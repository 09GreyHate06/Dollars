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
    public enum PricelistType
    {
        PercentageDiscount,
        FixedDiscount,
        Points
    }

    public partial class ManagePricelistForm : Form, IChildForm
    {
        public Action OnChildFormClosed { get; set; }

        public ManagePricelistForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnChildFormClosed?.Invoke();
            Close();
        }

        private void tbPricelistID_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbPricelistID.Text = new String(tbPricelistID.Text.Where(c => '0' <= c && c <= '9').ToArray());
        }

        private void tbPricelistValue_TextChanged(object sender, EventArgs e)
        {
            // only allow floating point numbers
            tbPricelistValue.Text = new String(tbPricelistValue.Text.Where(c => c == '.' || ('0' <= c && c <= '9')).ToArray());
        }

        private void tbPricelistValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // read dot only once
            if (e.KeyChar == '.' && tbPricelistValue.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void tbPricelistMin_TextChanged(object sender, EventArgs e)
        {
            if(cbPricelistApplyOn.SelectedItem.ToString() == "Product")
            {
                // only allow numbers
                tbPricelistMin.Text = new String(tbPricelistMin.Text.Where(c => '0' <= c && c <= '9').ToArray());
            }
            else if(cbPricelistApplyOn.SelectedItem.ToString() == "Product Category" ||
                cbPricelistApplyOn.SelectedItem.ToString() == "All Products")
            {
                // only allow floating point numbers
                tbPricelistMin.Text = new String(tbPricelistMin.Text.Where(c => c == '.' || ('0' <= c && c <= '9')).ToArray());
            }
        }

        private void tbPricelistMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // read dot only once
            if (e.KeyChar == '.' && tbPricelistMin.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void cbPricelistApplyOn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbPricelistApplyOn.SelectedItem.ToString() == "Product")
            {
                lblMin.Text = "Min. Units";
                tbPricelistMin.Text = "";

                cbApplyOnCat.TabStop = false;
                cbApplyOnCat.Visible = false;

                lblApplyOn.Text = "Product";
                lblApplyOn.Visible = true;
                tbApplyOnPrd.TabStop = true;
                tbApplyOnPrd.Visible = true;
                btnSearchPrd.Visible = true;
            }
            else if (cbPricelistApplyOn.SelectedItem.ToString() == "Product Category")
            {
                lblMin.Text = "Min. Price";

                tbApplyOnPrd.TabStop = false;
                tbApplyOnPrd.Visible = false;
                btnSearchPrd.Visible = false;

                lblApplyOn.Text = "Prd. Category";
                lblApplyOn.Visible = true;
                cbApplyOnCat.TabStop = true;
                cbApplyOnCat.Visible = true;
            }
            else if(cbPricelistApplyOn.SelectedItem.ToString() == "All Products")
            {
                lblMin.Text = "Min. Price";

                lblApplyOn.Visible = false;
                cbApplyOnCat.TabStop = false;
                cbApplyOnCat.Visible = false;
                tbApplyOnPrd.TabStop = false;
                tbApplyOnPrd.Visible = false;
                btnSearchPrd.Visible = false;
            }
        }

        private void btnSearchPrd_Click(object sender, EventArgs e)
        {
            SearchProductForm form = new SearchProductForm();
            form.ShowDialog(this);
        }
    }
}
