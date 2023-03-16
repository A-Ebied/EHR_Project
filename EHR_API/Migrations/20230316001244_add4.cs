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
            migrationBuilder.DropColumn(
                name: "Type",
                table: "VisitRadLabTests");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "VisitRadLabTests",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
