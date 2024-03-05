using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Classes
{
    public class DoctorContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DoctorContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(Config.config);
    }
}
