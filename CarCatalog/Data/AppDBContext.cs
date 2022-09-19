using CarCatalog.Data.Models;
using CarCatalog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CarCatalog.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<BodyStyle> BodyStyles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Drivetrain> Drivetrains { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<TransmissionType> TransmissionTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>()
                .HasMany<BodyStyle>(bs => bs.BodyStyles);

            modelBuilder.Entity<Car>()
                .HasMany<TransmissionType>(ts => ts.TransmissionTypes);

            modelBuilder.Entity<Car>()
                .HasMany<Drivetrain>(dts => dts.Drivetrains);
        }

    }

}
