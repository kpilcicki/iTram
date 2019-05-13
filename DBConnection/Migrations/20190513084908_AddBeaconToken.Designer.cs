﻿// <auto-generated />
using System;
using DBConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DBConnection.Migrations
{
    [DbContext(typeof(TramContext))]
    [Migration("20190513084908_AddBeaconToken")]
    partial class AddBeaconToken
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DBConnection.Entities.BeaconToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Token");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidThrough");

                    b.HasKey("Id");

                    b.ToTable("BeaconTokens");
                });

            modelBuilder.Entity("DBConnection.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.Accelerometer", b =>
                {
                    b.Property<int>("Id");

                    b.Property<double?>("Ax");

                    b.Property<double?>("Ay");

                    b.Property<double?>("Az");

                    b.HasKey("Id");

                    b.ToTable("SensorsReadings");
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.GameRotation", b =>
                {
                    b.Property<int>("Id");

                    b.Property<double?>("GameRotationVecX");

                    b.Property<double?>("GameRotationVecY");

                    b.Property<double?>("GameRotationVecZ");

                    b.HasKey("Id");

                    b.ToTable("SensorsReadings");
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.GeomagneticRotation", b =>
                {
                    b.Property<int>("Id");

                    b.Property<double?>("GeomagneticRotationVecX");

                    b.Property<double?>("GeomagneticRotationVecY");

                    b.Property<double?>("GeomagneticRotationVecZ");

                    b.HasKey("Id");

                    b.ToTable("SensorsReadings");
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.Gravity", b =>
                {
                    b.Property<int>("Id");

                    b.Property<double?>("GravityX");

                    b.Property<double?>("GravityY");

                    b.Property<double?>("GravityZ");

                    b.HasKey("Id");

                    b.ToTable("SensorsReadings");
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.Gyroscope", b =>
                {
                    b.Property<int>("Id");

                    b.Property<double?>("Gx");

                    b.Property<double?>("Gy");

                    b.Property<double?>("Gz");

                    b.HasKey("Id");

                    b.ToTable("SensorsReadings");
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.Location", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.HasKey("Id");

                    b.ToTable("SensorsReadings");
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.MagneticField", b =>
                {
                    b.Property<int>("Id");

                    b.Property<double?>("MagneticFieldX");

                    b.Property<double?>("MagneticFieldY");

                    b.Property<double?>("MagneticFieldZ");

                    b.HasKey("Id");

                    b.ToTable("SensorsReadings");
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.RotationVec", b =>
                {
                    b.Property<int>("Id");

                    b.Property<double?>("RotationVecX");

                    b.Property<double?>("RotationVecY");

                    b.Property<double?>("RotationVecZ");

                    b.HasKey("Id");

                    b.ToTable("SensorsReadings");
                });

            modelBuilder.Entity("DBConnection.Entities.SensorsReading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BatteryLevel");

                    b.Property<bool?>("ImInTram");

                    b.Property<double?>("Light");

                    b.Property<string>("NearestBeaconId");

                    b.Property<float?>("NumberOfSteps");

                    b.Property<double?>("Pressure");

                    b.Property<double?>("Proximity");

                    b.Property<float?>("StepDetector");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SensorsReadings");
                });

            modelBuilder.Entity("DBConnection.Entities.Tram", b =>
                {
                    b.Property<int>("TramId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<int>("Number");

                    b.HasKey("TramId");

                    b.HasIndex("CityId");

                    b.ToTable("Trams");
                });

            modelBuilder.Entity("DBConnection.Entities.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsFinished");

                    b.Property<float>("Length");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("TramId");

                    b.Property<int>("UserId");

                    b.HasKey("TripId");

                    b.HasIndex("TramId");

                    b.HasIndex("UserId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("DBConnection.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Lastname");

                    b.Property<string>("Name");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.Accelerometer", b =>
                {
                    b.HasOne("DBConnection.Entities.SensorsReading", "Reading")
                        .WithOne("Accelerometer")
                        .HasForeignKey("DBConnection.Entities.Sensors.Accelerometer", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.GameRotation", b =>
                {
                    b.HasOne("DBConnection.Entities.SensorsReading", "Reading")
                        .WithOne("GameRotation")
                        .HasForeignKey("DBConnection.Entities.Sensors.GameRotation", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.GeomagneticRotation", b =>
                {
                    b.HasOne("DBConnection.Entities.SensorsReading", "Reading")
                        .WithOne("GeomagneticRotation")
                        .HasForeignKey("DBConnection.Entities.Sensors.GeomagneticRotation", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.Gravity", b =>
                {
                    b.HasOne("DBConnection.Entities.SensorsReading", "Reading")
                        .WithOne("Gravity")
                        .HasForeignKey("DBConnection.Entities.Sensors.Gravity", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.Gyroscope", b =>
                {
                    b.HasOne("DBConnection.Entities.SensorsReading", "Reading")
                        .WithOne("Gyroscope")
                        .HasForeignKey("DBConnection.Entities.Sensors.Gyroscope", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.Location", b =>
                {
                    b.HasOne("DBConnection.Entities.SensorsReading", "Reading")
                        .WithOne("Location")
                        .HasForeignKey("DBConnection.Entities.Sensors.Location", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.MagneticField", b =>
                {
                    b.HasOne("DBConnection.Entities.SensorsReading", "Reading")
                        .WithOne("MagneticField")
                        .HasForeignKey("DBConnection.Entities.Sensors.MagneticField", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBConnection.Entities.Sensors.RotationVec", b =>
                {
                    b.HasOne("DBConnection.Entities.SensorsReading", "Reading")
                        .WithOne("RotationVec")
                        .HasForeignKey("DBConnection.Entities.Sensors.RotationVec", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBConnection.Entities.SensorsReading", b =>
                {
                    b.HasOne("DBConnection.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBConnection.Entities.Tram", b =>
                {
                    b.HasOne("DBConnection.Entities.City", "City")
                        .WithMany("Trams")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBConnection.Entities.Trip", b =>
                {
                    b.HasOne("DBConnection.Entities.Tram", "Tram")
                        .WithMany()
                        .HasForeignKey("TramId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DBConnection.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
