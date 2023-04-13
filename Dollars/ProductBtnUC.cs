using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollars
{
    public partial class ProductBtnUC : UserControl
    {
        private static Product s_default = new Product
        {
            Id = -1,
            Name = "Unset",
            Category = new ProductCategory(),
            UnitPrice = 0.0,
            Qty = 0,
            Image = null
        };

        private Product m_product;

        public Product Product
        {
            get
            {
                return m_product;
            }
            set
            {
                m_product = value;
                lblPrdName.Text = m_product.Name;
                PrdPrice = m_product.UnitPrice;
                btnProduct.Image = m_product.Image;
            }
        }

        public Action<ProductBtnUC, Product> OnPrdClick { get; set; }


        public string PrdName
        {
            get
            {
                return Product.Name;
            }
            set
            {
                m_product.Name = value;
                lblPrdName.Text = value;
            }
        }

        public double PrdPrice
        {
            get
            {
                return Product.UnitPrice;
            }
            set
            {
                m_product.UnitPrice = value;
                lblPrice.Text = Utils.DisplayCash(Product.UnitPrice);
                if(lblPrice.Right > Width)
                    lblPrice.Left = Width - lblPrice.Width;
            }
        }

        public Image PrdImage
        {
            get
            {
                return Product.Image;
            }
            set
            {
                m_product.Image = value;
                btnProduct.Image = value;
            }
        }


        public ProductBtnUC(Product p)
        {
            InitializeComponent();
            if (p.Id > 0)
                Product = p;
            else
                Product = s_default;
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Product.Qty);
            OnPrdClick?.Invoke(this, Product);
            Console.WriteLine(Product.Qty);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ProductInfoForm form = new ProductInfoForm();
            form.Init(Product);
            form.Location = MousePosition;
            form.Show();
        }

        private void btnProduct_Enter(object sender, EventArgs e)
        {
            btnProduct.ImageSize = new Size(141, 141);
        }

        private void btnProduct_Leave(object sender, EventArgs e)
        {
            btnProduct.ImageSize = new Size(131, 131);
        }
    }
}
