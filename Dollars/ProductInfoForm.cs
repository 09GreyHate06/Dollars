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
    public partial class ProductInfoForm : Form, IChildForm
    {
        private bool m_windowDragging = false;
        private Point m_windowDragOffset;

        public Action OnChildFormClosed { get; set; }

        public ProductInfoForm()
        {
            InitializeComponent();
        }

        public void Init(Product prd)
        {
            pbPrdImage.Image = prd.Image;
            tbPrdID.Text = prd.Id.ToString();
            tbPrdName.Text = prd.Name.ToString();
            tbPrdCat.Text = prd.Category.Category.ToString();
            tbPrdUnitPrice.Text = Utils.DisplayCash(prd.UnitPrice);
            tbPrdQty.Text = prd.Qty.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }

        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            m_windowDragging = true;
            m_windowDragOffset = e.Location;
        }

        private void pnlMenu_MouseUp(object sender, MouseEventArgs e)
        {
            m_windowDragging = false;
        }

        private void pnlMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (!m_windowDragging) return;

            Point curScreenPos = PointToScreen(e.Location);
            Location = new Point(curScreenPos.X - m_windowDragOffset.X, curScreenPos.Y - m_windowDragOffset.Y);
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // https://stackoverflow.com/questions/3172731/forms-not-responding-to-keydown-events

            if (keyData == Keys.Escape)
            {
                btnExit_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
