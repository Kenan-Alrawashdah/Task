﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.AppContext;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221028201843_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeTaskEntity", b =>
                {
                    b.Property<int>("EmployeesID")
                        .HasColumnType("int");

                    b.Property<int>("TasksEntityID")
                        .HasColumnType("int");

                    b.HasKey("EmployeesID", "TasksEntityID");

                    b.HasIndex("TasksEntityID");

                    b.ToTable("EmployeeTaskEntity");

                    b.HasData(
                        new
                        {
                            EmployeesID = 1,
                            TasksEntityID = 1
                        },
                        new
                        {
                            EmployeesID = 2,
                            TasksEntityID = 1
                        },
                        new
                        {
                            EmployeesID = 3,
                            TasksEntityID = 1
                        },
                        new
                        {
                            EmployeesID = 4,
                            TasksEntityID = 1
                        },
                        new
                        {
                            EmployeesID = 1,
                            TasksEntityID = 2
                        },
                        new
                        {
                            EmployeesID = 3,
                            TasksEntityID = 2
                        },
                        new
                        {
                            EmployeesID = 4,
                            TasksEntityID = 2
                        },
                        new
                        {
                            EmployeesID = 2,
                            TasksEntityID = 3
                        },
                        new
                        {
                            EmployeesID = 3,
                            TasksEntityID = 3
                        },
                        new
                        {
                            EmployeesID = 1,
                            TasksEntityID = 4
                        },
                        new
                        {
                            EmployeesID = 1,
                            TasksEntityID = 5
                        },
                        new
                        {
                            EmployeesID = 2,
                            TasksEntityID = 5
                        },
                        new
                        {
                            EmployeesID = 3,
                            TasksEntityID = 6
                        },
                        new
                        {
                            EmployeesID = 4,
                            TasksEntityID = 6
                        },
                        new
                        {
                            EmployeesID = 1,
                            TasksEntityID = 7
                        },
                        new
                        {
                            EmployeesID = 3,
                            TasksEntityID = 8
                        },
                        new
                        {
                            EmployeesID = 4,
                            TasksEntityID = 8
                        },
                        new
                        {
                            EmployeesID = 2,
                            TasksEntityID = 9
                        },
                        new
                        {
                            EmployeesID = 3,
                            TasksEntityID = 9
                        },
                        new
                        {
                            EmployeesID = 1,
                            TasksEntityID = 10
                        });
                });

            modelBuilder.Entity("Persistence.Entities.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(8794),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kenan",
                            ImageUrl = "/Images/em1.png",
                            LastName = "Rawashdah",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9274),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Noor",
                            ImageUrl = "/Images/emp2.jpg",
                            LastName = "Rawashdah",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 3,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9276),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Zaher",
                            ImageUrl = "/Images/emp5.png",
                            LastName = "Rawashdah",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 4,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9278),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mohamad",
                            LastName = "Rawashdah",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Persistence.Entities.TaskEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal?>("ActualCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("TotalBudget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ParentId");

                    b.ToTable("TasksEntitie");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ActualCost = 7000m,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9344),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test test",
                            EndDate = new DateTime(2022, 11, 2, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9354),
                            StartDate = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9350),
                            Status = 1,
                            Title = "Task1",
                            TotalBudget = 10000m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            ActualCost = 4000m,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9357),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test test",
                            EndDate = new DateTime(2022, 11, 7, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9361),
                            StartDate = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9359),
                            Status = 0,
                            Title = "Task2",
                            TotalBudget = 11000m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 3,
                            ActualCost = 5000m,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9362),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test test",
                            EndDate = new DateTime(2022, 11, 12, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9365),
                            StartDate = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9364),
                            Status = 1,
                            Title = "Task3",
                            TotalBudget = 8000m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 4,
                            ActualCost = 2000m,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9366),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test test",
                            EndDate = new DateTime(2022, 11, 17, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9370),
                            StartDate = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9369),
                            Status = 2,
                            Title = "Task4",
                            TotalBudget = 7000m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 5,
                            ActualCost = 3000m,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9371),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test test",
                            EndDate = new DateTime(2022, 11, 7, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9374),
                            ParentId = 1,
                            StartDate = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9373),
                            Status = 1,
                            Title = "Sub1",
                            TotalBudget = 6000m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 6,
                            ActualCost = 2500m,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9375),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test test",
                            EndDate = new DateTime(2022, 11, 2, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9378),
                            ParentId = 1,
                            StartDate = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9377),
                            Status = 2,
                            Title = "Sub2",
                            TotalBudget = 4000m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 7,
                            ActualCost = 500m,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9384),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test test",
                            EndDate = new DateTime(2022, 10, 31, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9387),
                            ParentId = 1,
                            StartDate = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9386),
                            Status = 0,
                            Title = "Sub3",
                            TotalBudget = 1000m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 8,
                            ActualCost = 4000m,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9411),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test test",
                            EndDate = new DateTime(2022, 11, 3, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9415),
                            ParentId = 2,
                            StartDate = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9413),
                            Status = 0,
                            Title = "Sub1",
                            TotalBudget = 7000m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 9,
                            ActualCost = 2000m,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9416),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test test",
                            EndDate = new DateTime(2022, 10, 31, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9419),
                            ParentId = 2,
                            StartDate = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9418),
                            Status = 1,
                            Title = "Sub2",
                            TotalBudget = 4000m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 10,
                            ActualCost = 3000m,
                            CreateAt = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9421),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "test test",
                            EndDate = new DateTime(2022, 10, 29, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9424),
                            ParentId = 4,
                            StartDate = new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9423),
                            Status = 2,
                            Title = "Sub1",
                            TotalBudget = 7000m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EmployeeTaskEntity", b =>
                {
                    b.HasOne("Persistence.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.TaskEntity", null)
                        .WithMany()
                        .HasForeignKey("TasksEntityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Persistence.Entities.TaskEntity", b =>
                {
                    b.HasOne("Persistence.Entities.TaskEntity", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Persistence.Entities.TaskEntity", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
