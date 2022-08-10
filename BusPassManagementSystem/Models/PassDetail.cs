namespace BusPassManagementSystem.Models
{
    public class PassDetail
    {
        public int Id { get; set; }

        public string? UserId { get; set; }
        public int BusNo { get; set; }

        public string? Source { get; set; }

        public string? Destination { get; set; }
        public DateTime DateIssued { get; set; }

        public string? PassType { get; set; }
    }
}
