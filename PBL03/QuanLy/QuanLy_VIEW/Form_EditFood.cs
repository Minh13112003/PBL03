using PBL03.Quanly.Quanly_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03.Quanly.Quanly_VIEW
{
    public partial class Form_EditFood : Form
    {
        public Form_EditFood()
        {
            InitializeComponent();
            SetComboBox();
        }

        public delegate void MyDele();
        public MyDele pass;

        private List<CBBItem> SetCBBCategory()
        {
            List<CBBItem> list = new List<CBBItem>();
            int count = 0;
            foreach (FoodCategory i in Manager_BLL.Instance.GetAllCategory())
            {
                list.Add(new CBBItem
                {
                    Value = ++count,
                    Text = i.NameCategory
                });
            }
            return list;
        }

        private void SetComboBox()
        {
            cbbCategory.Items.AddRange(SetCBBCategory().ToArray());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtID_Food.Text.Length < 2)
            {
                MessageBox.Show("Mã món chưa đảm bảo đủ độ dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtNameFood.Text == "")
            {
                MessageBox.Show("Chưa điền tên món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Chưa điền giá món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn loại món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPicture.Text == "")
            {
                MessageBox.Show("Chưa chọn ảnh của món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtID_Food.Enabled == true)
                {
                    string name = txtNameFood.Text;
                    float price = Convert.ToSingle(txtPrice.Text);
                    string IDCategory = Manager_BLL.Instance.GetID_FoodCategory(cbbCategory.SelectedItem.ToString());
                    string img = txtPicture.Text;
                    string id = txtID_Food.Text;
                    if (!Manager_BLL.Instance.CheckExistedIDFood(id))
                    {
                        Manager_BLL.Instance.AddFood(id, name, price, IDCategory, img);
                        MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pass();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("ID này đã tồn tại! Yêu cầu nhập ID khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    string name = txtNameFood.Text;
                    float price = Convert.ToSingle(txtPrice.Text);
                    string IDCategory = Manager_BLL.Instance.GetID_FoodCategory(cbbCategory.SelectedItem.ToString());
                    string img = txtPicture.Text;
                    string id = txtID_Food.Text;
                    bool tt = true;
                    if (rbtnCon.Checked)
                    {
                        tt = true;
                    }
                    if (rbtnHet.Checked)
                    {
                        tt = false;
                    }
                    Manager_BLL.Instance.EditFood(id, name, price, tt, IDCategory, 200, img);
                    MessageBox.Show("Cập nhật món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pass();
                    this.Dispose();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            string imageFolderpath = @"D:\PBL03-master\PBL03\bin\Debug\Images";
            f.InitialDirectory = imageFolderpath;
            if (f.ShowDialog() == DialogResult.OK)
            {
                string imgpath = f.FileName;
                string folderpath = Path.GetDirectoryName(Application.ExecutablePath);
                string relativepath = imgpath.Substring(folderpath.Length).TrimStart('\\');
                txtPicture.Text = relativepath;
                byte[] imgdata = File.ReadAllBytes(imgpath);
                using (MemoryStream ms = new MemoryStream(imgdata))
                {
                    Image i = Image.FromStream(ms);
                    pictureFood.Image = i;
                }
            }
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == 0)
            {
                txtID_Food.Text = "K";
            }
            if (cbbCategory.SelectedIndex == 1)
            {
                txtID_Food.Text = "D";
            }
            if (cbbCategory.SelectedIndex == 2)
            {
                txtID_Food.Text = "F";
            }
        }

    }
}
