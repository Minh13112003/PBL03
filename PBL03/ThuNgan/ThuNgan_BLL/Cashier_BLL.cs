using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL03.ThuNgan.ThuNgan_DAL;

namespace PBL03.ThuNgan.ThuNgan_BLL
{
    internal class Cashier_BLL
    {
        private static Cashier_BLL _Instance;
        public static Cashier_BLL Instance
        {
            get
            {
                if( _Instance == null)
                {
                    _Instance = new Cashier_BLL();
                }
                return _Instance;
            }
        }

        public void ChangePassword(string Id,string newpass)
        {
            Cashier_DAL.Instance.ChangePassword(Id,newpass);
        }
        public string getUsername(string name)
        {
            return Cashier_DAL.Instance.getUsername(name);
        }
        public string getName(string user)
        {
            return Cashier_DAL.Instance.getName(user);
        }

        public string getPassword(string user)
        {
            return Cashier_DAL.Instance.getPassword(user);
        }
    }
}
