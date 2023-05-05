using Guna.UI2.WinForms;
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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void btn_Food_Click(object sender, EventArgs e)
        {
            flowLayout_Show.Controls.Clear();
            pnStas.Width = btn_Food.Width;
            pnStas.Left = btn_Food.Left;
            string k = null;
            for (int i = 1; i <= 5; i++)
            {
                if (i % 2 == 0) k = "Còn hàng";
                else k = "Hết hàng";

                UserControl_Menu uf = new UserControl_Menu();
                uf.setLael("" + i, "ID" + i, "Gà", k, "10.000 VND");
                flowLayout_Show.Controls.Add(uf);
            }
        }

        private void btn_Drink_Click(object sender, EventArgs e)
        {
            flowLayout_Show.Controls.Clear();
            pnStas.Width = btn_Drink.Width;
            pnStas.Left = btn_Drink.Left;
            string k = null;
            for (int i = 1; i <= 5; i++)
            {
                if (i % 2 == 0) k = "Còn hàng";
                else k = "Hết hàng";

                UserControl_Menu uf = new UserControl_Menu();
                uf.setLael("" + i, "ID" + i, "Gà", k, "10.000 VND");
                flowLayout_Show.Controls.Add(uf);
            }
        }

        private void btn_Creams_Click(object sender, EventArgs e)
        {
            flowLayout_Show.Controls.Clear();
            pnStas.Width = btn_Creams.Width;
            pnStas.Left = btn_Creams.Left;
            string k = null;
            for (int i = 1; i <= 5; i++)
            {
                if (i % 2 == 0) k = "Còn hàng";
                else k = "Hết hàng";

                UserControl_Menu uf = new UserControl_Menu();
                uf.setLael("" + i, "ID" + i, "Gà", k, "10.000 VND");
                flowLayout_Show.Controls.Add(uf);
            }
        }
    }
}
