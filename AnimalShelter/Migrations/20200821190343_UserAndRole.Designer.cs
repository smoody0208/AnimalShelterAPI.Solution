﻿// <auto-generated />
using System;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20200821190343_UserAndRole")]
    partial class UserAndRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Breed");

                    b.Property<DateTime>("DateRescued");

                    b.Property<string>("Description");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<int>("ShelterId");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.HasIndex("ShelterId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 4,
                            Breed = "German Shepard",
                            DateRescued = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Well behaved and playful!",
                            Gender = "Male",
                            Name = "Leo",
                            ShelterId = 1,
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 2,
                            Breed = "N/A",
                            DateRescued = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sometimes grumpy, but usually friendly",
                            Gender = "Female",
                            Name = "Kitty",
                            ShelterId = 1,
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 20,
                            Breed = "Parrot",
                            DateRescued = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Likes to talk and yell",
                            Gender = "Female",
                            Name = "Birdy",
                            ShelterId = 2,
                            Species = "Bird"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.Shelter", b =>
                {
                    b.Property<int>("ShelterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.HasKey("ShelterId");

                    b.ToTable("Shelters");

                    b.HasData(
                        new
                        {
                            ShelterId = 1,
                            Location = "Four Paws Rescue"
                        },
                        new
                        {
                            ShelterId = 2,
                            Location = "Meowin Rescue"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.HasOne("AnimalShelter.Models.Shelter")
                        .WithMany("Animals")
                        .HasForeignKey("ShelterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}