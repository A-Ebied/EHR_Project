using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSane",
                table: "PersonalData");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678902341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "654d51ff-ddd6-46a3-9783-f464d807899c", "AQAAAAIAAYagAAAAEB8G1lFXgRjXtI7kAJMYfzSy30ycJegvP3oi0t6tUgk2lsvIPfo8KUZAH3x/DNJF1w==", "4686093c-c476-4a11-af35-b0bf8a5484bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f78a47ac-7fdc-42c1-aa24-6ed83e1816e0", "AQAAAAIAAYagAAAAED9/pAEdBfzU5tUdZv6pAImUhggZ2qWHJtxTUdO2FDeExyVPYCSc4RTZStdH2mviog==", "64e76fcb-ac05-4af2-8e93-8deee1794888" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678921345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45eb8eb3-13c4-4d65-9345-d6fb733c46e0", "AQAAAAIAAYagAAAAECLU5sBhOqFbVV1cX/QALm3u3376RV/c+6kP05Uw9jJo4m4g5vSXlMzIQ5s2etpFZQ==", "ba83c67d-dbb2-4eb3-aa7c-cbe8291903e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c4d2713-17c1-48ba-ab8e-05d7fbda8d5e", "AQAAAAIAAYagAAAAEMu08lhxfu1SgtcAev1VQ/hsICmjMfU/Va0NQd2iL5CxuDJjpAN5gftcvw90knDWBw==", "a326a3c0-9c8c-43ca-b690-94d3d3db0583" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7290), new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7311), new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7314), new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7316), new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7318), new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7320), new DateTime(2023, 2, 24, 11, 8, 48, 816, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8984), new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8989), new DateTime(2023, 2, 24, 11, 8, 49, 275, DateTimeKind.Local).AddTicks(8990) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSane",
                table: "PersonalData",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678902341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "139bb6c2-4443-40b8-b0e3-d36cb2ccdee6", "AQAAAAIAAYagAAAAEBOIx1BDjQEmeHH83BDrsLEy1K90Kv+EpIWqKBwioIEDSkluYVdu6T+nN0kX8uMSIQ==", "e3921f8f-8e1d-42d0-962a-096466c1cbad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23f9c4cc-1c0f-453d-8bac-3497fe7497c5", "AQAAAAIAAYagAAAAEKqLEiv+NAjJAIlPB/GzJlVLfXfuG6gsP6VST//22QXLbVDPAmOHv+apVcu6AFbq1Q==", "88d735e4-ef29-40b5-b059-50e0f60454ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678921345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dee17516-13eb-42ae-836d-a69f735d79c5", "AQAAAAIAAYagAAAAENWTR0/Rw+uXYeF281I88AdcaB9cVzBLgVG3MmUlk2a0gI9ywKJsolMvke+1n8+Wqg==", "194679fc-5917-4ff1-b7c5-2c764fbace95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2b3608-3bb6-43be-a3fc-82f305acc05c", "AQAAAAIAAYagAAAAEMWMzMU3ogA5jStzFHjzw2xOrnQ8tF+UCtim3eHVX5ilN7t3EZfUyGWkHOnjs9Bnnw==", "3f533c9f-dcf1-41dc-81f3-3960734a99c8" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4489), new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4506), new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4508), new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4510), new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4512), new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4515), new DateTime(2023, 2, 24, 10, 40, 14, 830, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 10, 40, 15, 182, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 2, 24, 10, 40, 15, 182, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 10, 40, 15, 182, DateTimeKind.Local).AddTicks(2553), new DateTime(2023, 2, 24, 10, 40, 15, 182, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 10, 40, 15, 182, DateTimeKind.Local).AddTicks(2556), new DateTime(2023, 2, 24, 10, 40, 15, 182, DateTimeKind.Local).AddTicks(2557) });
        }
    }
}
