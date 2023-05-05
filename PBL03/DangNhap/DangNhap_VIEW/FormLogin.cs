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
using PBL03.DangNhap.DangNhap_VIEW;

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
          
            Login_BLL.Instance.dangnhap(tbUsername.Text, tbPassword.Text);
            
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            FormForgot fg = new FormForgot();
            fg.Show();
        }
    }
}
