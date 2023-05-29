using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class db3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "SurgeryProgressNotes");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "SurgeryProgressNotes",
                newName: "FileUrl");

            migrationBuilder.CreateTable(
                name: "AdmitProgressNote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalTeamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdmitId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmitProgressNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdmitProgressNote_Admits_AdmitId",
                        column: x => x.AdmitId,
                        principalTable: "Admits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdmitProgressNote_MedicalTeam_MedicalTeamId",
                        column: x => x.MedicalTeamId,
                        principalTable: "MedicalTeam",
                        principalColumn: "Id");
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
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1855), "/files/Medication/fexofenadine.jpg", new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1879), "/files/Medication/NASONEX.jpg", new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1884), "/files/Medication/advance.jpg", new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1888), "/files/Medication/Kerovit.jpg", new DateTime(2023, 5, 29, 10, 5, 35, 548, DateTimeKind.Local).AddTicks(1889) });

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
                name: "IX_AdmitProgressNote_AdmitId",
                table: "AdmitProgressNote",
                column: "AdmitId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmitProgressNote_MedicalTeamId",
                table: "AdmitProgressNote",
                column: "MedicalTeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmitProgressNote");

            migrationBuilder.RenameColumn(
                name: "FileUrl",
                table: "SurgeryProgressNotes",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "SurgeryProgressNotes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7845), "/Medication/fexofenadine.jpg", new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7851), "/Medication/NASONEX.jpg", new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7854), "/Medication/advance.jpg", new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7857), "/Medication/Kerovit.jpg", new DateTime(2023, 5, 25, 23, 27, 10, 740, DateTimeKind.Local).AddTicks(7858) });

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
        }
    }
}
