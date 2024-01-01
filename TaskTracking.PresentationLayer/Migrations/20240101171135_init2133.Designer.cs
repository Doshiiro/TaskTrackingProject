﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskTracking.PresentationLayer.DAL;

namespace TaskTracking.PresentationLayer.Migrations
{
    [DbContext(typeof(TaskTrackingContext))]
    [Migration("20240101171135_init2133")]
    partial class init2133
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.CalendarEntity", b =>
                {
                    b.Property<int>("calender_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("emp_ID")
                        .HasColumnType("int");

                    b.Property<string>("events")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("calender_ID");

                    b.HasIndex("emp_ID");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.Department", b =>
                {
                    b.Property<int>("DepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.Employee", b =>
                {
                    b.Property<int>("emp_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Access")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("emp_ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.ProjectEntity", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("projectEmp_ID")
                        .HasColumnType("int");

                    b.HasKey("ProjectID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("projectEmp_ID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.ProjectEvent", b =>
                {
                    b.Property<int>("ProjectEventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Employeesemp_ID")
                        .HasColumnType("int");

                    b.Property<string>("EventDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectFK")
                        .HasColumnType("int");

                    b.Property<int>("projectEmp_ID")
                        .HasColumnType("int");

                    b.HasKey("ProjectEventID");

                    b.HasIndex("Employeesemp_ID");

                    b.HasIndex("ProjectFK");

                    b.ToTable("ProjectEvent");
                });

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.CalendarEntity", b =>
                {
                    b.HasOne("TaskTracking.PresentationLayer.Entities.Employee", "Employees")
                        .WithMany("Calendars")
                        .HasForeignKey("emp_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.Employee", b =>
                {
                    b.HasOne("TaskTracking.PresentationLayer.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.ProjectEntity", b =>
                {
                    b.HasOne("TaskTracking.PresentationLayer.Entities.Department", "Department")
                        .WithMany("Projects")
                        .HasForeignKey("DepartmentID");

                    b.HasOne("TaskTracking.PresentationLayer.Entities.Employee", "Employees")
                        .WithMany("Projects")
                        .HasForeignKey("projectEmp_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.ProjectEvent", b =>
                {
                    b.HasOne("TaskTracking.PresentationLayer.Entities.Employee", "Employees")
                        .WithMany("ProjeEvent")
                        .HasForeignKey("Employeesemp_ID");

                    b.HasOne("TaskTracking.PresentationLayer.Entities.ProjectEntity", "projectEntity")
                        .WithMany("ProjeEvent")
                        .HasForeignKey("ProjectFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}