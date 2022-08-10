using System.ComponentModel.DataAnnotations;

namespace BusPassManagementSystem.Models
{
    public class LoginModel
    {
        [Required]
        public string UserId { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
