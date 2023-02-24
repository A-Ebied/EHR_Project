using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.AddColumn<string>(
                name: "AgeGroup",
                table: "PersonalData",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeGroup",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "IsSane",
                table: "PersonalData");

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSane = table.Column<bool>(type: "bit", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678902341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7800ff5-b486-4e03-840d-bae84ba9216e", "AQAAAAIAAYagAAAAEEaF7eCZ1rTM+3Ld61A0l0jkbIP3AkCMzaTnrX/oQpQPhqEKRMX4TE7U9KAe0p+sIQ==", "ccefc028-03b0-46fb-8292-50d9cd4d15b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32f0eef8-9fcc-490f-a30a-9e29fd4be25e", "AQAAAAIAAYagAAAAEGRDODo4tC0AXIvXvIo9pPKgoeA/SZfpsQOyOcSxh45cqwd9Z1tujFDaEuB8E4yWFw==", "a24c5725-7ff6-4c7a-ad0e-31faa5f20db9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678921345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e89614d-3d34-4af7-92fc-5099b85f3f8c", "AQAAAAIAAYagAAAAEASmkRNJGaZvyRSIFvxLoIrLJ4vuTANxyb03t23dNA4vm3jX3OaHUdZQp0nRE2AjVQ==", "72146f97-1ef2-484c-8a2f-a7c3b1c840b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d64d543-19ff-4bad-aadf-2c7658b01ebf", "AQAAAAIAAYagAAAAEFjdeFFq4USTgl/Z4LTonI4HzsuvXoxho8SfJZVEi4rkFl4BQppjXBAcgOxqNxCjfQ==", "8374da3b-f3b0-41b1-833c-e53dcb3eac31" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(420), new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(461), new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(469), new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(503), new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(511), new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2736) });
        }
    }
}
