using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "MedicalFacilityTeams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1350), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1353), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1357), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1592), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0f8c13c-2d8a-4484-a80c-ce1fc864f463", "AQAAAAIAAYagAAAAEDuudx2mBFy9+9UuJVgPd7sHp2JqJ+oTZ/QuyA+wQCBFUKZaCocjUHsHXosAv6RfOQ==", "f9e8faec-0c29-4010-a351-e96d4d63bcce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ebd61e0-ae27-449d-b0fd-a131a060c058", "AQAAAAIAAYagAAAAENcLOfIwW+Ejf4bptXPOzE2lhF2hdLIoe4LJ+2OUzg3Ik+XptnOAKI0z6i0/GXgP/w==", "e1777b8e-27bc-4b53-ae84-89b103ebd506" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7799770e-1521-4119-becb-91f79a0db003", "AQAAAAIAAYagAAAAEFFA3fqwdtk+reUahHuOsjAi7uqUdVlcWpCIPt2qkCTAdJJku+v5NeCJHlOcUKbSvg==", "dca7b24f-e3cd-4f23-8b58-8e45f375a312" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6d19c35-e7a4-46af-a208-c3197e529170", "AQAAAAIAAYagAAAAELv3q+3mRC8NhzcBXFSmrpV93FQNze1Zf46/b+DKozr71OCvaLWpN2wRF74W4lYBtg==", "5a180c1e-7f18-4179-aadf-136f8c0fa3f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86cd3894-1652-4bf8-9a47-aa0fc7354eaa", "AQAAAAIAAYagAAAAEFAX/k3Tt4k1gDbIuWTIdP9RUhiMrBg/DS591M6anPy9mYgzsPW5FT2XTQ/i+OW9iQ==", "2d3c539c-3137-40fe-a8ae-7d0c16dce91b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a5e4d64-aeeb-440a-930e-883e34878a5a", "AQAAAAIAAYagAAAAEHcQXsipJslrRt4mhhDLgkOq/48XUgsUMvaQPhCwvlyB83yTHAqYl9ajv6UlvBOPFw==", "ffe9fa06-9f95-4da9-806f-e4743aea30e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cfed0a0-21ad-40e8-b084-0c23d9f264d6", "AQAAAAIAAYagAAAAELWLieIwySEcKO+FHMQ+mUwQrm4A34GIZlqGJV3ohgUy6itU6glpeONvUvgqGzY+Xw==", "6eda03b7-d77e-4c53-b9e0-8a4e3916b95b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bd38318-fbf4-41c3-b70e-a29b33c60ba0", "AQAAAAIAAYagAAAAEJ69IdUjz357c71D6UiHQCkjZkQJYM2CFU/gVhWL9+CSF3ZoSnWgof7UxR2YUk2AQA==", "87346920-02b6-408e-80a2-647347395ac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47d12b93-a301-441d-a96a-eb2830ed2b4a", "AQAAAAIAAYagAAAAEHnOkYs0jxZsYiN+B3dw0VszDdSB0ckQT52zjYRS71cuX5+0uSVHmW4ujjjAjJ1qkg==", "0bb93873-7640-4cfd-be8a-114095bc178b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd3b00f4-d19a-4ad9-be82-e738d5e41217", "AQAAAAIAAYagAAAAEMAmcvKNl4/rrhAmFKLY2cf1Vay/oKPJ2OIes0sm9iGUs5ioXuP8nbfjhu2hnqUaew==", "613f22ca-6db4-4fce-aaa3-1d26974ef08d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44c7c8fc-c92f-4717-abac-07cd62906057", "AQAAAAIAAYagAAAAEHQl0C+KZ0aGM0EuhOxRf2lFw6mDsH+quuhPaR+lVnd5xEDgEggXC0yFIncsXlwx7Q==", "ed3577cb-0749-4551-a3f3-41df5a268984" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d190db10-14a7-40a9-a2c6-aebcb3e1ad0f", "AQAAAAIAAYagAAAAEBbHEBx9agNR4JMMX5bwTXSXZSR7/kXo9Jj/q0ngXZOGZjgyBscdvtI9+WmAy2cQsA==", "37ee8a48-30f8-40e7-a763-e7cee9f26ff5" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1099), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(864), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(869), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(868), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(876), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(892), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(894), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(897), new DateTime(2023, 3, 24, 2, 14, 5, 490, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9050), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(111), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(114), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(361), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(367), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(369), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(371), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(365), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(618), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(620), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(622), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(623), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9839), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9848), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9853), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9450), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9452), new DateTime(2023, 3, 24, 2, 14, 6, 279, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1832), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1835), new DateTime(2023, 3, 24, 2, 14, 6, 280, DateTimeKind.Local).AddTicks(1835) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "MedicalFacilityTeams");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(9180), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(9193), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(9197), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 451, DateTimeKind.Local).AddTicks(983), new DateTime(2023, 3, 21, 13, 36, 29, 451, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 451, DateTimeKind.Local).AddTicks(997), new DateTime(2023, 3, 21, 13, 36, 29, 451, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23a6ecbb-b399-4139-877d-4b9e29b1b894", "AQAAAAIAAYagAAAAEEhxqFV2gF6xvjW8KQ1M5Qqls7l/XVz+8cfGGJ0cW9iHZBLs/vqRtf+RqxadpvJfnQ==", "5290a234-212c-440b-984e-5ba465584819" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8a9ba06-bd04-49ba-87a8-d0c47658d135", "AQAAAAIAAYagAAAAEOb1IALcyfARkUlVPvm4hpDf+ulG2BMSrQ5PsMDBn2LuWdoBqQ89oDhcxhQYH7Ou5w==", "5fa69a0c-5306-4af5-b7d5-097456773819" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aae3ad0-d7f7-467c-b157-badd0cfe1459", "AQAAAAIAAYagAAAAEIarOrDlicBMJLhP+pdbOa/XLDnXHytOP0Jqr36JqceSPBxjO4cedLpeYi42wx0upg==", "e3473e9e-b8b5-449b-a5ab-871796c39c75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de76aacc-56d9-421a-926b-6b695a8e180e", "AQAAAAIAAYagAAAAEITmVCSSF3bdB+AugldzaFQxx0OGfMuMT1qTcoRvTVRDDd5WLiZhabY+vdRwsFK/ww==", "76245c3e-9b3b-459b-a20f-60528a32c6be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3993286-9924-4f2f-9392-cccd2de04977", "AQAAAAIAAYagAAAAECqe8sZFdlth2OQU9yDvYBSxCVEIVPEisbaP/aOnzEBQXY2BRpbWK0lCELCbkrrH5g==", "5e88b823-4d7d-4dab-8934-272b2ad98d59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d0e4a3a-381b-4641-98de-b867b5a81daf", "AQAAAAIAAYagAAAAENjakNsW+BRP2Py6xcbOonx87JuiNIHtafBlRFTY/r5SFeO1gVQxXW0y4E8JIiYEcA==", "32171a2d-cb2d-4c06-a4b1-939455936dc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0b99846-c3e4-46c0-a8f9-45fe51b3a88b", "AQAAAAIAAYagAAAAEPisDzZ8m443Zk4HU7Tc4jEELNfncgsArY1O+JxGrd7z/DLffwdzguoAYiLgrKdVfg==", "3429735c-378e-43ab-9f44-33999547bbb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2131f8b1-8ee5-4097-a18c-5b0062b3f35e", "AQAAAAIAAYagAAAAECB2naBBcmQKKZ4PDs0VffOwgv6+BZztEGaULBdinu/oKfr1app/PUgQEWOB4L08Sg==", "225b4fd3-5fe3-4714-ab26-8c82499e98ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3b9d7dd-1fe0-48b1-ad4d-91d5b077be8a", "AQAAAAIAAYagAAAAEBg2dpWxMzkRY4+ca/sTcnSbAgf6kroc1zCAL26tar2H7uAjLZHKhis1yhAFrX/sGQ==", "dcdb7d99-8d4e-448f-9915-af4e67b1c6a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3683788-081e-4782-bda3-64b546b86cef", "AQAAAAIAAYagAAAAEJKjtXcDh7uGid5UFidk5YYQmlgz+2BVdN0NHTJd1q5uGSPJT7ihuPQ4kw2f39pWJw==", "b98c52b0-5e20-4df1-9dd2-25c9186d1b55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d34fefb-0bab-44b7-8de8-c7bf4fde508e", "AQAAAAIAAYagAAAAEMuIRYRjb1BJeY7m2I6FDQDxytcOzx1cFOO6y80RVA7T80l54vpmfy1DUxOAPYUeUg==", "bb32ccca-7cf2-4af2-a146-809d286c5272" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63c3a929-7f00-4809-b187-2405d84693c6", "AQAAAAIAAYagAAAAEGKjB3LSez95yUCdF9jV0OFGNZacyF54Rd0twJjpLTRCixEwRy73Fg+szo4KlA+BtQ==", "9dcddafc-5424-4812-8a95-cdb1be6d571e" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7729), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7733), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7735), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7070), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7068), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7075), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7074), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(843), new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(859), new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(860), new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(862), new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(863), new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(865), new DateTime(2023, 3, 21, 13, 36, 28, 574, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4011), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4028), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4030), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4314), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4316), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4317), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4319), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5954), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5959), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5962), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6271), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6273), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6276), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6277), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6651), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6653), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5385), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5396), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5401), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4605), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4748), new DateTime(2023, 3, 21, 13, 36, 29, 450, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 451, DateTimeKind.Local).AddTicks(1924), new DateTime(2023, 3, 21, 13, 36, 29, 451, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 21, 13, 36, 29, 451, DateTimeKind.Local).AddTicks(1928), new DateTime(2023, 3, 21, 13, 36, 29, 451, DateTimeKind.Local).AddTicks(1928) });
        }
    }
}
