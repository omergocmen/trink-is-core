﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221218184624_v6")]
    partial class v6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("OperationClaimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OperationClaimId"));

                    b.Property<string>("OperationClaimName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OperationClaimId");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("UserOperationClaimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserOperationClaimId"));

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserOperationClaimId");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationId"));

                    b.Property<int>("CandidateCommunicationInfo")
                        .HasColumnType("int");

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("JobAnnouncementId")
                        .HasColumnType("int");

                    b.HasKey("ApplicationId");

                    b.HasIndex("CandidateId");

                    b.HasIndex("JobAnnouncementId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entities.Concrete.JobAnnouncement", b =>
                {
                    b.Property<int>("JobAnnouncementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobAnnouncementId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("EmployerId")
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("JobAnnouncementId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EmployerId");

                    b.ToTable("JobAnnouncements");
                });

            modelBuilder.Entity("Entities.Concrete.Candidate", b =>
                {
                    b.HasBaseType("Core.Entities.Concrete.User");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(15)");

                    b.ToTable("Candidates", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.Employer", b =>
                {
                    b.HasBaseType("Core.Entities.Concrete.User");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TaxNumber")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WebAddress")
                        .HasColumnType("nvarchar(100)");

                    b.ToTable("Employers", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.HasOne("Core.Entities.Concrete.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Entities.Concrete.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Application", b =>
                {
                    b.HasOne("Entities.Concrete.Candidate", "Candidate")
                        .WithMany("Applications")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.JobAnnouncement", "JobAnnouncement")
                        .WithMany("Applications")
                        .HasForeignKey("JobAnnouncementId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("JobAnnouncement");
                });

            modelBuilder.Entity("Entities.Concrete.JobAnnouncement", b =>
                {
                    b.HasOne("Entities.Concrete.Category", "Category")
                        .WithMany("JobAnnouncements")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Employer", "Employer")
                        .WithMany("JobAnnouncements")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Category");

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("Entities.Concrete.Candidate", b =>
                {
                    b.HasOne("Core.Entities.Concrete.User", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concrete.Candidate", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Employer", b =>
                {
                    b.HasOne("Core.Entities.Concrete.User", null)
                        .WithOne()
                        .HasForeignKey("Entities.Concrete.Employer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Navigation("JobAnnouncements");
                });

            modelBuilder.Entity("Entities.Concrete.JobAnnouncement", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("Entities.Concrete.Candidate", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("Entities.Concrete.Employer", b =>
                {
                    b.Navigation("JobAnnouncements");
                });
#pragma warning restore 612, 618
        }
    }
}
