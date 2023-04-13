using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Dollars
{
    public struct Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
        public double UnitPrice { get; set; }
        public int Qty { get; set; }
        public Image Image { get; set; }
    }
}
