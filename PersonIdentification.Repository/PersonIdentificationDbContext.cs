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

            modelBuilder.Entity<Person>()
                                .Property(p => p.Id)
                                .HasColumnType("int")
                                .IsRequired(true);
            modelBuilder.Entity<Person>()
                                .Property(p => p.FirstName)
                                .HasColumnType("nvarchar(30)")
                                .IsRequired(true);
            modelBuilder.Entity<Person>()
                                .Property(p => p.LastName)
                                .HasColumnType("nvarchar(75)")
                                .IsRequired(true);
            modelBuilder.Entity<Person>()
                                .Property(p => p.PersonalNumber)
                                .HasColumnType("nvarchar(11)")
                                .IsRequired(true);
            modelBuilder.Entity<Person>()
                                .Property(p => p.BirthDate)
                                .HasColumnType("date")
                                .IsRequired(true);
            modelBuilder.Entity<Person>()
                                .Property(p => p.Gender)
                                .HasColumnType("tinyint")
                                .IsRequired(true);
            modelBuilder.Entity<Person>()
                                .Property(p => p.CreateDate)
                                .HasColumnType("date")
                                .HasDefaultValueSql("GetDate()")
                                .IsRequired(true);
            modelBuilder.Entity<Person>()
                                .Property(pc => pc.IsDelete)
                                .HasColumnType("bit")
                                .HasDefaultValueSql("(0)")
                                .IsRequired(true);

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
                .HasName("ToPersonID");


            modelBuilder.Entity<Relation>()
                                            .Property(r => r.Type)
                                            .HasColumnType("tinyint")
                                            .IsRequired(true);

            modelBuilder.Entity<Relation>()
                                            .Property(pc => pc.CreateDate)
                                            .HasColumnType("date")
                                            .HasDefaultValueSql("GetDate()")
                                            .IsRequired(true);

            modelBuilder.Entity<Relation>()
                                            .Property(pc => pc.IsDelete)
                                            .HasColumnType("bit")
                                            .HasDefaultValueSql("(0)")
                                            .IsRequired(true);





            modelBuilder.Entity<City>()
                                .Property(c => c.Id)
                                .HasColumnType("int")
                                .IsRequired(true);
            modelBuilder.Entity<City>()
                                .Property(c => c.Name)
                                .HasColumnType("nvarchar(100)")
                                .IsRequired(true);
            modelBuilder.Entity<City>()
                                .HasIndex(c => c.Name)
                                .IsUnique(true);
            modelBuilder.Entity<City>()
                                .HasMany(p => p.People)
                                .WithOne(p => p.City);
            modelBuilder.Entity<City>()
                                .Property(p => p.CreateDate)
                                .HasColumnType("date")
                                .HasDefaultValueSql("GetDate()")
                                .IsRequired(true);
            modelBuilder.Entity<City>()
                                .Property(pc => pc.IsDelete)
                                .HasColumnType("bit")
                                .HasDefaultValueSql("(0)")
                                .IsRequired(true);

            modelBuilder.Entity<Number>()
                                .Property(n => n.Id)
                                .HasColumnType("int")
                                .IsRequired(true);
            modelBuilder.Entity<Number>()
                                .Property(ci => ci.TextNumber)
                                .HasColumnType("varchar(15)")
                                .IsRequired(true);
            modelBuilder.Entity<Number>()
                                .Property(n => n.Type)
                                .HasColumnType("tinyint")
                                .IsRequired(true);
            modelBuilder.Entity<Number>()
                                .HasOne(n =>n.Person)
                                .WithMany(n =>n.Numbers)
                                .IsRequired(true);
            modelBuilder.Entity<Number>()
                                .Property(p => p.CreateDate)
                                .HasColumnType("date")
                                .HasDefaultValueSql("GetDate()")
                                .IsRequired(true);
            modelBuilder.Entity<Number>()
                                .Property(r => r.IsDelete)
                                .HasColumnType("bit")
                                .HasDefaultValueSql("(0)")
                                .IsRequired(true);
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Number> Numbers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Relation> Relations { get; set; }
    }
}
