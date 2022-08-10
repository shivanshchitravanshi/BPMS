using System.ComponentModel.DataAnnotations;

namespace BusPassManagementSystem.Models
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Dob { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string ContactNo { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
