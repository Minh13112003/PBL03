using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL03.ThuNgan.ThuNgan_DAL
{
    internal class Cashier_DAL
    {
        PBL03Entities db;
        private static Cashier_DAL _Instance;
        public static Cashier_DAL Instance
        {
            get
            {
                if(_Instance== null)
                {
                    _Instance = new Cashier_DAL();
                }
                return _Instance;
            }
        }

        public Cashier_DAL()
        {
            db = new PBL03Entities();
        }

        public void ChangePassword(string User, string newpass)
        {
            
            var query = db.Accounts.Find(User);
            query.PW = newpass;
            db.SaveChanges();
        }

        public string getPassword(string User)
        {
            var query = db.Accounts.Find(User);
            if (query != null)
            {
                return query.PW;
            }
            return null;
        }
        public string getUsername(string name)
        {
            var query = db.Accounts.FirstOrDefault(p=>p.Username == name);
            if (query != null) { return query.Username; }
            return null;
        }
        public string getName(string user)
        {
            var query = db.Employees.Where(p => p.Acc == user).FirstOrDefault();
            if (query != null)
            {
                return query.Name_Employee;
            }
            return null;
        }
    }
}
