using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChronicDiseases_ICDs_ICDId",
                table: "ChronicDiseases");

            migrationBuilder.DropIndex(
                name: "IX_ChronicDiseases_RegistrationDataId_ICDId",
                table: "ChronicDiseases");

            migrationBuilder.RenameColumn(
                name: "ICDId",
                table: "ChronicDiseases",
                newName: "ICDCode");

            migrationBuilder.RenameIndex(
                name: "IX_ChronicDiseases_ICDId",
                table: "ChronicDiseases",
                newName: "IX_ChronicDiseases_ICDCode");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3874), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3881), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4458), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4466), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94a49f76-ae1f-42de-9109-3132090cd704", "AQAAAAIAAYagAAAAEBWOXDvkK5llcXZPwr9wUohWcc68MmCbaujlz3rCSpKUtCfCQcRp729bldkqk5XcgQ==", "d49eb1db-1cb0-4798-8b8a-2ce6f94552b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f16f6130-615e-4f05-a0eb-0f96b6cea945", "AQAAAAIAAYagAAAAEKSI4mI8GKHrXF4gdgCQqFI6euErUDlFWKHvUYsFhbkgKXDPAe9BSdXM9B78/TnM7w==", "6b24a19b-e69d-4b3b-a7c6-63d15a4fa363" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45d2ea23-b339-4c3d-b087-325241761441", "AQAAAAIAAYagAAAAEMwxe+tk5CWUYIGiMQXejkYIxqaGNnNDGGZU4ZsKcnuq//kyTDTkCUfQ+IYsvh+aJg==", "4d0d0e63-c058-46b6-82d6-f1b019f7a1dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "995e76e6-1a75-41f7-8e47-95d142074339", "AQAAAAIAAYagAAAAEJsVGGtB4DXyJtIpxkAC/wwfQNVFRNJZzj3LKaF8QD/F/A7BT9GmTbjJLj86+4BDAw==", "570700a8-b5ed-468e-94cd-4395a73273dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3321c54e-1c66-4814-872a-6b26f5925998", "AQAAAAIAAYagAAAAEPw8eBtFSKIdGXNIAFV8bMi7kZQ9R7vd4+hOOhDO6WCuy6or95mJOn7jhLY7Sjdu2w==", "fadd2525-ad0d-43a3-a0d3-dd8c66e9886a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55d4efda-ea75-454b-b1b1-45d488520b54", "AQAAAAIAAYagAAAAEEdtdcOZP7dkApjQV9OjUeUR2vyU2c7kIoUZs4Wlv42mwFoEd15qjFH34esAJJC71g==", "2ed9e1dc-6cb0-4b0b-97ed-51bee736ffc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67766fa4-5db6-4948-9c0e-ffaeef52caa5", "AQAAAAIAAYagAAAAEL0VpGC7/tmlSA0UJSnK31vVQQI+U8qg9kCn9DbJPW3SjSJ9Szn9ov0vvCK9ju7HRQ==", "b74afbe8-087e-4726-a1fd-a85b21595fbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8e8d782-6e4c-4a89-a4ca-38be2c3ce55c", "AQAAAAIAAYagAAAAENzoUYvbUgRBAT2qJFVmnUxFVVGU3Ebkme4kh+Lj8/IfB2Cy6zQcHwxZaKn5GTz2Yg==", "fdc9e181-1550-49bb-b94b-5a493e25b3d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c2f08d2-4baa-4459-8c82-dcd4cceffc5b", "AQAAAAIAAYagAAAAEMObqYg20ZWVFtyQuLxamXNgh2IWfhSTVkov+l8UkSmSaPszSNnOdxrtoq3ejF8hVw==", "90d83166-2e6a-41c0-9953-9b91a143bd12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6ebdaf1-7ec3-4927-a7c3-ba5814a10fcd", "AQAAAAIAAYagAAAAEBAdo2WEx7KyUODBmrj6dUMQ6Q8Mof5+xJVzc5/pgjwNFZcVUgZUQDFfPpWTtm8I5A==", "b6b6a508-eddd-4cbd-87f9-38062ab81451" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2fc4d66-2181-4923-95bb-8553d0615b4c", "AQAAAAIAAYagAAAAEP5mQKgIR6eYtNfZMaz3x6mMmvQM/pzoQ+ARwBiPYXDLgw1gBCBMi002c5fk71aHOQ==", "2a1e0cdb-4ee8-4d47-91dd-f5479ddc9033" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3465), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3473), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3477), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3072), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3065), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3078), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3076), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7567), new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7676), new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7683), new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7697), new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7706), new DateTime(2023, 6, 16, 20, 11, 46, 121, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9446), new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9525), new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9530), new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: " I10",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9875), new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9881), new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9885), new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 6, 16, 20, 11, 47, 306, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1232), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1313), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1319), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1886), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1910), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1914), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1918), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1893), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1898), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1902), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2498), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2514), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2518), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2522), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2525), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(836), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(855), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(865), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(246), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4824), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4831), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4841), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4846), new DateTime(2023, 6, 16, 20, 11, 47, 307, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseases_RegistrationDataId_ICDCode",
                table: "ChronicDiseases",
                columns: new[] { "RegistrationDataId", "ICDCode" },
                unique: true,
                filter: "[RegistrationDataId] IS NOT NULL AND [ICDCode] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ChronicDiseases_ICDs_ICDCode",
                table: "ChronicDiseases",
                column: "ICDCode",
                principalTable: "ICDs",
                principalColumn: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChronicDiseases_ICDs_ICDCode",
                table: "ChronicDiseases");

            migrationBuilder.DropIndex(
                name: "IX_ChronicDiseases_RegistrationDataId_ICDCode",
                table: "ChronicDiseases");

            migrationBuilder.RenameColumn(
                name: "ICDCode",
                table: "ChronicDiseases",
                newName: "ICDId");

            migrationBuilder.RenameIndex(
                name: "IX_ChronicDiseases_ICDCode",
                table: "ChronicDiseases",
                newName: "IX_ChronicDiseases_ICDId");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8225), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8517), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8521), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dab73287-9a3c-4cab-ac35-dbdeaa378dc9", "AQAAAAIAAYagAAAAEFwagwIHTq6+gVRVlFOeKjlG4wsuzOLjxpwFy6BKAE6TcxB3oIXCg0O43fUKZ7ICEA==", "a8ec5af2-4e66-4305-b5ac-44c0a763d448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98e2011d-cab2-4b2a-bd05-cb496ad6befb", "AQAAAAIAAYagAAAAEOH64hwZFhcEZFFWRiZ0KTS5CLVnpdjZHh+vCF0dpOpMWkfpNEppS4uaC41Todkhbw==", "fcad3e5d-404b-4571-88ae-f3a8d16dcf4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d62526-7b4a-4f8c-8d58-e2fc4b3cc286", "AQAAAAIAAYagAAAAEPhx9tC0jg9DQaDxjJXRKmjSUGcvOqaVfMsDhSU1iHjMiPoGKD1kOtlXl6ktuI2YsA==", "d2823ea6-2754-42a6-9d30-06fdc4a1787f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9d4e8a5-2ed4-4ee4-9fd5-8716445d5007", "AQAAAAIAAYagAAAAEDVpslSr1hgNPSu/sj5xfKJzUXMDfocPLI3geT29y5sm/EjKPEfm6pOSgt+0lHF2cg==", "21d3c9e5-4c8a-4480-8a12-35dc4e425cc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc094c3f-75d2-451e-aad7-8e49a33878e0", "AQAAAAIAAYagAAAAECvToswRSp+dVRvpNwnualu0rgxY2/d8lwk05TYWkZ73y4/u2Dak4UV/fXhB8W4UfQ==", "0f04b104-8dfd-4e8e-8e85-ca404693d7ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac0aaea1-fec6-414b-b8a8-bd9f2a87bb7a", "AQAAAAIAAYagAAAAEIRW07LcIprl7FqZ33J/bRINa+J82ugb1DrDm55D7IroFDhdbSbGe+IEafYWVFDZTw==", "9656a3ad-4422-4934-aba6-4ee20476fe92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c559a7ad-7fe4-49db-8b71-7ff9aab0f894", "AQAAAAIAAYagAAAAEFSapDy1QCif2Kc18uZcOGSe+AalH/5OX0y9o047Ok6FEgumASH3UKIuKHF4c1I25g==", "938d851e-2746-41a0-b5dd-ce80347ada61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aee0d581-0c4d-43f5-8c2f-037776597487", "AQAAAAIAAYagAAAAEO/424o9WWzQfz/kwfFYnNUdpFXQPM0xQwjzaaPziWhq6gfhRdv6NRjGrebDbA/K2w==", "93148e47-6113-4922-833d-60871f48b684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e28c5b2f-b0d3-42af-9698-ee3d83bd15c8", "AQAAAAIAAYagAAAAELPdkA3dxPL0hbGAOB6IL5PByc+hxEWUfDPqqJ+RYuWE9UKqh2eYXpM448U8aGyrLA==", "c5cad907-03d8-4465-80e1-fc097bd1dd37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d83d45b2-0d4d-42ac-ab1e-6b49d96147e6", "AQAAAAIAAYagAAAAEDaFP/SxCIDum8msELgGnX216KpPss7tfvEb2U+Lli+LQqmcoZmEXoFNfVEwGyCuew==", "2d14b2c8-9b61-4d66-9a82-292cdffe7fd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cde35f5-dc06-44bd-8874-d2c1705370c1", "AQAAAAIAAYagAAAAECqACyv+wYRPjxNDiPEB1/qfEHFWQCtOMYUCLCio8L/Jay61J6sSwR27y/Iwh1se6A==", "a821ae9a-a47f-44c2-8911-163dce0959b9" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7928), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7932), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7934), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7639), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7643), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7642), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5101), new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5159), new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 6, 16, 15, 24, 43, 405, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(4945), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(4948), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: " I10",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5322), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5306), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5312), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5314), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5317), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6579), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6584), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6877), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7004), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7008), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7010), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6882), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6888), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7328), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7333), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7336), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7339), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7342), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7345), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7348), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5648), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5653), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8805), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8814), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8821), new DateTime(2023, 6, 16, 15, 24, 44, 173, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseases_RegistrationDataId_ICDId",
                table: "ChronicDiseases",
                columns: new[] { "RegistrationDataId", "ICDId" },
                unique: true,
                filter: "[RegistrationDataId] IS NOT NULL AND [ICDId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ChronicDiseases_ICDs_ICDId",
                table: "ChronicDiseases",
                column: "ICDId",
                principalTable: "ICDs",
                principalColumn: "Code");
        }
    }
}
