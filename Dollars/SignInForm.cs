using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollars
{
    public partial class SignInForm : Form
    {
        public SignInForm()
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.OnChildFormClosed += Show;
            form.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
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

            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();

                // cast sensitive COLLATE Latin1_General_CS_AS
                string sqlQueury = "SELECT * FROM AccountsTbl WHERE Username COLLATE Latin1_General_CS_AS =@Username AND Password COLLATE Latin1_General_CS_AS =@Password";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
                cmd.Parameters.AddWithValue("@Password", tbPassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Account.Active = new Account
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        ParentAccountID = Convert.ToInt32(reader["ParentAccountID"]),
                        LastName = reader["LastName"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        MiddleInitial = reader["MiddleInitial"].ToString(),
                        Address = reader["Address"].ToString(),
                        ContactNo = reader["ContactNo"].ToString(),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        AccRole = (Account.Role)Convert.ToInt32(reader["Role"]),
                        AccStatus = (Account.Status)Convert.ToInt32(reader["Status"]),
                    };

                    DB.Validate();
                    if(Account.Active.AccRole == Account.Role.Administrator)
                    {
                        MainMenuForm form = new MainMenuForm();
                        form.OnChildFormClosed += () => 
                        { 
                            Show(); 
                            Account.Active = new Account(); 
                        };
                        form.Show();
                        Hide();
                    }
                    else
                    {
                        POSForm form = new POSForm();
                        form.OnChildFormClosed += () => 
                        { 
                            Show(); 
                            Account.Active = new Account(); 
                        };
                        form.Show();
                        Hide();
                    }

                    StoreInfo.Active = DB.StoreInfoDB.Get();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUsername.Focus();
                }

                sqlConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load AccountsTbl\n[Info]" + ex.Message, "AccountsTbl Error");
                Application.Exit();
            }
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
