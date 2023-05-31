using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class db7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RadLabResultImages");

            migrationBuilder.AddColumn<string>(
                name: "Image1Url",
                table: "RadLabResult",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2Url",
                table: "RadLabResult",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8223), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8228), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8231), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8472), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8476), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f413762b-e6ad-465a-b500-02face8c63bf", "AQAAAAIAAYagAAAAEDY2/o9oNTmhxLIEKpjYLrTI1bEiyRjR43vCxP1avw7Gj7j9Qx3RrbZlFsA+4laRLw==", "afb4ce18-91af-49cb-9a98-653d42c2f36a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff2d0613-1b7c-4b64-b14b-66dd015380ab", "AQAAAAIAAYagAAAAEHfYDyuQOzqw1BBnnhmL0SiQynrGB9+uliQvFb5yDhp/ga5MmTB8MwKiZiznovtY6Q==", "0d615f5a-b713-4f12-bc37-1ae83a9bd131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fca9c02a-fde1-4a12-9dbe-b5a9ad9ae1e8", "AQAAAAIAAYagAAAAEOwf4hCzGhZlNJ8xstJfC6CuTfJWXqYNHW5vJlfZdnOO3tv+9x5ZC5he0jFTXZoM0w==", "5bfbf590-8b21-42d6-9bf2-8351b9d07e23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3616b6dd-1052-4e1b-8be1-668539e64f99", "AQAAAAIAAYagAAAAEIszJL1U0+ShOn0aD5dtnK+ow6+ZDTzkYq/hrcnERKSFGn8N6EJ4i0xasZejgpxQdQ==", "ac5f05ad-197c-4bb0-9130-36a76d764928" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe6f7242-6542-4394-a004-f8763919fb86", "AQAAAAIAAYagAAAAEKFL87ynjG7BO4KT7CSJsR1sd8W74/Y4vMRYBg4eVye5xkKSPdEYNvOn/SyAHrLXJg==", "a059a74c-69a5-4c89-ad53-e70a6303b338" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6855214-c6d5-4c72-8e8c-619fc41a84ba", "AQAAAAIAAYagAAAAEO1ubSe0YmfCblS5ghqzUVSRfob9llFNCJUZtT130bGWvuknmlOSTxOh6OX/PAi38A==", "9b9b8050-5549-4080-b589-df98aadf35fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f51b2d9-ad80-43bb-882f-b7cd3663d0eb", "AQAAAAIAAYagAAAAEFEqBZD8L6t4ExlSkZig+Ljrtrh9kV4WfvJEpKxsF4Y1n4cM7DUVBYOCNI8qQv9SaQ==", "68fcb986-a3eb-4971-a4c3-e95f326a7b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39793e9f-35be-4e4d-9254-c849d9944843", "AQAAAAIAAYagAAAAEFqeVmbFwa8obwIJ1vKw88ZLfkGGPOVuBNSzIbDn3s+7qbE7mxY9w6lRGbP/VigFbg==", "1b1e5903-140d-4c7e-95d9-cf10236c1b57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f18db81-09cc-4874-8f31-cd4147de4a18", "AQAAAAIAAYagAAAAEKg4vQUJqmirFbs8TBsfoUqdwczJpDrcgkn54Uh80AJR7F2uQtJ0ZycuBqOgwlzkfA==", "c32ebd00-eba1-4d22-8860-d5b5f068ff9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec3d64f-3491-41c4-9b1d-20ce200cd090", "AQAAAAIAAYagAAAAEGH0ANaDURtwsvibppssi7ZJc0HckMdveBG8syBJxBsbV0DkuIpjGYeX3jwNwrYeRg==", "b5d910eb-6c45-400f-b6d6-486ea763a18a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3d6b084-8c4b-4867-96fa-cedf005746e6", "AQAAAAIAAYagAAAAEE01bXvrqDsV1qy4n3HMdP4tnPRQ7iOo9sG+fyia5TWHM3gSRL1acIrut9ab1Io+xw==", "b64593ef-1ce9-4f52-9dd0-3af756821304" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec7035c2-f62f-4771-80ba-6da962531f44", "AQAAAAIAAYagAAAAEMldYUdsM9l4BUlQcfzLSan4DIozcpsWqHYXJOt0qqgQQpqhElN43lXUmQwtCoUobg==", "68850563-fe32-41e4-9a35-99b16ef912fd" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7719), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7715), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7723), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9015), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9019), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9022), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9026), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5384), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5493), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5755), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5757), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5761), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6825), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7087), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7099), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7102), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7105), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7107), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7094), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7097), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7375), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7378), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6469), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6481), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6488), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8740), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8747) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1Url",
                table: "RadLabResult");

            migrationBuilder.DropColumn(
                name: "Image2Url",
                table: "RadLabResult");

            migrationBuilder.CreateTable(
                name: "RadLabResultImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadLabResultId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResultImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9571), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9588), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9595), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(260), new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "640219e4-2455-44bb-8a24-4bbe28089ae5", "AQAAAAIAAYagAAAAEP5GvjN71ycrP4q9arkkOm0iVIvZcBbj8l3/jZXA300D/MoqDEdte+WSEI8I6omCww==", "4f35454f-d580-4eb0-b82d-51aa960b0f35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ef47124-70b4-4aa3-928e-5d54ebb8dacb", "AQAAAAIAAYagAAAAEB5YcyTPxWD+LalR4NUXMfWetWHVhD3p11qGQsyfCbHlJEdKxBQofx7vyD2Rq/Z2nA==", "babc8d52-27a9-4f4c-8f07-eebd86042aee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65bef192-bb8e-4348-8847-307ed2069b3e", "AQAAAAIAAYagAAAAEKPhn6MUmu9aD70NzFoNqE39OjctbzcnvnMbpU9Z9SzlxWuzuCv0Z//z3vzpLmkVaw==", "d517902b-5451-442f-ab7a-0a06ce1de609" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66e894ce-f3f9-4f39-a78a-e99bb02ceea6", "AQAAAAIAAYagAAAAELepBHRKawQcFPTjRsr3mFCmnOESv7BZ1xg2ZY+WNWO2Eh0ug/G0SyG2gkYnY8RSIA==", "4fb9ed79-0875-41c8-81d4-f9dee8ab2992" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fb93cfe-50c3-4639-bebc-89ad051d229f", "AQAAAAIAAYagAAAAEFrlaPJ6FdO2QXhdXlyHX+onCKgOrsPC4np5+MVlKfsZWzTbPkW3FyoKut0tFiullg==", "30b6a417-eec4-462d-a63e-cc2bd6a91478" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9112431d-a8f5-4734-bf5d-28624009824e", "AQAAAAIAAYagAAAAEMlpdYgEWvBfZ6vbAlIqZBGhQ5nqK7Oox2ISG++T3/1Qyk5BTrH+tSgN5+I8CrOjsg==", "deba9b65-5770-4ae5-b9d0-9547d2998f64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fc89ee5-0af4-42bd-8cad-ed278165ce0f", "AQAAAAIAAYagAAAAEKWBmK6KyAUectowPeJuTyjXoSb0Ee0rMTzYTAPyuw2MxXReQ07GzfV1o0/Fw1YOAg==", "87c5e0c3-35de-4af9-bd9f-03baa086ac1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9f73f85-160e-4908-9800-8cce113fc9f4", "AQAAAAIAAYagAAAAEOd0DvlOjLLEA2RGGjmii9l79QSiC8vZNVZutKOfBmFEFdQC3kZkuvw65kf626w9lQ==", "ce4c1c35-571a-4f3e-aaee-c7a1b3dbf2cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bb920e7-e70e-4ac1-ab40-27b5b869f837", "AQAAAAIAAYagAAAAEMkfXADWRzsgUZV/t2tjXdPuUtBDSxyi+hlChxUS0aOVPCLbQnX/9y0Z9qN/DMvBGQ==", "ae8442aa-553d-4ae2-a9f3-a488eed0c000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e19db3a4-e559-4808-8aaf-f7a3a013afc8", "AQAAAAIAAYagAAAAEHTWZxxUaqod+cWQmgAOXbjZ0lI5bTFP8Hc+lYJ79klcC2Kyd2y6TE9HLGf3IzQYqg==", "c7e1b3f8-ae07-4c11-9a10-9ccebf06cb25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30cdba6c-18f5-479f-8388-e229e09d1533", "AQAAAAIAAYagAAAAENo2TEhZOL/UxRvAWO3XAPSnSDBrgUxrWkO4RInVm5bm30Zmp85DEn3wNJCgQp3xUw==", "468e77d4-77d2-458c-80ba-7bb7f7fa0599" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9dc03e7-de12-4ce6-85df-73b317836fb7", "AQAAAAIAAYagAAAAEMLdzXn7El75mwyFTkZdFsL24NjErUv7AVL3JkbnLrJLbK23M8vnValbWRu915tYAQ==", "9b265b25-8d44-456a-94cd-5647d80148a8" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8668), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1740), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1745), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1748), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1752), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1756), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2087), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2190), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2843), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5330), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5338), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6071), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6108), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6115), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6123), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6088), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6095), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6102), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6911), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6937), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6943), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4652), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(3672), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(3687), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(1159), new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(1177), new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.CreateIndex(
                name: "IX_RadLabResultImages_RadLabResultId",
                table: "RadLabResultImages",
                column: "RadLabResultId");
        }
    }
}
