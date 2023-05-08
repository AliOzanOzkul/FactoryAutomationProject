namespace Otomasyon.Entity.Classes
{
    public class Attentions
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }

        public DateTime? End { get; set; }
        public Employee Employee { get; set; }

    }
}
