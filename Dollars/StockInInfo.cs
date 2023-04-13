using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollars
{
    public struct StockInInfo
    {
        public int Id { get; set; }
        public int ProductID{ get; set; }
        public string ProductName{ get; set; }
        public string ProductCategory{ get; set; }
        public int Qty { get; set; }
        public DateTime StockInDate { get; set; }
    }
}
