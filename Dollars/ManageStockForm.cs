using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Dollars
{
    public partial class ManageStockForm : Form, IChildForm
    {
        private DataTable m_dtPrd;

        public Action OnChildFormClosed { get; set; }

        public ManageStockForm()
        {
            InitializeComponent();

            m_dtPrd = new DataTable();
            m_dtPrd.Columns.Add("ID");
            m_dtPrd.Columns.Add("Name");
            m_dtPrd.Columns.Add("Quantity");

            dpStockInDate.Value = DateTime.Now;
            ShowProducts();
        }

        private void ShowProducts()
        {
            m_dtPrd.Rows.Clear();
            foreach (Product product in DB.ProductsDB.Products)
            {
                m_dtPrd.Rows.Add(
                    product.Id,
                    product.Name,
                    product.Qty
                    );
            }

            dgvPrd.DataSource = m_dtPrd;

            dgvPrd.Columns["ID"].Width = 44;
            dgvPrd.Columns["Name"].Width = 293;
            dgvPrd.Columns["Quantity"].Width = 73;
        }

        private void ReloadDB()
        {
            DB.ProductsDB.Validate();
            DB.StockInHistoryDB.Validate();
            ShowProducts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbQuantity.Text = Utils.RemoveAllExceptNumbers(tbQuantity.Text);
        }

        private void dgvPrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbPrdID.Text = dgvPrd["ID", e.RowIndex].Value.ToString();
                tbPrdName.Text = dgvPrd["Name", e.RowIndex].Value.ToString();
            }
        }

        private void OnSearchProduct(object sender, EventArgs e)
        {
            DataView dv = m_dtPrd.DefaultView;
            dv.RowFilter = string.Format("Name LIKE '%{0}%'", tbSearchPrd.Text);
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPrdID.Text))
            {
                MessageBox.Show("Please select a product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int.TryParse(tbQuantity.Text, out int qty);
            if(qty == 0)
            {
                MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbQuantity.Focus();
                return;
            }

            bool exists = false;
            foreach(DataGridViewRow row in dgvStockInHistory.Rows)
            {
                if (row.Cells[dgvStockInPrdID.Name].Value.ToString() == tbPrdID.Text)
                {
                    int.TryParse(row.Cells[dgvStockInQuantity.Name].Value.ToString(), out int curQty);
                    row.Cells[dgvStockInQuantity.Name].Value = curQty + qty;
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                dgvStockInHistory.Rows.Add(
                    tbPrdID.Text,
                    tbPrdName.Text,
                    tbQuantity.Text,
                    dpStockInDate.Value.ToString("d"),
                    "Delete"
                    );
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbPrdID.Text = "";
            tbPrdName.Text = "";
            tbQuantity.Text = "";
        }

        private void btnClearStockIn_Click(object sender, EventArgs e)
        {
            dgvStockInHistory.Rows.Clear();
        }

        private void dgvStockInHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStockInHistory.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                dgvStockInHistory.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnSaveStockIn_Click(object sender, EventArgs e)
        {
            if (dgvStockInHistory.Rows.Count == 0) return;

            foreach(DataGridViewRow row in dgvStockInHistory.Rows)
            {
                int.TryParse(row.Cells[dgvStockInPrdID.Name].Value.ToString(), out int id);
                string name = row.Cells[dgvStockInPrdName.Name].Value.ToString();
                string productCategory = Utils.ConcatCategories(DB.ProductsDB.Get(id).Category);
                int.TryParse(row.Cells[dgvStockInQuantity.Name].Value.ToString(), out int qty);
                DateTime date = DateTime.ParseExact(row.Cells[dgvStockInDate.Name].Value.ToString(), "d", null);

                StockInInfo stockInInfo = new StockInInfo
                {
                    ProductID = id,
                    ProductName = name,
                    ProductCategory = productCategory,
                    Qty = qty,
                    StockInDate = date
                };
                DB.ProductsDB.AddQuantity(id, qty);
                DB.StockInHistoryDB.Add(stockInInfo);
            }

            dgvStockInHistory.Rows.Clear();
            ReloadDB();

            MessageBox.Show("Stocks Added", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ManageStockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }
    }
}
