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
                name: "FK_ReceiveBloods_AspNetUsers_RegistrationDataId",
                table: "ReceiveBloods");

            migrationBuilder.DropIndex(
                name: "IX_ReceiveBloods_RegistrationDataId",
                table: "ReceiveBloods");

            migrationBuilder.DropColumn(
                name: "RegistrationDataId",
                table: "ReceiveBloods");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "SurgeryProgressNotes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "SurgeryProgressNotes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Surgeries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Surgeries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Receives",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Receives",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ReceiveBloods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ReceiveBloods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3861), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3865), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3868), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(4177), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f74e2542-8a85-4c61-b138-b3ecf7c29183", "AQAAAAIAAYagAAAAEEq9Snoq4ngrJC87U0iACxyQCPcj5qsG3i9YFVPpjfrfyfa/lYRHSO2nXqXud10beA==", "f7f9b3f8-46db-435b-a18a-2c050e6bef26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2095a17d-71a6-4876-913c-4f0e5e0b3f13", "AQAAAAIAAYagAAAAEEglptZHy1mbkrUnnqTTQUZAPVpInrbIrnH93qoMPnQw/ifijlPwdBSnYjbSYXeciQ==", "96e52540-1722-48e8-bfec-163bc32a9d1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd284c9a-281e-48c5-990a-b66ddd961fdb", "AQAAAAIAAYagAAAAEHElrYLeHs+kzGX3G2GCoJ4CqvmnAyeXNpy+66vcPLqrhbmEREKxHlPjgxRP1bSkOQ==", "14f92b35-44e7-460f-af02-95409f1a652d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7dc0ace-9681-4eaa-b8b9-399e0cd0a884", "AQAAAAIAAYagAAAAEObUtxdD/q9XQHPSag8SLvMaZhm8jD3CPh60BXsrIc+U6z3XDkkL87u+CEa/DP5/dg==", "1e754644-a032-4c9e-a63a-b2ee9b800b34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1190624-d341-41f8-80cd-93a95a68205d", "AQAAAAIAAYagAAAAEEBv9QBWCE5rvhejkbqbxeRLOoasOAGeE+ignWOIfvUXn/ellrrBhDvFuT2qFOaJjA==", "2daadfeb-0974-4460-ab7e-731d63e8a9a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8afcd4c1-cb73-47b4-a71f-6508a58dea3a", "AQAAAAIAAYagAAAAEFg9HcPnvfwIyEh9aiz3ZQGd4GmaGl70qVo+zJ88V6TaKSNke0AdpuvRZmB+QIqQbQ==", "51b379a4-a0af-438e-b9d1-994f04067c62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e47c14fa-9aa3-48b9-a7fe-a78788f1a3d5", "AQAAAAIAAYagAAAAEFiQj+2KZTRAOT/hRcpY6TA6Jh0QakTzJpQVZ9PChmpUK+m7eWzJXIniGvJ0YnhMpA==", "1e47b9b1-0e33-455d-b494-d2d3442f048c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eae8e287-8e64-44bf-92af-da3a2367977b", "AQAAAAIAAYagAAAAEGB9SYxjskEsheGGcosS7Dx8XqI8AdCsHDGvEaVnISJhBWwp1tUk5IWknDbzMgkrfg==", "db596c66-bce5-4e33-98c1-52b0f790c283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f441639-d580-484c-ac07-1ddb12a4a909", "AQAAAAIAAYagAAAAEMT6mUvCtdMAU7k2XoQRa8XRJCjBbl75OsWLOHLrNOhmFFs473PyYtr5XiZhCxVgpA==", "fa42f0db-d9b1-4834-bfa2-d7f2b88a36b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2b3d059-31f2-45fa-962a-d219f9a2fc84", "AQAAAAIAAYagAAAAEHwDWfWV8Lwo/D9HLCbAEWB9MrfN/qp9HrQgI5f6HF/Ni9PNbznFsbSKVpR6mb//bQ==", "8444cd72-0f07-4a62-a5c6-0c017390c124" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0df39bb-603a-4dd9-b6c3-f9de8785f5cd", "AQAAAAIAAYagAAAAEEKWcb8xy6njj9pRnaon+4U6YNVLWzWXXadnBOz0joa1LNyh7YRqP2rX8Dp53gqd4A==", "982f5869-adee-4160-9cdd-83ea58cb3512" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42b7a627-70f1-476f-b21a-1a4067a26d6d", "AQAAAAIAAYagAAAAEFJ667/0z1aRGJ6V6TBgRXCWb8InWz2sest5HWVIpUQlgPJt84FaXQs0febQUqPqPw==", "c731df43-4f1a-4794-bf5f-c6679c3cc720" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3552), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3555), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3557), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3247), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(804), new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(810), new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(812), new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(814), new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(815), new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(817), new DateTime(2023, 3, 20, 17, 57, 5, 80, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(600), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(608), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(611), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(941), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(943), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(945), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(946), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2168), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2172), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2596), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2605), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2608), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2610), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2604), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2930), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2933), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2935), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2937), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(1736), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(1747), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(1754), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(1268), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(1271), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(4499), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(4503), new DateTime(2023, 3, 20, 17, 57, 6, 145, DateTimeKind.Local).AddTicks(4504) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SurgeryProgressNotes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "SurgeryProgressNotes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Surgeries");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Surgeries");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Receives");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Receives");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ReceiveBloods");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ReceiveBloods");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationDataId",
                table: "ReceiveBloods",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveBloods_RegistrationDataId",
                table: "ReceiveBloods",
                column: "RegistrationDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiveBloods_AspNetUsers_RegistrationDataId",
                table: "ReceiveBloods",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
