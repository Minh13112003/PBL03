namespace PBL03
{
    partial class UserControl_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Order));
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.lbFood = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbNameTable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numericquantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.Transparent;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRemove.Location = new System.Drawing.Point(3, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 60);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbFood
            // 
            this.lbFood.AutoSize = false;
            this.lbFood.BackColor = System.Drawing.Color.Transparent;
            this.lbFood.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFood.ForeColor = System.Drawing.Color.Turquoise;
            this.lbFood.Location = new System.Drawing.Point(69, 3);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(117, 33);
            this.lbFood.TabIndex = 1;
            this.lbFood.Text = "Food";
            this.lbFood.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNameTable
            // 
            this.lbNameTable.AutoSize = false;
            this.lbNameTable.BackColor = System.Drawing.Color.Transparent;
            this.lbNameTable.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTable.ForeColor = System.Drawing.Color.Turquoise;
            this.lbNameTable.Location = new System.Drawing.Point(69, 33);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(158, 33);
            this.lbNameTable.TabIndex = 2;
            this.lbNameTable.Text = "Name Table";
            this.lbNameTable.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericquantity
            // 
            this.numericquantity.BackColor = System.Drawing.Color.Transparent;
            this.numericquantity.BorderRadius = 10;
            this.numericquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericquantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericquantity.Location = new System.Drawing.Point(328, 13);
            this.numericquantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericquantity.Name = "numericquantity";
            this.numericquantity.Size = new System.Drawing.Size(85, 42);
            this.numericquantity.TabIndex = 3;
            this.numericquantity.UpDownButtonFillColor = System.Drawing.Color.HotPink;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = false;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Turquoise;
            this.lbPrice.Location = new System.Drawing.Point(419, 22);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(102, 33);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price $";
            this.lbPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = false;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Turquoise;
            this.lbTime.Location = new System.Drawing.Point(220, 22);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(102, 33);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Time";
            this.lbTime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.numericquantity);
            this.Controls.Add(this.lbNameTable);
            this.Controls.Add(this.lbFood);
            this.Controls.Add(this.btnRemove);
            this.Name = "UserControl_Order";
            this.Size = new System.Drawing.Size(547, 69);
            ((System.ComponentModel.ISupportInitialize)(this.numericquantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2NumericUpDown numericquantity;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbPrice;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbTime;
        public Guna.UI2.WinForms.Guna2Button btnRemove;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbFood;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbNameTable;
    }
}
