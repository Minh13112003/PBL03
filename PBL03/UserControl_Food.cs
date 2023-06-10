using PBL03.BLL;
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
    public partial class UserControl_Food : UserControl
    {
        private OrderFood_BLL bll;
        public UserControl_Food()
        {
            InitializeComponent();
            bll = new OrderFood_BLL();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (btnSelect.Visible == true)
            {
                btnSelect.Visible = false;
            }
            else
            {
                btnSelect.Visible = true;
            }
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            if (btnSelect.Visible == false)
            { 
                btnSelect.Visible = true;
                Form_Order f1 = (Form_Order)Application.OpenForms["Form_Order"];
                //if (f1.flowLayout_Order.Controls.Count >= 0)
                //{
                //    UserControl_Order uo = new UserControl_Order();
                //    uo.lbFood.Text = lbFood.Text;
                //    uo.lbNameTable.Text = f1.lbTable.Text;
                //    uo.lbPrice.Text = lbPrice.Text;
                //    uo.numericquantity.Value = 1;
                //    f1.flowLayout_Order.Controls.Add(uo);
                //}

                //else
                //{
                //    foreach (UserControl_Order order in f1.flowLayout_Order.Controls)
                //    {
                //        if (order.lbFood.Text == lbFood.Text)
                //        {
                //            order.numericquantity.Value++;
                //        }
                           
                //    }
                //}
                bool isAdded = false;
                foreach (UserControl_Order uo in f1.flowLayout_Order.Controls)
                {
                    if (uo.lbFood.Text == lbFood.Text)
                    {
                        uo.numericquantity.Value++;
                        isAdded = true;
                        break;
                    }    
                }    
                if (!isAdded)
                {
                    UserControl_Order uo = new UserControl_Order();
                    uo.lbFood.Text = lbFood.Text;
                    uo.lbNameTable.Text = f1.lbTable.Text;
                    uo.lbPrice.Text = lbPrice.Text;
                    uo.numericquantity.Value = 1;
                    f1.flowLayout_Order.Controls.Add(uo);
                }    
            }
        }
    }
}
