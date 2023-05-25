using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                table: "HealthFacilities");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiveBloods_AspNetUsers_RegistrationDataId",
                table: "ReceiveBloods");

            migrationBuilder.DropIndex(
                name: "IX_ReceiveBloods_RegistrationDataId",
                table: "ReceiveBloods");

            migrationBuilder.DropColumn(
                name: "RegistrationDataId",
                table: "ReceiveBloods");

            migrationBuilder.RenameColumn(
                name: "RegistrationDataId",
                table: "HealthFacilities",
                newName: "MedicalTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthFacilities_RegistrationDataId",
                table: "HealthFacilities",
                newName: "IX_HealthFacilities_MedicalTeamId");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8719), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8722), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(9113), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(9118), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62913ea5-6ba7-4730-8be6-a28f0b1f9bc1", "AQAAAAIAAYagAAAAEPW7XVZ5Zova/Y8iADogtrGf8XkByKHSy4vv2XOTKA0Ci8m95eIil1tYwvTdJFrD3w==", "3985ff6a-0121-4e27-b4a3-ff705f775589" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86834307-5f77-456f-ba98-a4654d1c60a6", "AQAAAAIAAYagAAAAEEegYxxv03dsOHkJsDFyO2PYfqxDWMmMyeJrmfrm15lErdPCOFmoVTA9yO1Zxx2fJw==", "62685f06-1df2-4300-9650-d6d743fe8d6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e12931e-b5eb-44c9-bc0a-84bd56ac33e2", "AQAAAAIAAYagAAAAEFY0A3a3fR+HvKh34EU6CLOcwVDHRutWY23HRdHUgdMu5ZCe9keesrDmPMmpuftaow==", "7975b6fa-09e2-472c-87c6-4fbd323a1e5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10da27ea-467f-43e7-b73f-cc1c4f818dda", "AQAAAAIAAYagAAAAEKaPbv5HiCvnZ2K6roD3w2Cfqu3Bz+yF84ZljEELbxYZBDF1AUKyyGfqX5J3n4/Zew==", "ffd7ff75-33a5-4ba8-b66b-53793c38a87a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f0be2f5-4427-4514-999e-2c625ccf1afe", "AQAAAAIAAYagAAAAEFNew3tnyflQTiTviSDAGDy7mCHccXx4CemwGV34UgA59bHjgROO/eLWby+G/dZLNw==", "1ccc41bd-85c2-479e-9480-2ab279311a8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19ac142a-38c7-4ee9-8a81-e1836fb50b33", "AQAAAAIAAYagAAAAEA+2Ciuzb9yLjpeyONTnSSij1GoMNECOdt/wzcUb8qHppkdLpiuABKnOWI3MY+ojcQ==", "88699b0b-5880-4a17-888c-b5687a539d46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7de82223-0f82-41dd-b21f-c91dea196d3d", "AQAAAAIAAYagAAAAEG+a+nnMYdk9uN5d7yBeiXkt0D9XtMEo9QD5ehv6vJKqLCqiSjt5F+eOErhnXkinzQ==", "08ebef56-9714-4548-ae75-c3fba7db0d36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fe1924b-4328-45c1-9257-7a88a42dc00d", "AQAAAAIAAYagAAAAEP+1Q8rYw48K5u7FFENt35XRI5JcVx2yVdkdZRt2P7egxR8FoAC06eQmvdEgmevu2A==", "25d74760-0312-4a44-9fd7-81deac8acbcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8748d88d-feeb-4ccd-ab46-b70330cfe52c", "AQAAAAIAAYagAAAAELEfNZQIRbEdGxpWB/dIfKKOmfL4VvwRMerWtcFwBRz/bOU9LxxZZf9RE1aq9MIpaw==", "729e1ce0-70e5-4254-8d5f-5fd7a65e425d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb8f7519-3530-4b3c-91e2-814aa1f4b2df", "AQAAAAIAAYagAAAAEGwzucib+2Dg2QMlkAcolqEibzMKjUGzqGzbGo+ASwTKUx/91D3UQ2xp/Qgv2PqOtw==", "fda6274c-6d54-4dbb-accd-e1f2ad38268f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfc9ee20-9c1a-4f23-9efd-707e4aa62f0f", "AQAAAAIAAYagAAAAEFxMfw6oKcy4WeqHanqIktP+3r6xhiCDQHY3C0lx+WGLqJF33mMvQZN9+YHNycp9rQ==", "ede57d7a-4537-4602-8524-6359c024780e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b026e778-0e21-469e-a485-199c0e96d1de", "AQAAAAIAAYagAAAAEIUQiTmS/xvJ0SmRrDgmOBdnhOsg1YIBFd6qIDc4iU3WbXWD5MXM5pwjNq9aR+QOyA==", "c0fc4e77-f821-4745-8bdb-d90e07251cfe" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8420), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8426), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8429), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8139), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8135), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8144), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8142), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6535), new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6599), new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6603), new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6606), new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6613), new DateTime(2023, 5, 25, 23, 27, 9, 964, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(5696), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(5757), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6125), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6133), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6136), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7217), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7223), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7226), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7529), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7542), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7545), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7548), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7550), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7534), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7537), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7540), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7845), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7851), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7857), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6884), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6435), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(9408), new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.AddForeignKey(
                name: "FK_HealthFacilities_MedicalTeam_MedicalTeamId",
                table: "HealthFacilities",
                column: "MedicalTeamId",
                principalTable: "MedicalTeam",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthFacilities_MedicalTeam_MedicalTeamId",
                table: "HealthFacilities");

            migrationBuilder.RenameColumn(
                name: "MedicalTeamId",
                table: "HealthFacilities",
                newName: "RegistrationDataId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthFacilities_MedicalTeamId",
                table: "HealthFacilities",
                newName: "IX_HealthFacilities_RegistrationDataId");

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
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9434), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9440), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9443), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9709), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9714), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd818f7b-1d06-4828-bb0c-ea05d8a67915", "AQAAAAIAAYagAAAAEBKCJarLJyf7qNMGD9DTGeGyo9mkVTRxOlNt/W0/17ijO7hmAM35Rm6QRhNPCczGGg==", "006019c9-ff96-4da9-ade3-8fbffa1f862c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "599d4d69-7cb2-4b57-b0a2-db7a9f5c17ba", "AQAAAAIAAYagAAAAEDVI+LIH8eEC6BAScHDuXJZLKc4tfMNxuhD0H4NdIQ0kgYWP5TE4mePILLAZ3vSrfw==", "f684eb3f-d5cf-40c8-b7b9-529a88fed691" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f75d573f-9027-49f2-85cf-f625e259d99a", "AQAAAAIAAYagAAAAEKw0D63+/QPjwjLxRrIbx7JX/wX9RxC6ungHB8fVi2fIE8gAbc5D08JxpuZ7YyOqxQ==", "34d75e22-d0b8-42c9-ba4a-4cdb2eeaa261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cff46a6-0c30-4e4b-bdd3-dd712692d0bc", "AQAAAAIAAYagAAAAEAOJFK4E4e+CQlgPKXm76GlIp7iiwqBziFsySVfYmFMOqp4o5CWMGKvSTzh4/0ZHbQ==", "c3c70749-3439-405b-9f81-71b0c3e47e74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d67e650b-dc13-480b-b5ed-6b8141cc51df", "AQAAAAIAAYagAAAAEP/AYaEsa65wn8GvQBnWvreMXwhfSumsgkZjmbzzjy7qzKlSWockRrvF1LW6YoggIA==", "41a90fd1-a3cb-4d93-ae17-5e89c10d3760" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18b49a05-3415-4b7c-a6b6-da52e2ad1bfb", "AQAAAAIAAYagAAAAEGRJHqEw82krl/JcKvzUYVOsshxZBVmiLrfuHKog9OX87V8POxflHZghmdoNUNWpCA==", "bdbb502f-9f8d-4930-a83d-ec876034817e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89b404a1-cc25-4216-a9c3-1bcc9fab94ea", "AQAAAAIAAYagAAAAEAz3tdR5iPNrPQNXi9jBFRupJz+HWB07TyU4RhuiccO8stq7HQZ8xtWho2T5aIvnYA==", "6312af78-2e91-49a4-8cbf-1bdf5faa5128" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5f3efec-57ed-4d26-b71e-afb3bc33434a", "AQAAAAIAAYagAAAAEN9C0iXHAQnynEKUG8Vhx7aUTXT4dXLbFTR1KiyhLI/BrJfU1G0FXQ4uReC+A7pDZQ==", "67e1ec51-de8a-4566-9e38-b0b60fdfd6ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "214b4d09-9cda-4133-a66c-c2d38ccda8b7", "AQAAAAIAAYagAAAAEAucf7alF9EaGFg/w+7kswvsKy4L3wO3oSXGlzBSpr+nvndb0WTE0ceoTRJu0PNMvw==", "a7adabfb-d976-4abd-9d7f-b7ce3900a60e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2859e03-cb0e-4315-8e46-8c50212ad43d", "AQAAAAIAAYagAAAAEPmK7AM7+GJ0g1vVP/vhi0SiObJFNKHUU9QnSC+NMAUJV2f2mPuFDeFkqV7b8acFaA==", "2a2967ba-e516-4601-9adf-5152c3bbf320" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4d507b8-cb19-4889-bb3b-d8a8c3992bdc", "AQAAAAIAAYagAAAAEO8iLlEaWdS98uyOYDS2iFoCGMzKymOLSjMtuz2q/4O5Dj92IZfuUhkPGSus4OuA9A==", "ae4feea2-59d7-42ab-91eb-915da14891b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4619ed4-c4f0-43e4-85b9-e844805ac156", "AQAAAAIAAYagAAAAEG2AHBhTdeyEHqgrpd/5IWwbLY1qq627c9FwlOSdIploU5BCAxfwJz6nypDgWOSdwg==", "7e18d078-1e6a-4f9d-8606-18dbf1a96ded" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9115), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9120), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9123), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9213), new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9264), new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9269), new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9274), new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9279), new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9284), new DateTime(2023, 5, 24, 21, 42, 30, 719, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6449), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6644), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6944), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6950), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6953), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6955), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7988), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7994), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7998), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8274), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8287), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8290), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8293), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8296), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8279), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8282), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8285), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8571), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8577), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8582), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7670), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7684), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7258), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7263), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 5, 24, 21, 42, 31, 606, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveBloods_RegistrationDataId",
                table: "ReceiveBloods",
                column: "RegistrationDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                table: "HealthFacilities",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiveBloods_AspNetUsers_RegistrationDataId",
                table: "ReceiveBloods",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
