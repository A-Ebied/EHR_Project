﻿// <auto-generated />
using System;
using EHR_API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EHRAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EHR_API.Entities.Models.Governorate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Governorates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(4995),
                            Title = "القاهرة",
                            UpdateddAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5010)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5012),
                            Title = "الجيزة",
                            UpdateddAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5012)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5013),
                            Title = "مطروح",
                            UpdateddAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5014)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5015),
                            Title = "شمال سيناء",
                            UpdateddAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5016)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5016),
                            Title = "الشرقية",
                            UpdateddAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5017)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5018),
                            Title = "الدقهلية",
                            UpdateddAt = new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5018)
                        });
                });

            modelBuilder.Entity("EHR_API.Entities.Models.HealthFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDataId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubordinateTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasAlternateKey("RegistrationDataId")
                        .HasName("AlternateKey_RegistrationDataId");

                    b.HasIndex("GovernorateId");

                    b.ToTable("HealthFacilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Address1",
                            CreatedAt = new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3870),
                            Description = "Description1",
                            Email = "m@gmail.com",
                            GovernorateId = 1,
                            Phone1 = "01123456878",
                            Phone2 = "",
                            Phone3 = "",
                            RegistrationDataId = "12345678912345",
                            SubordinateTo = "المؤسسة العسكرية",
                            Title = "المستشفى العسكري بالشرقية",
                            Type = "مستشفى عسكري",
                            UpdateddAt = new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3887)
                        },
                        new
                        {
                            Id = 2,
                            Address = "Address2",
                            CreatedAt = new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3889),
                            Description = "Description2",
                            Email = "a@gmail.com",
                            GovernorateId = 1,
                            Phone1 = "01122456878",
                            Phone2 = "",
                            Phone3 = "",
                            RegistrationDataId = "12345678902341",
                            SubordinateTo = "وزارة الصحة",
                            Title = "المستشفى العام بالعريش",
                            Type = "مستشفى عام",
                            UpdateddAt = new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3890)
                        },
                        new
                        {
                            Id = 3,
                            Address = "Address3",
                            CreatedAt = new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3892),
                            Description = "Description3",
                            Email = "j@gmail.com",
                            GovernorateId = 1,
                            Phone1 = "01123416878",
                            Phone2 = "",
                            Phone3 = "",
                            RegistrationDataId = "12345678921345",
                            SubordinateTo = "مستشفيات الجامعة",
                            Title = "مستشفى الجامعة بالزقازيق",
                            Type = "مستشفى جامعي",
                            UpdateddAt = new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3892)
                        });
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.MedicalData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DNAImageResultUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MedicalData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.MedicalTeam", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalSpecialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MedicalTeam");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.PersonalData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgeGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmergencyPhone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyPhone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<int>("NumOfChildren")
                        .HasColumnType("int");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GovernorateId");

                    b.ToTable("PersonalData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.RegistrationData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "12345678912345",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d426659e-3f48-4f1d-84ac-1d2d59f84f08",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "k@gmail.com",
                            EmailConfirmed = false,
                            FullName = "أحمد محمد كمال",
                            LockoutEnabled = false,
                            Nationality = "مصري",
                            NormalizedEmail = "K@GMAIL.COM",
                            NormalizedUserName = "@KAMAL123",
                            PasswordHash = "AQAAAAIAAYagAAAAEMWk7G7dh2C0JBTFiOQfUhZG3W0op2TeoNW+IwsaiS7tdwcCT1dosnriB9k6eQVB5w==",
                            PhoneNumber = "01234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b8156f0e-78b0-48cf-a5b4-276e92a6d274",
                            TwoFactorEnabled = false,
                            UpdateddAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "@Kamal123"
                        },
                        new
                        {
                            Id = "12345678902341",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5f37d68b-49b9-4295-9359-66174414e969",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "A@gmail.com",
                            EmailConfirmed = false,
                            FullName = "أحمد محمد أحمد",
                            LockoutEnabled = false,
                            Nationality = "مصري",
                            NormalizedEmail = "A@GMAIL.COM",
                            NormalizedUserName = "@AHMED123",
                            PasswordHash = "AQAAAAIAAYagAAAAEN943JIHW+c1IoZZrKoaSSFxucTKlprl2SrvuckRva26nIrsOnhdnJ2BJogFmCD0OQ==",
                            PhoneNumber = "",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3dad73e2-99f5-406a-8de6-a75d6fed3788",
                            TwoFactorEnabled = false,
                            UpdateddAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "@Ahmed123"
                        },
                        new
                        {
                            Id = "12345678921345",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "80b8b408-4577-46cc-a3a2-5106bb8f8dd5",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "M@gmail.com",
                            EmailConfirmed = false,
                            FullName = "أحمد محمد محمد",
                            LockoutEnabled = false,
                            Nationality = "مصري",
                            NormalizedEmail = "M@GMAIL.COM",
                            NormalizedUserName = "@MUHAMMAD123",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0A5n8UttSucz3KWcVpL55uSHJJ9CO6UcGfuyTMV0XDGl6YnP9FtqzswrRrJrHzjQ==",
                            PhoneNumber = "01234567899",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f9babf38-1f4a-4f1e-a3e5-584893f11887",
                            TwoFactorEnabled = false,
                            UpdateddAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "@Muhammad123"
                        },
                        new
                        {
                            Id = "92345678912345",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "43ff94bf-ed2f-44fa-9bcd-6cf131436f88",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Al@gmail.com",
                            EmailConfirmed = false,
                            FullName = "أحمد محمد علي",
                            LockoutEnabled = false,
                            Nationality = "مصري",
                            NormalizedEmail = "AL@GMAIL.COM",
                            NormalizedUserName = "@ALI123",
                            PasswordHash = "AQAAAAIAAYagAAAAEPt1cPSzSLx64bE2VEgsbIcEqIr2gAfV/AeeoP3SPC8A6WiAsDzZ9YtkfhPAZF3Ssw==",
                            PhoneNumber = "01234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4798ca0a-2acc-4373-93d7-590df13db1c7",
                            TwoFactorEnabled = false,
                            UpdateddAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "@Ali123"
                        });
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.UserInsurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("InsuranceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsuranceOrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsuranceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDataId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RelationshipWithOrganization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateddAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationDataId");

                    b.ToTable("UserInsurance");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "SystemManager",
                            NormalizedName = "SYSTEMMANAGER"
                        },
                        new
                        {
                            Id = "2",
                            Name = "HealthFacilitiesAdministrator",
                            NormalizedName = "HEALTHFACILITIESADMINISTRATOR"
                        },
                        new
                        {
                            Id = "3",
                            Name = "HealthFacilityManager",
                            NormalizedName = "HEALTHFACILITYAMANAGER"
                        },
                        new
                        {
                            Id = "4",
                            Name = "Physician",
                            NormalizedName = "PHYSICIAN"
                        },
                        new
                        {
                            Id = "5",
                            Name = "Nurse",
                            NormalizedName = "NURSE"
                        },
                        new
                        {
                            Id = "6",
                            Name = "Pharmacist",
                            NormalizedName = "PHARMACIST"
                        },
                        new
                        {
                            Id = "7",
                            Name = "Patient",
                            NormalizedName = "PATIENT"
                        },
                        new
                        {
                            Id = "8",
                            Name = "Technician",
                            NormalizedName = "TECHNICIAN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "12345678912345",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "12345678902341",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "12345678921345",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "92345678912345",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EHR_API.Entities.Models.HealthFacility", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.Governorate", "Governorate")
                        .WithMany("HealthFacilitys")
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", "RegistrationData")
                        .WithOne("HealthFacility")
                        .HasForeignKey("EHR_API.Entities.Models.HealthFacility", "RegistrationDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governorate");

                    b.Navigation("RegistrationData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.MedicalData", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", "RegistrationData")
                        .WithOne("MedicalData")
                        .HasForeignKey("EHR_API.Entities.Models.UsersData.MedicalData", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegistrationData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.MedicalTeam", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", "RegistrationData")
                        .WithOne("MedicalTeam")
                        .HasForeignKey("EHR_API.Entities.Models.UsersData.MedicalTeam", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegistrationData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.PersonalData", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.Governorate", "Governorate")
                        .WithMany("PersonalData")
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", "RegistrationData")
                        .WithOne("PersonalData")
                        .HasForeignKey("EHR_API.Entities.Models.UsersData.PersonalData", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governorate");

                    b.Navigation("RegistrationData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.UserInsurance", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", "RegistrationData")
                        .WithMany("UserInsurances")
                        .HasForeignKey("RegistrationDataId");

                    b.Navigation("RegistrationData");
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
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", null)
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

                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EHR_API.Entities.Models.UsersData.RegistrationData", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EHR_API.Entities.Models.Governorate", b =>
                {
                    b.Navigation("HealthFacilitys");

                    b.Navigation("PersonalData");
                });

            modelBuilder.Entity("EHR_API.Entities.Models.UsersData.RegistrationData", b =>
                {
                    b.Navigation("HealthFacility");

                    b.Navigation("MedicalData");

                    b.Navigation("MedicalTeam");

                    b.Navigation("PersonalData");

                    b.Navigation("UserInsurances");
                });
#pragma warning restore 612, 618
        }
    }
}
