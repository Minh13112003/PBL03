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
    public partial class Form_ManageSchedule : Form
    {
        public Form_ManageSchedule()
        {
            InitializeComponent();
            ShowSchedule();
            SetCBBShift();
        }

        private void ShowSchedule()
        {
            dgvWorkSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkSchedule.DataSource = Manager_BLL.Instance.ShowSchedule();
            dgvWorkSchedule.Columns["ID_Schedule"].HeaderText = "ID";
            dgvWorkSchedule.Columns["ID_Employee"].HeaderText = "ID nhân viên";
            dgvWorkSchedule.Columns["Name_Employee"].HeaderText = "Tên nhân viên";
            dgvWorkSchedule.Columns["NameShift"].HeaderText = "Ca";
            dgvWorkSchedule.Columns["DateWork"].HeaderText = "Ngày làm";
            dgvWorkSchedule.Columns["Note"].HeaderText = "Ghi chú";
            dgvWorkSchedule.Visible = true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_ManageSchedule_Load(object sender, EventArgs e)
        {
          
        }

        private void SetCBBShift()
        {
            cbbShiftWork.Items.Add(new CBBItem
            {
                Value = 0,
                Text = "Tất cả ca"
            });
            foreach (var item in Manager_BLL.Instance.GetAllShift())
            {
                cbbShiftWork.Items.Add(new CBBItem
                {
                    Value = item.ID_Shift,
                    Text = item.NameShift
                });
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_EditSchedule fe = new Form_EditSchedule();
            fe.Show();
            fe.pass += new Form_EditSchedule.MyDele(ShowSchedule);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form_EditSchedule fe = new Form_EditSchedule();
            if (dgvWorkSchedule.SelectedRows.Count > 0)
            {
                fe.txtIDSchedule.Enabled = false;
                fe.txtIDSchedule.Text = dgvWorkSchedule.SelectedRows[0].Cells["ID_Schedule"].Value.ToString();
                fe.cbbIDEmployee.Text = dgvWorkSchedule.SelectedRows[0].Cells["ID_Employee"].Value.ToString();
                fe.cbbIDEmployee.Enabled = false;
                fe.txtNameEmployee.Text = dgvWorkSchedule.SelectedRows[0].Cells["Name_Employee"].Value.ToString();
                fe.cbbShiftWork.Text = dgvWorkSchedule.SelectedRows[0].Cells["NameShift"].Value.ToString();
                fe.dtpickerDateWork.Value = Convert.ToDateTime(dgvWorkSchedule.SelectedRows[0].Cells["DateWork"].Value.ToString());
                fe.rtbNote.Text = dgvWorkSchedule.SelectedRows[0].Cells["Note"].Value != null ? dgvWorkSchedule.SelectedRows[0].Cells["Note"].Value.ToString() : "";
                fe.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hàng để chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fe.pass += new Form_EditSchedule.MyDele(ShowSchedule);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvWorkSchedule.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa lịch này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvWorkSchedule.SelectedRows[0].Cells["ID_Schedule"].Value.ToString());
                    Manager_BLL.Instance.DeleteSchedule(id);
                    ShowSchedule();
                }
            }
        }

        private void btnSearchSchedule_Click(object sender, EventArgs e)
        {
            if (cbbShiftWork.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn ca để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbbShiftWork.SelectedItem.ToString() == "Tất cả ca" && txtSearchSchedule.Text == string.Empty)
            {
                dgvWorkSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvWorkSchedule.DataSource = Manager_BLL.Instance.ShowSchedule();
                dgvWorkSchedule.Columns["ID_Schedule"].HeaderText = "ID";
                dgvWorkSchedule.Columns["ID_Employee"].HeaderText = "ID nhân viên";
                dgvWorkSchedule.Columns["Name_Employee"].HeaderText = "Tên nhân viên";
                dgvWorkSchedule.Columns["NameShift"].HeaderText = "Ca";
                dgvWorkSchedule.Columns["DateWork"].HeaderText = "Ngày làm";
                dgvWorkSchedule.Columns["Note"].HeaderText = "Ghi chú";
                dgvWorkSchedule.Visible = true;
            }
            else if (cbbShiftWork.SelectedItem.ToString() == "Tất cả ca" && txtSearchSchedule.Text != string.Empty)
            {
                dgvWorkSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvWorkSchedule.DataSource = Manager_BLL.Instance.ShowAllScheduleOfEPL(txtSearchSchedule.Text);
                dgvWorkSchedule.Columns["ID_Schedule"].HeaderText = "ID";
                dgvWorkSchedule.Columns["ID_Employee"].HeaderText = "ID nhân viên";
                dgvWorkSchedule.Columns["Name_Employee"].HeaderText = "Tên nhân viên";
                dgvWorkSchedule.Columns["NameShift"].HeaderText = "Ca";
                dgvWorkSchedule.Columns["DateWork"].HeaderText = "Ngày làm";
                dgvWorkSchedule.Columns["Note"].HeaderText = "Ghi chú";
                dgvWorkSchedule.Visible = true;
            }
            else
            {
                dgvWorkSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgvWorkSchedule.DataSource = Manager_BLL.Instance.SearchSchedule(txtSearchSchedule.Text, cbbShiftWork.SelectedItem.ToString());
                dgvWorkSchedule.Columns["ID_Schedule"].HeaderText = "ID";
                dgvWorkSchedule.Columns["ID_Employee"].HeaderText = "ID nhân viên";
                dgvWorkSchedule.Columns["Name_Employee"].HeaderText = "Tên nhân viên";
                dgvWorkSchedule.Columns["NameShift"].HeaderText = "Ca";
                dgvWorkSchedule.Columns["DateWork"].HeaderText = "Ngày làm";
                dgvWorkSchedule.Columns["Note"].HeaderText = "Ghi chú";
                dgvWorkSchedule.Visible = true;
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = true;
            btnExpand.Visible = false;
            btnCollapse.Visible = true;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = false;
            btnExpand.Visible = true;
            btnCollapse.Visible = false;
        }
    }
}
