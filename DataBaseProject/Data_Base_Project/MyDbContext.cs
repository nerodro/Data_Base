using Microsoft.EntityFrameworkCore;

namespace Data_Base_Project
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-ERNBME1\\SQLEXPRESS;Database=Users;Trusted_Connection=True;");
        }

    }

}
