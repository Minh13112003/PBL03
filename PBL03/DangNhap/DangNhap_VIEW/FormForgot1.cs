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
    public partial class FormForgot1 : Form
    {
        public FormForgot1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Login_BLL.Instance.CheckInfor(tbUsername.Text, tbName.Text, tbPhone.Text, tbAddress.Text) == true)
            {
                FormForgot2 fg2 = new FormForgot2();
                fg2.tbUsername.Text = tbUsername.Text;
                fg2.tbUsername.Enabled = false;
                fg2.Show();
                this.Dispose();
            }
            else MessageBox.Show("Bạn đã nhập sai thông tin, mời bạn nhập lại");
        }
    }
}
