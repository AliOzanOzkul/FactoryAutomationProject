using Microsoft.EntityFrameworkCore;
using Otomasyon.Entity.Classes;
using Otomasyon.Model.Context;

namespace Otomasyon.BLL.Services
{
    public static class TaskServices
    {
        static OtomasyonContext _db = new OtomasyonContext();

        public static void AddTask(int Id, string name, string message, string role, DateTime deadLine)
        {
            var selectedEmployee = _db.Employees.ToList()[Id];
            if (selectedEmployee.Tasks.Count < 3)
            {
                selectedEmployee.Tasks.Add(new Tasking()
                {
                    Name = name,
                    TaskMessage = message,
                    Role = role,
                    DeadLine = deadLine

                });
                _db.SaveChanges();
            }
            else
            {
                throw new Exception();
            }
        }

        public static List<Tasking> GetTasks(int Id)
        {
            var selectedEmployee = _db.Employees.Find(Id);
            return _db.Tasks.Include(x => x.Employees).Where(x => x.Employees.Any(e => e.Id == selectedEmployee.Id)).ToList();
        }
        public static bool EmployeTaskControl(int index)
        {
            var employee = _db.Employees.ToList()[index];
            var list = _db.Employees.Include(x => x.Tasks).Where(x => x.Tasks.Count == 3 && x.Id == employee.Id).FirstOrDefault();
            if (list != null)
            {

            return true;
            }
            return false;
        }

        public static void DeleteTask(string name)
        {
            var selectedTask = _db.Tasks.Where(x => x.Name == name).FirstOrDefault();
            _db.Tasks.Remove(selectedTask);
            _db.SaveChanges();

        }


    }
}
