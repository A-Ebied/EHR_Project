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
            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5223), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5832), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8169d9d-9bd7-479b-92c7-664d6dd956e6", "AQAAAAIAAYagAAAAEMLyBZJv66TQfYy0HhXTUdDuVWhV1P7Okb9mKnzo7RIr4/kbZt0o6PM3VP4QOs429Q==", "082df6b0-4c64-4c46-9806-17955645d632" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0c60647-aa4b-435d-877e-61bb6bc0c424", "AQAAAAIAAYagAAAAEL/SmuWRW9KVfhHuutVpw6BZK6hqPPlH6MahUTrrcjHv7MiWMLV+Od+HOpuHT5amxA==", "a7a0b524-e12a-4584-acd2-71ed189d2424" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12b210d2-d36c-4a4d-bdef-9a8723513157", "AQAAAAIAAYagAAAAEBmjH9wvawFTctRmSfnJKfA4Tt4F4LOmvCC95u9wOiUTSRiroQscIY7rIlajoiIQbQ==", "c7758baf-b7c0-4f7d-94fa-b1ffb0600fa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a89648c-a866-4456-89c1-31eb70a723ad", "AQAAAAIAAYagAAAAEG7rTbtdL74FMYvLZDuUysWMMxwGVaNUU7We69NcoN5mIoTJptWdrIA9TmhDbvIaiQ==", "ba7a9920-311c-4246-bda8-a0cffad5656c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4885f49-6a12-4b6d-bb28-019908c29e99", "AQAAAAIAAYagAAAAEDOmtiWBtiOReaRLpwbW1/1mhipQqcpxvKO2OerD0vRvT1Xbc04a4qmahtltQFZFHA==", "97ac2b6d-e3f9-48de-9ff8-700c71fcc6bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faa17e3a-12fd-4b86-bab0-df370aa1983a", "AQAAAAIAAYagAAAAEGkSZ6XYGYLSWU3u1hhu56xlx3KB9j5XT/dCDPLpqGPiGLhW+BYWOxk/CM5z7K7YmA==", "06b7c045-a04b-430f-8480-e01f73f9dd25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b0c3c1f-5f90-4e3f-9686-3d91ac28829e", "AQAAAAIAAYagAAAAEISYkd+m0QhzCHRp+iJxYQbGD065Y4nGNFwRKeomqkSEQXVXwKNcZlmOjfNWPh03hw==", "b1e411d9-b787-4d49-b542-a0797acbb66f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bbe502f-b956-462d-81c3-a63d30b43d7a", "AQAAAAIAAYagAAAAEADD6xKCV12SJUgmARDwNgEABIrfhbuUEG18N+8fTGvkVIZmfPHHnO+0iMqKsF4K6Q==", "0ae15b6c-bea3-4445-9d1e-eee479329e41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84f2f0a4-7ede-4b57-aeb6-3e95e2db7c7a", "AQAAAAIAAYagAAAAELoRGo4fFNDeQCXNcBnJZryUmSGgT+hzjZJFRh5LIhXG8OLBfV/htLlQcn0RyBwMUw==", "c630bb76-045c-45d4-9472-216cd3d6cbac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ba70615-b474-4189-abc6-ff5b7cf4dd3d", "AQAAAAIAAYagAAAAEBTDky2JuCDVDTp59MHyHp44tVO6vTgSjXguE7AqnAo/2kSeAMHOvuQFj70WjM/55g==", "5deb1166-d681-4757-8eb8-175c173fd2db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96ef6274-3f28-4446-8dea-933da972e25f", "AQAAAAIAAYagAAAAEN/KUhJNOfcV2sHnrXIxUyIbWEd126bwslvXrlmZiwq3aKyYMmB0RBHb4cBWLN3kKQ==", "f3b9e93b-6c8f-4c1b-a1ec-c98721165140" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4657), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4673), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4097), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4089), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4107), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4104), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8425), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8493), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8497), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8500), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8503), new DateTime(2023, 6, 4, 16, 36, 58, 970, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9196), new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9464), new DateTime(2023, 6, 4, 16, 37, 0, 33, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(44), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(56), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(62), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(68), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(74), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.InsertData(
                table: "ICDs",
                columns: new[] { "Code", "CreatedAt", "DiagnosisName", "UpdatedAt" },
                values: new object[] { " I10", new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(80), "Essential (primary) hypertension", new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2314), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2929), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2898), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3497), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3522), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3529), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3535), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1675), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1691), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(892), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6397), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6409), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6418), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6426), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6434), new DateTime(2023, 6, 4, 16, 37, 0, 34, DateTimeKind.Local).AddTicks(6437) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: " I10");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6045), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6052), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6478), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c291b57-31c8-4497-a038-6072b9c81137", "AQAAAAIAAYagAAAAEH2Nu/2gHOGO5PgK+M38aAkuRHE5qbHoR47eVsJmfruCXQYeo+9wY+P5G2LI7ggTEw==", "a7ab55bf-7a07-42d3-871a-e9cf0e1a9770" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d23d2ff5-89d5-45ea-989d-6b901b52e4cb", "AQAAAAIAAYagAAAAEINpCo1H4/k3ZeU8c3LO3hrrri6yS0ppKeeM0ioV8POQ9dAQBom6Ds7/w4hv5aZwWA==", "5ba8b154-7307-4433-8232-c8a2f6a8b33b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0b3069e-c5b7-4124-a88d-4002516210f1", "AQAAAAIAAYagAAAAEKBtT33FfZCgd0/begGMJd2p8l3Rfp/HoY5COBAiokZvi5e910WjXddbV+I2jkrKug==", "00128e3e-d50c-4bcc-9533-7a9b6fdd705e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a01e0ca-9c4b-42a2-93ff-d71cf3a49693", "AQAAAAIAAYagAAAAEB7gmTiXV9fxuXj2/u2E8mvQ6xJv+X5HFDGk9mn+bVrh8Yshf+pwxv06Mj6qHJtTaA==", "dff4c33f-cae9-4343-a540-b6713d6d4708" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88044977-449c-4d75-8de6-b13746568dea", "AQAAAAIAAYagAAAAEG1lU/Y3SHNAW6eZ9SH8F6VcVtbavc0BkucLGtYdsFl374yADD+efUpNx7O9EmGChw==", "3c428ad5-f449-4767-9865-733c9522072e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "459ef04b-8de6-4a76-8f7a-2171b4659f9b", "AQAAAAIAAYagAAAAEMYRWydwUt02vyKLND3oIos+Q9RRE5bc1VEPPiMQqBJkUiTTsJ5+gBKzN3cUe2zU6g==", "5a5383ee-6972-4f17-b46b-2f4aff2f7947" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65748285-bd44-4f34-95d8-68c5ec6b51c0", "AQAAAAIAAYagAAAAEGd0LLfvOiTp+RbYblK2TYNr0sRWuVtS8Vq4GGENCD0TgngN3jky7xdr+NUoMfv3Wg==", "cb535913-0f88-45c8-9f87-e4a59a6dc46f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6505e3c-cb34-4658-bc0e-98603a7b3e5a", "AQAAAAIAAYagAAAAEDoBhypo0Fv454B3grCIWSTfBsd+vVi7ts39jEubolSKVL5er6h9/0//SfThClD/Sw==", "468599b5-35ff-480d-b55f-c4cd65703d2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d199e11-62a2-4b56-bad2-1a1f902b9f4b", "AQAAAAIAAYagAAAAEC60k4G+pNopH9f9DZARhYuueMg4b3z4zdSDROGtK+2PLKKPy1XAFB+kbRLBvpXsaQ==", "23574571-19de-4499-8dee-c7d564308084" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e31363e-a108-46ec-8b2b-185de9f4c8cc", "AQAAAAIAAYagAAAAEPzoHgrgP/Yp/VZMNVjrZVfQDMG0ZLSJuZww1PJ/x9DofJIR/iQ/1QNgEkQOQ9nz+g==", "3396e4a0-1757-4a2b-90f8-106752d8dcb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb9795b2-66ed-4ac7-97ba-105f6fc196b3", "AQAAAAIAAYagAAAAENigmlHWsGwDooZMTqnBzJFAoTRZK+8Q9tdyzHScFEyx6xDBoZ+IBhkK6IvS8DsRHg==", "2ffd9b5b-e1bd-4206-bac4-4e692d20ec2b" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5558), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5561), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5106), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8568), new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8735), new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8745), new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 6, 4, 16, 27, 39, 717, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1269), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1392), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1397), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1823), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1830), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3349), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3362), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3439), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3837), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3855), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3859), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3863), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3845), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3848), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3852), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4592), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(2255), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6868), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6876), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6889), new DateTime(2023, 6, 4, 16, 27, 41, 64, DateTimeKind.Local).AddTicks(6968) });
        }
    }
}
