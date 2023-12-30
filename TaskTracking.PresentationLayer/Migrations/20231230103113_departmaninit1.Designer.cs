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
    [Migration("20231230103113_departmaninit1")]
    partial class departmaninit1
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

                    b.ToTable("Department");
                });

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.Employee", b =>
                {
                    b.Property<int>("emp_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Access")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentID")
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

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("projectEmp_ID")
                        .HasColumnType("int");

                    b.HasKey("ProjectID");

                    b.HasIndex("projectEmp_ID");

                    b.ToTable("Projects");
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
                        .HasForeignKey("DepartmentID");
                });

            modelBuilder.Entity("TaskTracking.PresentationLayer.Entities.ProjectEntity", b =>
                {
                    b.HasOne("TaskTracking.PresentationLayer.Entities.Employee", "Employees")
                        .WithMany("Projects")
                        .HasForeignKey("projectEmp_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
