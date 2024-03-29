﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_ef_core.DataContext;

#nullable disable

namespace dotnet_ef_core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("dotnet_ef_core.DataContext.AbsensiEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("AbsenEndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("absen_end-date");

                    b.Property<DateTime>("AbsenStartDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("absen_start-date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("emplooye_id");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("location");

                    b.HasKey("Id");

                    b.ToTable("tbl_absensi");
                });

            modelBuilder.Entity("dotnet_ef_core.DataContext.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_code");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("dotnet_ef_core.DataContext.CustomerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("customer_name");

                    b.HasKey("Id");

                    b.ToTable("tbl_customer");
                });

            modelBuilder.Entity("dotnet_ef_core.DataContext.EmployeeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("employee_name");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("position");

                    b.HasKey("Id");

                    b.ToTable("tbl_employee");
                });
#pragma warning restore 612, 618
        }
    }
}
