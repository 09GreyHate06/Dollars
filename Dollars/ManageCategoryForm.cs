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
    public partial class ManageCategoryForm : Form, IChildForm
    {
        public Action OnChildFormClosed { get; set; }

        public ManageCategoryForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnChildFormClosed?.Invoke();
            Close();
        }

        private void tbCatID_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbCatID.Text = new String(tbCatID.Text.Where(c => '0' <= c && c <= '9').ToArray());
        }
    }
}
