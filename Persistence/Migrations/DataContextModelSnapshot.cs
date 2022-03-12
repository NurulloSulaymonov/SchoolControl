﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Domain.Entities.AccountInformation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("BankAccountNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BankName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("AccountInformation");
                });

            modelBuilder.Entity("Domain.Entities.Attendance", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AttendanceType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT")
                        .HasMaxLength(400);

                    b.Property<int>("Date")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mark")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("Attandences");
                });

            modelBuilder.Entity("Domain.Entities.Class", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FinishedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StaffId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Domain.Entities.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("StaffId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Domain.Entities.ParentInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("FatherOccupation")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("FathersEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("FathersName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("FathersPhone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MotherOccupation")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("MothersEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("MothersName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("MothersPhone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("ParentInfos");
                });

            modelBuilder.Entity("Domain.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Domain.Entities.Staff", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("Phone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StaffCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StaffType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Domain.Entities.StaffInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdressLine1")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("AdressLine2")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("PostalCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StaffId")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("StaffInfos");
                });

            modelBuilder.Entity("Domain.Entities.StaffWorkingHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyAdress")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("CompanyName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("DepartamentId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCurrentCompany")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCurrentWorking")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Qualification")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("StaffId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.HasIndex("StaffId");

                    b.ToTable("StaffWorkingHistories");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("FathersName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("MothersName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("SectionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Domain.Entities.StudentClass", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClassId")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentClasses");
                });

            modelBuilder.Entity("Domain.Entities.StudentInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("AttendedSchool")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("InteresOrtHobby")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<bool>("LoginRequired")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NoteAboutStudent")
                        .HasColumnType("TEXT")
                        .HasMaxLength(400);

                    b.Property<string>("ParentEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<bool>("ParentLoginRequired")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParentPhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostalCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentPhoto")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentInfos");
                });

            modelBuilder.Entity("Domain.Entities.Subject", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Entities.AccountInformation", b =>
                {
                    b.HasOne("Domain.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Domain.Entities.Attendance", b =>
                {
                    b.HasOne("Domain.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("Domain.Entities.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Domain.Entities.Class", b =>
                {
                    b.HasOne("Domain.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId");

                    b.HasOne("Domain.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("Domain.Entities.Department", b =>
                {
                    b.HasOne("Domain.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId");
                });

            modelBuilder.Entity("Domain.Entities.ParentInfo", b =>
                {
                    b.HasOne("Domain.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Domain.Entities.StaffInfo", b =>
                {
                    b.HasOne("Domain.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId");
                });

            modelBuilder.Entity("Domain.Entities.StaffWorkingHistory", b =>
                {
                    b.HasOne("Domain.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartamentId");

                    b.HasOne("Domain.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId");
                });

            modelBuilder.Entity("Domain.Entities.Student", b =>
                {
                    b.HasOne("Domain.Entities.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.StudentClass", b =>
                {
                    b.HasOne("Domain.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("Domain.Entities.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Domain.Entities.StudentInfo", b =>
                {
                    b.HasOne("Domain.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
