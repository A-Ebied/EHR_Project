using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "HealthFacilities",
                newName: "UpdatedAt");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(9443), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(9467), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(9479), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 979, DateTimeKind.Local).AddTicks(488), new DateTime(2023, 6, 2, 2, 24, 45, 979, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 979, DateTimeKind.Local).AddTicks(506), new DateTime(2023, 6, 2, 2, 24, 45, 979, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a573fa8-ab4d-493a-b4c9-3dbf0ada7d91", "AQAAAAIAAYagAAAAELQTC7GgZlJnBsrZ7GVZhoHoY9i4ZoP4XklxTGqIUqmAN1G4Cy2WJNVELSxMjhVHaQ==", "a0a24bae-7572-4428-a53f-c862de525c15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ded5852d-5fee-4307-85f6-8cd4a474224d", "AQAAAAIAAYagAAAAEIEInY162lsAwvcPndcYKF8oKlfEyjyXXu87sDSmg0BB2V8Wps6U0WsQQIIxgED7Vw==", "e935d3c1-0128-4903-885a-77f8c2ed22f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d72ec0d4-c426-44cd-8674-5365ca319653", "AQAAAAIAAYagAAAAEOEVTufl/+cKUknoE4XxgS0FnXrMS2eEvIr4lZkLG+h/KQ52T+M8zEes/Uk6fdxvrw==", "140d6103-858e-4c8b-bd0c-583d2360cfd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4acf36c5-ee7f-4e30-bb0c-5a2a6cdbc4a7", "AQAAAAIAAYagAAAAEMbafce0GBJmi5QfpumoIfstobVuouRAlMAAk1X3WL42aavfc8Ywu7NzTHwLgKLoBg==", "a2bbd6e2-3ee0-4c5f-bf64-afc21d7f7aa4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5515ede5-4edf-4ee6-ba8d-ca8e3ad69f07", "AQAAAAIAAYagAAAAEMkD2Vuu1XLkgpX4NXBAd6YN6kFfuNCHwJ63cWDHl9QHlM2trm+pv5I8NRTgCTS24w==", "c6376671-f88b-4803-bf98-6588a170f49e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eac6548e-7793-4364-999e-1ce2712dc2be", "AQAAAAIAAYagAAAAEGB1C8CZ3PJaXk1BzVoyyoFb1s3D7rgrxvff6wgo6mteNCXjAnnMH9CfaEvSwOaL5w==", "07a44591-2fa1-437e-90a2-8201884a3e3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0da1c01-7379-4e80-9ddc-eb201010155f", "AQAAAAIAAYagAAAAELl/AU/pfc6qKOpKVaIryS0JGvbZkgcZYCldIF3lPfgG/RYKegBb2ys7v/9PEzJfgA==", "d60a45f5-36d0-4914-89f8-95a65de94d2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3789c49d-c6f7-4d1c-9041-a715c8751bd7", "AQAAAAIAAYagAAAAEC9ogS2o9Ig+aB65B2V8ITQTDEeQXpPGh35u18jYjOqOJvoLILwaX4HUFgKUwiP/Qg==", "9e916b72-501e-4683-8b37-cd40874d0fb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f03dd24-e01e-4895-bf11-768aff5ceb15", "AQAAAAIAAYagAAAAED1zUDAjOH5nFi2eaWg0eiPhLx+qGAQUip01huCyM8I2Hnd6NHpDPGA7cPrpTQzk6Q==", "8389d84d-407e-402c-ac79-46b908e9907f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59d699f5-f6bc-4960-833a-9d7fea196f99", "AQAAAAIAAYagAAAAEAlJw57JbyAYrp2sfAUPHEuBBs/7VQexpLn3JvojuHffc1Pp4NX94X5NAeLfZqwV8g==", "25274682-94bf-4b95-bff2-bb956d493228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa206b74-4646-4bfa-9d48-0a8e861d071f", "AQAAAAIAAYagAAAAEK0GwpZsik2xoCf7Xyccr5zHO52jAkADC/poK8ljkSchliYda5z28he1aQxXc0oDMQ==", "a3de8eb8-e736-4b5d-9ee4-27a484ce7da9" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(7918), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(6531), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(6516), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(6548), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(6543), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(589), new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(676), new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(680), new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(684), new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(687), new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(690), new DateTime(2023, 6, 2, 2, 24, 44, 198, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(7576), new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(7747), new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(8808), new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(2197), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(2216), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(2229), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3978), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3644), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3654), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3669), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(5284), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(5321), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(5333), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(1056), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 6, 2, 2, 24, 45, 978, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(9813), new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(9831), new DateTime(2023, 6, 2, 2, 24, 45, 977, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 979, DateTimeKind.Local).AddTicks(1468), new DateTime(2023, 6, 2, 2, 24, 45, 979, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 2, 24, 45, 979, DateTimeKind.Local).AddTicks(1492), new DateTime(2023, 6, 2, 2, 24, 45, 979, DateTimeKind.Local).AddTicks(1496) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "HealthFacilities",
                newName: "UpdateddAt");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2061), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2068), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e545b85e-cbdc-4b6e-8455-4bd5b50ec0eb", "AQAAAAIAAYagAAAAEIMtisEA8VZhecW87IVCdgmpG39cmqzFGiW1bMt6KydVF6FSvuY7TeSK4P6utB1AEw==", "8ce72237-8810-45eb-b7af-9a446bc9cb6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f5eb83a-8e3d-423a-b1c6-e627784fd144", "AQAAAAIAAYagAAAAELM+vCBLIKFa/HyFR9MeuoN7toTdgbCNcHc3N8dJ2A7IVciYS1SGXG8TF3zqnWy3oQ==", "0c97412a-6a21-437e-81dc-2c08001cbfaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d2f727e-4ed5-4446-b82e-937c48cbf0c7", "AQAAAAIAAYagAAAAEK7DPMNZxxtvdwzAdZVmu8mvsPkuvM5CIdZUopPXSNTZzTdhwqXJ7cD6bkNpbr/ZsQ==", "9fa46295-21ce-4d06-a695-5bfc8b3d4898" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f0337b1-32c9-40d5-b7bc-8493a10cd968", "AQAAAAIAAYagAAAAEC340D8YeTTUmh7idpqGRCB2lNyHPUpF4xnV1qtlk6ouuNJteWx82l8ew1QWBnmLhw==", "4afe4b50-10f1-4cbc-8239-a60f68e4709a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa199050-3bb2-4e1b-8178-c6d9b5c1a9b4", "AQAAAAIAAYagAAAAEAawQBruND/HTv03349oCjPM7+jZZ8w1NPGIBzqlkrRVSIFee0wQyu9dlJcXa6SL4w==", "29a89ee1-b033-4aaf-a23b-8e8721840e82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df039f77-52b6-47fa-8826-e50e446cee29", "AQAAAAIAAYagAAAAENPOpZkevP6NS+6TTMf3X4zZlBG7BvBjDOlSfnocpKc3WQXjFWLoX2k1kx/hrJlcXg==", "0db1bad5-2c60-4287-9485-c5a4b0ef0248" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27bbb60b-a60b-4950-b239-f08b26438e44", "AQAAAAIAAYagAAAAEPJzSSg4z9XDjjg+XqSNJXSE1iQ2/mbGStY56Wiw5a0F0TkoqzmBXST1xD5PFKgB1g==", "a693a839-57cc-43c2-b0d2-ffd400f1d450" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ef16edd-3cd3-4cb8-9e04-5afe53a75b12", "AQAAAAIAAYagAAAAEOlIvn8SS+qeu3RT5UlsR0gfXh+OhBQ4XaztwpT9paKpISTzr7ck15O06Y+zmywJ2A==", "e0da791e-17be-4280-ad61-59def71d2d82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b76ffc4-2131-4d9f-b6d4-c45eadc0b520", "AQAAAAIAAYagAAAAEJthI0DblT2nJBdutNUFiJHVz3KjB1bqzG3R3PEZjuW+3ep731ENVhSbEwx8DU9lrg==", "1a78ef5d-a35b-4ae1-9813-c9f70c3622d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85950c61-6c1c-4f20-ab48-b40db8bae0b5", "AQAAAAIAAYagAAAAECbQuVcJ65hdJ87PAFDnvBafoxqFpfoOpTCn7GROxhtyq2rkwLsWaV92a8amct5R8Q==", "1f129575-6acb-4e2c-b00f-31638e97c0c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ba58229-83ce-4ee4-ab4a-32c13af3d9ee", "AQAAAAIAAYagAAAAEFq2VOQlmF2YTS9J0MlQ8dcoqG5qiqAN+Zfzmxzs2+OSf7oPhyIJFlR01fUkcwd4vQ==", "3585db52-044a-45a4-bcad-3d468430e82f" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1376), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1388), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1395), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(757), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(743), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(769), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(766), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6211), new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6273), new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6276), new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 6, 1, 11, 52, 9, 654, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7248), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7316), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7321), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7747), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9136), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9142), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9147), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9574), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9577), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9581), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9562), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9565), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9570), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(1), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(9), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8695), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8703), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8160), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8166), new DateTime(2023, 6, 1, 11, 52, 10, 643, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(3386), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(3398), new DateTime(2023, 6, 1, 11, 52, 10, 644, DateTimeKind.Local).AddTicks(3401) });
        }
    }
}
