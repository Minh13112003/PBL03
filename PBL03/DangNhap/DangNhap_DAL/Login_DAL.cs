using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03.DangNhap.DangNhap_DAL
{
    internal class Login_DAL
    {
        private PBL3Entities1 db;
        private static Login_DAL _Instance;
        public static Login_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Login_DAL();
                return _Instance;
            }
        }

        private Login_DAL()
        {
            db = new PBL3Entities1();
        }
        

        public bool CheckQuanLy(string UserName,string PassWord)
        {
            var user1 = db.Accounts.FirstOrDefault(u => u.Username.Equals(UserName) && u.NameType == "quanly");
            if (user1 == null) return false;
            else {
                if (BCrypt.Net.BCrypt.Verify(PassWord, user1.PW) == true) return true;
                else return false;
            }
            
        }

        public bool CheckThuNgan(string UserName, string PassWord)
        {
            var user1 = db.Accounts.FirstOrDefault(u => u.Username.Equals(UserName) && u.NameType == "thungan");
            if (user1 == null) return false;
            else
            {
                if (BCrypt.Net.BCrypt.Verify(PassWord, user1.PW) == true) return true;
                else return false;
            }

        }

        public bool CheckInfor(string user, string name, string phonenumber, string address)
        {
            var query = db.Employees.FirstOrDefault(u => u.Acc == user && u.Name_Employee == name && u.PhoneNumber == phonenumber && u.Address_Employee == address);
            if (query == null) return false;
            else return true;
        }

        public void ChangePass(string Account, string newpass)
        {
            var query = db.Accounts.FirstOrDefault(u => u.Username == Account);
            query.PW = newpass;
            db.SaveChanges();
        }
    }
}
