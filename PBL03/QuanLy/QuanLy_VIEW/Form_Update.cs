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

namespace PBL03
{
    public partial class Form_Update : Form
    {

        public delegate void Mydele();
        public Mydele pass;
        public Form_Update()
        {
            InitializeComponent();
        }
        // button cancel
        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            pass();
            this.Dispose();

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            if (tbAccount.Enabled == true)
            {
                if (tbID.Text == "" || tbName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || tbSalary.Text == "" || tbAccount.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    string hashpassword = BCrypt.Net.BCrypt.HashPassword(tbPassword.Text);
                    if (Manager_BLL.Instance.CheckExistedIDEmployee(tbID.Text))
                    {
                        MessageBox.Show("ID đã tồn tại! Yêu cầu nhập ID khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!Manager_BLL.Instance.CheckExistedUsername(tbAccount.Text))
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại! Yêu cầu nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Manager_BLL.Instance.Add(tbID.Text, tbName.Text, tbPhone.Text, tbAddress.Text, float.Parse(tbSalary.Text), tbAccount.Text, hashpassword);
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pass();
                        this.Dispose();
                    }
                    
                }
            }
            else
            {
                if (tbName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || tbSalary.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    Manager_BLL.Instance.Edit(tbID.Text, tbName.Text, tbPhone.Text, tbAddress.Text, float.Parse(tbSalary.Text), tbAccount.Text);
                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pass();
                    this.Dispose();
                }
            }
        }

        private void Form_Update_Load(object sender, EventArgs e)
        {

        }
    }
}
