using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "UserVaccinations");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9409), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9413), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9737), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9742), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca5b01a4-82bb-4ee7-9de6-0c0ede0d71d0", "AQAAAAIAAYagAAAAEBSMTTjorG6PX3M/5KJTTFe3AgbuHTOqbLKpC0qPmCdGfzt0eqhhA0ezMQLz2112gg==", "925a3a22-c38c-4f3f-9bfd-7e51830482b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5cffab5-c79c-4a65-8b0e-4061b964db3f", "AQAAAAIAAYagAAAAEOjNA7VbZcs2tQF2hdOddNCivPyNi1Dpcm1QTrXzhgGAvrb9VWKhalPC47SQTSs6+w==", "33387039-ff02-4792-a988-adcfbd5e9294" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "836272be-2225-4a15-8ed2-8ae56d23a466", "AQAAAAIAAYagAAAAEL7zWQmUYCB51gfsoXEBY2eE7Uf1+w0PRIBOKi+qVcgatu6tCKMOXFEP//7Q5l//xQ==", "ab20da37-9edc-4187-98d4-b64ffe7ba44d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15d175db-d305-42c5-b60c-06b7c87331e6", "AQAAAAIAAYagAAAAEPG6IoGg6PDwtjZCUlzjz3z4lF9a8EQX+OfULtXlTta1eKwrbgNMxR+g0o/BlXiYgw==", "f6e56ffa-e7e5-4a04-b78b-2fab997c27b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bae2510-35ae-4391-a0ed-bc563c813640", "AQAAAAIAAYagAAAAENP6I4SPVPseitZWDU15LQsL18jxsycMRD7b+e/b6BsrUlQpe35eOjKRF7B24JWuqA==", "c1ec677d-5680-4b99-8efe-00c3de8d7aa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "228599f8-c7d6-4383-930b-e31fb69b85d6", "AQAAAAIAAYagAAAAEB0pAYsF/2GQJYxZ8RyFL+AueRYcff8eoKk6nS1muuJahDYvobm5ZvvqQWH3XixWMQ==", "0830fbc3-331b-474d-854c-8c2f364226ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fb1197b-d3cd-4a5b-8152-75f9a80aec0d", "AQAAAAIAAYagAAAAEE1UTk0uj1HbPbHUh4Ud2QH9Q2iD0rFBQkXf5t3inQmlFeYPJqHvDEKTmnJiG4ixig==", "dc292734-b754-4fbd-bd8a-b674f70ce9bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62787c8d-817a-45be-8d5c-b1886143fade", "AQAAAAIAAYagAAAAECwZcaGLe2z0HV+7IgeOVrh5gW1fiWZIiM/wGSYP3zgH3qR+QogsvcUEg8gg/Bfcgw==", "a5cfe7a4-ea4f-4f0f-9442-4ce12c844197" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b602afd-54dc-431a-acb2-46346d2fb86b", "AQAAAAIAAYagAAAAEFidV5AMgOFhzj7mGs8WIJ/ron86GyhcILdKyC4woFSA93T0g7rL2YXS8/m2JbcMlw==", "57e959c3-2582-4dc9-bde9-3a666edc43c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fd99608-263d-47e1-a1a4-07bcf2ab3c1a", "AQAAAAIAAYagAAAAEF1dPQtWba5lvsw3FdA4AZ/4pI3dkyfVdaOE/d//IhZZvymix9XY+Ej0PdNH99BfxA==", "e0a016f6-8f9f-4aba-9a0f-8165edbde9e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2a37b78-c937-4e54-9855-39f91b991e4f", "AQAAAAIAAYagAAAAEKFt0vQBiMk7YaBoIHL37QlWA0TwiynXWHQeSzck/4CF8OGVyY61b0F9cPwSCAFkVg==", "3d0c161b-7a6c-4023-9110-5d98b1147452" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c17ba5b0-0c1b-4c4c-9084-856fade0c7fc", "AQAAAAIAAYagAAAAEJ1HLosa37cM4V1Mi3/38obX4U3/uk7k3N4rAxlPKx/xg1aF5aagdh9uiNA1vKyzmA==", "068bbd7a-00cf-486d-9911-ca034bca0e4b" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9015), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9030), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8664), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8659), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8670), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8668), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1592), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1651), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1656), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1661), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1665), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5801), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5944), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6289), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6295), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6299), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7504), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7836), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7855), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7862), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7865), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7843), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7847), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7850), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8314), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8320), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8323), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8327), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7126), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7141), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7150), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6639), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 537, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 4, 15, 15, 18, 18, 537, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 537, DateTimeKind.Local).AddTicks(122), new DateTime(2023, 4, 15, 15, 18, 18, 537, DateTimeKind.Local).AddTicks(123) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "UserVaccinations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
