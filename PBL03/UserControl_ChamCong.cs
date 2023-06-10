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
    public partial class UserControl_ChamCong : UserControl
    {
        public UserControl_ChamCong()
        {
            InitializeComponent();
            this.AutoScroll = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        private void btnPayWage_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận hoàn tất thanh toán lương", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                string id = this.lbID.Text;
                string idEmployee = id.Substring(id.IndexOf(':') + 2);
                MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Manager_BLL.Instance.DeleteWorkDayOfEmployee_BLL(idEmployee);
            }
        }
    }
}
