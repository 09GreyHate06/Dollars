using Dollars.Properties;
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
    public partial class ManageProductForm : Form, IChildForm
    {
        private DataTable m_dtProduct;

        public Action OnChildFormClosed { get; set; }

        public ManageProductForm()
        {
            InitializeComponent();

            m_dtProduct = new DataTable();
            m_dtProduct.Columns.Add("ID");
            m_dtProduct.Columns.Add("Name");
            m_dtProduct.Columns.Add("Category");
            m_dtProduct.Columns.Add("Unit Price");

            SetCategory();
            ShowProducts();
        }

        private void SetCategory()
        {
            cbPrdCat.Items.Clear();
            cbSearchPrdByCat.Items.Clear();

            cbPrdCat.Items.Add("");
            cbSearchPrdByCat.Items.Add("");
            foreach (ProductCategory cat in DB.PrdCategoriesDB.Categories)
            {
                cbPrdCat.Items.Add(cat.Category);
                cbSearchPrdByCat.Items.Add(cat.Category);
            }
        }

        private void ShowProducts()
        {
            m_dtProduct.Rows.Clear();
            foreach(Product product in DB.ProductsDB.Products)
            {
                m_dtProduct.Rows.Add(
                    product.Id,
                    product.Name,
                    Utils.ConcatCategories(product.Category),
                    Utils.DisplayCash(product.UnitPrice)
                    );
            }

            dgvProduct.DataSource = m_dtProduct;

            dgvProduct.Columns["ID"].Width = 48;
            dgvProduct.Columns["Name"].Width = 242;
            dgvProduct.Columns["Category"].Width = 193;
            dgvProduct.Columns["Unit Price"].Width = 121;
            dgvProduct.Columns["Unit Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ReloadDB()
        {
            DB.ProductsDB.Validate();
            ShowProducts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPrdID_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbPrdID.Text = Utils.RemoveAllExceptNumbers(tbPrdID.Text);
        }

        private void tbPrdUnitPrice_TextChanged(object sender, EventArgs e)
        {
            // only allow floating point numbers
            tbPrdUnitPrice.Text = Utils.RemoveAllExceptFloats(tbPrdUnitPrice.Text);
        }

        private void tbPrdUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // read dot only once
            if (e.KeyChar == '.' && tbPrdUnitPrice.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnBrowsePrdImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Browse Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "Images (*.PNG;*.JPG;*.BMP;*.TIFF)|*.PNG;*.JPG;*.BMP;*.TIFF | All files (*.*)|*.*",
                FilterIndex = 0,

                RestoreDirectory = true,
            };

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(fileDialog.FileName);
                pbPrdImage.Image = image;
            }
        }

        private void btnClearPrdImage_Click(object sender, EventArgs e)
        {
            pbPrdImage.Image = ImageRes.default_image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPrdName.Text))
            {
                MessageBox.Show("Please enter Product Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrdName.Focus();
                return;
            }

            double.TryParse(tbPrdUnitPrice.Text, out double unitPrice);

            ProductCategory newPrdCat = DB.PrdCategoriesDB.Get(cbPrdCat.Text);
            Product newPrd = new Product
            {
                Name = tbPrdName.Text,
                Category = newPrdCat.Id > 0 ? newPrdCat : new ProductCategory(),
                UnitPrice = unitPrice,
                Image = pbPrdImage.Image
            };

            int.TryParse(tbPrdID.Text, out int id);
            Product oldPrd = DB.ProductsDB.Get(id);
            if (oldPrd.Id > 0)
            {
                if (MessageBox.Show("Update Product #'" + tbPrdID.Text + "'?", "Update Product",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    newPrd.Id = id;
                    newPrd.Qty = oldPrd.Qty;
                    DB.ProductsDB.Update(newPrd);
                    ReloadDB();
                }
            }
            else
            {
                DB.ProductsDB.Add(newPrd);
                ReloadDB();
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedAccId = int.Parse(dgvProduct["ID", e.RowIndex].Value.ToString());
                Product prd = DB.ProductsDB.Get(selectedAccId);

                tbPrdID.Text = prd.Id.ToString();
                tbPrdName.Text = prd.Name;
                cbPrdCat.Text = prd.Category.Category;
                tbPrdUnitPrice.Text = Utils.DisplayCash(prd.UnitPrice);
                pbPrdImage.Image = prd.Image;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPrdID.Text))
            {
                MessageBox.Show("Please enter Product ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrdID.Focus();
                return;
            }

            int.TryParse(tbPrdID.Text, out int id);
            if (DB.ProductsDB.Exists(id))
            {
                if (MessageBox.Show("Delete Product #'" + tbPrdID.Text + "'?", "Delete Product",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DB.DiscountDB.DeletingProduct(id);
                    DB.DiscountDB.Validate();

                    DB.ProductsDB.Delete(id);
                    ReloadDB();
                }
            }
            else
            {
                MessageBox.Show("Cannot find Id #'" + id + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnSearchProduct(object sender, EventArgs e)
        {
            DataView dv = m_dtProduct.DefaultView;

            if (cbSearchPrdByCat.Text == "")
                dv.RowFilter = string.Format("Name LIKE '%{0}%'", tbSearchPrd.Text);
            else
                dv.RowFilter = string.Format("Name LIKE '%{0}%' AND Category LIKE '%{1}%'", tbSearchPrd.Text, cbSearchPrdByCat.Text);
        }

        private void ManageProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }
    }
}
