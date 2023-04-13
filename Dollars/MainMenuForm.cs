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
    public partial class MainMenuForm : Form, IChildForm
    {
        private bool m_windowDragging = false;
        private Point m_windowDragOffset;

        private List<Product> m_criticalStocks;

        private Form m_activeChildForm;

        public Action OnChildFormClosed { get; set; }

        public MainMenuForm()
        {
            InitializeComponent();
            CenterToScreen();

            lblTodayDate.Text = DateTime.Now.ToString("dddd, d MMMM yyyy");
            string userFullName = Utils.ConcatFullname(Account.Active.FirstName, Account.Active.MiddleInitial, Account.Active.LastName);
            lblCurrentUser.Text = userFullName + " | " + Account.Active.AccRole.ToString();

            UpdateTotalSales();
            UpdateTotalTransactions();
            UpdateTotalProducts();
            UpdateCriticalStocks();
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
            {
                ManageProductForm form = new ManageProductForm();
                form.OnChildFormClosed += UpdateTotalProducts;
                form.OnChildFormClosed += UpdateCriticalStocks;
                OpenChildMenuForm(form);
            }
            else if (e.ClickedItem.Text == "Manage Stocks")
            {
                ManageStockForm form = new ManageStockForm();
                form.OnChildFormClosed += UpdateCriticalStocks;
                OpenChildMenuForm(form);
            }
            else if (e.ClickedItem.Text == "Manage Discounts")
                OpenChildMenuForm(new ManageDiscountForm());
            else if (e.ClickedItem.Text == "Manage Store Info")
                OpenChildMenuForm(new ManageStoreInfoForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.Init(m_criticalStocks);
            OpenChildMenuForm(form);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            m_activeChildForm?.Close();
            m_activeChildForm = null;
            pnlChildMenu.Visible = false;

            POSForm form = new POSForm();
            form.OnChildFormClosed += Show;
            form.OnChildFormClosed += UpdateTotalSales;
            form.OnChildFormClosed += UpdateTotalTransactions;
            form.OnChildFormClosed += UpdateCriticalStocks;
            form.OnChildFormClosed += () =>
            {
                Location = form.Location;
            };

            form.Show();
            form.Location = Location;
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateTotalSales()
        {
            lblTotalSales.Text = Utils.DisplayCash(StoreInfo.Active.TotalSales);
        }

        private void UpdateTotalTransactions()
        {
            lblTotalTransactions.Text = StoreInfo.Active.TotalTransactions.ToString();
        }

        private void UpdateTotalProducts()
        {
            lblTotalPrd.Text = DB.ProductsDB.Products.Count.ToString();
        }

        private void UpdateCriticalStocks()
        {
            m_criticalStocks = new List<Product>();
            foreach(Product prd in DB.ProductsDB.Products)
            {
                if (prd.Qty > 10) continue;

                m_criticalStocks.Add(prd);
            }

            lblCriticalStocks.Text = m_criticalStocks.Count.ToString();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
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
            if(!m_windowDragging) return;

            Point curScreenPos = PointToScreen(e.Location);
            Location = new Point(curScreenPos.X - m_windowDragOffset.X, curScreenPos.Y - m_windowDragOffset.Y);
        }
    }
}
