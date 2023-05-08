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
            selectedEmployee.Tasks.Add(new Tasking()
            {
                Name = name,
                TaskMessage = message,
                Role = role,
                DeadLine = deadLine

            });
            _db.SaveChanges();
        }

        public static List<Tasking> GetTasks(int Id)
        {

            var selectedEmployee = _db.Employees.Find(Id);
            return _db.Tasks.Include(x => x.Employees).Where(x => x.Employees.Any(e => e.Id == selectedEmployee.Id)).ToList();

        }



    }
}
