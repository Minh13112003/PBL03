using PBL03.Thungan.Thungan_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03.Thungan.Thungan_BLL
{
    internal class Cashier_BLL
    {

        private static Cashier_BLL _Instance;
        public static Cashier_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Cashier_BLL();
                }
                return _Instance;
            }
        }

        // Thao tác tài khoản
        public void ChangePassword(string Id, string newpass)
        {
            Cashier_DAL.Instance.ChangePassword(Id, newpass);
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

        //Thao tác Form_Menu

        public dynamic getFoodInfor()
        {
            return Cashier_DAL.Instance.getFoodInfor();
        }

        public dynamic getDrinkInfor()
        {
            return Cashier_DAL.Instance.getDrinkInfor();
        }

        public dynamic getCreamInfor()
        {
            return Cashier_DAL.Instance.getCreamsInfor();
        }
        // Đặt món ăn

        public dynamic getFoodbyBooking()
        {
            return Cashier_DAL.Instance.getFoodbyBooking();
        }

        public dynamic getDrinkbyBooking()
        {
            return Cashier_DAL.Instance.getDrinkbyBooking();
        }

        public dynamic getCreamsbyBooking()
        {
            return Cashier_DAL.Instance.getCreamsbyBooking();
        }

        public void OrderMeal(int count, string idfood, int quantity, string idtable)
        {
            Cashier_DAL.Instance.OrderMeal(count, idfood, quantity, idtable);
        }

        public void subQuantityFood(string food, int quantity)
        {
            Cashier_DAL.Instance.subQuantityFood(food, quantity);
        }

        public void UpdateMeal(string tb, int qtt, string food)
        {
            Cashier_DAL.Instance.UpdateMeal(tb, qtt, food);
        }

        public dynamic ShowOrder(string tb)
        {
            return Cashier_DAL.Instance.ShowOrder(tb);
        }

        public int GetNumberOfCustomer(string tb)
        {
            return Cashier_DAL.Instance.GetNumberOfCustomers(tb);
        }

        public string GetIdFood(string Name)
        {
            return Cashier_DAL.Instance.getIDFood(Name);
        }

        public void RemoveOrder(string tb)
        {
            Cashier_DAL.Instance.RemoveOrder(tb);
        }

        public dynamic GetFoodBySearch(string name)
        {
            return Cashier_DAL.Instance.GetFoodBySearch(name);
        }

        public int CountOrder(string tb)
        {
            return Cashier_DAL.Instance.countOrder(tb);
        }

        public bool CheckExistFood(string id)
        {
            return Cashier_DAL.Instance.CheckExistedFood(id);
        }

        // Xuất Bill

        public void AddBill(DateTime timein,string id, string tb, float subtotal)
        {
            Cashier_DAL.Instance.AddBill(timein, id, tb, subtotal);
        }

        public void UpdateBill(DateTime timein,string id, string tb, float subtotal)
        {
            Cashier_DAL.Instance.UpdateBill(timein, id, tb, subtotal);
        }

        public void PayBill(DateTime dt, string tb)
        {
            Cashier_DAL.Instance.PayBill(dt, tb);
        }

        public string GetIdDiscount(int people)
        {
            return Cashier_DAL.Instance.GetIDDiscount(people);
        }

        public void AddBillHistoryWithoutDC(string tb, DateTime dt, float subtotal, float paidbyCustomer, string discount, float change, int people)
        {
            Cashier_DAL.Instance.AddBillHistoryWithoutDC(tb, dt, subtotal, paidbyCustomer, discount, change, people);
        }

        public void AddBillHistoryWithDC(string tb, DateTime dt, float subtotal, float paidbyCustomer, float change, int people)
        {
            Cashier_DAL.Instance.AddBillHistoryWithDC(tb, dt, subtotal, paidbyCustomer, change, people);
        }

        public string GetIdEmployee(string name)
        {
            return Cashier_DAL.Instance.GetIdEmployee(name);
        }

        public dynamic MakeBill(string idfood)
        {
            return Cashier_DAL.Instance.MakeBill(idfood);
        }

        public dynamic ShowBill(string NameFood)
        {
            return Cashier_DAL.Instance.ShowBill(NameFood);
        }
        // Xem thông tin cá nhân 

        public dynamic ShowInforEmployees(string UserName, int type)
        {
            return Cashier_DAL.Instance.ShowInforEmployees(UserName, type);
        }

        // Tính thời gian vào, ra của hóa đơn

        public dynamic TakeTimeInorOut(string NameTable, int type)
        {
            return Cashier_DAL.Instance.TakeTimeInorOut(NameTable, type);
        }

        // xem lịch làm
        public dynamic ShowSchedule()
        {
            return Cashier_DAL.Instance.ShowSchedule_DAL();
        }
        public dynamic SearchSchedule(string name, string shift)
        {
            return Cashier_DAL.Instance.SearchSchedule(name, shift);
        }
        public dynamic ShowAllScheduleOfEPL(string name)
        {
            return Cashier_DAL.Instance.ShowAllScheduleOfEPL(name);
        }
        //public void GetScheduleFollowEPL(string epl, RichTextBox rtb)
        //{
        //    Cashier_DAL.Instance.GetScheduleFollowEPL(epl, rtb);
        //}
        public List<string> GetScheduleFollowEPL(string epl)
        {
            return Cashier_DAL.Instance.GetScheduleFollowEPL(epl);
        }
        public string GetIDEmployee(string acc)
        {
            return Cashier_DAL.Instance.GetIDEmployee(acc);
        }
        public void AddSchedule(int id, string idepl, int idshift, DateTime dt, string note)
        {
            Cashier_DAL.Instance.AddSchedule(id, idepl, idshift, dt, note);
        }
        public void EditSchedule(int id, string idepl, int idshift, DateTime dt, string note)
        {
            Cashier_DAL.Instance.EditSchedule(id, idepl, idshift, dt, note);
        }
        public void DeleteSchedule(int id)
        {
            Cashier_DAL.Instance.DeleteSchedule(id);
        }
        public List<ShiftWork> GetAllShift()
        {
            return Cashier_DAL.Instance.GetAllShift();
        }
        public string GetIDEmployeeByName(string name)
        {
            return Cashier_DAL.Instance.GetIDEmployeeByName(name);
        }
        public int GetIDShift(string name)
        {
            return Cashier_DAL.Instance.GetIDShift(name);
        }

        //Lưu hóa đơn vào database

        public void AddOrUpdateRevenue(string id, float total, int customer)
        {
            Cashier_DAL.Instance.AddOrUpdateRevenue(id, total, customer);
        }

        public string CountRowInRevenue()
        {
            return Cashier_DAL.Instance.CountRowInRevenue();
        }
    }
}


