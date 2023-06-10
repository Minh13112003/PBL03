namespace PBL03.Quanly.Quanly_VIEW
{
    partial class FormChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChamCong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnChamCong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.FlowLayout_Salary = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgvShow = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.dtpkEditWorkDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            this.cbbWeek = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbWeek = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSumWorkDay = new System.Windows.Forms.Label();
            this.lbShiftWork = new System.Windows.Forms.Label();
            this.btnMail = new Guna.UI2.WinForms.Guna2Button();
            this.guna2MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialogEdit = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(442, 601);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 36);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.Transparent;
            this.btnChamCong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChamCong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChamCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChamCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChamCong.FillColor = System.Drawing.Color.White;
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btnChamCong.Image")));
            this.btnChamCong.Location = new System.Drawing.Point(442, 653);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(120, 36);
            this.btnChamCong.TabIndex = 23;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.guna2ShadowPanel1.Controls.Add(this.FlowLayout_Salary);
            this.guna2ShadowPanel1.Controls.Add(this.dtgvShow);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(55, 146);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1288, 401);
            this.guna2ShadowPanel1.TabIndex = 22;
            // 
            // FlowLayout_Salary
            // 
            this.FlowLayout_Salary.AutoScroll = true;
            this.FlowLayout_Salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.FlowLayout_Salary.Location = new System.Drawing.Point(593, 0);
            this.FlowLayout_Salary.Name = "FlowLayout_Salary";
            this.FlowLayout_Salary.Size = new System.Drawing.Size(695, 401);
            this.FlowLayout_Salary.TabIndex = 9;
            this.FlowLayout_Salary.Visible = false;
            // 
            // dtgvShow
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvShow.ColumnHeadersHeight = 4;
            this.dtgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvShow.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvShow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvShow.Location = new System.Drawing.Point(3, 3);
            this.dtgvShow.Name = "dtgvShow";
            this.dtgvShow.RowHeadersVisible = false;
            this.dtgvShow.RowHeadersWidth = 51;
            this.dtgvShow.RowTemplate.Height = 24;
            this.dtgvShow.Size = new System.Drawing.Size(1282, 395);
            this.dtgvShow.TabIndex = 8;
            this.dtgvShow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvShow.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvShow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvShow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvShow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvShow.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvShow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvShow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvShow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvShow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvShow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvShow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvShow.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvShow.ThemeStyle.ReadOnly = false;
            this.dtgvShow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvShow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvShow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvShow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvShow.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvShow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvShow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(504, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 79);
            this.label3.TabIndex = 21;
            this.label3.Text = "BẢNG CHẤM CÔNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(1189, 625);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 36);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit WorkDay";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtpkEditWorkDay
            // 
            this.dtpkEditWorkDay.Checked = true;
            this.dtpkEditWorkDay.CustomFormat = "dd/MM/yyy";
            this.dtpkEditWorkDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpkEditWorkDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkEditWorkDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkEditWorkDay.Location = new System.Drawing.Point(1093, 567);
            this.dtpkEditWorkDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkEditWorkDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkEditWorkDay.Name = "dtpkEditWorkDay";
            this.dtpkEditWorkDay.Size = new System.Drawing.Size(250, 36);
            this.dtpkEditWorkDay.TabIndex = 30;
            this.dtpkEditWorkDay.Value = new System.DateTime(2023, 5, 25, 10, 33, 49, 369);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(282, 93);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 36);
            this.btnShow.TabIndex = 31;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cbbWeek
            // 
            this.cbbWeek.BackColor = System.Drawing.Color.Transparent;
            this.cbbWeek.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWeek.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbWeek.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbWeek.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbWeek.ItemHeight = 30;
            this.cbbWeek.Location = new System.Drawing.Point(55, 93);
            this.cbbWeek.Name = "cbbWeek";
            this.cbbWeek.Size = new System.Drawing.Size(191, 36);
            this.cbbWeek.TabIndex = 32;
            this.cbbWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbWeek
            // 
            this.lbWeek.BackColor = System.Drawing.Color.Transparent;
            this.lbWeek.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.lbWeek.Location = new System.Drawing.Point(623, 92);
            this.lbWeek.Name = "lbWeek";
            this.lbWeek.Size = new System.Drawing.Size(176, 37);
            this.lbWeek.TabIndex = 33;
            this.lbWeek.Text = "Tuần: ...";
            this.lbWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.lbName.Location = new System.Drawing.Point(54, 566);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(297, 37);
            this.lbName.TabIndex = 34;
            this.lbName.Text = "Tên: ...";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSumWorkDay
            // 
            this.lbSumWorkDay.BackColor = System.Drawing.Color.Transparent;
            this.lbSumWorkDay.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumWorkDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.lbSumWorkDay.Location = new System.Drawing.Point(54, 655);
            this.lbSumWorkDay.Name = "lbSumWorkDay";
            this.lbSumWorkDay.Size = new System.Drawing.Size(256, 37);
            this.lbSumWorkDay.TabIndex = 35;
            this.lbSumWorkDay.Text = "Số ngày làm: ...";
            this.lbSumWorkDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbShiftWork
            // 
            this.lbShiftWork.BackColor = System.Drawing.Color.Transparent;
            this.lbShiftWork.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShiftWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.lbShiftWork.Location = new System.Drawing.Point(54, 612);
            this.lbShiftWork.Name = "lbShiftWork";
            this.lbShiftWork.Size = new System.Drawing.Size(251, 37);
            this.lbShiftWork.TabIndex = 36;
            this.lbShiftWork.Text = "Ca làm: ...";
            this.lbShiftWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.Transparent;
            this.btnMail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMail.FillColor = System.Drawing.Color.Transparent;
            this.btnMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMail.ForeColor = System.Drawing.Color.Black;
            this.btnMail.Image = ((System.Drawing.Image)(resources.GetObject("btnMail.Image")));
            this.btnMail.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMail.Location = new System.Drawing.Point(1256, 85);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(87, 55);
            this.btnMail.TabIndex = 37;
            this.btnMail.Visible = false;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // guna2MessageDialog
            // 
            this.guna2MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog.Caption = "Thông báo";
            this.guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog.Parent = null;
            this.guna2MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog.Text = null;
            // 
            // guna2MessageDialogEdit
            // 
            this.guna2MessageDialogEdit.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialogEdit.Caption = "Thông báo";
            this.guna2MessageDialogEdit.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialogEdit.Parent = null;
            this.guna2MessageDialogEdit.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialogEdit.Text = "";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Thứ 2";
            this.Monday.MinimumWidth = 6;
            this.Monday.Name = "Monday";
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "Thứ 3";
            this.Tuesday.MinimumWidth = 6;
            this.Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Thứ 4";
            this.Wednesday.MinimumWidth = 6;
            this.Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Thứ 5";
            this.Thursday.MinimumWidth = 6;
            this.Thursday.Name = "Thursday";
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Thứ 6";
            this.Friday.MinimumWidth = 6;
            this.Friday.Name = "Friday";
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Thứ 7";
            this.Saturday.MinimumWidth = 6;
            this.Saturday.Name = "Saturday";
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "Chủ nhật";
            this.Sunday.MinimumWidth = 6;
            this.Sunday.Name = "Sunday";
            // 
            // FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 701);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.lbShiftWork);
            this.Controls.Add(this.lbSumWorkDay);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbWeek);
            this.Controls.Add(this.cbbWeek);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtpkEditWorkDay);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChamCong";
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnChamCong;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvShow;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkEditWorkDay;
        private Guna.UI2.WinForms.Guna2Button btnShow;
        private Guna.UI2.WinForms.Guna2ComboBox cbbWeek;
        private System.Windows.Forms.Label lbWeek;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSumWorkDay;
        private System.Windows.Forms.Label lbShiftWork;
        private Guna.UI2.WinForms.Guna2Button btnMail;
        public System.Windows.Forms.FlowLayoutPanel FlowLayout_Salary;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialogEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
    }
}