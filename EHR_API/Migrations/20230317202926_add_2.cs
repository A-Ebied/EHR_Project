using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admits_Visits_VisitId",
                table: "Admits");

            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_VisitId",
                table: "Admits");

            migrationBuilder.DropColumn(
                name: "IsAdmit",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "Admits");

            migrationBuilder.AddColumn<string>(
                name: "MedicalTeamId",
                table: "Admits",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3417), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d15c9f44-b075-428b-b142-58b16cde0a09", "AQAAAAIAAYagAAAAEBmeo9T5ObXQ7ziEmDRwKgS11ptecjKmPw9wcrHlhNpZOywt3J7SRls1nat46Wxzhw==", "7edcd8f4-77ec-4b6b-a670-c0e6d848ea39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7ff2f25-000a-43ec-a2ce-8329ecf8a966", "AQAAAAIAAYagAAAAEMwaKeOvZ+PcB3I/HwsbUlZJsLAqx2zjd+kH/iUg//ht+9iRjieSA8/0sdU4PZriQg==", "c41349f2-48da-4000-906c-d2f207a1dfe8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe96c0f5-f3ec-465f-bb4e-af91074c4324", "AQAAAAIAAYagAAAAEAa4NQYXWvqz2dH0T+ml2Y+qcSZIOyjFgaXM27Tr17m2p+JpI8JGfY4yFbkC2tCzvg==", "5d789fa2-c180-41fc-a008-b677d1c22167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aea226f0-3906-4ea5-aff7-b06d3c1dc752", "AQAAAAIAAYagAAAAEDOmMoE1A5MVU9ursYTk4rWlGKUCfl2yj5BctOfqoHYgll3llMu6yeQuzmuiWED5+g==", "8683016c-6d76-41f7-95e4-c2310516158e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ceda4dd-537a-4d41-97bc-34fb36fb8211", "AQAAAAIAAYagAAAAEBvASfj+CI2kL7osHQLylToMa48rxW0L0EwP/4uJEgH75lsVVc37/ZFJaH6yICQKNw==", "fd9e1bb8-e6ef-4fff-a71f-24c395bbb5b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd9b89d1-126b-48a0-bac6-23daec1e4fdf", "AQAAAAIAAYagAAAAEHm9Ly/CW7F5DMZ5zcUOtJWLwyRrk9Yctp9SdEDbH15uiyHKNxduq/QrqxFHtJeqyQ==", "98598c8c-9fb8-4955-ac6a-2fcdc77ec027" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c195b955-b01e-4997-a02a-06a8bcae7a00", "AQAAAAIAAYagAAAAEPM+/SDH1XDVYq5wN2DmnGQkkJ4BKJB8nAZ1aVIURNnnqd5Ea1CL3gxBSWYpU1EPqQ==", "f5c1cb3b-e7c1-46be-942f-a8bf4b7b1611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fce4ece-6553-4b2e-8efa-efb5575376aa", "AQAAAAIAAYagAAAAEPiyN0PAgKNy9XU2uLTGMTkjr8Cv9njCZid+jpAAOZ9ZQZp4SCevLI9AY/LzM+4zbA==", "bf7f6b84-b55b-490a-83a6-841d51530d2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e7175b6-f19a-4cfb-afc0-ff52c23569f6", "AQAAAAIAAYagAAAAEODMzcxEPM3FurPSn3XvURug0PBCi5ZznhZL1g3quZBa8DyqhHYYRnRFHvZbaHS80w==", "a4bd0e60-ca2a-494c-a6b5-be4ac408100c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f6afc50-f949-41be-8e36-b90181e14a01", "AQAAAAIAAYagAAAAEA8nbZ3N3qGQEHaBpo51MO6jKzKpSZ5BukeF3XmQw1/mei74UqPdnteBmSdCjSW7nQ==", "1386f0a8-3c55-44c8-8266-5609b4129ef2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8104b6f-df9d-4123-9210-681be9083588", "AQAAAAIAAYagAAAAEJhCo/rjbuzyl0NsE4zl3qoYQdMQ9m9pyGKnRTGeLQQH5u5vuc5+xM0JHA1qP2g8Mg==", "8d0548d4-1f9f-4676-bee9-255942b2efcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8bdeca5-b722-4d67-8b05-d919b61162df", "AQAAAAIAAYagAAAAEIOSgNfZsOJHiZzBuvgfHkozOdlG+JRQNGckiYAr8fBL1MGHDr+Qi6sTPSDmL+xErA==", "7a56fedb-a092-4261-a356-878559fb3b7c" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2393), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2390), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2396), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2395), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2159), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2177), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9547), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9559), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1232), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1234), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1680), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1690), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1692), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1695), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1697), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1683), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1685), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1688), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2052), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2056), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2058), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2061), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(851), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(865), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(875), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(341), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(343), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3751), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3754), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.CreateIndex(
                name: "IX_Admits_MedicalTeamId",
                table: "Admits",
                column: "MedicalTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admits_MedicalTeam_MedicalTeamId",
                table: "Admits",
                column: "MedicalTeamId",
                principalTable: "MedicalTeam",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admits_MedicalTeam_MedicalTeamId",
                table: "Admits");

            migrationBuilder.DropIndex(
                name: "IX_Admits_MedicalTeamId",
                table: "Admits");

            migrationBuilder.DropColumn(
                name: "MedicalTeamId",
                table: "Admits");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmit",
                table: "Visits",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VisitId",
                table: "Admits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_VisitId",
                table: "Admits",
                column: "VisitId");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5868), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5874), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6426), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6428), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11ca29ea-0b1e-4b26-9d53-047691942eea", "AQAAAAIAAYagAAAAEMfgDq2/d/3kp2cdBmuWO2wmrRA3vyFzz/topqrg3evTf627Ljp0xypPvdBqjxMcnQ==", "e7c34b70-0365-441e-82c2-b9ba2b485327" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "779c5b70-7987-4714-9c6e-eed783531b59", "AQAAAAIAAYagAAAAELw7crU1rxUzgfCTPQIraweZDErDgAnAHZHpJ1G75YeJGEs4S/HTgf7hA0OWroosYw==", "f4f29088-b45d-4e55-943f-f36dd7402eec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6da3f1b-d39b-4353-93d1-bcdfeddafc58", "AQAAAAIAAYagAAAAEG9lvwOzf2T5oaklCB1WWYBtSjkclieR/pKXTgLjjCQxF73NyRvewbwKC8JVe9jDmA==", "69e3fc60-1786-47a5-87fc-e18899ab759c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffbf3675-0fc7-41d8-993e-aeba56758bc4", "AQAAAAIAAYagAAAAEGOh0A3R3tZe6xPn9hPbynKOrz7/WY2NRsxv39v903Xme/79UOSXfH6o1r/4d2/bBw==", "2a6dea9f-1329-42b1-92e4-ac4b01cbc4e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fbe783b-9c65-494c-a404-f0569b96cdd3", "AQAAAAIAAYagAAAAEHjjMLkbRn7tZlBW5ZEk2mEfEjsiM/5u196rjRDdYnpo7DXa8fgHeIemhK0nHRHmvw==", "4f117051-c0ab-4b71-a849-b29dce12cb3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6bb9759-4ad3-429d-92d3-88effbfb8b1b", "AQAAAAIAAYagAAAAENEg5dX4h+uWLSHy4RaAn86QwEx2IH4Pqrvo564KPlPmT7nXKRT8ifsjsvd2HJbVNQ==", "fcd8fcdc-6b8e-4fee-8975-9056dcf2e131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3126fb81-67cb-4064-bede-ad256bbf6207", "AQAAAAIAAYagAAAAEL37IvVIGi24mg+wEf44VxZ86h+W5eUI+MgmVUukx8mkFOwc7O4qe6wPoetOZy9VIA==", "2ab0b833-2b13-422b-abb8-f82fa10e7769" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c94bd0e9-7c1a-467d-96e4-4b24db89a3d5", "AQAAAAIAAYagAAAAEKQVqbDIYFSOakGX6Vsd5BHwjfCJk9cNFeMfnV0+/E93i9jZvUX46CmIhSC2qGz8sQ==", "5136cfce-e3e9-4407-ba1c-1de0e968c25c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c67776a-34f3-424a-923e-cc15a74fe0f8", "AQAAAAIAAYagAAAAEE1nuaxTj+64ygpkNTx7LlXW5y7wRNqPlE8+EhDX/f3SIQUZn0mKmWTBPHOcpidUww==", "2575e045-8391-49b0-9d61-a978637ede27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db59e683-f3d9-49f0-8fdf-ded773ec7723", "AQAAAAIAAYagAAAAEOKBCcoGdqX/1pBf5PVY4psdDrqGIbyutaF6DIWnNzl2AReXXg66Nd4jZs9bNxiYJg==", "12db259b-a05b-4e16-8fe5-bdc615d574fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dcb5ad4-8e0d-4196-bf8f-7e677f739aee", "AQAAAAIAAYagAAAAEFtY6SbqVsmh2ef5T6gW5u/Y6gv/r43borTIPqKicgm3zOQw57o3eQhGOaBfM42b2A==", "e4d2e315-5353-4145-a8e1-26b382c9a5da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf01d7ab-74e4-463a-be60-136747fc1fcb", "AQAAAAIAAYagAAAAEDm+hZ5jZXNhNOf1/NIj3lVz3TWf3WPbChUG9aSsG9+sGjzJTXKDQoAGfWIca5+8TQ==", "851b26fd-6eea-4515-b1ee-2bb931e65057" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5615), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5618), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5348), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5347), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5351), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5351), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4916), new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4930), new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4932), new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4933), new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4934), new DateTime(2023, 3, 17, 21, 27, 0, 201, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2443), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2456), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2458), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2745), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2747), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4229), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4233), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4711), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4717), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4718), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4719), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4721), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4713), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4714), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5006), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5008), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3888), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3901), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3909), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3066), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6877), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 3, 17, 21, 27, 1, 53, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.AddForeignKey(
                name: "FK_Admits_Visits_VisitId",
                table: "Admits",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
