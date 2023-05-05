using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL03.QuanLy.QuanLy_BLL;

namespace PBL03
{
    public partial class Form_Update : Form
    {
        public Form_Update()
        {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            if(tbAccount.Enabled == true)
            {
                if((MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    string hashpassword = BCrypt.Net.BCrypt.HashPassword(tbPassword.Text);
                    Manager_BLL.Instance.Add(tbID.Text, tbName.Text, tbPhone.Text, tbAddress.Text, float.Parse(tbSalary.Text), tbAccount.Text, hashpassword);
                    MessageBox.Show("Thêm tài khoản thành công!,mời bạn nhấn Reset để cập nhật");
                    this.Dispose();
                }
            }
            else
            {
                if((MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    Manager_BLL.Instance.Edit(tbID.Text, tbName.Text, tbPhone.Text, tbAddress.Text, float.Parse(tbSalary.Text), tbAccount.Text);
                    MessageBox.Show("Chỉnh sửa thành công !, mời bạn nhấn Reset để cập nhật");
                }
            }
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Update_Load(object sender, EventArgs e)
        {

        }
    }
}
