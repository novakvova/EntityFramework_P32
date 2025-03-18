﻿// <auto-generated />
using System;
using Animal.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Animal.Infrastructure.Migrations
{
    [DbContext(typeof(AppAnimalContext))]
    [Migration("20250318132949_Add_tblAppointments")]
    partial class Add_tblAppointments
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Animal.Infractructure.Entities.AdoptionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AdoptedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("AdopterId")
                        .HasColumnType("integer");

                    b.Property<int>("AnimalId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AdopterId");

                    b.HasIndex("AnimalId");

                    b.ToTable("tblAdoptions");
                });

            modelBuilder.Entity("Animal.Infractructure.Entities.AppointmentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("tblAppointments");
                });

            modelBuilder.Entity("Animal.Infrastructure.Entities.AdopterEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("tblAdopters");
                });

            modelBuilder.Entity("Animal.Infrastructure.Entities.AnimalEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("ArrivalDate")
                        .HasColumnType("date");

                    b.Property<string>("Breed")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(40000)
                        .HasColumnType("character varying(40000)");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int?>("ShelterLocationId")
                        .HasColumnType("integer");

                    b.Property<int>("SpecieId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ShelterLocationId");

                    b.HasIndex("SpecieId");

                    b.ToTable("tbl_animals");
                });

            modelBuilder.Entity("Animal.Infrastructure.Entities.ShelterLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("tbl_shelter_locations");
                });

            modelBuilder.Entity("Animal.Infrastructure.Entities.Specie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("tbl_species");
                });

            modelBuilder.Entity("Animal.Infractructure.Entities.AdoptionEntity", b =>
                {
                    b.HasOne("Animal.Infrastructure.Entities.AdopterEntity", "Adopter")
                        .WithMany()
                        .HasForeignKey("AdopterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Animal.Infrastructure.Entities.AnimalEntity", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adopter");

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("Animal.Infractructure.Entities.AppointmentEntity", b =>
                {
                    b.HasOne("Animal.Infrastructure.Entities.AnimalEntity", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("Animal.Infrastructure.Entities.AnimalEntity", b =>
                {
                    b.HasOne("Animal.Infrastructure.Entities.ShelterLocation", "ShelterLocation")
                        .WithMany("Animals")
                        .HasForeignKey("ShelterLocationId");

                    b.HasOne("Animal.Infrastructure.Entities.Specie", "Specie")
                        .WithMany("Animals")
                        .HasForeignKey("SpecieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShelterLocation");

                    b.Navigation("Specie");
                });

            modelBuilder.Entity("Animal.Infrastructure.Entities.ShelterLocation", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("Animal.Infrastructure.Entities.Specie", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
