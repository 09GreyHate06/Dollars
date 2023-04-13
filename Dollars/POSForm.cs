using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollars
{
    
    public partial class POSForm : Form, IChildForm
    {
        private bool m_windowDragging = false;
        private Point m_windowDragOffset;

        private List<Product> m_curProducts;

        private List<Discount> m_activeDiscounts;

        private Customer m_selectedCustomer;

        private Cart m_cart;

        public Action OnChildFormClosed { get; set; }

        public POSForm()
        {
            InitializeComponent();

            CenterToScreen();

            dgvColumnUnitPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvColumnDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvColumnSubtotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvColumnQuantity.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Reset();
        }

        private void Reset()
        {
            m_activeDiscounts = new List<Discount>();
            m_curProducts = DB.ProductsDB.CopyProducts();
            m_selectedCustomer = new Customer();
            btnCustomer.Text = "[F1] CUSTOMER";

            lblTodayDate.Text = DateTime.Now.ToString("F");
            lblDesignation.Text = Account.Active.AccRole.ToString();
            string userFullName = Utils.ConcatFullname(Account.Active.FirstName, Account.Active.MiddleInitial, Account.Active.LastName);
            lblCashierName.Text = userFullName;

            m_cart = new Cart();
            lblTransactionNo.Text = (StoreInfo.Active.TotalTransactions + 1).ToString();

            GetPreActivedDiscounts();
        }

        private void GetPreActivedDiscounts()
        {
            foreach(Discount discount in DB.DiscountDB.Discounts)
            {
                if (!discount.ApplyAutomatically) continue;

                if(discount.StartDate.Ticks < DateTime.Now.Ticks && DateTime.Now.Ticks < discount.EndDate.Ticks)
                    m_activeDiscounts.Add(discount);
            }
        }

        private void ShowCart()
        {
            dgvCart.Rows.Clear();
            foreach(CartProduct cb in m_cart.Products)
            {
                dgvCart.Rows.Add(
                    cb.Product.Id,
                    cb.Product.Name,
                    Utils.DisplayCash(cb.Product.UnitPrice),
                    cb.Qty,
                    Utils.DisplayCash(cb.Discount),
                    Utils.DisplayCash(cb.Subtotal)
                    );
            }
        }

        private void ShowCartInfos()
        {
            double vat = m_cart.Total * StoreInfo.Active.Vat * 0.01;

            lblTotal.Text = Utils.DisplayCash(m_cart.Total).ToString();
            lblTotalDiscount.Text = Utils.DisplayCash(m_cart.TotalNoDiscount - m_cart.Total);
            lblTotalVat.Text = Utils.DisplayCash(vat);
            lblTotalVatable.Text = Utils.DisplayCash(m_cart.Total - vat);
        }

        private void AddToCart(Product product, int qty)
        {
            if (qty == 0) return;
            
            CartProduct cb = new CartProduct(product, qty);
            m_cart.AddToCart(cb);
            m_cart.ApplyDiscounts(m_activeDiscounts);

            ShowCart();
            ShowCartInfos();
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearchPrd_Click(object sender, EventArgs e)
        {
            SearchProductForm form = new SearchProductForm();

            form.Init(m_curProducts, true);
            form.OnProductSelectedQty += AddToCart;
            form.ShowDialog(this);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            EnableDiscountForm form = new EnableDiscountForm();

            form.Init(m_activeDiscounts);
            form.ShowDialog(this);

            m_cart.ApplyDiscounts(m_activeDiscounts);
            ShowCart();
            ShowCartInfos();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomerForm form = new SearchCustomerForm();

            form.OnCustomerSelected += (Customer c) => 
            { 
                m_selectedCustomer = c;
                if (c.Id > 0)
                    btnCustomer.Text = "[F1] " + c.LastName.ToUpper();
                else
                    btnCustomer.Text = "[F1] CUSTOMER";

                form.Close(); 
            };

            form.ShowDialog(this);
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            m_cart = new Cart();
            dgvCart.Rows.Clear();
            m_curProducts = DB.ProductsDB.CopyProducts();

            tbPrdID.Text = "";
            tbPrdName.Text = "";
            tbPrdQty.Text = "";
            tbPrdDiscount.Text = "";
            tbPrdSubtotal.Text = "";

            lblTotalDiscount.Text = "0.00";
            lblTotalVat.Text = "0.00";
            lblTotalVatable.Text = "0.00";
            lblTotal.Text = "0.00";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            PaymentForm form = new PaymentForm();
            form.OnValidate += () =>
            {
                btnClearCart_Click(null, null);
                Reset();
            };

            List<Discount> pointsDiscount = new List<Discount>();
            foreach(Discount d in m_activeDiscounts)
            {
                if (d.DiscountType != Discount.Type.Points) continue;

                pointsDiscount.Add(d);
            }

            form.Init(m_selectedCustomer, m_cart, DateTime.ParseExact(lblTodayDate.Text, "F", null), pointsDiscount);
            form.ShowDialog(this);
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbPrdID.Text = dgvCart[dgvColumnID.Index, e.RowIndex].Value.ToString();
                tbPrdName.Text = dgvCart[dgvColumnName.Index, e.RowIndex].Value.ToString();
                tbPrdUnitPrice.Text = dgvCart[dgvColumnUnitPrice.Index, e.RowIndex].Value.ToString();
                tbPrdQty.Text = dgvCart[dgvColumnQuantity.Index, e.RowIndex].Value.ToString();
                tbPrdDiscount.Text = dgvCart[dgvColumnDiscount.Index, e.RowIndex].Value.ToString();
                tbPrdSubtotal.Text = dgvCart[dgvColumnSubtotal.Index, e.RowIndex].Value.ToString();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // https://stackoverflow.com/questions/3172731/forms-not-responding-to-keydown-events

            switch (keyData)
            {
                case Keys.F1:
                    btnCustomer_Click(null, null);
                    return true;

                case Keys.F2:
                    btnDiscount_Click(null, null);
                    return true;

                case Keys.F3:
                    btnSearchPrd_Click(null, null);
                    return true;

                case Keys.F4:
                    btnPayment_Click(null, null);
                    return true;

                case Keys.F5:
                    btnClearCart_Click(null, null);
                    return true;

                case Keys.F6:
                    btnEndSession_Click(null, null);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void POSForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            m_windowDragging = true;
            m_windowDragOffset = e.Location;
        }

        private void pnlMenu_MouseUp(object sender, MouseEventArgs e)
        {
            m_windowDragging = false;
        }

        private void pnlMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!m_windowDragging) return;

            Point curScreenPos = PointToScreen(e.Location);
            Location = new Point(curScreenPos.X - m_windowDragOffset.X, curScreenPos.Y - m_windowDragOffset.Y);
        }
    }
}
