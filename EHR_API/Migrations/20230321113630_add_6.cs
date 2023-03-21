using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Admits",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Admits");

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
    }
}
