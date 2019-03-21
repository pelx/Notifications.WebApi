﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Notifications.WebApi.Data;

namespace Notifications.WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190320183320_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Notifications.WebApi.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AppointmentDate");

                    b.Property<bool>("Canceled");

                    b.Property<string>("OrganisationName");

                    b.Property<string>("Reason");

                    b.Property<Guid>("UserRefId");

                    b.HasKey("AppointmentId");

                    b.HasIndex("UserRefId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Notifications.WebApi.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AppointmentDateTime");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("OrganisationName")
                        .IsRequired();

                    b.Property<string>("Reason")
                        .IsRequired();

                    b.Property<Guid>("UserRefId");

                    b.HasKey("NotificationId");

                    b.HasIndex("UserRefId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Notifications.WebApi.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("83649614-70c9-46f2-8bb6-cd8dba69c70d"),
                            UserName = "Mubeen"
                        },
                        new
                        {
                            UserId = new Guid("2714997f-855b-4535-90a2-d1c6ac51d602"),
                            UserName = "Tahir"
                        },
                        new
                        {
                            UserId = new Guid("43308171-dbdb-4e81-901c-eb939f792f40"),
                            UserName = "Cheema"
                        });
                });

            modelBuilder.Entity("Notifications.WebApi.Models.Appointment", b =>
                {
                    b.HasOne("Notifications.WebApi.Models.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Notifications.WebApi.Models.Notification", b =>
                {
                    b.HasOne("Notifications.WebApi.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
