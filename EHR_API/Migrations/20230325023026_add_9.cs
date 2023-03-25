using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contraindications_Medications_MedicationId",
                table: "Contraindications");

            migrationBuilder.DropIndex(
                name: "IX_Contraindications_MedicationId",
                table: "Contraindications");

            migrationBuilder.DropIndex(
                name: "IX_Contraindications_RegistrationDataId_MedicationId",
                table: "Contraindications");

            migrationBuilder.DropColumn(
                name: "MedicationId",
                table: "Contraindications");

            migrationBuilder.RenameColumn(
                name: "ContraindiReason",
                table: "Contraindications",
                newName: "MedicalCondition");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationDataId",
                table: "ReceiveBloods",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contraindications",
                table: "Contraindications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicalTeamId",
                table: "Contraindications",
                type: "nvarchar(450)",
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

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveBloods_RegistrationDataId",
                table: "ReceiveBloods",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Contraindications_MedicalTeamId",
                table: "Contraindications",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Contraindications_RegistrationDataId",
                table: "Contraindications",
                column: "RegistrationDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contraindications_MedicalTeam_MedicalTeamId",
                table: "Contraindications",
                column: "MedicalTeamId",
                principalTable: "MedicalTeam",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiveBloods_AspNetUsers_RegistrationDataId",
                table: "ReceiveBloods",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contraindications_MedicalTeam_MedicalTeamId",
                table: "Contraindications");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiveBloods_AspNetUsers_RegistrationDataId",
                table: "ReceiveBloods");

            migrationBuilder.DropIndex(
                name: "IX_ReceiveBloods_RegistrationDataId",
                table: "ReceiveBloods");

            migrationBuilder.DropIndex(
                name: "IX_Contraindications_MedicalTeamId",
                table: "Contraindications");

            migrationBuilder.DropIndex(
                name: "IX_Contraindications_RegistrationDataId",
                table: "Contraindications");

            migrationBuilder.DropColumn(
                name: "RegistrationDataId",
                table: "ReceiveBloods");

            migrationBuilder.DropColumn(
                name: "Contraindications",
                table: "Contraindications");

            migrationBuilder.DropColumn(
                name: "MedicalTeamId",
                table: "Contraindications");

            migrationBuilder.RenameColumn(
                name: "MedicalCondition",
                table: "Contraindications",
                newName: "ContraindiReason");

            migrationBuilder.AddColumn<int>(
                name: "MedicationId",
                table: "Contraindications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1350), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1353), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1357), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1592), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0f8c13c-2d8a-4484-a80c-ce1fc864f463", "AQAAAAIAAYagAAAAEDuudx2mBFy9+9UuJVgPd7sHp2JqJ+oTZ/QuyA+wQCBFUKZaCocjUHsHXosAv6RfOQ==", "f9e8faec-0c29-4010-a351-e96d4d63bcce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ebd61e0-ae27-449d-b0fd-a131a060c058", "AQAAAAIAAYagAAAAENcLOfIwW+Ejf4bptXPOzE2lhF2hdLIoe4LJ+2OUzg3Ik+XptnOAKI0z6i0/GXgP/w==", "e1777b8e-27bc-4b53-ae84-89b103ebd506" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7799770e-1521-4119-becb-91f79a0db003", "AQAAAAIAAYagAAAAEFFA3fqwdtk+reUahHuOsjAi7uqUdVlcWpCIPt2qkCTAdJJku+v5NeCJHlOcUKbSvg==", "dca7b24f-e3cd-4f23-8b58-8e45f375a312" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6d19c35-e7a4-46af-a208-c3197e529170", "AQAAAAIAAYagAAAAELv3q+3mRC8NhzcBXFSmrpV93FQNze1Zf46/b+DKozr71OCvaLWpN2wRF74W4lYBtg==", "5a180c1e-7f18-4179-aadf-136f8c0fa3f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86cd3894-1652-4bf8-9a47-aa0fc7354eaa", "AQAAAAIAAYagAAAAEFAX/k3Tt4k1gDbIuWTIdP9RUhiMrBg/DS591M6anPy9mYgzsPW5FT2XTQ/i+OW9iQ==", "2d3c539c-3137-40fe-a8ae-7d0c16dce91b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a5e4d64-aeeb-440a-930e-883e34878a5a", "AQAAAAIAAYagAAAAEHcQXsipJslrRt4mhhDLgkOq/48XUgsUMvaQPhCwvlyB83yTHAqYl9ajv6UlvBOPFw==", "ffe9fa06-9f95-4da9-806f-e4743aea30e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cfed0a0-21ad-40e8-b084-0c23d9f264d6", "AQAAAAIAAYagAAAAELWLieIwySEcKO+FHMQ+mUwQrm4A34GIZlqGJV3ohgUy6itU6glpeONvUvgqGzY+Xw==", "6eda03b7-d77e-4c53-b9e0-8a4e3916b95b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bd38318-fbf4-41c3-b70e-a29b33c60ba0", "AQAAAAIAAYagAAAAEJ69IdUjz357c71D6UiHQCkjZkQJYM2CFU/gVhWL9+CSF3ZoSnWgof7UxR2YUk2AQA==", "87346920-02b6-408e-80a2-647347395ac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47d12b93-a301-441d-a96a-eb2830ed2b4a", "AQAAAAIAAYagAAAAEHnOkYs0jxZsYiN+B3dw0VszDdSB0ckQT52zjYRS71cuX5+0uSVHmW4ujjjAjJ1qkg==", "0bb93873-7640-4cfd-be8a-114095bc178b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd3b00f4-d19a-4ad9-be82-e738d5e41217", "AQAAAAIAAYagAAAAEMAmcvKNl4/rrhAmFKLY2cf1Vay/oKPJ2OIes0sm9iGUs5ioXuP8nbfjhu2hnqUaew==", "613f22ca-6db4-4fce-aaa3-1d26974ef08d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44c7c8fc-c92f-4717-abac-07cd62906057", "AQAAAAIAAYagAAAAEHQl0C+KZ0aGM0EuhOxRf2lFw6mDsH+quuhPaR+lVnd5xEDgEggXC0yFIncsXlwx7Q==", "ed3577cb-0749-4551-a3f3-41df5a268984" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d190db10-14a7-40a9-a2c6-aebcb3e1ad0f", "AQAAAAIAAYagAAAAEBbHEBx9agNR4JMMX5bwTXSXZSR7/kXo9Jj/q0ngXZOGZjgyBscdvtI9+WmAy2cQsA==", "37ee8a48-30f8-40e7-a763-e7cee9f26ff5" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1099), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(864), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(869), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(868), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(876), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(892), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(894), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(897), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9050), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(111), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(114), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(361), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(367), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(369), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(371), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(365), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(618), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(620), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(622), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(623), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9839), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9848), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9853), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9450), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9452), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1832), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1835), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1835) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Contraindications_Medications_MedicationId",
                table: "Contraindications",
                column: "MedicationId",
                principalTable: "Medications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
