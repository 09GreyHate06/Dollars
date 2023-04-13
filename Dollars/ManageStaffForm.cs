using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollars
{
    public partial class ManageStaffForm : Form, IChildForm
    {
        private DataTable m_dtStaff;

        public Action OnChildFormClosed { get; set; }
        

        public ManageStaffForm()
        {
            InitializeComponent();

            btnHideShowPass.Image = ImageRes.hide;

            m_dtStaff = new DataTable();
            m_dtStaff.Columns.Add("ID");
            m_dtStaff.Columns.Add("Name");
            m_dtStaff.Columns.Add("Address");
            m_dtStaff.Columns.Add("Contact No.");
            m_dtStaff.Columns.Add("Email");
            m_dtStaff.Columns.Add("Role");
            m_dtStaff.Columns.Add("Status");

            ShowStaffs();
        }

        public void ShowStaffs()
        {
            m_dtStaff.Rows.Clear();
            foreach(Account staff in DB.StaffsDB.Staffs)
            {
                m_dtStaff.Rows.Add(
                    staff.Id,
                    Utils.ConcatFullname(staff.FirstName, staff.MiddleInitial, staff.LastName),
                    staff.Address,
                    staff.ContactNo,
                    staff.Email,
                    staff.AccRole.ToString(),
                    staff.AccStatus.ToString()
                );
            }

            dgvStaff.DataSource = m_dtStaff;

            dgvStaff.Columns["ID"].Width = 34;
            dgvStaff.Columns["Name"].Width = 114;
            dgvStaff.Columns["Address"].Width = 114;
            dgvStaff.Columns["Contact No."].Width = 114;
            dgvStaff.Columns["Email"].Width = 114;
            dgvStaff.Columns["Role"].Width = 57;
            dgvStaff.Columns["Status"].Width = 57;
        }

        private void ReloadDB()
        {
            DB.StaffsDB.Validate();
            ShowStaffs();
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

        private void btnHideShowPass_Click(object sender, EventArgs e)
        {
            tbStaffPassword.PasswordChar = '\0';
            tbStaffPassword.UseSystemPasswordChar = !tbStaffPassword.UseSystemPasswordChar;
            btnHideShowPass.Image = tbStaffPassword.UseSystemPasswordChar ? ImageRes.hide : ImageRes.show;
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int selectedAccId = int.Parse(dgvStaff["ID", e.RowIndex].Value.ToString());
                Account acc = DB.StaffsDB.Get(selectedAccId);

                tbStaffID.Text = acc.Id.ToString();
                tbStaffLastName.Text = acc.LastName;
                tbStaffFirstName.Text = acc.FirstName;
                tbStaffMiddleIn.Text = acc.MiddleInitial;
                tbStaffAddress.Text = acc.Address;
                tbStaffContactNo.Text = acc.ContactNo;
                tbStaffEmail.Text = acc.Email;
                tbStaffUsername.Text = acc.Username;
                tbStaffPassword.Text = acc.Password;
                cbStaffRole.Text = acc.AccRole.ToString();
                cbStaffStatus.Text = acc.AccStatus.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbStaffLastName.Text))
            {
                MessageBox.Show("Please enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbStaffLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbStaffFirstName.Text))
            {
                MessageBox.Show("Please enter First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbStaffFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbStaffAddress.Text))
            {
                MessageBox.Show("Please enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbStaffAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbStaffContactNo.Text))
            {
                MessageBox.Show("Please enter Contact No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbStaffContactNo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbStaffEmail.Text))
            {
                MessageBox.Show("Please enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbStaffEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbStaffUsername.Text))
            {
                MessageBox.Show("Please enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbStaffUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbStaffPassword.Text))
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbStaffPassword.Focus();
                return;
            }

            int.TryParse(tbStaffID.Text, out int id);
            if (DB.StaffsDB.UsernameExists(tbStaffUsername.Text, id))
            {
                MessageBox.Show("Username is already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbStaffUsername.Focus();
                return;
            }

            Account newStaff = new Account
            {
                LastName = tbStaffLastName.Text,
                FirstName = tbStaffFirstName.Text,
                MiddleInitial = tbStaffMiddleIn.Text,
                Address = tbStaffAddress.Text,
                ContactNo = tbStaffContactNo.Text,
                Email = tbStaffEmail.Text,
                Username = tbStaffUsername.Text,
                Password = tbStaffPassword.Text,
                AccRole = (Account.Role)cbStaffRole.SelectedIndex,
                AccStatus = (Account.Status)cbStaffStatus.SelectedIndex
            };

            if (DB.StaffsDB.Exists(id))
            {
                if(MessageBox.Show("Update Staff #'" + tbStaffID.Text + "'?", "Update Staff",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    newStaff.Id = id;
                    DB.StaffsDB.Update(newStaff);
                    ReloadDB();
                }
            }
            else
            {
                DB.StaffsDB.Add(newStaff);
                ReloadDB();
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbStaffID.Text))
            {
                MessageBox.Show("Please enter Account ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbStaffID.Focus();
                return;
            }

            int.TryParse(tbStaffID.Text, out int id);
            if(id == Account.Active.Id)
            {
                MessageBox.Show("Cannot delete active account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DB.StaffsDB.Exists(id))
            {
                if(MessageBox.Show("Delete Staff #'" + tbStaffID.Text + "'?", "Delete Staff",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DB.StaffsDB.Delete(id);
                    ReloadDB();
                }
            }
            else
            {
                MessageBox.Show("Cannot find Id #'" + id + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnSearchStaff(object sender, EventArgs e)
        {
            DataView dv = m_dtStaff.DefaultView;

            if (cbSearchStaffByRole.Text == "All")
                dv.RowFilter = string.Format("Name LIKE '%{0}%'", tbSearchStaff.Text);
            else
                dv.RowFilter = string.Format("Name LIKE '%{0}%' AND Role LIKE '%{1}%'", tbSearchStaff.Text, cbSearchStaffByRole.Text);
        }

        private void ManageStaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }
    }
}
