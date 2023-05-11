﻿// <auto-generated />
using System;
using AirportLastJourney;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ApplicationContext = AirportLastJourney.ApplicationContext;

#nullable disable

namespace AirportLastJourney.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230511192643_AddUser")]
    partial class AddUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AirportLastJourney.Models.Flights", b =>
                {
                    b.Property<int>("id_flight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_flight"));

                    b.Property<int>("countCrew")
                        .HasColumnType("int");

                    b.Property<int>("countPas")
                        .HasColumnType("int");

                    b.Property<DateTime>("eta")
                        .HasColumnType("datetime2");

                    b.Property<double>("priceCrew")
                        .HasColumnType("float");

                    b.Property<double>("pricePas")
                        .HasColumnType("float");

                    b.Property<double>("procDop")
                        .HasColumnType("float");

                    b.Property<double>("sum")
                        .HasColumnType("float");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("id_flight");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AirportLastJourney.Models.User", b =>
                {
                    b.Property<int>("id_user")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_user"));

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_user");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
