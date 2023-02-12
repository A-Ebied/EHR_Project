using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class addPersonalDataMedicalDataInsuranceData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08743721-c384-43f6-993e-896851b06e6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47efb674-7465-4771-bd96-69d06922efce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c0ac3ae-c4b4-4e4b-b9dd-adc31b383d7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af1c3b81-14d9-4d7b-988a-822e6cda0f91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b859c7bc-0f1f-44d1-8392-eef61b1bcd7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d68078f9-a510-4750-be63-c3db4b63299b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e276388a-e9bb-413f-8257-53acaea1c399");

            migrationBuilder.CreateTable(
                name: "InsuranceData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasGovernmentInsurance = table.Column<bool>(type: "bit", nullable: false),
                    HasAnotherInsurance = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceData_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "PersonalData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumOfChildren = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyPhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                        name: "FK_PersonalData_Governorate_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0deb9968-2f2b-46b6-8088-d2973ec830d0", null, "HealthFacilityManager", "HEALTHFACILITYAMANAGER" },
                    { "1062b39a-ad4c-44a4-9f37-ded3ad0a89c6", null, "Patient", "PATIENT" },
                    { "77c27281-a7c1-4e5e-b359-5e2c67ac9ab9", null, "SystemManager", "SYSTEMMANAGER" },
                    { "8685be63-7c3b-4470-9e07-ebf4f0cf4588", null, "Nurse", "NURSE" },
                    { "da1615b5-2d69-48d9-a453-cdc7516a3244", null, "HealthFacilitiesAdministrator", "HEALTHFACILITIESADMINISTRATOR" },
                    { "e648f93e-c555-4fcd-b9c6-8c42672290cc", null, "Physician", "PHYSICIAN" },
                    { "fd885b14-4014-4714-a538-8b2654494e47", null, "Pharmacist", "PHARMACIST" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_GovernorateId",
                table: "PersonalData",
                column: "GovernorateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsuranceData");

            migrationBuilder.DropTable(
                name: "MedicalData");

            migrationBuilder.DropTable(
                name: "PersonalData");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0deb9968-2f2b-46b6-8088-d2973ec830d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1062b39a-ad4c-44a4-9f37-ded3ad0a89c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77c27281-a7c1-4e5e-b359-5e2c67ac9ab9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8685be63-7c3b-4470-9e07-ebf4f0cf4588");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da1615b5-2d69-48d9-a453-cdc7516a3244");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e648f93e-c555-4fcd-b9c6-8c42672290cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd885b14-4014-4714-a538-8b2654494e47");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08743721-c384-43f6-993e-896851b06e6f", null, "HealthFacilityManager", "HEALTHFACILITYAMANAGER" },
                    { "47efb674-7465-4771-bd96-69d06922efce", null, "HealthFacilitiesAdministrator", "HEALTHFACILITIESADMINISTRATOR" },
                    { "4c0ac3ae-c4b4-4e4b-b9dd-adc31b383d7a", null, "Nurse", "NURSE" },
                    { "af1c3b81-14d9-4d7b-988a-822e6cda0f91", null, "Pharmacist", "PHARMACIST" },
                    { "b859c7bc-0f1f-44d1-8392-eef61b1bcd7c", null, "Patient", "PATIENT" },
                    { "d68078f9-a510-4750-be63-c3db4b63299b", null, "SystemManager", "SYSTEMMANAGER" },
                    { "e276388a-e9bb-413f-8257-53acaea1c399", null, "Physician", "PHYSICIAN" }
                });
        }
    }
}
