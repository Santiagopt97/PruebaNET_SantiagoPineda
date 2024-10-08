﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaNET_SantiagoPineda.Data;

#nullable disable

namespace PruebaNET_SantiagoPineda.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241007132945_RoomAndRoomTypeSeeders")]
    partial class RoomAndRoomTypeSeeders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_date");

                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_date");

                    b.Property<double>("TotalCost")
                        .HasColumnType("double")
                        .HasColumnName("total_cost");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("bookings");
                });

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birthdate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("guests");
                });

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("availability");

                    b.Property<int>("MaxOccupancyPerson")
                        .HasColumnType("int")
                        .HasColumnName("max_occupancy_person");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("double")
                        .HasColumnName("price_per_night");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("room_number");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "101",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "102",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 3,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "103",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "104",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 5,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "105",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 6,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "106",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 7,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "107",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "108",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 9,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "109",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 10,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "110",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 11,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "201",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 12,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "202",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 13,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "203",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 14,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "204",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 15,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "205",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 16,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "206",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 17,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "207",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 18,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "208",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 19,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "209",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 20,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "210",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 21,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "301",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 22,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "302",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 23,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "303",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 24,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "304",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 25,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "305",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 26,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "306",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 27,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "307",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 28,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "308",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 29,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "309",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 30,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "310",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 31,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "401",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 32,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "402",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 33,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "403",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 34,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "404",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 35,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "405",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 36,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "406",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 37,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "407",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 38,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "408",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 39,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "409",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 40,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "410",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 41,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "501",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 42,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "502",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 43,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "503",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 44,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "504",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 45,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "505",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 46,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "506",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 47,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 80.0,
                            RoomNumber = "507",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 48,
                            Availability = true,
                            MaxOccupancyPerson = 4,
                            PricePerNight = 200.0,
                            RoomNumber = "508",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 49,
                            Availability = true,
                            MaxOccupancyPerson = 1,
                            PricePerNight = 50.0,
                            RoomNumber = "509",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 50,
                            Availability = true,
                            MaxOccupancyPerson = 2,
                            PricePerNight = 150.0,
                            RoomNumber = "510",
                            RoomTypeId = 3
                        });
                });

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("room_types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A cozy basic room with a single bed, ideal for solo travelers.",
                            Name = "Single Room"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Offers flexibility with either two single beds or a double bed, perfect for couples or friends.",
                            Name = "Double Room"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Spacious and luxurious, with a king-size bed and a separate living area, ideal for those seeking comfort and exclusivity.",
                            Name = "Suite"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Designed for families, with extra space and multiple beds for a comfortable stay.",
                            Name = "Family Room"
                        });
                });

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.Booking", b =>
                {
                    b.HasOne("PruebaNET_SantiagoPineda.Models.Employee", "Employees")
                        .WithMany("Bookings")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaNET_SantiagoPineda.Models.Guest", "Guests")
                        .WithMany("Bookings")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaNET_SantiagoPineda.Models.Room", "Rooms")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Guests");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.Room", b =>
                {
                    b.HasOne("PruebaNET_SantiagoPineda.Models.RoomType", "RoomTypes")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomTypes");
                });

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.Employee", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.Guest", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("PruebaNET_SantiagoPineda.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
