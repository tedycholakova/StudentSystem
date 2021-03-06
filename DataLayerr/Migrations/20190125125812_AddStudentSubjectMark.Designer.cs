﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.Data;

namespace DataLayer.Migrations
{
    [DbContext(typeof(StudentSystemDbContext))]
    [Migration("20190125125812_AddStudentSubjectMark")]
    partial class AddStudentSubjectMark
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Models.StudentSubjectMark", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("SubjectId");

                    b.Property<int>("MarkId");

                    b.HasKey("StudentId", "SubjectId", "MarkId");

                    b.HasAlternateKey("MarkId", "StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubjectMark");
                });

            modelBuilder.Entity("StudentSystem.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Street");

                    b.Property<int>("StudentId");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("StudentSystem.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("StudentSystem.Models.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId");

                    b.Property<string>("Name");

                    b.Property<int?>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("StudentSystem.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentSystem.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("StudentSystem.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("DataLayer.Models.StudentSubjectMark", b =>
                {
                    b.HasOne("StudentSystem.Models.Mark", "Mark")
                        .WithMany("StudentSubjectMarks")
                        .HasForeignKey("MarkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentSystem.Models.Student", "Student")
                        .WithMany("StudentSubjectMarks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentSystem.Models.Subject", "Subject")
                        .WithMany("StudentSubjectMarks")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentSystem.Models.Address", b =>
                {
                    b.HasOne("StudentSystem.Models.Student", "Student")
                        .WithOne("Address")
                        .HasForeignKey("StudentSystem.Models.Address", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentSystem.Models.Mark", b =>
                {
                    b.HasOne("StudentSystem.Models.Course")
                        .WithMany("Marks")
                        .HasForeignKey("CourseId");

                    b.HasOne("StudentSystem.Models.Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("StudentSystem.Models.Student", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("StudentSystem.Models.Subject", b =>
                {
                    b.HasOne("StudentSystem.Models.Student")
                        .WithMany("Subjects")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("StudentSystem.Models.Teacher", b =>
                {
                    b.HasOne("StudentSystem.Models.Subject")
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectId");
                });
#pragma warning restore 612, 618
        }
    }
}
