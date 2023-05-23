namespace Otomasyon.Entity.Classes
{
    public class Messages
    {
        public int Id { get; set; }
        public string MessageTopic { get; set; }
        public string Message { get; set; }
        public DateTime? SentDay { get; set; } = DateTime.Now;
        public string? WhoSent { get; set; }
        public Employee Employee { get; set; }
    }
}
