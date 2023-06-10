using Guna.UI2.WinForms;
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
using static PBL03.Form_Update;

namespace PBL03
{
    public partial class Form_QuanLyThuNgan : Form
    {
        
        public Form_QuanLyThuNgan()
        {
            InitializeComponent();
            ShowDT();
        }

        private void ShowDT()
        {
            dtgvShow.DataSource = Manager_BLL.Instance.Show();
            dtgvShow.Visible = true;
            dtgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        //private async void hideSubMenu()
        //{
        //    if (pnMenu.Visible && btnHomeUp.Visible)
        //    {
        //        pnMenu.Visible = false;
        //        btnHomeUp.Visible = true;
        //        btnHomeDown.Visible = false;
        //    }
        //}
        //private void showSubMenu(Panel subMenu, Guna2Button btn1, Guna2Button btn2)
        //{
        //    if (subMenu.Visible == false)
        //    {
        //        hideSubMenu();
        //        subMenu.Visible = true;
        //        btn1.Visible = false;
        //        btn2.Visible = true;
        //    }
        //    else
        //    {
        //        subMenu.Visible = false;
        //        btn1.Visible = true;
        //        btn2.Visible = false;
        //    }
        //}

        private void btnExpand_Click(object sender, EventArgs e)
        {
            //showSubMenu(pnMenu, btnHomeUp, btnHomeDown);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtgvShow.Visible = false;
            pnDisplayFunction.Visible = true;
            pnDisplayFunction.Controls.Clear();
            Form_Update fu = new Form_Update();
            fu.TopLevel = false;
            fu.FormBorderStyle = FormBorderStyle.None;
            fu.Dock = DockStyle.Fill;
            pnDisplayFunction.Controls.Clear();
           
            pnDisplayFunction.Controls.Add(fu);
            fu.Size = pnDisplayFunction.Size;
            fu.Show();
            fu.pass += new Mydele(ShowDT);

        }
       
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            dtgvShow.Visible = false;
            pnDisplayFunction.Visible = true;
            pnDisplayFunction.Controls.Clear();
            Form_Update fu = new Form_Update()
            {
                TopLevel = false
            };
            
            pnDisplayFunction.Controls.Add(fu);
            fu.Size = pnDisplayFunction.Size;
            
            if (dtgvShow.SelectedRows.Count > 0)
            {
                fu.Show();
                fu.tbAccount.Text = dtgvShow.SelectedRows[0].Cells["Acc"].Value.ToString();
                fu.tbAccount.Enabled = false;
                fu.tbID.Text = dtgvShow.SelectedRows[0].Cells["ID_Employee"].Value.ToString();
                fu.tbID.Enabled = false;
                fu.tbPassword.Enabled = false;
                fu.tbName.Text = dtgvShow.SelectedRows[0].Cells["Name_Employee"].Value.ToString();
                fu.tbAddress.Text = dtgvShow.SelectedRows[0].Cells["Address_Employee"].Value.ToString();
                fu.tbPhone.Text = dtgvShow.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                fu.tbSalary.Text = dtgvShow.SelectedRows[0].Cells["Salary"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hàng để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fu.pass += new Mydele(ShowDT);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            pnDisplayFunction.Visible = false;
            dtgvShow.Visible = true;
            if ((MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Manager_BLL.Instance.Delete(dtgvShow.SelectedRows[0].Cells["Id_Employee"].Value.ToString(), dtgvShow.SelectedRows[0].Cells["Acc"].Value.ToString());
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowDT();
        }

        
        private void btReset_Click(object sender, EventArgs e)
        {
            dtgvShow.DataSource = Manager_BLL.Instance.Show();
        }

        private void dtgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_QuanLyThuNgan_Load(object sender, EventArgs e)
        {
            dtgvShow.DataSource = Manager_BLL.Instance.Show();
        }

        //private void btnHomeDown_Click(object sender, EventArgs e)
        //{
        //    this.Dispose();
        //    FormLogin flg = (FormLogin)Application.OpenForms["FormLogin"];
        //    flg.Show();
        //    flg.tbUsername.Text = string.Empty;
        //    flg.tbPassword.Text = string.Empty;
        //}
    }
}
