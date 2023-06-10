namespace PBL03.Quanly.Quanly_VIEW
{
    partial class Form_Revenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Revenue));
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvRevenue = new Guna.UI2.WinForms.Guna2DataGridView();
            this.rbtnNgay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtnThang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtpickerStartDay = new System.Windows.Forms.DateTimePicker();
            this.dtpickerEndDay = new System.Windows.Forms.DateTimePicker();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.btnShowchart = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(4, 4);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            series1.YValuesPerPoint = 2;
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(685, 698);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Text = "chart1";
            title1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Doanh thu";
            this.chartRevenue.Titles.Add(title1);
            // 
            // dgvRevenue
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRevenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRevenue.ColumnHeadersHeight = 4;
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRevenue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRevenue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRevenue.Location = new System.Drawing.Point(695, 133);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.RowHeadersVisible = false;
            this.dgvRevenue.RowHeadersWidth = 51;
            this.dgvRevenue.RowTemplate.Height = 24;
            this.dgvRevenue.Size = new System.Drawing.Size(703, 578);
            this.dgvRevenue.TabIndex = 1;
            this.dgvRevenue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRevenue.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRevenue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRevenue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRevenue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRevenue.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRevenue.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRevenue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRevenue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRevenue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRevenue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRevenue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRevenue.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvRevenue.ThemeStyle.ReadOnly = false;
            this.dgvRevenue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRevenue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRevenue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRevenue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRevenue.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRevenue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRevenue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // rbtnNgay
            // 
            this.rbtnNgay.AutoSize = true;
            this.rbtnNgay.BackColor = System.Drawing.Color.Transparent;
            this.rbtnNgay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnNgay.CheckedState.BorderThickness = 0;
            this.rbtnNgay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnNgay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnNgay.CheckedState.InnerOffset = -4;
            this.rbtnNgay.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNgay.ForeColor = System.Drawing.Color.White;
            this.rbtnNgay.Location = new System.Drawing.Point(793, 28);
            this.rbtnNgay.Name = "rbtnNgay";
            this.rbtnNgay.Size = new System.Drawing.Size(66, 24);
            this.rbtnNgay.TabIndex = 2;
            this.rbtnNgay.Text = "Ngày";
            this.rbtnNgay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnNgay.UncheckedState.BorderThickness = 2;
            this.rbtnNgay.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnNgay.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnNgay.UseVisualStyleBackColor = false;
            this.rbtnNgay.CheckedChanged += new System.EventHandler(this.rbtnNgay_CheckedChanged);
            // 
            // rbtnThang
            // 
            this.rbtnThang.AutoSize = true;
            this.rbtnThang.BackColor = System.Drawing.Color.Transparent;
            this.rbtnThang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnThang.CheckedState.BorderThickness = 0;
            this.rbtnThang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtnThang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtnThang.CheckedState.InnerOffset = -4;
            this.rbtnThang.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnThang.ForeColor = System.Drawing.Color.White;
            this.rbtnThang.Location = new System.Drawing.Point(1064, 28);
            this.rbtnThang.Name = "rbtnThang";
            this.rbtnThang.Size = new System.Drawing.Size(75, 24);
            this.rbtnThang.TabIndex = 3;
            this.rbtnThang.Text = "Tháng";
            this.rbtnThang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtnThang.UncheckedState.BorderThickness = 2;
            this.rbtnThang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtnThang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtnThang.UseVisualStyleBackColor = false;
            this.rbtnThang.CheckedChanged += new System.EventHandler(this.rbtnThang_CheckedChanged);
            // 
            // dtpickerStartDay
            // 
            this.dtpickerStartDay.CustomFormat = "dd/MM/yyyy";
            this.dtpickerStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerStartDay.Location = new System.Drawing.Point(793, 84);
            this.dtpickerStartDay.Name = "dtpickerStartDay";
            this.dtpickerStartDay.Size = new System.Drawing.Size(200, 22);
            this.dtpickerStartDay.TabIndex = 4;
            this.dtpickerStartDay.Visible = false;
            // 
            // dtpickerEndDay
            // 
            this.dtpickerEndDay.CustomFormat = "dd/MM/yyyy";
            this.dtpickerEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerEndDay.Location = new System.Drawing.Point(1125, 84);
            this.dtpickerEndDay.Name = "dtpickerEndDay";
            this.dtpickerEndDay.Size = new System.Drawing.Size(200, 22);
            this.dtpickerEndDay.TabIndex = 5;
            this.dtpickerEndDay.Visible = false;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.BackColor = System.Drawing.Color.Transparent;
            this.lbFrom.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.ForeColor = System.Drawing.Color.White;
            this.lbFrom.Location = new System.Drawing.Point(733, 86);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(27, 20);
            this.lbFrom.TabIndex = 6;
            this.lbFrom.Text = "Từ";
            this.lbFrom.Visible = false;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.BackColor = System.Drawing.Color.Transparent;
            this.lbTo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.ForeColor = System.Drawing.Color.White;
            this.lbTo.Location = new System.Drawing.Point(1068, 86);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(36, 20);
            this.lbTo.TabIndex = 7;
            this.lbTo.Text = "Đến";
            this.lbTo.Visible = false;
            // 
            // btnShowchart
            // 
            this.btnShowchart.BackColor = System.Drawing.Color.Transparent;
            this.btnShowchart.BorderRadius = 10;
            this.btnShowchart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowchart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowchart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowchart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowchart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowchart.ForeColor = System.Drawing.Color.White;
            this.btnShowchart.Location = new System.Drawing.Point(1276, 12);
            this.btnShowchart.Name = "btnShowchart";
            this.btnShowchart.Size = new System.Drawing.Size(111, 50);
            this.btnShowchart.TabIndex = 8;
            this.btnShowchart.Text = "Show";
            this.btnShowchart.Click += new System.EventHandler(this.btnShowchart_Click);
            // 
            // Form_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 707);
            this.Controls.Add(this.btnShowchart);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.dtpickerEndDay);
            this.Controls.Add(this.dtpickerStartDay);
            this.Controls.Add(this.rbtnThang);
            this.Controls.Add(this.rbtnNgay);
            this.Controls.Add(this.dgvRevenue);
            this.Controls.Add(this.chartRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Revenue";
            this.Text = "Form_Revenue";
            this.Load += new System.EventHandler(this.Form_Revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRevenue;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnNgay;
        private Guna.UI2.WinForms.Guna2RadioButton rbtnThang;
        private System.Windows.Forms.DateTimePicker dtpickerStartDay;
        private System.Windows.Forms.DateTimePicker dtpickerEndDay;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private Guna.UI2.WinForms.Guna2Button btnShowchart;

    }
}