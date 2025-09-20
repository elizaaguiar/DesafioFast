using DesafioFullstack.Entity;
using DesafioFullstack.Seed;
using Microsoft.EntityFrameworkCore;

namespace DesafioFullstack.AppDbContext
{
    public class DbContexto : DbContext
    {
        public DbContexto(){}
        public DbSet<Collaborator> Collaborator { get; set; } = default!;
        public DbSet<Workshop> Workshop { get; set; } = default!;
        public DbSet<Attendance> Attendance { get; set; } = default!;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("server=localhost;port=3306;database=mydb;user=myuser;password=mypassword;",
                new MySqlServerVersion(new Version(8, 0, 30)));
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            WorshopSeed.WorshopSeedBuilder(modelBuilder);
            CollaboratorSeed.CollaboratorSeedBuilder(modelBuilder);
            AttendanceSeed.AttendanceSeedBuilder(modelBuilder);
        }
    }
}