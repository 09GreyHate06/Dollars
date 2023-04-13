using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollars
{
    public partial class SearchCustomerForm : Form, IChildForm
    {
        private DataTable m_dtCustomers;
        public Action OnChildFormClosed { get; set; }
        public Action<Customer> OnCustomerSelected { get; set; }

        public Customer SelectedCustomer { get; private set; } = new Customer();

        public SearchCustomerForm()
        {
            InitializeComponent();

            m_dtCustomers = new DataTable();
            m_dtCustomers.Columns.Add("ID");
            m_dtCustomers.Columns.Add("Name");
            m_dtCustomers.Columns.Add("Birthdate");
            m_dtCustomers.Columns.Add("Contact No.");
            m_dtCustomers.Columns.Add("Email");
            m_dtCustomers.Columns.Add("Points");
            m_dtCustomers.Columns.Add("Amount Spent");

            ShowCustomer();
        }

        private void ShowCustomer()
        {
            m_dtCustomers.Rows.Clear();

            m_dtCustomers.Rows.Add("0", "None", "", "", "", "", "");
            foreach (Customer customer in DB.CustomersDB.Customers)
            {
                m_dtCustomers.Rows.Add(
                    customer.Id,
                    customer.FirstName + (customer.MiddleInitial == "" ? " " : " " + customer.MiddleInitial + ". ") + customer.LastName,
                    customer.Birthdate.ToString("d"),
                    customer.ContactNo,
                    customer.Email,
                    Utils.DisplayCash(customer.Points),
                    Utils.DisplayCash(customer.AmountSpent)
                    );
            }

            dgvCustomers.DataSource = m_dtCustomers;
            dgvCustomers.Columns["ID"].Width = 38;
            dgvCustomers.Columns["Name"].Width = 151;
            dgvCustomers.Columns["Birthdate"].Width = 151;
            dgvCustomers.Columns["Contact No."].Width = 151;
            dgvCustomers.Columns["Email"].Width = 151;
            dgvCustomers.Columns["Points"].Width = 76;
            dgvCustomers.Columns["Amount Spent"].Width = 106;

            dgvCustomers.Columns["Points"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCustomers.Columns["Amount Spent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewButtonColumn selectBtn = new DataGridViewButtonColumn();
            selectBtn.Text = "Select";
            selectBtn.UseColumnTextForButtonValue = true;
            selectBtn.Width = 60;
            dgvCustomers.Columns.Add(selectBtn);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int selectedID = int.Parse(dgvCustomers["ID", e.RowIndex].Value.ToString());

                if(selectedID == 0) 
                    SelectedCustomer = new Customer();
                else
                    SelectedCustomer = DB.CustomersDB.Get(selectedID);

                OnCustomerSelected?.Invoke(SelectedCustomer);
            }
        }

        private void OnSearchCustomer(object sender, EventArgs e)
        {
            DataView dv = m_dtCustomers.DefaultView;
            dv.RowFilter = string.Format("Name LIKE '%{0}%'", tbSearchCustomer.Text);
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

        private void SearchCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
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
