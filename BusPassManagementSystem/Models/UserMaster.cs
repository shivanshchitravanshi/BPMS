namespace BusPassManagementSystem.Models
{
    public class UserMaster
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DoB { get; set; }
        public string? Gender { get; set; }
        public string? ContactNo { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public int RoleId { get; set; }

    }
}
