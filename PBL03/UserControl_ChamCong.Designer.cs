namespace PBL03
{
    partial class UserControl_ChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ChamCong));
            this.btnPayWage = new Guna.UI2.WinForms.Guna2Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSumWorkDay = new System.Windows.Forms.Label();
            this.lbShiftWork = new System.Windows.Forms.Label();
            this.lbSumSalary = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPayWage
            // 
            this.btnPayWage.BackColor = System.Drawing.Color.Transparent;
            this.btnPayWage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayWage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayWage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayWage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayWage.FillColor = System.Drawing.Color.White;
            this.btnPayWage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPayWage.ForeColor = System.Drawing.Color.White;
            this.btnPayWage.Image = ((System.Drawing.Image)(resources.GetObject("btnPayWage.Image")));
            this.btnPayWage.ImageSize = new System.Drawing.Size(45, 45);
            this.btnPayWage.Location = new System.Drawing.Point(609, 29);
            this.btnPayWage.Name = "btnPayWage";
            this.btnPayWage.Size = new System.Drawing.Size(69, 64);
            this.btnPayWage.TabIndex = 37;
            this.btnPayWage.Click += new System.EventHandler(this.btnPayWage_Click_1);
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(179, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(192, 37);
            this.lbName.TabIndex = 38;
            this.lbName.Text = "Tên: ...";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSumWorkDay
            // 
            this.lbSumWorkDay.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumWorkDay.ForeColor = System.Drawing.Color.Black;
            this.lbSumWorkDay.Location = new System.Drawing.Point(397, 10);
            this.lbSumWorkDay.Name = "lbSumWorkDay";
            this.lbSumWorkDay.Size = new System.Drawing.Size(206, 37);
            this.lbSumWorkDay.TabIndex = 39;
            this.lbSumWorkDay.Text = "Số ngày làm: ...";
            this.lbSumWorkDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbShiftWork
            // 
            this.lbShiftWork.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShiftWork.ForeColor = System.Drawing.Color.Black;
            this.lbShiftWork.Location = new System.Drawing.Point(3, 76);
            this.lbShiftWork.Name = "lbShiftWork";
            this.lbShiftWork.Size = new System.Drawing.Size(198, 37);
            this.lbShiftWork.TabIndex = 40;
            this.lbShiftWork.Text = "Ca làm: ...";
            this.lbShiftWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSumSalary
            // 
            this.lbSumSalary.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumSalary.ForeColor = System.Drawing.Color.Black;
            this.lbSumSalary.Location = new System.Drawing.Point(224, 76);
            this.lbSumSalary.Name = "lbSumSalary";
            this.lbSumSalary.Size = new System.Drawing.Size(379, 37);
            this.lbSumSalary.TabIndex = 41;
            this.lbSumSalary.Text = "Tổng lương: ...";
            this.lbSumSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 5);
            this.panel1.TabIndex = 42;
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Location = new System.Drawing.Point(3, 10);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(151, 37);
            this.lbID.TabIndex = 43;
            this.lbID.Text = "ID: ...";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControl_ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSumSalary);
            this.Controls.Add(this.lbShiftWork);
            this.Controls.Add(this.lbSumWorkDay);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnPayWage);
            this.Name = "UserControl_ChamCong";
            this.Size = new System.Drawing.Size(681, 122);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnPayWage;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.Label lbSumWorkDay;
        public System.Windows.Forms.Label lbShiftWork;
        public System.Windows.Forms.Label lbSumSalary;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbID;
    }
}
