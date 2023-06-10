using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL03.Quanly.Quanly_DAL
{
    internal class Manager_DAL
    {
        private PBL3Entities1 db;
        private static Manager_DAL _Instance;
        public static Manager_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Manager_DAL();
                }
                return _Instance;
            }
        }

        public Manager_DAL()
        {
            db = new PBL3Entities1();
        }

        //Quản lý nhân viên
        public dynamic Show()
        {

            var query = db.Employees.Select(p => new { p.ID_Employee, p.Name_Employee, p.PhoneNumber, p.Address_Employee, p.Salary, p.Acc }).ToList();
            return query;

        }


        public void add(string Id, string name, string phone, string address, float salary, string Username, string Password)
        {
            Employee temp = new Employee
            {
                ID_Employee = Id,
                Name_Employee = name,
                PhoneNumber = phone,
                Address_Employee = address,
                Salary = salary,
                Acc = Username,
            };
            Account temp1 = new Account
            {
                Username = Username,
                PW = Password,
                NameType = "thungan"
            };


            db.Employees.Add(temp);
            db.Accounts.Add(temp1);
            db.SaveChanges();
        }
        public bool CheckExistedIDEmployee(string id)
        {
            var query = db.Employees.Find(id);
            if (query != null)
            {
                return true;
            }
            return false;
        }
        public bool CheckExistedUsername(string username)
        {
            var query = db.Accounts.Find(username);
            if (query != null)
            {
                return false;
            }
            return true;
        }
        public void Edit(string Id, string Name, string PhoneNumber, string Address, float Salary, string user)
        {


            var query = db.Employees.Find(Id);
            query.Name_Employee = Name;
            query.PhoneNumber = PhoneNumber;
            query.Address_Employee = Address;
            query.Salary = Salary;
            query.Acc = user;
            db.SaveChanges();
        }

        public void Delete(string Id, string User)
        {

            var query = db.Employees.FirstOrDefault(p => p.ID_Employee == Id);
            var query1 = db.Accounts.FirstOrDefault(p => p.Username == User);
            db.Employees.Remove(query);
            db.Accounts.Remove(query1);
            db.SaveChanges();

        }

        public List<Employee> GetAllIDEmployee()
        {
            var query = db.Employees.Where(p => p.Account.NameType == "thungan").ToList();
            return query;
        }

        public string GetNameEmployeeByID(string ID)
        {
            var query = db.Employees.FirstOrDefault(p => p.ID_Employee == ID);
            return query.Name_Employee;
        }
        //lịch làm việc

        public dynamic ShowSchedule()
        {
            var query = db.WorkSchedules
                .Join(db.Employees, p => p.IDEmployee, c => c.ID_Employee, (p, c) => new { WorkSchedule = p, Employee = c })
                .Select(x => new
                {
                    x.WorkSchedule.ID_Schedule,
                    x.Employee.ID_Employee,
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
                    x.Employee.ID_Employee,
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
                    x.Employee.ID_Employee,
                    x.Employee.Name_Employee,
                    x.WorkSchedule.ShiftWork.NameShift,
                    x.WorkSchedule.DateWork,
                    x.WorkSchedule.Note
                })
                .ToList();
            return query;
        }

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
            if (query != null)
            {
                return query.ID_Employee;
            }
            return null;
        }

        public bool CheckExistedIDSchedule(int id)
        {
            var query = db.WorkSchedules.Find(id);
            if (query == null)
            {
                return false;
            }
            return true;
        }
        public bool CheckExistedIDEPLInSchedule(string ID)
        {
            var query = db.WorkSchedules.FirstOrDefault(p => p.IDEmployee == ID);
            if (query != null)
            {
                return true;
            }
            return false;
        }
        public int GetIDShift(string name)
        {
            var query = db.ShiftWorks.FirstOrDefault(p => p.NameShift == name);
            return query.ID_Shift;
        }

        public dynamic GetAllFood()
        {

            var query = db.Foods.Select(p => new { p.ID_Food, p.NameFood, p.Price, p.QuantityFood }).ToList();
            return query;

        }

        // Quản lý món ăn

        public dynamic GetFirstFood()
        {

            var query = db.Foods
                .Take(5)
                .Select(p => new { p.ID_Food, p.NameFood, p.Price, p.QuantityFood })
                .ToList();
            return query;

        }
        public dynamic GetNextFood(int row)
        {

            var query = db.Foods
                .OrderBy(p => p.ID_Food)
                .Skip(row)
                .Take(5)
                .Select(p => new { p.ID_Food, p.NameFood, p.Price, p.QuantityFood, p.FoodCategory.NameCategory })
                .ToList();
            return query;

        }
        public dynamic GetPreviousFood(int row)
        {

            var query = db.Foods
                .OrderBy(p => p.ID_Food)
                .Skip(-row)
                .Take(5)
                .Select(p => new { p.ID_Food, p.NameFood, p.Price, p.QuantityFood })
                .ToList();
            return query;

        }
        public int CountRow()
        {

            var count = db.Foods.Count();
            return count;

        }
        public string GetID_FoodCategory(string name)
        {

            var query = db.FoodCategories.FirstOrDefault(p => p.NameCategory == name);
            return query.ID_Category;

        }
        public void AddFood(string id, string name, float price, string idCategory, string picture)
        {

            Food temp = new Food
            {
                ID_Food = id,
                NameFood = name,
                Price = price,
                StatusFood = true,
                IDCategory = idCategory,
                QuantityFood = 200,
                PictureFood = picture
            };
            db.Foods.Add(temp);
            db.SaveChanges();

        }
        public void EditFood(string id, string name, float price, bool tt, string idCategory, int quantity, string picture)
        {

            var food = db.Foods.Find(id);
            food.NameFood = name;
            food.Price = price;
            food.StatusFood = tt;
            food.IDCategory = idCategory;
            food.QuantityFood = quantity;
            food.PictureFood = picture;
            db.SaveChanges();

        }
        public List<FoodCategory> GetAllCategory()
        {

            var query = db.FoodCategories.ToList();
            return query;

        }
        public bool CheckExistedIDFood(string id)
        {

            var query = db.Foods.Find(id);
            if (query == null)
            {
                return false;
            }
            return true;
        }

        // Xem lợi nhuận

        public dynamic showRevenue()
        {

            var query = db.Revenues.OrderBy(p => p.RevenueInDate).ToList();
            return query;
        }

        public dynamic showRevenueByDay(DateTime st, DateTime et)
        {

            var query = db.Revenues
                .Where(p => p.RevenueInDate >= st && p.RevenueInDate <= et)
                .OrderBy(p => p.RevenueInDate).ToList();
            return query;

        }

        public dynamic drawChartRevenue()
        {

            var data = db.Revenues
                .Select(p => new { p.RevenueInDate, p.TotalInDate })
                .OrderBy(p => p.RevenueInDate)
                .ToList();
            return data;

        }
        public dynamic DrawChartRevenueByDay(DateTime st, DateTime et)
        {

            var data = db.Revenues
                .Where(p => p.RevenueInDate >= st && p.RevenueInDate <= et)
                .Select(p => new
                {
                    p.RevenueInDate,
                    p.TotalInDate,
                })
                .OrderBy(p => p.RevenueInDate)
                .ToList();
            return data;

        }
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
        public string countRowInRevenue()
        {

            int count = db.Revenues.Count();
            count++;
            return count.ToString();

        }
        public void drawColumnChart(Chart chartRevenue)
        {

            var query = db.Revenues
                .Where(p => p.RevenueInDate >= new DateTime(2023, 1, 1) && p.RevenueInDate <= new DateTime(2023, 12, 31))
                .GroupBy(p => new { p.RevenueInDate.Year, p.RevenueInDate.Month })
                .Select(c => new
                {
                    Month = c.Key.Month,
                    Year = c.Key.Year,
                    Total = c.Sum(p => p.TotalInDate)
                })
                .OrderBy(c => c.Year)
                .ThenBy(c => c.Month)
                .ToList();
            List<float> revenues = new List<float>();
            List<string> months = new List<string>();
            foreach (var item in query)
            {
                revenues.Add(item.Total);
                months.Add($"Tháng {item.Month} năm {item.Year}");
            }
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();
            chartRevenue.Titles.Clear();
            ChartArea chartArea = new ChartArea();
            chartRevenue.ChartAreas.Add(chartArea);

            Series series = new Series();

            //Tiêu đề cho biểu đồ
            Title title = new Title();
            title.Text = "Doanh thu theo tháng";
            title.Font = new Font("Verdana", 12, FontStyle.Regular);
            title.ForeColor = Color.Green;

            series.ChartType = SeriesChartType.Column;
            series.BorderWidth = 2;
            series.Color = Color.Blue;
            series.Name = "Doanh thu";
            series.IsValueShownAsLabel = true;

            series.Points.DataBindXY(months, revenues);

            chartRevenue.Series.Add(series);
            chartRevenue.Titles.Add(title);

            chartRevenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chartRevenue.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            chartRevenue.ChartAreas[0].AxisX.Title = "Tháng";

            chartRevenue.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            chartRevenue.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";


            chartRevenue.Invalidate();

        }
        public dynamic ShowRevenueByMonth()
        {

            var query = db.Revenues
                .Where(p => p.RevenueInDate >= new DateTime(2023, 1, 1) && p.RevenueInDate <= new DateTime(2023, 12, 31))
                .GroupBy(p => new { p.RevenueInDate.Year, p.RevenueInDate.Month })
                .Select(c => new
                {
                    Month = c.Key.Month,
                    Year = c.Key.Year,
                    Total = c.Sum(p => p.TotalInDate)
                })
                .OrderBy(c => c.Year)
                .ThenBy(c => c.Month)
                .ToList();
            return query;

        }

        // Chấm công :
        public List<string> getNameEmployee()
        {
            List<string> names = new List<string>();

            var query = from ws in db.WorkSchedules
                        join em in db.Employees on ws.IDEmployee equals em.ID_Employee
                        select em.Name_Employee;
            foreach (var item in query)
            {
                names.Add(item);
            }

            return names;
        }

        public List<string> GetIDEmployeeInTimeSheet()
        {
            List<string> listID = new List<string>();
            var query = db.WorkSchedules.Select(p => new { p.IDEmployee, p.Employee.Name_Employee }).ToList();
            foreach (var item in query)
            {
                listID.Add(item.IDEmployee);
            }
            return listID;
        }
        public int getIDSchedule(string idEmployee)
        {

            var query = db.WorkSchedules.SingleOrDefault(p => p.IDEmployee == idEmployee);
            return query.ID_Schedule;

        }
        public int getIDShift(string idEmployee)
        {
            var query = db.WorkSchedules.SingleOrDefault(p => p.IDEmployee == idEmployee);
            return query.IDShift;

        }
        public List<DateTime> GetDaysOfWeek(int week, int year)
        {
            List<DateTime> daysOfWeek = new List<DateTime>();
            CultureInfo culture = CultureInfo.CurrentCulture;
            Calendar calendar = culture.Calendar;
            // Xác định ngày đầu tiên của tuần và năm đã cho
            DateTime startDate = new DateTime(year, 1, 1);
            startDate = startDate.AddDays((week - 1) * 7);
            while (calendar.GetWeekOfYear(startDate, culture.DateTimeFormat.CalendarWeekRule, culture.DateTimeFormat.FirstDayOfWeek) != week)
            {
                startDate = startDate.AddDays(1);
            }
            // Duyệt qua 7 ngày trong tuần
            for (int i = 1; i <= 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);
                daysOfWeek.Add(currentDay);
            }

            return daysOfWeek;
        }
        public List<DateTime> getWorkDayOfEmployee(int idSchedule, int day)
        {
            List<DateTime> days = new List<DateTime>();
            List<DateTime> dayinweek = GetDaysOfWeek(day, DateTime.Now.Year);

            var query = db.TimeSheets.Where(p => p.IDSchedule == idSchedule).Select(p => p.WorkDay).ToList();
            foreach (var item in query)
            {
                foreach (DateTime d in dayinweek)
                {
                    if (d == item)
                    {
                        days.Add((DateTime)item);
                    }
                }

            }
            return days;
        }
        public void Add_WorkDay(string idEmployee, DateTime now)
        {
            int id = getIDSchedule(idEmployee);

            TimeSheet ts = new TimeSheet
            {
                IDSchedule = id,
                WorkDay = now,
            };
            db.TimeSheets.Add(ts);
            db.SaveChanges();

        }
        public int SumWorkDay(string idEmployee)
        {
            int id = getIDSchedule(idEmployee);

            var query = db.TimeSheets
                .Join(db.WorkSchedules, p => p.IDSchedule, c => c.ID_Schedule, (p, c) => new { TimeSheet = p, WorkSchedule = c })
                .Where(p => p.TimeSheet.IDSchedule == id)
                .Count();
            return query;
        }
        public string getShiftWork(string idEmployee)
        {
            int id = getIDShift(idEmployee);

            var query = db.WorkSchedules
                .Join(db.ShiftWorks, p => p.IDShift, c => c.ID_Shift, (p, c) => new { WorkSchedule = p, ShiftWork = c })
                .Where(p => p.ShiftWork.ID_Shift == id)
                .Select(p => p.ShiftWork.NameShift);
            return query.FirstOrDefault().ToString();


        }

        public DateTime getMaxDay()
        {
            var query = db.TimeSheets.Max(p => p.WorkDay);
            return query;
        }

        public int GetWeekNumberOfDate(DateTime date)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            Calendar calendar = ci.Calendar;
            CalendarWeekRule calendarWeekRule = ci.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = ci.DateTimeFormat.FirstDayOfWeek;

            return calendar.GetWeekOfYear(date, calendarWeekRule, firstDayOfWeek);
        }
        public List<string> getWeekOfDays()
        {
            List<string> list = new List<string>();

            var query = db.TimeSheets.Select(p => p.WorkDay).ToList();
            foreach (var item in query)
            {
                string week = GetWeekNumberOfDate((DateTime)item).ToString();
                list.Add(week);
            }
            list.Sort();
            return list.Distinct().ToList();
        }
        public DateTime CheckExistOfDay(string idEmployee, DateTime date)
        {
            int idSchedule = getIDSchedule(idEmployee);
            using (var db = new PBL3Entities1())
            {
                var query = db.TimeSheets.Where(p => p.IDSchedule == idSchedule && p.WorkDay == date).Select(p => p.WorkDay);
                return query.FirstOrDefault();

            }
        }
        public float getSalary(string idEmployee)
        {

            var query = db.Employees.Where(p => p.ID_Employee == idEmployee).Select(p => p.Salary);
            return query.FirstOrDefault();

        }
        public void DeleteWorkDayOfEmployee(string idEmployee)
        {
            int idSchedule = getIDSchedule(idEmployee);
            var query = db.TimeSheets.Where(p => p.IDSchedule == idSchedule);
            db.TimeSheets.RemoveRange(query);
            db.SaveChanges();
        }
        public bool CountShiftInDay(string idEmployee, DateTime date)
        {
            int idSchedule = getIDSchedule(idEmployee);

            var query = db.TimeSheets.Where(p => p.IDSchedule == idSchedule && p.WorkDay == date).ToList();
            var count = query.Count(p => p.WorkDay.Date == date);
            if (count == 3)
            {
                return true;
            }
            return false;
        }
    }
}

