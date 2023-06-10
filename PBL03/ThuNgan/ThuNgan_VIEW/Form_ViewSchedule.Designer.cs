namespace PBL03.Thungan.Thungan_VIEW
{
    partial class Form_ViewSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewSchedule));
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.rtbSchedule = new System.Windows.Forms.RichTextBox();
            this.lbTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel3.Controls.Add(this.rtbSchedule);
            this.guna2Panel3.Controls.Add(this.lbTitle);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1319, 593);
            this.guna2Panel3.TabIndex = 2;
            // 
            // rtbSchedule
            // 
            this.rtbSchedule.BackColor = System.Drawing.Color.White;
            this.rtbSchedule.Enabled = false;
            this.rtbSchedule.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSchedule.Location = new System.Drawing.Point(48, 133);
            this.rtbSchedule.Name = "rtbSchedule";
            this.rtbSchedule.Size = new System.Drawing.Size(1240, 432);
            this.rtbSchedule.TabIndex = 1;
            this.rtbSchedule.Text = "";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = false;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.lbTitle.Location = new System.Drawing.Point(516, 30);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(550, 74);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Lịch làm việc hôm nay";
            this.lbTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_ViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1319, 593);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ViewSchedule";
            this.Text = "Form_ViewSchedule";
            this.Load += new System.EventHandler(this.Form_ViewSchedule_Load_1);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.RichTextBox rtbSchedule;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTitle;
    }
}