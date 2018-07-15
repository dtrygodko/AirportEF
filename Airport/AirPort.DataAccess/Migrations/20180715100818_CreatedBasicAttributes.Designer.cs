﻿// <auto-generated />
using System;
using Airport.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirPort.DataAccess.Migrations
{
    [DbContext(typeof(AirportDbContext))]
    [Migration("20180715100818_CreatedBasicAttributes")]
    partial class CreatedBasicAttributes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Airport.Domain.Entities.AirCraft", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<DateTime>("TimeSpan");

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("AirCrafts");
                });

            modelBuilder.Entity("Airport.Domain.Entities.AirCraftType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LoadCapacity");

                    b.Property<string>("Model");

                    b.Property<int>("Seats");

                    b.HasKey("Id");

                    b.ToTable("AirCraftTypes");
                });

            modelBuilder.Entity("Airport.Domain.Entities.Crew", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("PilotId");

                    b.HasKey("Id");

                    b.HasIndex("PilotId");

                    b.ToTable("Crews");
                });

            modelBuilder.Entity("Airport.Domain.Entities.Departure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AirCraftId");

                    b.Property<Guid>("CrewId");

                    b.Property<DateTime>("DepartureDate");

                    b.Property<int>("FlightNumber");

                    b.HasKey("Id");

                    b.ToTable("Departures");
                });

            modelBuilder.Entity("Airport.Domain.Entities.Flight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeparturePoint");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<string>("Destination");

                    b.Property<int>("Number");

                    b.Property<DateTime>("TimeOfArrival");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Airport.Domain.Entities.Pilot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int>("Experience");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Pilots");
                });

            modelBuilder.Entity("Airport.Domain.Entities.Stewardess", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CrewId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.HasIndex("CrewId");

                    b.ToTable("Stewardesses");
                });

            modelBuilder.Entity("Airport.Domain.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("FlightId");

                    b.Property<int>("FlightNumber");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Airport.Domain.Entities.AirCraft", b =>
                {
                    b.HasOne("Airport.Domain.Entities.AirCraftType", "AirCraftType")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Airport.Domain.Entities.Crew", b =>
                {
                    b.HasOne("Airport.Domain.Entities.Pilot", "Pilot")
                        .WithMany()
                        .HasForeignKey("PilotId");
                });

            modelBuilder.Entity("Airport.Domain.Entities.Stewardess", b =>
                {
                    b.HasOne("Airport.Domain.Entities.Crew")
                        .WithMany("Stewardesses")
                        .HasForeignKey("CrewId");
                });

            modelBuilder.Entity("Airport.Domain.Entities.Ticket", b =>
                {
                    b.HasOne("Airport.Domain.Entities.Flight", "Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightId");
                });
#pragma warning restore 612, 618
        }
    }
}