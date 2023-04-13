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
    public partial class EnterQuantityForm : Form, IChildForm
    {
        private int m_max = -1;

        public Action OnChildFormClosed { get; set; }

        public Action<int> OnBtnOKClick { get; set; }

        public EnterQuantityForm()
        {
            InitializeComponent();

            tbQuantity.Focus();
        }

        public void MaxQty(int max)
        {
            m_max = max;
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            tbQuantity.Text = Utils.RemoveAllExceptNumbers(tbQuantity.Text);

            int.TryParse(tbQuantity.Text, out int qty);
            if (qty > m_max && m_max != -1)
                tbQuantity.Text = m_max.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int.TryParse(tbQuantity.Text, out int qty);
            OnBtnOKClick?.Invoke(qty);
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // https://stackoverflow.com/questions/3172731/forms-not-responding-to-keydown-events

            switch (keyData)
            {
                case Keys.Enter:
                    btnOk_Click(null, null);
                    return true;

                case Keys.Escape:
                    btnExit_Click(null, null);
                    return true;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void EnterQuantityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= Utils.CS_DROPSHADOW;
                return cp;
            }
        }
    }
}
