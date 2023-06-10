namespace PBL03.Quanly.Quanly_VIEW
{
    partial class Form_EditSchedule
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
            this.cbbShiftWork = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIDSchedule = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnOK = new Guna.UI2.WinForms.Guna2TileButton();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.dtpickerDateWork = new System.Windows.Forms.DateTimePicker();
            this.lbDateWork = new System.Windows.Forms.Label();
            this.lbShift = new System.Windows.Forms.Label();
            this.txtNameEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNameEmployee = new System.Windows.Forms.Label();
            this.lbIDEmployee = new System.Windows.Forms.Label();
            this.cbbIDEmployee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbShiftWork
            // 
            this.cbbShiftWork.BackColor = System.Drawing.Color.Transparent;
            this.cbbShiftWork.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbShiftWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShiftWork.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbShiftWork.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbShiftWork.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbShiftWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbShiftWork.ItemHeight = 30;
            this.cbbShiftWork.Location = new System.Drawing.Point(309, 157);
            this.cbbShiftWork.Name = "cbbShiftWork";
            this.cbbShiftWork.Size = new System.Drawing.Size(261, 36);
            this.cbbShiftWork.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 49);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbIDEmployee);
            this.panel2.Controls.Add(this.lbIDEmployee);
            this.panel2.Controls.Add(this.txtIDSchedule);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.rtbNote);
            this.panel2.Controls.Add(this.lbNote);
            this.panel2.Controls.Add(this.dtpickerDateWork);
            this.panel2.Controls.Add(this.lbDateWork);
            this.panel2.Controls.Add(this.lbShift);
            this.panel2.Controls.Add(this.txtNameEmployee);
            this.panel2.Controls.Add(this.lbNameEmployee);
            this.panel2.Controls.Add(this.cbbShiftWork);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 531);
            this.panel2.TabIndex = 2;
            // 
            // txtIDSchedule
            // 
            this.txtIDSchedule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDSchedule.DefaultText = "";
            this.txtIDSchedule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDSchedule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDSchedule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDSchedule.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSchedule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDSchedule.Location = new System.Drawing.Point(12, 4);
            this.txtIDSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDSchedule.Name = "txtIDSchedule";
            this.txtIDSchedule.PasswordChar = '\0';
            this.txtIDSchedule.PlaceholderText = "";
            this.txtIDSchedule.SelectedText = "";
            this.txtIDSchedule.Size = new System.Drawing.Size(60, 31);
            this.txtIDSchedule.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(425, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 43);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BorderRadius = 10;
            this.btnOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOK.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(133, 464);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(145, 43);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNote.Location = new System.Drawing.Point(133, 342);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(437, 96);
            this.rtbNote.TabIndex = 7;
            this.rtbNote.Text = "";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(129, 295);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(72, 20);
            this.lbNote.TabIndex = 6;
            this.lbNote.Text = "Ghi chú";
            // 
            // dtpickerDateWork
            // 
            this.dtpickerDateWork.CustomFormat = "dd/MM/yyyy";
            this.dtpickerDateWork.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerDateWork.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerDateWork.Location = new System.Drawing.Point(309, 221);
            this.dtpickerDateWork.Name = "dtpickerDateWork";
            this.dtpickerDateWork.Size = new System.Drawing.Size(261, 27);
            this.dtpickerDateWork.TabIndex = 5;
            // 
            // lbDateWork
            // 
            this.lbDateWork.AutoSize = true;
            this.lbDateWork.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateWork.Location = new System.Drawing.Point(129, 226);
            this.lbDateWork.Name = "lbDateWork";
            this.lbDateWork.Size = new System.Drawing.Size(81, 20);
            this.lbDateWork.TabIndex = 4;
            this.lbDateWork.Text = "Ngày làm";
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShift.Location = new System.Drawing.Point(129, 157);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(27, 20);
            this.lbShift.TabIndex = 3;
            this.lbShift.Text = "Ca";
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameEmployee.DefaultText = "";
            this.txtNameEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameEmployee.Enabled = false;
            this.txtNameEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameEmployee.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameEmployee.Location = new System.Drawing.Point(309, 91);
            this.txtNameEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.PasswordChar = '\0';
            this.txtNameEmployee.PlaceholderText = "";
            this.txtNameEmployee.SelectedText = "";
            this.txtNameEmployee.Size = new System.Drawing.Size(261, 31);
            this.txtNameEmployee.TabIndex = 2;
            // 
            // lbNameEmployee
            // 
            this.lbNameEmployee.AutoSize = true;
            this.lbNameEmployee.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameEmployee.Location = new System.Drawing.Point(129, 91);
            this.lbNameEmployee.Name = "lbNameEmployee";
            this.lbNameEmployee.Size = new System.Drawing.Size(126, 20);
            this.lbNameEmployee.TabIndex = 1;
            this.lbNameEmployee.Text = "Tên nhân viên";
            // 
            // lbIDEmployee
            // 
            this.lbIDEmployee.AutoSize = true;
            this.lbIDEmployee.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDEmployee.Location = new System.Drawing.Point(129, 23);
            this.lbIDEmployee.Name = "lbIDEmployee";
            this.lbIDEmployee.Size = new System.Drawing.Size(117, 20);
            this.lbIDEmployee.TabIndex = 11;
            this.lbIDEmployee.Text = "ID nhân viên";
            // 
            // cbbIDEmployee
            // 
            this.cbbIDEmployee.BackColor = System.Drawing.Color.Transparent;
            this.cbbIDEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbIDEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIDEmployee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbIDEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbIDEmployee.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbIDEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbIDEmployee.ItemHeight = 30;
            this.cbbIDEmployee.Location = new System.Drawing.Point(309, 23);
            this.cbbIDEmployee.Name = "cbbIDEmployee";
            this.cbbIDEmployee.Size = new System.Drawing.Size(261, 36);
            this.cbbIDEmployee.TabIndex = 12;
            this.cbbIDEmployee.SelectedIndexChanged += new System.EventHandler(this.cbbIDEmployee_SelectedIndexChanged);
            // 
            // Form_EditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditSchedule";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNameEmployee;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbDateWork;
        private System.Windows.Forms.Label lbShift;
        private Guna.UI2.WinForms.Guna2TileButton btnCancel;
        private Guna.UI2.WinForms.Guna2TileButton btnOK;
        public Guna.UI2.WinForms.Guna2TextBox txtIDSchedule;
        public Guna.UI2.WinForms.Guna2ComboBox cbbShiftWork;
        public System.Windows.Forms.RichTextBox rtbNote;
        public System.Windows.Forms.DateTimePicker dtpickerDateWork;
        public Guna.UI2.WinForms.Guna2TextBox txtNameEmployee;
        public Guna.UI2.WinForms.Guna2ComboBox cbbIDEmployee;
        private System.Windows.Forms.Label lbIDEmployee;
    }

      
    
}