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
    public partial class ManageStoreInfoForm : Form, IChildForm
    {
        public Action OnChildFormClosed { get; set; }

        public ManageStoreInfoForm()
        {
            InitializeComponent();

            ShowStoreInfo();
        }

        private void ShowStoreInfo()
        {
            tbStoreName.Text = StoreInfo.Active.Name;
            tbStoreAddress.Text = StoreInfo.Active.Address;
            tbStoreContact.Text = StoreInfo.Active.ContactNo;
            tbStoreEmail.Text = StoreInfo.Active.Email;
            tbStoreVat.Text = Utils.DisplayCash(StoreInfo.Active.Vat);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbStoreVat_TextChanged(object sender, EventArgs e)
        {
            tbStoreVat.Text = Utils.RemoveAllExceptFloats(tbStoreVat.Text);
        }

        private void tbStoreVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // read dot only once
            if (e.KeyChar == '.' && tbStoreVat.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void tbStoreContact_TextChanged(object sender, EventArgs e)
        {
            tbStoreContact.Text = Utils.RemoveAllExceptNumbers(tbStoreContact.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Update store info?", "Update Store Info",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                return;
            }

            double.TryParse(tbStoreVat.Text, out double vat);
            DB.StoreInfoDB.Update(new StoreInfo
            {
                Name = tbStoreName.Text,
                Address = tbStoreAddress.Text,
                ContactNo = tbStoreContact.Text,
                Email = tbStoreEmail.Text,
                Vat = vat,
                TotalTransactions = StoreInfo.Active.TotalTransactions,
                TotalSales = StoreInfo.Active.TotalSales
            });

            DB.StoreInfoDB.Validate();
        }

        private void ManageStoreInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }
    }
}
