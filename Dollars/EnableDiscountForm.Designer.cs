namespace Dollars
{
    partial class EnableDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSearchDiscountByApplyOn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSearchDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDiscounts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnApplyOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnValidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "DISCOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(884, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 25);
            this.panel1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSearchDiscountByApplyOn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbSearchDiscount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 66);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADVANCE SEARCH";
            // 
            // cbSearchDiscountByApplyOn
            // 
            this.cbSearchDiscountByApplyOn.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchDiscountByApplyOn.BorderRadius = 5;
            this.cbSearchDiscountByApplyOn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchDiscountByApplyOn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchDiscountByApplyOn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.cbSearchDiscountByApplyOn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbSearchDiscountByApplyOn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbSearchDiscountByApplyOn.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbSearchDiscountByApplyOn.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbSearchDiscountByApplyOn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbSearchDiscountByApplyOn.ItemHeight = 18;
            this.cbSearchDiscountByApplyOn.Items.AddRange(new object[] {
            "All",
            "Category",
            "Product"});
            this.cbSearchDiscountByApplyOn.Location = new System.Drawing.Point(610, 25);
            this.cbSearchDiscountByApplyOn.Name = "cbSearchDiscountByApplyOn";
            this.cbSearchDiscountByApplyOn.Size = new System.Drawing.Size(210, 24);
            this.cbSearchDiscountByApplyOn.StartIndex = 0;
            this.cbSearchDiscountByApplyOn.TabIndex = 98;
            this.cbSearchDiscountByApplyOn.TextOffset = new System.Drawing.Point(5, 0);
            this.cbSearchDiscountByApplyOn.SelectionChangeCommitted += new System.EventHandler(this.OnSearchDiscount);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label6.Location = new System.Drawing.Point(536, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 97;
            this.label6.Text = "Apply On:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSearchDiscount
            // 
            this.tbSearchDiscount.Animated = true;
            this.tbSearchDiscount.BorderRadius = 5;
            this.tbSearchDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchDiscount.DefaultText = "";
            this.tbSearchDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchDiscount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbSearchDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchDiscount.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbSearchDiscount.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbSearchDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchDiscount.IconLeft = global::Dollars.ImageRes.search;
            this.tbSearchDiscount.IconLeftSize = new System.Drawing.Size(15, 15);
            this.tbSearchDiscount.Location = new System.Drawing.Point(107, 25);
            this.tbSearchDiscount.Name = "tbSearchDiscount";
            this.tbSearchDiscount.PasswordChar = '\0';
            this.tbSearchDiscount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchDiscount.PlaceholderText = "Type here...";
            this.tbSearchDiscount.SelectedText = "";
            this.tbSearchDiscount.Size = new System.Drawing.Size(349, 24);
            this.tbSearchDiscount.TabIndex = 9;
            this.tbSearchDiscount.TextChanged += new System.EventHandler(this.OnSearchDiscount);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(48, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDiscounts
            // 
            this.dgvDiscounts.AllowUserToAddRows = false;
            this.dgvDiscounts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvDiscounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiscounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvDiscounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiscounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiscounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnID,
            this.dgvColumnName,
            this.dgvColumnType,
            this.dgvColumnValue,
            this.dgvColumnApplyOn,
            this.dgvColumnMin,
            this.dgvColumnValidity,
            this.dgvColumnCheckBox});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiscounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvDiscounts.Location = new System.Drawing.Point(12, 114);
            this.dgvDiscounts.Name = "dgvDiscounts";
            this.dgvDiscounts.RowHeadersVisible = false;
            this.dgvDiscounts.Size = new System.Drawing.Size(886, 494);
            this.dgvDiscounts.TabIndex = 33;
            this.dgvDiscounts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvDiscounts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvDiscounts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDiscounts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDiscounts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDiscounts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDiscounts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiscounts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvDiscounts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvDiscounts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDiscounts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiscounts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiscounts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiscounts.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvDiscounts.ThemeStyle.ReadOnly = false;
            this.dgvDiscounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvDiscounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiscounts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiscounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvDiscounts.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDiscounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvDiscounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDiscounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscounts_CellClick);
            // 
            // dgvColumnID
            // 
            this.dgvColumnID.FillWeight = 36.1991F;
            this.dgvColumnID.HeaderText = "ID";
            this.dgvColumnID.Name = "dgvColumnID";
            this.dgvColumnID.ReadOnly = true;
            this.dgvColumnID.Width = 40;
            // 
            // dgvColumnName
            // 
            this.dgvColumnName.FillWeight = 157.4453F;
            this.dgvColumnName.HeaderText = "Name";
            this.dgvColumnName.Name = "dgvColumnName";
            this.dgvColumnName.ReadOnly = true;
            this.dgvColumnName.Width = 174;
            // 
            // dgvColumnType
            // 
            this.dgvColumnType.FillWeight = 102.3354F;
            this.dgvColumnType.HeaderText = "Type";
            this.dgvColumnType.Name = "dgvColumnType";
            this.dgvColumnType.ReadOnly = true;
            this.dgvColumnType.Width = 113;
            // 
            // dgvColumnValue
            // 
            this.dgvColumnValue.FillWeight = 103.0377F;
            this.dgvColumnValue.HeaderText = "Value";
            this.dgvColumnValue.Name = "dgvColumnValue";
            this.dgvColumnValue.ReadOnly = true;
            this.dgvColumnValue.Width = 114;
            // 
            // dgvColumnApplyOn
            // 
            this.dgvColumnApplyOn.FillWeight = 146.3767F;
            this.dgvColumnApplyOn.HeaderText = "Apply On";
            this.dgvColumnApplyOn.Name = "dgvColumnApplyOn";
            this.dgvColumnApplyOn.ReadOnly = true;
            this.dgvColumnApplyOn.Width = 162;
            // 
            // dgvColumnMin
            // 
            this.dgvColumnMin.FillWeight = 96.03783F;
            this.dgvColumnMin.HeaderText = "Min. Price/Units";
            this.dgvColumnMin.Name = "dgvColumnMin";
            this.dgvColumnMin.ReadOnly = true;
            this.dgvColumnMin.Width = 106;
            // 
            // dgvColumnValidity
            // 
            this.dgvColumnValidity.FillWeight = 138.9001F;
            this.dgvColumnValidity.HeaderText = "Validity";
            this.dgvColumnValidity.Name = "dgvColumnValidity";
            this.dgvColumnValidity.ReadOnly = true;
            this.dgvColumnValidity.Width = 153;
            // 
            // dgvColumnCheckBox
            // 
            this.dgvColumnCheckBox.FalseValue = "false";
            this.dgvColumnCheckBox.FillWeight = 19.66799F;
            this.dgvColumnCheckBox.HeaderText = "";
            this.dgvColumnCheckBox.Name = "dgvColumnCheckBox";
            this.dgvColumnCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColumnCheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvColumnCheckBox.TrueValue = "true";
            this.dgvColumnCheckBox.Width = 22;
            // 
            // EnableDiscountForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDiscounts);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EnableDiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ActivatePricelistForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnableDiscountForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchDiscount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiscounts;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchDiscountByApplyOn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnApplyOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnValidity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnCheckBox;
    }
}