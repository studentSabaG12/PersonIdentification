﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonIdentification.Repository;

#nullable disable

namespace PersonIdentification.Repository.Migrations
{
    [DbContext(typeof(PersonIdentificationDbContext))]
    partial class PersonIdentificationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersonIdentification.DTO.City", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("PersonIdentification.DTO.Number", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("TextNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Numbers");
                });

            modelBuilder.Entity("PersonIdentification.DTO.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CityId1")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId1");

                    b.ToTable("People");
                });

            modelBuilder.Entity("PersonIdentification.DTO.Relation", b =>
                {
                    b.Property<int>("ToPersonId")
                        .HasColumnType("int");

                    b.Property<int>("FromPersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("ToPersonId", "FromPersonId")
                        .HasName("ToPersonId");

                    b.HasIndex("FromPersonId");

                    b.ToTable("Relations");
                });

            modelBuilder.Entity("PersonIdentification.DTO.Number", b =>
                {
                    b.HasOne("PersonIdentification.DTO.Person", "Person")
                        .WithMany("Numbers")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("PersonIdentification.DTO.Person", b =>
                {
                    b.HasOne("PersonIdentification.DTO.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("PersonIdentification.DTO.Relation", b =>
                {
                    b.HasOne("PersonIdentification.DTO.Person", "FromPerson")
                        .WithMany("FromRelations")
                        .HasForeignKey("FromPersonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PersonIdentification.DTO.Person", "ToPerson")
                        .WithMany("ToRelations")
                        .HasForeignKey("ToPersonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FromPerson");

                    b.Navigation("ToPerson");
                });

            modelBuilder.Entity("PersonIdentification.DTO.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("PersonIdentification.DTO.Person", b =>
                {
                    b.Navigation("FromRelations");

                    b.Navigation("Numbers");

                    b.Navigation("ToRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
