using Guna.UI2.WinForms;
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
    public partial class ManageCustomerForm : Form, IChildForm
    {
        private DataTable m_dtCustomer;

        public Action OnChildFormClosed { get; set; }

        public ManageCustomerForm()
        {
            InitializeComponent();

            m_dtCustomer = new DataTable();
            m_dtCustomer.Columns.Add("ID");
            m_dtCustomer.Columns.Add("Name");
            m_dtCustomer.Columns.Add("Birthdate");
            m_dtCustomer.Columns.Add("Contact No.");
            m_dtCustomer.Columns.Add("Email");
            m_dtCustomer.Columns.Add("Points");
            m_dtCustomer.Columns.Add("Amount Spent");

            dpBirthdate.Value = DateTime.Now;

            ShowCustomers();
        }

        private void ShowCustomers()
        {
            m_dtCustomer.Rows.Clear();
            foreach(Customer customer in DB.CustomersDB.Customers)
            {
                m_dtCustomer.Rows.Add(
                    customer.Id,
                    Utils.ConcatFullname(customer.FirstName, customer.MiddleInitial, customer.LastName),
                    customer.Birthdate.ToString("d"),
                    customer.ContactNo,
                    customer.Email,
                    Utils.DisplayCash(customer.Points),
                    Utils.DisplayCash(customer.AmountSpent)
                    );
            }

            dgvCustomer.DataSource = m_dtCustomer;

            dgvCustomer.Columns["ID"].Width = 29;
            dgvCustomer.Columns["Name"].Width = 96;
            dgvCustomer.Columns["Birthdate"].Width = 96;
            dgvCustomer.Columns["Contact No."].Width = 95;
            dgvCustomer.Columns["Email"].Width = 96;
            dgvCustomer.Columns["Points"].Width = 96;
            dgvCustomer.Columns["Amount Spent"].Width = 96;

            dgvCustomer.Columns["Points"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCustomer.Columns["Amount Spent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ReloadDB()
        {
            DB.CustomersDB.Validate();
            ShowCustomers();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TBTextChangeNumbersOnly(object sender, EventArgs e)
        {
            var tb = (Guna2TextBox)sender;
            tb.Text = Utils.RemoveAllExceptNumbers(tb.Text);
        }

        private void TBTextChangeFloatsOnly(object sender, EventArgs e)
        {
            var tb = (Guna2TextBox)sender;
            tb.Text = Utils.RemoveAllExceptFloats(tb.Text);
        }

        private void TBKeyPressReadDotOnce(object sender, KeyPressEventArgs e)
        {
            // read dot only once
            if (e.KeyChar == '.' && ((Guna2TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void OnSearchCustomer(object sender, EventArgs e)
        {
            DataView dv = m_dtCustomer.DefaultView;
            dv.RowFilter = string.Format("Name LIKE '%{0}%'", tbSearchCustomer.Text);
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedId = int.Parse(dgvCustomer["ID", e.RowIndex].Value.ToString());
                Customer customer = DB.CustomersDB.Get(selectedId);

                tbCustomerID.Text = customer.Id.ToString();
                tbCustomerLastName.Text = customer.LastName;
                tbCustomerFirstName.Text = customer.FirstName;
                tbCustomerMiddleIn.Text = customer.MiddleInitial;
                dpBirthdate.Value = customer.Birthdate;
                tbCustomerContactNo.Text = customer.ContactNo;
                tbCustomerEmail.Text = customer.Email;
                tbCustomerPoints.Text = Utils.DisplayCash(customer.Points);
                tbCustomerAmountSpent.Text = Utils.DisplayCash(customer.AmountSpent);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCustomerLastName.Text))
            {
                MessageBox.Show("Please enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCustomerLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbCustomerFirstName.Text))
            {
                MessageBox.Show("Please enter First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCustomerFirstName.Focus();
                return;
            }

            double.TryParse(tbCustomerPoints.Text, out double points);
            double.TryParse(tbCustomerAmountSpent.Text, out double amountSpent);

            Customer customer = new Customer
            {
                LastName = tbCustomerLastName.Text,
                FirstName = tbCustomerFirstName.Text,
                MiddleInitial = tbCustomerMiddleIn.Text,
                Birthdate = dpBirthdate.Value,
                ContactNo = tbCustomerContactNo.Text,
                Email = tbCustomerEmail.Text,
                Points = points,
                AmountSpent = amountSpent
            };

            int.TryParse(tbCustomerID.Text, out int id);
            if (DB.CustomersDB.Exists(id))
            {
                if (MessageBox.Show("Update Customer #'" + tbCustomerID.Text + "'?", "Update Customer",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    customer.Id = id;
                    DB.CustomersDB.Update(customer);
                    ReloadDB();
                }
            }
            else
            {
                DB.CustomersDB.Add(customer);
                ReloadDB();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCustomerID.Text))
            {
                MessageBox.Show("Please enter Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCustomerID.Focus();
                return;
            }

            int.TryParse(tbCustomerID.Text, out int id);
            if (DB.CustomersDB.Exists(id))
            {
                if (MessageBox.Show("Delete Customer #'" + tbCustomerID.Text + "'?", "Delete Customer",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DB.CustomersDB.Delete(id);
                    ReloadDB();
                }
            }
            else
            {
                MessageBox.Show("Cannot find Id #'" + id + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }
    }
}
