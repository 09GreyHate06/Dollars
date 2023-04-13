namespace Dollars
{
    partial class ProductBtnUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPrdName = new System.Windows.Forms.Label();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(170)))));
            this.lblPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(130, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 15);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrdName
            // 
            this.lblPrdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblPrdName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPrdName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrdName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPrdName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrdName.Location = new System.Drawing.Point(0, 110);
            this.lblPrdName.Name = "lblPrdName";
            this.lblPrdName.Size = new System.Drawing.Size(130, 20);
            this.lblPrdName.TabIndex = 2;
            this.lblPrdName.Text = "Product Name";
            this.lblPrdName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInfo
            // 
            this.btnInfo.Animated = true;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(125)))), ((int)(((byte)(170)))));
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI Black", 5F, System.Drawing.FontStyle.Bold);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::Dollars.ImageRes.info;
            this.btnInfo.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnInfo.ImageSize = new System.Drawing.Size(16, 16);
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(20, 20);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.TabStop = false;
            this.btnInfo.Text = "i";
            this.btnInfo.UseTransparentBackground = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Animated = true;
            this.btnProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.FillColor = System.Drawing.Color.White;
            this.btnProduct.FocusedColor = System.Drawing.Color.Black;
            this.btnProduct.Font = new System.Drawing.Font("Arial", 9F);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::Dollars.ImageRes.default_image;
            this.btnProduct.ImageSize = new System.Drawing.Size(131, 131);
            this.btnProduct.IndicateFocus = true;
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(7);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(130, 130);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.UseTransparentBackground = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            this.btnProduct.Enter += new System.EventHandler(this.btnProduct_Enter);
            this.btnProduct.Leave += new System.EventHandler(this.btnProduct_Leave);
            // 
            // ProductBtnUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblPrdName);
            this.Controls.Add(this.btnProduct);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "ProductBtnUC";
            this.Size = new System.Drawing.Size(130, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPrdName;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
    }
}
