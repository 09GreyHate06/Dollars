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
    public partial class ManageCustomerForm : Form, IChildForm
    {
        public Action OnChildFormClosed { get; set; }

        public ManageCustomerForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnChildFormClosed?.Invoke();
            Close();
        }

        private void tbCustomerID_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbCustomerID.Text = new String(tbCustomerID.Text.Where(c => '0' <= c && c <= '9').ToArray());
        }

        private void tbCustomerContactNo_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbCustomerContactNo.Text = new String(tbCustomerContactNo.Text.Where(c => '0' <= c && c <= '9').ToArray());
        }

        private void tbCustomerPoints_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbCustomerPoints.Text = new String(tbCustomerPoints.Text.Where(c => '0' <= c && c <= '9').ToArray());
        }

        private void tbCustomerAmountSpent_TextChanged(object sender, EventArgs e)
        {
            // only allow floating point numbers
            tbCustomerAmountSpent.Text = new String(tbCustomerAmountSpent.Text.Where(c => c == '.' || ('0' <= c && c <= '9')).ToArray());
        }

        private void tbCustomerAmountSpent_KeyPress(object sender, KeyPressEventArgs e)
        {
            // read dot only once
            if(e.KeyChar == '.' && tbCustomerAmountSpent.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
