using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollars
{
    public struct Account
    {
        public enum Role
        {
            Administrator = 0,
            Cashier = 1
        }

        public enum Status
        {
            Active = 0,
            Inactive = 1
        }

        public int Id { get; set; } 
        public int ParentAccountID { get; set; } 
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role AccRole { get; set; }
        public Status AccStatus { get; set; }

        public static Account Active { get; set; }
    }
}
