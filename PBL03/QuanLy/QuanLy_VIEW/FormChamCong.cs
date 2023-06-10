using PBL03.Quanly.Quanly_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03.Quanly.Quanly_VIEW
{
    public partial class FormChamCong : Form
    {
        
        private int flag = 0;
        public FormChamCong()
        {
            InitializeComponent();
            dtpkEditWorkDay.Value = DateTime.Now;
            cbbWeek.Items.AddRange(Manager_BLL.Instance.getWeekOfDays_BLL().ToArray());
            lbWeek.Text = "Tuần: " + GetWeekNumberOfDate(DateTime.Now);
            if (DateTime.Now.Day == 10)
            {
                btnMail.Visible = true;
            }
            List<string> danhSachID = Manager_BLL.Instance.GetIDEmployeeInTimeSheet();
            dtgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTextBoxColumn IDColumn = (DataGridViewTextBoxColumn)dtgvShow.Columns["ID"];
            DataGridViewTextBoxColumn tenColumn = (DataGridViewTextBoxColumn)dtgvShow.Columns["Name"];
            foreach (string id in danhSachID)
            {
                string ten = Manager_BLL.Instance.GetNameEmployeeByID(id);
                IDColumn.DataGridView.Rows.Add(id,ten);
            }
        }
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            string idEmployee = dtgvShow.SelectedRows[0].Cells[0].Value.ToString();
            string nameEmployee = dtgvShow.SelectedRows[0].Cells[1].Value.ToString();
            DateTime datenow = DateTime.Now;
            DateTime currentDate = datenow.Date;
            if (Manager_BLL.Instance.CountShiftInDay(idEmployee, currentDate))
            {
                guna2MessageDialog.Show("Nhân viên này đã làm đủ số ca trong ngày nên không thể chấm công thêm!");
            }
            else
            {
                if (Manager_BLL.Instance.CheckExistOfDay_BLL(idEmployee, currentDate) != currentDate)
                {
                    Manager_BLL.Instance.Add_WorkDay_BLL(idEmployee, currentDate);
                    guna2MessageDialog.Show("Đã chấm công thành công cho thu ngân " + nameEmployee);
                }
                else
                {
                    DialogResult result = guna2MessageDialogEdit.Show("Nhân viên này đã được điểm danh vào ngày này.\n Nếu nhân viên này đang làm thêm ca:\n+ chọn YES để cộng thêm ngày làm cho nhân viên này\n+ chọn NO để hủy");
                    if (result == DialogResult.Yes)
                    {
                        Manager_BLL.Instance.Add_WorkDay_BLL(idEmployee, currentDate);
                        guna2MessageDialog.Show("Đã chấm công thành công cho thu ngân " + nameEmployee);
                    }
                }
            }
        }
        //Lấy được số tuần của ngày
        public int GetWeekNumberOfDate(DateTime date)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            Calendar calendar = ci.Calendar;
            CalendarWeekRule calendarWeekRule = ci.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = ci.DateTimeFormat.FirstDayOfWeek;

            return calendar.GetWeekOfYear(date, calendarWeekRule, firstDayOfWeek);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbShiftWork.Text = string.Empty;
            lbSumWorkDay.Text = string.Empty;
            string nameEmployee = dtgvShow.SelectedRows[0].Cells[1].Value.ToString();
            string idEmployee = dtgvShow.SelectedRows[0].Cells[0].Value.ToString();
            lbName.Text = "Tên nhân viên: " + nameEmployee;
            lbSumWorkDay.Text = "Số ngày làm: " + Manager_BLL.Instance.SumWorkDay_BLL(idEmployee).ToString();
            lbShiftWork.Text = "Ca làm: " + Manager_BLL.Instance.getShiftWork_BLL(idEmployee);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string idEmployee = dtgvShow.SelectedRows[0].Cells[0].Value.ToString();
            string nameEmployee = dtgvShow.SelectedRows[0].Cells[1].Value.ToString();
            if (Manager_BLL.Instance.CountShiftInDay(idEmployee, dtpkEditWorkDay.Value.Date))
            {
                guna2MessageDialog.Show("Nhân viên này đã làm đủ số ca trong ngày nên không thể chấm công thêm!");
            }
            else
            {
                if (Manager_BLL.Instance.CheckExistOfDay_BLL(idEmployee, dtpkEditWorkDay.Value.Date) != dtpkEditWorkDay.Value.Date)
                {
                    Manager_BLL.Instance.Add_WorkDay_BLL(idEmployee, dtpkEditWorkDay.Value);
                    guna2MessageDialog.Show("Đã chấm công thành công cho thu ngân " + nameEmployee);
                }
                else
                {
                    DialogResult result = guna2MessageDialogEdit.Show("Nhân viên này đã được điểm danh vào ngày này.\n Nếu nhân viên này đang làm thêm ca:\n+ chọn YES để cộng thêm ngày làm cho nhân viên này\n+ chọn NO để hủy");
                    if (result == DialogResult.Yes)
                    {
                        Manager_BLL.Instance.Add_WorkDay_BLL(idEmployee, dtpkEditWorkDay.Value);
                        guna2MessageDialog.Show("Đã chấm công thành công cho thu ngân " + nameEmployee);
                    }
                }
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbbWeek.SelectedIndex == -1)
            {
                guna2MessageDialog.Show("Cần chọn tuần trước khi thực hiện chấm công");
            }
            else
            {
                string week = cbbWeek.SelectedItem.ToString();
                dtgvShow.Rows.Clear();
                List<string> danhSachID = Manager_BLL.Instance.GetIDEmployeeInTimeSheet();
                dtgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                DataGridViewTextBoxColumn tenColumn = (DataGridViewTextBoxColumn)dtgvShow.Columns["Name"];
                DataGridViewTextBoxColumn IDColumn = (DataGridViewTextBoxColumn)dtgvShow.Columns["ID"];
                
                foreach (string id in danhSachID)
                {
                    string ten = Manager_BLL.Instance.GetNameEmployeeByID(id);
                    IDColumn.DataGridView.Rows.Add(id, ten);
                }
                foreach (string id in danhSachID)
                {
                    int idWorkSchedule = Manager_BLL.Instance.getIDSchedule_BLL(id);
                    List<DateTime> days = Manager_BLL.Instance.getWorkDayOfEmployee_BLL(idWorkSchedule, Convert.ToInt32(week));
                    foreach (var item in days)
                    {
                        DayOfWeek currentDayOfWeek = item.DayOfWeek;
                        foreach (DataGridViewColumn column in dtgvShow.Columns)
                        {
                            if (column.Name == currentDayOfWeek.ToString())
                            {
                                foreach (DataGridViewRow row in dtgvShow.Rows)
                                {
                                    if (row.Cells["ID"].Value.ToString() == id)
                                    {
                                        row.Cells[column.Index].Value = "X";
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
            
        }
        private void btnMail_Click(object sender, EventArgs e)
        {
            ++flag;
            if (flag % 2 != 0)
            {
                FlowLayout_Salary.Visible = true;
                FlowLayout_Salary.Controls.Clear();
                List<string> id = Manager_BLL.Instance.GetIDEmployeeInTimeSheet();
                foreach (var item in id)
                {
                    string ten = Manager_BLL.Instance.GetNameEmployeeByID(item);
                    float salary = Manager_BLL.Instance.getSalary_BLL(item);
                    int sumWorkDay = Manager_BLL.Instance.SumWorkDay_BLL(item);
                    string shiftwork = Manager_BLL.Instance.getShiftWork_BLL(item);
                    float sumSalary = salary * sumWorkDay * 5;
                    if (sumWorkDay > 1)
                    {
                        UserControl_ChamCong ucc = new UserControl_ChamCong();
                        ucc.lbID.Text = "ID: " + item;
                        ucc.lbName.Text = "Tên: " + ten;
                        ucc.lbShiftWork.Text = "Ca làm: " + shiftwork;
                        ucc.lbSumWorkDay.Text = "Số ngày làm: " + sumWorkDay.ToString();
                        ucc.lbSumSalary.Text = "Tổng tiền lương: " + sumSalary.ToString("#,##0") + " VND";
                        FlowLayout_Salary.Controls.Add(ucc);
                    }
                }
            }
            else
            {
                FlowLayout_Salary.Visible = false;
            }
        }
    }
}
