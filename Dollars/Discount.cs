using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dollars.Discount;
using System.Xml.Linq;

namespace Dollars
{
    public struct Discount
    {
        public enum Type
        {
            Percentage,
            Fixed,
            Points
        }

        public enum ApplyOn
        {
            All,
            Category,
            Product
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Type DiscountType { get; set; }
        public double Value { get; set; }
        public ApplyOn ApplyDiscountOn { get; set; }
        /// <summary>
        /// if ApplyOn = Product Min. Qty 
        /// else Min. Price
        /// </summary>
        public double Min { get; set; }
        public int ApplyOnID { get; set; }
        public bool ApplyAutomatically { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
