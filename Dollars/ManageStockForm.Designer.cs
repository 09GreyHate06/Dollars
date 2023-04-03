namespace Dollars
{
    partial class ManageStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStockForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearchPrd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrdID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dpStockInDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvPrd = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvProductCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddStock = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveStockIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteSelectedAddStock = new Guna.UI2.WinForms.Guna2Button();
            this.dgvStockInHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvStockInID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStockInPrdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStockInPrdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStockInQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStockInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrd)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockInHistory)).BeginInit();
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
            this.panel1.TabIndex = 20;
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
            this.label1.Text = "STOCK";
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
            // tbSearchPrd
            // 
            this.tbSearchPrd.Animated = true;
            this.tbSearchPrd.AutoRoundedCorners = true;
            this.tbSearchPrd.BorderRadius = 11;
            this.tbSearchPrd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchPrd.DefaultText = "";
            this.tbSearchPrd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchPrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchPrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchPrd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchPrd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbSearchPrd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchPrd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchPrd.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbSearchPrd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbSearchPrd.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbSearchPrd.IconLeft")));
            this.tbSearchPrd.IconLeftSize = new System.Drawing.Size(15, 15);
            this.tbSearchPrd.Location = new System.Drawing.Point(113, 25);
            this.tbSearchPrd.Name = "tbSearchPrd";
            this.tbSearchPrd.PasswordChar = '\0';
            this.tbSearchPrd.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchPrd.PlaceholderText = "Type here...";
            this.tbSearchPrd.SelectedText = "";
            this.tbSearchPrd.Size = new System.Drawing.Size(299, 24);
            this.tbSearchPrd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpStockInDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbPrdName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPrdID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbQuantity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSearchPrd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 101);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STOCK INFORMATION";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Animated = true;
            this.tbQuantity.AutoRoundedCorners = true;
            this.tbQuantity.BorderRadius = 11;
            this.tbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuantity.DefaultText = "";
            this.tbQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbQuantity.Location = new System.Drawing.Point(113, 55);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.PasswordChar = '\0';
            this.tbQuantity.PlaceholderText = "";
            this.tbQuantity.SelectedText = "";
            this.tbQuantity.Size = new System.Drawing.Size(299, 24);
            this.tbQuantity.TabIndex = 40;
            this.tbQuantity.TextOffset = new System.Drawing.Point(5, 0);
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Quantity:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPrdID
            // 
            this.tbPrdID.Animated = true;
            this.tbPrdID.AutoRoundedCorners = true;
            this.tbPrdID.BorderRadius = 11;
            this.tbPrdID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrdID.DefaultText = "";
            this.tbPrdID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrdID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrdID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrdID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrdID.Enabled = false;
            this.tbPrdID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbPrdID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrdID.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPrdID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdID.Location = new System.Drawing.Point(518, 25);
            this.tbPrdID.Name = "tbPrdID";
            this.tbPrdID.PasswordChar = '\0';
            this.tbPrdID.PlaceholderText = "";
            this.tbPrdID.ReadOnly = true;
            this.tbPrdID.SelectedText = "";
            this.tbPrdID.Size = new System.Drawing.Size(110, 24);
            this.tbPrdID.TabIndex = 42;
            this.tbPrdID.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(437, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Product ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPrdName
            // 
            this.tbPrdName.Animated = true;
            this.tbPrdName.AutoRoundedCorners = true;
            this.tbPrdName.BorderRadius = 11;
            this.tbPrdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrdName.DefaultText = "";
            this.tbPrdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrdName.Enabled = false;
            this.tbPrdName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbPrdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrdName.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPrdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdName.Location = new System.Drawing.Point(518, 55);
            this.tbPrdName.Name = "tbPrdName";
            this.tbPrdName.PasswordChar = '\0';
            this.tbPrdName.PlaceholderText = "";
            this.tbPrdName.ReadOnly = true;
            this.tbPrdName.SelectedText = "";
            this.tbPrdName.Size = new System.Drawing.Size(414, 24);
            this.tbPrdName.TabIndex = 44;
            this.tbPrdName.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(437, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(642, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "Stock in Date:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpStockInDate
            // 
            this.dpStockInDate.Animated = true;
            this.dpStockInDate.AutoRoundedCorners = true;
            this.dpStockInDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpStockInDate.BorderRadius = 11;
            this.dpStockInDate.BorderThickness = 1;
            this.dpStockInDate.Checked = true;
            this.dpStockInDate.CustomFormat = "";
            this.dpStockInDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpStockInDate.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dpStockInDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.dpStockInDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpStockInDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.dpStockInDate.Location = new System.Drawing.Point(739, 25);
            this.dpStockInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpStockInDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpStockInDate.Name = "dpStockInDate";
            this.dpStockInDate.Size = new System.Drawing.Size(193, 24);
            this.dpStockInDate.TabIndex = 84;
            this.dpStockInDate.Value = new System.DateTime(2023, 4, 3, 0, 0, 0, 0);
            // 
            // dgvPrd
            // 
            this.dgvPrd.AllowUserToAddRows = false;
            this.dgvPrd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvPrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPrd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductCoID,
            this.dgvProductColName,
            this.dgvProductColQuantity});
            this.dgvPrd.DataMember = " ";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrd.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPrd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvPrd.Location = new System.Drawing.Point(12, 149);
            this.dgvPrd.Name = "dgvPrd";
            this.dgvPrd.ReadOnly = true;
            this.dgvPrd.RowHeadersVisible = false;
            this.dgvPrd.Size = new System.Drawing.Size(412, 377);
            this.dgvPrd.TabIndex = 72;
            this.dgvPrd.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvPrd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvPrd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPrd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPrd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPrd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPrd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvPrd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvPrd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPrd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPrd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrd.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvPrd.ThemeStyle.ReadOnly = true;
            this.dgvPrd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvPrd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrd.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPrd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvPrd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dgvProductCoID
            // 
            this.dgvProductCoID.FillWeight = 15F;
            this.dgvProductCoID.HeaderText = "ID";
            this.dgvProductCoID.Name = "dgvProductCoID";
            this.dgvProductCoID.ReadOnly = true;
            // 
            // dgvProductColName
            // 
            this.dgvProductColName.HeaderText = "Name";
            this.dgvProductColName.Name = "dgvProductColName";
            this.dgvProductColName.ReadOnly = true;
            // 
            // dgvProductColQuantity
            // 
            this.dgvProductColQuantity.FillWeight = 25F;
            this.dgvProductColQuantity.HeaderText = "Quantity";
            this.dgvProductColQuantity.Name = "dgvProductColQuantity";
            this.dgvProductColQuantity.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddStock);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(12, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 35);
            this.panel2.TabIndex = 73;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Animated = true;
            this.btnAddStock.AutoRoundedCorners = true;
            this.btnAddStock.BorderRadius = 16;
            this.btnAddStock.BorderThickness = 1;
            this.btnAddStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStock.FillColor = System.Drawing.Color.White;
            this.btnAddStock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.Color.Black;
            this.btnAddStock.Location = new System.Drawing.Point(0, 0);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(140, 35);
            this.btnAddStock.TabIndex = 69;
            this.btnAddStock.Text = "Add Stock";
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 16;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnCancel.Location = new System.Drawing.Point(152, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancel";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveStockIn);
            this.panel3.Controls.Add(this.btnDeleteSelectedAddStock);
            this.panel3.Location = new System.Drawing.Point(696, 532);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 35);
            this.panel3.TabIndex = 75;
            // 
            // btnSaveStockIn
            // 
            this.btnSaveStockIn.Animated = true;
            this.btnSaveStockIn.AutoRoundedCorners = true;
            this.btnSaveStockIn.BorderRadius = 16;
            this.btnSaveStockIn.BorderThickness = 1;
            this.btnSaveStockIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveStockIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveStockIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveStockIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveStockIn.FillColor = System.Drawing.Color.White;
            this.btnSaveStockIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStockIn.ForeColor = System.Drawing.Color.Black;
            this.btnSaveStockIn.Location = new System.Drawing.Point(0, 0);
            this.btnSaveStockIn.Name = "btnSaveStockIn";
            this.btnSaveStockIn.Size = new System.Drawing.Size(140, 35);
            this.btnSaveStockIn.TabIndex = 69;
            this.btnSaveStockIn.Text = "Save";
            // 
            // btnDeleteSelectedAddStock
            // 
            this.btnDeleteSelectedAddStock.Animated = true;
            this.btnDeleteSelectedAddStock.AutoRoundedCorners = true;
            this.btnDeleteSelectedAddStock.BorderRadius = 16;
            this.btnDeleteSelectedAddStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSelectedAddStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSelectedAddStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteSelectedAddStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteSelectedAddStock.FillColor = System.Drawing.Color.White;
            this.btnDeleteSelectedAddStock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedAddStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnDeleteSelectedAddStock.Location = new System.Drawing.Point(152, 0);
            this.btnDeleteSelectedAddStock.Name = "btnDeleteSelectedAddStock";
            this.btnDeleteSelectedAddStock.Size = new System.Drawing.Size(140, 35);
            this.btnDeleteSelectedAddStock.TabIndex = 70;
            this.btnDeleteSelectedAddStock.Text = "Delete";
            // 
            // dgvStockInHistory
            // 
            this.dgvStockInHistory.AllowUserToAddRows = false;
            this.dgvStockInHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvStockInHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvStockInHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvStockInHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockInHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvStockInHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvStockInID,
            this.dgvStockInPrdID,
            this.dgvStockInPrdName,
            this.dgvStockInQuantity,
            this.dgvStockInDate});
            this.dgvStockInHistory.DataMember = " ";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockInHistory.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvStockInHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvStockInHistory.Location = new System.Drawing.Point(452, 149);
            this.dgvStockInHistory.Name = "dgvStockInHistory";
            this.dgvStockInHistory.ReadOnly = true;
            this.dgvStockInHistory.RowHeadersVisible = false;
            this.dgvStockInHistory.Size = new System.Drawing.Size(536, 377);
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
            this.dgvStockInHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStockInHistory.ThemeStyle.RowsStyle.Height = 22;
            this.dgvStockInHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvStockInHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // dgvStockInID
            // 
            this.dgvStockInID.FillWeight = 20F;
            this.dgvStockInID.HeaderText = "ID";
            this.dgvStockInID.Name = "dgvStockInID";
            this.dgvStockInID.ReadOnly = true;
            // 
            // dgvStockInPrdID
            // 
            this.dgvStockInPrdID.FillWeight = 50F;
            this.dgvStockInPrdID.HeaderText = "Product ID";
            this.dgvStockInPrdID.Name = "dgvStockInPrdID";
            this.dgvStockInPrdID.ReadOnly = true;
            // 
            // dgvStockInPrdName
            // 
            this.dgvStockInPrdName.HeaderText = "Product Name";
            this.dgvStockInPrdName.Name = "dgvStockInPrdName";
            this.dgvStockInPrdName.ReadOnly = true;
            // 
            // dgvStockInQuantity
            // 
            this.dgvStockInQuantity.FillWeight = 50F;
            this.dgvStockInQuantity.HeaderText = "Quantity";
            this.dgvStockInQuantity.Name = "dgvStockInQuantity";
            this.dgvStockInQuantity.ReadOnly = true;
            // 
            // dgvStockInDate
            // 
            this.dgvStockInDate.HeaderText = "Stock in Date";
            this.dgvStockInDate.Name = "dgvStockInDate";
            this.dgvStockInDate.ReadOnly = true;
            // 
            // ManageStockForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvStockInHistory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPrd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageStockForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockInHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchPrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbQuantity;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tbPrdName;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbPrdID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpStockInDate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductColQuantity;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAddStock;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnSaveStockIn;
        private Guna.UI2.WinForms.Guna2Button btnDeleteSelectedAddStock;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStockInHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStockInID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStockInPrdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStockInPrdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStockInQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStockInDate;
    }
}