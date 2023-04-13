using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dollars
{
    public partial class SignUpForm : Form, IChildForm
    {
        public Action OnChildFormClosed { get; set; }

        public SignUpForm()
        {
            InitializeComponent();

            btnHideShowPass.Image = ImageRes.hide;
        }

        private void btnHideShowPass_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\0';
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
            btnHideShowPass.Image = tbPassword.UseSystemPasswordChar ? ImageRes.hide : ImageRes.show;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                MessageBox.Show("Please enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                MessageBox.Show("Please enter First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                MessageBox.Show("Please enter Address Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbContactNo.Text))
            {
                MessageBox.Show("Please enter Contact No. Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbContactNo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Please enter Contact No. Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Please enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Focus();
                return;
            }

            bool usernameTaken = false;
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "SELECT * FROM AccountsTbl WHERE Username COLLATE Latin1_General_CS_AS = @Username";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    usernameTaken = true;
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load AccountsTbl\n[Info]: " + ex.Message, "AccountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (!usernameTaken)
            {
                try
                {
                    SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                    {
                        sqlConn.Open();
                        string sqlQueury = "INSERT INTO AccountsTbl(LastName, FirstName, MiddleInitial, Address, ContactNo, Email, Username, Password, Role, Status) VALUES(@LastName, @FirstName, @MiddleInitial, @Address, @ContactNo, @Email, @Username, @Password, @Role, @Status)";
                        SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                        cmd.Parameters.AddWithValue("@LastName", tbLastName.Text);
                        cmd.Parameters.AddWithValue("@FirstName", tbFirstName.Text);
                        cmd.Parameters.AddWithValue("@MiddleInitial", tbMiddleInitial.Text);
                        cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
                        cmd.Parameters.AddWithValue("@ContactNo", tbContactNo.Text);
                        cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                        cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", tbPassword.Text);
                        cmd.Parameters.AddWithValue("@Role", 0);
                        cmd.Parameters.AddWithValue("@Status", 0);

                        cmd.ExecuteNonQuery();
                        sqlConn.Close();
                    }

                    {
                        sqlConn.Open();
                        string sqlQueury = "UPDATE AccountsTbl SET ParentAccountID = Id WHERE ParentAccountID IS NULL";
                        SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                        cmd.ExecuteNonQuery();
                        sqlConn.Close();
                    }

                    int parentAccID = 0;
                    {
                        sqlConn.Open();
                        string sqlQueury = "SELECT * FROM AccountsTbl WHERE Username COLLATE Latin1_General_CS_AS =@Username AND Password COLLATE Latin1_General_CS_AS =@Password";
                        SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                        cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", tbPassword.Text);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            parentAccID = Convert.ToInt32(reader["ParentAccountID"]);
                        }
                    }

                    DB.StoreInfoDB.Add(parentAccID, new StoreInfo 
                    { 
                        Name = "Dollars",  
                        Address = tbAddress.Text,
                        ContactNo = tbContactNo.Text,
                        Email = tbEmail.Text,
                        Vat = 12.0,
                        TotalTransactions = 0,
                        TotalSales = 0.0,
                    });

                    MessageBox.Show(tbUsername.Text + " is registered", "Add account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlConn.Close();

                    Validate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load AccountsTbl\n[Info]: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                OnChildFormClosed?.Invoke();
                Close();
            }
            else
            {
                MessageBox.Show("Username is already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Focus();
            }
        }

        private void tbContactNo_TextChanged(object sender, EventArgs e)
        {
            // only allow numbers
            tbContactNo.Text = Utils.RemoveAllExceptNumbers(tbContactNo.Text);
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
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
