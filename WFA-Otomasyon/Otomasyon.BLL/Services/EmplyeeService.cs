using Otomasyon.Entity.Classes;
using Otomasyon.Model.Context;

namespace Otomasyon.BLL.Services
{
    public static class EmplyeeService
    {
        static OtomasyonContext _db = new OtomasyonContext();

        public static void AddEmployee(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
        }
        public static void DeleteEmployee(int id)
        {
            var empList = _db.Employees.ToList();
            var selectedEmployee = _db.Employees.Find(empList[id].Id);
            _db.Employees.Remove(selectedEmployee);
            _db.SaveChanges();
        }
        public static void UpdateEmployee()
        {

            _db.SaveChanges();
        }

        public static List<object> GetAllEmployees()
        {
            var myList = _db.Employees.Select(x => new { ID = x.Id, Name = x.Name, LastName = x.LastName, Salary = x.Salary, BirthDay = x.BirthDay, Departman = x.Departman, Gender = x.Gender, PhoneNo = x.PhoneNo, IdentityNo = x.IdentityNo }).ToList<object>();
            return myList;
        }
        public static Employee GetEmployee(int id)
        {
            var empList = _db.Employees.ToList();
            var selectedEmployee = _db.Employees.Find(empList[id].Id);
            return selectedEmployee;
        }

        public static void LoadPic(string picPath, int id)
        {
            _db.Employees.ToList()[id].PhotoPath = picPath;
            _db.SaveChanges();

        }
        public static Employee GetEmployeeName(string name, string lastName)
        {
            return _db.Employees.FirstOrDefault(x => x.Name == name && x.LastName == lastName);
        }
    }
}
