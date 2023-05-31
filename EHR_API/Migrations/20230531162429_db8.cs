using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class db8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image2Url",
                table: "RadLabResult",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Image1Url",
                table: "RadLabResult",
                newName: "FileUrl");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7201), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7206), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7209), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7452), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51d603f6-e1e8-4c97-9795-fe2b9757a1ac", "AQAAAAIAAYagAAAAEIV3fPT8CMD17YggEsdNR80HIET3cF5eZZMp6bxGrTCIELtaDYc70+5D+qqkxPuaxw==", "85af92ba-1edf-4cf4-ba50-76ac08dc5f0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce528736-584a-478c-a977-1d617f8a4807", "AQAAAAIAAYagAAAAEG20F+CFW94GzxCUTROIXQSiZ1HCv/a84Hl0M1Rokl6HQddEAEsRg8qoTIgTmc+hlw==", "383efe22-67d8-40fa-a13b-bbeea0fdcc59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08f7572f-30a8-48e4-ba7a-ce1ca689787c", "AQAAAAIAAYagAAAAEEzuqCsqMObTe0RWliBVyIKVHkrqhO2BCqs7PFEPaQtQUnXn84zauqRlWDPmdEkstg==", "a56c7fcd-ae33-40a0-b0bf-88db1386c97a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f509622-b09d-4441-86d9-28f4667cd35a", "AQAAAAIAAYagAAAAEO+Dw1IOScg+wsL6dPdyfWmcTFV/BaLcOxxM8OJopFcxifE2R6JlU0UFjw7xfYRcLg==", "e0b0240d-ce24-459c-bf9f-ad058ace997b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d6dfaaf-882b-447f-9711-67e01c9142de", "AQAAAAIAAYagAAAAEH88YJ1+wTKtN0wEdI57YkTk1cn2+Udbev3bgX2J+AoEm9QHLXT45hR8UuWmHJqIWg==", "d5c44351-6315-4a8e-9a6a-64b7ebf71ddf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "073f1d8c-d62a-4a78-ad4e-b7824e6a1985", "AQAAAAIAAYagAAAAEBabY3ut/U5P3zpk1/sm78ddjMN+Gtt+OftzLBtqCNaQD8YUfs5WwnwvqqwKRVFvMg==", "3cb88545-cbeb-4fd2-82fc-da2d03edf6a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "248c3d40-a8e8-4a7d-83a1-491ed50e5006", "AQAAAAIAAYagAAAAEKKkirbp2xJKPq/vdIKqODoPmJHKzxZ77B074Tfw9gUZ31ya/WMEVALFozfaQX5h0A==", "4b9ad5d3-6eef-4583-87f1-0906b38febe0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87e9dc3b-1962-420a-9332-a941d377ddfe", "AQAAAAIAAYagAAAAECQnTVhS8R6LYHiiUm9wBEbegcQAdSeBDWJkkJLppHi6UqtFNAz6D6YA7w2ECjAp1A==", "38d9ae5e-6d5e-4185-83f5-ff157f795d7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03fd1672-58bb-4594-85da-4f018cdb0a7f", "AQAAAAIAAYagAAAAEKNJ5Zfsj0LMrkyk6H0hN7b+Auj57vfLAvfo2d3fNe7tykYhwerKMB4b4nWhEYRb1A==", "bede9643-4d7a-4c23-8777-9ce64df25ba4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2b959c9-c840-44da-b4b6-eb41c104d896", "AQAAAAIAAYagAAAAEG6ZnySjVlCgPqKyFj1XUkX4lDf//0EQFX45PS5girdqSF6GM07HwgjkGTgbCd2UVg==", "73f7e278-0866-4a52-be15-cb5d677ffee9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "199395e2-0818-4675-919d-6f5fa9772dcf", "AQAAAAIAAYagAAAAELVkchLYIFsijfqq/W7R31LlyeOa/4M1caXUEZMlCvXfoTh9neb2Jz+fu7ygWv1M8g==", "6b369110-4780-470d-9984-3090822e7477" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8af98769-acd6-40f5-ad1b-ebd4743e5bfd", "AQAAAAIAAYagAAAAEAhagx+7lSxtO2POyVxj+A5nmh4i35OvovuOzGKfqEj5eii0yNxS0HxURgoQrHSwOA==", "1d4fe72f-4a18-4eee-8a60-bd340bce1667" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6951), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6955), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6958), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6674), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6671), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6678), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6677), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3222), new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3273), new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3276), new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3280), new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3283), new DateTime(2023, 5, 31, 19, 24, 27, 636, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4458), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4577), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4581), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4841), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4846), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5856), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5858), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6144), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6146), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6149), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6151), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6135), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6138), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6141), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6411), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6417), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6419), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6422), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5471), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5568), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5117), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5121), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7708), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 5, 31, 19, 24, 28, 455, DateTimeKind.Local).AddTicks(7715) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "RadLabResult",
                newName: "Image2Url");

            migrationBuilder.RenameColumn(
                name: "FileUrl",
                table: "RadLabResult",
                newName: "Image1Url");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8223), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8228), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8231), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8472), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8476), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f413762b-e6ad-465a-b500-02face8c63bf", "AQAAAAIAAYagAAAAEDY2/o9oNTmhxLIEKpjYLrTI1bEiyRjR43vCxP1avw7Gj7j9Qx3RrbZlFsA+4laRLw==", "afb4ce18-91af-49cb-9a98-653d42c2f36a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff2d0613-1b7c-4b64-b14b-66dd015380ab", "AQAAAAIAAYagAAAAEHfYDyuQOzqw1BBnnhmL0SiQynrGB9+uliQvFb5yDhp/ga5MmTB8MwKiZiznovtY6Q==", "0d615f5a-b713-4f12-bc37-1ae83a9bd131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fca9c02a-fde1-4a12-9dbe-b5a9ad9ae1e8", "AQAAAAIAAYagAAAAEOwf4hCzGhZlNJ8xstJfC6CuTfJWXqYNHW5vJlfZdnOO3tv+9x5ZC5he0jFTXZoM0w==", "5bfbf590-8b21-42d6-9bf2-8351b9d07e23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3616b6dd-1052-4e1b-8be1-668539e64f99", "AQAAAAIAAYagAAAAEIszJL1U0+ShOn0aD5dtnK+ow6+ZDTzkYq/hrcnERKSFGn8N6EJ4i0xasZejgpxQdQ==", "ac5f05ad-197c-4bb0-9130-36a76d764928" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe6f7242-6542-4394-a004-f8763919fb86", "AQAAAAIAAYagAAAAEKFL87ynjG7BO4KT7CSJsR1sd8W74/Y4vMRYBg4eVye5xkKSPdEYNvOn/SyAHrLXJg==", "a059a74c-69a5-4c89-ad53-e70a6303b338" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6855214-c6d5-4c72-8e8c-619fc41a84ba", "AQAAAAIAAYagAAAAEO1ubSe0YmfCblS5ghqzUVSRfob9llFNCJUZtT130bGWvuknmlOSTxOh6OX/PAi38A==", "9b9b8050-5549-4080-b589-df98aadf35fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f51b2d9-ad80-43bb-882f-b7cd3663d0eb", "AQAAAAIAAYagAAAAEFEqBZD8L6t4ExlSkZig+Ljrtrh9kV4WfvJEpKxsF4Y1n4cM7DUVBYOCNI8qQv9SaQ==", "68fcb986-a3eb-4971-a4c3-e95f326a7b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39793e9f-35be-4e4d-9254-c849d9944843", "AQAAAAIAAYagAAAAEFqeVmbFwa8obwIJ1vKw88ZLfkGGPOVuBNSzIbDn3s+7qbE7mxY9w6lRGbP/VigFbg==", "1b1e5903-140d-4c7e-95d9-cf10236c1b57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f18db81-09cc-4874-8f31-cd4147de4a18", "AQAAAAIAAYagAAAAEKg4vQUJqmirFbs8TBsfoUqdwczJpDrcgkn54Uh80AJR7F2uQtJ0ZycuBqOgwlzkfA==", "c32ebd00-eba1-4d22-8860-d5b5f068ff9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec3d64f-3491-41c4-9b1d-20ce200cd090", "AQAAAAIAAYagAAAAEGH0ANaDURtwsvibppssi7ZJc0HckMdveBG8syBJxBsbV0DkuIpjGYeX3jwNwrYeRg==", "b5d910eb-6c45-400f-b6d6-486ea763a18a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3d6b084-8c4b-4867-96fa-cedf005746e6", "AQAAAAIAAYagAAAAEE01bXvrqDsV1qy4n3HMdP4tnPRQ7iOo9sG+fyia5TWHM3gSRL1acIrut9ab1Io+xw==", "b64593ef-1ce9-4f52-9dd0-3af756821304" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec7035c2-f62f-4771-80ba-6da962531f44", "AQAAAAIAAYagAAAAEMldYUdsM9l4BUlQcfzLSan4DIozcpsWqHYXJOt0qqgQQpqhElN43lXUmQwtCoUobg==", "68850563-fe32-41e4-9a35-99b16ef912fd" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7719), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7715), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7723), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9015), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9019), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9022), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9026), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 5, 31, 19, 0, 46, 611, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5384), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5493), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5755), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5757), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5761), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6825), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7087), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7099), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7102), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7105), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7107), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7094), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7097), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7375), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7378), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6469), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6481), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6488), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8740), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 5, 31, 19, 0, 47, 397, DateTimeKind.Local).AddTicks(8747) });
        }
    }
}
