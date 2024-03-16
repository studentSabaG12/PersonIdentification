using Microsoft.EntityFrameworkCore;
using PersonIdentification.DTO;

namespace PersonIdentification.Repository
{
    public class PersonIdentificationDbContext:DbContext
    {
        public PersonIdentificationDbContext(DbContextOptions<PersonIdentificationDbContext> options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Number> Numbers { get; set; }
        public DbSet<Person> People { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Number>().Property(a => a.TextNumber).HasColumnType("nvarchar(50)").IsRequired(true);
        }
      
    }
}
