namespace Dollars
{
    partial class ManageDiscountForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSearchDiscountByApplyOn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSearchDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDiscounts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.checkBoxApplyAutomatic = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tbDiscountApplyOnPrd = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchPrd = new Guna.UI2.WinForms.Guna2Button();
            this.dpDiscountEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dpDiscountStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblValidity = new System.Windows.Forms.Label();
            this.cbDiscountApplyOnCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDiscountApplyOn = new System.Windows.Forms.Label();
            this.tbDiscountMin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.cbDiscountApplyOn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDiscountValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDiscountType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDiscountName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDiscountID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSearchDiscountByApplyOn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbSearchDiscount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 66);
            this.groupBox1.TabIndex = 21;
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
            this.cbSearchDiscountByApplyOn.Location = new System.Drawing.Point(685, 25);
            this.cbSearchDiscountByApplyOn.Name = "cbSearchDiscountByApplyOn";
            this.cbSearchDiscountByApplyOn.Size = new System.Drawing.Size(210, 24);
            this.cbSearchDiscountByApplyOn.StartIndex = 0;
            this.cbSearchDiscountByApplyOn.TabIndex = 100;
            this.cbSearchDiscountByApplyOn.TextOffset = new System.Drawing.Point(5, 0);
            this.cbSearchDiscountByApplyOn.SelectionChangeCommitted += new System.EventHandler(this.OnSearchDiscount);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label7.Location = new System.Drawing.Point(611, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 99;
            this.label7.Text = "Apply On:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tbSearchDiscount.Location = new System.Drawing.Point(104, 25);
            this.tbSearchDiscount.Name = "tbSearchDiscount";
            this.tbSearchDiscount.PasswordChar = '\0';
            this.tbSearchDiscount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchDiscount.PlaceholderText = "Type here...";
            this.tbSearchDiscount.SelectedText = "";
            this.tbSearchDiscount.Size = new System.Drawing.Size(406, 24);
            this.tbSearchDiscount.TabIndex = 9;
            this.tbSearchDiscount.TextChanged += new System.EventHandler(this.OnSearchDiscount);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiscounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvDiscounts.Location = new System.Drawing.Point(12, 136);
            this.dgvDiscounts.Name = "dgvDiscounts";
            this.dgvDiscounts.ReadOnly = true;
            this.dgvDiscounts.RowHeadersVisible = false;
            this.dgvDiscounts.Size = new System.Drawing.Size(606, 440);
            this.dgvDiscounts.TabIndex = 22;
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
            this.dgvDiscounts.ThemeStyle.ReadOnly = true;
            this.dgvDiscounts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvDiscounts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiscounts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiscounts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvDiscounts.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDiscounts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvDiscounts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDiscounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscounts_CellClick);
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
            this.panel1.Size = new System.Drawing.Size(1000, 25);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
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
            this.btnExit.Location = new System.Drawing.Point(974, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(626, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 447);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRICELIST INFORMATION";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(35, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 35);
            this.panel2.TabIndex = 87;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 16;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.White;
            this.btnSave.FocusedColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 35);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 16;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.FocusedColor = System.Drawing.Color.Black;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnDelete.IndicateFocus = true;
            this.btnDelete.Location = new System.Drawing.Point(152, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 35);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblEndDate);
            this.panel3.Controls.Add(this.lblStartDate);
            this.panel3.Controls.Add(this.checkBoxApplyAutomatic);
            this.panel3.Controls.Add(this.tbDiscountApplyOnPrd);
            this.panel3.Controls.Add(this.btnSearchPrd);
            this.panel3.Controls.Add(this.dpDiscountEndDate);
            this.panel3.Controls.Add(this.dpDiscountStartDate);
            this.panel3.Controls.Add(this.lblValidity);
            this.panel3.Controls.Add(this.cbDiscountApplyOnCat);
            this.panel3.Controls.Add(this.lblDiscountApplyOn);
            this.panel3.Controls.Add(this.tbDiscountMin);
            this.panel3.Controls.Add(this.lblMin);
            this.panel3.Controls.Add(this.cbDiscountApplyOn);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbDiscountValue);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbDiscountType);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbDiscountName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbDiscountID);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(19, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 354);
            this.panel3.TabIndex = 24;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lblEndDate.Location = new System.Drawing.Point(2, 300);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(94, 24);
            this.lblEndDate.TabIndex = 108;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEndDate.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lblStartDate.Location = new System.Drawing.Point(2, 270);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 24);
            this.lblStartDate.TabIndex = 107;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStartDate.Visible = false;
            // 
            // checkBoxApplyAutomatic
            // 
            this.checkBoxApplyAutomatic.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.checkBoxApplyAutomatic.CheckedState.BorderRadius = 0;
            this.checkBoxApplyAutomatic.CheckedState.BorderThickness = 0;
            this.checkBoxApplyAutomatic.CheckedState.FillColor = System.Drawing.Color.Black;
            this.checkBoxApplyAutomatic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxApplyAutomatic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.checkBoxApplyAutomatic.Location = new System.Drawing.Point(5, 213);
            this.checkBoxApplyAutomatic.Name = "checkBoxApplyAutomatic";
            this.checkBoxApplyAutomatic.Size = new System.Drawing.Size(126, 24);
            this.checkBoxApplyAutomatic.TabIndex = 102;
            this.checkBoxApplyAutomatic.Text = "Apply Automaticaly";
            this.checkBoxApplyAutomatic.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.checkBoxApplyAutomatic.UncheckedState.BorderRadius = 0;
            this.checkBoxApplyAutomatic.UncheckedState.BorderThickness = 0;
            this.checkBoxApplyAutomatic.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.checkBoxApplyAutomatic.CheckedChanged += new System.EventHandler(this.checkBoxApplyAutomatic_CheckedChanged);
            // 
            // tbDiscountApplyOnPrd
            // 
            this.tbDiscountApplyOnPrd.Animated = true;
            this.tbDiscountApplyOnPrd.BorderRadius = 5;
            this.tbDiscountApplyOnPrd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiscountApplyOnPrd.DefaultText = "";
            this.tbDiscountApplyOnPrd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiscountApplyOnPrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiscountApplyOnPrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountApplyOnPrd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountApplyOnPrd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbDiscountApplyOnPrd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbDiscountApplyOnPrd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscountApplyOnPrd.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbDiscountApplyOnPrd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbDiscountApplyOnPrd.Location = new System.Drawing.Point(102, 183);
            this.tbDiscountApplyOnPrd.Name = "tbDiscountApplyOnPrd";
            this.tbDiscountApplyOnPrd.PasswordChar = '\0';
            this.tbDiscountApplyOnPrd.PlaceholderText = "";
            this.tbDiscountApplyOnPrd.ReadOnly = true;
            this.tbDiscountApplyOnPrd.SelectedText = "";
            this.tbDiscountApplyOnPrd.Size = new System.Drawing.Size(189, 24);
            this.tbDiscountApplyOnPrd.TabIndex = 101;
            this.tbDiscountApplyOnPrd.TextOffset = new System.Drawing.Point(5, 0);
            this.tbDiscountApplyOnPrd.Visible = false;
            // 
            // btnSearchPrd
            // 
            this.btnSearchPrd.Animated = true;
            this.btnSearchPrd.AutoRoundedCorners = true;
            this.btnSearchPrd.BorderRadius = 11;
            this.btnSearchPrd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchPrd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchPrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchPrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchPrd.FillColor = System.Drawing.Color.White;
            this.btnSearchPrd.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnSearchPrd.ForeColor = System.Drawing.Color.Black;
            this.btnSearchPrd.Image = global::Dollars.ImageRes.search;
            this.btnSearchPrd.ImageSize = new System.Drawing.Size(15, 15);
            this.btnSearchPrd.Location = new System.Drawing.Point(297, 183);
            this.btnSearchPrd.Name = "btnSearchPrd";
            this.btnSearchPrd.Size = new System.Drawing.Size(24, 24);
            this.btnSearchPrd.TabIndex = 91;
            this.btnSearchPrd.TabStop = false;
            this.btnSearchPrd.Visible = false;
            this.btnSearchPrd.Click += new System.EventHandler(this.btnSearchPrd_Click);
            // 
            // dpDiscountEndDate
            // 
            this.dpDiscountEndDate.Animated = true;
            this.dpDiscountEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpDiscountEndDate.BorderRadius = 5;
            this.dpDiscountEndDate.BorderThickness = 1;
            this.dpDiscountEndDate.Checked = true;
            this.dpDiscountEndDate.CustomFormat = "";
            this.dpDiscountEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpDiscountEndDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDiscountEndDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.dpDiscountEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDiscountEndDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.dpDiscountEndDate.Location = new System.Drawing.Point(102, 300);
            this.dpDiscountEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpDiscountEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpDiscountEndDate.Name = "dpDiscountEndDate";
            this.dpDiscountEndDate.Size = new System.Drawing.Size(219, 24);
            this.dpDiscountEndDate.TabIndex = 105;
            this.dpDiscountEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dpDiscountEndDate.Value = new System.DateTime(2023, 4, 3, 0, 0, 0, 0);
            this.dpDiscountEndDate.Visible = false;
            // 
            // dpDiscountStartDate
            // 
            this.dpDiscountStartDate.Animated = true;
            this.dpDiscountStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpDiscountStartDate.BorderRadius = 5;
            this.dpDiscountStartDate.BorderThickness = 1;
            this.dpDiscountStartDate.Checked = true;
            this.dpDiscountStartDate.CustomFormat = "";
            this.dpDiscountStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpDiscountStartDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dpDiscountStartDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.dpDiscountStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDiscountStartDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.dpDiscountStartDate.Location = new System.Drawing.Point(102, 270);
            this.dpDiscountStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpDiscountStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpDiscountStartDate.Name = "dpDiscountStartDate";
            this.dpDiscountStartDate.Size = new System.Drawing.Size(219, 24);
            this.dpDiscountStartDate.TabIndex = 103;
            this.dpDiscountStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dpDiscountStartDate.Value = new System.DateTime(2023, 4, 3, 0, 0, 0, 0);
            this.dpDiscountStartDate.Visible = false;
            // 
            // lblValidity
            // 
            this.lblValidity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidity.ForeColor = System.Drawing.Color.DimGray;
            this.lblValidity.Location = new System.Drawing.Point(2, 243);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(94, 24);
            this.lblValidity.TabIndex = 102;
            this.lblValidity.Text = "- Validity -";
            this.lblValidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidity.Visible = false;
            // 
            // cbDiscountApplyOnCat
            // 
            this.cbDiscountApplyOnCat.BackColor = System.Drawing.Color.Transparent;
            this.cbDiscountApplyOnCat.BorderRadius = 5;
            this.cbDiscountApplyOnCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDiscountApplyOnCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscountApplyOnCat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.cbDiscountApplyOnCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbDiscountApplyOnCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbDiscountApplyOnCat.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbDiscountApplyOnCat.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbDiscountApplyOnCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbDiscountApplyOnCat.ItemHeight = 18;
            this.cbDiscountApplyOnCat.Location = new System.Drawing.Point(102, 183);
            this.cbDiscountApplyOnCat.Name = "cbDiscountApplyOnCat";
            this.cbDiscountApplyOnCat.Size = new System.Drawing.Size(219, 24);
            this.cbDiscountApplyOnCat.TabIndex = 100;
            this.cbDiscountApplyOnCat.TextOffset = new System.Drawing.Point(5, 0);
            this.cbDiscountApplyOnCat.Visible = false;
            // 
            // lblDiscountApplyOn
            // 
            this.lblDiscountApplyOn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountApplyOn.ForeColor = System.Drawing.Color.Black;
            this.lblDiscountApplyOn.Location = new System.Drawing.Point(2, 183);
            this.lblDiscountApplyOn.Name = "lblDiscountApplyOn";
            this.lblDiscountApplyOn.Size = new System.Drawing.Size(94, 24);
            this.lblDiscountApplyOn.TabIndex = 99;
            this.lblDiscountApplyOn.Text = "...:";
            this.lblDiscountApplyOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiscountApplyOn.Visible = false;
            // 
            // tbDiscountMin
            // 
            this.tbDiscountMin.Animated = true;
            this.tbDiscountMin.BorderRadius = 5;
            this.tbDiscountMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiscountMin.DefaultText = "";
            this.tbDiscountMin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiscountMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiscountMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountMin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbDiscountMin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbDiscountMin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscountMin.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbDiscountMin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbDiscountMin.Location = new System.Drawing.Point(102, 153);
            this.tbDiscountMin.Name = "tbDiscountMin";
            this.tbDiscountMin.PasswordChar = '\0';
            this.tbDiscountMin.PlaceholderText = "0.00";
            this.tbDiscountMin.SelectedText = "";
            this.tbDiscountMin.Size = new System.Drawing.Size(219, 24);
            this.tbDiscountMin.TabIndex = 98;
            this.tbDiscountMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDiscountMin.TextOffset = new System.Drawing.Point(5, 0);
            this.tbDiscountMin.TextChanged += new System.EventHandler(this.tbPricelistMin_TextChanged);
            this.tbDiscountMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPricelistMin_KeyPress);
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lblMin.Location = new System.Drawing.Point(2, 153);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(94, 24);
            this.lblMin.TabIndex = 97;
            this.lblMin.Text = "Min. Price:";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDiscountApplyOn
            // 
            this.cbDiscountApplyOn.BackColor = System.Drawing.Color.Transparent;
            this.cbDiscountApplyOn.BorderRadius = 5;
            this.cbDiscountApplyOn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDiscountApplyOn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscountApplyOn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.cbDiscountApplyOn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbDiscountApplyOn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbDiscountApplyOn.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbDiscountApplyOn.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbDiscountApplyOn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbDiscountApplyOn.ItemHeight = 18;
            this.cbDiscountApplyOn.Items.AddRange(new object[] {
            "All",
            "Category",
            "Product"});
            this.cbDiscountApplyOn.Location = new System.Drawing.Point(102, 123);
            this.cbDiscountApplyOn.Name = "cbDiscountApplyOn";
            this.cbDiscountApplyOn.Size = new System.Drawing.Size(219, 24);
            this.cbDiscountApplyOn.StartIndex = 0;
            this.cbDiscountApplyOn.TabIndex = 96;
            this.cbDiscountApplyOn.TextOffset = new System.Drawing.Point(5, 0);
            this.cbDiscountApplyOn.SelectionChangeCommitted += new System.EventHandler(this.cbPricelistApplyOn_SelectionChangeCommitted);
            this.cbDiscountApplyOn.TextChanged += new System.EventHandler(this.cbPricelistApplyOn_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label6.Location = new System.Drawing.Point(2, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 95;
            this.label6.Text = "Apply On:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDiscountValue
            // 
            this.tbDiscountValue.Animated = true;
            this.tbDiscountValue.BorderRadius = 5;
            this.tbDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiscountValue.DefaultText = "";
            this.tbDiscountValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiscountValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiscountValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbDiscountValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbDiscountValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscountValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbDiscountValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbDiscountValue.Location = new System.Drawing.Point(102, 93);
            this.tbDiscountValue.Name = "tbDiscountValue";
            this.tbDiscountValue.PasswordChar = '\0';
            this.tbDiscountValue.PlaceholderText = "0.00";
            this.tbDiscountValue.SelectedText = "";
            this.tbDiscountValue.Size = new System.Drawing.Size(219, 24);
            this.tbDiscountValue.TabIndex = 94;
            this.tbDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDiscountValue.TextOffset = new System.Drawing.Point(5, 0);
            this.tbDiscountValue.TextChanged += new System.EventHandler(this.tbPricelistValue_TextChanged);
            this.tbDiscountValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPricelistValue_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(2, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "Value:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDiscountType
            // 
            this.cbDiscountType.BackColor = System.Drawing.Color.Transparent;
            this.cbDiscountType.BorderRadius = 5;
            this.cbDiscountType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscountType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.cbDiscountType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbDiscountType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbDiscountType.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbDiscountType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbDiscountType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.cbDiscountType.ItemHeight = 18;
            this.cbDiscountType.Items.AddRange(new object[] {
            "Percentage",
            "Fixed",
            "Points"});
            this.cbDiscountType.Location = new System.Drawing.Point(102, 63);
            this.cbDiscountType.Name = "cbDiscountType";
            this.cbDiscountType.Size = new System.Drawing.Size(219, 24);
            this.cbDiscountType.StartIndex = 0;
            this.cbDiscountType.TabIndex = 92;
            this.cbDiscountType.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(2, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 90;
            this.label5.Text = "Type:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDiscountName
            // 
            this.tbDiscountName.Animated = true;
            this.tbDiscountName.BorderRadius = 5;
            this.tbDiscountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiscountName.DefaultText = "";
            this.tbDiscountName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiscountName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiscountName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbDiscountName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbDiscountName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscountName.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbDiscountName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbDiscountName.Location = new System.Drawing.Point(102, 33);
            this.tbDiscountName.Name = "tbDiscountName";
            this.tbDiscountName.PasswordChar = '\0';
            this.tbDiscountName.PlaceholderText = "";
            this.tbDiscountName.SelectedText = "";
            this.tbDiscountName.Size = new System.Drawing.Size(219, 24);
            this.tbDiscountName.TabIndex = 89;
            this.tbDiscountName.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(2, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 88;
            this.label4.Text = "Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDiscountID
            // 
            this.tbDiscountID.Animated = true;
            this.tbDiscountID.BorderRadius = 5;
            this.tbDiscountID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiscountID.DefaultText = "";
            this.tbDiscountID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiscountID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiscountID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscountID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbDiscountID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbDiscountID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscountID.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbDiscountID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbDiscountID.Location = new System.Drawing.Point(102, 3);
            this.tbDiscountID.Name = "tbDiscountID";
            this.tbDiscountID.PasswordChar = '\0';
            this.tbDiscountID.PlaceholderText = "";
            this.tbDiscountID.SelectedText = "";
            this.tbDiscountID.Size = new System.Drawing.Size(219, 24);
            this.tbDiscountID.TabIndex = 87;
            this.tbDiscountID.TextOffset = new System.Drawing.Point(5, 0);
            this.tbDiscountID.TextChanged += new System.EventHandler(this.tbPricelistID_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label9.Location = new System.Drawing.Point(2, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 86;
            this.label9.Text = "ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManageDiscountForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDiscounts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ManageDiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManagePriceList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageDiscountForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchDiscount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiscounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnSearchPrd;
        private Guna.UI2.WinForms.Guna2TextBox tbDiscountName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbDiscountID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox tbDiscountApplyOnPrd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpDiscountEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpDiscountStartDate;
        private System.Windows.Forms.Label lblValidity;
        private Guna.UI2.WinForms.Guna2ComboBox cbDiscountApplyOnCat;
        private System.Windows.Forms.Label lblDiscountApplyOn;
        private Guna.UI2.WinForms.Guna2TextBox tbDiscountMin;
        private System.Windows.Forms.Label lblMin;
        private Guna.UI2.WinForms.Guna2ComboBox cbDiscountApplyOn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbDiscountValue;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbDiscountType;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxApplyAutomatic;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchDiscountByApplyOn;
        private System.Windows.Forms.Label label7;
    }
}