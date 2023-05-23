using Otomasyon.Entity.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otomasyon.Entity.Classes
{
    public class Employee
    {
        public Employee()
        {
            Messages = new HashSet<Messages>();
            Tasks = new HashSet<Tasking>();
            Attentions = new HashSet<Attentions>();
        }
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long PhoneNo { get; set; }
        public long IdentityNo { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Salary { get; set; }
        public Departman Departman { get; set; }
        public Gender Gender { get; set; } = Gender.Unknown;
        public string? PhotoPath { get; set; }
        public ICollection<Messages> Messages { get; set; }
        public ICollection<Tasking> Tasks { get; set; }
        public ICollection<Attentions> Attentions { get; set; }
    }
}
