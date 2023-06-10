namespace PBL03
{
    partial class UserControl_Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Food));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new Guna.UI2.WinForms.Guna2TileButton();
            this.lbFood = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.picSoldOut = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnSoldOut = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoldOut)).BeginInit();
            this.pnSoldOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.lbFood);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 52);
            this.panel1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSelect.Location = new System.Drawing.Point(149, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(55, 52);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbFood
            // 
            this.lbFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFood.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFood.ForeColor = System.Drawing.Color.SeaShell;
            this.lbFood.Location = new System.Drawing.Point(0, 0);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(153, 52);
            this.lbFood.TabIndex = 0;
            this.lbFood.Text = "Bánh mì";
            this.lbFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 46);
            this.panel2.TabIndex = 1;
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPrice.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.SeaShell;
            this.lbPrice.Location = new System.Drawing.Point(0, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(146, 46);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "15.000 đ";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSoldOut
            // 
            this.picSoldOut.BackColor = System.Drawing.Color.Transparent;
            this.picSoldOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSoldOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picSoldOut.ImageRotate = 0F;
            this.picSoldOut.Location = new System.Drawing.Point(0, 0);
            this.picSoldOut.Name = "picSoldOut";
            this.picSoldOut.Size = new System.Drawing.Size(204, 177);
            this.picSoldOut.TabIndex = 0;
            this.picSoldOut.TabStop = false;
            // 
            // pnSoldOut
            // 
            this.pnSoldOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnSoldOut.Controls.Add(this.pictureBox1);
            this.pnSoldOut.Controls.Add(this.picSoldOut);
            this.pnSoldOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSoldOut.Location = new System.Drawing.Point(0, 0);
            this.pnSoldOut.Name = "pnSoldOut";
            this.pnSoldOut.Size = new System.Drawing.Size(204, 177);
            this.pnSoldOut.TabIndex = 2;
            this.pnSoldOut.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 112);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnSoldOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "UserControl_Food";
            this.Size = new System.Drawing.Size(204, 232);
            this.Click += new System.EventHandler(this.UserControl_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSoldOut)).EndInit();
            this.pnSoldOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbFood;
        public System.Windows.Forms.Label lbPrice;
        public Guna.UI2.WinForms.Guna2TileButton btnSelect;
        public Guna.UI2.WinForms.Guna2PictureBox picSoldOut;
        public System.Windows.Forms.Panel pnSoldOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
