using Microsoft.EntityFrameworkCore;
using Otomasyon.Entity.Classes;
using Otomasyon.Model.Context;

namespace Otomasyon.BLL.Services
{
    public static class MessageServices
    {
        static OtomasyonContext _db = new OtomasyonContext();

        public static List<object> GetEmployees()
        {

            return _db.Employees.Select(x => new { ID = x.Id, Name = x.Name, LastName = x.LastName, Departman = x.Departman }).ToList<object>();
        }

        public static void SendMessage(string message, string topic, int index, Employee employee)
        {
            var empList = _db.Employees.ToList();
            var selectedPerson = _db.Employees.Find(empList[index].Id);

            selectedPerson.Messages.Add(new Messages()
            {
                Message = message,
                MessageTopic = topic,
                WhoSent = employee.Name + " " + employee.LastName,
            });
            _db.SaveChanges();
        }
        public static List<object> ShowMessage(int Id)
        {

            var selectedPerson = _db.Employees.Find(Id);
            return _db.Messages.Include(x => x.Employee).Where(msg => msg.Employee.Id == selectedPerson.Id).Select(x => new { ID = x.Id, From = x.WhoSent, Topic = x.MessageTopic, Messages = x.Message }).ToList<object>();
        }

        public static List<Messages> ShowMessageFull(int Id)
        {
            var selectedPerson = _db.Employees.Find(Id);
            return _db.Messages.Include(x => x.Employee).Where(msg => msg.Employee.Id == selectedPerson.Id).ToList();
        }
        public static void DeleteMessage(int id,int msgId)
        {
            var selectedPerson = _db.Employees.Find(id);
            var selectedMessage = _db.Messages.Include(x => x.Employee).Where(msg => msg.Employee.Id == selectedPerson.Id).ToList()[msgId];
            _db.Messages.Remove(selectedMessage);
            _db.SaveChanges();
        }
    }
}
