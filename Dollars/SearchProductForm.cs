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
    public partial class SearchProductForm : Form, IChildForm
    {
        public Action OnChildFormClosed { get; set; }
        public Action OnSelectPrd { get; set; }

        public SearchProductForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnChildFormClosed?.Invoke();
            Close();
        }
    }
}
