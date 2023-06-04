using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class db3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(557), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(564), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(963), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(969), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84c7d8c8-c5a2-450b-b9c9-08b1b01f7b82", "AQAAAAIAAYagAAAAEJiKB/6u13NcPdPahNAI4e1nWwUFQiMEkMXOCoIJJ9N6NDxreAYYFBW1lA+zbbE/3w==", "f32257ec-9b85-4434-97f5-59ce68f7069c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff3e7a22-7b31-4b0f-9d8c-74a138ffdd43", "AQAAAAIAAYagAAAAECrxALIIFXYu8HauwhvsFsmufin05qatJtjpmwvTUqqlcq30/fawl2578bOHleBuJw==", "1fece116-953b-4c17-9729-6472c404dfda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be43b14a-5dba-4725-903f-bd1b8e695263", "AQAAAAIAAYagAAAAEEeHUH4V5keynMUo7ofxiCxRtxLRIWkweOEPJCaNw1g2bPQoJXtxxxh3Y432gmwDwQ==", "664b5ae0-0dcb-402c-b644-2ccf7205d251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1852f96e-618f-43bb-afff-3b969984fe92", "AQAAAAIAAYagAAAAEAXJSiFCxHa8NXWO85yCJc745S+O5WxcriXO8FUE/+db/8vVWVPjBHDJTiyA96LJ8Q==", "2df37318-57ea-4f34-b573-5ee5116a881d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fc7fb72-0772-4f51-bf6e-9aa91eb85e25", "AQAAAAIAAYagAAAAEKlBWXiMOfaz50ar2nHwP3vqRDuVJOM1ckPm18ZGLu0JPNf6HKmNyNkTqs2MmgCAkA==", "2bf17b98-bcd3-4e7f-a78b-eceb6ed0f764" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd6455aa-5d60-4711-b8cf-79e9463b78a9", "AQAAAAIAAYagAAAAEH6+W37e+7hxaN6ZpxYHf4UpOT1l2ECRG+E864OvIeX7gRwlAdRRWWoyRDyJrZmRyw==", "db6a5ad5-27fb-4185-a708-a19a17d1f0d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da6feb46-0017-447c-bceb-601b7a54b979", "AQAAAAIAAYagAAAAECvJWkyomDC9n34Ol5ZhUZD0UDoCi1muEwJ5Y1bwQrZeeIlhEWtSnU4b8DEcYS3/Rg==", "56d54109-5f74-4d66-a4f0-34245583a1f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63b57866-c82d-4eb1-a041-281c503046c2", "AQAAAAIAAYagAAAAEA7s9sTd2/l8Wiy9UihWnH+jMDq0DxOdiq7Pi7u80lzY8olfG/n9Un7EUjrpSpw1Cw==", "5f91f47a-cfde-4532-bd16-3d8eb9ff2d92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4751f36a-d882-428b-96bb-feecc5fd9cf0", "AQAAAAIAAYagAAAAEKYh1BFgsSggDtXAxnoZHvEFqPDnrMyuxbicx6dVBH96FgLbAWhFxBYRVywrpu7IoQ==", "8502bd97-85c4-4129-b605-9ecda6ed6de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a75acd0f-ed99-4ef0-92f0-c26bddecce04", "AQAAAAIAAYagAAAAEPpfVlGD1pWM3uTqqYYtj2O0oy/LsLW3BOTZf5X80R0zkCN1inXdzSSzBzSYZqs2WQ==", "071fcf72-b6a3-4e68-9793-b26273b25c4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dcc9ae5-40e7-4a38-92d4-a48cad12d005", "AQAAAAIAAYagAAAAEDqb9TlvHmABsby0oPgHlfrDEmUqf9zxS8nm+UOrMy/g+e2+78FKlol+rmUvmbp8HA==", "b2d5293b-2dcc-4400-a584-8bbf06e711c8" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(138), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(145), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9715), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9710), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9721), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9719), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1018), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1137), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1154), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1171), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6385), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6453), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6458), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: " I10",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6894), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6884), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6887), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6891), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8395), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8414), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8418), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8819), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8832), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8835), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9277), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9286), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9290), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9295), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9299), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9303), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "Contraindication", "CreatedAt", "Description", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[] { 7, "", new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9308), "Route, Oral", "/files/Medication/Hydrochlorothiazide.jpg", "Hydrochlorothiazide", new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7293), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7299), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1382), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1389), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1394), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1399), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1405) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5223), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8169d9d-9bd7-479b-92c7-664d6dd956e6", "AQAAAAIAAYagAAAAEMLyBZJv66TQfYy0HhXTUdDuVWhV1P7Okb9mKnzo7RIr4/kbZt0o6PM3VP4QOs429Q==", "082df6b0-4c64-4c46-9806-17955645d632" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0c60647-aa4b-435d-877e-61bb6bc0c424", "AQAAAAIAAYagAAAAEL/SmuWRW9KVfhHuutVpw6BZK6hqPPlH6MahUTrrcjHv7MiWMLV+Od+HOpuHT5amxA==", "a7a0b524-e12a-4584-acd2-71ed189d2424" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12b210d2-d36c-4a4d-bdef-9a8723513157", "AQAAAAIAAYagAAAAEBmjH9wvawFTctRmSfnJKfA4Tt4F4LOmvCC95u9wOiUTSRiroQscIY7rIlajoiIQbQ==", "c7758baf-b7c0-4f7d-94fa-b1ffb0600fa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a89648c-a866-4456-89c1-31eb70a723ad", "AQAAAAIAAYagAAAAEG7rTbtdL74FMYvLZDuUysWMMxwGVaNUU7We69NcoN5mIoTJptWdrIA9TmhDbvIaiQ==", "ba7a9920-311c-4246-bda8-a0cffad5656c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4885f49-6a12-4b6d-bb28-019908c29e99", "AQAAAAIAAYagAAAAEDOmtiWBtiOReaRLpwbW1/1mhipQqcpxvKO2OerD0vRvT1Xbc04a4qmahtltQFZFHA==", "97ac2b6d-e3f9-48de-9ff8-700c71fcc6bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faa17e3a-12fd-4b86-bab0-df370aa1983a", "AQAAAAIAAYagAAAAEGkSZ6XYGYLSWU3u1hhu56xlx3KB9j5XT/dCDPLpqGPiGLhW+BYWOxk/CM5z7K7YmA==", "06b7c045-a04b-430f-8480-e01f73f9dd25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b0c3c1f-5f90-4e3f-9686-3d91ac28829e", "AQAAAAIAAYagAAAAEISYkd+m0QhzCHRp+iJxYQbGD065Y4nGNFwRKeomqkSEQXVXwKNcZlmOjfNWPh03hw==", "b1e411d9-b787-4d49-b542-a0797acbb66f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bbe502f-b956-462d-81c3-a63d30b43d7a", "AQAAAAIAAYagAAAAEADD6xKCV12SJUgmARDwNgEABIrfhbuUEG18N+8fTGvkVIZmfPHHnO+0iMqKsF4K6Q==", "0ae15b6c-bea3-4445-9d1e-eee479329e41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84f2f0a4-7ede-4b57-aeb6-3e95e2db7c7a", "AQAAAAIAAYagAAAAELoRGo4fFNDeQCXNcBnJZryUmSGgT+hzjZJFRh5LIhXG8OLBfV/htLlQcn0RyBwMUw==", "c630bb76-045c-45d4-9472-216cd3d6cbac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ba70615-b474-4189-abc6-ff5b7cf4dd3d", "AQAAAAIAAYagAAAAEBTDky2JuCDVDTp59MHyHp44tVO6vTgSjXguE7AqnAo/2kSeAMHOvuQFj70WjM/55g==", "5deb1166-d681-4757-8eb8-175c173fd2db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96ef6274-3f28-4446-8dea-933da972e25f", "AQAAAAIAAYagAAAAEN/KUhJNOfcV2sHnrXIxUyIbWEd126bwslvXrlmZiwq3aKyYMmB0RBHb4cBWLN3kKQ==", "f3b9e93b-6c8f-4c1b-a1ec-c98721165140" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4657), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4673), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4097), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4089), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4107), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4104), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8425), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8493), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8497), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8500), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8503), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9196), new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9464), new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: " I10",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(80), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(44), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(56), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(62), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(68), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(74), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2314), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2929), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2898), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3497), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3522), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3529), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3535), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1675), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1691), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(892), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6397), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6409), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6418), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6426), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6434), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6437) });
        }
    }
}
