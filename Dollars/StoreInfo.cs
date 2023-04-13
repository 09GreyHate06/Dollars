using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollars
{
    public struct StoreInfo
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public double Vat { get; set; }
        public int TotalTransactions { get; set; }
        public double TotalSales { get; set; }

        public static StoreInfo Active { get; set; }
    }
}
