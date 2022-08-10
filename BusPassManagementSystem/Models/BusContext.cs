using Microsoft.EntityFrameworkCore;

namespace BusPassManagementSystem.Models
{
    public class BusContext:DbContext
    {
        public BusContext()
        {

        }

        public BusContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<UserMaster> UserMasters { get; set; }
        public DbSet<BusDetail> BusDetails { get; set; }
        public DbSet<PassDetail> PassDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=tcp:rps-wipro.database.windows.net;Initial Catalog=BusPassManagementSystem;Persist Security Info=False;User ID=shivansh;Password=Qazwsx123.;");
            optionsBuilder.UseSqlServer("Data Source=WINDOWS-BVQNF6J\\SQLEXPRESS;Initial Catalog=DbBPMS;Integrated Security = true;");
        }
    }
}
