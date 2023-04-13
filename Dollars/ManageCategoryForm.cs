using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollars
{
    public partial class ManageCategoryForm : Form, IChildForm
    {
        private DataTable m_dtCategory;
        public Action OnChildFormClosed { get; set; }

        public ManageCategoryForm()
        {
            InitializeComponent();

            m_dtCategory = new DataTable();
            m_dtCategory.Columns.Add("ID");
            m_dtCategory.Columns.Add("Category");

            ShowCategory();
        }

        private void ReloadDB()
        {
            DB.PrdCategoriesDB.Validate();
            ShowCategory();
        }

        private void ShowCategory()
        {
            cbParentCategory.Items.Clear();
            m_dtCategory.Rows.Clear();
            cbParentCategory.Items.Add("");
            foreach (ProductCategory cat in DB.PrdCategoriesDB.Categories)
            {
                m_dtCategory.Rows.Add(
                    cat.Id,
                    Utils.ConcatCategories(cat)
                );
                cbParentCategory.Items.Add(cat.Category);
            }

            dgvCategory.DataSource = m_dtCategory;

            dgvCategory.Columns["ID"].Width = 55;
            dgvCategory.Columns["Category"].Width = 549;
        }

        private bool IsParentCategoryValid(ProductCategory parent, ProductCategory child)
        {
            if (parent.Id == child.Id)
                return false;

            List<ProductCategory> children = DB.PrdCategoriesDB.GetChildren(child);
            foreach(ProductCategory cat in children)
            {
                if (cat.Category == parent.Category) return false;
            }

            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbCategoryID_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbCategoryID.Text = Utils.RemoveAllExceptNumbers(tbCategoryID.Text);
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedAccId = int.Parse(dgvCategory["ID", e.RowIndex].Value.ToString());
                ProductCategory cat = DB.PrdCategoriesDB.Get(selectedAccId);

                tbCategoryID.Text = cat.Id.ToString();
                tbCategory.Text = cat.Category;
                cbParentCategory.Text = DB.PrdCategoriesDB.Exists(cat.ParentCategoryID) ? cat.ParentCategory : "";
            }
        }

        private void OnSearchCategory(object sender, EventArgs e)
        {
            DataView dv = m_dtCategory.DefaultView;
            dv.RowFilter = string.Format("Category LIKE '%{0}%'", tbSearchCat.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCategory.Text))
            {
                MessageBox.Show("Please enter Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCategory.Focus();
                return;
            }

            ProductCategory newCat = new ProductCategory
            {
                Category = tbCategory.Text,
                ParentCategory = ""
            };
            ProductCategory newCatParent = DB.PrdCategoriesDB.Get(cbParentCategory.Text);
            if(newCatParent.Id > 0)
            {
                newCat.ParentCategory = newCatParent.Category;
                newCat.ParentCategoryID = newCatParent.Id;
            }

            int.TryParse(tbCategoryID.Text, out int id);
            if (DB.PrdCategoriesDB.Exists(id))
            {
                ProductCategory temp = DB.PrdCategoriesDB.Get(tbCategory.Text);
                if (temp.Id > 0 && id != temp.Id)
                {
                    MessageBox.Show("Category '" + tbCategory.Text + "' already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCategory.Focus();
                    return;
                }

                if (newCatParent.Id > 0 && !IsParentCategoryValid(newCatParent, DB.PrdCategoriesDB.Get(id)))
                {
                    MessageBox.Show("Parent category cannot be a child of " + tbCategory.Text + " or itself", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCategory.Focus();
                    return;
                }

                if (MessageBox.Show("Update Category #'" + tbCategoryID.Text + "'?", "Update Category",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    newCat.Id = id;
                    DB.PrdCategoriesDB.Update(newCat);
                    ReloadDB();
                }
            }
            else
            {
                if (DB.PrdCategoriesDB.Exists(tbCategory.Text))
                {
                    MessageBox.Show("Category '" + tbCategory.Text + "' already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCategory.Focus();
                    return;
                }

                DB.PrdCategoriesDB.Add(newCat);
                ReloadDB();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCategoryID.Text))
            {
                MessageBox.Show("Please enter Account ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCategoryID.Focus();
                return;
            }

            int.TryParse(tbCategoryID.Text, out int id);
            if (DB.PrdCategoriesDB.Exists(id))
            {
                if (MessageBox.Show("Delete Category #'" + tbCategoryID.Text + "'?", "Delete Category",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DB.DiscountDB.DeletingCategory(id);
                    DB.ProductsDB.DeletingCategory(id);
                    DB.DiscountDB.Validate();
                    DB.ProductsDB.Validate();

                    DB.PrdCategoriesDB.Delete(id);
                    ReloadDB();
                }
            }
            else
            {
                MessageBox.Show("Cannot find Id #'" + id + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageCategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }
    }
}
