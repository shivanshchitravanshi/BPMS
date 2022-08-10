namespace BusPassManagementSystem.Models
{
    public class BusDetail
    {
        public int Id { get; set; }

        public int BusNo { get; set; }
        public string? Source { get; set; }

        public string? Destination { get; set; }
        public int NoOfStops { get; set; }

    }
}
