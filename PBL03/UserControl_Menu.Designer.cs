namespace PBL03
{
    partial class UserControl_Menu
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.STT = new System.Windows.Forms.Label();
            this.ID_Food = new System.Windows.Forms.Label();
            this.Name_Food = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 25;
            this.guna2GradientPanel1.Controls.Add(this.Price);
            this.guna2GradientPanel1.Controls.Add(this.Status);
            this.guna2GradientPanel1.Controls.Add(this.Name_Food);
            this.guna2GradientPanel1.Controls.Add(this.ID_Food);
            this.guna2GradientPanel1.Controls.Add(this.STT);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1317, 65);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.STT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.STT.Location = new System.Drawing.Point(25, 15);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(101, 34);
            this.STT.TabIndex = 11;
            this.STT.Text = "STT";
            this.STT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID_Food
            // 
            this.ID_Food.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.ID_Food.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.ID_Food.Location = new System.Drawing.Point(218, 15);
            this.ID_Food.Name = "ID_Food";
            this.ID_Food.Size = new System.Drawing.Size(170, 34);
            this.ID_Food.TabIndex = 12;
            this.ID_Food.Text = "ID Food";
            this.ID_Food.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name_Food
            // 
            this.Name_Food.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.Name_Food.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.Name_Food.Location = new System.Drawing.Point(439, 15);
            this.Name_Food.Name = "Name_Food";
            this.Name_Food.Size = new System.Drawing.Size(435, 34);
            this.Name_Food.TabIndex = 13;
            this.Name_Food.Text = "Name Food";
            this.Name_Food.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.Status.Location = new System.Drawing.Point(899, 15);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(203, 34);
            this.Status.TabIndex = 14;
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.Price.Location = new System.Drawing.Point(1125, 15);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(170, 34);
            this.Price.TabIndex = 15;
            this.Price.Text = "Price $";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl_Menu";
            this.Size = new System.Drawing.Size(1317, 65);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Name_Food;
        private System.Windows.Forms.Label ID_Food;
        private System.Windows.Forms.Label STT;
    }
}
