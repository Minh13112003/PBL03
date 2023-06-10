namespace PBL03
{
    partial class Form_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.pnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btChamCong = new System.Windows.Forms.Button();
            this.btnManageFood = new System.Windows.Forms.Button();
            this.btnManageSchedule = new System.Windows.Forms.Button();
            this.pnQLDT = new System.Windows.Forms.Panel();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnQLDT = new System.Windows.Forms.Button();
            this.pnQLNV = new System.Windows.Forms.Panel();
            this.btnThuNgan = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnForm_ThuNgan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnShow = new System.Windows.Forms.Panel();
            this.pnSetting = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.pnMenu.SuspendLayout();
            this.pnQLDT.SuspendLayout();
            this.pnQLNV.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.AutoScroll = true;
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnMenu.Controls.Add(this.btChamCong);
            this.pnMenu.Controls.Add(this.btnManageFood);
            this.pnMenu.Controls.Add(this.btnManageSchedule);
            this.pnMenu.Controls.Add(this.pnQLDT);
            this.pnMenu.Controls.Add(this.btnQLDT);
            this.pnMenu.Controls.Add(this.pnQLNV);
            this.pnMenu.Controls.Add(this.btnQLNV);
            this.pnMenu.Controls.Add(this.btnForm_ThuNgan);
            this.pnMenu.Controls.Add(this.panel3);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(276, 813);
            this.pnMenu.TabIndex = 1;
            // 
            // btChamCong
            // 
            this.btChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChamCong.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChamCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.btChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btChamCong.Location = new System.Drawing.Point(0, 698);
            this.btChamCong.Name = "btChamCong";
            this.btChamCong.Size = new System.Drawing.Size(276, 88);
            this.btChamCong.TabIndex = 21;
            this.btChamCong.Text = "Chấm công";
            this.btChamCong.UseVisualStyleBackColor = false;
            this.btChamCong.Click += new System.EventHandler(this.btChamCong_Click);
            // 
            // btnManageFood
            // 
            this.btnManageFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageFood.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.btnManageFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageFood.Location = new System.Drawing.Point(0, 610);
            this.btnManageFood.Name = "btnManageFood";
            this.btnManageFood.Size = new System.Drawing.Size(276, 88);
            this.btnManageFood.TabIndex = 20;
            this.btnManageFood.Text = "Quản lý món ăn";
            this.btnManageFood.UseVisualStyleBackColor = false;
            this.btnManageFood.Click += new System.EventHandler(this.btnManageFood_Click);
            // 
            // btnManageSchedule
            // 
            this.btnManageSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnManageSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSchedule.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.btnManageSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageSchedule.Location = new System.Drawing.Point(0, 522);
            this.btnManageSchedule.Name = "btnManageSchedule";
            this.btnManageSchedule.Size = new System.Drawing.Size(276, 88);
            this.btnManageSchedule.TabIndex = 19;
            this.btnManageSchedule.Text = "Quản lý lịch làm";
            this.btnManageSchedule.UseVisualStyleBackColor = false;
            this.btnManageSchedule.Click += new System.EventHandler(this.btnManageSchedule_Click);
            // 
            // pnQLDT
            // 
            this.pnQLDT.Controls.Add(this.btnDoanhThu);
            this.pnQLDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnQLDT.Location = new System.Drawing.Point(0, 444);
            this.pnQLDT.Name = "pnQLDT";
            this.pnQLDT.Size = new System.Drawing.Size(276, 78);
            this.pnQLDT.TabIndex = 18;
            this.pnQLDT.Visible = false;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.btnDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(276, 72);
            this.btnDoanhThu.TabIndex = 14;
            this.btnDoanhThu.Text = "Doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click_1);
            // 
            // btnQLDT
            // 
            this.btnQLDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQLDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.btnQLDT.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDT.Image")));
            this.btnQLDT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLDT.Location = new System.Drawing.Point(0, 356);
            this.btnQLDT.Name = "btnQLDT";
            this.btnQLDT.Size = new System.Drawing.Size(276, 88);
            this.btnQLDT.TabIndex = 17;
            this.btnQLDT.Text = "Quản lý doanh thu";
            this.btnQLDT.UseVisualStyleBackColor = false;
            this.btnQLDT.Click += new System.EventHandler(this.btnQLDT_Click_1);
            // 
            // pnQLNV
            // 
            this.pnQLNV.Controls.Add(this.btnThuNgan);
            this.pnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnQLNV.Location = new System.Drawing.Point(0, 281);
            this.pnQLNV.Name = "pnQLNV";
            this.pnQLNV.Size = new System.Drawing.Size(276, 75);
            this.pnQLNV.TabIndex = 16;
            this.pnQLNV.Visible = false;
            // 
            // btnThuNgan
            // 
            this.btnThuNgan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThuNgan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuNgan.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuNgan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.btnThuNgan.Location = new System.Drawing.Point(0, 0);
            this.btnThuNgan.Name = "btnThuNgan";
            this.btnThuNgan.Size = new System.Drawing.Size(276, 70);
            this.btnThuNgan.TabIndex = 13;
            this.btnThuNgan.Text = "Thu ngân";
            this.btnThuNgan.UseVisualStyleBackColor = true;
            this.btnThuNgan.Click += new System.EventHandler(this.btnThuNgan_Click_1);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.btnQLNV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNV.Image")));
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNV.Location = new System.Drawing.Point(0, 193);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(276, 88);
            this.btnQLNV.TabIndex = 15;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click_1);
            // 
            // btnForm_ThuNgan
            // 
            this.btnForm_ThuNgan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnForm_ThuNgan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForm_ThuNgan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm_ThuNgan.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm_ThuNgan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.btnForm_ThuNgan.Location = new System.Drawing.Point(0, 105);
            this.btnForm_ThuNgan.Name = "btnForm_ThuNgan";
            this.btnForm_ThuNgan.Size = new System.Drawing.Size(276, 88);
            this.btnForm_ThuNgan.TabIndex = 14;
            this.btnForm_ThuNgan.Text = "Form thu ngân";
            this.btnForm_ThuNgan.UseVisualStyleBackColor = false;
            this.btnForm_ThuNgan.Click += new System.EventHandler(this.btnForm_ThuNgan_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2PictureBox1);
            this.panel3.Controls.Add(this.lbUserName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 105);
            this.panel3.TabIndex = 13;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(21, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(116, 111);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbUserName
            // 
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(155, 57);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(100, 23);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "label1";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(276, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 105);
            this.panel1.TabIndex = 3;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BorderColor = System.Drawing.Color.Transparent;
            this.btnSetting.BorderRadius = 5;
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.FillColor = System.Drawing.Color.Transparent;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSetting.Location = new System.Drawing.Point(1347, 60);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(55, 42);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1292, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(52, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1350, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(52, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.Color.Transparent;
            this.pnShow.Location = new System.Drawing.Point(276, 111);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(1405, 699);
            this.pnShow.TabIndex = 4;
            // 
            // pnSetting
            // 
            this.pnSetting.BackColor = System.Drawing.Color.Transparent;
            this.pnSetting.Controls.Add(this.btnLogout);
            this.pnSetting.Controls.Add(this.btnShowProfile);
            this.pnSetting.Controls.Add(this.btnChangePass);
            this.pnSetting.Location = new System.Drawing.Point(1478, 105);
            this.pnSetting.Name = "pnSetting";
            this.pnSetting.Size = new System.Drawing.Size(200, 155);
            this.pnSetting.TabIndex = 0;
            this.pnSetting.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(0, 105);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnShowProfile
            // 
            this.btnShowProfile.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowProfile.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnShowProfile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowProfile.ForeColor = System.Drawing.Color.Black;
            this.btnShowProfile.Location = new System.Drawing.Point(0, 54);
            this.btnShowProfile.Name = "btnShowProfile";
            this.btnShowProfile.Size = new System.Drawing.Size(200, 45);
            this.btnShowProfile.TabIndex = 1;
            this.btnShowProfile.Text = "My profile";
            this.btnShowProfile.Click += new System.EventHandler(this.btnShowProfile_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Location = new System.Drawing.Point(0, 3);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(200, 45);
            this.btnChangePass.TabIndex = 0;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1681, 813);
            this.Controls.Add(this.pnSetting);
            this.Controls.Add(this.pnShow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Admin";
            this.pnMenu.ResumeLayout(false);
            this.pnQLDT.ResumeLayout(false);
            this.pnQLNV.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMenu;
        private System.Windows.Forms.Panel pnQLDT;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnQLDT;
        private System.Windows.Forms.Panel pnQLNV;
        private System.Windows.Forms.Button btnThuNgan;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnForm_ThuNgan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel pnShow;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnManageSchedule;
        private System.Windows.Forms.Button btnManageFood;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private System.Windows.Forms.Panel pnSetting;
        private Guna.UI2.WinForms.Guna2Button btnChangePass;
        private Guna.UI2.WinForms.Guna2Button btnShowProfile;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Button btChamCong;
    }
}