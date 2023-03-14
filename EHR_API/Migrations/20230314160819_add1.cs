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
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfTimes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DosageNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraindication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SideEffects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccinations", x => x.Code);
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
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthFacilities", x => x.Id);
                    table.UniqueConstraint("AlternateKey_RegistrationDataId", x => x.RegistrationDataId);
                    table.ForeignKey(
                        name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ICDId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChronicDiseases", x => new { x.RegistrationDataId, x.ICDId });
                    table.ForeignKey(
                        name: "FK_ChronicDiseases_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChronicDiseases_ICDs_ICDId",
                        column: x => x.ICDId,
                        principalTable: "ICDs",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contraindications",
                columns: table => new
                {
                    MedicationId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContraindiReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItsEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsChronic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contraindications", x => new { x.MedicationId, x.RegistrationDataId });
                    table.ForeignKey(
                        name: "FK_Contraindications_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    AllergyId = table.Column<int>(type: "int", nullable: false),
                    MedicationId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyDrugs", x => new { x.AllergyId, x.MedicationId });
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
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HealthFacilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalFacilityTeams", x => new { x.HealthFacilityId, x.MedicalTeamId });
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                    MedicationId = table.Column<int>(type: "int", nullable: false),
                    ICDId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChronicDiseaseDrugs", x => new { x.RegistrationDataId, x.ICDId, x.MedicationId });
                    table.ForeignKey(
                        name: "FK_ChronicDiseaseDrugs_ChronicDiseases_ICDId_RegistrationDataId",
                        columns: x => new { x.ICDId, x.RegistrationDataId },
                        principalTable: "ChronicDiseases",
                        principalColumns: new[] { "RegistrationDataId", "ICDId" },
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
                    table.PrimaryKey("PK_Admits", x => x.VisitId);
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
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    VaccinationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVaccinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserVaccinations_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserVaccinations_Vaccinations_VaccinationId",
                        column: x => x.VaccinationId,
                        principalTable: "Vaccinations",
                        principalColumn: "Code");
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
                    table.PrimaryKey("PK_VisitMedications", x => new { x.MedicationId, x.VisitId });
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
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "VisitId",
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
                        principalColumn: "VisitId",
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
                    { "12345678912341", 0, "31f5ada6-2ba1-4161-b7dd-f7d5cb7a3419", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "k@gmail.com", false, "أحمد محمد كمال", false, null, "مصري", "K@GMAIL.COM", "@KAMAL123", "AQAAAAIAAYagAAAAEM9/Z6K7ZEpJt9gekNTBouk05WuqDI15BGMD7rBaBUm9OXhq826nmZQH9RTD4QZK7A==", "01234567890", false, "b0f4b34c-f2b6-4007-b74d-1f90a9ca9469", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Kamal123" },
                    { "12345678912342", 0, "59fb8368-02f7-43bd-8465-f4da0ab0868b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A@gmail.com", false, "أحمد محمد أحمد", false, null, "مصري", "A@GMAIL.COM", "@AHMED123", "AQAAAAIAAYagAAAAEDh4DBGtwFA8/mHYepdBgBEt4oeSllNlNZoT9VC1y3/+kCnD9aulo/xzgrxx38E0IA==", "", false, "9fa13c40-c5d3-41b7-beeb-332cf26e82f7", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Ahmed123" },
                    { "12345678912343", 0, "d9068ac7-2058-45e2-ba72-72f4ca213498", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M@gmail.com", false, "أحمد محمد محمد", false, null, "مصري", "M@GMAIL.COM", "@MUHAMMAD123", "AQAAAAIAAYagAAAAEOkHRrwhCLVPEyDPnVCVA7gj88602WG4LzP5C0bazy2Vosnwc6SzytfgrYtOt4UJCA==", "01234567899", false, "89457e94-db82-47ef-8852-11ac2704406c", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Muhammad123" },
                    { "12345678912344", 0, "356a872a-e2c6-4cf7-8c0d-68f6ea3147d3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al@gmail.com", false, "أحمد محمد علي", false, null, "مصري", "AL@GMAIL.COM", "@ALI123", "AQAAAAIAAYagAAAAEBbanvPHs1etHUhI1qG4axJAGhPy1DdaKPIS2Gtky2r5A211j7INX6spQvkX4A0IDg==", "01234567890", false, "302865eb-0b36-462f-b6a1-f4d3b90ec680", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Ali123" },
                    { "12345678912346", 0, "c9776ebb-c760-4496-a4a5-cfd627435850", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ka@gmail.com", false, "أحمد خاطر علي", false, null, "مصري", "KA@GMAIL.COM", "@KHATER123", "AQAAAAIAAYagAAAAEKHz0ylbq+uj10OP3L8iTk+Hd7DtOw4MTu9DBvYilGRUj4OljgQhQh4OjJ7Sp5Dddw==", "", false, "5aa2c4a7-abc1-420f-9c4f-76d1f56491ec", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Khater123" },
                    { "12345678912347", 0, "3d7f65f6-1e1a-4e7f-91f7-4ddfcf4686ad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ma@gmail.com", false, "منال خاطر علي", false, null, "مصري", "MA@GMAIL.COM", "@MANAL123", "AQAAAAIAAYagAAAAEBc6qa2JNmzGqbioEo8SHzhjiym6NFYBqNWVRieWZFLjj79kGffokMnr9oNLgnLijg==", "", false, "854e7947-4d57-4549-bd96-c085633aea12", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Manal123" },
                    { "12345678912348", 0, "47b047e2-0992-400f-ba7a-6c904ea6b5ca", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ma2@gmail.com", false, "منال خاطر أحمد", false, null, "مصري", "MA2@GMAIL.COM", "@MANAL2123", "AQAAAAIAAYagAAAAENdqai3HoSryh7eri4osUiyH9ehT4RQXHmVIUW7U/ypaYN1mkfoKXlnkvVfQXq8v3w==", "", false, "100f7248-f014-4ef3-ac62-5bbfd3a4f228", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Manal2123" },
                    { "12345678912349", 0, "1d651bff-6d05-43e8-8292-4633d5467fd5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ka2@gmail.com", false, "خاطر أحمد", false, null, "مصري", "KA2@GMAIL.COM", "@KHATER2123", "AQAAAAIAAYagAAAAED46f6IFonuxRtaiD3reaJfjoXefqg8a+SvqmrC+rsOH2IOLyU4ihg1P56+9W80pcg==", "", false, "d2accacd-ec94-450f-a972-93d608141608", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Khater2123" },
                    { "12345678912350", 0, "88cb8984-ee2f-48a7-b057-a7745e7875ba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TE@gmail.com", false, "test", false, null, "مصري", "TE@GMAIL.COM", "@TEST2123", "AQAAAAIAAYagAAAAEFfr2WFVj4KtmKEDofRdeOZTN2pQX+abk4w/cmigRgTiY04Wkaqa7daLb5iMYx0nTg==", "", false, "e28b8c46-03c9-47f7-a3df-108660fdf05a", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Test2123" },
                    { "12345678912351", 0, "0849cb28-e19e-4d42-9b30-a6a357036569", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fa@gmail.com", false, "أحمد فوزي محمد", false, null, "مصري", "FA@GMAIL.COM", "@FAWZY123", "AQAAAAIAAYagAAAAECPKbBugmBwEBtlIKOM2wprWxNvh7IEG7XBryrwmvdy+BR+gn4rrritPkA6bxJHZIA==", "", false, "01672632-ab97-4a7a-a19e-8b000dd6f11f", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Fawzy123" },
                    { "12345678912352", 0, "ce4d9578-7e70-4e45-8ff5-f8b41befe723", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlFa@gmail.com", false, "علي فوزي محمد", false, null, "مصري", "ALFA@GMAIL.COM", "@ALIFAWZY123", "AQAAAAIAAYagAAAAEHLsZkl8GFJRFy36B6weHAbQbZz57+nRw9g4LNEwfMQABjQ2bgEn5AvYZkKGR3IE+Q==", "", false, "64b005b8-f1ef-427e-8aab-bba1a1e34632", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@AliFawzy123" },
                    { "12345678912353", 0, "4fc39d1a-25d5-4ef4-82d4-d2541458fc62", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AFa@gmail.com", false, "علي فوزي أحمد", false, null, "مصري", "AFA@GMAIL.COM", "@AFAWZY123", "AQAAAAIAAYagAAAAEAFz0tx7EAsPZhkvvCf07j0giAEQBFeRfphaFmV3wCKakDwUG41EPeVjxwSlvVIFuw==", "", false, "991af6cc-18c3-4fa3-a944-bd5d1a2c0496", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@AFawzy123" }
                });

            migrationBuilder.InsertData(
                table: "Governorates",
                columns: new[] { "Id", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5596), "القاهرة", new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5602) },
                    { 2, new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5605), "الجيزة", new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5606) },
                    { 3, new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5607), "مطروح", new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5608) },
                    { 4, new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5609), "شمال سيناء", new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5610) },
                    { 5, new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5611), "الشرقية", new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5612) },
                    { 6, new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5613), "الدقهلية", new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5613) }
                });

            migrationBuilder.InsertData(
                table: "ICDs",
                columns: new[] { "Code", "CreatedAt", "DiagnosisName", "UpdatedAt" },
                values: new object[,]
                {
                    { "A00.0", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2104), "Cholera due to Vibrio cholerae 01, biovar cholerae", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2105) },
                    { "A00.1", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2109), "Cholera due to Vibrio cholerae 01, biovar eltor", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2109) },
                    { "A00.9", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2111), "Cholera, unspecified", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2112) },
                    { "A01.00", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2113), "Typhoid fever, unspecified", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2114) }
                });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "Contraindication", "CreatedAt", "Description", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "ممنوع على مرضى الكلى والكبد", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5232), "أقراص", "D:\\0_MY_DATA\\2_IT\\Level_4\\IT Project\\Project\\Backend\\V 1.0 -  API with MVC\\EHR_Project\\EHR_API\\wwwroot\\images\\Medication\\fexofenadine.jpg", "Fexofenadine (الفيكسوفينادين)", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5234) },
                    { 2, "لا يستخدم مع مرضى السكري.....الخ", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5238), "بخاخ أنف", "D:\\0_MY_DATA\\2_IT\\Level_4\\IT Project\\Project\\Backend\\V 1.0 -  API with MVC\\EHR_Project\\EHR_API\\wwwroot\\images\\Medication\\NASONEX.jpg", "Nasonex (نازونكس)", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5239) },
                    { 3, "لا تستخدم مع أي منتجات أخرى تحتوي على الباراسيتامول. يزيد مرض الكبد الأساسي من خطر تلف الكبد المرتبط بالباراسيتامول. يجب على المرضى الذين تم تشخيص إصابتهم بضعف في الكبد أو الكلى طلب المشورة الطبية قبل تناول هذا الدواء.", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5241), "أقراص", "D:\\0_MY_DATA\\2_IT\\Level_4\\IT Project\\Project\\Backend\\V 1.0 -  API with MVC\\EHR_Project\\EHR_API\\wwwroot\\images\\Medication\\advance.jpg", "Panadol Advance (بانادول أدفانس)", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5241) },
                    { 4, "فرط الحساسية لأي من المكونات", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5243), "أقراص", "D:\\0_MY_DATA\\2_IT\\Level_4\\IT Project\\Project\\Backend\\V 1.0 -  API with MVC\\EHR_Project\\EHR_API\\wwwroot\\images\\Medication\\Kerovit.jpg", "Kerovit (كيروفيت)", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5244) }
                });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "Id", "Allergen", "CreatedAt", "Instruction", "IsChronic", "Reaction", "RegistrationDataId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "التراب", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7156), "---", true, "سيلان الأنف والكحة", "12345678912351", "حساسية التراب", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7157) },
                    { 2, "الفول السوداني والحليب والبيض", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7161), "", true, "طفح جلدي", "12345678912352", "حساسية الطعام", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7161) },
                    { 3, "فراء الحيوانات ، وخاصة من الحيوانات الأليفة مثل القطط والكلاب", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7165), "الابتعاد عن الحيوانات الأليفة", true, "ضيق في الصدر وفقدان أنفاسك", "12345678912353", "حساسية الحيوانات الأليفة", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7166) }
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
                    { 1, new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6613), "التدخين", "", "12345678912351", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6614) },
                    { 2, new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6617), "التدخين", "", "12345678912352", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6618) },
                    { 3, new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6619), "شرب الخمور", "", "12345678912353", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6620) }
                });

            migrationBuilder.InsertData(
                table: "HealthFacilities",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "Email", "GovernorateId", "Phone1", "Phone2", "Phone3", "RegistrationDataId", "SubordinateTo", "Title", "Type", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, "Address1", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1420), "Description1", "m@gmail.com", 1, "01123456878", "", "", "12345678912342", "المؤسسة العسكرية", "المستشفى العسكري بالشرقية", "مستشفى عسكري", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1429) },
                    { 2, "Address2", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1434), "Description2", "a@gmail.com", 1, "01122456878", "", "", "12345678912348", "وزارة الصحة", "المستشفى العام بالعريش", "مستشفى عام", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1434) },
                    { 3, "Address3", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1439), "Description3", "j@gmail.com", 1, "01123416878", "", "", "12345678912349", "مستشفيات الجامعة", "مستشفى الجامعة بالزقازيق", "مستشفى جامعي", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1439) }
                });

            migrationBuilder.InsertData(
                table: "MedicalData",
                columns: new[] { "Id", "BloodGroup", "CreatedAt", "DNAImageResultUrl", "FamilyHistory", "MedicalHistory", "UpdatedAt" },
                values: new object[,]
                {
                    { "12345678912351", "A+", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4128), "", "الجد من الأب كان مصاب بالسكري", "", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4129) },
                    { "12345678912352", "O+", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4132), "", "الجد من الأب كان مصاب بمرض ذهني", "المريض أصيب بحالة من الهلوسة مرتين سابقا", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4133) },
                    { "12345678912353", "AB+", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4135), "", "", "", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4136) }
                });

            migrationBuilder.InsertData(
                table: "MedicalTeam",
                columns: new[] { "Id", "CreatedAt", "Degree", "MedicalSpecialization", "UpdatedAt" },
                values: new object[,]
                {
                    { "12345678912342", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4668), "ماجستير جراحة العمود الفقري", "جراحة العمود الفقري", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4670) },
                    { "12345678912343", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4681), "ماجستير أنف وأذن وحنجرة", "أنف وأذن وحنجرة", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4681) },
                    { "12345678912344", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4683), "بكالوريوس الصيدلة", "طب الصيدلة", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4684) },
                    { "12345678912346", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4685), "معهد فني صحي", "فني أشعة", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4686) },
                    { "12345678912347", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4687), "معهد فني تمريض", "ممرضة", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4688) },
                    { "12345678912348", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4674), "ماجستير أورام العظام", "أورام العظام", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4675) },
                    { "12345678912349", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4676), "دكتوراة أورام المسالك البولية", "أورام المسالك البولية", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4677) },
                    { "12345678912350", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4678), "دكتوراة جراحة القلب", "جراحة القلب", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4679) }
                });

            migrationBuilder.InsertData(
                table: "PersonalData",
                columns: new[] { "Id", "Address", "AgeGroup", "BirthDate", "CreatedAt", "EmergencyPhone1", "EmergencyPhone2", "Gender", "GovernorateId", "NumOfChildren", "Occupation", "Phone1", "UpdatedAt", "UserImageUrl" },
                values: new object[,]
                {
                    { "12345678912351", "", "", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3526), "01234546788", "", "ذكر", 1, 3, "مدرس", "01234546787", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3527), "" },
                    { "12345678912352", "", "", new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3547), "01234746788", "", "ذكر", 3, 1, "دكتور جامعي", "01234544487", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3548), "" },
                    { "12345678912353", "", "", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3557), "01234506788", "", "ذكر", 2, 3, "عمل حر", "01234500787", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3558), "" }
                });

            migrationBuilder.InsertData(
                table: "UserInsurances",
                columns: new[] { "Id", "CreatedAt", "InsuranceNo", "InsuranceOrganizationName", "InsuranceType", "RegistrationDataId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2798), "123OP", "التأمين الصحي المصري", "حكومي", "12345678912351", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2800) },
                    { 2, new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2803), "124OP", "التأمين الصحي المصري", "حكومي", "12345678912352", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2803) }
                });

            migrationBuilder.InsertData(
                table: "AllergyDrugs",
                columns: new[] { "AllergyId", "MedicationId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7861) },
                    { 1, 2, new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7863) }
                });

            migrationBuilder.InsertData(
                table: "BloodDonations",
                columns: new[] { "Id", "CreatedAt", "DonationDateTime", "MedicalTeamId", "RegistrationDataId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5780), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5776), "12345678912347", "12345678912351", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5781) },
                    { 2, new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5785), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5784), "12345678912347", "12345678912352", new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5786) }
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
                name: "IX_ChronicDiseaseDrugs_ICDId_RegistrationDataId",
                table: "ChronicDiseaseDrugs",
                columns: new[] { "ICDId", "RegistrationDataId" });

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseaseDrugs_MedicationId",
                table: "ChronicDiseaseDrugs",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseases_ICDId",
                table: "ChronicDiseases",
                column: "ICDId");

            migrationBuilder.CreateIndex(
                name: "IX_Contraindications_RegistrationDataId",
                table: "Contraindications",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacilities_GovernorateId",
                table: "HealthFacilities",
                column: "GovernorateId");

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
                name: "IX_UserVaccinations_RegistrationDataId",
                table: "UserVaccinations",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVaccinations_VaccinationId",
                table: "UserVaccinations",
                column: "VaccinationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVaccinations_VisitId",
                table: "UserVaccinations",
                column: "VisitId");

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
