using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL03.Thungan.Thungan_BLL;

namespace PBL03.Thungan.Thungan_VIEW
{
    public partial class FormShowInforEmployee : Form
    {
        public FormShowInforEmployee()
        {
            InitializeComponent();
        }

        private void FormShowInforEmployee_Load(object sender, EventArgs e)
        {
            tbID.Text = Cashier_BLL.Instance.ShowInforEmployees(tbAccount.Text, 0);
            tbName.Text = Cashier_BLL.Instance.ShowInforEmployees(tbAccount.Text, 1);
            tbPhone.Text = Cashier_BLL.Instance.ShowInforEmployees(tbAccount.Text, 2);
            tbAddress.Text = Cashier_BLL.Instance.ShowInforEmployees(tbAccount.Text, 3);
            float a = Cashier_BLL.Instance.ShowInforEmployees(tbAccount.Text, 4);
            tbSalary.Text = a.ToString();
        }
    }
}
