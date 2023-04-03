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
    public partial class ManageStockForm : Form, IChildForm
    {
        public Action OnChildFormClosed { get; set; }

        public ManageStockForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnChildFormClosed?.Invoke();
            Close();
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbQuantity.Text = new String(tbQuantity.Text.Where(c => '0' <= c && c <= '9').ToArray());
        }
    }
}
