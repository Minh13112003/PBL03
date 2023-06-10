using Guna.UI2.WinForms;
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
using PBL03.Thungan.Thungan_BLL;
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
            //MenuFood_BLL bll = new MenuFood_BLL();
            //bll.getFoodInfor(flowLayout_Show);
            ShowFoodInfor();
        }

        private void btn_Drink_Click(object sender, EventArgs e)
        {
            flowLayout_Show.Controls.Clear();
            pnStas.Width = btn_Drink.Width;
            pnStas.Left = btn_Drink.Left;
            //MenuFood_BLL bll = new MenuFood_BLL();
            //bll.getDrinkInfor(flowLayout_Show);
            ShowDrinkInfor();
        }

        private void btn_Creams_Click(object sender, EventArgs e)
        {
            flowLayout_Show.Controls.Clear();
            pnStas.Width = btn_Creams.Width;
            pnStas.Left = btn_Creams.Left;
            MenuFood_BLL bll = new MenuFood_BLL();
            bll.getCreamsInfor(flowLayout_Show);
        }

        private void ShowFoodInfor()
        {
            
            int stt = 0;
            foreach (var food in Cashier_BLL.Instance.getFoodInfor())
            {
                UserControl_Menu uf = new UserControl_Menu();

                // Truyền giá trị cho các label của user control
                uf.STT.Text = (++stt).ToString();
                uf.Soluong.Text = food.QuantityFood.ToString();
                uf.Name_Food.Text = food.NameFood.ToString();
                uf.Price.Text = food.Price.ToString() + " VND";



                // Thêm user control vào FlowLayoutPanel
                flowLayout_Show.Controls.Add(uf);
            }
        }

        private void ShowDrinkInfor()
        {
            int stt = 0;
            foreach(var drink in Cashier_BLL.Instance.getDrinkInfor())
            {
                // Tạo một đối tượng UserControl_Menu mới
                UserControl_Menu uf = new UserControl_Menu();

                // Truyền giá trị cho các label của user control
                uf.STT.Text = (++stt).ToString();
                uf.Soluong.Text = drink.QuantityFood.ToString();
                uf.Name_Food.Text = drink.NameFood.ToString();
                uf.Price.Text = drink.Price.ToString() + " VND";



                // Thêm user control vào FlowLayoutPanel
                flowLayout_Show.Controls.Add(uf);
            }
        }

        private void ShowCreamInfor()
        {
            int stt = 0;
            foreach(var cream in Cashier_BLL.Instance.getCreamInfor())
            {
                // Tạo một đối tượng UserControl_Menu mới
                UserControl_Menu uf = new UserControl_Menu();

                // Truyền giá trị cho các label của user control
                uf.STT.Text = (++stt).ToString();
                uf.Soluong.Text = cream.QuantityFood.ToString();
                uf.Name_Food.Text = cream.NameFood.ToString();
                uf.Price.Text = cream.Price.ToString() + " VND";



                // Thêm user control vào FlowLayoutPanel
                flowLayout_Show.Controls.Add(uf);
            }
        }
    }
}
