using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollars
{
    public struct Customer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public DateTime Birthdate { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public double Points { get; set; }
        public double AmountSpent { get; set; }
    }
}
