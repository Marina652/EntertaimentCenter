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
    [Migration("20221211231528_Migration.1")]
    partial class Migration1
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("DiscountCardId");

                    b.HasIndex("OrderId");

                    b.ToTable("Clients");
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

                    b.HasKey("Id");

                    b.ToTable("Orders");
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
