using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class addAllModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInsurance_AspNetUsers_RegistrationDataId",
                table: "UserInsurance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInsurance",
                table: "UserInsurance");

            migrationBuilder.RenameTable(
                name: "UserInsurance",
                newName: "UserInsurances");

            migrationBuilder.RenameIndex(
                name: "IX_UserInsurance_RegistrationDataId",
                table: "UserInsurances",
                newName: "IX_UserInsurances_RegistrationDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInsurances",
                table: "UserInsurances",
                column: "Id");

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
                name: "BadHabits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Habit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "Medications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraindication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SideEffects = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d5dc8da-5cdc-487f-88d2-144b7d5cf079", "AQAAAAIAAYagAAAAED9AudwfMdHZrCQtMcuSNdVrxZ8qLSzGFX5zu3ygsBSOeWdfIFl7sf6l6FPrOfOUNQ==", "ed42894b-7c05-4ad8-8ac9-ad6105aa1d6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa520e37-be5c-4c37-aa58-0cbf8c077309", "AQAAAAIAAYagAAAAEF3ThaPIZkgxmvTYKChGDYVNG1jPCUi7t71oxA6SSSZkdRg2tUHAAExLK2sSy49abQ==", "ad332d4f-d75c-4e49-bdca-b3d1fa10059a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2af4bf8d-49fd-40b5-aa4f-52012eabe104", "AQAAAAIAAYagAAAAEHNdC2Qnl3S+qLgZMmUwAn5S5Fa+ar0+2ta9baa0aOwjndo20zj8Mo5h6ZJivSQgNw==", "e1245de3-1e4d-4b6b-8251-5d5ecde73590" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6744f26-6a4a-48f8-9ae1-7fee64df0ae5", "AQAAAAIAAYagAAAAEMS98cosJRW2JzodvI1qqRagQSyXq0yiYpRFhV0BJ/LzPanNSxgL6StDERiu6+Z0Rw==", "504d014d-cfcb-4ff1-b1d4-b12054c507a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dacbe46-ee6e-47db-aae2-86fada1ba628", "AQAAAAIAAYagAAAAEK8yeA0RfYihhn3NezPHPnOOh6RjHrjuXI8gtzJdKhjylHzu4+cDmqrXRo/1TT7Jzw==", "5a9a6aa2-2b93-41b2-9851-ed14f1d8656c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01d31a6a-f3d1-4dae-a243-215b7535b923", "AQAAAAIAAYagAAAAEBImLEP+erHLcdu+pQiuB7+ZgnVXWBvP3iqssSFyqL4cQ3+nXb0P3aHNHklBT48Ctg==", "9c33abf7-4ce1-4e4f-b09e-767c856556c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bf77dd3-39fe-4604-9d0b-dd3ee4e592ee", "AQAAAAIAAYagAAAAELuLTwuEZo1wLSARqf0eH4SCjwcJ2s8QDu2QlqK/xuQbHNuBMu2smQSt2n2SVMrXuw==", "c9a0a29e-e47b-4ddd-90fa-85e7d02aff59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff553f34-58b9-4999-b948-3647db1d0d20", "AQAAAAIAAYagAAAAEOLtPurzGQSRkbdl6QfV5hqPpqdlM7VRoLt+S2iYt9np3/fYfdqRkAlQW7MOsQOO8g==", "792a5186-7b28-4275-8241-4b661d9a9925" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fd3c4aa-abc7-439a-a9ca-1eed6e58af6c", "AQAAAAIAAYagAAAAEDo9TMGwQdMKQCOtus7UsUyQpVdQa7irAGv6rg89bIaW62/8iQZXXNceAoiU1tTkvA==", "02636644-3690-4515-a438-fd31db6916dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf5b07b-d3b7-4b49-bbb4-f607d84b8b3e", "AQAAAAIAAYagAAAAECLXgkVjxYePvALIoga5U3wml0iBZdKXvT0m9g7Oqt6wwEsSkC3EcYuCDieEa8KrUA==", "75e745ec-c117-47bd-b4b2-b698aef03965" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1297), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1309), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1311), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1312), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1314), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1315), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(449), new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(470), new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(470) });

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
                name: "IX_MedicalFacilityTeams_MedicalTeamId",
                table: "MedicalFacilityTeams",
                column: "MedicalTeamId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsurances_AspNetUsers_RegistrationDataId",
                table: "UserInsurances",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInsurances_AspNetUsers_RegistrationDataId",
                table: "UserInsurances");

            migrationBuilder.DropTable(
                name: "AllergyDrugs");

            migrationBuilder.DropTable(
                name: "BadHabits");

            migrationBuilder.DropTable(
                name: "BloodDonations");

            migrationBuilder.DropTable(
                name: "ChronicDiseaseDrugs");

            migrationBuilder.DropTable(
                name: "Contraindications");

            migrationBuilder.DropTable(
                name: "MedicalFacilityTeams");

            migrationBuilder.DropTable(
                name: "PhysicalTherapy");

            migrationBuilder.DropTable(
                name: "RadLabResultImages");

            migrationBuilder.DropTable(
                name: "Receives");

            migrationBuilder.DropTable(
                name: "SurgeryProgressNotes");

            migrationBuilder.DropTable(
                name: "UserVaccinations");

            migrationBuilder.DropTable(
                name: "VisitMedications");

            migrationBuilder.DropTable(
                name: "VisitVitalSigns");

            migrationBuilder.DropTable(
                name: "Allergies");

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
                name: "ICDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInsurances",
                table: "UserInsurances");

            migrationBuilder.RenameTable(
                name: "UserInsurances",
                newName: "UserInsurance");

            migrationBuilder.RenameIndex(
                name: "IX_UserInsurances_RegistrationDataId",
                table: "UserInsurance",
                newName: "IX_UserInsurance_RegistrationDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInsurance",
                table: "UserInsurance",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "498e9488-9c06-4fe4-858a-c431c7d33daf", "AQAAAAIAAYagAAAAEDG3Vaf6J141woK8ny1VdD/+dHoC5pKIbD8O4UOBQ/ob0ZamWa9rqLpXaPASXod0fQ==", "43d3ab07-f4a4-47e1-84c1-e1b1265d67b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6a7e4e8-a301-4179-ab4d-7d41e6a9b12b", "AQAAAAIAAYagAAAAEDk7xbJi7cKMgOdh3MRAWmUtw4xQH/XRhcdiPYjVTG7jfTGQlXZNADo3tRzgtMCmmQ==", "488cf835-323a-475a-9bb6-04d03378c023" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21694970-5bf5-473e-82e1-c5441e459921", "AQAAAAIAAYagAAAAECDlaOtihH04d6EbHcqMlxsuG2Q6GDLXeg+GWMCRh29ZUWHcDVEcOUFFPSkyNFJv6g==", "11d4bdc1-cdba-451f-9341-3ee4b6885138" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be7c42bd-28d6-4f53-8bee-d9f8f5359c8d", "AQAAAAIAAYagAAAAEEtc3jUJz7XtYp1b0w9ZkWl1uO1uxka+alHZBKqOCSdksQTxHrZ1lXC+cGXzqOAhOg==", "0928e7f1-2640-47b1-9dc5-c0c49a945536" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6711ca2-388c-4095-b33e-2712b6ead875", "AQAAAAIAAYagAAAAEPnpTVYckEVv7ui19NYn6Zhx6qwOxvH3uksYvgDm0oYDhEMaH4J17Tus+ZDAj2LOrg==", "a7eab8fd-4592-4fff-becb-b75ab3273244" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24c02749-dca4-41f9-8477-dd78d50a5486", "AQAAAAIAAYagAAAAEAzKHtIAeLIczwhDd5mrjgcUL/XUEhyY657nh1wD8E727Q42mhvYJeYk+9lRTlp7Qw==", "c994f89c-f826-47d0-845e-9725108ecd49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c87fce7-0231-47ac-9812-addb9986b79b", "AQAAAAIAAYagAAAAEFcpw/nDFQJMKWItOWFnC2MALWOMywKZi5GzoFZg6DFJ5Z3gFl+1KTOvQwCokq3CzA==", "6f25d438-cc62-45c9-87b5-f55445e88e27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7a52ff8-8d51-44cc-81a3-fbe78b25034b", "AQAAAAIAAYagAAAAEOBFkSIbK4+e9thxHu24J4cRBQJxqb9Fjfmt/waZ6UdyW7cmCZM5TCQvMvcBxsieBQ==", "78fffd46-2ca4-4247-ac57-fb9737a23961" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d08b2a0-e91d-4d97-9874-905bf3f04902", "AQAAAAIAAYagAAAAEOMwpkeE78x9eIyXSnr5AjfzrjE02VfcUQbDujcurMRPkz5/UA4Uy4ILWLKlJ9pwRQ==", "a9a2ed33-003f-4aa8-8652-817a5ca2aa94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d53bcbd-bb59-44bf-922f-5f4d874b0cf6", "AQAAAAIAAYagAAAAECbIqQPM4FFf4O0DXvJpZ/e4aKPMhWCNKekkZnUsTZ6y11VwEDjA0B40IzdKkoncgg==", "7c9c6e53-a194-46c8-a41b-94e1e03058e7" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9089), new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9105), new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9107), new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9108), new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9111), new DateTime(2023, 2, 25, 4, 23, 53, 736, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 25, 4, 23, 54, 617, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 2, 25, 4, 23, 54, 617, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 25, 4, 23, 54, 617, DateTimeKind.Local).AddTicks(6636), new DateTime(2023, 2, 25, 4, 23, 54, 617, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 25, 4, 23, 54, 617, DateTimeKind.Local).AddTicks(6639), new DateTime(2023, 2, 25, 4, 23, 54, 617, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsurance_AspNetUsers_RegistrationDataId",
                table: "UserInsurance",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
