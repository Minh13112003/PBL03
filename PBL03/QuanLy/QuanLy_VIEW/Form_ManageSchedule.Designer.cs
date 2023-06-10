namespace PBL03.Quanly.Quanly_VIEW
{
    partial class Form_ManageSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ManageSchedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExpand = new Guna.UI2.WinForms.Guna2Button();
            this.dgvWorkSchedule = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnCollapse = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpickerSchedule = new System.Windows.Forms.DateTimePicker();
            this.txtSearchSchedule = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchSchedule = new System.Windows.Forms.Button();
            this.cbbShiftWork = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkSchedule)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Controls.Add(this.btnExpand);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1319, 62);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.Transparent;
            this.btnExpand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExpand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExpand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExpand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExpand.FillColor = System.Drawing.Color.Transparent;
            this.btnExpand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExpand.ForeColor = System.Drawing.Color.White;
            this.btnExpand.Image = ((System.Drawing.Image)(resources.GetObject("btnExpand.Image")));
            this.btnExpand.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExpand.Location = new System.Drawing.Point(1073, 27);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(180, 29);
            this.btnExpand.TabIndex = 1;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // dgvWorkSchedule
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvWorkSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorkSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorkSchedule.ColumnHeadersHeight = 4;
            this.dgvWorkSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWorkSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvWorkSchedule.Location = new System.Drawing.Point(30, 155);
            this.dgvWorkSchedule.Name = "dgvWorkSchedule";
            this.dgvWorkSchedule.RowHeadersVisible = false;
            this.dgvWorkSchedule.RowHeadersWidth = 51;
            this.dgvWorkSchedule.RowTemplate.Height = 24;
            this.dgvWorkSchedule.Size = new System.Drawing.Size(871, 298);
            this.dgvWorkSchedule.TabIndex = 1;
            this.dgvWorkSchedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvWorkSchedule.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvWorkSchedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvWorkSchedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvWorkSchedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvWorkSchedule.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvWorkSchedule.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvWorkSchedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvWorkSchedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvWorkSchedule.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWorkSchedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvWorkSchedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvWorkSchedule.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvWorkSchedule.ThemeStyle.ReadOnly = false;
            this.dgvWorkSchedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvWorkSchedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvWorkSchedule.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWorkSchedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvWorkSchedule.ThemeStyle.RowsStyle.Height = 24;
            this.dgvWorkSchedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvWorkSchedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.pnMenu.Controls.Add(this.btnCollapse);
            this.pnMenu.Controls.Add(this.btnDelete);
            this.pnMenu.Controls.Add(this.btnEdit);
            this.pnMenu.Controls.Add(this.btnAdd);
            this.pnMenu.Controls.Add(this.dtpickerSchedule);
            this.pnMenu.Location = new System.Drawing.Point(1012, 62);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(307, 531);
            this.pnMenu.TabIndex = 2;
            this.pnMenu.Visible = false;
            // 
            // btnCollapse
            // 
            this.btnCollapse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCollapse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCollapse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCollapse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCollapse.FillColor = System.Drawing.Color.Transparent;
            this.btnCollapse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCollapse.ForeColor = System.Drawing.Color.White;
            this.btnCollapse.Image = ((System.Drawing.Image)(resources.GetObject("btnCollapse.Image")));
            this.btnCollapse.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCollapse.Location = new System.Drawing.Point(61, 499);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(180, 29);
            this.btnCollapse.TabIndex = 7;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(41, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 50);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(41, 179);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 50);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(41, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpickerSchedule
            // 
            this.dtpickerSchedule.CustomFormat = "dd/MM/yyyy";
            this.dtpickerSchedule.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerSchedule.Location = new System.Drawing.Point(41, 31);
            this.dtpickerSchedule.Name = "dtpickerSchedule";
            this.dtpickerSchedule.Size = new System.Drawing.Size(200, 27);
            this.dtpickerSchedule.TabIndex = 3;
            // 
            // txtSearchSchedule
            // 
            this.txtSearchSchedule.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearchSchedule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSchedule.DefaultText = "";
            this.txtSearchSchedule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSchedule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSchedule.FillColor = System.Drawing.Color.Gainsboro;
            this.txtSearchSchedule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSchedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchSchedule.ForeColor = System.Drawing.Color.Black;
            this.txtSearchSchedule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSchedule.Location = new System.Drawing.Point(30, 82);
            this.txtSearchSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchSchedule.Name = "txtSearchSchedule";
            this.txtSearchSchedule.PasswordChar = '\0';
            this.txtSearchSchedule.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchSchedule.PlaceholderText = "Nhập thông tin cần tìm";
            this.txtSearchSchedule.SelectedText = "";
            this.txtSearchSchedule.Size = new System.Drawing.Size(280, 38);
            this.txtSearchSchedule.TabIndex = 3;
            // 
            // btnSearchSchedule
            // 
            this.btnSearchSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnSearchSchedule.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSchedule.Location = new System.Drawing.Point(530, 82);
            this.btnSearchSchedule.Name = "btnSearchSchedule";
            this.btnSearchSchedule.Size = new System.Drawing.Size(108, 38);
            this.btnSearchSchedule.TabIndex = 5;
            this.btnSearchSchedule.Text = "Search";
            this.btnSearchSchedule.UseVisualStyleBackColor = false;
            this.btnSearchSchedule.Click += new System.EventHandler(this.btnSearchSchedule_Click);
            // 
            // cbbShiftWork
            // 
            this.cbbShiftWork.BackColor = System.Drawing.Color.Transparent;
            this.cbbShiftWork.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbShiftWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShiftWork.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbShiftWork.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbShiftWork.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbShiftWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbShiftWork.ItemHeight = 30;
            this.cbbShiftWork.Location = new System.Drawing.Point(353, 84);
            this.cbbShiftWork.Name = "cbbShiftWork";
            this.cbbShiftWork.Size = new System.Drawing.Size(140, 36);
            this.cbbShiftWork.TabIndex = 6;
            // 
            // Form_ManageSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1319, 593);
            this.Controls.Add(this.cbbShiftWork);
            this.Controls.Add(this.btnSearchSchedule);
            this.Controls.Add(this.txtSearchSchedule);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.dgvWorkSchedule);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ManageSchedule";
            this.Text = "Form_ManageSchedule";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkSchedule)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvWorkSchedule;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpickerSchedule;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchSchedule;
        private System.Windows.Forms.Button btnSearchSchedule;
        private Guna.UI2.WinForms.Guna2ComboBox cbbShiftWork;
        private Guna.UI2.WinForms.Guna2Button btnExpand;
        private Guna.UI2.WinForms.Guna2Button btnCollapse;
    }
}