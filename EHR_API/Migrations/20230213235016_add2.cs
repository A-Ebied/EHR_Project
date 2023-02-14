using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13c5aae0-9542-466f-ae0f-6a79e61a8a92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "477a45a9-d63e-434b-9cd8-8af998f42261");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6736cc4c-81c6-4797-ab3d-11beb5def9c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a5342b8-1d45-458e-8399-a4116ed5c572");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1216176-21b5-4658-b58e-abf08aebe84c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c27e387b-2446-4241-895a-ae2bcae44f52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f85f62da-573b-4d85-a041-e3fdf9c32fa8");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Patient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "Patient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MedicalTeam",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "MedicalTeam",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CreatedAt",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MedicalTeam");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "MedicalTeam");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13c5aae0-9542-466f-ae0f-6a79e61a8a92", null, "HealthFacilityManager", "HEALTHFACILITYAMANAGER" },
                    { "477a45a9-d63e-434b-9cd8-8af998f42261", null, "HealthFacilitiesAdministrator", "HEALTHFACILITIESADMINISTRATOR" },
                    { "6736cc4c-81c6-4797-ab3d-11beb5def9c0", null, "SystemManager", "SYSTEMMANAGER" },
                    { "8a5342b8-1d45-458e-8399-a4116ed5c572", null, "Patient", "PATIENT" },
                    { "b1216176-21b5-4658-b58e-abf08aebe84c", null, "Physician", "PHYSICIAN" },
                    { "c27e387b-2446-4241-895a-ae2bcae44f52", null, "Nurse", "NURSE" },
                    { "f85f62da-573b-4d85-a041-e3fdf9c32fa8", null, "Pharmacist", "PHARMACIST" }
                });
        }
    }
}
