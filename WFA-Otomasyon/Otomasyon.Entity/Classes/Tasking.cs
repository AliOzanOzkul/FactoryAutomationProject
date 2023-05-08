namespace Otomasyon.Entity.Classes
{
    public class Tasking
    {
        public Tasking()
        {
            Employees = new HashSet<Employee>();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string TaskMessage { get; set; }
        public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime DeadLine { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
