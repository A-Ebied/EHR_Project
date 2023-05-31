using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class db5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receives");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "ReceiveBloods");

            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "ReceiveBloods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiveType",
                table: "ReceiveBloods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9571), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9588), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9595), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(260), new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "640219e4-2455-44bb-8a24-4bbe28089ae5", "AQAAAAIAAYagAAAAEP5GvjN71ycrP4q9arkkOm0iVIvZcBbj8l3/jZXA300D/MoqDEdte+WSEI8I6omCww==", "4f35454f-d580-4eb0-b82d-51aa960b0f35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ef47124-70b4-4aa3-928e-5d54ebb8dacb", "AQAAAAIAAYagAAAAEB5YcyTPxWD+LalR4NUXMfWetWHVhD3p11qGQsyfCbHlJEdKxBQofx7vyD2Rq/Z2nA==", "babc8d52-27a9-4f4c-8f07-eebd86042aee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65bef192-bb8e-4348-8847-307ed2069b3e", "AQAAAAIAAYagAAAAEKPhn6MUmu9aD70NzFoNqE39OjctbzcnvnMbpU9Z9SzlxWuzuCv0Z//z3vzpLmkVaw==", "d517902b-5451-442f-ab7a-0a06ce1de609" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66e894ce-f3f9-4f39-a78a-e99bb02ceea6", "AQAAAAIAAYagAAAAELepBHRKawQcFPTjRsr3mFCmnOESv7BZ1xg2ZY+WNWO2Eh0ug/G0SyG2gkYnY8RSIA==", "4fb9ed79-0875-41c8-81d4-f9dee8ab2992" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fb93cfe-50c3-4639-bebc-89ad051d229f", "AQAAAAIAAYagAAAAEFrlaPJ6FdO2QXhdXlyHX+onCKgOrsPC4np5+MVlKfsZWzTbPkW3FyoKut0tFiullg==", "30b6a417-eec4-462d-a63e-cc2bd6a91478" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9112431d-a8f5-4734-bf5d-28624009824e", "AQAAAAIAAYagAAAAEMlpdYgEWvBfZ6vbAlIqZBGhQ5nqK7Oox2ISG++T3/1Qyk5BTrH+tSgN5+I8CrOjsg==", "deba9b65-5770-4ae5-b9d0-9547d2998f64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fc89ee5-0af4-42bd-8cad-ed278165ce0f", "AQAAAAIAAYagAAAAEKWBmK6KyAUectowPeJuTyjXoSb0Ee0rMTzYTAPyuw2MxXReQ07GzfV1o0/Fw1YOAg==", "87c5e0c3-35de-4af9-bd9f-03baa086ac1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9f73f85-160e-4908-9800-8cce113fc9f4", "AQAAAAIAAYagAAAAEOd0DvlOjLLEA2RGGjmii9l79QSiC8vZNVZutKOfBmFEFdQC3kZkuvw65kf626w9lQ==", "ce4c1c35-571a-4f3e-aaee-c7a1b3dbf2cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bb920e7-e70e-4ac1-ab40-27b5b869f837", "AQAAAAIAAYagAAAAEMkfXADWRzsgUZV/t2tjXdPuUtBDSxyi+hlChxUS0aOVPCLbQnX/9y0Z9qN/DMvBGQ==", "ae8442aa-553d-4ae2-a9f3-a488eed0c000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e19db3a4-e559-4808-8aaf-f7a3a013afc8", "AQAAAAIAAYagAAAAEHTWZxxUaqod+cWQmgAOXbjZ0lI5bTFP8Hc+lYJ79klcC2Kyd2y6TE9HLGf3IzQYqg==", "c7e1b3f8-ae07-4c11-9a10-9ccebf06cb25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30cdba6c-18f5-479f-8388-e229e09d1533", "AQAAAAIAAYagAAAAENo2TEhZOL/UxRvAWO3XAPSnSDBrgUxrWkO4RInVm5bm30Zmp85DEn3wNJCgQp3xUw==", "468e77d4-77d2-458c-80ba-7bb7f7fa0599" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9dc03e7-de12-4ce6-85df-73b317836fb7", "AQAAAAIAAYagAAAAEMLdzXn7El75mwyFTkZdFsL24NjErUv7AVL3JkbnLrJLbK23M8vnValbWRu915tYAQ==", "9b265b25-8d44-456a-94cd-5647d80148a8" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8668), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1740), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1745), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1748), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1752), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1756), new DateTime(2023, 5, 31, 18, 1, 4, 236, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2087), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2190), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2843), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5330), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5338), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6071), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6108), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6115), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6123), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6088), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6095), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6102), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6911), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6930), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6937), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6943), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4652), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(3672), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(3687), new DateTime(2023, 5, 31, 18, 1, 5, 659, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(1159), new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(1177), new DateTime(2023, 5, 31, 18, 1, 5, 660, DateTimeKind.Local).AddTicks(1180) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "ReceiveBloods");

            migrationBuilder.DropColumn(
                name: "ReceiveType",
                table: "ReceiveBloods");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "ReceiveBloods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Receives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiveBloodId = table.Column<int>(type: "int", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receives_ReceiveBloods_ReceiveBloodId",
                        column: x => x.ReceiveBloodId,
                        principalTable: "ReceiveBloods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3896), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3903), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3907), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3e077e2-2fdd-4d82-bd52-e50acdd14eee", "AQAAAAIAAYagAAAAEF7xIJW1f2Tq6GdP6iqntkQ+hFeHbpzi1/TbcCoHqCldeS9R1hvwH8YcurA6flks6Q==", "b846876f-57d7-4462-874d-1124d19e22e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11ee36d9-fc23-4166-b1d6-0388ad5f77a9", "AQAAAAIAAYagAAAAEDqwZqiRrBRqPxYWBgyub77RmYaAMyIhBkAmxcUOYQb9YbV4az9w4+oYuClyCmZF6g==", "837f0a7f-d5b3-44e0-aadd-dc93f19f7519" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96730f6d-e7b6-4922-b57c-ccf96e0f16de", "AQAAAAIAAYagAAAAEHzqTZfEhUix3LXebdJtOUWxWJyX77PRmKq9YcKYp5MFkrFv2toGgmwyXM/7rQYSJw==", "65740a60-43ff-4558-99ee-4baf65bd4088" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5559082b-a619-4634-bb07-8073edf3e3bd", "AQAAAAIAAYagAAAAEC6LOzL1z7RFcvStp8AeUJX5OTzVNxWNhUEHWsOJl1zxvuuncWw7K8lWCIREyEaORQ==", "9056497a-96e3-4e2d-b1f1-2abd67004c81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cfdc2dd-72f3-4ec7-a501-fd1442f44ecf", "AQAAAAIAAYagAAAAELJUSgr30eORtfWwGp4DesXrRp+aNH7zHy1/CrnoQjI84EKIdnCCv3wjjQBAVrI4xg==", "e1006706-236e-45b7-b700-c905bed3d5eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1395480d-924f-4380-aae6-0578298f8184", "AQAAAAIAAYagAAAAEKApKgzZF582ozYbDmIOF4f2E7jdORQiVrYaDgvNF34UISlaysBnCC5ly/2Fm/sHNg==", "6235d724-07b8-4bf1-aacb-2b68e4bd726d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6049d7b-02b3-49f4-b571-91babea96612", "AQAAAAIAAYagAAAAENJgQc0FnhNO71RmoVsUwQukjQLdWoQvMeOJ2dnVj26BpskfQ6024J9vdl61LBwdVw==", "17a397e4-3e73-42b3-9e5a-354ce26696d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3bd694d-a40a-471f-aa47-c0c95043ab14", "AQAAAAIAAYagAAAAEJhruLTKUFYkKwVonMgxD2chDy/e3+OtW+S2fsqdn/QFAAEn2zj8vDsc6UJ6iP7SCQ==", "c7cfd6c7-deb2-4770-8f98-c7926729b345" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf12287f-2be9-4cc3-a1fe-51539afefaa7", "AQAAAAIAAYagAAAAEF71WQwFEQF0bl27YWvLlt1YUQdwKN6xHAFKXcL24a/Juaww6/xI+DO5Sgdrwd/05Q==", "dfe648c5-c1f3-426f-b7fa-ca034585a70c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f729c4e4-5066-45c6-8469-807837b0e081", "AQAAAAIAAYagAAAAELRAiLNCBlk+xVnULks//3/W17HVdaINt6sS5Kx65kc9kbr5kDpf1bovbSwvn9Oncg==", "772d5343-363f-4c44-9c85-b6694b96d910" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fe7da0c-345c-4f2c-b37e-862c7f44559c", "AQAAAAIAAYagAAAAEAZt5502bPCTlLj7B9l3hSyDS5zCvCFR1w8HIhz5aREYwrzja/kogkdHeMnKYH1dYQ==", "4306b9b5-5612-4bc8-b9ed-6fa3cc3b6e27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95f1a495-2549-4d05-826e-1eb735d837de", "AQAAAAIAAYagAAAAEHUOJZrlpVIHoAjJqEBHWOXNNePd6kyj8pGa0TwqtcCs744i1OMSwmDZvTSg3IG35g==", "0b4fa333-6972-46a8-88c2-58e94c729d60" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3253), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3264), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(2616), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(2611), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(2621), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6298), new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6314), new DateTime(2023, 5, 29, 10, 5, 34, 648, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(8212), new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(8487), new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(8492), new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9189), new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9193), new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9197), new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(699), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(708), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(712), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1082), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1107), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1112), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1116), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1120), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1090), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1099), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1855), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1879), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1884), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1888), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(135), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(158), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9578), new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9586), new DateTime(2023, 5, 29, 10, 5, 35, 547, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(7192), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(7202), new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.CreateIndex(
                name: "IX_Receives_ReceiveBloodId",
                table: "Receives",
                column: "ReceiveBloodId");
        }
    }
}
