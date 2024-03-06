

using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Classes
{
    public class PatientContext : DbContext
    {
        public DbSet<Patients> Patients { get; set; }
        public PatientContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("server=student.permaviat.ru;Trusted_Connection=false;DataBase=base1_ISP_21_2_23;User=ISP_21_2_23;PWD=3frQxZ83o#;");
    }
}
