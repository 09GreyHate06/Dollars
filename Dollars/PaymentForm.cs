using Guna.UI2.WinForms;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollars
{
    public partial class PaymentForm : Form, IChildForm
    {
        private static readonly int s_invoiceMaxCharPerLine = 49;

        private Cart m_cart;
        private double m_customerMoney;
        private Customer m_customer;
        private DateTime m_transactionDate;
        private List<Discount> m_pointsDiscount;

        private int m_printerItemIndex;

        public Action OnChildFormClosed { get; set; }
        public Action OnValidate { get; set; }

        public PaymentForm()
        {
            InitializeComponent();

            printInvoiceDialog.Size = new Size(600, 600);
            printInvoiceDialog.StartPosition = FormStartPosition.CenterScreen;

            tbCustomerMoney.Focus();
        }

        public void Init(Customer customer, Cart cart, DateTime transactionDate, List<Discount> pointsDiscount)
        {
            m_customer = customer;
            m_cart = cart;
            m_pointsDiscount = pointsDiscount;

            if (m_customer.Id > 0)
                lblCustomer.Text = m_customer.LastName;
            lblTotalDue.Text = Utils.DisplayCash(m_cart.Total);
            m_transactionDate = transactionDate;
            ShowInfos();
        }

        private void ShowInfos()
        {
            double.TryParse(tbCustomerMoney.Text, out m_customerMoney);
            lblCustomerMoney.Text = Utils.DisplayCash(m_customerMoney);
            lblCustomerRemainingPayment.Text = Utils.DisplayCash((m_cart.Total - m_customerMoney).Clamp(0.0, double.MaxValue));
            lblCustomerChange.Text = Utils.DisplayCash((m_customerMoney - m_cart.Total).Clamp(0.0, double.MaxValue));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            lblActivePayment.Text = "CASH";
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            lblActivePayment.Text = "BANK";
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            if (m_customer.Id <= 0) return;

            UseCustomerPointsForm form = new UseCustomerPointsForm();
            form.OnBtnOKClick += (double p) =>
            {
                m_customer.Points -= p;
                double.TryParse(tbCustomerMoney.Text, out double custMoney);
                tbCustomerMoney.Text = (custMoney + p).ToString();
            };
            form.Init(m_customer.Points);
            form.ShowDialog(this);
        }

        private void OnCalculatorBtnClick(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;

            if (btn.Text == "." && tbCustomerMoney.Text.Contains("."))
                return;

            if (btn.Text[0] == '+')
            {
                double.TryParse(tbCustomerMoney.Text, out double cur);

                if (btn.Text.Contains("10"))
                    cur += 10.0;
                else if (btn.Text.Contains("20"))
                    cur += 20.0;
                else if (btn.Text.Contains("50"))
                    cur += 50.0;


                tbCustomerMoney.Text = cur.ToString();
                return;
            }

            tbCustomerMoney.Text += btn.Text;
        }

        private void tbCustomerMoney_TextChanged(object sender, EventArgs e)
        {
            tbCustomerMoney.Text = Utils.RemoveAllExceptFloats(tbCustomerMoney.Text);

            double.TryParse(tbCustomerMoney.Text, out m_customerMoney);
            ShowInfos();
        }

        private void tbCustomerMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            // read dot only once
            if (e.KeyChar == '.' && tbCustomerMoney.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (tbCustomerMoney.Text.Length == 0) return;

            tbCustomerMoney.Text = tbCustomerMoney.Text.Substring(0, tbCustomerMoney.Text.Length - 1);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            // my printer(Brother DCP-T310) printable area
            //
            // size
            // hardMargin.xy = 11
            // x = 0; y = 0;
            // w = 850; h = 1100;
            //
            // printable area:
            // x = 11.6; y = 11.6;
            // w = 826.6; h = 1076.6;

            // invoice paper size
            // w = 80mm

            PrinterSettings settings;
            PageSettings pageSettings;
            bool hasPrinter = false;
            foreach(var printer in PrinterSettings.InstalledPrinters)
            {
                settings = new PrinterSettings();
                settings.PrinterName = printer.ToString();
                if (settings.IsDefaultPrinter)
                {
                    pageSettings = settings.DefaultPageSettings;
                    hasPrinter = true;
                }
            }

            if (!hasPrinter)
            {
                MessageBox.Show("No printer installed", "Printing Invoice Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m_printerItemIndex = 0;
            printInvoice.DefaultPageSettings.PaperSize = new PaperSize("A4", 302, 1100);
            printInvoiceDialog.Document = printInvoice;
            printInvoiceDialog.ShowDialog();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            // update products
            foreach(CartProduct prd in m_cart.Products)
                DB.ProductsDB.AddQuantity(prd.Product.Id, -prd.Qty);
            DB.ProductsDB.Validate();

            // update customer
            if(m_customer.Id > 0)
            {
                double points = 0.0;
                foreach(Discount d in m_pointsDiscount)
                {
                    if (d.ApplyDiscountOn == Discount.ApplyOn.Product)
                    {
                        int min = m_cart.GetCartProduct(d.ApplyOnID).Qty;

                        if (d.Min > min) continue;

                        points += d.Value * Math.Floor(min / d.Min);
                    }
                    else if (d.ApplyDiscountOn == Discount.ApplyOn.Category)
                    {
                        double min = m_cart.GetTotalFromCategory(DB.PrdCategoriesDB.Get(d.ApplyOnID));

                        if (d.Min > min) continue;

                        points += d.Value * Math.Floor(min / d.Min);
                    }
                    else
                    {
                        if (d.Min > m_cart.Total) continue;
                        points += d.Value * Math.Floor(m_cart.Total / d.Min);
                    }
                }

                m_customer.Points += points;
                m_customer.AmountSpent += m_cart.Total;
                DB.CustomersDB.Update(m_customer);
                DB.CustomersDB.Validate();
            }

            // todo save transaction history
            Transaction transaction = new Transaction
            {
                Number = StoreInfo.Active.TotalTransactions + 1,
                CashierID = Account.Active.Id,
                CashierName = Utils.ConcatFullname(Account.Active.FirstName, Account.Active.MiddleInitial, Account.Active.LastName),
                CustomerID = m_customer.Id,
                CustomerName = Utils.ConcatFullname(m_customer.FirstName, m_customer.MiddleInitial, m_customer.LastName),
                Date = m_transactionDate,
                Subtotal = m_cart.Total
            };
            DB.TransactionsDB.Add(transaction);
            DB.TransactionsDB.Validate();

            // update store info
            var storeInfo = StoreInfo.Active;
            storeInfo.TotalTransactions += 1;
            storeInfo.TotalSales += m_cart.Total;
            DB.StoreInfoDB.Update(storeInfo);
            DB.StoreInfoDB.Validate();

            OnValidate?.Invoke();
            Close();
        }

        private void printInvoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font title = new Font("Arial Narrow", 9, FontStyle.Bold);
            Font defaultFont = new Font("Arial Narrow", 8, FontStyle.Regular);

            StringFormat centerFormat = new StringFormat();
            StringFormat rightFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            rightFormat.Alignment = StringAlignment.Far;

            int itemDefHeight = 14;
            int curLine = 1;
            Point startLoc = new Point(12, 15);

            int idWidth = 31;
            int nameWidth= 137;
            int qtyWidth = 35;
            int priceWidth = 57;
            int idPosX = startLoc.X;
            int namePosX = 43;
            int qtyPosX = 180;
            int pricePosX = 225;

            int curPosY = startLoc.X;

            // prints store name and address and headers
            if (m_printerItemIndex == 0)
            {
                e.Graphics.DrawString(StoreInfo.Active.Name.ToUpper(), title, Brushes.RoyalBlue, new Rectangle(0, curPosY, 302, itemDefHeight), centerFormat);
                int addressMaxLine = 3;
                string address = StoreInfo.Active.Address;
                if (address.Length > s_invoiceMaxCharPerLine)
                {
                    List<string> addressSplit = new List<string>(StoreInfo.Active.Address.Split(' '));
                    for(int i = 1; i < addressSplit.Count; i++)
                    {
                        address = InvoiceGetSubstring(addressSplit, i);

                        if (address.Length > s_invoiceMaxCharPerLine) continue;

                        e.Graphics.DrawString(address.ToUpper(), title, Brushes.RoyalBlue, new Rectangle(0, startLoc.Y + itemDefHeight * curLine++, 302, itemDefHeight), centerFormat);
                        if (curLine > addressMaxLine) break;
                        addressSplit.RemoveRange(0, addressSplit.Count - i);
                        i = -1;
                    }
                }
                else
                {
                    e.Graphics.DrawString(address.ToUpper(), title, Brushes.RoyalBlue, new Rectangle(0, startLoc.Y + itemDefHeight * curLine, 302, itemDefHeight), centerFormat);
                }

                curLine = 4;

                e.Graphics.DrawString("CONTACT NO: " + StoreInfo.Active.ContactNo, defaultFont, Brushes.RoyalBlue, 
                    new Rectangle(startLoc.X, startLoc.Y + itemDefHeight * curLine++, 270, itemDefHeight));
                e.Graphics.DrawString("EMAIL: " + StoreInfo.Active.Email, defaultFont, Brushes.RoyalBlue, 
                    new Rectangle(startLoc.X, startLoc.Y + itemDefHeight * curLine++, 270, itemDefHeight));
                string cashier = Utils.ConcatFullname(Account.Active.FirstName, Account.Active.MiddleInitial, Account.Active.LastName) + "#" + Account.Active.Id;
                e.Graphics.DrawString("CASHIER: " + cashier.ToUpper(), defaultFont, Brushes.RoyalBlue, 
                    new Rectangle(startLoc.X, startLoc.Y + itemDefHeight * curLine++, 270, itemDefHeight));
                e.Graphics.DrawString("DATE: " + m_transactionDate.ToString("g"), defaultFont, Brushes.RoyalBlue, 
                    new Rectangle(startLoc.X, startLoc.Y + itemDefHeight * curLine++, 270, itemDefHeight));
                e.Graphics.DrawString("TRANSACTION NO: #" + (StoreInfo.Active.TotalTransactions + 1).ToString(), defaultFont, Brushes.RoyalBlue,
                    new Rectangle(startLoc.X, startLoc.Y + itemDefHeight * curLine++, 270, itemDefHeight));

                curLine++;

                curPosY = startLoc.Y + itemDefHeight * curLine;
                e.Graphics.DrawString("ID", defaultFont, Brushes.RoyalBlue,
                    new Rectangle(idPosX, curPosY, idWidth, itemDefHeight));
                e.Graphics.DrawString("NAME", defaultFont, Brushes.RoyalBlue,
                    new Rectangle(namePosX, curPosY, nameWidth, itemDefHeight));
                e.Graphics.DrawString("QTY", defaultFont, Brushes.RoyalBlue,
                    new Rectangle(qtyPosX, curPosY, qtyWidth, itemDefHeight), rightFormat);
                e.Graphics.DrawString("PRICE", defaultFont, Brushes.RoyalBlue,
                    new Rectangle(pricePosX, curPosY, priceWidth, itemDefHeight), rightFormat);
            }

            
            curLine++;
            for( ; m_printerItemIndex < m_cart.Products.Count; m_printerItemIndex++)
            {
                curPosY = startLoc.Y + itemDefHeight * curLine;
                if(curPosY > e.MarginBounds.Bottom - itemDefHeight)
                {
                    e.HasMorePages = true;
                    return;
                }

                CartProduct prd = m_cart.Products[m_printerItemIndex];
                e.Graphics.DrawString(prd.Product.Id.ToString(), defaultFont, Brushes.RoyalBlue,
                    new Rectangle(idPosX, curPosY, idWidth, itemDefHeight));
                e.Graphics.DrawString(prd.Product.Name.ToUpper(), defaultFont, Brushes.RoyalBlue,
                    new Rectangle(namePosX, curPosY, nameWidth, itemDefHeight));
                e.Graphics.DrawString(prd.Qty.ToString(), defaultFont, Brushes.RoyalBlue,
                    new Rectangle(qtyPosX, curPosY, qtyWidth, itemDefHeight), rightFormat);
                e.Graphics.DrawString(Utils.DisplayCash(prd.Subtotal), defaultFont, Brushes.RoyalBlue,
                    new Rectangle(pricePosX, curPosY, priceWidth, itemDefHeight), rightFormat);

                curLine++;
            }

            int lblWidth = 185;
            int dashPosX = 84;
            int dashWidth = 96;
            int valuePosX = 182;
            int valueWidth = 100;


            curLine++;
            for (int i = 0; i < 4; i++)
            {
                e.Graphics.DrawString("- - - - - - - - - - - - - - -", defaultFont, Brushes.RoyalBlue,
                    new Rectangle(dashPosX, startLoc.Y + itemDefHeight * (curLine + i), dashWidth, itemDefHeight));
            }

            curPosY = startLoc.Y + itemDefHeight * curLine;
            e.Graphics.DrawString("SUB-TOTAL", defaultFont, Brushes.RoyalBlue,
                new Rectangle(startLoc.X, curPosY, lblWidth, itemDefHeight));
            e.Graphics.DrawString(Utils.DisplayCash(m_cart.Total), defaultFont, Brushes.RoyalBlue,
                new Rectangle(valuePosX, curPosY, valueWidth, itemDefHeight), rightFormat);


            curPosY = startLoc.Y + itemDefHeight * ++curLine;
            e.Graphics.DrawString("AMOUNT DUE", defaultFont, Brushes.RoyalBlue,
                new Rectangle(startLoc.X, curPosY, lblWidth, itemDefHeight));
            e.Graphics.DrawString(Utils.DisplayCash(m_cart.Total), defaultFont, Brushes.RoyalBlue,
                new Rectangle(valuePosX, curPosY, valueWidth, itemDefHeight), rightFormat);


            curPosY = startLoc.Y + itemDefHeight * ++curLine;
            e.Graphics.DrawString("CASH", defaultFont, Brushes.RoyalBlue,
                new Rectangle(startLoc.X, curPosY, lblWidth, itemDefHeight));
            e.Graphics.DrawString(lblCustomerMoney.Text, defaultFont, Brushes.RoyalBlue,
                new Rectangle(valuePosX, curPosY, valueWidth, itemDefHeight), rightFormat);


            curPosY = startLoc.Y + itemDefHeight * ++curLine;
            e.Graphics.DrawString("CHANGE", defaultFont, Brushes.RoyalBlue,
                new Rectangle(startLoc.X, curPosY, lblWidth, itemDefHeight));
            e.Graphics.DrawString(lblCustomerChange.Text, defaultFont, Brushes.RoyalBlue,
                new Rectangle(valuePosX, curPosY, valueWidth, itemDefHeight), rightFormat);


            curLine += 2;
            for (int i = 0; i < 3; i++)
            {
                e.Graphics.DrawString("- - - - - - - - - - - - - - -", defaultFont, Brushes.RoyalBlue,
                    new Rectangle(dashPosX, startLoc.Y + itemDefHeight * (curLine + i), dashWidth, itemDefHeight));
            }

            curPosY = startLoc.Y + itemDefHeight * curLine;
            double discount = m_cart.TotalNoDiscount - m_cart.Total;
            double vat = m_cart.Total * StoreInfo.Active.Vat * 0.01;
            double vatable = m_cart.Total - vat;

            e.Graphics.DrawString("DISCOUNT", defaultFont, Brushes.RoyalBlue,
                new Rectangle(startLoc.X, curPosY, lblWidth, itemDefHeight));
            e.Graphics.DrawString(Utils.DisplayCash(discount), defaultFont, Brushes.RoyalBlue,
                new Rectangle(valuePosX, curPosY, valueWidth, itemDefHeight), rightFormat);


            curPosY = startLoc.Y + itemDefHeight * ++curLine;
            e.Graphics.DrawString("VAT(" + Utils.DisplayCash(StoreInfo.Active.Vat) + "%)", defaultFont, Brushes.RoyalBlue,
                new Rectangle(startLoc.X, curPosY, lblWidth, itemDefHeight));
            e.Graphics.DrawString(Utils.DisplayCash(vat), defaultFont, Brushes.RoyalBlue,
                new Rectangle(valuePosX, curPosY, valueWidth, itemDefHeight), rightFormat);


            curPosY = startLoc.Y + itemDefHeight * ++curLine;
            e.Graphics.DrawString("VATABLE", defaultFont, Brushes.RoyalBlue,
                new Rectangle(startLoc.X, curPosY, lblWidth, itemDefHeight));
            e.Graphics.DrawString(Utils.DisplayCash(vatable), defaultFont, Brushes.RoyalBlue,
                new Rectangle(valuePosX, curPosY, valueWidth, itemDefHeight), rightFormat);


            curLine += 2;
            lblWidth = 270;
            string custName = Utils.ConcatFullname(m_customer.FirstName, m_customer.MiddleInitial, m_customer.LastName) + "#" + m_customer.Id;
            e.Graphics.DrawString("BUYER'S NAME: " + (m_customer.Id > 0 ? custName.ToUpper() : ""), defaultFont, Brushes.RoyalBlue,
                new Rectangle(startLoc.X, startLoc.Y + itemDefHeight * curLine++, lblWidth, itemDefHeight));
            e.Graphics.DrawString("BUYER'S CONTACT#: " + m_customer.ContactNo, defaultFont, Brushes.RoyalBlue,
                new Rectangle(startLoc.X, startLoc.Y + itemDefHeight * curLine++, lblWidth, itemDefHeight));
            e.Graphics.DrawString("BUYER'S EMAIL: " + m_customer.Email, defaultFont, Brushes.RoyalBlue,
                new Rectangle(startLoc.X, startLoc.Y + itemDefHeight * curLine++, lblWidth, itemDefHeight));
        }

        private string InvoiceGetSubstring(List<string> spl, int offsetFromLast) 
        {
            string res = "";
            for(int i = 0; i < spl.Count - offsetFromLast; i++)
            {
                if(i == (spl.Count - offsetFromLast - 1))
                    res += spl[i];
                else
                    res += spl[i] + " ";
            }

            return res;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // https://stackoverflow.com/questions/3172731/forms-not-responding-to-keydown-events

            switch (keyData)
            {
                case Keys.F1:
                    btnCash_Click(null, null);
                    return true;

                case Keys.F2:
                    btnBank_Click(null, null);
                    return true;

                case Keys.F3:
                    btnPoints_Click(null, null);
                    return true;

                case Keys.F4:
                    btnInvoice_Click(null, null);
                    return true;

                case Keys.F5:
                    btnValidate_Click(null, null);
                    return true;

                case Keys.Escape:
                    btnExit_Click(null, null);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= Utils.CS_DROPSHADOW;
                return cp;
            }
        }
    }
}
