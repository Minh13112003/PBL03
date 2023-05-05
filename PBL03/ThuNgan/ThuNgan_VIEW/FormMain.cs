using PBL03.ThuNgan.ThuNgan_BLL;
using PBL03.ThuNgan.ThuNgan_VIEW;
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
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
            this.AutoScroll = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnStast.Height = btnMenu.Height;
            pnStast.Top = btnMenu.Top;
            pnShow.Controls.Clear();
            Form_Menu mn = new Form_Menu();
            mn.TopLevel = false;
            pnShow.Controls.Add(mn);
            mn.Size = pnShow.Size;
            mn.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            pnStast.Height = btnQLNV.Height;
            pnStast.Top = btnQLNV.Top;
            pnShow.Controls.Clear();
            Form_MEmployee me = new Form_MEmployee();
            me.TopLevel = false;
            pnShow.Controls.Add(me);
            me.Size = pnShow.Size;
            me.Show();
        }

        private void btnStatus_Table_Click(object sender, EventArgs e)
        {
            pnStast.Height = btnStatus_Table.Height;
            pnStast.Top = btnStatus_Table.Top;
            pnShow.Controls.Clear();
            Form_StatusTable fst = new Form_StatusTable();
            fst.TopLevel = false;
            fst.Size = pnShow.Size;
            pnShow.Controls.Add(fst);
            fst.Show();
        }

        private void btChangepass_Click(object sender, EventArgs e)
        {
            pnStast.Height = btnStatus_Table.Height;
            pnStast.Top = btnStatus_Table.Top;
            pnShow.Controls.Clear();
            
            FormChangePass fm = new FormChangePass();
            fm.tbUser.Text = lbNameUser.Text;
            fm.TopLevel = false;
            fm.Size = pnShow.Size;
            pnShow.Controls.Add(fm);
            fm.Show();
          
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
    }
}
