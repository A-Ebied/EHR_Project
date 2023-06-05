using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class db4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8918), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "NormalizedName",
                value: "HEALTHFACILITYMANAGER");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32619418-fc40-4bb3-bc70-ff3fa9a1dd5f", "AQAAAAIAAYagAAAAEH0txxKHdOZQuonxQM7/eDW5PspMjs6bRHruYjeRa4EXst+OltYLCnlafVkb9D0GfQ==", "f939b792-616f-49cc-bef9-96ca8045fb82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab5109e4-1ff9-494e-b7f0-25bb69d47f79", "AQAAAAIAAYagAAAAEEDvileho072WKErApPYBAS/yRNx9jkYzIVRyFGcfrpN/aq+w4TXYoURWINrSKpgDw==", "3edd36e2-deec-4422-b393-d4aef650d552" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0eea9b3-7fde-46ec-a93c-929656c809b1", "AQAAAAIAAYagAAAAEGt991fbf9sUF20EbvMwv95sBVeJbjKc05CUBrLV7+VIoxuHLxRONVcAJaMO7dZdNA==", "b0e5c787-3af3-4487-8714-b30461bf8cf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ccc0706-f107-454e-acb5-29734ecaac71", "AQAAAAIAAYagAAAAEJp8mKRGMv4LC/u7odjmlERfLr/FVXmT5ukbp6PGE7z9g4FKKK3/Nc54LPk6WrCSyQ==", "9362a62b-a35c-4ea0-961c-638bc50ec0d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47b2a3db-10ac-4a2a-b841-6e5b90bcdfc3", "AQAAAAIAAYagAAAAEPi0d3uCWHUDiKnrNc6kuHXGpij6XfkQqpPu4F5J5rnWnfC4a+ayqrpoW4Azl/ujRw==", "21b68d30-0939-4be3-9462-fbb2cc8e6f4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7751264-9f7b-4858-b869-daeda5f8bf76", "AQAAAAIAAYagAAAAEHJwzsM8EleSmNPsj/aNicEBLwVOVT+baPqhs25yw+3COgVpgq8n1b+BvrN5THamJg==", "cfb41475-b94a-4d02-9108-f41bb639188c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90433ea2-45f2-4050-a11f-4328e6cef2f5", "AQAAAAIAAYagAAAAEOFCElfPlokQ7EIBTB0SZw2vpgDkJLWT6CC9B0XIpWL68tisOxbGQ3MCNPvnyZHOWg==", "dc1b3677-a3d6-46a3-90e6-49dcf7a8eb38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06be3f01-5926-4f24-9f99-5fa9bd0b1799", "AQAAAAIAAYagAAAAEB1s8vbTrscjjmGRJnjzMbtwQLZVp0GW6WygKBoNXRnQPBfDM992A2X7g5AIadXRjA==", "1dfb84b5-41bc-41f1-91e8-054768c0bf3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaeea70f-6cb2-42e2-9139-5b1790a7a23c", "AQAAAAIAAYagAAAAELb+Itl8QpEDsuFVGxRrpffp117c2DoyxlwLtfW42WfjOmITTKT6nCxKLuYxqi7F+A==", "e4b0ba5f-8201-4b1d-bf3d-5c8bef4d89bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96eeddde-d719-4f56-9150-8e11c3af500a", "AQAAAAIAAYagAAAAECxvs5KPivsiaJdzZ0vwRVyQ5vwPH8Jro573wx5oMQ+nonQfMrT3WbPDA+E7fPHCVQ==", "ac084808-6253-46a9-88e1-e75bb20e44b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "863da36f-eb6c-48cd-a7ad-6467ad238661", "AQAAAAIAAYagAAAAEE77V4y850W2GkWkGYx5bdzo/9DkoXfmt3kLoE8a5oo2HJO2K1k5Q6btv4udaWNMgw==", "9dac9b81-ebbd-41a3-8e14-6e6a57e19189" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8377), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8381), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8145), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8143), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9692), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9741), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9748), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9751), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6069), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6111), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6114), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: " I10",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6384), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6368), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6373), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6376), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6378), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6381), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7358), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7614), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7627), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7630), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7633), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7619), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7622), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7624), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7073), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7085), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6691), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6696), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9166), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9174), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9183) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(557), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(564), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(963), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(969), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "NormalizedName",
                value: "HEALTHFACILITYAMANAGER");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84c7d8c8-c5a2-450b-b9c9-08b1b01f7b82", "AQAAAAIAAYagAAAAEJiKB/6u13NcPdPahNAI4e1nWwUFQiMEkMXOCoIJJ9N6NDxreAYYFBW1lA+zbbE/3w==", "f32257ec-9b85-4434-97f5-59ce68f7069c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff3e7a22-7b31-4b0f-9d8c-74a138ffdd43", "AQAAAAIAAYagAAAAECrxALIIFXYu8HauwhvsFsmufin05qatJtjpmwvTUqqlcq30/fawl2578bOHleBuJw==", "1fece116-953b-4c17-9729-6472c404dfda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be43b14a-5dba-4725-903f-bd1b8e695263", "AQAAAAIAAYagAAAAEEeHUH4V5keynMUo7ofxiCxRtxLRIWkweOEPJCaNw1g2bPQoJXtxxxh3Y432gmwDwQ==", "664b5ae0-0dcb-402c-b644-2ccf7205d251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1852f96e-618f-43bb-afff-3b969984fe92", "AQAAAAIAAYagAAAAEAXJSiFCxHa8NXWO85yCJc745S+O5WxcriXO8FUE/+db/8vVWVPjBHDJTiyA96LJ8Q==", "2df37318-57ea-4f34-b573-5ee5116a881d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fc7fb72-0772-4f51-bf6e-9aa91eb85e25", "AQAAAAIAAYagAAAAEKlBWXiMOfaz50ar2nHwP3vqRDuVJOM1ckPm18ZGLu0JPNf6HKmNyNkTqs2MmgCAkA==", "2bf17b98-bcd3-4e7f-a78b-eceb6ed0f764" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd6455aa-5d60-4711-b8cf-79e9463b78a9", "AQAAAAIAAYagAAAAEH6+W37e+7hxaN6ZpxYHf4UpOT1l2ECRG+E864OvIeX7gRwlAdRRWWoyRDyJrZmRyw==", "db6a5ad5-27fb-4185-a708-a19a17d1f0d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da6feb46-0017-447c-bceb-601b7a54b979", "AQAAAAIAAYagAAAAECvJWkyomDC9n34Ol5ZhUZD0UDoCi1muEwJ5Y1bwQrZeeIlhEWtSnU4b8DEcYS3/Rg==", "56d54109-5f74-4d66-a4f0-34245583a1f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63b57866-c82d-4eb1-a041-281c503046c2", "AQAAAAIAAYagAAAAEA7s9sTd2/l8Wiy9UihWnH+jMDq0DxOdiq7Pi7u80lzY8olfG/n9Un7EUjrpSpw1Cw==", "5f91f47a-cfde-4532-bd16-3d8eb9ff2d92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4751f36a-d882-428b-96bb-feecc5fd9cf0", "AQAAAAIAAYagAAAAEKYh1BFgsSggDtXAxnoZHvEFqPDnrMyuxbicx6dVBH96FgLbAWhFxBYRVywrpu7IoQ==", "8502bd97-85c4-4129-b605-9ecda6ed6de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a75acd0f-ed99-4ef0-92f0-c26bddecce04", "AQAAAAIAAYagAAAAEPpfVlGD1pWM3uTqqYYtj2O0oy/LsLW3BOTZf5X80R0zkCN1inXdzSSzBzSYZqs2WQ==", "071fcf72-b6a3-4e68-9793-b26273b25c4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dcc9ae5-40e7-4a38-92d4-a48cad12d005", "AQAAAAIAAYagAAAAEDqb9TlvHmABsby0oPgHlfrDEmUqf9zxS8nm+UOrMy/g+e2+78FKlol+rmUvmbp8HA==", "b2d5293b-2dcc-4400-a584-8bbf06e711c8" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(138), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(145), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9715), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9710), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9721), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9719), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1018), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1137), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1154), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1171), new DateTime(2023, 6, 4, 16, 41, 56, 2, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6385), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6453), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6458), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: " I10",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6894), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6884), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6887), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6891), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8395), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8414), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8418), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8819), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8832), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8835), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9277), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9286), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9290), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9295), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9299), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9303), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9308), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7293), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7299), new DateTime(2023, 6, 4, 16, 41, 58, 71, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1382), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1389), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1394), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1399), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 6, 4, 16, 41, 58, 72, DateTimeKind.Local).AddTicks(1405) });
        }
    }
}
