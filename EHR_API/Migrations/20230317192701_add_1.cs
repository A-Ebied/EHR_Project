using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add1 : Migration
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthFacilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthFacilities_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Contraindications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContraindiReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItsEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsChronic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicationId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Contraindications_Medications_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "MedicalFacilityTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthFacilityId = table.Column<int>(type: "int", nullable: false)
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
                    IsAdmit = table.Column<bool>(type: "bit", nullable: false),
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
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmitAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HealthFacilityId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admits", x => x.Id);
                    table.UniqueConstraint("AlternateKey_VisitId", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Admits_HealthFacilities_HealthFacilityId",
                        column: x => x.HealthFacilityId,
                        principalTable: "HealthFacilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Admits_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "ReceiveBloods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdmitId = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_ReceiveBloods_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
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
                    AdmitId = table.Column<int>(type: "int", nullable: false)
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
                name: "RadLabResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Receives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiveBloodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receives_ReceiveBloods_ReceiveBloodId",
                        column: x => x.ReceiveBloodId,
                        principalTable: "ReceiveBloods",
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SurgeryId = table.Column<int>(type: "int", nullable: false)
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
                name: "RadLabResultImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResultImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RadLabResultId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadLabResultImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RadLabResultImages_RadLabResult_RadLabResultId",
                        column: x => x.RadLabResultId,
                        principalTable: "RadLabResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "SystemManager", "SYSTEMMANAGER" },
                    { "2", null, "HealthFacilityManager", "HEALTHFACILITYAMANAGER" },
                    { "3", null, "Physician", "PHYSICIAN" },
                    { "4", null, "Nurse", "NURSE" },
                    { "5", null, "Pharmacist", "PHARMACIST" },
                    { "6", null, "Patient", "PATIENT" },
                    { "7", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateddAt", "UserName" },
                values: new object[,]
                {
                    { "12345678912341", 0, "11ca29ea-0b1e-4b26-9d53-047691942eea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "k@gmail.com", false, "أحمد محمد كمال", false, null, "مصري", "K@GMAIL.COM", "@KAMAL123", "AQAAAAIAAYagAAAAEMfgDq2/d/3kp2cdBmuWO2wmrRA3vyFzz/topqrg3evTf627Ljp0xypPvdBqjxMcnQ==", "01234567890", false, "e7c34b70-0365-441e-82c2-b9ba2b485327", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Kamal123" },
                    { "12345678912342", 0, "779c5b70-7987-4714-9c6e-eed783531b59", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A@gmail.com", false, "أحمد محمد أحمد", false, null, "مصري", "A@GMAIL.COM", "@AHMED123", "AQAAAAIAAYagAAAAELw7crU1rxUzgfCTPQIraweZDErDgAnAHZHpJ1G75YeJGEs4S/HTgf7hA0OWroosYw==", "", false, "f4f29088-b45d-4e55-943f-f36dd7402eec", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Ahmed123" },
                    { "12345678912343", 0, "d6da3f1b-d39b-4353-93d1-bcdfeddafc58", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M@gmail.com", false, "أحمد محمد محمد", false, null, "مصري", "M@GMAIL.COM", "@MUHAMMAD123", "AQAAAAIAAYagAAAAEG9lvwOzf2T5oaklCB1WWYBtSjkclieR/pKXTgLjjCQxF73NyRvewbwKC8JVe9jDmA==", "01234567899", false, "69e3fc60-1786-47a5-87fc-e18899ab759c", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Muhammad123" },
                    { "12345678912344", 0, "ffbf3675-0fc7-41d8-993e-aeba56758bc4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al@gmail.com", false, "أحمد محمد علي", false, null, "مصري", "AL@GMAIL.COM", "@ALI123", "AQAAAAIAAYagAAAAEGOh0A3R3tZe6xPn9hPbynKOrz7/WY2NRsxv39v903Xme/79UOSXfH6o1r/4d2/bBw==", "01234567890", false, "2a6dea9f-1329-42b1-92e4-ac4b01cbc4e8", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Ali123" },
                    { "12345678912346", 0, "3fbe783b-9c65-494c-a404-f0569b96cdd3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ka@gmail.com", false, "أحمد خاطر علي", false, null, "مصري", "KA@GMAIL.COM", "@KHATER123", "AQAAAAIAAYagAAAAEHjjMLkbRn7tZlBW5ZEk2mEfEjsiM/5u196rjRDdYnpo7DXa8fgHeIemhK0nHRHmvw==", "", false, "4f117051-c0ab-4b71-a849-b29dce12cb3c", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Khater123" },
                    { "12345678912347", 0, "d6bb9759-4ad3-429d-92d3-88effbfb8b1b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ma@gmail.com", false, "منال خاطر علي", false, null, "مصري", "MA@GMAIL.COM", "@MANAL123", "AQAAAAIAAYagAAAAENEg5dX4h+uWLSHy4RaAn86QwEx2IH4Pqrvo564KPlPmT7nXKRT8ifsjsvd2HJbVNQ==", "", false, "fcd8fcdc-6b8e-4fee-8975-9056dcf2e131", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Manal123" },
                    { "12345678912348", 0, "3126fb81-67cb-4064-bede-ad256bbf6207", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ma2@gmail.com", false, "منال خاطر أحمد", false, null, "مصري", "MA2@GMAIL.COM", "@MANAL2123", "AQAAAAIAAYagAAAAEL37IvVIGi24mg+wEf44VxZ86h+W5eUI+MgmVUukx8mkFOwc7O4qe6wPoetOZy9VIA==", "", false, "2ab0b833-2b13-422b-abb8-f82fa10e7769", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Manal2123" },
                    { "12345678912349", 0, "c94bd0e9-7c1a-467d-96e4-4b24db89a3d5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ka2@gmail.com", false, "خاطر أحمد", false, null, "مصري", "KA2@GMAIL.COM", "@KHATER2123", "AQAAAAIAAYagAAAAEKQVqbDIYFSOakGX6Vsd5BHwjfCJk9cNFeMfnV0+/E93i9jZvUX46CmIhSC2qGz8sQ==", "", false, "5136cfce-e3e9-4407-ba1c-1de0e968c25c", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Khater2123" },
                    { "12345678912350", 0, "7c67776a-34f3-424a-923e-cc15a74fe0f8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TE@gmail.com", false, "test", false, null, "مصري", "TE@GMAIL.COM", "@TEST2123", "AQAAAAIAAYagAAAAEE1nuaxTj+64ygpkNTx7LlXW5y7wRNqPlE8+EhDX/f3SIQUZn0mKmWTBPHOcpidUww==", "", false, "2575e045-8391-49b0-9d61-a978637ede27", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Test2123" },
                    { "12345678912351", 0, "db59e683-f3d9-49f0-8fdf-ded773ec7723", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fa@gmail.com", false, "أحمد فوزي محمد", false, null, "مصري", "FA@GMAIL.COM", "@FAWZY123", "AQAAAAIAAYagAAAAEOKBCcoGdqX/1pBf5PVY4psdDrqGIbyutaF6DIWnNzl2AReXXg66Nd4jZs9bNxiYJg==", "", false, "12db259b-a05b-4e16-8fe5-bdc615d574fe", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Fawzy123" },
                    { "12345678912352", 0, "3dcb5ad4-8e0d-4196-bf8f-7e677f739aee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlFa@gmail.com", false, "علي فوزي محمد", false, null, "مصري", "ALFA@GMAIL.COM", "@ALIFAWZY123", "AQAAAAIAAYagAAAAEFtY6SbqVsmh2ef5T6gW5u/Y6gv/r43borTIPqKicgm3zOQw57o3eQhGOaBfM42b2A==", "", false, "e4d2e315-5353-4145-a8e1-26b382c9a5da", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@AliFawzy123" },
                    { "12345678912353", 0, "bf01d7ab-74e4-463a-be60-136747fc1fcb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AFa@gmail.com", false, "علي فوزي أحمد", false, null, "مصري", "AFA@GMAIL.COM", "@AFAWZY123", "AQAAAAIAAYagAAAAEDm+hZ5jZXNhNOf1/NIj3lVz3TWf3WPbChUG9aSsG9+sGjzJTXKDQoAGfWIca5+8TQ==", "", false, "851b26fd-6eea-4515-b1ee-2bb931e65057", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@AFawzy123" }
                });

            migrationBuilder.InsertData(
                table: "Governorates",
                columns: new[] { "Id", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4916), "القاهرة", new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4927) },
                    { 2, new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4929), "الجيزة", new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4929) },
                    { 3, new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4930), "مطروح", new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4931) },
                    { 4, new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4932), "شمال سيناء", new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4932) },
                    { 5, new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4933), "الشرقية", new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4933) },
                    { 6, new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4934), "الدقهلية", new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4935) }
                });

            migrationBuilder.InsertData(
                table: "ICDs",
                columns: new[] { "Code", "CreatedAt", "DiagnosisName", "UpdatedAt" },
                values: new object[,]
                {
                    { "A00.0", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2741), "Cholera due to Vibrio cholerae 01, biovar cholerae", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2743) },
                    { "A00.1", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2744), "Cholera due to Vibrio cholerae 01, biovar eltor", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2745) },
                    { "A00.9", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2745), "Cholera, unspecified", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2746) },
                    { "A01.00", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2747), "Typhoid fever, unspecified", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2747) }
                });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "Contraindication", "CreatedAt", "Description", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "ممنوع على مرضى الكلى والكبد", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4999), "أقراص", "/Medication/fexofenadine.jpg", "Fexofenadine (الفيكسوفينادين)", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5001) },
                    { 2, "لا يستخدم مع مرضى السكري.....الخ", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5005), "بخاخ أنف", "/Medication/NASONEX.jpg", "Nasonex (نازونكس)", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5005) },
                    { 3, "لا تستخدم مع أي منتجات أخرى تحتوي على الباراسيتامول. يزيد مرض الكبد الأساسي من خطر تلف الكبد المرتبط بالباراسيتامول. يجب على المرضى الذين تم تشخيص إصابتهم بضعف في الكبد أو الكلى طلب المشورة الطبية قبل تناول هذا الدواء.", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5006), "أقراص", "/Medication/advance.jpg", "Panadol Advance (بانادول أدفانس)", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5007) },
                    { 4, "فرط الحساسية لأي من المكونات", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5008), "أقراص", "/Medication/Kerovit.jpg", "Kerovit (كيروفيت)", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5008) }
                });

            migrationBuilder.InsertData(
                table: "Vaccinations",
                columns: new[] { "Id", "AgeRange", "Contraindication", "CreatedAt", "Dosage", "Name", "Note", "Reason", "Route", "SideEffects", "Type", "UpdatedAt", "VaccinationEffectiveness" },
                values: new object[,]
                {
                    { 1, "2-64 عام", "", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6877), "1 dose", "Vaxchora", "", "لقاح يستخدم للوقاية من الكوليرا", "عن طريق الفم", "", "حبوب", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6877), "3-6 أشهر" },
                    { 2, "من عامين وأكبر", "", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6880), "2 doses, given 1–6 weeks apart ", "Dukoral", "Children aged 2–5 years need 3 doses, given 1 to 6 weeks apart", "لقاح يستخدم للوقاية من الكوليرا", "عن طريق الفم", "", "حبوب", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6880), "عامين" }
                });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "Allergen", "CreatedAt", "Instruction", "IsChronic", "Reaction", "RegistrationDataId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "التراب", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5868), "---", true, "سيلان الأنف والكحة", "12345678912351", "حساسية التراب", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5869) },
                    { 2, "الفول السوداني والحليب والبيض", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5871), "", true, "طفح جلدي", "12345678912352", "حساسية الطعام", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5872) },
                    { 3, "فراء الحيوانات ، وخاصة من الحيوانات الأليفة مثل القطط والكلاب", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5874), "الابتعاد عن الحيوانات الأليفة", true, "ضيق في الصدر وفقدان أنفاسك", "12345678912353", "حساسية الحيوانات الأليفة", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5875) }
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
                    { "4", "12345678912347" },
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
                    { 1, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5615), "التدخين", "", "12345678912351", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5616) },
                    { 2, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5618), "التدخين", "", "12345678912352", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5618) },
                    { 3, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5619), "شرب الخمور", "", "12345678912353", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5619) }
                });

            migrationBuilder.InsertData(
                table: "HealthFacilities",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "Email", "GovernorateId", "Phone1", "Phone2", "Phone3", "RegistrationDataId", "SubordinateTo", "Title", "Type", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, "Address1", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2443), "Description1", "m@gmail.com", 1, "01123456878", "", "", "12345678912342", "المؤسسة العسكرية", "المستشفى العسكري بالشرقية", "مستشفى عسكري", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2454) },
                    { 2, "Address2", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2456), "Description2", "a@gmail.com", 1, "01122456878", "", "", "12345678912348", "وزارة الصحة", "المستشفى العام بالعريش", "مستشفى عام", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2457) },
                    { 3, "Address3", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2458), "Description3", "j@gmail.com", 1, "01123416878", "", "", "12345678912349", "مستشفيات الجامعة", "مستشفى الجامعة بالزقازيق", "مستشفى جامعي", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2459) }
                });

            migrationBuilder.InsertData(
                table: "MedicalData",
                columns: new[] { "Id", "BloodGroup", "CreatedAt", "DNAImageResultUrl", "FamilyHistory", "MedicalHistory", "UpdatedAt" },
                values: new object[,]
                {
                    { "12345678912351", "A+", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4229), "", "الجد من الأب كان مصاب بالسكري", "", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4231) },
                    { "12345678912352", "O+", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4233), "", "الجد من الأب كان مصاب بمرض ذهني", "المريض أصيب بحالة من الهلوسة مرتين سابقا", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4233) },
                    { "12345678912353", "AB+", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4234), "", "", "", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4234) }
                });

            migrationBuilder.InsertData(
                table: "MedicalTeam",
                columns: new[] { "Id", "CreatedAt", "Degree", "MedicalSpecialization", "UpdatedAt" },
                values: new object[,]
                {
                    { "12345678912342", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4711), "ماجستير جراحة العمود الفقري", "جراحة العمود الفقري", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4712) },
                    { "12345678912343", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4717), "ماجستير أنف وأذن وحنجرة", "أنف وأذن وحنجرة", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4717) },
                    { "12345678912344", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4718), "بكالوريوس الصيدلة", "طب الصيدلة", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4718) },
                    { "12345678912346", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4719), "معهد فني صحي", "فني أشعة", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4720) },
                    { "12345678912347", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4721), "معهد فني تمريض", "ممرضة", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4721) },
                    { "12345678912348", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4713), "ماجستير أورام العظام", "أورام العظام", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4713) },
                    { "12345678912349", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4714), "دكتوراة أورام المسالك البولية", "أورام المسالك البولية", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4715) },
                    { "12345678912350", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4716), "دكتوراة جراحة القلب", "جراحة القلب", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4716) }
                });

            migrationBuilder.InsertData(
                table: "PersonalData",
                columns: new[] { "Id", "Address", "AgeGroup", "BirthDate", "CreatedAt", "EmergencyPhone1", "EmergencyPhone2", "Gender", "GovernorateId", "NumOfChildren", "Occupation", "Phone1", "UpdatedAt", "UserImageUrl" },
                values: new object[,]
                {
                    { "12345678912351", "", "", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3888), "01234546788", "", "ذكر", 1, 3, "مدرس", "01234546787", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3890), "" },
                    { "12345678912352", "", "", new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3901), "01234746788", "", "ذكر", 3, 1, "دكتور جامعي", "01234544487", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3902), "" },
                    { "12345678912353", "", "", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3909), "01234506788", "", "ذكر", 2, 3, "عمل حر", "01234500787", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3910), "" }
                });

            migrationBuilder.InsertData(
                table: "UserInsurances",
                columns: new[] { "Id", "CreatedAt", "InsuranceNo", "InsuranceOrganizationName", "InsuranceType", "RegistrationDataId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3063), "123OP", "التأمين الصحي المصري", "حكومي", "12345678912351", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3063) },
                    { 2, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3066), "124OP", "التأمين الصحي المصري", "حكومي", "12345678912352", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3066) }
                });

            migrationBuilder.InsertData(
                table: "AllergyDrugs",
                columns: new[] { "Id", "AllergyId", "CreatedAt", "MedicationId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6426), 1, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6426) },
                    { 2, 1, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6428), 2, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6428) }
                });

            migrationBuilder.InsertData(
                table: "BloodDonations",
                columns: new[] { "Id", "CreatedAt", "DonationDateTime", "MedicalTeamId", "RegistrationDataId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5348), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5347), "12345678912347", "12345678912351", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5349) },
                    { 2, new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5351), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5351), "12345678912347", "12345678912352", new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5352) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admits_HealthFacilityId",
                table: "Admits",
                column: "HealthFacilityId");

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
                name: "IX_Contraindications_MedicationId",
                table: "Contraindications",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contraindications_RegistrationDataId_MedicationId",
                table: "Contraindications",
                columns: new[] { "RegistrationDataId", "MedicationId" },
                unique: true,
                filter: "[RegistrationDataId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacilities_GovernorateId",
                table: "HealthFacilities",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacilities_RegistrationDataId",
                table: "HealthFacilities",
                column: "RegistrationDataId");

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
                name: "IX_RadLabResultImages_RadLabResultId",
                table: "RadLabResultImages",
                column: "RadLabResultId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveBloods_AdmitId",
                table: "ReceiveBloods",
                column: "AdmitId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveBloods_RegistrationDataId",
                table: "ReceiveBloods",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Receives_ReceiveBloodId",
                table: "Receives",
                column: "ReceiveBloodId");

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
                name: "RadLabResultImages");

            migrationBuilder.DropTable(
                name: "Receives");

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
                name: "RadLabResult");

            migrationBuilder.DropTable(
                name: "ReceiveBloods");

            migrationBuilder.DropTable(
                name: "Surgeries");

            migrationBuilder.DropTable(
                name: "Vaccinations");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "VisitRadLabTests");

            migrationBuilder.DropTable(
                name: "Admits");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "HealthFacilities");

            migrationBuilder.DropTable(
                name: "ICDs");

            migrationBuilder.DropTable(
                name: "MedicalTeam");

            migrationBuilder.DropTable(
                name: "Governorates");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
