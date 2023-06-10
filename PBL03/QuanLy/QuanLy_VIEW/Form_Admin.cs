using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL03.Quanly.Quanly_VIEW;
using PBL03.Thungan.Thungan_VIEW;

namespace PBL03
{
    // Hello World
    public partial class Form_Admin : Form
    {
        int flag = 0;
        public Form_Admin()
        {
            InitializeComponent();
            this.AutoScroll = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        private void hideSubMenu()
        {
            if (pnQLDT.Visible)
            {
                pnQLDT.Visible = false;
            }
            if (pnQLNV.Visible)
            {
                pnQLNV.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnQLNV_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnQLNV);
        }

        private void btnQLDT_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnQLDT);
        }

        private void btnPhucVu_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnThuNgan_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            pnShow.Controls.Clear();
            Form_QuanLyThuNgan ftn = new Form_QuanLyThuNgan
            {
                TopLevel = false
            };
            pnShow.Controls.Add(ftn);
            ftn.Size = pnShow.Size;
            ftn.Show();
        }

        private void btnChiPhi_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLoiNhuan_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            pnShow.Controls.Clear();
            Form_Profit fp = new Form_Profit();
            fp.TopLevel = false;
            pnShow.Controls.Add(fp);
            fp.Size = pnShow.Size;
            fp.Show();
        }

        private void btnDoanhThu_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            pnShow.Controls.Clear();
            Form_Revenue fr = new Form_Revenue();
            fr.TopLevel = false;
            pnShow.Controls.Add(fr);
            fr.Size = pnShow.Size;
            fr.Show();
        }

        private void btnForm_ThuNgan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            pnShow.Controls.Clear();
            Form_StatusTable ftb = new Form_StatusTable();
            ftb.TopLevel = false;
            pnShow.Controls.Add(ftb);
            ftb.Show();


        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            
            ++flag;
            if (flag % 2 != 0)
                pnSetting.Visible = true;
            else
                pnSetting.Visible = false;
        }

       

        private void btnShowProfile_Click(object sender, EventArgs e)
        {
            pnSetting.Visible = false;
            pnShow.Visible = true;
            pnShow.Controls.Clear();
            FormShowInforEmployee fsie = new FormShowInforEmployee();
            fsie.TopLevel = false;
            fsie.FormBorderStyle = FormBorderStyle.None;
            fsie.Dock = DockStyle.Fill;
            pnShow.Controls.Add(fsie);
            fsie.Size = pnShow.Size;
            fsie.tbAccount.Text = lbUserName.Text;
            fsie.tbAccount.Enabled = false;
            fsie.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormLogin flg = (FormLogin)Application.OpenForms["FormLogin"];
            flg.Show();
            flg.tbUsername.Text = string.Empty;
            flg.tbPassword.Text = string.Empty;
        }

        private void btnManageSchedule_Click(object sender, EventArgs e)
        {
            pnSetting.Visible = false;
            pnShow.Visible = true;
            pnShow.Controls.Clear();
            hideSubMenu();
            
            Form_ManageSchedule fms = new Form_ManageSchedule();
            fms.TopLevel = false;
            pnShow.Controls.Add(fms);
            fms.Size = pnShow.Size;
            fms.Show();
        }

        private void btnManageFood_Click(object sender, EventArgs e)
        {
            pnSetting.Visible = false;
            pnShow.Visible = true;
            pnShow.Controls.Clear();
            hideSubMenu();
            Form_ManageFood fmf = new Form_ManageFood();
            fmf.TopLevel = false;
            pnShow.Controls.Add(fmf);
            fmf.Size = pnShow.Size;
            fmf.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            pnSetting.Visible = false;
            pnShow.Visible = true;
            pnShow.Controls.Clear();

            FormChangePass fm = new FormChangePass();
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            pnShow.Controls.Add(fm);
            fm.Size = pnShow.Size;
            fm.tbUsername.Text = lbUserName.Text;
            fm.tbUsername.Enabled = false;

            fm.Show();
        }

        private void btChamCong_Click(object sender, EventArgs e)
        {
            pnShow.Controls.Clear();
            FormChamCong fcc = new FormChamCong();
            fcc.TopLevel = false;
            pnShow.Controls.Add(fcc);
            fcc.Size = pnShow.Size;
            fcc.Show();
        }
    }
}
