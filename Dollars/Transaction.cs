using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollars
{
    public struct Transaction
    {
        public int Number { get; set; }
        public int CashierID { get; set; }
        public string CashierName { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public double Subtotal { get; set; }
    }
}
