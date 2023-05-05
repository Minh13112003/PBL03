using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL03.QuanLy.QuanLy_DAL
{
    public class Manager_DAL
    {
        private PBL03Entities db;
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
            db = new PBL03Entities();
        }
        public dynamic Show()
        {
            
          var query = db.Employees.Select(p => new { p.ID_Employee, p.Name_Employee,p.PhoneNumber,p.Address_Employee,p.Salary,p.Acc}).ToList();
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

        public void Delete(string Id,string User)
        {

            var query = db.Employees.FirstOrDefault(p => p.ID_Employee == Id);
            var query1 = db.Accounts.FirstOrDefault(p => p.Username == User);
            db.Employees.Remove(query);
            db.Accounts.Remove(query1);
            db.SaveChanges();

        }

    }
}

