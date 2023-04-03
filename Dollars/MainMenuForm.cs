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
    public partial class MainMenuForm : Form
    {
        private Form m_activeChildForm;


        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void OpenChildMenuForm(IChildForm form)
        {
            if (m_activeChildForm != null && m_activeChildForm.GetType() == form.GetType()) return;

            m_activeChildForm?.Close();
            
            form.OnChildFormClosed += OnChildMenuClosed;
            m_activeChildForm = (Form)form;
            pnlChildMenu.Visible = true;
            m_activeChildForm.TopLevel = false;
            m_activeChildForm.Dock = DockStyle.Fill;
            pnlChildMenu.Controls.Add(m_activeChildForm);
            pnlChildMenu.Tag = m_activeChildForm;
            m_activeChildForm.BringToFront();
            m_activeChildForm.Show();
        }

        private void OnChildMenuClosed()
        {
            pnlChildMenu.Visible = false;
            m_activeChildForm = null;
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            menuStripMaintenance.Show(MousePosition);
        }


        private void menuStripMaintenance_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == null) return;

            if (e.ClickedItem.Text == "Manage Staffs")
                OpenChildMenuForm(new ManageStaffForm());
            else if (e.ClickedItem.Text == "Manage Customers")
                OpenChildMenuForm(new ManageCustomerForm());
            else if (e.ClickedItem.Text == "Manage Categories")
                OpenChildMenuForm(new ManageCategoryForm());
            else if (e.ClickedItem.Text == "Manage Products")
                OpenChildMenuForm(new ManageProductForm());
            else if (e.ClickedItem.Text == "Manage Stocks")
                OpenChildMenuForm(new ManageStockForm());
            else if (e.ClickedItem.Text == "Manage Pricelists")
                OpenChildMenuForm(new ManagePricelistForm());
        }
    }
}
