using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LeaveAt",
                table: "Admits",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3102), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3345), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3347), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29dd1fe3-2064-49e0-8e1d-43acf91f711d", "AQAAAAIAAYagAAAAEH6SlF/hE9Xt+QFDJFQ41IFF1eD6kjAmxfzb6D+A8jXjUsmwnWaudsa5+S4vIxZZ3A==", "2590a96a-36e5-43aa-87ca-1229ede19e75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cf0d762-fffc-44b1-9561-4185c00cfee3", "AQAAAAIAAYagAAAAEDc7ARY3EJMc8JZupLpDpORiJ/Z9CN+jRbpyw9eSNjhUzyFsfAh9GB1GQFUa8gR2Jg==", "0c344583-3939-4700-953e-ce50df89f5db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbebd313-0f9e-49bd-99c1-488ee0fd5409", "AQAAAAIAAYagAAAAEMhrvfbvaB+fvVLLFsYEhaPciv35OJANwSzBvUNiUcNeKl1E6pm/Mc4RcKmUgtg4Ww==", "ef5b275f-6bd9-404b-9a38-a3cf82ae769f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13c17c84-aa29-4590-9822-0193195dcfb2", "AQAAAAIAAYagAAAAEC3vdWwD2vJFvcAoz7SPR3gkDGjb1aCGW2oJEw5g4RMtlmufVhZZzDX1tGORCE+3rg==", "ca4e0db6-cb8e-4c59-a9fe-3a6b9db78e84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1377a2d6-86a1-44b3-a6b1-29251f448bdb", "AQAAAAIAAYagAAAAEN4CLN/hCF+CKYQvZwqVfTYvOByEeDxNGtcLQcGkQ4I+AlAWJxXfItwSwYVHwpiyoQ==", "cc7149eb-7ed4-4166-9802-dbb71abc2ba2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3085149e-b329-4d0b-bcf4-0952e8b9422a", "AQAAAAIAAYagAAAAEA9eIkKp5UKLG3Vi2cPtvUN1V07+eXmD/SRacx9mmwAU7hPVfMBcjG0IVLyqU//FCQ==", "6c771960-2add-42ea-a3fe-276bba45e863" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bb68e7e-318f-43f9-8cc2-5089b61fd8f5", "AQAAAAIAAYagAAAAEMXsMDgXnwo9uQV32IwkyB4T1FbtAruIDPO9d1EubpUZdQyD5K3GFlmpvZ3qyuO0hA==", "0ba318bd-6640-4f10-8081-7eda78bde6b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c3db510-e381-46ba-a5ce-2275c28292d4", "AQAAAAIAAYagAAAAEKk3HUvUqpuD4z8ndcTQYOvmQJmYNOX2/3T/WGujaAWOBNC5hqi5lMNT20CooLc6fw==", "52e23587-b661-4c41-98e3-ea3e66a399a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae6e78ab-1dd0-4e3a-a878-c05f517576d2", "AQAAAAIAAYagAAAAEH2F949oe6Q33l5KSqhf+8Zc/OApqL9JwM+5PRIr1BCPSnbxZ4kx1r2jf/BEBYIP8A==", "8f7e5795-e35c-477a-9c5c-07267b48b591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80442783-8ed5-4ad0-b26c-c3c7818be072", "AQAAAAIAAYagAAAAEC2yFQCjyG5Wo8C1QbCt3EP2X9PnEFI7XnW6CP4umjyFUxbbB2lFoqIrNfCjkrBgXg==", "806916c1-2e93-4c05-a044-504768ace9d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "111edb36-9fa2-4bce-a2b6-78faee2dce25", "AQAAAAIAAYagAAAAEFcoE/X7nz0qSKfkve3Xi7thpdFrn5OvOOjJTcinGLJCA0lpvvR4+laOsKH+6ZngcA==", "f66feb2b-de52-4de2-ae1d-a12df92b6ab9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fa64452-a232-4343-87f1-5e6aaa9f6794", "AQAAAAIAAYagAAAAEO2g+2VpSV3S/mOUtNEgm2225CuRC5+3cCnmT4WW9lHsro+iCZUNRaKKkjai6WKRVA==", "08aaae6d-171d-41e9-81f5-a0a605a2402c" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2847), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2850), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2851), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2595), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2593), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2598), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2597), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2401), new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2418), new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2420), new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2421), new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2422), new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2424), new DateTime(2023, 3, 17, 23, 7, 27, 552, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 433, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 3, 17, 23, 7, 28, 433, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(247), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(248), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(250), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(251), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1573), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1576), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1577), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1829), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1836), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1838), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1840), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1832), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1833), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1835), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2335), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2342), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2344), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(933), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(944), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(950), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(499), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(502), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3596), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3599), new DateTime(2023, 3, 17, 23, 7, 28, 434, DateTimeKind.Local).AddTicks(3600) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LeaveAt",
                table: "Admits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7475), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7479), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7840), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7843), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "140c3780-17a9-42ef-a056-2f941c9fe154", "AQAAAAIAAYagAAAAECTq8apdSC0NRFBCcZYpuaDk7VlA46U+hqCjgXpSc1yvFniRCZ26PF7aokgtA2pQlQ==", "707d984f-d205-4db4-8984-89013b2fdf49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c47afc97-70cf-475b-bea0-26d60a21a660", "AQAAAAIAAYagAAAAECQ5oZp/4lgGAPGcZR3dHrjh1MWUGoy992PsaGnNn3S2iZkHZZl9E1MoH53ugcX2Lg==", "5dddb71b-0da7-472e-b8ec-9e8ca4bfd94b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b7610d8-c692-447e-83c7-7af6fe55ff36", "AQAAAAIAAYagAAAAEMwkOiqSkjXs6fjqBsFOqnmdKcwUfLsO5P2yhKPpAN3uZCQURKpl9pBwYGq5P3qACQ==", "9f79eb6b-172e-43fd-9386-368a2bfe5de0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d8f2376-c57d-4d32-bc38-6675f9eb1482", "AQAAAAIAAYagAAAAEEQlPO6T85ML49E9yr04mW8+9kyqN358796cuWjqpjPCxyLjSxW6lXtw/QIeISxYdw==", "035188d3-b3e0-449b-99a7-ff9c76376931" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f21eec4-7c39-4af1-a4f9-673c3220646d", "AQAAAAIAAYagAAAAECVOwfB5oVi+0wyA0mrlP3Z9QI9RWA+b9zcInS49NErKmnqpc/4R8JIU+fWtugqn+w==", "1117d1af-c3c1-4e22-8f89-c39f81373ac8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f9b1927-5dee-4f23-9a07-b2f61818af03", "AQAAAAIAAYagAAAAEKawM10Ys9P9I6m/M0bMbf0Bl5lMG5pdA/3w71PBlDLeXD5EJCxywhrSQ4UdaHTs3A==", "2388ba72-98b4-4190-b533-ce2f0f52bf42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36703c7e-6c33-4a7c-a0de-f925de09da60", "AQAAAAIAAYagAAAAEAE2Xr897en8aQNeydnQIdqbrIgzwpxJP2Hu0id9YvRFfXtym92i6zsSgXGXraywDg==", "b558589b-aca1-44df-ba99-1cba5ac68302" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b57be39a-51c2-4179-a1b7-f2f4999300d3", "AQAAAAIAAYagAAAAEHyA1otph4Dgxez919PVOu1bt/lFI0FgYylnePz2ltlKdN2Rem6D62yIbHnhDYFJNw==", "a1593995-b06d-4005-a339-fa994c8fad0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f6c84c-2ff2-44a3-af26-e4829e90a629", "AQAAAAIAAYagAAAAEEDBTp69QQXXlgi1QTA6HKUqPntoeA8N3x0bzn8H3YAaTAaEs80ZQx4ei10rDEWcgg==", "e231e44f-83e5-47f2-9d83-358e2cb91af4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c65f4be-6eea-4b15-ae78-bb55105f7db9", "AQAAAAIAAYagAAAAEDUe6/Wyk/+gRZBLjHG33yXSVkFiDZSwT7DyQ7C7XY9k94+66RS+nUj/oFsf9qTtXA==", "d7220365-401e-4ad8-b5ce-37e5d0999264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89a4fce1-c292-493f-a8ed-92bb11e00848", "AQAAAAIAAYagAAAAEMEz6Xx7e6hz7LbcoFujgAf89ds7uRWYacQ7PTd0ANqhg0PEBmvzkfX5RZ/V37cO8A==", "4afc2295-63ec-48b3-8a7a-b9fb5570e216" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce4d411a-ff67-48e2-8aa1-e875dda8a831", "AQAAAAIAAYagAAAAENUcp3DlHevlpYFjylR0xEjrFJeZsLj1nwQVXqkLqkzjR3bPP1RiDeGv6uH2KqF85w==", "01dc261d-9227-49d9-a918-9c62259f4c74" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6909), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6913), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6915), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6585), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6590), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6589), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1740), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1747), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1749), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1750), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1752), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1754), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3918), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3926), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3929), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4274), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5869), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5881), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6222), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6226), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5143), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4613), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(8180), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(8184), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(8185) });
        }
    }
}
