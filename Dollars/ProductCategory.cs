using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollars
{
    public struct ProductCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string ParentCategory { get; set; }
        public int ParentCategoryID { get; set; }
    }
}
