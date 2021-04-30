﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReFitPatientCore.DatabaseAccess;

namespace ReFitPatientCore.Migrations
{
    [DbContext(typeof(PatientContext))]
    partial class PatientContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReFitPatientCore.Domain.Exercise", b =>
                {
                    b.Property<int>("ExerciseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ExerciseLink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ExercisePackageID")
                        .HasColumnType("int");

                    b.Property<int>("Repetitions")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("ExerciseID");

                    b.HasIndex("ExercisePackageID");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("ReFitPatientCore.Domain.ExercisePackage", b =>
                {
                    b.Property<int>("ExercisePackageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PackageName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PatientSSN")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ExercisePackageID");

                    b.HasIndex("PatientSSN");

                    b.ToTable("ExercisePackages");
                });

            modelBuilder.Entity("ReFitPatientCore.Domain.Journal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BendAngle")
                        .HasMaxLength(10)
                        .HasColumnType("float");

                    b.Property<string>("GeneralComment")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("JournalType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicine")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<double>("PainScale")
                        .HasMaxLength(10)
                        .HasColumnType("float");

                    b.Property<string>("PatientSSN")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("PatientSSN");

                    b.ToTable("Journals");
                });

            modelBuilder.Entity("ReFitPatientCore.Domain.Patient", b =>
                {
                    b.Property<string>("SSN")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("SSN");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ReFitPatientCore.Domain.Exercise", b =>
                {
                    b.HasOne("ReFitPatientCore.Domain.ExercisePackage", null)
                        .WithMany("ExerciseList")
                        .HasForeignKey("ExercisePackageID");
                });

            modelBuilder.Entity("ReFitPatientCore.Domain.ExercisePackage", b =>
                {
                    b.HasOne("ReFitPatientCore.Domain.Patient", null)
                        .WithMany("PackageList")
                        .HasForeignKey("PatientSSN");
                });

            modelBuilder.Entity("ReFitPatientCore.Domain.Journal", b =>
                {
                    b.HasOne("ReFitPatientCore.Domain.Patient", null)
                        .WithMany("JournalList")
                        .HasForeignKey("PatientSSN");
                });

            modelBuilder.Entity("ReFitPatientCore.Domain.ExercisePackage", b =>
                {
                    b.Navigation("ExerciseList");
                });

            modelBuilder.Entity("ReFitPatientCore.Domain.Patient", b =>
                {
                    b.Navigation("JournalList");

                    b.Navigation("PackageList");
                });
#pragma warning restore 612, 618
        }
    }
}
