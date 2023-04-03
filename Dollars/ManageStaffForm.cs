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
    public partial class ManageStaffForm : Form, IChildForm
    {
        public Action OnChildFormClosed { get; set; }

        public ManageStaffForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnChildFormClosed?.Invoke();
            Close();
        }

        private void tbStaffID_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbStaffID.Text = new String(tbStaffID.Text.Where(c => '0' <= c && c <= '9').ToArray());
        }

        private void tbStaffContactNo_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbStaffContactNo.Text = new String(tbStaffContactNo.Text.Where(c => '0' <= c && c <= '9').ToArray());
        }
    }
}
