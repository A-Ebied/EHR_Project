using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9933), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9937), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9941), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 196, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 3, 16, 1, 48, 1, 196, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 196, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 3, 16, 1, 48, 1, 196, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7785a964-6229-4cc3-b6b0-7f99cd7367f7", "AQAAAAIAAYagAAAAEFQftdAr/Vkmm/UYzjy8bNGtWTKLVyTykUSHMvernI1MFbvXAir2iRZOTs0MmrmfwQ==", "ba8233b0-0eda-48f9-9602-0672cbabfabb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a6e95e5-233a-45ad-b318-a6226064f1f6", "AQAAAAIAAYagAAAAEMMKMJRS3jIp8ds8pHeym0dhnaDhM5kBQdzxy3u0SoSVYQitDLYLvSPGMyhYxYG24Q==", "2c224082-bfe9-4bac-bf21-ba273baa0e1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64923788-8631-42f1-8c3d-9ff727bd76b8", "AQAAAAIAAYagAAAAEESFLhSpLzl0r3IOWxVvbd13O6ae02SDa8tf1gNLpA/EGup5TccCY4tSa+5f85s1Ow==", "14458746-a01c-402d-a49b-55de4ec80bc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbc712f1-9829-4060-ba18-8a1cffae4cd2", "AQAAAAIAAYagAAAAEBlBctdjzbDw4+D/+9Nd9wkrO2icXzZiA4Lp/FngjXhopWxHFVVxqhCDyKpJif4BeQ==", "54be1f03-8f93-44b8-b1f7-f666fd417861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "919950ab-b40c-42cd-99b1-81d034f02284", "AQAAAAIAAYagAAAAECOoaVM2O7ZQH0ng3fUnnfQKkWzkMZQ7uZnHHsmQGfpxpgfGujiezBkgsNLdod708A==", "46661c36-2a75-435a-b7e9-5fdaec8ee63e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4dea212-bf99-4791-9699-ce981d0d15a8", "AQAAAAIAAYagAAAAEOJsZBvzoWOGC2zb1KSx9AhVircnX12IUAwy/W/d2VUsyOeQosGveKDRyR3Sj9d5Vg==", "4626401e-c135-4605-adac-b854d17ebb55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60b0a2cc-61b2-4cce-bfd2-ae8508b4064a", "AQAAAAIAAYagAAAAEPFV2HJBN9kqDaTLVss8fDhksBKW3mmkznbWCIY+Ud6HivfsOgkur+a8gjY6bVntJQ==", "86482276-02b6-4e89-9024-fa266bf17306" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3c7189c-3939-4343-83cb-1d163989b43b", "AQAAAAIAAYagAAAAEFk33dorJgXq7yyV+e/rE9hVnmeFv1wjnEQMK39OvAp+DaSClXdkLbpDnRhgWJGJXA==", "7ff8bb1e-d7db-4f39-8d88-5df10be8a57a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d90e739-d65a-409a-b8ff-ee17a6129d5a", "AQAAAAIAAYagAAAAEJONzUzs4GEjbbLgLFAqnpq0fYbfuirBWjbQ1TLgQgfdIkGGGvYxxXtg9wH4I1Catg==", "6cde8019-8e2d-40fa-85a2-416d8ba7c461" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45670259-059e-4109-a647-cb622464bd0e", "AQAAAAIAAYagAAAAEJkJrjuNdD0qcKYqZHvtRwLQ55QtqfCEnS2kzwRFrL/INhDPoqkut60LSTk2SxwCpQ==", "d2931d19-0563-4360-ba27-60b06c7b869f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93642e89-c01f-4e54-b405-7500aa779e70", "AQAAAAIAAYagAAAAECK/IwdT9f7WUO0wyo+SLMm/ja7C330Je/6LEKi7/Zcktg9L0jdnSeULsUEQrbX2GQ==", "d928e4dd-bcde-4204-a330-d75d66aaaa31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dfa5cb5-b2ce-4941-8231-341601c3db80", "AQAAAAIAAYagAAAAEJSRpRJsYh81leXUIPcCpaG34ez6hr65GcYkMajL1b5vkyYK/2H71gAXZZXZghqz5g==", "58bce485-1b65-480e-9aa4-82d242f95add" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9537), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9541), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9543), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9076), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9073), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9079), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9078), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8211), new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8217), new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8219), new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8221), new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8223), new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8224), new DateTime(2023, 3, 16, 1, 48, 0, 94, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(3851), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(3861), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(3864), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(5321), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(5326), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(5328), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(5330), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7999), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8002), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8004), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8355), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8363), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8365), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8369), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8358), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8361), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8721), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8724), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8728), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7601), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7612), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7040), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7045), new DateTime(2023, 3, 16, 1, 48, 1, 195, DateTimeKind.Local).AddTicks(7046) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9475), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9479), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9483), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9800), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bca6c8c8-1d6d-4877-b750-3c2195c38f24", "AQAAAAIAAYagAAAAEJamTpIrYy2rIEiaPOv+nbfkrJx7hH3z2PxInvNK/psXUX+o3FIzF6UlIuuKsdvZgQ==", "01ac03e7-0ad4-4b59-87f6-ec57ce1792a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d58ff934-6256-4035-9826-7e715fccd4b4", "AQAAAAIAAYagAAAAEIz+4Swz6q6nFGsWDUA3R6Laq61OBvLCgEXHu2fjkUxeEObK9hQdksVQ8kIawUM57g==", "adc5baab-743f-4e73-86b1-1d8d9c453322" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "594e93e3-2319-45c9-a743-c52afa9a051e", "AQAAAAIAAYagAAAAEGBWbX/UTs5aLGPuUxa6QLXrXKMXETMUzA0MKfTmQT115oU1M221ohG/3FjJzRbKnw==", "b5d007e6-b70b-4b42-b799-3988d75e096b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82314c3f-ac2a-4e0e-850c-b2647cdc9250", "AQAAAAIAAYagAAAAEPo3e+gBnKv28OPmLBTG5RLShm88TkVilO0J14WScH6BO6horifdwH5+qf0UY2bKjg==", "7b7b77a4-757d-40b1-b5b1-44224ac65888" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fc855c4-2384-4c8f-96fe-93ca52105659", "AQAAAAIAAYagAAAAEFQ8bIK4a3Rg30WtGLrDBXBKs8HNprvY0QQ1hJtie9nyfAAvsKyzQERLZou2mn76Rg==", "d1fb552f-6118-4ac4-9eb7-f45153f3438d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cb318f9-af2e-44f3-8bae-d73bb43171e7", "AQAAAAIAAYagAAAAEKlJ5Fg5uMaduY39jq3VD68a8Dat4dN3fKCwnVZHG/CghkLOhLFZWKhA3i+qtHdPHg==", "77638e09-1839-47e5-9fc7-f62e82498511" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdd4e0a7-c042-419e-9321-d90bcc21318c", "AQAAAAIAAYagAAAAED5AKRCOM9stppbYu4IgZdmQKOEqMfsIN8wHQzoHmylRiYoX7px6QskFhboOR/otRQ==", "ac2b347d-cf40-4662-be3a-940a2ab3a8c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73d443aa-f6a3-4ad8-8152-86530e9a04b0", "AQAAAAIAAYagAAAAEB8A0/DBYxixpp+/tITajRYscFxS9TAXLsEEJeXy7EF+/PswmF2IGNvY+2PoR+CD0w==", "f56f1e46-9dd2-426f-9858-4b14a9f55251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6c11fb3-d08c-43ff-8d99-ea5045543774", "AQAAAAIAAYagAAAAEL6CWpjM1SDFt2COFpfk67/lFh0piEW5AuKOG83nRf7tCaPlTZR1st6ElQcR4H5Ufg==", "c225037b-b2a9-4ba1-8a69-ab7d587693e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c89f2a5e-e80b-408a-97d5-52b7e2cb777f", "AQAAAAIAAYagAAAAEDfgzozur9i4+JoWBtxxx/+vg1FELMJ41QG4yU93CPfneBy+Yd+nHiClsJIurwHfiA==", "0eec9ed1-4707-4686-b657-a31973bbe64b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c75ac7e-1761-4bb1-bfdc-3a471f0c3932", "AQAAAAIAAYagAAAAEGFcDbZlWKELPX8zVz4aIo06ca/SeBn2S5Rawf2wucBlA3OqnNNXuubTAZdHDIH1hw==", "2b63192d-aa33-455b-b5e3-a41c2c1bb079" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52b8bf89-4cd8-476d-8f75-3015e8c3b399", "AQAAAAIAAYagAAAAEHw57gfSJq8vEVtOFpVZ3zuaC6Tt58ex7pUiCnEZ2ZyWry7qNDIPrJ1sfcZEHycREQ==", "9aed4638-860e-4580-bb87-d8cb3d701c5e" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9149), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9152), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9154), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8822), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6206), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6214), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6217), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6557), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6559), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7703), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7705), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8030), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8042), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8032), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8034), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8036), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8374), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8382), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8386), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7358), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6902), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6905), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6906) });
        }
    }
}
