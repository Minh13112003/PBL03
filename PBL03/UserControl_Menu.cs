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
    public partial class UserControl_Menu : UserControl
    {
        public UserControl_Menu()
        {
            InitializeComponent();
        }
        public void setLael(string stt, string ID, string name, string status, string price)
        {
            STT.Text = stt;
            ID_Food.Text = ID;
            Name_Food.Text = name;
            Status.Text = status;
            Price.Text = price;
        }
    }
}
