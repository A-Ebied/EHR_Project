using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class addDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmEmailCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForgotPasswordCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Governorates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ICDs",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DiagnosisName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ICDs", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraindication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vaccinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaccinationEffectiveness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraindication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SideEffects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BadHabits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Habit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BadHabits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BadHabits_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicalData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNAImageResultUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalData_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalTeam",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MedicalSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalTeam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalTeam_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInsurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceOrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInsurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInsurances_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonalData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumOfChildren = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyPhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalData_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalData_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allergen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsChronic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allergies_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Allergies_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BloodDonations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodDonations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BloodDonations_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BloodDonations_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChronicDiseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ICDCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChronicDiseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChronicDiseases_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChronicDiseases_ICDs_ICDCode",
                        column: x => x.ICDCode,
                        principalTable: "ICDs",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_ChronicDiseases_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contraindications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraindications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItsEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsChronic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contraindications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contraindications_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contraindications_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HealthFacilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubordinateTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthFacilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthFacilities_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthFacilities_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AllergyDrugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllergyId = table.Column<int>(type: "int", nullable: false),
                    MedicationId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyDrugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllergyDrugs_Allergies_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "Allergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllergyDrugs_Medications_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChronicDiseaseDrugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicationId = table.Column<int>(type: "int", nullable: false),
                    ChronicDiseaseId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChronicDiseaseDrugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChronicDiseaseDrugs_ChronicDiseases_ChronicDiseaseId",
                        column: x => x.ChronicDiseaseId,
                        principalTable: "ChronicDiseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChronicDiseaseDrugs_Medications_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HealthFacilityId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdmitAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admits_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Admits_HealthFacilities_HealthFacilityId",
                        column: x => x.HealthFacilityId,
                        principalTable: "HealthFacilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Admits_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "MedicalFacilityTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthFacilityId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalFacilityTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalFacilityTeams_HealthFacilities_HealthFacilityId",
                        column: x => x.HealthFacilityId,
                        principalTable: "HealthFacilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalFacilityTeams_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthFacilityId = table.Column<int>(type: "int", nullable: false),
                    VisitType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICDId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InstructionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Visits_HealthFacilities_HealthFacilityId",
                        column: x => x.HealthFacilityId,
                        principalTable: "HealthFacilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_ICDs_ICDId",
                        column: x => x.ICDId,
                        principalTable: "ICDs",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_Visits_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdmitProgressNote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdmitId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmitProgressNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdmitProgressNote_Admits_AdmitId",
                        column: x => x.AdmitId,
                        principalTable: "Admits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdmitProgressNote_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReceiveBloods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmitId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveBloods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiveBloods_Admits_AdmitId",
                        column: x => x.AdmitId,
                        principalTable: "Admits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiveBloods_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Surgeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdmitId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surgeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Surgeries_Admits_AdmitId",
                        column: x => x.AdmitId,
                        principalTable: "Admits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Surgeries_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalTherapy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalTherapy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalTherapy_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserVaccinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    VaccinationId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVaccinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserVaccinations_Vaccinations_VaccinationId",
                        column: x => x.VaccinationId,
                        principalTable: "Vaccinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserVaccinations_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitMedications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    MedicationId = table.Column<int>(type: "int", nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DosageNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodRelation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitMedications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitMedications_Medications_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitMedications_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitRadLabTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitRadLabTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitRadLabTests_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitVitalSigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitVitalSigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitVitalSigns_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurgeryProgressNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SurgeryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurgeryProgressNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurgeryProgressNotes_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SurgeryProgressNotes_Surgeries_SurgeryId",
                        column: x => x.SurgeryId,
                        principalTable: "Surgeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RadLabResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitRadLabTestId = table.Column<int>(type: "int", nullable: false),
                    HealthFacilityId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadLabResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RadLabResult_HealthFacilities_HealthFacilityId",
                        column: x => x.HealthFacilityId,
                        principalTable: "HealthFacilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RadLabResult_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RadLabResult_VisitRadLabTests_VisitRadLabTestId",
                        column: x => x.VisitRadLabTestId,
                        principalTable: "VisitRadLabTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "SystemManager", "SYSTEMMANAGER" },
                    { "2", null, "HealthFacilityManager", "HEALTHFACILITYMANAGER" },
                    { "3", null, "Physician", "PHYSICIAN" },
                    { "5", null, "Pharmacist", "PHARMACIST" },
                    { "6", null, "Patient", "PATIENT" },
                    { "7", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmEmailCode", "CreatedAt", "Email", "EmailConfirmed", "ForgotPasswordCode", "FullName", "LockoutEnabled", "LockoutEnd", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "12345678912341", 0, "fb9bc665-550c-4271-a3e9-7e02b87cdb92", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "k@gmail.com", true, null, "Ahmed Mohamed Kamal", false, null, "Egyptian", "K@GMAIL.COM", "@KAMAL123", "AQAAAAIAAYagAAAAEKM1ydMO6xLNu7po/Kd5vuqN4GkmvMblE+S27mD/aLH61WwsWVLcZFAh+G7rBA/NCA==", "01234567890", false, "982ad2f2-10be-4a01-b124-8e29f13be08d", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Kamal123" },
                    { "12345678912342", 0, "aee19fe2-d0c1-4673-9e24-527d100b3137", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M@gmail.com", true, null, "Ahmed Mohamed Ahmed", false, null, "Egyptian", "M@GMAIL.COM", "@AHMED123", "AQAAAAIAAYagAAAAEJREFfB7nxbKE5PVSuh1Gri59SIQTcuFI3RtFUW2tFYDvaJw5xcW3SbAhtYkEdW5Iw==", "", false, "21bdfa27-4912-45d6-9cc8-d82b13473f94", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Ahmed123" },
                    { "12345678912343", 0, "1216a800-6649-4d01-a79e-ee7bb66e57cd", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "muha75375@gmail.com", true, null, "Ahmed Mohamed Mohamed", false, null, "Egyptian", "MUHA75375@GMAIL.COM", "@MUHAMMAD123", "AQAAAAIAAYagAAAAEIN1vTDAer6Yq31bfgZ7y9Lv/QPnbohYboOWrwTWAya0+/OPrTEaROLDH8ytIwFljA==", "01234567899", false, "ccdfbfa3-f8e3-46af-9ff4-1d3b11e53af5", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Muhammad123" },
                    { "12345678912344", 0, "088b41c4-dc8a-4678-a7ff-8d230ef7dc09", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al@gmail.com", true, null, "Ahmed Mohammed Ali", false, null, "Egyptian", "AL@GMAIL.COM", "@ALI123", "AQAAAAIAAYagAAAAENxHAAEru2RrhymvwxJO+I9Ou4M65c7vd7aPBFSFLvK30Rw1HdpTRUjE0XNX56ltdg==", "01234567890", false, "198cdb0d-caf5-4f68-a0a2-b52cf3c03cc6", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Ali123" },
                    { "12345678912346", 0, "5c9a77c0-6e84-4111-b336-569aaa49ca91", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ka@gmail.com", true, null, "Ahmed Khater Ali", false, null, "Egyptian", "KA@GMAIL.COM", "@KHATER123", "AQAAAAIAAYagAAAAEGF7DfdmB1xqH85mXpvEkMpbNdOwVf62zkrBrSItTWiQRxHuUCp7jKob0yC/vrMuwg==", "", false, "88ac3138-2790-4a8c-9436-12cd23fb23a7", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Khater123" },
                    { "12345678912348", 0, "22947a20-b5f3-45f3-98a0-6afbdd49493a", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ma2@gmail.com", true, null, "Manal Khater Ahmed", false, null, "Egyptian", "MA2@GMAIL.COM", "@MANAL2123", "AQAAAAIAAYagAAAAELL/umv4TIUxSB8MkqIdJMqhaMNIKF1a01ROwmo0vDDlR8dojVlWOLQrgzn+Ppjdiw==", "", false, "e43309c7-75ab-4d5a-93ee-7e3d3e3ed8c2", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Manal2123" },
                    { "12345678912349", 0, "a92b45da-6f35-43e1-979f-992b84fa7d96", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ka2@gmail.com", true, null, "Khater Ahmed", false, null, "Egyptian", "KA2@GMAIL.COM", "@KHATER2123", "AQAAAAIAAYagAAAAENsBSvfgTDQzJZBryl6ibe9syxjKpT5pMnp2DxB6xiV6obO3z2QxG+xD0L/owa5bZw==", "", false, "4df55336-959c-4699-bf74-8a393bb8a2a7", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Khater2123" },
                    { "12345678912350", 0, "a0b37472-e2cd-4ab3-956c-0fd76d0bf539", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TE@gmail.com", true, null, "Ali Khater Ahmed", false, null, "Egyptian", "TE@GMAIL.COM", "@TEST2123", "AQAAAAIAAYagAAAAEN1oBbfFqocPgfp46llWJg0Ir3DwH6v3VR3yquydZquh4cjuABb7SIcDRIvcOm/f4A==", "", false, "03d242ac-6fba-4f11-8cda-6446a3685394", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@AlI2123" },
                    { "12345678912351", 0, "98106888-c2b3-4c9e-810e-1519c5975446", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fa@gmail.com", true, null, "Ahmed Fawzy Mohamed", false, null, "Egyptian", "FA@GMAIL.COM", "@FAWZY123", "AQAAAAIAAYagAAAAEFu/mNopzDsZw6pbi4UiNhU3dIbe9rX6mfJFlV6aG/RVskzji0w9iLQ073QA65E0ug==", "", false, "0f7a97cd-f4f9-44d1-a64d-24c87f8f4630", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Fawzy123" },
                    { "12345678912352", 0, "89927822-6610-4aac-832b-a1be3696c593", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlFa@gmail.com", true, null, "Ali Fawzy Muhammad", false, null, "Egyptian", "ALFA@GMAIL.COM", "@ALIFAWZY123", "AQAAAAIAAYagAAAAEGQe+Spv8t1md2VGyfQgDIxD7ZDwn03wTSVJ2cjSCrfJfxAPjNewiFgaLVFMo06ufg==", "", false, "16221327-ce54-44ff-bcb6-64e1667d5704", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@AliFawzy123" },
                    { "12345678912353", 0, "61b82134-3247-40cf-8803-8c9200723dbf", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AFa@gmail.com", true, null, "Ali Fawzy Ahmed", false, null, "Egyptian", "AFA@GMAIL.COM", "@AFAWZY123", "AQAAAAIAAYagAAAAEJYDFrgcdSItfXcLFtO0pITtcgkMbM1ckd0M+d36S46CwUzgXdvveZEL6wvOxW+lTQ==", "", false, "3cee919e-c8a4-415a-966b-7362354ecc50", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@AFawzy123" }
                });

            migrationBuilder.InsertData(
                table: "Governorates",
                columns: new[] { "Id", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4220), "Cairo", new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4268) },
                    { 2, new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4272), "Giza", new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4274) },
                    { 3, new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4276), "Matrouh", new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4277) },
                    { 4, new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4279), "North Sinai", new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4281) },
                    { 5, new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4283), "Sharkia", new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4285) },
                    { 6, new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4287), "Dakahlia", new DateTime(2023, 6, 17, 7, 38, 39, 710, DateTimeKind.Local).AddTicks(4288) }
                });

            migrationBuilder.InsertData(
                table: "ICDs",
                columns: new[] { "Code", "CreatedAt", "DiagnosisName", "UpdatedAt" },
                values: new object[,]
                {
                    { " I10", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3389), "Essential (primary) hypertension", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3390) },
                    { "A00.0", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3374), "Cholera due to Vibrio cholerae 01, biovar cholerae", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3377) },
                    { "A00.1", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3378), "Cholera due to Vibrio cholerae 01, biovar eltor", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3380) },
                    { "A00.9", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3381), "Cholera, unspecified", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3382) },
                    { "A01.00", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3384), "Typhoid fever, unspecified", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3385) },
                    { "J18.9", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3386), "Pneumonia", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3387) }
                });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "Contraindication", "CreatedAt", "Description", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Forbidden for patients with kidneys and liver.", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5029), "Route, Oral", "/files/Medication/fexofenadine.jpg", "Fexofenadine", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5031) },
                    { 2, "-", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5034), "Nasal Spray", "/files/Medication/NASONEX.jpg", "Nasonex", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5035) },
                    { 3, "Do not use with any other paracetamol containing products.", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5037), "Route, Oral", "/files/Medication/advance.jpg", "Panadol Advance", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5038) },
                    { 4, "-", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5039), "Route, Oral", "/files/Medication/Kerovit.jpg", "Kerovit", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5040) },
                    { 5, "Allergy to any of the components of the drug", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5042), "Route, Oral", "/files/Medication/CiproCoupons.png", "Cipro", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5043) },
                    { 6, "Allergy to any of the components of the drug", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5045), "Route, Oral", "/files/Medication/Oracea.jpg", "Oracea", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5046) },
                    { 7, "", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5048), "Route, Oral", "/files/Medication/Hydrochlorothiazide.jpg", "Hydrochlorothiazide", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5049) }
                });

            migrationBuilder.InsertData(
                table: "Vaccinations",
                columns: new[] { "Id", "AgeRange", "Contraindication", "CreatedAt", "Dosage", "Name", "Note", "Reason", "Route", "SideEffects", "Type", "UpdatedAt", "VaccinationEffectiveness" },
                values: new object[,]
                {
                    { 1, "Typically given in two doses during childhood", "Severe allergic reaction to a previous dose or vaccine components", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6323), "Two doses, usually administered at 12-15 months and 4-6 years of age", "Measles, Mumps, and Rubella (MMR)", "MMR vaccination is an important part of Egypt's immunization program.", "Protection against measles, mumps, and rubella", "Subcutaneous injection", "Mild side effects include fever, rash, and temporary joint pain", "Live attenuated vaccine", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6325), "Highly effective in preventing the target diseases" },
                    { 2, "Multiple doses given during infancy and childhood", "Severe allergic reaction to a previous dose", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6328), "Typically administered as a series of four doses", "Polio", "Polio vaccination is crucial for maintaining Egypt's polio-free status.", "Protection against poliovirus infection", "Intramuscular injection or oral administration", "Mild side effects include pain or swelling at the injection site", "Inactivated vaccine (inactivated polio vaccine or IPV)", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6329), "Highly effective in preventing polio" },
                    { 3, "Usually given during childhood or as a catch-up vaccine for older individuals", "Allergy to vaccine components", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6332), "Typically administered as a series of two doses", "Hepatitis A", "Hepatitis A vaccination is recommended for individuals traveling to areas with a high prevalence of the disease.", "Protection against hepatitis A virus infection", "Intramuscular injection", "Mild side effects include pain at the injection site, headache, and fatigue", "Inactivated vaccine", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6333), "Highly effective in preventing hepatitis A" },
                    { 4, "Recommended for individuals six months of age and older", "Severe allergic reaction to a previous dose or vaccine components", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6335), "Annual vaccination, as the flu strains change every year", "Influenza (Flu)", "Annual influenza vaccination is recommended, especially for high-risk groups.", "Protection against seasonal influenza viruses", "Intramuscular injection or nasal spray", "Mild side effects include soreness at the injection site, low-grade fever, and muscle aches", "Inactivated vaccine (influenza vaccine)", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6336), "Varies each year due to different strains, but overall effective in reducing the severity of flu symptoms" },
                    { 5, "It is recommended for infants and young children, as well as adults with certain medical conditions or risk factors. The specific age recommendations may vary by country.", "Severe allergic reaction (anaphylaxis) to a previous dose of PCV13 or any vaccine component.", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6339), "The number of doses and schedule can vary depending on the age at initial vaccination and the individual's risk factors.", "Pneumococcal Conjugate Vaccine (PCV13)", "PCV13 is often given as a series of doses during infancy and early childhood, followed by a booster dose in some individuals.", " Protection against infections caused by Streptococcus pneumoniae, including pneumonia, meningitis, and bloodstream infections.", "Intramuscular injection", "Common side effects include pain, redness, or swelling at the injection site, as well as fever, fussiness, and fatigue.", "Conjugate vaccine", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6340), "PCV13 has been shown to be highly effective in preventing pneumococcal disease caused by the serotypes included in the vaccine." }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "12345678912341" },
                    { "2", "12345678912342" },
                    { "3", "12345678912343" },
                    { "5", "12345678912344" },
                    { "7", "12345678912346" },
                    { "2", "12345678912348" },
                    { "2", "12345678912349" },
                    { "2", "12345678912350" },
                    { "6", "12345678912351" },
                    { "6", "12345678912352" },
                    { "6", "12345678912353" }
                });

            migrationBuilder.InsertData(
                table: "BadHabits",
                columns: new[] { "Id", "CreatedAt", "Habit", "Notes", "RegistrationDataId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5564), "Smoking", "", "12345678912351", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5566) },
                    { 2, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5568), "Smoking", "", "12345678912352", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5569) },
                    { 3, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5571), "Drink Wine", "", "12345678912353", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5572) }
                });

            migrationBuilder.InsertData(
                table: "MedicalData",
                columns: new[] { "Id", "BloodGroup", "CreatedAt", "DNAImageResultUrl", "FamilyHistory", "MedicalHistory", "UpdatedAt" },
                values: new object[,]
                {
                    { "12345678912351", "A+", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4431), "", "Paternal grandfather had diabetes", "", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4433) },
                    { "12345678912352", "O+", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4435), "", "The paternal grandfather had a mental illness.", "The patient had hallucinations twice previously.", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4437) },
                    { "12345678912353", "AB+", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4439), "", "", "", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4440) }
                });

            migrationBuilder.InsertData(
                table: "MedicalTeam",
                columns: new[] { "Id", "CreatedAt", "Degree", "MedicalSpecialization", "UpdatedAt" },
                values: new object[,]
                {
                    { "12345678912342", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4754), "PhD in pulmonary diseases", "Pulmonologist", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4757) },
                    { "12345678912343", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4767), "Master of Otolaryngology", "Otolaryngology", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4768) },
                    { "12345678912344", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4769), "Bachelor's degree in pharmacy", "Pharmacist", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4770) },
                    { "12345678912346", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4772), "Institute of Technical healthy", "Radiology technician", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4773) },
                    { "12345678912348", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4759), "Master of Orthopedic Oncology", "Orthopaedic Oncology Surgeon", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4760) },
                    { "12345678912349", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4761), "PhD in urological oncology", "Urologic Oncologist", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4763) },
                    { "12345678912350", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4764), "PhD in Internal medicine", "Internal medicine physician", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4765) }
                });

            migrationBuilder.InsertData(
                table: "PersonalData",
                columns: new[] { "Id", "Address", "AgeGroup", "BirthDate", "CreatedAt", "EmergencyPhone1", "EmergencyPhone2", "Gender", "GovernorateId", "NumOfChildren", "Occupation", "Phone1", "UpdatedAt", "UserImageUrl" },
                values: new object[,]
                {
                    { "12345678912351", "", "", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4131), "01234546788", "", "Male", 1, 3, "Teacher", "01234546787", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4134), "" },
                    { "12345678912352", "", "", new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4143), "01234746788", "", "Male", 3, 1, "Professor", "01234544487", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4144), "" },
                    { "12345678912353", "", "", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4150), "01234506788", "", "Male", 2, 3, "", "01234500787", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(4151), "" }
                });

            migrationBuilder.InsertData(
                table: "UserInsurances",
                columns: new[] { "Id", "CreatedAt", "InsuranceNo", "InsuranceOrganizationName", "InsuranceType", "RegistrationDataId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3650), "123OP", "Egyptian health insurance", "Governmental", "12345678912351", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3652) },
                    { 2, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3655), "124OP", "Egyptian health insurance", "Governmental", "12345678912352", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3656) }
                });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "Allergen", "CreatedAt", "Instruction", "IsChronic", "MedicalTeamId", "Reaction", "RegistrationDataId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Dust mites, Pollen, Pet hair, fur, feathers", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5815), "Avoid allergens", true, "12345678912343", "Sneezing ,Runny or stuffy nose, coughing, tightness in the chest, shortness of breath", "12345678912351", "Dust allergy", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5818) },
                    { 2, "Peanuts, Milk, Eggs", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5820), "", true, "12345678912350", "Rash", "12345678912352", "Food Allergy", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5821) }
                });

            migrationBuilder.InsertData(
                table: "BloodDonations",
                columns: new[] { "Id", "CreatedAt", "DonationDateTime", "MedicalTeamId", "RegistrationDataId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5319), new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5315), "12345678912348", "12345678912351", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5320) },
                    { 2, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5323), new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5322), "12345678912348", "12345678912352", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(5325) }
                });

            migrationBuilder.InsertData(
                table: "HealthFacilities",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "Email", "GovernorateId", "MedicalTeamId", "Phone1", "Phone2", "Phone3", "SubordinateTo", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Address1", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(2969), "Description1", "m@gmail.com", 1, "12345678912342", "01123456878", "", "", "The military Establishment", "Sharkia Military Hospital", "Military Hospital", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3082) },
                    { 2, "Address2", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3088), "Description2", "a@gmail.com", 1, "12345678912348", "01122456878", "", "", "Ministry of Health", "Arish Hospital", "Government Hospital", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3089) },
                    { 3, "Address3", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3092), "Description3", "j@gmail.com", 1, "12345678912349", "01123416878", "", "", "University Hospitals", "University Hospital, Zagazig", "University Hospital", new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(3093) }
                });

            migrationBuilder.InsertData(
                table: "AllergyDrugs",
                columns: new[] { "Id", "AllergyId", "CreatedAt", "MedicationId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6077), 1, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6079) },
                    { 2, 1, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6081), 2, new DateTime(2023, 6, 17, 7, 38, 40, 422, DateTimeKind.Local).AddTicks(6082) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmitProgressNote_AdmitId",
                table: "AdmitProgressNote",
                column: "AdmitId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmitProgressNote_MedicalTeamId",
                table: "AdmitProgressNote",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Admits_HealthFacilityId",
                table: "Admits",
                column: "HealthFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Admits_MedicalTeamId",
                table: "Admits",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Admits_RegistrationDataId",
                table: "Admits",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_MedicalTeamId",
                table: "Allergies",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_RegistrationDataId",
                table: "Allergies",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_AllergyDrugs_AllergyId_MedicationId",
                table: "AllergyDrugs",
                columns: new[] { "AllergyId", "MedicationId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AllergyDrugs_MedicationId",
                table: "AllergyDrugs",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BadHabits_RegistrationDataId",
                table: "BadHabits",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonations_MedicalTeamId",
                table: "BloodDonations",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodDonations_RegistrationDataId",
                table: "BloodDonations",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseaseDrugs_ChronicDiseaseId_MedicationId",
                table: "ChronicDiseaseDrugs",
                columns: new[] { "ChronicDiseaseId", "MedicationId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseaseDrugs_MedicationId",
                table: "ChronicDiseaseDrugs",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseases_ICDCode",
                table: "ChronicDiseases",
                column: "ICDCode");

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseases_MedicalTeamId",
                table: "ChronicDiseases",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseases_RegistrationDataId_ICDCode",
                table: "ChronicDiseases",
                columns: new[] { "RegistrationDataId", "ICDCode" },
                unique: true,
                filter: "[RegistrationDataId] IS NOT NULL AND [ICDCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contraindications_MedicalTeamId",
                table: "Contraindications",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Contraindications_RegistrationDataId",
                table: "Contraindications",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacilities_GovernorateId",
                table: "HealthFacilities",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacilities_MedicalTeamId",
                table: "HealthFacilities",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalFacilityTeams_HealthFacilityId_MedicalTeamId",
                table: "MedicalFacilityTeams",
                columns: new[] { "HealthFacilityId", "MedicalTeamId" },
                unique: true,
                filter: "[MedicalTeamId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalFacilityTeams_MedicalTeamId",
                table: "MedicalFacilityTeams",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_GovernorateId",
                table: "PersonalData",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalTherapy_VisitId",
                table: "PhysicalTherapy",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_RadLabResult_HealthFacilityId",
                table: "RadLabResult",
                column: "HealthFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_RadLabResult_MedicalTeamId",
                table: "RadLabResult",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_RadLabResult_VisitRadLabTestId",
                table: "RadLabResult",
                column: "VisitRadLabTestId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveBloods_AdmitId",
                table: "ReceiveBloods",
                column: "AdmitId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveBloods_MedicalTeamId",
                table: "ReceiveBloods",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Surgeries_AdmitId",
                table: "Surgeries",
                column: "AdmitId");

            migrationBuilder.CreateIndex(
                name: "IX_Surgeries_MedicalTeamId",
                table: "Surgeries",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeryProgressNotes_MedicalTeamId",
                table: "SurgeryProgressNotes",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgeryProgressNotes_SurgeryId",
                table: "SurgeryProgressNotes",
                column: "SurgeryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInsurances_RegistrationDataId",
                table: "UserInsurances",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVaccinations_VaccinationId",
                table: "UserVaccinations",
                column: "VaccinationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVaccinations_VisitId_VaccinationId",
                table: "UserVaccinations",
                columns: new[] { "VisitId", "VaccinationId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisitMedications_MedicationId_VisitId",
                table: "VisitMedications",
                columns: new[] { "MedicationId", "VisitId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisitMedications_VisitId",
                table: "VisitMedications",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitRadLabTests_VisitId",
                table: "VisitRadLabTests",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_HealthFacilityId",
                table: "Visits",
                column: "HealthFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_ICDId",
                table: "Visits",
                column: "ICDId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_MedicalTeamId",
                table: "Visits",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_RegistrationDataId",
                table: "Visits",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitVitalSigns_VisitId",
                table: "VisitVitalSigns",
                column: "VisitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmitProgressNote");

            migrationBuilder.DropTable(
                name: "AllergyDrugs");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BadHabits");

            migrationBuilder.DropTable(
                name: "BloodDonations");

            migrationBuilder.DropTable(
                name: "ChronicDiseaseDrugs");

            migrationBuilder.DropTable(
                name: "Contraindications");

            migrationBuilder.DropTable(
                name: "MedicalData");

            migrationBuilder.DropTable(
                name: "MedicalFacilityTeams");

            migrationBuilder.DropTable(
                name: "PersonalData");

            migrationBuilder.DropTable(
                name: "PhysicalTherapy");

            migrationBuilder.DropTable(
                name: "RadLabResult");

            migrationBuilder.DropTable(
                name: "ReceiveBloods");

            migrationBuilder.DropTable(
                name: "SurgeryProgressNotes");

            migrationBuilder.DropTable(
                name: "UserInsurances");

            migrationBuilder.DropTable(
                name: "UserVaccinations");

            migrationBuilder.DropTable(
                name: "VisitMedications");

            migrationBuilder.DropTable(
                name: "VisitVitalSigns");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ChronicDiseases");

            migrationBuilder.DropTable(
                name: "VisitRadLabTests");

            migrationBuilder.DropTable(
                name: "Surgeries");

            migrationBuilder.DropTable(
                name: "Vaccinations");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Admits");

            migrationBuilder.DropTable(
                name: "ICDs");

            migrationBuilder.DropTable(
                name: "HealthFacilities");

            migrationBuilder.DropTable(
                name: "Governorates");

            migrationBuilder.DropTable(
                name: "MedicalTeam");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
