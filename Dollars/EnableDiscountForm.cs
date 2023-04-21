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
    public partial class EnableDiscountForm : Form, IChildForm
    {
        private DataTable m_dtDiscounts;
        private List<Discount> m_activeDiscounts;

        public Action OnChildFormClosed { get; set; }

        public EnableDiscountForm()
        {
            InitializeComponent();
        }

        public void Init(List<Discount> outActiveDiscounts)
        {
            m_activeDiscounts = outActiveDiscounts;

            m_dtDiscounts = new DataTable();
            m_dtDiscounts.Columns.Add("ID");
            m_dtDiscounts.Columns.Add("Name");
            m_dtDiscounts.Columns.Add("Type");
            m_dtDiscounts.Columns.Add("Value");
            m_dtDiscounts.Columns.Add("Apply On");
            m_dtDiscounts.Columns.Add("Min. Price/Units");
            m_dtDiscounts.Columns.Add("Validity");

            dgvColumnValue.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvColumnMin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            LoadDiscounts();
            ShowDiscounts(m_dtDiscounts);
        }

        private void LoadDiscounts()
        {
            m_dtDiscounts.Rows.Clear();
            foreach (Discount discount in DB.DiscountDB.Discounts)
            {
                string applyOnName = discount.ApplyDiscountOn.ToString();
                if (discount.ApplyDiscountOn == Discount.ApplyOn.Product)
                    applyOnName = DB.ProductsDB.Get(discount.ApplyOnID).Name + " (" + discount.ApplyDiscountOn.ToString() + ")";
                else if (discount.ApplyDiscountOn == Discount.ApplyOn.Category)
                    applyOnName = DB.PrdCategoriesDB.Get(discount.ApplyOnID).Category + " (" + discount.ApplyDiscountOn.ToString() + ")";

                string validity = "";
                if (discount.ApplyAutomatically)
                    validity = discount.StartDate.ToString("d") + " -> " + discount.EndDate.ToString("d");

                string min;
                if (discount.ApplyDiscountOn == Discount.ApplyOn.Product)
                    min = discount.Min.ToString() + " Units";
                else
                    min = Utils.DisplayCash(discount.Min);

                m_dtDiscounts.Rows.Add(
                    discount.Id,
                    discount.Name,
                    discount.DiscountType.ToString(),
                    Utils.DisplayCash(discount.Value),
                    applyOnName,
                    min,
                    validity
                    );
            }
        }

        private void ShowDiscounts(DataTable dt)
        {
            // This is a hack
            // because when I set DGV.DataSource to DataTable I can't Programatically change Checkbox value

            dgvDiscounts.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                bool isEnabled = false;
                foreach(Discount discount in m_activeDiscounts)
                {
                    if (int.Parse(row["ID"].ToString()) == discount.Id)
                    {
                        isEnabled = true;
                        break;
                    }
                }

                dgvDiscounts.Rows.Add(
                    row["ID"],
                    row["Name"],
                    row["Type"],
                    row["Value"],
                    row["Apply On"],
                    row["Min. Price/Units"],
                    row["Validity"],
                    isEnabled
                    );
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDiscounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvDiscounts[e.ColumnIndex, e.RowIndex];

            if (e.RowIndex < 0 || !(cell is DataGridViewCheckBoxCell)) return;

            // todo cell content click happens before check box updated (Solved)
            // Solution https://stackoverflow.com/questions/20790640/datagridviewcheckboxcell-click-handling-issue

            int selectedID = int.Parse(dgvDiscounts[dgvColumnID.Index, e.RowIndex].Value.ToString());

            if(cell.Value == null) cell.Value = false;
            cell.Value = !Convert.ToBoolean(cell.Value);
            dgvDiscounts.EndEdit();
            

            if (Convert.ToBoolean(cell.Value))
            {
                m_activeDiscounts.Add(DB.DiscountDB.Get(selectedID));
            }
            else
            {
                for (int i = m_activeDiscounts.Count - 1; i >= 0; i--)
                {
                    if (m_activeDiscounts[i].Id != selectedID) continue;

                    m_activeDiscounts.RemoveAt(i);
                    break;
                }
            }
        }

        private void OnSearchDiscount(object sender, EventArgs e)
        {
            DataView dv = m_dtDiscounts.DefaultView;

            if(cbSearchDiscountByApplyOn.SelectedIndex == (int)Discount.ApplyOn.All)
                dv.RowFilter = string.Format("Name LIKE '%{0}%'", tbSearchDiscount.Text);
            else
                dv.RowFilter = string.Format("Name LIKE '%{0}%' AND [Apply On] LIKE '%{1}%'", 
                    tbSearchDiscount.Text, ((Discount.ApplyOn)cbSearchDiscountByApplyOn.SelectedIndex).ToString());

            ShowDiscounts(dv.ToTable());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // https://stackoverflow.com/questions/3172731/forms-not-responding-to-keydown-events

            if (keyData == Keys.Escape)
            {
                btnExit_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void EnableDiscountForm_FormClosing(object sender, FormClosingEventArgs e)
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
