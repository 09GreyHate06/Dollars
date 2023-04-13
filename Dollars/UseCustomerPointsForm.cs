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
    public partial class UseCustomerPointsForm : Form, IChildForm
    {
        private double m_maxPoints = -1;

        public Action OnChildFormClosed { get; set; }
        public Action<double> OnBtnOKClick { get; set; }

        public UseCustomerPointsForm()
        {
            InitializeComponent();
        }

        public void Init(double maxPoints)
        {
            m_maxPoints = maxPoints;
            lblCurPoints.Text = Utils.DisplayCash(m_maxPoints);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPoints_TextChanged(object sender, EventArgs e)
        {
            tbPoints.Text = Utils.RemoveAllExceptFloats(tbPoints.Text);

            double.TryParse(tbPoints.Text, out double points);
            if (points > m_maxPoints && m_maxPoints != -1)
                tbPoints.Text = m_maxPoints.ToString();
        }

        private void tbPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && tbPoints.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double.TryParse(tbPoints.Text, out double points);
            OnBtnOKClick?.Invoke(points);
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

        private void UseCustomerPointsForm_FormClosing(object sender, FormClosingEventArgs e)
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
