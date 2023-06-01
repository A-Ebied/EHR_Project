using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class db1 : Migration
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
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allergies_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "ChronicDiseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ICDId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                        name: "FK_ChronicDiseases_ICDs_ICDId",
                        column: x => x.ICDId,
                        principalTable: "ICDs",
                        principalColumn: "Code");
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
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthFacilityId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicalFacilityTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthFacilityId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { "2", null, "HealthFacilityManager", "HEALTHFACILITYAMANAGER" },
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
                    { "12345678912341", 0, "e545b85e-cbdc-4b6e-8455-4bd5b50ec0eb", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "k@gmail.com", true, null, "أحمد محمد كمال", false, null, "مصري", "K@GMAIL.COM", "@KAMAL123", "AQAAAAIAAYagAAAAEIMtisEA8VZhecW87IVCdgmpG39cmqzFGiW1bMt6KydVF6FSvuY7TeSK4P6utB1AEw==", "01234567890", false, "8ce72237-8810-45eb-b7af-9a446bc9cb6b", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Kamal123" },
                    { "12345678912342", 0, "6f5eb83a-8e3d-423a-b1c6-e627784fd144", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A@gmail.com", true, null, "أحمد محمد أحمد", false, null, "مصري", "A@GMAIL.COM", "@AHMED123", "AQAAAAIAAYagAAAAELM+vCBLIKFa/HyFR9MeuoN7toTdgbCNcHc3N8dJ2A7IVciYS1SGXG8TF3zqnWy3oQ==", "", false, "0c97412a-6a21-437e-81dc-2c08001cbfaf", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Ahmed123" },
                    { "12345678912343", 0, "3d2f727e-4ed5-4446-b82e-937c48cbf0c7", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M@gmail.com", true, null, "أحمد محمد محمد", false, null, "مصري", "M@GMAIL.COM", "@MUHAMMAD123", "AQAAAAIAAYagAAAAEK7DPMNZxxtvdwzAdZVmu8mvsPkuvM5CIdZUopPXSNTZzTdhwqXJ7cD6bkNpbr/ZsQ==", "01234567899", false, "9fa46295-21ce-4d06-a695-5bfc8b3d4898", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Muhammad123" },
                    { "12345678912344", 0, "9f0337b1-32c9-40d5-b7bc-8493a10cd968", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al@gmail.com", true, null, "أحمد محمد علي", false, null, "مصري", "AL@GMAIL.COM", "@ALI123", "AQAAAAIAAYagAAAAEC340D8YeTTUmh7idpqGRCB2lNyHPUpF4xnV1qtlk6ouuNJteWx82l8ew1QWBnmLhw==", "01234567890", false, "4afe4b50-10f1-4cbc-8239-a60f68e4709a", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Ali123" },
                    { "12345678912346", 0, "fa199050-3bb2-4e1b-8178-c6d9b5c1a9b4", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ka@gmail.com", true, null, "أحمد خاطر علي", false, null, "مصري", "KA@GMAIL.COM", "@KHATER123", "AQAAAAIAAYagAAAAEAawQBruND/HTv03349oCjPM7+jZZ8w1NPGIBzqlkrRVSIFee0wQyu9dlJcXa6SL4w==", "", false, "29a89ee1-b033-4aaf-a23b-8e8721840e82", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Khater123" },
                    { "12345678912348", 0, "df039f77-52b6-47fa-8826-e50e446cee29", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ma2@gmail.com", true, null, "منال خاطر أحمد", false, null, "مصري", "MA2@GMAIL.COM", "@MANAL2123", "AQAAAAIAAYagAAAAENPOpZkevP6NS+6TTMf3X4zZlBG7BvBjDOlSfnocpKc3WQXjFWLoX2k1kx/hrJlcXg==", "", false, "0db1bad5-2c60-4287-9485-c5a4b0ef0248", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Manal2123" },
                    { "12345678912349", 0, "27bbb60b-a60b-4950-b239-f08b26438e44", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ka2@gmail.com", true, null, "خاطر أحمد", false, null, "مصري", "KA2@GMAIL.COM", "@KHATER2123", "AQAAAAIAAYagAAAAEPJzSSg4z9XDjjg+XqSNJXSE1iQ2/mbGStY56Wiw5a0F0TkoqzmBXST1xD5PFKgB1g==", "", false, "a693a839-57cc-43c2-b0d2-ffd400f1d450", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Khater2123" },
                    { "12345678912350", 0, "3ef16edd-3cd3-4cb8-9e04-5afe53a75b12", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TE@gmail.com", true, null, "test", false, null, "مصري", "TE@GMAIL.COM", "@TEST2123", "AQAAAAIAAYagAAAAEOlIvn8SS+qeu3RT5UlsR0gfXh+OhBQ4XaztwpT9paKpISTzr7ck15O06Y+zmywJ2A==", "", false, "e0da791e-17be-4280-ad61-59def71d2d82", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Test2123" },
                    { "12345678912351", 0, "0b76ffc4-2131-4d9f-b6d4-c45eadc0b520", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fa@gmail.com", true, null, "أحمد فوزي محمد", false, null, "مصري", "FA@GMAIL.COM", "@FAWZY123", "AQAAAAIAAYagAAAAEJthI0DblT2nJBdutNUFiJHVz3KjB1bqzG3R3PEZjuW+3ep731ENVhSbEwx8DU9lrg==", "", false, "1a78ef5d-a35b-4ae1-9813-c9f70c3622d3", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Fawzy123" },
                    { "12345678912352", 0, "85950c61-6c1c-4f20-ab48-b40db8bae0b5", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlFa@gmail.com", true, null, "علي فوزي محمد", false, null, "مصري", "ALFA@GMAIL.COM", "@ALIFAWZY123", "AQAAAAIAAYagAAAAECbQuVcJ65hdJ87PAFDnvBafoxqFpfoOpTCn7GROxhtyq2rkwLsWaV92a8amct5R8Q==", "", false, "1f129575-6acb-4e2c-b00f-31638e97c0c6", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@AliFawzy123" },
                    { "12345678912353", 0, "7ba58229-83ce-4ee4-ab4a-32c13af3d9ee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AFa@gmail.com", true, null, "علي فوزي أحمد", false, null, "مصري", "AFA@GMAIL.COM", "@AFAWZY123", "AQAAAAIAAYagAAAAEFq2VOQlmF2YTS9J0MlQ8dcoqG5qiqAN+Zfzmxzs2+OSf7oPhyIJFlR01fUkcwd4vQ==", "", false, "3585db52-044a-45a4-bcad-3d468430e82f", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@AFawzy123" }
                });

            migrationBuilder.InsertData(
                table: "Governorates",
                columns: new[] { "Id", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6211), "القاهرة", new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6262) },
                    { 2, new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6266), "الجيزة", new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6267) },
                    { 3, new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6269), "مطروح", new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6271) },
                    { 4, new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6273), "شمال سيناء", new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6274) },
                    { 5, new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6276), "الشرقية", new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6278) },
                    { 6, new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6280), "الدقهلية", new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6281) }
                });

            migrationBuilder.InsertData(
                table: "ICDs",
                columns: new[] { "Code", "CreatedAt", "DiagnosisName", "UpdatedAt" },
                values: new object[,]
                {
                    { "A00.0", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7740), "Cholera due to Vibrio cholerae 01, biovar cholerae", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7744) },
                    { "A00.1", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7747), "Cholera due to Vibrio cholerae 01, biovar eltor", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7748) },
                    { "A00.9", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7750), "Cholera, unspecified", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7752) },
                    { "A01.00", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7754), "Typhoid fever, unspecified", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7756) }
                });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "Contraindication", "CreatedAt", "Description", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "ممنوع على مرضى الكلى والكبد", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9993), "أقراص", "/files/Medication/fexofenadine.jpg", "Fexofenadine (الفيكسوفينادين)", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9996) },
                    { 2, "لا يستخدم مع مرضى السكري.....الخ", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1), "بخاخ أنف", "/files/Medication/NASONEX.jpg", "Nasonex (نازونكس)", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(3) },
                    { 3, "لا تستخدم مع أي منتجات أخرى تحتوي على الباراسيتامول. يزيد مرض الكبد الأساسي من خطر تلف الكبد المرتبط بالباراسيتامول. يجب على المرضى الذين تم تشخيص إصابتهم بضعف في الكبد أو الكلى طلب المشورة الطبية قبل تناول هذا الدواء.", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(5), "أقراص", "/files/Medication/advance.jpg", "Panadol Advance (بانادول أدفانس)", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(7) },
                    { 4, "فرط الحساسية لأي من المكونات", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(9), "أقراص", "/files/Medication/Kerovit.jpg", "Kerovit (كيروفيت)", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(11) }
                });

            migrationBuilder.InsertData(
                table: "Vaccinations",
                columns: new[] { "Id", "AgeRange", "Contraindication", "CreatedAt", "Dosage", "Name", "Note", "Reason", "Route", "SideEffects", "Type", "UpdatedAt", "VaccinationEffectiveness" },
                values: new object[,]
                {
                    { 1, "2-64 عام", "", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(3386), "1 dose", "Vaxchora", "", "لقاح يستخدم للوقاية من الكوليرا", "عن طريق الفم", "", "حبوب", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(3391), "3-6 أشهر" },
                    { 2, "من عامين وأكبر", "", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(3398), "2 doses, given 1–6 weeks apart ", "Dukoral", "Children aged 2–5 years need 3 doses, given 1 to 6 weeks apart", "لقاح يستخدم للوقاية من الكوليرا", "عن طريق الفم", "", "حبوب", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(3401), "عامين" }
                });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "Allergen", "CreatedAt", "Instruction", "IsChronic", "Reaction", "RegistrationDataId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "التراب", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2050), "---", true, "سيلان الأنف والكحة", "12345678912351", "حساسية التراب", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2056) },
                    { 2, "الفول السوداني والحليب والبيض", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2061), "", true, "طفح جلدي", "12345678912352", "حساسية الطعام", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2064) },
                    { 3, "فراء الحيوانات ، وخاصة من الحيوانات الأليفة مثل القطط والكلاب", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2068), "الابتعاد عن الحيوانات الأليفة", true, "ضيق في الصدر وفقدان أنفاسك", "12345678912353", "حساسية الحيوانات الأليفة", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2071) }
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
                    { 1, new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1376), "التدخين", "", "12345678912351", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1382) },
                    { 2, new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1388), "التدخين", "", "12345678912352", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1390) },
                    { 3, new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1395), "شرب الخمور", "", "12345678912353", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1397) }
                });

            migrationBuilder.InsertData(
                table: "MedicalData",
                columns: new[] { "Id", "BloodGroup", "CreatedAt", "DNAImageResultUrl", "FamilyHistory", "MedicalHistory", "UpdatedAt" },
                values: new object[,]
                {
                    { "12345678912351", "A+", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9136), "", "الجد من الأب كان مصاب بالسكري", "", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9139) },
                    { "12345678912352", "O+", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9142), "", "الجد من الأب كان مصاب بمرض ذهني", "المريض أصيب بحالة من الهلوسة مرتين سابقا", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9144) },
                    { "12345678912353", "AB+", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9147), "", "", "", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9148) }
                });

            migrationBuilder.InsertData(
                table: "MedicalTeam",
                columns: new[] { "Id", "CreatedAt", "Degree", "MedicalSpecialization", "UpdatedAt" },
                values: new object[,]
                {
                    { "12345678912342", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9555), "ماجستير جراحة العمود الفقري", "جراحة العمود الفقري", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9558) },
                    { "12345678912343", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9574), "ماجستير أنف وأذن وحنجرة", "أنف وأذن وحنجرة", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9575) },
                    { "12345678912344", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9577), "بكالوريوس الصيدلة", "طب الصيدلة", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9579) },
                    { "12345678912346", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9581), "معهد فني صحي", "فني أشعة", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9583) },
                    { "12345678912348", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9562), "ماجستير أورام العظام", "أورام العظام", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9563) },
                    { "12345678912349", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9565), "دكتوراة أورام المسالك البولية", "أورام المسالك البولية", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9567) },
                    { "12345678912350", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9570), "دكتوراة جراحة القلب", "جراحة القلب", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9572) }
                });

            migrationBuilder.InsertData(
                table: "PersonalData",
                columns: new[] { "Id", "Address", "AgeGroup", "BirthDate", "CreatedAt", "EmergencyPhone1", "EmergencyPhone2", "Gender", "GovernorateId", "NumOfChildren", "Occupation", "Phone1", "UpdatedAt", "UserImageUrl" },
                values: new object[,]
                {
                    { "12345678912351", "", "", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8680), "01234546788", "", "ذكر", 1, 3, "مدرس", "01234546787", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8683), "" },
                    { "12345678912352", "", "", new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8695), "01234746788", "", "ذكر", 3, 1, "دكتور جامعي", "01234544487", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8696), "" },
                    { "12345678912353", "", "", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8703), "01234506788", "", "ذكر", 2, 3, "عمل حر", "01234500787", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8705), "" }
                });

            migrationBuilder.InsertData(
                table: "UserInsurances",
                columns: new[] { "Id", "CreatedAt", "InsuranceNo", "InsuranceOrganizationName", "InsuranceType", "RegistrationDataId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8160), "123OP", "التأمين الصحي المصري", "حكومي", "12345678912351", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8163) },
                    { 2, new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8166), "124OP", "التأمين الصحي المصري", "حكومي", "12345678912352", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8168) }
                });

            migrationBuilder.InsertData(
                table: "AllergyDrugs",
                columns: new[] { "Id", "AllergyId", "CreatedAt", "MedicationId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2776), 1, new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2782) },
                    { 2, 1, new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2786), 2, new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2788) }
                });

            migrationBuilder.InsertData(
                table: "BloodDonations",
                columns: new[] { "Id", "CreatedAt", "DonationDateTime", "MedicalTeamId", "RegistrationDataId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(757), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(743), "12345678912348", "12345678912351", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(761) },
                    { 2, new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(769), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(766), "12345678912348", "12345678912352", new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(771) }
                });

            migrationBuilder.InsertData(
                table: "HealthFacilities",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "Email", "GovernorateId", "MedicalTeamId", "Phone1", "Phone2", "Phone3", "SubordinateTo", "Title", "Type", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, "Address1", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7248), "Description1", "m@gmail.com", 1, "12345678912342", "01123456878", "", "", "المؤسسة العسكرية", "المستشفى العسكري بالشرقية", "مستشفى عسكري", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7308) },
                    { 2, "Address2", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7316), "Description2", "a@gmail.com", 1, "12345678912348", "01122456878", "", "", "وزارة الصحة", "المستشفى العام بالعريش", "مستشفى عام", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7317) },
                    { 3, "Address3", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7321), "Description3", "j@gmail.com", 1, "12345678912349", "01123416878", "", "", "مستشفيات الجامعة", "مستشفى الجامعة بالزقازيق", "مستشفى جامعي", new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7323) }
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
                name: "IX_ChronicDiseases_ICDId",
                table: "ChronicDiseases",
                column: "ICDId");

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseases_RegistrationDataId_ICDId",
                table: "ChronicDiseases",
                columns: new[] { "RegistrationDataId", "ICDId" },
                unique: true,
                filter: "[RegistrationDataId] IS NOT NULL AND [ICDId] IS NOT NULL");

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
                name: "IX_RadLabResult_VisitRadLabTestId",
                table: "RadLabResult",
                column: "VisitRadLabTestId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveBloods_AdmitId",
                table: "ReceiveBloods",
                column: "AdmitId");

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
