using PBL03.DangNhap.DangNhap_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03.DangNhap.DangNhap_VIEW
{
    public partial class FormForgot2 : Form
    {
        public FormForgot2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbnewPass.Text == tbconfirmPass.Text)
            {
                if ((MessageBox.Show("Bạn có muốn đổi mật khẩu không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    string hashpassword = BCrypt.Net.BCrypt.HashPassword(tbconfirmPass.Text);
                    Login_BLL.Instance.ChangePass(tbUsername.Text, hashpassword);
                    MessageBox.Show("Đổi mật khẩu thành công, mời bạn đăng nhập lại !");
                    this.Dispose();
                }

            }
            else MessageBox.Show("New pass và confirm new pass không trùng nhau !");
        }
    }
}
