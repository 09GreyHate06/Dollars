using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollars
{
    public partial class ReportForm : Form, IChildForm
    {
        private bool m_isStockInHistoryLoaded = false;
        private bool m_isCriticalStocksLoaded = false;
        private List<Product> m_criticalStock;

        private DataTable m_dtTransactions;
        private DataTable m_dtStockInHistory;

        public Action OnChildFormClosed { get; set; }

        public ReportForm()
        {
            InitializeComponent();

        }

        public void Init(List<Product> criticalStocks)
        {
            m_criticalStock = criticalStocks;
            ShowTransactions();
        }

        private void ShowTransactions()
        {
            lblTotalTransactions.Text = "Total Transactions: " + StoreInfo.Active.TotalTransactions.ToString();
            lblTotalSales.Text = "Total Sales: " + Utils.DisplayCash(StoreInfo.Active.TotalSales);

            m_dtTransactions = new DataTable();
            m_dtTransactions.Columns.Add("No.");
            m_dtTransactions.Columns.Add("Cashier ID");
            m_dtTransactions.Columns.Add("Cashier Name");
            m_dtTransactions.Columns.Add("Customer ID");
            m_dtTransactions.Columns.Add("Customer Name");
            m_dtTransactions.Columns.Add("Date");
            m_dtTransactions.Columns.Add("Subtotal");

            foreach(Transaction transaction in DB.TransactionsDB.Transactions)
            {
                m_dtTransactions.Rows.Add(
                    transaction.Number,
                    transaction.CashierID,
                    transaction.CashierName,
                    transaction.CustomerID,
                    transaction.CustomerName,
                    transaction.Date.ToString("g"),
                    Utils.DisplayCash(transaction.Subtotal)
                    );
            }

            dgvTransactions.DataSource = m_dtTransactions;

            dgvTransactions.Columns["No."].Width = 38;
            dgvTransactions.Columns["Cashier ID"].Width = 76;
            dgvTransactions.Columns["Cashier Name"].Width = 191;
            dgvTransactions.Columns["Customer ID"].Width = 86;
            dgvTransactions.Columns["Customer Name"].Width = 191;
            dgvTransactions.Columns["Date"].Width = 191;
            dgvTransactions.Columns["Subtotal"].Width = 95;

            dgvTransactions.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ShowStockInHistory()
        {
            m_dtStockInHistory = new DataTable();
            m_dtStockInHistory.Columns.Add("Product ID");
            m_dtStockInHistory.Columns.Add("Product Name");
            m_dtStockInHistory.Columns.Add("Product Category");
            m_dtStockInHistory.Columns.Add("Quantity");
            m_dtStockInHistory.Columns.Add("Stock in Date");

            foreach(StockInInfo info in DB.StockInHistoryDB.StockInHistory)
            {
                m_dtStockInHistory.Rows.Add(
                    info.ProductID,
                    info.ProductName,
                    info.ProductCategory,
                    info.Qty,
                    info.StockInDate.ToString("d")
                    );
            }

            dgvStockInHistory.DataSource = m_dtStockInHistory;
            dgvStockInHistory.Columns["Product ID"].Width = 109;
            dgvStockInHistory.Columns["Product Name"].Width = 271;
            dgvStockInHistory.Columns["Product Category"].Width = 271;
            dgvStockInHistory.Columns["Quantity"].Width = 109;
            dgvStockInHistory.Columns["Stock in Date"].Width = 108;

            //dgvStockInHistory.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ShowCriticalStocks()
        {
            dgvCriticalStocks.Rows.Clear();
            dgvCriticalStocksCUnitPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCriticalStocksCStock.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach(Product prd in m_criticalStock)
            {
                dgvCriticalStocks.Rows.Add(
                    prd.Id,
                    prd.Name,
                    Utils.ConcatCategories(prd.Category),
                    Utils.DisplayCash(prd.UnitPrice),
                    prd.Qty
                    );
            }

            lblCriticalStocks.Text = "Critical Stocks: " + m_criticalStock.Count;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnSearchBarChanged(object sender, EventArgs e)
        {
            tbSearchTransByNo.Text = Utils.RemoveAllExceptNumbers(tbSearchTransByNo.Text);

            DataView dv = m_dtTransactions.DefaultView;

            bool searchCashierByID = int.TryParse(tbSearchTransByCashier.Text, out _);
            bool searchCustomerByID = int.TryParse(tbSearchTransByCustomer.Text, out _);

            if(searchCashierByID && searchCustomerByID)
            {
                dv.RowFilter = string.Format("[No.] LIKE '%{0}%' AND [Cashier ID] LIKE '%{1}%' AND [Customer ID] LIKE '%{2}%'",
                    tbSearchTransByNo.Text, tbSearchTransByCashier.Text, tbSearchTransByCustomer.Text);
            }
            else if(!searchCashierByID && !searchCustomerByID)
            {
                dv.RowFilter = string.Format("[No.] LIKE '%{0}%' AND [Cashier Name] LIKE '%{1}%' AND [Customer Name] LIKE '%{2}%'",
                    tbSearchTransByNo.Text, tbSearchTransByCashier.Text, tbSearchTransByCustomer.Text);
            }
            else if (!searchCashierByID && searchCustomerByID)
            {
                dv.RowFilter = string.Format("[No.] LIKE '%{0}%' AND [Cashier Name] LIKE '%{1}%' AND [Customer ID] LIKE '%{2}%'",
                    tbSearchTransByNo.Text, tbSearchTransByCashier.Text, tbSearchTransByCustomer.Text);
            }
            else if (searchCashierByID && !searchCustomerByID)
            {
                dv.RowFilter = string.Format("[No.] LIKE '%{0}%' AND [Cashier ID] LIKE '%{1}%' AND [Customer Name] LIKE '%{2}%'",
                    tbSearchTransByNo.Text, tbSearchTransByCashier.Text, tbSearchTransByCustomer.Text);
            }
        }

        private void tcReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcReports.SelectedIndex == 1 && !m_isStockInHistoryLoaded)
            {
                ShowStockInHistory();
                m_isStockInHistoryLoaded = true;
            }
            else if(tcReports.SelectedIndex == 2 && !m_isCriticalStocksLoaded)
            {
                ShowCriticalStocks();
                m_isCriticalStocksLoaded = true;
            }
        }

        private void tbSearchPrd_TextChanged(object sender, EventArgs e)
        {
            DataView dv = m_dtStockInHistory.DefaultView;

            if (int.TryParse(tbSearchPrd.Text, out _))
                dv.RowFilter = string.Format("[Product ID] LIKE '%{0}%'", tbSearchPrd.Text);
            else
                dv.RowFilter = string.Format("[Product Name] LIKE '%{0}%'", tbSearchPrd.Text);
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }
    }
}
