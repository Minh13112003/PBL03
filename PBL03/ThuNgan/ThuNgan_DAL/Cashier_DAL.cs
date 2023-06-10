using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03.Thungan.Thungan_DAL
{
    internal class Cashier_DAL
    {
        PBL3Entities1 db;
        private static Cashier_DAL _Instance;
        public static Cashier_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Cashier_DAL();
                }
                return _Instance;
            }
        }

        public Cashier_DAL()
        {
            db = new PBL3Entities1();
        }

        // Change PassWord
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
            var query = db.Accounts.FirstOrDefault(p => p.Username == name);
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

        //MenuFood

        public dynamic getFoodInfor()
        {

            var data = db.Foods.Where(p => p.IDCategory == "FD").Select(p => new
            {
                p.NameFood,
                p.QuantityFood,
                p.Price
            }).ToList();
            return data;
        }

        public dynamic getDrinkInfor()
        {
            var data = db.Foods.Where(p => p.IDCategory == "DR").Select(p => new
            {
                p.NameFood,
                p.QuantityFood,
                p.Price
            }).ToList();
            return data;
        }

        public dynamic getCreamsInfor()
        {
            var data = db.Foods.Where(p => p.IDCategory == "CR").Select(p => new
            {
                p.NameFood,
                p.QuantityFood,
                p.Price
            }).ToList();
            return data;
        }

        //Đặt món ăn

        public dynamic getFoodbyBooking()
        {
            var data = db.Foods.Where(p => p.IDCategory == "FD").Select(p => new
            {
                p.NameFood,
                p.Price,
                p.PictureFood,
                p.QuantityFood
            }).ToList();
            return data;
        }

        public dynamic getDrinkbyBooking()
        {
            var data = db.Foods.Where(p => p.IDCategory == "DR").Select(p => new
            {
                p.NameFood,
                p.Price,
                p.PictureFood,
                p.QuantityFood
            }).ToList();
            return data;
        }

        public dynamic getCreamsbyBooking()
        {
            var data = db.Foods.Where(p => p.IDCategory == "CR").Select(p => new
            {
                p.NameFood,
                p.Price,
                p.PictureFood,
                p.QuantityFood
            }).ToList();
            return data;
        }

        public string getIDFood(string name)
        {
            var query = db.Foods.FirstOrDefault(p => p.NameFood == name);
            if (query != null)
            {
                return query.ID_Food;
            }
            return null;
        }

        public void OrderMeal(int count, string idfood, int quantity, string idtable)
        {
            OrderTable temp = new OrderTable
            {
                ID_Order = idtable + count,
                IDFood = idfood,
                Quantity = quantity,
                IDTable = idtable
            };
            db.OrderTables.Add(temp);
            db.SaveChanges();
        }

        public void subQuantityFood(string food, int quantity)
        {
            var fd = db.Foods.Find(getIDFood(food));
            fd.QuantityFood -= quantity;
            db.SaveChanges();
        }

        public bool CheckExistedFood(string idfood)
        {

            var fd = db.OrderTables.Where(p => p.IDFood == idfood).FirstOrDefault();
            if (fd != null)
            {
                return true;
            }
            return false;
        }

        public int countOrder(string tb)
        {
            return db.OrderTables.Where(p => p.IDTable == tb).Count();
        }

        public void UpdateMeal(string tb, int qtt, string food)
        {
            string id = getIDFood(food);
            var order = db.OrderTables.Where(p => p.IDTable == tb && p.IDFood == id).FirstOrDefault();
            var fd = db.Foods.Find(getIDFood(food));
            int add = qtt - order.Quantity;
            order.Quantity = qtt;
            fd.QuantityFood -= add;
            db.SaveChanges();
        }

        public dynamic ShowOrder(string tb)
        {
            var query = db.OrderTables
                .Join(db.Foods, p => p.IDFood, c => c.ID_Food, (p, c) => new { OrderTable = p, Food = c })
                .Where(x => x.OrderTable.IDTable == tb)
                .Select(x => new
                {
                    x.OrderTable.ID_Order,
                    x.Food.NameFood,
                    x.OrderTable.Quantity,
                    x.OrderTable.IDTable,
                    x.Food.Price
                }).ToList();
            return query;
        }



        public int GetNumberOfCustomers(string tb)
        {
            var query = db.TableFoods.FirstOrDefault(p => p.ID_Table == tb);
            return query.Capacity;

        }

        public void RemoveOrder(string tb)
        {

            var order = db.OrderTables.Where(p => p.IDTable == tb);
            db.OrderTables.RemoveRange(order);
            db.SaveChanges();

        }

        public dynamic GetFoodBySearch(string name)
        {

            var data = db.Foods.Where(p => p.IDCategory == "FD" && p.NameFood.Contains(name)).Select(p => new
            {
                p.NameFood,
                p.Price,
                p.PictureFood
            }).ToList();
            return data;
        }

        //Tính Bill

        public void AddBill(DateTime timein, string id, string tb, float subtotal)
        {
            Bill temp = new Bill
            {
                TimeCheckIn = timein,
                TimeCheckOut = timein,
                idEmployee = id,
                idTable = tb,
                TotalMoney = subtotal,
                statusBill = false
            };
            db.Bills.Add(temp);
            db.SaveChanges();

        }
        public void UpdateBill(DateTime timein, string id, string tb, float subtotal)
        {
            var query = db.Bills.Where(p => p.idTable == tb).FirstOrDefault();
            if (query != null)
            {
                var bill = db.Bills.Single(p => p.idTable == tb && p.statusBill == false);
                bill.TotalMoney = subtotal;
            }
            else
            {
                Bill temp = new Bill
                {
                    TimeCheckIn = timein,
                    TimeCheckOut = timein,
                    idEmployee = id,
                    idTable = tb,
                    TotalMoney = subtotal,
                    statusBill = false
                };
                db.Bills.Add(temp);
            }
            db.SaveChanges();

        }
        public int GetIDBill(string tb)
        {
            var idbill = db.Bills.Single(p => p.idTable == tb && p.statusBill == false);
            return idbill.ID_Bill;

        }
        public void PayBill(DateTime dt, string tb)
        {
            var bill = db.Bills.Single(p => p.idTable == tb && p.statusBill == false);
            bill.statusBill = true;
            bill.TimeCheckOut = dt;
            db.SaveChanges();

        }
        public string GetIDDiscount(int people)
        {
            if (people < 5)
            {
                return db.Discounts.Where(p => p.NameDiscount == "Dưới 5 khách").Select(p => p.ID_Discount).FirstOrDefault();
            }
            else if (people >= 5 && people <= 10)
            {
                return db.Discounts.Where(p => p.NameDiscount == "5-10 khách").Select(p => p.ID_Discount).FirstOrDefault();
            }
            else
            {
                return db.Discounts.Where(p => p.NameDiscount == "Trên 10 khách").Select(p => p.ID_Discount).FirstOrDefault();
            }
        }
        public void AddBillHistoryWithoutDC(string tb, DateTime dt, float subtotal, float paidbyCustomer, string discount, float change, int people)
        {

            int id = GetIDBill(tb);
            BillHistory bill = new BillHistory
            {
                IDBill = id,
                DatePay = dt,
                TotalMoney = subtotal,
                MoneyCustomerPay = paidbyCustomer,
                IDDiscount = discount,
                Exchange = change
            };
            db.BillHistories.Add(bill);
            db.SaveChanges();

        }
        public void AddBillHistoryWithDC(string tb, DateTime dt, float subtotal, float paidbyCustomer, float change, int people)
        {

            int id = GetIDBill(tb);
            string discount = GetIDDiscount(people);
            BillHistory bill = new BillHistory
            {
                IDBill = id,
                DatePay = dt,
                TotalMoney = subtotal,
                MoneyCustomerPay = paidbyCustomer,
                IDDiscount = discount,
                Exchange = change
            };
            db.BillHistories.Add(bill);
            db.SaveChanges();

        }

        public string GetIdEmployee(string name)
        {
            var query = db.Employees.FirstOrDefault(p => p.Acc == name);
            if (query != null)
            {
                return query.ID_Employee;
            }
            return null;
        }

        public dynamic MakeBill(string idfood)
        {
            var query = db.Foods.Where(p => p.ID_Food == idfood).Select(p => new
            {
                p.NameFood,
                p.Price
            }).ToList();
            return query;

        }

        public dynamic ShowBill(string NameFood)
        {
            var query = db.OrderTables
               .Join(db.Foods, p => p.IDFood, c => c.ID_Food, (p, c) => new { OrderTable = p, Food = c })
               .Where(x => x.Food.NameFood == NameFood)
               .Select(x => new
               {                 
                   x.Food.NameFood,
                   x.OrderTable.Quantity,
                   x.Food.Price
               }).ToList();
            return query;
        }

        // Xem thông tin cá nhân 

        public dynamic ShowInforEmployees(string UserName,int type)
        {
            var query = db.Employees.Where(p => p.Acc == UserName).FirstOrDefault();
            if (type == 0) return query.ID_Employee;
            if (type == 1) return query.Name_Employee;
            if (type == 2) return query.PhoneNumber;
            if (type == 3) return query.Address_Employee;
            if (type == 4) return query.Salary;
            else return 0;
        }

        // Tính thời gian vào, ra của hóa đơn

        public dynamic TakeTimeInorOut(string NameTable,int type)
        {
            var query = db.Bills.Where(p => p.idTable == NameTable).ToList().LastOrDefault();
            if (type == 0) return query.TimeCheckIn;
            if (type == 1) return query.TimeCheckOut;
            else return 0;
        }

        //Xem lịch làm việc 
        public dynamic ShowSchedule_DAL()
        {
            var query = db.WorkSchedules
                .Join(db.Employees, p => p.IDEmployee, c => c.ID_Employee, (p, c) => new { WorkSchedule = p, Employee = c })
                .Select(x => new
                {
                    x.WorkSchedule.ID_Schedule,
                    x.Employee.Name_Employee,
                    x.WorkSchedule.ShiftWork.NameShift,
                    x.WorkSchedule.DateWork,
                    x.WorkSchedule.Note
                })
                .ToList();
            return query;
        }
        public dynamic SearchSchedule(string name, string shift)
        {
            var query = db.WorkSchedules
                .Join(db.Employees, p => p.IDEmployee, c => c.ID_Employee, (p, c) => new { WorkSchedule = p, Employee = c })
                .Where(x => x.Employee.Name_Employee.Contains(name) && x.WorkSchedule.ShiftWork.NameShift == shift)
                .Select(x => new
                {
                    x.WorkSchedule.ID_Schedule,
                    x.Employee.Name_Employee,
                    x.WorkSchedule.ShiftWork.NameShift,
                    x.WorkSchedule.DateWork,
                    x.WorkSchedule.Note
                })
                .ToList();
            return query;
        }
        public dynamic ShowAllScheduleOfEPL(string name)
        {
            var query = db.WorkSchedules
                .Join(db.Employees, p => p.IDEmployee, c => c.ID_Employee, (p, c) => new { WorkSchedule = p, Employee = c })
                .Where(x => x.Employee.Name_Employee == name)
                .Select(x => new
                {
                    x.WorkSchedule.ID_Schedule,
                    x.Employee.Name_Employee,
                    x.WorkSchedule.ShiftWork.NameShift,
                    x.WorkSchedule.DateWork,
                    x.WorkSchedule.Note
                })
                .ToList();
            return query;
        }
        //public void GetScheduleFollowEPL(string epl, RichTextBox rtb)
        //{
        //    var query = db.WorkSchedules
        //        .Join(db.ShiftWorks, p => p.IDShift, c => c.ID_Shift, (p, c) => new { WorkSchedule = p, ShiftWork = c })
        //        .Where(x => x.WorkSchedule.IDEmployee == epl)
        //        .Select(x => new
        //        {
        //            x.WorkSchedule.IDEmployee,
        //            x.ShiftWork.NameShift,
        //            x.WorkSchedule.DateWork,
        //            x.WorkSchedule.Note,
        //        })
        //        .ToList();
        //    if (query.Any())
        //    {
        //        foreach (var item in query)
        //        {
        //            rtb.AppendText(" - " + item.NameShift.PadRight(10) + item.DateWork.ToShortDateString() + " - " + item.Note + "\n");
        //        }
        //    }
        //    else
        //    {
        //        rtb.Text = "Hôm nay không có lịch làm việc";
        //    }
        //}
        public List<string> GetScheduleFollowEPL(string epl)
        {
            List<string> list = new List<string>();
            var query = db.WorkSchedules
                .Join(db.ShiftWorks, p => p.IDShift, c => c.ID_Shift, (p, c) => new { WorkSchedule = p, ShiftWork = c })
                .Where(x => x.WorkSchedule.IDEmployee == epl)
                .Select(x => new
                {
                    x.WorkSchedule.IDEmployee,
                    x.ShiftWork.NameShift,
                    x.WorkSchedule.DateWork,
                    x.WorkSchedule.Note,
                })
                .ToList();
            foreach (var i in query)
            {
                list.Add(" - " + i.NameShift + ", " + i.DateWork.ToString("dd/MM/yyyy") + ", " + i.Note + "\n");
            }
            return list;
        }
        public string GetIDEmployee(string acc)
        {
            var query = db.Employees.FirstOrDefault(p => p.Acc == acc);
            return query.ID_Employee;
        }
        public void AddSchedule(int id, string idepl, int idshift, DateTime dt, string note)
        {
            WorkSchedule temp = new WorkSchedule
            {
                ID_Schedule = id,
                IDEmployee = idepl,
                IDShift = idshift,
                DateWork = dt,
                Note = note
            };
            db.WorkSchedules.Add(temp);
            db.SaveChanges();
        }
        public void EditSchedule(int id, string idepl, int idshift, DateTime dt, string note)
        {
            var query = db.WorkSchedules.Find(id);
            query.IDEmployee = idepl;
            query.IDShift = idshift;
            query.DateWork = dt;
            query.Note = note;
            db.SaveChanges();
        }
        public void DeleteSchedule(int id)
        {
            var query = db.WorkSchedules.FirstOrDefault(p => p.ID_Schedule == id);
            db.WorkSchedules.Remove(query);
            db.SaveChanges();
        }
        public List<ShiftWork> GetAllShift()
        {
            var query = db.ShiftWorks.ToList();
            return query;
        }
        public string GetIDEmployeeByName(string name)
        {
            var query = db.Employees.FirstOrDefault(p => p.Name_Employee == name);
            return query.ID_Employee;
        }
        public int GetIDShift(string name)
        {
            var query = db.ShiftWorks.FirstOrDefault(p => p.NameShift == name);
            return query.ID_Shift;
        }

        // Lưu lịch sử hóa đơn vào database

        public void AddOrUpdateRevenue(string id, float total, int customer)
        {

            DateTime dt = DateTime.Today;
            //var query = db.Revenues.Where(p => p.RevenueInDate.Day == day && p.RevenueInDate.Month == month && p.RevenueInDate.Year == year)
            //    .FirstOrDefault();
            var date = db.Revenues.FirstOrDefault(p => p.RevenueInDate == dt);
            if (date != null)
            {
                date.TotalInDate += total;
                date.NumberOfBill += 1;
                date.NumberOfCustomer += customer;
                db.SaveChanges();
            }
            else
            {
                var row = new Revenue
                {
                    ID_Revenue = id,
                    RevenueInDate = dt,
                    TotalInDate = total,
                    NumberOfBill = 1,
                    NumberOfCustomer = customer,
                };
                db.Revenues.Add(row);
                db.SaveChanges();

            }
        }

        public string CountRowInRevenue()
        {

            int count = db.Revenues.Count();
            count++;
            return count.ToString();

        }
    }
    

}      

