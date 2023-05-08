namespace Otomasyon.Entity.Classes
{
    public class Expenses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bill { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
