﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Context;

#nullable disable

namespace WebApp.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20240606173234_AddedTables")]
    partial class AddedTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApp.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDoctor"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdDoctor")
                        .HasName("Doctor_PK");

                    b.ToTable("Doctor", (string)null);

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "jk@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMedicament"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdMedicament")
                        .HasName("Medicament_PK");

                    b.ToTable("Medicament", (string)null);

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "AA",
                            Name = "AA",
                            Type = "A"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "BB",
                            Name = "BB",
                            Type = "B"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPatient"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdPatient")
                        .HasName("Patient_PK");

                    b.ToTable("Patient", (string)null);

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(2024, 6, 6, 19, 32, 34, 490, DateTimeKind.Local).AddTicks(5700),
                            FirstName = "Piotr",
                            LastName = "Nowak"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrescription"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescription", (string)null);

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2024, 6, 6, 19, 32, 34, 491, DateTimeKind.Local).AddTicks(3055),
                            DueDate = new DateTime(2024, 6, 6, 19, 32, 34, 491, DateTimeKind.Local).AddTicks(3072),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2024, 6, 6, 19, 32, 34, 491, DateTimeKind.Local).AddTicks(3074),
                            DueDate = new DateTime(2024, 6, 6, 19, 32, 34, 491, DateTimeKind.Local).AddTicks(3075),
                            IdDoctor = 1,
                            IdPatient = 1
                        });
                });

            modelBuilder.Entity("WebApp.Models.PrescriptionMedicament", b =>
                {
                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription", "IdMedicament")
                        .HasName("PresMed_PK");

                    b.HasIndex("IdMedicament");

                    b.ToTable("Prescription_Medicament", (string)null);

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            IdMedicament = 1,
                            Details = "2x a day"
                        },
                        new
                        {
                            IdPrescription = 2,
                            IdMedicament = 1,
                            Details = "4x a day",
                            Dose = 100
                        });
                });

            modelBuilder.Entity("WebApp.Models.Prescription", b =>
                {
                    b.HasOne("WebApp.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Prescription_Doctor");

                    b.HasOne("WebApp.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Prescription_Patient");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("WebApp.Models.PrescriptionMedicament", b =>
                {
                    b.HasOne("WebApp.Models.Medicament", "Medicament")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("PresMed_Medicament");

                    b.HasOne("WebApp.Models.Prescription", "Prescription")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("PresMed_Prescription");

                    b.Navigation("Medicament");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("WebApp.Models.Doctor", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("WebApp.Models.Medicament", b =>
                {
                    b.Navigation("PrescriptionMedicaments");
                });

            modelBuilder.Entity("WebApp.Models.Patient", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("WebApp.Models.Prescription", b =>
                {
                    b.Navigation("PrescriptionMedicaments");
                });
#pragma warning restore 612, 618
        }
    }
}
