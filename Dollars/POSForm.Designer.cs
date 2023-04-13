namespace Dollars
{
    partial class POSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalVatable = new System.Windows.Forms.Label();
            this.lblTotalVat = new System.Windows.Forms.Label();
            this.lblTotalDiscount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchPrd = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnEndSession = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrdUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPrdSubtotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrdDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrdQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrdID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.lblTotal);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1000, 56);
            this.pnlMenu.TabIndex = 11;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
            this.pnlMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseMove);
            this.pnlMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseUp);
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Location = new System.Drawing.Point(318, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(682, 56);
            this.lblTotal.TabIndex = 90;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
            this.lblTotal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseMove);
            this.lblTotal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dollars.ImageRes.dollars_word_only;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lblTodayDate);
            this.panel1.Controls.Add(this.lblDesignation);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblCashierName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 610);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 34);
            this.panel1.TabIndex = 12;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTodayDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTodayDate.Location = new System.Drawing.Point(741, 0);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(259, 34);
            this.lblTodayDate.TabIndex = 93;
            this.lblTodayDate.Text = "Sunday, 2 April 2023  09:03:14 pm";
            this.lblTodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDesignation
            // 
            this.lblDesignation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDesignation.Location = new System.Drawing.Point(420, 5);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(111, 24);
            this.lblDesignation.TabIndex = 92;
            this.lblDesignation.Text = "Administrator";
            this.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(334, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 91;
            this.label9.Text = "Designation:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCashierName
            // 
            this.lblCashierName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCashierName.Location = new System.Drawing.Point(69, 5);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(242, 24);
            this.lblCashierName.TabIndex = 90;
            this.lblCashierName.Text = "Wesley Karl Andres";
            this.lblCashierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(16, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 89;
            this.label5.Text = "Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.lblTotalVatable);
            this.panel2.Controls.Add(this.lblTotalVat);
            this.panel2.Controls.Add(this.lblTotalDiscount);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(741, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 554);
            this.panel2.TabIndex = 13;
            // 
            // lblTotalVatable
            // 
            this.lblTotalVatable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVatable.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalVatable.Location = new System.Drawing.Point(86, 55);
            this.lblTotalVatable.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalVatable.Name = "lblTotalVatable";
            this.lblTotalVatable.Size = new System.Drawing.Size(163, 18);
            this.lblTotalVatable.TabIndex = 95;
            this.lblTotalVatable.Text = "0.00";
            this.lblTotalVatable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalVat
            // 
            this.lblTotalVat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVat.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalVat.Location = new System.Drawing.Point(86, 31);
            this.lblTotalVat.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalVat.Name = "lblTotalVat";
            this.lblTotalVat.Size = new System.Drawing.Size(163, 18);
            this.lblTotalVat.TabIndex = 94;
            this.lblTotalVat.Text = "0.00";
            this.lblTotalVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDiscount
            // 
            this.lblTotalDiscount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiscount.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalDiscount.Location = new System.Drawing.Point(86, 7);
            this.lblTotalDiscount.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalDiscount.Name = "lblTotalDiscount";
            this.lblTotalDiscount.Size = new System.Drawing.Size(163, 18);
            this.lblTotalDiscount.TabIndex = 93;
            this.lblTotalDiscount.Text = "0.00";
            this.lblTotalDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(10, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 18);
            this.label15.TabIndex = 92;
            this.label15.Text = "VATABLE";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(10, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 91;
            this.label14.Text = "VAT";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(10, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 18);
            this.label13.TabIndex = 90;
            this.label13.Text = "DISCOUNT";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.btnCustomer);
            this.flowLayoutPanel1.Controls.Add(this.btnDiscount);
            this.flowLayoutPanel1.Controls.Add(this.btnSearchPrd);
            this.flowLayoutPanel1.Controls.Add(this.btnPayment);
            this.flowLayoutPanel1.Controls.Add(this.btnClearCart);
            this.flowLayoutPanel1.Controls.Add(this.btnEndSession);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 80);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 471);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.panel4.Controls.Add(this.lblTransactionNo);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 81);
            this.panel4.TabIndex = 0;
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTransactionNo.Location = new System.Drawing.Point(0, 36);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(231, 24);
            this.lblTransactionNo.TabIndex = 93;
            this.lblTransactionNo.Text = "1001001";
            this.lblTransactionNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(10, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 24);
            this.label11.TabIndex = 92;
            this.label11.Text = "TRANSACTION NO:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Animated = true;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.Location = new System.Drawing.Point(3, 95);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(236, 54);
            this.btnCustomer.TabIndex = 38;
            this.btnCustomer.Text = "[F1] CUSTOMER";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.TextOffset = new System.Drawing.Point(10, 0);
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Animated = true;
            this.btnDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnDiscount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDiscount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDiscount.Image = global::Dollars.ImageRes.discount;
            this.btnDiscount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiscount.Location = new System.Drawing.Point(3, 160);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(236, 54);
            this.btnDiscount.TabIndex = 39;
            this.btnDiscount.Text = "[F2] DISCOUNTS";
            this.btnDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiscount.TextOffset = new System.Drawing.Point(10, 0);
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnSearchPrd
            // 
            this.btnSearchPrd.Animated = true;
            this.btnSearchPrd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchPrd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchPrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchPrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchPrd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnSearchPrd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearchPrd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchPrd.Image = global::Dollars.ImageRes.shopping_cart;
            this.btnSearchPrd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearchPrd.Location = new System.Drawing.Point(3, 225);
            this.btnSearchPrd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnSearchPrd.Name = "btnSearchPrd";
            this.btnSearchPrd.Size = new System.Drawing.Size(236, 54);
            this.btnSearchPrd.TabIndex = 40;
            this.btnSearchPrd.Text = "[F3] SEARCH PRODUCT";
            this.btnSearchPrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearchPrd.TextOffset = new System.Drawing.Point(10, 0);
            this.btnSearchPrd.Click += new System.EventHandler(this.btnSearchPrd_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Animated = true;
            this.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnPayment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPayment.Image = global::Dollars.ImageRes.payment;
            this.btnPayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayment.Location = new System.Drawing.Point(3, 290);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(236, 54);
            this.btnPayment.TabIndex = 41;
            this.btnPayment.Text = "[F4] PAYMENT";
            this.btnPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayment.TextOffset = new System.Drawing.Point(10, 0);
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Animated = true;
            this.btnClearCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnClearCart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClearCart.Image = global::Dollars.ImageRes.clear_cart;
            this.btnClearCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClearCart.Location = new System.Drawing.Point(3, 355);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(236, 54);
            this.btnClearCart.TabIndex = 42;
            this.btnClearCart.Text = "[F5] CLEAR CART";
            this.btnClearCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClearCart.TextOffset = new System.Drawing.Point(10, 0);
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnEndSession
            // 
            this.btnEndSession.Animated = true;
            this.btnEndSession.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEndSession.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEndSession.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEndSession.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEndSession.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnEndSession.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEndSession.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEndSession.Image = global::Dollars.ImageRes.flag;
            this.btnEndSession.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEndSession.Location = new System.Drawing.Point(3, 420);
            this.btnEndSession.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(236, 54);
            this.btnEndSession.TabIndex = 43;
            this.btnEndSession.Text = "[F6] END SESSION";
            this.btnEndSession.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEndSession.TextOffset = new System.Drawing.Point(10, 0);
            this.btnEndSession.Click += new System.EventHandler(this.btnEndSession_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbPrdUnitPrice);
            this.panel3.Controls.Add(this.tbPrdSubtotal);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbPrdDiscount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbPrdQty);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbPrdName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbPrdID);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 80);
            this.panel3.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label6.Location = new System.Drawing.Point(275, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 82;
            this.label6.Text = "UNIT PRICE:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPrdUnitPrice
            // 
            this.tbPrdUnitPrice.Animated = true;
            this.tbPrdUnitPrice.BorderRadius = 5;
            this.tbPrdUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrdUnitPrice.DefaultText = "";
            this.tbPrdUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrdUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrdUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbPrdUnitPrice.Enabled = false;
            this.tbPrdUnitPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbPrdUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdUnitPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrdUnitPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPrdUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdUnitPrice.Location = new System.Drawing.Point(367, 12);
            this.tbPrdUnitPrice.Name = "tbPrdUnitPrice";
            this.tbPrdUnitPrice.PasswordChar = '\0';
            this.tbPrdUnitPrice.PlaceholderText = "0.00";
            this.tbPrdUnitPrice.SelectedText = "";
            this.tbPrdUnitPrice.Size = new System.Drawing.Size(118, 24);
            this.tbPrdUnitPrice.TabIndex = 81;
            this.tbPrdUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPrdUnitPrice.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // tbPrdSubtotal
            // 
            this.tbPrdSubtotal.Animated = true;
            this.tbPrdSubtotal.BorderRadius = 5;
            this.tbPrdSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrdSubtotal.DefaultText = "";
            this.tbPrdSubtotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrdSubtotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrdSubtotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdSubtotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbPrdSubtotal.Enabled = false;
            this.tbPrdSubtotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbPrdSubtotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdSubtotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrdSubtotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPrdSubtotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdSubtotal.Location = new System.Drawing.Point(600, 42);
            this.tbPrdSubtotal.Name = "tbPrdSubtotal";
            this.tbPrdSubtotal.PasswordChar = '\0';
            this.tbPrdSubtotal.PlaceholderText = "0.00";
            this.tbPrdSubtotal.ReadOnly = true;
            this.tbPrdSubtotal.SelectedText = "";
            this.tbPrdSubtotal.Size = new System.Drawing.Size(118, 24);
            this.tbPrdSubtotal.TabIndex = 80;
            this.tbPrdSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPrdSubtotal.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(508, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 79;
            this.label4.Text = "SUBTOTAL:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPrdDiscount
            // 
            this.tbPrdDiscount.Animated = true;
            this.tbPrdDiscount.BorderRadius = 5;
            this.tbPrdDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrdDiscount.DefaultText = "";
            this.tbPrdDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrdDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrdDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbPrdDiscount.Enabled = false;
            this.tbPrdDiscount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbPrdDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdDiscount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrdDiscount.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPrdDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdDiscount.Location = new System.Drawing.Point(600, 12);
            this.tbPrdDiscount.Name = "tbPrdDiscount";
            this.tbPrdDiscount.PasswordChar = '\0';
            this.tbPrdDiscount.PlaceholderText = "0.00";
            this.tbPrdDiscount.ReadOnly = true;
            this.tbPrdDiscount.SelectedText = "";
            this.tbPrdDiscount.Size = new System.Drawing.Size(118, 24);
            this.tbPrdDiscount.TabIndex = 78;
            this.tbPrdDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPrdDiscount.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(508, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 77;
            this.label3.Text = "DISCOUNT:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPrdQty
            // 
            this.tbPrdQty.Animated = true;
            this.tbPrdQty.BorderRadius = 5;
            this.tbPrdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrdQty.DefaultText = "";
            this.tbPrdQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrdQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrdQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbPrdQty.Enabled = false;
            this.tbPrdQty.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbPrdQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdQty.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrdQty.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPrdQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdQty.Location = new System.Drawing.Point(367, 42);
            this.tbPrdQty.Name = "tbPrdQty";
            this.tbPrdQty.PasswordChar = '\0';
            this.tbPrdQty.PlaceholderText = "";
            this.tbPrdQty.SelectedText = "";
            this.tbPrdQty.Size = new System.Drawing.Size(118, 24);
            this.tbPrdQty.TabIndex = 76;
            this.tbPrdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPrdQty.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(275, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "QUANTITY:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPrdName
            // 
            this.tbPrdName.Animated = true;
            this.tbPrdName.BorderRadius = 5;
            this.tbPrdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrdName.DefaultText = "";
            this.tbPrdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbPrdName.Enabled = false;
            this.tbPrdName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbPrdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrdName.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPrdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdName.Location = new System.Drawing.Point(144, 42);
            this.tbPrdName.Name = "tbPrdName";
            this.tbPrdName.PasswordChar = '\0';
            this.tbPrdName.PlaceholderText = "";
            this.tbPrdName.ReadOnly = true;
            this.tbPrdName.SelectedText = "";
            this.tbPrdName.Size = new System.Drawing.Size(118, 24);
            this.tbPrdName.TabIndex = 74;
            this.tbPrdName.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 73;
            this.label1.Text = "PRODUCT NAME:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPrdID
            // 
            this.tbPrdID.Animated = true;
            this.tbPrdID.BorderRadius = 5;
            this.tbPrdID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrdID.DefaultText = "";
            this.tbPrdID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrdID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrdID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdID.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbPrdID.Enabled = false;
            this.tbPrdID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.tbPrdID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrdID.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbPrdID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.tbPrdID.Location = new System.Drawing.Point(144, 12);
            this.tbPrdID.Name = "tbPrdID";
            this.tbPrdID.PasswordChar = '\0';
            this.tbPrdID.PlaceholderText = "";
            this.tbPrdID.ReadOnly = true;
            this.tbPrdID.SelectedText = "";
            this.tbPrdID.Size = new System.Drawing.Size(118, 24);
            this.tbPrdID.TabIndex = 72;
            this.tbPrdID.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label7.Location = new System.Drawing.Point(16, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 71;
            this.label7.Text = "PRODUCT ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnID,
            this.dgvColumnName,
            this.dgvColumnUnitPrice,
            this.dgvColumnQuantity,
            this.dgvColumnDiscount,
            this.dgvColumnSubtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCart.Location = new System.Drawing.Point(0, 136);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.Size = new System.Drawing.Size(741, 474);
            this.dgvCart.TabIndex = 23;
            this.dgvCart.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCart.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvCart.ThemeStyle.ReadOnly = true;
            this.dgvCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvCart.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // dgvColumnID
            // 
            this.dgvColumnID.FillWeight = 15F;
            this.dgvColumnID.HeaderText = "ID";
            this.dgvColumnID.Name = "dgvColumnID";
            this.dgvColumnID.ReadOnly = true;
            // 
            // dgvColumnName
            // 
            this.dgvColumnName.HeaderText = "Name";
            this.dgvColumnName.Name = "dgvColumnName";
            this.dgvColumnName.ReadOnly = true;
            // 
            // dgvColumnUnitPrice
            // 
            this.dgvColumnUnitPrice.FillWeight = 30F;
            this.dgvColumnUnitPrice.HeaderText = "Unit Price";
            this.dgvColumnUnitPrice.Name = "dgvColumnUnitPrice";
            this.dgvColumnUnitPrice.ReadOnly = true;
            // 
            // dgvColumnQuantity
            // 
            this.dgvColumnQuantity.FillWeight = 30F;
            this.dgvColumnQuantity.HeaderText = "Quantity";
            this.dgvColumnQuantity.Name = "dgvColumnQuantity";
            this.dgvColumnQuantity.ReadOnly = true;
            // 
            // dgvColumnDiscount
            // 
            this.dgvColumnDiscount.FillWeight = 30F;
            this.dgvColumnDiscount.HeaderText = "Discount";
            this.dgvColumnDiscount.Name = "dgvColumnDiscount";
            this.dgvColumnDiscount.ReadOnly = true;
            // 
            // dgvColumnSubtotal
            // 
            this.dgvColumnSubtotal.FillWeight = 30F;
            this.dgvColumnSubtotal.HeaderText = "Subtotal";
            this.dgvColumnSubtotal.Name = "dgvColumnSubtotal";
            this.dgvColumnSubtotal.ReadOnly = true;
            // 
            // POSForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 644);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "POSForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.POSForm_FormClosing);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox tbPrdID;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbPrdName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbPrdQty;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbPrdSubtotal;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbPrdDiscount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCashierName;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTransactionNo;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnDiscount;
        private Guna.UI2.WinForms.Guna2Button btnSearchPrd;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private Guna.UI2.WinForms.Guna2Button btnClearCart;
        private Guna.UI2.WinForms.Guna2Button btnEndSession;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalDiscount;
        private System.Windows.Forms.Label lblTotalVatable;
        private System.Windows.Forms.Label lblTotalVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSubtotal;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbPrdUnitPrice;
    }
}