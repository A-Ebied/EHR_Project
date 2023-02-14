using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "012ae972-efa5-4ee3-8228-d4a4a83230ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16bc0341-6640-499c-b99d-6ccbd66ed65d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "202a9946-2adc-4f99-90dd-fa0af1720f6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49717ecd-9886-4a21-9dc2-0fa3e50f9cab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d4e1c4b-0f14-466a-9c3a-8b750e4d9166");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "533b03a6-7d85-435b-b0ca-9fc8f8a7acab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92a53045-ab77-458c-b02a-bd1c175199cd");

            migrationBuilder.DropColumn(
                name: "MedicalSpecializationId",
                table: "MedicalTeam");

            migrationBuilder.AddColumn<string>(
                name: "MedicalSpecialization",
                table: "MedicalTeam",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1dae6b2f-36bf-473b-8fd4-d07c2a6f26ed", null, "HealthFacilityManager", "HEALTHFACILITYAMANAGER" },
                    { "1dc906c4-ece8-48af-aea1-650345b5554a", null, "Pharmacist", "PHARMACIST" },
                    { "3fd68925-4454-4b21-bdaf-b36e3902a2aa", null, "Nurse", "NURSE" },
                    { "64465600-f4e3-4c36-aac8-4ea852d90e59", null, "SystemManager", "SYSTEMMANAGER" },
                    { "b8a35f10-2a07-4570-adc1-5f871453f070", null, "Patient", "PATIENT" },
                    { "dea9d273-dc91-4e2c-aed8-0f986bbc039e", null, "HealthFacilitiesAdministrator", "HEALTHFACILITIESADMINISTRATOR" },
                    { "ea3edd88-6f6d-46c1-91c8-059a50cf7238", null, "Physician", "PHYSICIAN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dae6b2f-36bf-473b-8fd4-d07c2a6f26ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dc906c4-ece8-48af-aea1-650345b5554a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fd68925-4454-4b21-bdaf-b36e3902a2aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64465600-f4e3-4c36-aac8-4ea852d90e59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8a35f10-2a07-4570-adc1-5f871453f070");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dea9d273-dc91-4e2c-aed8-0f986bbc039e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3edd88-6f6d-46c1-91c8-059a50cf7238");

            migrationBuilder.DropColumn(
                name: "MedicalSpecialization",
                table: "MedicalTeam");

            migrationBuilder.AddColumn<int>(
                name: "MedicalSpecializationId",
                table: "MedicalTeam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "012ae972-efa5-4ee3-8228-d4a4a83230ba", null, "Physician", "PHYSICIAN" },
                    { "16bc0341-6640-499c-b99d-6ccbd66ed65d", null, "Nurse", "NURSE" },
                    { "202a9946-2adc-4f99-90dd-fa0af1720f6e", null, "Pharmacist", "PHARMACIST" },
                    { "49717ecd-9886-4a21-9dc2-0fa3e50f9cab", null, "HealthFacilityManager", "HEALTHFACILITYAMANAGER" },
                    { "4d4e1c4b-0f14-466a-9c3a-8b750e4d9166", null, "SystemManager", "SYSTEMMANAGER" },
                    { "533b03a6-7d85-435b-b0ca-9fc8f8a7acab", null, "Patient", "PATIENT" },
                    { "92a53045-ab77-458c-b02a-bd1c175199cd", null, "HealthFacilitiesAdministrator", "HEALTHFACILITIESADMINISTRATOR" }
                });
        }
    }
}
