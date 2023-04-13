using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollars
{
    public class CartProduct
    {
        private Product m_product;
        private int m_qty;
        private double m_discount;

        public double SubtotalNoDiscount { get; private set; }
        public double Subtotal { get; private set; }

        public Product Product
        {
            get
            {
                return m_product;
            }
            set
            {
                m_product = value;
                SubtotalNoDiscount = m_product.UnitPrice * m_qty;
            }
        }

        public int Qty
        {
            get
            {
                return m_qty;
            }
            set
            {
                m_qty = value;
                SubtotalNoDiscount = m_product.UnitPrice * m_qty;
            }
        }

        public double Discount
        {
            get
            {
                return m_discount;
            }
            set
            {
                m_discount = value;
                Subtotal = Utils.Clamp(SubtotalNoDiscount - m_discount, 0, double.MaxValue);
            }
        }


        public CartProduct(Product product, int qty)
        {
            m_product = product;
            m_qty = qty;
            SubtotalNoDiscount = m_product.UnitPrice * m_qty;
        }
    }

    public class Cart
    {
        private double m_total;
        private bool m_isDirty = false;

        public double TotalNoDiscount { get; private set; }
        public double Total
        {
            get
            {
                if (m_isDirty)
                {
                    m_total = CalcTotal();
                    m_isDirty = false;
                }

                return m_total;
            }
            private set
            {
                m_total = value;
            }
        }

        public List<CartProduct> Products { get; private set; }

        public Cart()
        {
            Products = new List<CartProduct>();
        }

        public void AddToCart(CartProduct product)
        {
            int i = Exists(product.Product.Id);
            if(i >= 0)
            {
                TotalNoDiscount -= Products[i].SubtotalNoDiscount;
                Products[i].Qty += product.Qty;
                TotalNoDiscount += Products[i].SubtotalNoDiscount;
            }
            else
            {
                Products.Add(product);
                TotalNoDiscount += product.SubtotalNoDiscount;
            }


            m_isDirty = true;
        }

        public void ApplyDiscounts(List<Discount> discounts)
        {
            foreach (CartProduct cb in Products)
            {
                cb.Discount = 0;

                foreach (Discount discount in discounts)
                {
                    if (discount.DiscountType == Discount.Type.Points) continue;


                    if (discount.ApplyDiscountOn == Discount.ApplyOn.All)
                    {
                        if (discount.Min > TotalNoDiscount) continue;

                        double d = 0.0;
                        if (discount.DiscountType == Discount.Type.Percentage)
                            d = cb.SubtotalNoDiscount * discount.Value * 0.01;
                        else if(discount.DiscountType == Discount.Type.Fixed)
                            d = cb.Qty * discount.Value;

                        cb.Discount += d;
                    }
                    else if(discount.ApplyDiscountOn == Discount.ApplyOn.Product 
                        && discount.ApplyOnID == cb.Product.Id)
                    {
                        if (discount.Min > cb.Qty) continue;

                        double d = 0.0;
                        if (discount.DiscountType == Discount.Type.Percentage)
                            d = cb.SubtotalNoDiscount * discount.Value * 0.01;
                        else if (discount.DiscountType == Discount.Type.Fixed)
                            d = cb.Qty * discount.Value;

                        cb.Discount += d;
                    }
                    else if(discount.ApplyDiscountOn == Discount.ApplyOn.Category)
                    {
                        bool sameOrAChild = false;
                        if (discount.ApplyOnID == cb.Product.Category.Id)
                        {
                            sameOrAChild = true;
                        }
                        else
                        {
                            foreach(ProductCategory c in DB.PrdCategoriesDB.GetParents(cb.Product.Category))
                            {
                                if (c.Id != discount.ApplyOnID) continue;

                                sameOrAChild = true;
                                break;
                            }
                        }

                        if (!sameOrAChild || discount.Min > TotalNoDiscount) continue;

                        double d = 0.0;
                        if (discount.DiscountType == Discount.Type.Percentage)
                            d = cb.SubtotalNoDiscount * discount.Value * 0.01;
                        else if (discount.DiscountType == Discount.Type.Fixed)
                            d = cb.Qty * discount.Value;

                        cb.Discount += d;
                    }
                }
            }

            m_isDirty = true;
        }

        public double GetTotalFromCategory(ProductCategory cat)
        {
            double total = 0.0;
            List<ProductCategory> cats = DB.PrdCategoriesDB.GetChildren(cat);
            cats.Add(cat);
            foreach (var prd in Products)
            {
                foreach(ProductCategory c in cats)
                {
                    if(prd.Product.Category.Id != c.Id) continue;

                    total += prd.Subtotal;
                    break;
                }
            }

            return total;
        }

        public CartProduct GetCartProduct(int prdID)
        {
            foreach(CartProduct prd in Products)
            {
                if(prd.Product.Id != prdID) continue;

                return prd;
            }

            return null;
        }


        /// <summary>
        /// return index of the item. returns -1 if it doesn't exists
        /// </summary>
        /// <param name="prdID"></param>
        /// <returns></returns>
        private int Exists(int prdID)
        {
            int index = -1;
            for(int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Product.Id != prdID) continue;

                index = i; 
                break;
            }

            return index;
        }

        private double CalcTotal()
        {
            double total = 0.0;
            foreach (CartProduct cb in Products)
                total += cb.Subtotal;
            return total;
        }

    }
}
