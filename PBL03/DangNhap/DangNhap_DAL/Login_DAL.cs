using PBL03.ThuNgan.ThuNgan_VIEW;
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
        private PBL03Entities db;
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
            db = new PBL03Entities();
        }
        public void dangnhap(string Username,string Password)
        {
            /*using (var context = new PBL03Entities())
            {
                var user1 = context.Accounts.FirstOrDefault(u => u.Username == Username && u.NameType == "quanly");
                var uses2 = context.Accounts.FirstOrDefault(u => u.Username == Username && u.NameType == "thungan");
                if (user1 == null && uses2 == null)
                {
                    MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu");
                }
                else
                {
                    string hashedPassword = user1 != null ? user1.PW : uses2.PW;
                    if (BCrypt.Net.BCrypt.Verify(Password, hashedPassword))
                    {

                        if (user1 != null)
                        {
                            Form_Admin fad = new Form_Admin();
                            fad.Show();
                        }
                        else
                        {
                            FormMain ftn = new FormMain();
                            ftn.Show();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu");
                    }
                }
            }*/

                var user1 = db.Accounts.FirstOrDefault(u => u.Username == Username && u.NameType == "quanly");
                var uses2 = db.Accounts.FirstOrDefault(u => u.Username == Username && u.NameType == "thungan");
                if (user1 == null && uses2 == null)
                {
                    MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu");
                }
                else
                {
                    string hashedPassword = user1 != null ? user1.PW : uses2.PW;
                    if (BCrypt.Net.BCrypt.Verify(Password, hashedPassword))
                    {

                        if (user1 != null)
                        {
                            Form_Admin fad = new Form_Admin();
                            fad.Show();
                        }
                        else
                        {
                            FormMain ftn = new FormMain();
                            ftn.lbNameUser.Text = Username;
                            ftn.Show();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu");
                    }
            }
        }
        public bool CheckInfor(string user, string name, string phonenumber, string address)
        {
            var query = db.Employees.FirstOrDefault(u => u.Acc == user && u.Name_Employee == name && u.PhoneNumber == phonenumber && u.Address_Employee == address);
            if (query == null) return false;
            else return true;
        }
            
        public void ChangePass(string Account,string newpass)
        {
            var query = db.Accounts.FirstOrDefault(u => u.Username == Account);
            query.PW = newpass;
            db.SaveChanges();
        }
    
    }

   
}
