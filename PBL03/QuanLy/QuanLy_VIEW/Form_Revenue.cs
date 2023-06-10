using PBL03.Quanly.Quanly_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL03.Quanly.Quanly_VIEW
{
    public partial class Form_Revenue : Form
    {
        public Form_Revenue()
        {
            InitializeComponent();
        }

        public void showRevenue()
        {
            dgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenue.DataSource = Manager_BLL.Instance.showRevenue();
            dgvRevenue.Columns["ID_Revenue"].HeaderText = "STT";
            dgvRevenue.Columns["RevenueInDate"].HeaderText = "Ngày";
            dgvRevenue.Columns["TotalInDate"].HeaderText = "Tổng trong ngày";
            dgvRevenue.Columns["NumberOfBill"].HeaderText = "SL hóa đơn";
            dgvRevenue.Columns["NumberOfCustomer"].HeaderText = "SL khách";
        }
        public void drawChartRevenue()
        {
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();
            chartRevenue.Titles.Clear();
            ChartArea chartArea = new ChartArea();
            chartRevenue.ChartAreas.Add(chartArea);

            Series series = new Series();

            //Đặt tiêu đề cho biểu đồ
            Title title = new Title();
            title.Text = "Doanh thu theo ngày";
            title.Font = new Font("Verdana", 12, FontStyle.Regular);
            title.ForeColor = Color.Green;

            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.Color = Color.Blue;
            series.Name = "Doanh thu";
            series.IsValueShownAsLabel = false;

            foreach (var item in Manager_BLL.Instance.drawChartRevenue())
            {
                series.Points.AddXY(item.RevenueInDate, item.TotalInDate);
            }


            chartRevenue.Series.Add(series);
            chartRevenue.Titles.Add(title);

            chartRevenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartRevenue.ChartAreas[0].AxisX.Interval = 5;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartRevenue.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            chartRevenue.ChartAreas[0].AxisX.Title = "Ngày";

            chartRevenue.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            chartRevenue.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";

            chartRevenue.Invalidate();
            //foreach (var item in bll.drawChartRevenue_BLL())
            //{
            //    chartRevenue.Series["Doanh thu"].Points.AddXY(item.RevenueInDate, item.TotalInDate);
            //}
        }

        public void DrawChartRevenueByDay()
        {
            DateTime st = dtpickerStartDay.Value.Date;
            DateTime et = dtpickerEndDay.Value.Date;
            if (st < et)
            {
                chartRevenue.Series.Clear();
                chartRevenue.ChartAreas.Clear();
                chartRevenue.Titles.Clear();
                ChartArea chartArea = new ChartArea();
                chartRevenue.ChartAreas.Add(chartArea);

                Series series = new Series();

                //Đặt tiêu đề cho biểu đồ
                Title title = new Title();
                title.Text = "Doanh thu theo ngày";
                title.Font = new Font("Verdana", 12, FontStyle.Regular);
                title.ForeColor = Color.Green;

                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 2;
                series.Color = Color.Blue;
                series.Name = "Doanh thu";
                series.IsValueShownAsLabel = false;

                foreach (var item in Manager_BLL.Instance.DrawChartRevenueByDay(st, et))
                {
                    series.Points.AddXY(item.RevenueInDate, item.TotalInDate);
                }


                chartRevenue.Series.Add(series);
                chartRevenue.Titles.Add(title);

                chartRevenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartRevenue.ChartAreas[0].AxisX.Interval = 5;
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chartRevenue.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
                chartRevenue.ChartAreas[0].AxisX.Title = "Ngày";

                chartRevenue.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
                chartRevenue.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
                chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";

                chartRevenue.Invalidate();
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ");
            }
        }

        private void Form_Revenue_Load(object sender, EventArgs e)
        {

            showRevenue();
            drawChartRevenue();
        }

        private void rbtnNgay_CheckedChanged(object sender, EventArgs e)
        {
            lbFrom.Visible = true;
            lbTo.Visible = true;
            dtpickerStartDay.Visible = true;
            dtpickerEndDay.Visible = true;
        }

        private void rbtnThang_CheckedChanged(object sender, EventArgs e)
        {
            lbFrom.Visible = false;
            lbTo.Visible = false;
            dtpickerStartDay.Visible = false;
            dtpickerEndDay.Visible = false;
        }
        private void drawColumnChart()
        {
            Manager_BLL.Instance.drawColumnChart(chartRevenue);
        }

        private void ShowDGVRevenueByDay()
        {
            DateTime st = dtpickerStartDay.Value.Date;
            DateTime et = dtpickerEndDay.Value.Date;
            dgvRevenue.DataSource = Manager_BLL.Instance.showRevenueByDay(st, et);
            dgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenue.Columns["ID_Revenue"].HeaderText = "STT";
            dgvRevenue.Columns["RevenueInDate"].HeaderText = "Ngày";
            dgvRevenue.Columns["TotalInDate"].HeaderText = "Tổng trong ngày";
            dgvRevenue.Columns["NumberOfBill"].HeaderText = "SL hóa đơn";
            dgvRevenue.Columns["NumberOfCustomer"].HeaderText = "SL khách";
        }

        private void ShowDGVRevenueByMonth()
        {
            dgvRevenue.DataSource = Manager_BLL.Instance.ShowRevenueByMonth();
            dgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenue.Columns["Month"].HeaderText = "Tháng";
            dgvRevenue.Columns["Year"].HeaderText = "Năm";
            dgvRevenue.Columns["Total"].HeaderText = "Tổng doanh thu (VND)";
        }

        private void btnShowchart_Click(object sender, EventArgs e)
        {
            if (rbtnNgay.Checked)
            {
                DrawChartRevenueByDay();
                ShowDGVRevenueByDay();
            }
            else if (rbtnThang.Checked)
            {
                drawColumnChart();
                ShowDGVRevenueByMonth();
            }
        }
    }
}

