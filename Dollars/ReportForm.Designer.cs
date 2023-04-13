namespace Dollars
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.tcTabCriticalStocks = new System.Windows.Forms.TabPage();
            this.lblCriticalStocks = new System.Windows.Forms.Label();
            this.dgvCriticalStocks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvCriticalStocksCPrdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCriticalStocksCPrdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCriticalStocksCPrdCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCriticalStocksCUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCriticalStocksCStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcTabStockIn = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSearchPrd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvStockInHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tcTabTransactions = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSearchTransByCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchTransByCashier = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchTransByNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalTransactions = new System.Windows.Forms.Label();
            this.dgvTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tcReports = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tcTabCriticalStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticalStocks)).BeginInit();
            this.tcTabStockIn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockInHistory)).BeginInit();
            this.tcTabTransactions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.tcReports.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "REPORT";
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
            // tcTabCriticalStocks
            // 
            this.tcTabCriticalStocks.Controls.Add(this.lblCriticalStocks);
            this.tcTabCriticalStocks.Controls.Add(this.dgvCriticalStocks);
            this.tcTabCriticalStocks.Location = new System.Drawing.Point(4, 24);
            this.tcTabCriticalStocks.Name = "tcTabCriticalStocks";
            this.tcTabCriticalStocks.Size = new System.Drawing.Size(968, 492);
            this.tcTabCriticalStocks.TabIndex = 3;
            this.tcTabCriticalStocks.Text = "Critical Stocks";
            this.tcTabCriticalStocks.UseVisualStyleBackColor = true;
            // 
            // lblCriticalStocks
            // 
            this.lblCriticalStocks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticalStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lblCriticalStocks.Location = new System.Drawing.Point(46, 443);
            this.lblCriticalStocks.Name = "lblCriticalStocks";
            this.lblCriticalStocks.Size = new System.Drawing.Size(351, 24);
            this.lblCriticalStocks.TabIndex = 77;
            this.lblCriticalStocks.Text = "Total Critical Stocks: 0";
            this.lblCriticalStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCriticalStocks
            // 
            this.dgvCriticalStocks.AllowUserToAddRows = false;
            this.dgvCriticalStocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCriticalStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCriticalStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCriticalStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCriticalStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCriticalStocksCPrdID,
            this.dgvCriticalStocksCPrdName,
            this.dgvCriticalStocksCPrdCategory,
            this.dgvCriticalStocksCUnitPrice,
            this.dgvCriticalStocksCStock});
            this.dgvCriticalStocks.DataMember = " ";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCriticalStocks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCriticalStocks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCriticalStocks.Location = new System.Drawing.Point(49, 28);
            this.dgvCriticalStocks.Name = "dgvCriticalStocks";
            this.dgvCriticalStocks.ReadOnly = true;
            this.dgvCriticalStocks.RowHeadersVisible = false;
            this.dgvCriticalStocks.Size = new System.Drawing.Size(870, 412);
            this.dgvCriticalStocks.TabIndex = 76;
            this.dgvCriticalStocks.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvCriticalStocks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCriticalStocks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCriticalStocks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCriticalStocks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCriticalStocks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCriticalStocks.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCriticalStocks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCriticalStocks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvCriticalStocks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCriticalStocks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCriticalStocks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCriticalStocks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCriticalStocks.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvCriticalStocks.ThemeStyle.ReadOnly = true;
            this.dgvCriticalStocks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvCriticalStocks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCriticalStocks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCriticalStocks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvCriticalStocks.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCriticalStocks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvCriticalStocks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dgvCriticalStocksCPrdID
            // 
            this.dgvCriticalStocksCPrdID.FillWeight = 35F;
            this.dgvCriticalStocksCPrdID.HeaderText = "Product ID";
            this.dgvCriticalStocksCPrdID.Name = "dgvCriticalStocksCPrdID";
            this.dgvCriticalStocksCPrdID.ReadOnly = true;
            // 
            // dgvCriticalStocksCPrdName
            // 
            this.dgvCriticalStocksCPrdName.HeaderText = "Product Name";
            this.dgvCriticalStocksCPrdName.Name = "dgvCriticalStocksCPrdName";
            this.dgvCriticalStocksCPrdName.ReadOnly = true;
            // 
            // dgvCriticalStocksCPrdCategory
            // 
            this.dgvCriticalStocksCPrdCategory.HeaderText = "Category";
            this.dgvCriticalStocksCPrdCategory.Name = "dgvCriticalStocksCPrdCategory";
            this.dgvCriticalStocksCPrdCategory.ReadOnly = true;
            // 
            // dgvCriticalStocksCUnitPrice
            // 
            this.dgvCriticalStocksCUnitPrice.FillWeight = 50F;
            this.dgvCriticalStocksCUnitPrice.HeaderText = "Unit Price";
            this.dgvCriticalStocksCUnitPrice.Name = "dgvCriticalStocksCUnitPrice";
            this.dgvCriticalStocksCUnitPrice.ReadOnly = true;
            // 
            // dgvCriticalStocksCStock
            // 
            this.dgvCriticalStocksCStock.FillWeight = 50F;
            this.dgvCriticalStocksCStock.HeaderText = "Stock on Hand";
            this.dgvCriticalStocksCStock.Name = "dgvCriticalStocksCStock";
            this.dgvCriticalStocksCStock.ReadOnly = true;
            // 
            // tcTabStockIn
            // 
            this.tcTabStockIn.Controls.Add(this.groupBox2);
            this.tcTabStockIn.Controls.Add(this.dgvStockInHistory);
            this.tcTabStockIn.Location = new System.Drawing.Point(4, 24);
            this.tcTabStockIn.Name = "tcTabStockIn";
            this.tcTabStockIn.Size = new System.Drawing.Size(968, 492);
            this.tcTabStockIn.TabIndex = 2;
            this.tcTabStockIn.Text = "Stock in History";
            this.tcTabStockIn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSearchPrd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(49, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 66);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADVANCE SEARCH";
            // 
            // tbSearchPrd
            // 
            this.tbSearchPrd.Animated = true;
            this.tbSearchPrd.BorderRadius = 5;
            this.tbSearchPrd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchPrd.DefaultText = "";
            this.tbSearchPrd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchPrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchPrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchPrd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchPrd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbSearchPrd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchPrd.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbSearchPrd.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbSearchPrd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchPrd.IconLeft = global::Dollars.ImageRes.search;
            this.tbSearchPrd.IconLeftSize = new System.Drawing.Size(15, 15);
            this.tbSearchPrd.Location = new System.Drawing.Point(104, 25);
            this.tbSearchPrd.Name = "tbSearchPrd";
            this.tbSearchPrd.PasswordChar = '\0';
            this.tbSearchPrd.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchPrd.PlaceholderText = "Type here...";
            this.tbSearchPrd.SelectedText = "";
            this.tbSearchPrd.Size = new System.Drawing.Size(383, 24);
            this.tbSearchPrd.TabIndex = 9;
            this.tbSearchPrd.TextChanged += new System.EventHandler(this.tbSearchPrd_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label7.Location = new System.Drawing.Point(32, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Product:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvStockInHistory
            // 
            this.dgvStockInHistory.AllowUserToAddRows = false;
            this.dgvStockInHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvStockInHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStockInHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockInHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStockInHistory.DataMember = " ";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockInHistory.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStockInHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvStockInHistory.Location = new System.Drawing.Point(49, 78);
            this.dgvStockInHistory.Name = "dgvStockInHistory";
            this.dgvStockInHistory.ReadOnly = true;
            this.dgvStockInHistory.RowHeadersVisible = false;
            this.dgvStockInHistory.Size = new System.Drawing.Size(870, 362);
            this.dgvStockInHistory.TabIndex = 74;
            this.dgvStockInHistory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvStockInHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvStockInHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStockInHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStockInHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStockInHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStockInHistory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStockInHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvStockInHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvStockInHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStockInHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStockInHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStockInHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStockInHistory.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvStockInHistory.ThemeStyle.ReadOnly = true;
            this.dgvStockInHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvStockInHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStockInHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStockInHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvStockInHistory.ThemeStyle.RowsStyle.Height = 22;
            this.dgvStockInHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvStockInHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // tcTabTransactions
            // 
            this.tcTabTransactions.Controls.Add(this.groupBox1);
            this.tcTabTransactions.Controls.Add(this.lblTotalSales);
            this.tcTabTransactions.Controls.Add(this.lblTotalTransactions);
            this.tcTabTransactions.Controls.Add(this.dgvTransactions);
            this.tcTabTransactions.Location = new System.Drawing.Point(4, 24);
            this.tcTabTransactions.Name = "tcTabTransactions";
            this.tcTabTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tcTabTransactions.Size = new System.Drawing.Size(968, 492);
            this.tcTabTransactions.TabIndex = 0;
            this.tcTabTransactions.Text = "Transactions";
            this.tcTabTransactions.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSearchTransByCustomer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSearchTransByCashier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSearchTransByNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(49, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 66);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADVANCE SEARCH";
            // 
            // tbSearchTransByCustomer
            // 
            this.tbSearchTransByCustomer.Animated = true;
            this.tbSearchTransByCustomer.BorderRadius = 5;
            this.tbSearchTransByCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchTransByCustomer.DefaultText = "";
            this.tbSearchTransByCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchTransByCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchTransByCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchTransByCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchTransByCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbSearchTransByCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchTransByCustomer.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbSearchTransByCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbSearchTransByCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchTransByCustomer.IconLeft = global::Dollars.ImageRes.search;
            this.tbSearchTransByCustomer.IconLeftSize = new System.Drawing.Size(15, 15);
            this.tbSearchTransByCustomer.Location = new System.Drawing.Point(666, 25);
            this.tbSearchTransByCustomer.Name = "tbSearchTransByCustomer";
            this.tbSearchTransByCustomer.PasswordChar = '\0';
            this.tbSearchTransByCustomer.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchTransByCustomer.PlaceholderText = "Type here...";
            this.tbSearchTransByCustomer.SelectedText = "";
            this.tbSearchTransByCustomer.Size = new System.Drawing.Size(154, 24);
            this.tbSearchTransByCustomer.TabIndex = 13;
            this.tbSearchTransByCustomer.TextChanged += new System.EventHandler(this.OnSearchBarChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(588, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSearchTransByCashier
            // 
            this.tbSearchTransByCashier.Animated = true;
            this.tbSearchTransByCashier.BorderRadius = 5;
            this.tbSearchTransByCashier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchTransByCashier.DefaultText = "";
            this.tbSearchTransByCashier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchTransByCashier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchTransByCashier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchTransByCashier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchTransByCashier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbSearchTransByCashier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchTransByCashier.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbSearchTransByCashier.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbSearchTransByCashier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchTransByCashier.IconLeft = global::Dollars.ImageRes.search;
            this.tbSearchTransByCashier.IconLeftSize = new System.Drawing.Size(15, 15);
            this.tbSearchTransByCashier.Location = new System.Drawing.Point(396, 25);
            this.tbSearchTransByCashier.Name = "tbSearchTransByCashier";
            this.tbSearchTransByCashier.PasswordChar = '\0';
            this.tbSearchTransByCashier.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchTransByCashier.PlaceholderText = "Type here...";
            this.tbSearchTransByCashier.SelectedText = "";
            this.tbSearchTransByCashier.Size = new System.Drawing.Size(154, 24);
            this.tbSearchTransByCashier.TabIndex = 11;
            this.tbSearchTransByCashier.TextChanged += new System.EventHandler(this.OnSearchBarChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(326, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cashier:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSearchTransByNo
            // 
            this.tbSearchTransByNo.Animated = true;
            this.tbSearchTransByNo.BorderRadius = 5;
            this.tbSearchTransByNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchTransByNo.DefaultText = "";
            this.tbSearchTransByNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchTransByNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchTransByNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchTransByNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchTransByNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbSearchTransByNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchTransByNo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbSearchTransByNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbSearchTransByNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchTransByNo.IconLeft = global::Dollars.ImageRes.search;
            this.tbSearchTransByNo.IconLeftSize = new System.Drawing.Size(15, 15);
            this.tbSearchTransByNo.Location = new System.Drawing.Point(141, 25);
            this.tbSearchTransByNo.Name = "tbSearchTransByNo";
            this.tbSearchTransByNo.PasswordChar = '\0';
            this.tbSearchTransByNo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchTransByNo.PlaceholderText = "Type here...";
            this.tbSearchTransByNo.SelectedText = "";
            this.tbSearchTransByNo.Size = new System.Drawing.Size(154, 24);
            this.tbSearchTransByNo.TabIndex = 9;
            this.tbSearchTransByNo.TextChanged += new System.EventHandler(this.OnSearchBarChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Transaction No:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lblTotalSales.Location = new System.Drawing.Point(568, 443);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(351, 24);
            this.lblTotalSales.TabIndex = 73;
            this.lblTotalSales.Text = "Total Sales: 0";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalTransactions
            // 
            this.lblTotalTransactions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.lblTotalTransactions.Location = new System.Drawing.Point(46, 443);
            this.lblTotalTransactions.Name = "lblTotalTransactions";
            this.lblTotalTransactions.Size = new System.Drawing.Size(351, 24);
            this.lblTotalTransactions.TabIndex = 72;
            this.lblTotalTransactions.Text = "Total Transactions: 0";
            this.lblTotalTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvTransactions.Location = new System.Drawing.Point(49, 78);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.Size = new System.Drawing.Size(870, 362);
            this.dgvTransactions.TabIndex = 19;
            this.dgvTransactions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvTransactions.ThemeStyle.ReadOnly = true;
            this.dgvTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvTransactions.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // tcReports
            // 
            this.tcReports.Controls.Add(this.tcTabTransactions);
            this.tcReports.Controls.Add(this.tcTabStockIn);
            this.tcReports.Controls.Add(this.tcTabCriticalStocks);
            this.tcReports.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcReports.Location = new System.Drawing.Point(12, 44);
            this.tcReports.Name = "tcReports";
            this.tcReports.SelectedIndex = 0;
            this.tcReports.Size = new System.Drawing.Size(976, 520);
            this.tcReports.TabIndex = 18;
            this.tcReports.SelectedIndexChanged += new System.EventHandler(this.tcReports_SelectedIndexChanged);
            // 
            // ReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 588);
            this.Controls.Add(this.tcReports);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tcTabCriticalStocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticalStocks)).EndInit();
            this.tcTabStockIn.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockInHistory)).EndInit();
            this.tcTabTransactions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.tcReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.TabPage tcTabCriticalStocks;
        private System.Windows.Forms.Label lblCriticalStocks;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCriticalStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCriticalStocksCPrdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCriticalStocksCPrdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCriticalStocksCPrdCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCriticalStocksCUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCriticalStocksCStock;
        private System.Windows.Forms.TabPage tcTabStockIn;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStockInHistory;
        private System.Windows.Forms.TabPage tcTabTransactions;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalTransactions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactions;
        private System.Windows.Forms.TabControl tcReports;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchTransByNo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchTransByCustomer;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchTransByCashier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchPrd;
        private System.Windows.Forms.Label label7;
    }
}