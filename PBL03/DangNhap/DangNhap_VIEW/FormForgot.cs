using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL03.DangNhap.DangNhap_BLL;

namespace PBL03.DangNhap.DangNhap_VIEW
{
    public partial class FormForgot : Form
    {
        public FormForgot()
        {
            InitializeComponent();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            if (Login_BLL.Instance.CheckInfor(tbUser.Text, tbName.Text, tbPhone.Text, tbAddress.Text) == true)
            {
                FormForgot2 fg2 = new FormForgot2();
                fg2.tbUser.Text = tbUser.Text;
                fg2.tbUser.Enabled = false;
                fg2.Show();
                this.Dispose();
            }
            else MessageBox.Show("Bạn đã nhập sai thông tin, mời bạn nhập lại");
        }
    }
}
