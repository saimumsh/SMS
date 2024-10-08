﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMS.data.SMS_Data;

#nullable disable

namespace SMS.data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.3.24172.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SMS.core.Models.Attendence", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Ispresent")
                        .HasColumnType("bit");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentID1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("StudentID1");

                    b.ToTable("Attendents");
                });

            modelBuilder.Entity("SMS.core.Models.ClassLevel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TeacherId");

                    b.ToTable("ClassLevels");
                });

            modelBuilder.Entity("SMS.core.Models.Designation", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TeacherId");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("SMS.core.Models.Exam", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SubjectID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ClassID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("SMS.core.Models.ResultSheet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MarksObtained")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ExamID");

                    b.HasIndex("StudentID");

                    b.ToTable("ResultsSheets");
                });

            modelBuilder.Entity("SMS.core.Models.Student", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ClassLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ClassLevelId");

                    b.HasIndex("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SMS.core.Models.Subject", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassLevelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ResultSheetID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubjectCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TeacherID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ClassLevelID");

                    b.HasIndex("ResultSheetID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SMS.core.Models.Teacher", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SMS.core.Models.Attendence", b =>
                {
                    b.HasOne("SMS.core.Models.Student", "Student")
                        .WithMany("Attendence")
                        .HasForeignKey("StudentID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SMS.core.Models.ClassLevel", b =>
                {
                    b.HasOne("SMS.core.Models.Teacher", "Teacher")
                        .WithMany("Classes")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SMS.core.Models.Designation", b =>
                {
                    b.HasOne("SMS.core.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SMS.core.Models.Exam", b =>
                {
                    b.HasOne("SMS.core.Models.ClassLevel", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.core.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SMS.core.Models.ResultSheet", b =>
                {
                    b.HasOne("SMS.core.Models.Exam", "Exam")
                        .WithMany("Results")
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.core.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SMS.core.Models.Student", b =>
                {
                    b.HasOne("SMS.core.Models.ClassLevel", "ClassLevel")
                        .WithMany()
                        .HasForeignKey("ClassLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.core.Models.Student", null)
                        .WithMany("Students")
                        .HasForeignKey("StudentID");

                    b.Navigation("ClassLevel");
                });

            modelBuilder.Entity("SMS.core.Models.Subject", b =>
                {
                    b.HasOne("SMS.core.Models.ClassLevel", "ClassLevel")
                        .WithMany()
                        .HasForeignKey("ClassLevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.core.Models.ResultSheet", "ResultSheet")
                        .WithMany()
                        .HasForeignKey("ResultSheetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.core.Models.Teacher", null)
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherID");

                    b.Navigation("ClassLevel");

                    b.Navigation("ResultSheet");
                });

            modelBuilder.Entity("SMS.core.Models.Exam", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("SMS.core.Models.Student", b =>
                {
                    b.Navigation("Attendence");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("SMS.core.Models.Teacher", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
