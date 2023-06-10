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
    public partial class UserControl_Order : UserControl
    {
        public UserControl_Order()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form_Order f1 = (Form_Order)Application.OpenForms["Form_Order"];
            f1.flowLayout_Order.Controls.Remove(this);
            foreach (UserControl_Food uf in f1.flowLayout_Food.Controls)
            {
                if (uf.lbFood.Text == lbFood.Text)
                {
                    uf.btnSelect.Visible = false;
                }
            }
        }
    }
}
