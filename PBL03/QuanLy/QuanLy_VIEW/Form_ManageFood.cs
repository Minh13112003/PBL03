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

namespace PBL03.Quanly.Quanly_VIEW
{
    public partial class Form_ManageFood : Form
    {
        private int index = 0;
        public Form_ManageFood()
        {
            InitializeComponent();

        }

        private void ShowDGVFood()
        {
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.DataSource = Manager_BLL.Instance.GetNextFood(index);
            dgvFood.Columns["ID_Food"].HeaderText = "ID";
            dgvFood.Columns["NameFood"].HeaderText = "Tên món";
            dgvFood.Columns["Price"].HeaderText = "Giá";
            dgvFood.Columns["QuantityFood"].HeaderText = "Số lượng còn dư";
            dgvFood.Columns["NameCategory"].HeaderText = "Loại món";
        }

        private void Form_ManageFood_Load(object sender, EventArgs e)
        {
            ShowDGVFood();
            SetEnableButton();
        }

        private void SetEnableButton()
        {
            btnNext.Enabled = index + 5 < Manager_BLL.Instance.CountRow();
            btnPrevious.Enabled = index > 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index -= 5;
            if (index < 0)
            {
                index = 0;
            }
            dgvFood.DataSource = Manager_BLL.Instance.GetNextFood(index);
            SetEnableButton();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index += 5;
            dgvFood.DataSource = Manager_BLL.Instance.GetNextFood(index);
            SetEnableButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_EditFood fef = new Form_EditFood();
            fef.pass += new Form_EditFood.MyDele(ShowDGVFood);
            fef.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form_EditFood fef = new Form_EditFood();
            if (dgvFood.SelectedRows.Count > 0)
            {
                fef.cbbCategory.Text = dgvFood.SelectedRows[0].Cells["NameCategory"].Value.ToString();
                fef.cbbCategory.Enabled = false;
                fef.txtID_Food.Enabled = false;
                fef.txtID_Food.Text = dgvFood.SelectedRows[0].Cells["ID_Food"].Value.ToString();
                fef.txtNameFood.Text = dgvFood.SelectedRows[0].Cells["NameFood"].Value.ToString();
                fef.txtPrice.Text = dgvFood.SelectedRows[0].Cells["Price"].Value.ToString();
                fef.lbStatus.Visible = true;
                fef.rbtnCon.Visible = true;
                fef.rbtnHet.Visible = true;
                fef.Show();
            }
            else
            {
                MessageBox.Show("Chưa chọn món để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fef.pass += new Form_EditFood.MyDele(ShowDGVFood);
        }
        private void btnExpand_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = true;
            btnExpand.Visible = false;
            btnCollapse.Visible = true;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = false;
            btnExpand.Visible = true;
            btnCollapse.Visible = false;
        }
    }


}

