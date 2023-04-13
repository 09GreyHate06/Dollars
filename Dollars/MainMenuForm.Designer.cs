namespace Dollars
{
    partial class MainMenuForm
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnPOS = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCriticalStocks = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPrd = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalTransactions = new System.Windows.Forms.Label();
            this.pnlChildMenu = new System.Windows.Forms.Panel();
            this.manageStaffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMaintenance = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.manageStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStripMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnPOS);
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Controls.Add(this.btnMaintenance);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1000, 56);
            this.pnlMenu.TabIndex = 10;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
            this.pnlMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseMove);
            this.pnlMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseUp);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FillColor = System.Drawing.Color.Black;
            this.btnLogout.FocusedColor = System.Drawing.Color.DimGray;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = global::Dollars.ImageRes.logout;
            this.btnLogout.Location = new System.Drawing.Point(910, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 56);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Animated = true;
            this.btnPOS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPOS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPOS.FillColor = System.Drawing.Color.Black;
            this.btnPOS.FocusedColor = System.Drawing.Color.DimGray;
            this.btnPOS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPOS.Image = global::Dollars.ImageRes.transaction;
            this.btnPOS.Location = new System.Drawing.Point(838, 0);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(0);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(72, 56);
            this.btnPOS.TabIndex = 14;
            this.btnPOS.Text = "POS";
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnReports
            // 
            this.btnReports.Animated = true;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.Black;
            this.btnReports.FocusedColor = System.Drawing.Color.DimGray;
            this.btnReports.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReports.Image = global::Dollars.ImageRes.report;
            this.btnReports.Location = new System.Drawing.Point(742, 0);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(96, 56);
            this.btnReports.TabIndex = 13;
            this.btnReports.Text = "REPORTS";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Animated = true;
            this.btnMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaintenance.FillColor = System.Drawing.Color.Black;
            this.btnMaintenance.FocusedColor = System.Drawing.Color.DimGray;
            this.btnMaintenance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaintenance.Image = global::Dollars.ImageRes.tools;
            this.btnMaintenance.Location = new System.Drawing.Point(611, 0);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(131, 56);
            this.btnMaintenance.TabIndex = 12;
            this.btnMaintenance.Text = "MAINTENANCE";
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lblTodayDate);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 25);
            this.panel1.TabIndex = 11;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTodayDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTodayDate.Location = new System.Drawing.Point(754, 0);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(246, 25);
            this.lblTodayDate.TabIndex = 32;
            this.lblTodayDate.Text = "Sunday, 2 April 2023";
            this.lblTodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCurrentUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentUser.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(549, 25);
            this.lblCurrentUser.TabIndex = 31;
            this.lblCurrentUser.Text = "Wesley Karl Andres | Administrator";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 44);
            this.panel2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "DASHBOARD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblTotalSales);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 110);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dollars.ImageRes.total_sales;
            this.pictureBox2.Location = new System.Drawing.Point(10, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(79, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Sales";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalSales.Location = new System.Drawing.Point(78, 32);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(47, 25);
            this.lblTotalSales.TabIndex = 15;
            this.lblTotalSales.Text = "0.00";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Location = new System.Drawing.Point(12, 178);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(976, 110);
            this.panel7.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lblCriticalStocks);
            this.panel5.Location = new System.Drawing.Point(747, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 110);
            this.panel5.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Dollars.ImageRes.decrease;
            this.pictureBox4.Location = new System.Drawing.Point(10, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(79, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Critical Stocks";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCriticalStocks
            // 
            this.lblCriticalStocks.AutoSize = true;
            this.lblCriticalStocks.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticalStocks.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCriticalStocks.Location = new System.Drawing.Point(78, 32);
            this.lblCriticalStocks.Name = "lblCriticalStocks";
            this.lblCriticalStocks.Size = new System.Drawing.Size(22, 25);
            this.lblCriticalStocks.TabIndex = 17;
            this.lblCriticalStocks.Text = "0";
            this.lblCriticalStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblTotalPrd);
            this.panel4.Location = new System.Drawing.Point(498, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 110);
            this.panel4.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dollars.ImageRes.boxes;
            this.pictureBox3.Location = new System.Drawing.Point(10, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(79, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Products";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrd
            // 
            this.lblTotalPrd.AutoSize = true;
            this.lblTotalPrd.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalPrd.Location = new System.Drawing.Point(78, 32);
            this.lblTotalPrd.Name = "lblTotalPrd";
            this.lblTotalPrd.Size = new System.Drawing.Size(22, 25);
            this.lblTotalPrd.TabIndex = 17;
            this.lblTotalPrd.Text = "0";
            this.lblTotalPrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LimeGreen;
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.lblTotalTransactions);
            this.panel6.Location = new System.Drawing.Point(249, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 110);
            this.panel6.TabIndex = 18;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Dollars.ImageRes.transaction;
            this.pictureBox5.Location = new System.Drawing.Point(10, 30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(79, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total Transactions";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalTransactions
            // 
            this.lblTotalTransactions.AutoSize = true;
            this.lblTotalTransactions.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransactions.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalTransactions.Location = new System.Drawing.Point(78, 32);
            this.lblTotalTransactions.Name = "lblTotalTransactions";
            this.lblTotalTransactions.Size = new System.Drawing.Size(22, 25);
            this.lblTotalTransactions.TabIndex = 17;
            this.lblTotalTransactions.Text = "0";
            this.lblTotalTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlChildMenu
            // 
            this.pnlChildMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlChildMenu.Location = new System.Drawing.Point(0, 56);
            this.pnlChildMenu.Name = "pnlChildMenu";
            this.pnlChildMenu.Size = new System.Drawing.Size(1000, 588);
            this.pnlChildMenu.TabIndex = 18;
            this.pnlChildMenu.Visible = false;
            // 
            // manageStaffsToolStripMenuItem
            // 
            this.manageStaffsToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageStaffsToolStripMenuItem.Name = "manageStaffsToolStripMenuItem";
            this.manageStaffsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageStaffsToolStripMenuItem.Text = "Manage Staffs";
            // 
            // manageCustomersToolStripMenuItem
            // 
            this.manageCustomersToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
            this.manageCustomersToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageCustomersToolStripMenuItem.Text = "Manage Customers";
            // 
            // manageCategoriesToolStripMenuItem
            // 
            this.manageCategoriesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageCategoriesToolStripMenuItem.Name = "manageCategoriesToolStripMenuItem";
            this.manageCategoriesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageCategoriesToolStripMenuItem.Text = "Manage Categories";
            // 
            // manageProductsToolStripMenuItem
            // 
            this.manageProductsToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
            this.manageProductsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageProductsToolStripMenuItem.Text = "Manage Products";
            // 
            // manageStocksToolStripMenuItem
            // 
            this.manageStocksToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageStocksToolStripMenuItem.Name = "manageStocksToolStripMenuItem";
            this.manageStocksToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageStocksToolStripMenuItem.Text = "Manage Stocks";
            // 
            // manageDiscountToolStripMenuItem
            // 
            this.manageDiscountToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageDiscountToolStripMenuItem.Name = "manageDiscountToolStripMenuItem";
            this.manageDiscountToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageDiscountToolStripMenuItem.Text = "Manage Discounts";
            // 
            // menuStripMaintenance
            // 
            this.menuStripMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.menuStripMaintenance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMaintenance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStaffsToolStripMenuItem,
            this.manageCustomersToolStripMenuItem,
            this.manageCategoriesToolStripMenuItem,
            this.manageProductsToolStripMenuItem,
            this.manageStocksToolStripMenuItem,
            this.manageDiscountToolStripMenuItem,
            this.manageStoreToolStripMenuItem});
            this.menuStripMaintenance.Name = "guna2ContextMenuStrip1";
            this.menuStripMaintenance.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menuStripMaintenance.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.menuStripMaintenance.RenderStyle.ColorTable = null;
            this.menuStripMaintenance.RenderStyle.RoundedEdges = true;
            this.menuStripMaintenance.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.menuStripMaintenance.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.menuStripMaintenance.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menuStripMaintenance.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.menuStripMaintenance.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.menuStripMaintenance.Size = new System.Drawing.Size(184, 158);
            this.menuStripMaintenance.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripMaintenance_ItemClicked);
            // 
            // manageStoreToolStripMenuItem
            // 
            this.manageStoreToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageStoreToolStripMenuItem.Name = "manageStoreToolStripMenuItem";
            this.manageStoreToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageStoreToolStripMenuItem.Text = "Manage Store Info";
            // 
            // MainMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 644);
            this.Controls.Add(this.pnlChildMenu);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainMenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStripMaintenance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnMaintenance;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnPOS;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCriticalStocks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalTransactions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPrd;
        private System.Windows.Forms.Panel pnlChildMenu;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menuStripMaintenance;
        private System.Windows.Forms.ToolStripMenuItem manageStaffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDiscountToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem manageStoreToolStripMenuItem;
    }
}