using System.ComponentModel.DataAnnotations;

namespace BusPassManagementSystem.Models
{
    public class AddPassModel
    {
        [Required]
        public string? UserId { get; set; }
        [Required]
        public int BusNo { get; set; }

        [Required]
        public string? Source { get; set; }

        [Required]
        public string? Destination { get; set; }

        public DateTime DateIssued { get; set; }

        [Required]
        public string? PassType { get; set; }
    }
}
