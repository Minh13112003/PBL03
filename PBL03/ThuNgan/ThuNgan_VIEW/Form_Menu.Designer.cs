namespace PBL03
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnStas = new System.Windows.Forms.Panel();
            this.btn_Creams = new System.Windows.Forms.Button();
            this.btn_Drink = new System.Windows.Forms.Button();
            this.btn_Food = new System.Windows.Forms.Button();
            this.flowLayout_Show = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pnStas);
            this.panel1.Controls.Add(this.btn_Creams);
            this.panel1.Controls.Add(this.btn_Drink);
            this.panel1.Controls.Add(this.btn_Food);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 74);
            this.panel1.TabIndex = 0;
            // 
            // pnStas
            // 
            this.pnStas.BackColor = System.Drawing.Color.Tomato;
            this.pnStas.Location = new System.Drawing.Point(0, 62);
            this.pnStas.Name = "pnStas";
            this.pnStas.Size = new System.Drawing.Size(443, 10);
            this.pnStas.TabIndex = 1;
            // 
            // btn_Creams
            // 
            this.btn_Creams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Creams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Creams.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_Creams.Location = new System.Drawing.Point(893, 0);
            this.btn_Creams.Name = "btn_Creams";
            this.btn_Creams.Size = new System.Drawing.Size(444, 62);
            this.btn_Creams.TabIndex = 4;
            this.btn_Creams.Text = "Creams";
            this.btn_Creams.UseVisualStyleBackColor = false;
            this.btn_Creams.Click += new System.EventHandler(this.btn_Creams_Click);
            // 
            // btn_Drink
            // 
            this.btn_Drink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Drink.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_Drink.Location = new System.Drawing.Point(443, 0);
            this.btn_Drink.Name = "btn_Drink";
            this.btn_Drink.Size = new System.Drawing.Size(450, 62);
            this.btn_Drink.TabIndex = 3;
            this.btn_Drink.Text = "Drink";
            this.btn_Drink.UseVisualStyleBackColor = false;
            this.btn_Drink.Click += new System.EventHandler(this.btn_Drink_Click);
            // 
            // btn_Food
            // 
            this.btn_Food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Food.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Food.Location = new System.Drawing.Point(0, 0);
            this.btn_Food.Name = "btn_Food";
            this.btn_Food.Size = new System.Drawing.Size(443, 62);
            this.btn_Food.TabIndex = 0;
            this.btn_Food.Text = "Food";
            this.btn_Food.UseVisualStyleBackColor = false;
            this.btn_Food.Click += new System.EventHandler(this.btn_Food_Click);
            // 
            // flowLayout_Show
            // 
            this.flowLayout_Show.AutoScroll = true;
            this.flowLayout_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.flowLayout_Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayout_Show.BackgroundImage")));
            this.flowLayout_Show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayout_Show.Location = new System.Drawing.Point(0, 78);
            this.flowLayout_Show.Name = "flowLayout_Show";
            this.flowLayout_Show.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayout_Show.Size = new System.Drawing.Size(1337, 562);
            this.flowLayout_Show.TabIndex = 1;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1337, 640);
            this.Controls.Add(this.flowLayout_Show);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Menu";
            this.Text = "Form_Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Creams;
        private System.Windows.Forms.Button btn_Drink;
        private System.Windows.Forms.Button btn_Food;
        private System.Windows.Forms.Panel pnStas;
        public System.Windows.Forms.FlowLayoutPanel flowLayout_Show;
    }
}