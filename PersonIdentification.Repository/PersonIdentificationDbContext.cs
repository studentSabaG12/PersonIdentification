using Microsoft.EntityFrameworkCore;
using PersonIdentification.DTO;

namespace PersonIdentification.Repository
{
    public class PersonIdentificationDbContext : DbContext
    {
        public PersonIdentificationDbContext(DbContextOptions<PersonIdentificationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>()
           .HasMany(p => p.ToRelations)
           .WithOne(p => p.ToPerson)
           .HasForeignKey(p => p.ToPersonId)
           .HasPrincipalKey(p => p.Id)
           .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Person>()
           .HasMany(p => p.FromRelations)
           .WithOne(p => p.FromPerson)
           .HasForeignKey(p => p.FromPersonId)
           .HasPrincipalKey(p => p.Id)
           .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Relation>()
           .HasKey(p => new { p.ToPersonId, p.FromPersonId })
           .HasName("FromPersonId")
           .HasName("ToPersonId");
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Number> Numbers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Relation> Relations { get; set; }
    }
}
