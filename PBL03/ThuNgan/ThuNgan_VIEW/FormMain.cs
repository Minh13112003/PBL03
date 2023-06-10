using PBL03.Thungan.Thungan_VIEW;
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
        private int progress = 0;
        int flag = 0;
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

            //pnShow.Visible = false;
            //ProgressIndicator_Load.Visible = true;
            //CirclePictureBox_GIF.Visible = true;
            //ProgressIndicator_Load.AnimationSpeed = 70;
            //progress = 0;
            //ProgressIndicator_Load.Start();
            //timer1.Start();

            Form_Menu mn = new Form_Menu();
            mn.TopLevel = false;
            pnShow.Controls.Add(mn);
            mn.Size = pnShow.Size;
            mn.Show();
        }

        

        private void btnStatus_Table_Click(object sender, EventArgs e)
        {
            pnStast.Height = btnStatus_Table.Height;
            pnStast.Top = btnStatus_Table.Top;
            pnShow.Controls.Clear();

            //pnShow.Visible = false;
            //ProgressIndicator_Load.Visible = true;
            //CirclePictureBox_GIF.Visible = true;
            //ProgressIndicator_Load.AnimationSpeed = 70;
            //progress = 0;
            //ProgressIndicator_Load.Start();
            //timer1.Start();

            Form_StatusTable fst = new Form_StatusTable();
            fst.TopLevel = false;
            fst.Size = pnShow.Size;
            pnShow.Controls.Add(fst);
            fst.Show();
        }

       

       

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    progress += 1;
        //    if (progress == 20)
        //    {
        //        timer1.Stop();
        //        ProgressIndicator_Load.Visible = false;
        //        CirclePictureBox_GIF.Visible = false;
        //        pnShow.Visible = true;
        //    }
        //}
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            FormLogin flg = (FormLogin)Application.OpenForms["FormLogin"];
            flg.Show();
          
        }

        

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ++flag;
            if (flag % 2 != 0)
                pnSetting.Visible = true;
            else
                pnSetting.Visible = false;
        }

      

        private void btnShowProfile_Click(object sender, EventArgs e)
        {
            pnSetting.Visible = false;
            pnShow.Visible = true;
            pnShow.Controls.Clear();
            FormShowInforEmployee fsie = new FormShowInforEmployee();
            fsie.TopLevel = false;
            fsie.FormBorderStyle = FormBorderStyle.None;
            fsie.Dock = DockStyle.Fill;
            pnShow.Controls.Add(fsie);
            fsie.Size = pnShow.Size;
            fsie.tbAccount.Text = lbNameUser.Text;
            fsie.tbAccount.Enabled = false;
            fsie.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormLogin flg = (FormLogin)Application.OpenForms["FormLogin"];
            flg.tbUsername.Text = string.Empty;
            flg.tbPassword.Text = string.Empty;
            
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            pnSetting.Visible = false;
            pnShow.Visible = true;

            FormChangePass fm = new FormChangePass();
            fm.tbUsername.Text = lbNameUser.Text;
            fm.tbUsername.Enabled = false;

            fm.Show();
        }

        private void btnViewCalendar_Click(object sender, EventArgs e)
        {
            pnStast.Height = btnViewCalendar.Height;
            pnStast.Top = btnViewCalendar.Top;
            pnShow.Controls.Clear();
            Form_ViewSchedule fv = new Form_ViewSchedule();
            fv.TopLevel = false;
            pnShow.Controls.Add(fv);
            fv.Size = pnShow.Size;
            fv.Show();
        }
    }
}
