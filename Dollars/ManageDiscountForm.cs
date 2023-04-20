using Guna.UI2.WinForms;
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
    public partial class ManageDiscountForm : Form, IChildForm
    {
        private DataTable m_dtDiscounts;

        public Action OnChildFormClosed { get; set; }

        public ManageDiscountForm()
        {
            InitializeComponent();

            m_dtDiscounts = new DataTable();
            m_dtDiscounts.Columns.Add("ID");
            m_dtDiscounts.Columns.Add("Name");
            m_dtDiscounts.Columns.Add("Type");
            m_dtDiscounts.Columns.Add("Value");
            m_dtDiscounts.Columns.Add("Apply On");

            dpDiscountStartDate.Value = DateTime.Now;
            dpDiscountEndDate.Value = DateTime.Now;

            SetCategory();
            ShowDiscounts();
        }

        private void SetCategory()
        {
            cbDiscountApplyOnCat.Items.Clear();
            foreach (ProductCategory cat in DB.PrdCategoriesDB.Categories)
            {
                cbDiscountApplyOnCat.Items.Add(cat.Category);
            }
        }

        private void ShowDiscounts()
        {
            m_dtDiscounts.Rows.Clear();
            foreach(Discount discount in DB.DiscountDB.Discounts)
            {
                m_dtDiscounts.Rows.Add(
                    discount.Id,
                    discount.Name,
                    discount.DiscountType.ToString(),
                    Utils.DisplayCash(discount.Value),
                    discount.ApplyDiscountOn.ToString()
                    );
            }

            dgvDiscounts.DataSource = m_dtDiscounts;

            dgvDiscounts.Columns["ID"].Width = 45;
            dgvDiscounts.Columns["Name"].Width = 223;
            dgvDiscounts.Columns["Type"].Width = 112;
            dgvDiscounts.Columns["Value"].Width = 112;
            dgvDiscounts.Columns["Apply On"].Width = 112;
            dgvDiscounts.Columns["Value"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ReloadDB()
        {
            DB.DiscountDB.Validate();
            ShowDiscounts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPricelistID_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbDiscountID.Text = Utils.RemoveAllExceptNumbers(tbDiscountID.Text);
        }

        private void tbPricelistValue_TextChanged(object sender, EventArgs e)
        {
            // only allow floating point numbers
            tbDiscountValue.Text = Utils.RemoveAllExceptFloats(tbDiscountValue.Text);
        }

        private void tbPricelistValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // read dot only once
            if (e.KeyChar == '.' && tbDiscountValue.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void tbPricelistMin_TextChanged(object sender, EventArgs e)
        {
            if(cbDiscountApplyOn.SelectedItem.ToString() == "Product")
            {
                // only allow numbers
                tbDiscountMin.Text = Utils.RemoveAllExceptNumbers(tbDiscountMin.Text);
            }
            else if(cbDiscountApplyOn.SelectedItem.ToString() == "Product Category" ||
                cbDiscountApplyOn.SelectedItem.ToString() == "All Products")
            {
                // only allow floating point numbers
                tbDiscountMin.Text = Utils.RemoveAllExceptFloats(tbDiscountMin.Text);
            }
        }

        private void tbPricelistMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // read dot only once
            if (e.KeyChar == '.' && tbDiscountMin.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void cbPricelistApplyOn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDiscountApplyOn.SelectedIndex == (int)Discount.ApplyOn.Product)
            {
                lblMin.Text = "Min. Units";
                tbDiscountMin.Text = "";
                tbDiscountMin.PlaceholderText = "0";

                cbDiscountApplyOnCat.TabStop = false;
                cbDiscountApplyOnCat.Visible = false;

                lblDiscountApplyOn.Text = "Product";
                lblDiscountApplyOn.Visible = true;
                tbDiscountApplyOnPrd.TabStop = true;
                tbDiscountApplyOnPrd.Visible = true;
                btnSearchPrd.Visible = true;
            }
            else if (cbDiscountApplyOn.SelectedIndex == (int)Discount.ApplyOn.Category)
            {
                lblMin.Text = "Min. Price";
                tbDiscountMin.PlaceholderText = "0.00";

                tbDiscountApplyOnPrd.Visible = false;
                btnSearchPrd.Visible = false;

                lblDiscountApplyOn.Text = "Prd. Category";
                lblDiscountApplyOn.Visible = true;
                cbDiscountApplyOnCat.Visible = true;
            }
            else if(cbDiscountApplyOn.SelectedIndex == (int)Discount.ApplyOn.All)
            {
                lblMin.Text = "Min. Price";
                tbDiscountMin.PlaceholderText = "0.00";

                lblDiscountApplyOn.Visible = false;
                cbDiscountApplyOnCat.Visible = false;
                tbDiscountApplyOnPrd.Visible = false;
                btnSearchPrd.Visible = false;
            }
        }

        private void btnSearchPrd_Click(object sender, EventArgs e)
        {
            SearchProductForm form = new SearchProductForm();

            form.OnProductSelected += (Product p) =>
            {
                tbDiscountApplyOnPrd.Text = "Product #'" + p.Id + "'";
                form.Close();
            };

            form.Init(DB.ProductsDB.Products);
            form.ShowDialog(this);
        }

        private void checkBoxApplyAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            bool isCheck = checkBoxApplyAutomatic.Checked;

            lblValidity.Visible = isCheck;
            lblStartDate.Visible = isCheck;
            lblEndDate.Visible = isCheck;  

            dpDiscountStartDate.Visible = isCheck;
            dpDiscountEndDate.Visible = isCheck;

        }

        private void dgvDiscounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int selectedID = int.Parse(dgvDiscounts["ID", e.RowIndex].Value.ToString());
                Discount discount = DB.DiscountDB.Get(selectedID);

                tbDiscountID.Text = selectedID.ToString();
                tbDiscountName.Text = discount.Name;
                cbDiscountType.Text = discount.DiscountType.ToString();
                tbDiscountValue.Text = Utils.DisplayCash(discount.Value);
                cbDiscountApplyOn.Text = discount.ApplyDiscountOn.ToString();

                if (discount.ApplyDiscountOn == Discount.ApplyOn.Product)
                    tbDiscountMin.Text = discount.Min.ToString();
                else
                   tbDiscountMin.Text = Utils.DisplayCash(discount.Min);

                if (discount.ApplyDiscountOn == Discount.ApplyOn.Product)
                    tbDiscountApplyOnPrd.Text = "Product #'" + DB.ProductsDB.Get(discount.ApplyOnID).Id.ToString() + "'";
                else if (discount.ApplyDiscountOn == Discount.ApplyOn.Category)
                    cbDiscountApplyOnCat.Text = DB.PrdCategoriesDB.Get(discount.ApplyOnID).Category;

                checkBoxApplyAutomatic.Checked = discount.ApplyAutomatically;
                dpDiscountStartDate.Value = discount.StartDate;
                dpDiscountEndDate.Value = discount.EndDate;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDiscountName.Text))
            {
                MessageBox.Show("Please enter Discount Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDiscountName.Focus();
                return;
            }

            if(cbDiscountApplyOn.SelectedIndex == (int)Discount.ApplyOn.Product &&
                string.IsNullOrWhiteSpace(tbDiscountApplyOnPrd.Text))
            {
                MessageBox.Show("Please select a Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbDiscountApplyOn.SelectedIndex == (int)Discount.ApplyOn.Category &&
                string.IsNullOrWhiteSpace(cbDiscountApplyOnCat.Text))
            {
                MessageBox.Show("Please select a Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double.TryParse(tbDiscountValue.Text, out double value);
            double.TryParse(tbDiscountMin.Text, out double min);

            int applyOnID = 0;
            if (cbDiscountApplyOn.SelectedIndex == (int)Discount.ApplyOn.Product)
            {
                int.TryParse(Utils.RemoveAllExceptNumbers(tbDiscountApplyOnPrd.Text), out applyOnID);
            }
            else if (cbDiscountApplyOn.SelectedIndex == (int)Discount.ApplyOn.Category)
            {
                applyOnID = DB.PrdCategoriesDB.Get(cbDiscountApplyOnCat.Text).Id;
            }


            Discount newDisc = new Discount
            {
                Name = tbDiscountName.Text,
                DiscountType = (Discount.Type)cbDiscountType.SelectedIndex,
                Value = value,
                ApplyDiscountOn = (Discount.ApplyOn)cbDiscountApplyOn.SelectedIndex,
                Min = min,
                ApplyOnID = applyOnID,
                ApplyAutomatically = checkBoxApplyAutomatic.Checked,
                StartDate = checkBoxApplyAutomatic.Checked ? dpDiscountStartDate.Value : DateTime.Now,
                EndDate = checkBoxApplyAutomatic.Checked ? dpDiscountEndDate.Value : DateTime.Now
            };

            int.TryParse(tbDiscountID.Text, out int id);
            if (DB.DiscountDB.Exists(id))
            {
                if (MessageBox.Show("Update Discount #'" + tbDiscountID.Text + "'?", "Update Discount",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    newDisc.Id = id;
                    DB.DiscountDB.Update(newDisc);
                    ReloadDB();
                }
            }
            else
            {
                DB.DiscountDB.Add(newDisc);
                ReloadDB();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDiscountID.Text))
            {
                MessageBox.Show("Please enter Discount ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDiscountID.Focus();
                return;
            }

            int.TryParse(tbDiscountID.Text, out int id);
            if (DB.DiscountDB.Exists(id))
            {
                if (MessageBox.Show("Delete discount #'" + tbDiscountID.Text + "'?", "Delete Discount",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DB.DiscountDB.Delete(id);
                    ReloadDB();
                }
            }
            else
            {
                MessageBox.Show("Cannot find Id #'" + id + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnSearchDiscount(object sender, EventArgs e)
        {
            DataView dv = m_dtDiscounts.DefaultView;

            if(cbSearchDiscountByApplyOn.SelectedIndex == (int)Discount.ApplyOn.All)
                dv.RowFilter = string.Format("Name LIKE '%{0}%'", tbSearchDiscount.Text);
            else
                dv.RowFilter = string.Format("Name LIKE '%{0}%' AND [Apply On] LIKE '%{1}%'", tbSearchDiscount.Text, cbSearchDiscountByApplyOn.Text);
        }

        private void ManageDiscountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }
    }
}
