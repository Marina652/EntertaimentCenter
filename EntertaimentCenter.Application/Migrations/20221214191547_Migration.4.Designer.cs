﻿// <auto-generated />
using System;
using EntertaimentCenter.Application.DbAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntertaimentCenter.Application.Migrations
{
    [DbContext(typeof(EntertaimentCenterDbContext))]
    [Migration("20221214191547_Migration.4")]
    partial class Migration4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DiscountCardId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("DiscountCardId");

                    b.HasIndex("OrderId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.smith@example.com",
                            Login = "John",
                            Name = "John Smith",
                            Password = "password",
                            Phone = "555-555-5555"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1995, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.doe@example.com",
                            Login = "Jone",
                            Name = "Jane Doe",
                            Password = "123",
                            Phone = "555-555-5556"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1985, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bob.johnson@example.com",
                            Login = "Bob",
                            Name = "Bob Johnson",
                            Password = "password",
                            Phone = "555-555-5557"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1980, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alice.williams@example.com",
                            Login = "AW",
                            Name = "Alice Williams",
                            Password = "alice",
                            Phone = "555-555-5558"
                        });
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.CustomEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("CustomEvents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A musical performance by the city symphony orchestra",
                            EndTime = new DateTime(2022, 12, 15, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 12, 15, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Description = "A stand-up comedy show featuring local comedians",
                            EndTime = new DateTime(2022, 12, 17, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 12, 17, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Description = "A book reading and signing event with a bestselling author",
                            EndTime = new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Description = "A movie screening of a classic film",
                            EndTime = new DateTime(2022, 12, 21, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 12, 21, 19, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DiscountCardId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DiscountCardId");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Value = 0.15m
                        },
                        new
                        {
                            Id = 2,
                            Value = 0.2m
                        },
                        new
                        {
                            Id = 3,
                            Value = 0.25m
                        });
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.DiscountCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DiscountsCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            DiscountId = 1
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 2,
                            DiscountId = 2
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 3,
                            DiscountId = 3
                        });
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("CustomEventId")
                        .HasColumnType("int");

                    b.Property<int>("PlaceId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            CustomEventId = 1,
                            PlaceId = 1,
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 2,
                            CustomEventId = 2,
                            PlaceId = 2,
                            Status = "In proseccing"
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 3,
                            CustomEventId = 3,
                            PlaceId = 3,
                            Status = "Completed"
                        });
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 500
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 250
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 100
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 75
                        });
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.Client", b =>
                {
                    b.HasOne("EntertaimentCenter.Application.Entities.DiscountCard", null)
                        .WithMany("Clients")
                        .HasForeignKey("DiscountCardId");

                    b.HasOne("EntertaimentCenter.Application.Entities.Order", null)
                        .WithMany("Clients")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.CustomEvent", b =>
                {
                    b.HasOne("EntertaimentCenter.Application.Entities.Order", null)
                        .WithMany("CustomEvents")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.Discount", b =>
                {
                    b.HasOne("EntertaimentCenter.Application.Entities.DiscountCard", null)
                        .WithMany("Discounts")
                        .HasForeignKey("DiscountCardId");
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.Place", b =>
                {
                    b.HasOne("EntertaimentCenter.Application.Entities.Order", null)
                        .WithMany("Places")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.DiscountCard", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Discounts");
                });

            modelBuilder.Entity("EntertaimentCenter.Application.Entities.Order", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("CustomEvents");

                    b.Navigation("Places");
                });
#pragma warning restore 612, 618
        }
    }
}
