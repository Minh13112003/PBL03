using PBL03.Quanly.Quanly_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL03.Quanly.Quanly_BLL
{
    internal class Manager_BLL
    {
        private static Manager_BLL db;
        public static Manager_BLL Instance
        {
            get
            {
                if (db == null)
                {
                    db = new Manager_BLL();
                }

                return db;
            }
        }

        public dynamic Show()
        {
            return Manager_DAL.Instance.Show();
        }

        public void Add(string Id, string name, string phone, string address, float salary, string Username, string Password)
        {
            Manager_DAL.Instance.add(Id, name, phone, address, salary, Username, Password);
        }
        public bool CheckExistedIDEmployee(string id)
        {
            return Manager_DAL.Instance.CheckExistedIDEmployee(id);
        }
        public bool CheckExistedUsername(string username)
        {
            return Manager_DAL.Instance.CheckExistedUsername(username);
        }
        public void Edit(string Id, string Name, string PhoneNumber, string Address, float Salary, string User)
        {
            Manager_DAL.Instance.Edit(Id, Name, PhoneNumber, Address, Salary, User);
        }

        public void Delete(string id, string User)
        {
            Manager_DAL.Instance.Delete(id, User);
        }

        //public List<CBBItem> GetAllIDEmployee()
        //{
        //    List<CBBItem> list = new List<CBBItem>();
        //    int count = 0;
        //    foreach (var item in Manager_DAL.Instance.GetAllIDEmployee())
        //    {
        //        list.Add(new CBBItem
        //        {
        //            Value = ++count,
        //            Text = item.ID_Employee
        //        });
        //    }
        //    return list;
        //}

        public List<Employee> GetAllIDEmployee()
        {
            return Manager_DAL.Instance.GetAllIDEmployee();
        }
        public string GetNameEmployeeByID(string ID)
        {
            return Manager_DAL.Instance.GetNameEmployeeByID(ID);
        }
        // lịch làm việc

        public dynamic ShowSchedule()
        {
            return Manager_DAL.Instance.ShowSchedule();
        }
        public dynamic SearchSchedule(string name, string shift)
        {
            return Manager_DAL.Instance.SearchSchedule(name, shift);
        }

        public dynamic ShowAllScheduleOfEPL(string name)
        {
            return Manager_DAL.Instance.ShowAllScheduleOfEPL(name);
        }
        //public void GetScheduleFollowEPL(string epl, RichTextBox rtb)
        //{
        //    Manager_DAL.Instance.GetScheduleFollowEPL(epl, rtb);
        //}
        public List<string> GetScheduleFollowEPL(string epl)
        {
            return Manager_DAL.Instance.GetScheduleFollowEPL(epl);
        }
        public string GetIDEmployee(string acc)
        {
            return Manager_DAL.Instance.GetIDEmployee(acc);
        }
        public void AddSchedule(int id, string idepl, int idshift, DateTime dt, string note)
        {
            Manager_DAL.Instance.AddSchedule(id, idepl, idshift, dt, note);
        }
        public void EditSchedule(int id, string idepl, int idshift, DateTime dt, string note)
        {
            Manager_DAL.Instance.EditSchedule(id, idepl, idshift, dt, note);
        }
        public void DeleteSchedule(int id)
        {
            Manager_DAL.Instance.DeleteSchedule(id);
        }
        public List<ShiftWork> GetAllShift()
        {
            return Manager_DAL.Instance.GetAllShift();
        }
        public string GetIDEmployeeByName(string name)
        {
            return Manager_DAL.Instance.GetIDEmployeeByName(name);
        }
        public bool CheckExistedIDSchedule(int id)
        {
            return Manager_DAL.Instance.CheckExistedIDSchedule(id);
        }
        public bool CheckExistedIDEPLInSchedule(string ID)
        {
            return Manager_DAL.Instance.CheckExistedIDEPLInSchedule(ID);
        }
        public int GetIDShift(string name)
        {
            return Manager_DAL.Instance.GetIDShift(name);
        }

        public dynamic GetAllFood()
        {
            return Manager_DAL.Instance.GetAllFood();
        }

        // Quản lý món ăn

        public dynamic GetFirstFood()
        {
            return Manager_DAL.Instance.GetFirstFood();
        }
        public dynamic GetNextFood(int row)
        {
            return Manager_DAL.Instance.GetNextFood(row);
        }
        public dynamic GetPreviousFood(int row)
        {
            return Manager_DAL.Instance.GetPreviousFood(row);
        }
        public int CountRow()
        {
            return Manager_DAL.Instance.CountRow();
        }
        public string GetID_FoodCategory(string name)
        {
            return Manager_DAL.Instance.GetID_FoodCategory(name);
        }
        public void AddFood(string id, string name, float price, string idCategory, string picture)
        {
            Manager_DAL.Instance.AddFood(id, name, price, idCategory, picture);
        }
        public void EditFood(string id, string name, float price, bool tt, string idCategory, int quantity, string picture)
        {
            Manager_DAL.Instance.EditFood(id, name, price, tt, idCategory, quantity, picture);
        }
        
        public List<FoodCategory> GetAllCategory()
        {
            return Manager_DAL.Instance.GetAllCategory();
        }

        public bool CheckExistedIDFood(string id)
        {
            return Manager_DAL.Instance.CheckExistedIDFood(id);
        }

        // Xem lợi nhuận


        public dynamic showRevenue()
        {
            return Manager_DAL.Instance.showRevenue();
        }
        public dynamic showRevenueByDay(DateTime st, DateTime et)
        {
            return Manager_DAL.Instance.showRevenueByDay(st, et);
        }
        public dynamic drawChartRevenue()
        {
            return Manager_DAL.Instance.drawChartRevenue();
        }
        public dynamic DrawChartRevenueByDay(DateTime st, DateTime et)
        {
            return Manager_DAL.Instance.DrawChartRevenueByDay(st, et);
        }
        public void AddOrUpdateRevenue(string id, float total, int customer)
        {
            Manager_DAL.Instance.AddOrUpdateRevenue(id, total, customer);
        }
        public string countRowInRevenue()
        {
            return Manager_DAL.Instance.countRowInRevenue();
        }
        public void drawColumnChart(Chart chartRevenue)
        {
            Manager_DAL.Instance.drawColumnChart(chartRevenue);
        }
        public dynamic ShowRevenueByMonth()
        {
            return Manager_DAL.Instance.ShowRevenueByMonth();
        }

        // Chấm công

        public List<string> getNameEmployee_BLL()
        {
            return Manager_DAL.Instance.getNameEmployee();
        }
        public List<string> GetIDEmployeeInTimeSheet()
        {
            return Manager_DAL.Instance.GetIDEmployeeInTimeSheet();
        }
        public int getIDSchedule_BLL(string idEmployee)
        {
            return Manager_DAL.Instance.getIDSchedule(idEmployee);
        }
        public List<DateTime> getWorkDayOfEmployee_BLL(int idSchedule, int day)
        {
            return Manager_DAL.Instance.getWorkDayOfEmployee(idSchedule, day);
        }
        public void Add_WorkDay_BLL(string idEmployee, DateTime now)
        {
            Manager_DAL.Instance.Add_WorkDay(idEmployee, now);
        }
        public int SumWorkDay_BLL(string idEmployee)
        {
            return Manager_DAL.Instance.SumWorkDay(idEmployee);
        }
        public string getShiftWork_BLL(string idEmployee)
        {
            return Manager_DAL.Instance.getShiftWork(idEmployee);
        }
        public DateTime getMaxDay_BLL()
        {
            return Manager_DAL.Instance.getMaxDay();
        }
        public List<string> getWeekOfDays_BLL()
        {
            return Manager_DAL.Instance.getWeekOfDays();
        }
        public DateTime CheckExistOfDay_BLL(string idEmployee, DateTime date)
        {
            return Manager_DAL.Instance.CheckExistOfDay(idEmployee, date);
        }
        public float getSalary_BLL(string idEmployee)
        {
            return Manager_DAL.Instance.getSalary(idEmployee);
        }
        public void DeleteWorkDayOfEmployee_BLL(string idEmployee)
        {
            Manager_DAL.Instance.DeleteWorkDayOfEmployee(idEmployee);
        }
        public bool CountShiftInDay(string idEmployee, DateTime date)
        {
            return Manager_DAL.Instance.CountShiftInDay(idEmployee, date);
        }
    }
}
    

