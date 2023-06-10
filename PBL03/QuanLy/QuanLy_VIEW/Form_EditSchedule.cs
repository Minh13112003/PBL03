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

namespace PBL03.Quanly.Quanly_VIEW
{
    public partial class Form_EditSchedule : Form
    {
        public delegate void MyDele();
        public MyDele pass;
        public Form_EditSchedule()
        {
            InitializeComponent();
            SetCBBShift();
            SetCBBIDEmployee();
        }

        private void SetCBBIDEmployee()
        {
            //cbbIDEmployee.Items.Add(Manager_BLL.Instance.GetAllIDEmployee().ToArray());
            int count = 0;
            foreach (var item in Manager_BLL.Instance.GetAllIDEmployee())
            {
                cbbIDEmployee.Items.Add(new CBBItem
                {
                    Value = ++count,
                    Text = item.ID_Employee
                });
            }
        }
        private void SetCBBShift()
        {
            foreach (var item in Manager_BLL.Instance.GetAllShift())
            {
                cbbShiftWork.Items.Add(new CBBItem
                {
                    Value = item.ID_Shift,
                    Text = item.NameShift
                });
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (txtIDSchedule.Enabled == true)
            {
                if (txtIDSchedule.Text == "" || txtNameEmployee.Text == "" || cbbShiftWork.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int id = Convert.ToInt32(txtIDSchedule.Text);
                    string idepl = cbbIDEmployee.SelectedItem.ToString();
                    int idshift = Manager_BLL.Instance.GetIDShift(cbbShiftWork.SelectedItem.ToString());
                    DateTime dt = Convert.ToDateTime(dtpickerDateWork.Value.ToString("yyyy/MM/dd"));
                    string note = rtbNote.Text;
                    if (Manager_BLL.Instance.CheckExistedIDEPLInSchedule(idepl))
                    {
                        MessageBox.Show("Nhân viên này đã có lịch làm. Yêu cầu chọn nhân viên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Manager_BLL.Instance.CheckExistedIDSchedule(id))
                    {
                        MessageBox.Show("ID này đã tồn tại! Yêu cầu nhập ID khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Manager_BLL.Instance.AddSchedule(id, idepl, idshift, dt, note);
                        pass();
                        MessageBox.Show("Thêm lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
            else
            {
                if (txtIDSchedule.Text == "" || txtNameEmployee.Text == "" || cbbShiftWork.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int id = Convert.ToInt32(txtIDSchedule.Text);
                    string idepl = cbbIDEmployee.Text;
                    int idshift = Manager_BLL.Instance.GetIDShift(cbbShiftWork.SelectedItem.ToString());
                    DateTime dt = Convert.ToDateTime(dtpickerDateWork.Value.ToString("yyyy/MM/dd"));
                    string note = rtbNote.Text;
                    Manager_BLL.Instance.EditSchedule(id, idepl, idshift, dt, note);
                    pass();
                    MessageBox.Show("Cập nhật lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbbIDEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNameEmployee.Text = Manager_BLL.Instance.GetNameEmployeeByID(cbbIDEmployee.SelectedItem.ToString());
        }
    }
}
