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
            migrationBuilder.AddColumn<string>(
                name: "MedicalTeamId",
                table: "ChronicDiseases",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicalTeamId",
                table: "Allergies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "MedicalTeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7749), null, new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MedicalTeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7753), null, new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MedicalTeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7756), null, new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8002), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d585a3a-419e-4807-9286-425b4bf8611c", "AQAAAAIAAYagAAAAEBUZwbdVK03aqOwC9mhtpy5UdAL0jUNByAX+hbvkhJGbm2A1ixPsr44Pz+NvJL58pw==", "4160cdb7-1d5c-4bca-9e7f-9799dde15e36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f6fe70f-d0a8-4b20-a82a-fdccaa7b59ce", "AQAAAAIAAYagAAAAEO1twOrK8sDdo+QkMWEGPxf4NV6+guxRnEzha8Ef27ayZ6N4g+yI4YMt8lWvtRFsNA==", "2e3f036f-7a52-4ad8-b13f-6f2fad762510" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d6414df-4766-4af3-9bba-aed1ad8fae57", "AQAAAAIAAYagAAAAEHDKEP1aaZHGaLEjcx92E+oYOKjQlNGtzDIYpUsu/3H/3j/9p6/6L8MwVO7HnZObKw==", "36811252-6a99-4a9e-9445-8dbd7d736970" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc7b87d0-1dfa-4936-928d-ad632b34e7a8", "AQAAAAIAAYagAAAAEGTbdMwDfw9Jp59STw98Q+cgzQmz8Xh7XgXFhCS9iqb4418ZAqocdiCDDg0bmKpfjw==", "7f0def4d-be4a-4c5f-9749-6f2333e6d1eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11bf23dd-bfb5-45e4-bc82-ea2f832815ec", "AQAAAAIAAYagAAAAEHKPeTugPi3EjDnJFKXtzfOqaRWKIHCqb44NGBsQGK7hn7tY9pz5vuXzeNtG08qtSw==", "ee38f5b9-5153-4e45-8d10-b092bcbf6177" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd43c9e4-78a5-4e98-b603-98932750ceb6", "AQAAAAIAAYagAAAAED6s1mxm9P1VQM1Q387/OvSGMiTlUulnWYt0WZFhPK8OprV92l+ImASmx6SMEsLMjg==", "14fd9b03-0d8d-414c-822b-9f2384039706" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1b4f3f5-6c97-435e-9b99-87843e323411", "AQAAAAIAAYagAAAAENM7NQAm2LG3ovA9JZCL/Cj5tzlBZnz7z5tfEbKvqb4erc1Q4Y7un+7/m/Vd8ZknNA==", "008f0425-caf5-44a7-84f6-1c7abaa3611b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "815a3826-85e5-4cf7-8f1c-a88f7236d074", "AQAAAAIAAYagAAAAEBG5a0kurN+XHns/4j4PrJTs6RTkLqK2FoT+fugbXY9AkXpViu/DzKu0T6RfDtlkww==", "b4311db6-65f9-439a-9054-4ec2d583b3fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fdcef71-daf7-4f33-ae53-fa3a7e1a3c53", "AQAAAAIAAYagAAAAEPgJutsh7jsHgqblTeokvDaC52DIxCj2lBuoKq74rsUViVA4EoiFoOLCPb/sFhpG9g==", "96bfe5b2-a9d1-43fc-897f-92d78be537e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4f31e05-6cbe-4316-83cd-99a83a041ff3", "AQAAAAIAAYagAAAAENXdPLyMsik6g3M1/9HbzQRR16BRD3QMfGx6wf2i8xxT8rY56pvp/1Co2HegUA4KkA==", "9c563f45-02e0-4739-96e3-2e135bf93543" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1a38a09-46de-458c-9236-c11277466360", "AQAAAAIAAYagAAAAEC3rj1nrGfEgg6nqjUp6a+QPzzq/HhOJIINzSxS60xH1ITcbJbQHpwLsvDqdt/37Aw==", "fc1e2d41-1d40-4ea0-94e0-2cb02b222922" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7493), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7497), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7240), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7237), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7244), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7243), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2905), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4965), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4968), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5255), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5257), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6307), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6315), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6714), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6718), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6622), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6980), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6984), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6987), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6989), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5505), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8247), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8252), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.CreateIndex(
                name: "IX_ChronicDiseases_MedicalTeamId",
                table: "ChronicDiseases",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_MedicalTeamId",
                table: "Allergies",
                column: "MedicalTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Allergies_MedicalTeam_MedicalTeamId",
                table: "Allergies",
                column: "MedicalTeamId",
                principalTable: "MedicalTeam",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChronicDiseases_MedicalTeam_MedicalTeamId",
                table: "ChronicDiseases",
                column: "MedicalTeamId",
                principalTable: "MedicalTeam",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Allergies_MedicalTeam_MedicalTeamId",
                table: "Allergies");

            migrationBuilder.DropForeignKey(
                name: "FK_ChronicDiseases_MedicalTeam_MedicalTeamId",
                table: "ChronicDiseases");

            migrationBuilder.DropIndex(
                name: "IX_ChronicDiseases_MedicalTeamId",
                table: "ChronicDiseases");

            migrationBuilder.DropIndex(
                name: "IX_Allergies_MedicalTeamId",
                table: "Allergies");

            migrationBuilder.DropColumn(
                name: "MedicalTeamId",
                table: "ChronicDiseases");

            migrationBuilder.DropColumn(
                name: "MedicalTeamId",
                table: "Allergies");

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
    }
}
