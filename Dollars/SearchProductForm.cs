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
    public partial class SearchProductForm : Form, IChildForm
    {
        private List<ProductBtnUC> m_prdBtns;
        private List<Product> m_products;

        private DataTable m_dtProducts;

        private bool m_isPos;

        public Action OnChildFormClosed { get; set; }
        public Action<Product> OnProductSelected { get; set; }
        public Action<Product, int> OnProductSelectedQty { get; set; }

        

        public SearchProductForm()
        {
            InitializeComponent();
        }

        // products will be change if isPos=true so pass a copy of ProductsDB.Products
        public void Init(List<Product> products, bool isPos = false)
        {
            m_products = products;
            m_isPos = isPos;
            SetCategory();
            SetButtons();
            ShowProducts(m_dtProducts);
        }

        private void SetCategory()
        {
            cbSearchPrdByCat.Items.Clear();
            cbSearchPrdByCat.Items.Add("");
            foreach (ProductCategory cat in DB.PrdCategoriesDB.Categories)
            {
                cbSearchPrdByCat.Items.Add(cat.Category);
            }
        }

        private void SetButtons()
        {
            m_dtProducts = new DataTable();
            m_dtProducts.Columns.Add("ID");
            m_dtProducts.Columns.Add("Name");
            m_dtProducts.Columns.Add("Category");

            m_prdBtns = new List<ProductBtnUC>();
            foreach (Product product in m_products)
            {
                m_dtProducts.Rows.Add(
                    product.Id,
                    product.Name,
                    Utils.ConcatCategories(product.Category)
                    );

                ProductBtnUC btn = new ProductBtnUC(product);
                btn.OnPrdClick += ProductBtnClick;
                btn.Visible = false;
                flpProducts.Controls.Add(btn);

                m_prdBtns.Add(btn);
            }
        }

        private void ShowProducts(DataTable dt)
        {
            foreach(ProductBtnUC btn in m_prdBtns)
            {
                btn.Visible = false;

                foreach(DataRow row in dt.Rows)
                {
                    if (int.Parse(row["ID"].ToString()) == btn.Product.Id)
                    {
                        btn.Visible = true;
                        break;
                    }
                }
            }
        }

        private void ProductBtnClick(ProductBtnUC sender, Product p)
        {
            OnProductSelected?.Invoke(p);

            if (!m_isPos) return;

            EnterQuantityForm form = new EnterQuantityForm();
            form.MaxQty(p.Qty);

            form.OnBtnOKClick += (int qty) =>
            {
                for (int i = 0; i < m_products.Count; i++)
                {
                    if (m_products[i].Id != p.Id) continue;

                    Product product = m_products[i];
                    product.Qty -= qty;

                    m_products[i] = product;
                    sender.Product = product;

                    OnProductSelectedQty?.Invoke(product, qty);
                    break;
                }
            };

            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnSearchProduct(object sender, EventArgs e)
        {
            DataView dv = m_dtProducts.DefaultView;

            string srch = int.TryParse(tbSearchPrd.Text, out _) ? "ID" : "Name";

            if (cbSearchPrdByCat.Text == "")
                dv.RowFilter = string.Format(srch + " LIKE '%{0}%'", tbSearchPrd.Text);
            else
                dv.RowFilter = string.Format(srch + " LIKE '%{0}%' AND Category LIKE '%{1}%'", tbSearchPrd.Text, cbSearchPrdByCat.Text);

            ShowProducts(dv.ToTable());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // https://stackoverflow.com/questions/3172731/forms-not-responding-to-keydown-events

            if(keyData == Keys.Escape) 
            {
                btnExit_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SearchProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnChildFormClosed?.Invoke();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= Utils.CS_DROPSHADOW;
                return cp;
            }
        }
    }
}
