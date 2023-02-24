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
            migrationBuilder.DropForeignKey(
                name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                table: "HealthFacilities");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInsurance_InsuranceData_InsuranceDataId",
                table: "UserInsurance");

            migrationBuilder.DropTable(
                name: "InsuranceData");

            migrationBuilder.DropIndex(
                name: "IX_HealthFacilities_RegistrationDataId",
                table: "HealthFacilities");

            migrationBuilder.RenameColumn(
                name: "InsuranceDataId",
                table: "UserInsurance",
                newName: "RegistrationDataId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInsurance_InsuranceDataId",
                table: "UserInsurance",
                newName: "IX_UserInsurance_RegistrationDataId");

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationDataId",
                table: "HealthFacilities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_RegistrationDataId",
                table: "HealthFacilities",
                column: "RegistrationDataId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678902341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f37d68b-49b9-4295-9359-66174414e969", "AQAAAAIAAYagAAAAEN943JIHW+c1IoZZrKoaSSFxucTKlprl2SrvuckRva26nIrsOnhdnJ2BJogFmCD0OQ==", "3dad73e2-99f5-406a-8de6-a75d6fed3788" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d426659e-3f48-4f1d-84ac-1d2d59f84f08", "AQAAAAIAAYagAAAAEMWk7G7dh2C0JBTFiOQfUhZG3W0op2TeoNW+IwsaiS7tdwcCT1dosnriB9k6eQVB5w==", "b8156f0e-78b0-48cf-a5b4-276e92a6d274" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678921345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80b8b408-4577-46cc-a3a2-5106bb8f8dd5", "AQAAAAIAAYagAAAAEC0A5n8UttSucz3KWcVpL55uSHJJ9CO6UcGfuyTMV0XDGl6YnP9FtqzswrRrJrHzjQ==", "f9babf38-1f4a-4f1e-a3e5-584893f11887" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43ff94bf-ed2f-44fa-9bcd-6cf131436f88", "AQAAAAIAAYagAAAAEPt1cPSzSLx64bE2VEgsbIcEqIr2gAfV/AeeoP3SPC8A6WiAsDzZ9YtkfhPAZF3Ssw==", "4798ca0a-2acc-4373-93d7-590df13db1c7" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(4995), new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5013), new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5015), new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5016), new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5018), new DateTime(2023, 2, 24, 13, 51, 53, 42, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3870), new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3889), new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3892), new DateTime(2023, 2, 24, 13, 51, 53, 306, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.AddForeignKey(
                name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                table: "HealthFacilities",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsurance_AspNetUsers_RegistrationDataId",
                table: "UserInsurance",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                table: "HealthFacilities");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInsurance_AspNetUsers_RegistrationDataId",
                table: "UserInsurance");

            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_RegistrationDataId",
                table: "HealthFacilities");

            migrationBuilder.RenameColumn(
                name: "RegistrationDataId",
                table: "UserInsurance",
                newName: "InsuranceDataId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInsurance_RegistrationDataId",
                table: "UserInsurance",
                newName: "IX_UserInsurance_InsuranceDataId");

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationDataId",
                table: "HealthFacilities",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "InsuranceData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasAnotherInsurance = table.Column<bool>(type: "bit", nullable: false),
                    HasGovernmentInsurance = table.Column<bool>(type: "bit", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceData_AspNetUsers_Id",
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

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacilities_RegistrationDataId",
                table: "HealthFacilities",
                column: "RegistrationDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                table: "HealthFacilities",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInsurance_InsuranceData_InsuranceDataId",
                table: "UserInsurance",
                column: "InsuranceDataId",
                principalTable: "InsuranceData",
                principalColumn: "Id");
        }
    }
}
