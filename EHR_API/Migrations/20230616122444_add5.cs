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
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MedicalFacilityTeams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MedicalFacilityTeams");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8387), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8701), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8706), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eac68e98-59b1-42a4-88ee-d98439aeba85", "AQAAAAIAAYagAAAAELfk3Fnkh1KFNmi1q6NYlDH/bi4xNr/yUhLsoSHkENitAZMGDLB9mRINC74//PiMvA==", "f63a22f0-9665-4a8a-8ac1-1d2e105c6071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e040d0c-1e7e-4ae2-a306-f2f44407d7a2", "AQAAAAIAAYagAAAAENTsqlUx83LQA3CET9CoUD0HsakxagD8eRoXoG9jaAHQKU1yZjaXwpCsPWxicHq+wA==", "2b141713-eeda-45c9-a7b6-524761cc70d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a22c59e-a264-4435-a841-7465bac6f073", "AQAAAAIAAYagAAAAEJOEKQQrAxVzb7/MjbStFpvA43zYnTF1ff3FB8OVtRuNh05mrgjAr9LBaLnEx3ilLg==", "8b02d0ae-e900-480a-8627-261837570d39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78a94d45-83ac-4675-a77d-d0b226dbd599", "AQAAAAIAAYagAAAAEIOff7ttWzVta16FOzzcw85BBo11IZ/c7D5LM1XoNZp22kpAyYFvjJZ9Qp6auCiyiA==", "e9429c2e-6b87-4e95-bec5-54d388eea90d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a2f3c45-d116-4e28-ab7d-2dbbe640f25e", "AQAAAAIAAYagAAAAEFL2o2IU5w0UU+4lGgoX26L6dOAYiB7l5goRVb3AI3TTGd7y9itXuvBIfxop/kD4hg==", "37e04f68-f846-408c-9cdb-1e65b36cbf26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3925c45-f24f-4b70-b9e7-71a016dec1a7", "AQAAAAIAAYagAAAAELZBcbcWzd7RcI00Ag2RK4jXurusWAuAzd147S/FFA/J2GwXWqyO2TvppeY/R4j+kg==", "c3bf6e4d-7c2f-45bf-b34b-36bc13ab0a6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d8cbaea-eeb0-46c9-9a45-0adf4f1982bd", "AQAAAAIAAYagAAAAEEpYk91cPbR8sRDcER7pxZyhut+TtRVERAXMLqaDX4rp/rUwYmSjG5wJXRF29XDXeg==", "c36a95e7-b791-4d21-831d-7e7fd64758e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "185a86de-a913-42b7-828d-6977e6d6290e", "AQAAAAIAAYagAAAAELSjmX4DL0TZ0zr5vd0ibs0q9SWEmpW7E7rWp8xLcsJk/lQBXpKH9J9l3GhiMEn5VQ==", "c40e0f40-a69e-42cb-8c22-ef6f3ab550f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c7dd5f2-2281-4352-ac73-28427162d321", "AQAAAAIAAYagAAAAEApl6/+qWRDTQNb8cJblvFAc4wF0zYXa44s5u2F6o+aayexulUtjno/GEEzpoKkMcQ==", "76621600-f7e0-46c5-839b-21f45681af34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deb6cd07-dd6b-4d2a-8322-e16e2c909fe8", "AQAAAAIAAYagAAAAECUavcB8//Ne6XpGe8WuOJ+Ny8djWdoEPM4Kj8njrGm/ktgsyI01VXnhi6Fs4di2/w==", "ae5b856c-dcf2-4b1e-b843-6bf3400e7986" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a149b860-2aee-4562-afbb-6f4ee01e3139", "AQAAAAIAAYagAAAAEGzcGRNwv2RtSZsqfB2p9EGqzmqAMz5n+zEUO05vgAvX12B2L4g9qPfE2cZ7ai8i4w==", "f2642f44-d9d4-441e-bba8-150f5abf7305" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8084), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8087), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7774), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7783), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2876), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5264), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5268), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: " I10",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5592), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6777), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6792), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6795), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7115), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7118), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7121), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7106), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7109), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7112), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7437), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7443), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7446), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7450), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7453), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6434), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6447), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6454), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6005), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6010), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9155), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9161), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9172), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9173) });
        }
    }
}
