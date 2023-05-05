using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03
{
    // Hello World
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }
        private async void hideSubMenu()
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
            Form_QuanLyThuNgan ftn = new Form_QuanLyThuNgan();
            ftn.TopLevel = false;
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
            Form_Order fod = new Form_Order();
            fod.Show();
        }
    }
}
