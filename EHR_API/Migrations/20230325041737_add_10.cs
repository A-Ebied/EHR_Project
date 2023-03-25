using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "RadLabResultImages");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2371), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2375), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2378), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2661), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "614efe4e-b378-4f8c-af9e-d15c7f389d91", "AQAAAAIAAYagAAAAEFjG022Qb+9YdZLggyPfL3A7NmqMBI7veiR1OQ1FZVs55YRxst4bL/P3tAy1JeHJUA==", "37c14eb6-ef9c-43bf-a0f1-56fb69505225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50c1b642-0e00-45d6-b5b9-5be0700ed69f", "AQAAAAIAAYagAAAAEP6UcpWGh3EN/B1EpvlIFfopfasFPGMZ0ULb7bQlaRREbZXX+fVRipd1StnCBRc+VA==", "a35e7e39-3260-416e-be08-4a66a7304257" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7ca1ca4-9afd-4127-97c6-c2483719e495", "AQAAAAIAAYagAAAAEITYliniruvTbFhFffaTClOUC0XXKCeBVWrz7ew9o2zLPUyAjqFBeFbOtHFJjeDrCw==", "9dd5656a-08ef-4951-8220-7c2e065383b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abb9b650-a70f-400b-a03d-9fefe2e85084", "AQAAAAIAAYagAAAAEGQunvz9gvEOGUu31P6vM9/xiaVPegknWwC+3ElzWos/62wEoHz2qCLctfczjs3UHQ==", "0a3560d5-60ff-44e3-8c97-d8df21ed4be3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6164f0ab-9381-40d7-83c9-bb933f062d9c", "AQAAAAIAAYagAAAAELcZHwvuWnMk1CeP4XDUF+qk6tHqiwbR8wRLVBYaB23u5XdG7AvGSEXbJgpRYf4qzQ==", "901303cd-4e4b-499c-b201-2dd778d05a92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03352e47-cac1-4cc4-b951-4ccbbb7d93fc", "AQAAAAIAAYagAAAAEOzCgVi6Ovlm99/GEhbqceZtvPW8wyZR7kckwyP0XTJYsdJiSOhUtom5UtEpwHFN6Q==", "139846b8-214b-4af7-bfbb-7b36355c01d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d834dacf-7e02-4f4d-9a55-36bebc8c4fa8", "AQAAAAIAAYagAAAAEBZaLVrkYelHZeKfZ7qgTSHiER3VlZvQLqQUFXWXbqjHf73I7KvmRTAHzcMercRiZg==", "374b2540-3eb0-4644-8434-528943352dad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "373c1cf6-a95e-4ac0-8392-01537a086a9c", "AQAAAAIAAYagAAAAEHfkvfmnQRGdqNNl6H/dZ//SrEcrKF2ti0fudYwxpxLNn76vW61KrdJn5HxeVkFnxw==", "4b911504-75d0-4aa8-a29e-d9c95cc148ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1428cef8-a680-43b7-b96a-11000a5c6bf9", "AQAAAAIAAYagAAAAEMu0ovSu6R0UmqzcXMNkm7Otq0SEUac8v4Ih+/+muFuCGFvam/bgFAJ+SQmKJGxwcw==", "19fb1b15-e3ea-4e7c-951c-5f7b8e27b4b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a3cd065-c7a0-4808-bc8e-81c412b34b19", "AQAAAAIAAYagAAAAEIM0shSReKtkqgBZcB6G8Qb+FIRCx91ihf6ZoT9AdJ1s9hTJuixyHyloAsyzrMc23g==", "7b42724a-240c-4f62-90cf-e178567fa81d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a25e6db-1b52-4281-8942-e5091f309687", "AQAAAAIAAYagAAAAEFFvurSIou1q/cCsxXKCp4+2IgpCcCKZFxEEI3n+ZVOnhFcisuJ87BUlkPxSseKj6g==", "b3b45c42-f419-4235-9b4e-6a730f2a1fee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7594cdf3-0be1-4cda-b230-2c1d99750253", "AQAAAAIAAYagAAAAEL6dVtV5ASqPoK5KVmzzzpJg1NNJGwO4HhQ2I+R7oWTH5xmaKVaApdx7j7x+jqoMbA==", "16730afa-a98a-4fba-a2a6-163d4dcaf499" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2121), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2123), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2125), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1864), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1862), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1870), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1869), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8688), new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8708), new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8711), new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8713), new DateTime(2023, 3, 25, 6, 17, 36, 261, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 104, DateTimeKind.Local).AddTicks(9799), new DateTime(2023, 3, 25, 6, 17, 37, 104, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 104, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 3, 25, 6, 17, 37, 104, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 104, DateTimeKind.Local).AddTicks(9808), new DateTime(2023, 3, 25, 6, 17, 37, 104, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(78), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(81), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(82), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(83), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(989), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(992), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(993), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1243), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1250), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1251), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1254), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1246), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1248), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1249), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1590), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(700), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(709), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(714), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(335), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(338), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(3004), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 3, 25, 6, 17, 37, 105, DateTimeKind.Local).AddTicks(3007) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "RadLabResultImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8694), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8699), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8703), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(9041), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aee4ab3-43fa-46d6-98f1-b678fce06b70", "AQAAAAIAAYagAAAAENIbXjrQiPrfZc7kpzsTHq/kkhF4pavwvKmodOStgS0A/UxrlFdoymNStg2WLLKqDA==", "ebd0029f-3438-4163-a1ce-983828f483c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5bd6ebd-53a7-4a71-bcfd-a0babd751195", "AQAAAAIAAYagAAAAEEtVTV1uDN0U0ZMyzRYeWsaJgWEEzGHhdM6VabYLwRbjmfeWOwMDraywdAU3m75BdA==", "82516323-fbf1-45c9-98cf-0ddfe348c239" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b76ef16a-fd36-4e30-9c2c-b7a5a68357d8", "AQAAAAIAAYagAAAAEJ/olZ6XihhUIFYqHNtJ/DT5qxOnyDK7duYsD+acr5TVh2A4xrAoRLLcvNicjno+/A==", "6bfc393d-c2fc-4667-82fe-ff0c0f9db256" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5cddf5f-acc1-4641-bf6a-bbb9f9c33ffd", "AQAAAAIAAYagAAAAEBtrn+5+YcpzurgjgWjX5qdKrj19CdIT/ZXo+oQLJjSSwW782XBTSPQbgHP4Ep4bCw==", "582c0443-fa4a-4ce2-b4a8-a81c470b1773" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c34c7c2c-ab24-49e3-9010-bf83214cda4f", "AQAAAAIAAYagAAAAEH/D2zhnNI6WmV/3F37fTNAf3kXInwWisrFx6UzCT+jOwj157Or+zuSkiiuWHHjIcA==", "0049e46b-3973-4683-9b97-b8bc9f5f8cf1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "701ab530-77d3-4399-8489-dfb44f5812df", "AQAAAAIAAYagAAAAEObaKf2PrNT1v0JYbbrlOs3KtzRSl9lqQHv3ak7+P8r3y+NFaQR/3FbOADFlVWEwvg==", "1a8ad08a-ec07-4d17-89f0-f8e7aa73fff7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "064e4c9f-a7b2-4afc-80d8-62a0225e4a9d", "AQAAAAIAAYagAAAAELLQynBZaP47zswKOPXXkSEi38QLIB7tknLzpjBejXw7Ngspn3TVPgcBWJn7j3/F9Q==", "9bc64e6a-74e3-43fb-b26c-d7fd22ff93ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cabad4e-2793-4d36-941d-36d48c6a5122", "AQAAAAIAAYagAAAAEAF5Qb09Ga8bLdZjSXvqmsWRua1DsLRhxJBvCMBiqr00gzCvm3JXaYOwsqW6BmIK1Q==", "7d869b0c-f293-4b42-969a-20eb03e6ef61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f777c45d-1320-4f0c-a10f-a6c62e5fff7a", "AQAAAAIAAYagAAAAEAAogA1s//RAACYCr3SrHprexuW2p6SpjxGYreW2qASf5UmnPKMjrWWO9MNuWN2iJA==", "05780cc3-26c1-4482-83d5-9f4be986cd8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a0b7569-6d43-4148-899a-a44a35c729b3", "AQAAAAIAAYagAAAAEC24Qu24gEG5BE1UypkCcb4aSunMhuu80cj9EhTds8DPL+EZtSgxOIqT1mWgM2kx1Q==", "57602ce0-1bea-459f-aafb-2f66523d2310" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6e090cd-66dd-4595-afa8-3c119cc1dc8c", "AQAAAAIAAYagAAAAEBWBK58sBcYAgXAA1Y9iyqPtCKePFlom0KFLs7/xRJd3OVEXh7oO9516icufvjC5fA==", "90b8d591-6a3a-48a2-b37e-76ed41f0e1e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3bc118b-3bdf-4e18-88fe-29f552b84979", "AQAAAAIAAYagAAAAEL4ftaMnY1eVewL+PNZMptbXx+kGlbhe6/Xk1f84bpV7vartHhLQfMlbXW9ieEQBaw==", "12ff6425-71dc-4c65-bc28-075be3fadbbb" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8355), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8358), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8014), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8011), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8017), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8016), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2639), new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2655), new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2662), new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2666), new DateTime(2023, 3, 25, 4, 30, 24, 515, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5123), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5131), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5134), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5473), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5476), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5478), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5480), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6788), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6791), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6794), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7266), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7274), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7276), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7278), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7279), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7268), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7270), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7656), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7658), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6388), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6400), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6408), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5845), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5847), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(9384), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(9388), new DateTime(2023, 3, 25, 4, 30, 25, 570, DateTimeKind.Local).AddTicks(9388) });
        }
    }
}
