using System.ComponentModel.DataAnnotations;

namespace BusPassManagementSystem.Models
{
    public class UpdateRouteModel
    {
        [Required]
        public int BusNo { get; set; }

        [Required]
        public string? Source { get; set; }

        [Required]
        public string? Destination { get; set; }

        [Required]
        public int NoOfStops { get; set; }
    }
}
