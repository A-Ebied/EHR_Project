using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserVaccinations_AspNetUsers_RegistrationDataId",
                table: "UserVaccinations");

            migrationBuilder.DropIndex(
                name: "IX_UserVaccinations_RegistrationDataId",
                table: "UserVaccinations");

            migrationBuilder.DropColumn(
                name: "RegistrationDataId",
                table: "UserVaccinations");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PhysicalTherapy",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "PhysicalTherapy",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3280), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3283), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3286), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3538), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3540), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aedf709f-8334-4fe1-81ef-b3de27f042c2", "AQAAAAIAAYagAAAAEJCsDE+KC9tKTtulSfLwE0Gw6yYoTz2LFxLu/u8Zhi0+Mgcly8U2BjMZfCCBEWk3DA==", "4281e4b5-abfe-4d82-a36f-3a2692039699" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6ff760c-8862-426f-a2b8-5d8fb44cab8e", "AQAAAAIAAYagAAAAEEpb/wtumWCZJ44/ZMnGdWkp08wlvgsC6LZLIbRLt0v54xNQ/xJBROjRFRoUZ1khkQ==", "932f8a18-b9a4-417f-90fe-cbe963f65ca9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fb33680-16c3-4fac-961c-289e7f1c8713", "AQAAAAIAAYagAAAAEP00z7HOmhyAzOGBrW4nzIGSDGdBuvd51Kvoq98XqAZ6g1Q/usMcxFo8Ebh3ob9aAA==", "cd62cd24-d167-494d-ba27-1f55752516e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aec6ae6-c3e3-4d8c-8af5-f92fa6a830d5", "AQAAAAIAAYagAAAAENY16hmOeuWv6ibDCjRJ7Vv3x3a8IwztX9SjfAgiD/WeHIhU7q6aMyysedDuJ6TrNA==", "23ad29f2-edcc-4fb2-9e35-556455713255" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb519cc7-785f-4335-a860-aa2c5da9f1b8", "AQAAAAIAAYagAAAAEABF17BpG+WG0pG5U1HG9nJSlg5QX8QCavEyo6zRjrfDlHHnQY0zDaJf3g2zp6Ww1A==", "81497a36-eb76-495a-9c86-804096189a66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1df8d77-3997-47a7-bcd9-3b0076335253", "AQAAAAIAAYagAAAAEHBm4O3QhyLY+zVL6yDni3x6MFzOzodoprDAT6QSvPZp7RTdbMEugjtN05SirFBhYw==", "8aef9ac0-d26d-438a-9457-1e2cd19c5503" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e2a3bc4-da8b-4fc3-87cd-14925172ebe6", "AQAAAAIAAYagAAAAEPC7DiYTfU6tPeuvhDn/h2yJ69apopXDJ8B4fFSwRyn2A78E/3aESOQOOz0moOdINg==", "fbf3e6a8-cfe3-4041-9a76-8f9cc286f68f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a06a736f-34a1-434a-99e8-43cac98590a6", "AQAAAAIAAYagAAAAEOXFtoLvIRAnR/QyTsTmY7+tMUTGsZNyNkShMtCFGLiw2kFsusMmgq9q14zcowg5jA==", "3b053ee9-b858-47ea-aa7d-daa5eb1919c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dd7cfee-d9f2-4b59-a76b-02c25277f99d", "AQAAAAIAAYagAAAAEDGGs5TcARkZLm1HDykSZNqRdnwEV2UcIYpCqvM5Q9yuH1NwSaPE5FCe4zvNZiC9Sg==", "17abdd80-b5c7-4529-b4ba-02bbd00e847f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "999afd82-edab-43ff-bf50-70b8919d99e3", "AQAAAAIAAYagAAAAELi3jhgv0nk0lhXTvH5V9Y/UTrs+kEI16GOAqYiI5Y7B8vWlO81I8GVLIVzFsFzQuQ==", "cffc5cd7-cb5b-4e9b-bcde-62c3efdf76de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23e66817-811d-4826-8e3d-940bb1885e8b", "AQAAAAIAAYagAAAAELrXIJiQnwEenoLubv0dOeEf7GfCH9YGntuq2cE+fUzxsJnRDj/zUlVot/HYLqTrXQ==", "4dcef5c3-3b33-4792-b2a8-a1f92a4ddfdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ccd1e72-694b-47ff-ae35-215f1afaad29", "AQAAAAIAAYagAAAAEM8+k2zU/1tWB6oEJ0JLJ/guNZn3fQ7xKW0nLdQxriBRczSxZQIO7JxOK9qejJKlGQ==", "e6c6c55c-9f24-447e-8fdd-76517aa2dfe1" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3027), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2778), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2775), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2779), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3484), new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3489), new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3490), new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3491), new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3492), new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3493), new DateTime(2023, 3, 16, 3, 24, 35, 112, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(640), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(647), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(650), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(941), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(943), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(944), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(945), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1867), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1870), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1871), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2229), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2236), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2237), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2239), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2231), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2232), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2234), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2504), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2508), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2511), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1585), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1213), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1215), new DateTime(2023, 3, 16, 3, 24, 36, 15, DateTimeKind.Local).AddTicks(1216) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PhysicalTherapy");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "PhysicalTherapy");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationDataId",
                table: "UserVaccinations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 947, DateTimeKind.Local).AddTicks(346), new DateTime(2023, 3, 16, 2, 12, 43, 947, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 947, DateTimeKind.Local).AddTicks(350), new DateTime(2023, 3, 16, 2, 12, 43, 947, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 947, DateTimeKind.Local).AddTicks(355), new DateTime(2023, 3, 16, 2, 12, 43, 947, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 947, DateTimeKind.Local).AddTicks(730), new DateTime(2023, 3, 16, 2, 12, 43, 947, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 947, DateTimeKind.Local).AddTicks(732), new DateTime(2023, 3, 16, 2, 12, 43, 947, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02727d4f-fb67-41bb-976f-a9042ea9b17a", "AQAAAAIAAYagAAAAECVnj0QLqzxdux9SnBLRKAnHWAvDULBQYdkqvMeRQhp1mRxDwHUvfbtmVXEiiad9/Q==", "9bc03d1e-f2f4-4794-9b48-fd35c01b6264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edd828f9-93b9-411c-bd41-fc863e77ee3d", "AQAAAAIAAYagAAAAEJW2ac9TbZszN0id0GmxMKUKaAtjsxxasQyuAcubeOivagSoCkrxHDS/ZjGug4y10g==", "a1820376-5dbd-4468-ba1d-f3b3064e9b22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fc72101-9d4e-4924-ac06-7baeee42f432", "AQAAAAIAAYagAAAAEJoK7IX9cmG6ZoYrMm1Y9FPBtj/b2fLgpwRqfAJJ5Sv8Vmp3UB9aMLMk1fC0xr1IHw==", "f4f7116a-8c58-43b0-9dd9-4903fe68b69f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ce3d848-4874-4152-acbc-b7f39298ef72", "AQAAAAIAAYagAAAAEALR5h+TUz2ZkSyJF9j/DZGYrkCpgzp7f/kU/uAHJoD7cuZtbiEGYXM6gbIWx3UT2g==", "03c45ebf-f121-4471-8d87-5396b2d91fbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9a083da-29d8-408a-a146-602a34e30e5a", "AQAAAAIAAYagAAAAENNAGWb4EOY6ngOB4vSYGMmU2eFlTSIHFrxJcILkm68imhWLmx0yuC5xGdp1tC9vSg==", "7dcbb725-49a0-4996-a94a-7623c24d10f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "583a9ccd-e6b8-4ec9-8488-a0b445989a19", "AQAAAAIAAYagAAAAEK68Hk5ArcYfsL2/nIrMrVd+X7Co//bW13sHeO18w9t1S/iE/DM9BvwtaOyvfwz+jQ==", "ee29f04c-5d8d-46eb-8c55-a2114cc909bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5035f50f-fb1f-4020-860c-9ea19a2ebd41", "AQAAAAIAAYagAAAAEFi1IYqiRAaoOtDRMeb+bWuQpimZ5Y0wlCv7oteJl948trogFzvAajP908uf2MAGkA==", "73397bd5-ba82-4cf5-9421-79f7ac1d7250" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2eba9fbb-aa3e-4b95-8421-b95bd6fa5c69", "AQAAAAIAAYagAAAAEDC2bOTSJtj1r5EzNlslHHVoy5NhtFEa7wQizAkPJUBireFeCTXYKHBZ69brccOZyQ==", "8257f077-ef5e-4f3d-91d5-ae8cf857137b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53caf1ff-ba96-49bd-8510-c3e4ca11aec9", "AQAAAAIAAYagAAAAEPTy99+bNdyt6tpD6zm31RVd3p6814IblNuAVAZCT2u+VH7pXJkwF4pdmoNWjYBa+A==", "97fcf09e-5c1b-404a-99c4-58df19cc59b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f871c4f9-d4f5-4b5e-aa62-088db4fc2d52", "AQAAAAIAAYagAAAAEFWF0e5TQnPqQrFdfNToH9Qfh7B5mQjMmsyyDiPI8fYXrfRs3mx3Df1muSjupe8ktQ==", "f605291d-fffb-4577-ab8d-f7e0d5bb07ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea34d113-6c68-4bd4-9995-88d700d2d395", "AQAAAAIAAYagAAAAEHvMyfw0GigsCD7DC9Sx9ZM8qjeuVJIzdjAM1b/rivBgvZps5S2n5Dndd7rc/Ct9gA==", "d4d13b04-3b5f-4c60-94ee-da01ee808258" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c63f662f-a897-443e-bd96-5bd060e560c3", "AQAAAAIAAYagAAAAEJLgQ2bjEyiMabn73jmp8d38PskbBfsICMz6G3Y5yyTFLQSw3dwKo7vwW4KMGatXQA==", "61c6ada3-ff19-44e6-b769-36668cc70878" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9986), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9623), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9620), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9626), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9626), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(55), new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(65), new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(67), new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(69), new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(70), new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(73), new DateTime(2023, 3, 16, 2, 12, 42, 725, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(6604), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(6703), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(6707), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7120), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7123), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7125), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7126), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8463), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8468), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8470), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8856), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9247), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9251), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9253), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9255), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8032), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7509), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7512), new DateTime(2023, 3, 16, 2, 12, 43, 946, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.CreateIndex(
                name: "IX_UserVaccinations_RegistrationDataId",
                table: "UserVaccinations",
                column: "RegistrationDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserVaccinations_AspNetUsers_RegistrationDataId",
                table: "UserVaccinations",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
