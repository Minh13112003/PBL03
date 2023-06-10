using PBL03.DangNhap.DangNhap_BLL;
using PBL03.DangNhap.DangNhap_VIEW;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;
            btnLogin.ForeColor = Color.LightBlue;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.SandyBrown;
            btnLogin.ForeColor = Color.Black;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login_BLL.Instance.CheckQuanLy(tbUsername.Text, tbPassword.Text) == Login_BLL.Instance.CheckThuNgan(tbUsername.Text, tbPassword.Text))
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu");
            }
            else
            {
                if(Login_BLL.Instance.CheckQuanLy(tbUsername.Text, tbPassword.Text) == true)
                {
                    Form_Admin fad = new Form_Admin();
                    fad.lbUserName.Text = tbUsername.Text;
                    fad.Show();
                    
                }
                else
                {
                    FormMain ftn = new FormMain();
                    ftn.lbNameUser.Text = tbUsername.Text;
                    ftn.Show();
                    
                }
            }
           
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            FormForgot1 fg = new FormForgot1();
            fg.Show();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = true;
            }
            else tbPassword.UseSystemPasswordChar = false;
        }

        private void KeyPress_TextBox(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                e.Handled = true;
            }
        }
    }
}
