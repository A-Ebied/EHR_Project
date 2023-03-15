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
            migrationBuilder.DropForeignKey(
                name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                table: "HealthFacilities");

            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_RegistrationDataId",
                table: "HealthFacilities");

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationDataId",
                table: "HealthFacilities",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9475), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9479), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9483), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9800), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bca6c8c8-1d6d-4877-b750-3c2195c38f24", "AQAAAAIAAYagAAAAEJamTpIrYy2rIEiaPOv+nbfkrJx7hH3z2PxInvNK/psXUX+o3FIzF6UlIuuKsdvZgQ==", "01ac03e7-0ad4-4b59-87f6-ec57ce1792a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d58ff934-6256-4035-9826-7e715fccd4b4", "AQAAAAIAAYagAAAAEIz+4Swz6q6nFGsWDUA3R6Laq61OBvLCgEXHu2fjkUxeEObK9hQdksVQ8kIawUM57g==", "adc5baab-743f-4e73-86b1-1d8d9c453322" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "594e93e3-2319-45c9-a743-c52afa9a051e", "AQAAAAIAAYagAAAAEGBWbX/UTs5aLGPuUxa6QLXrXKMXETMUzA0MKfTmQT115oU1M221ohG/3FjJzRbKnw==", "b5d007e6-b70b-4b42-b799-3988d75e096b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82314c3f-ac2a-4e0e-850c-b2647cdc9250", "AQAAAAIAAYagAAAAEPo3e+gBnKv28OPmLBTG5RLShm88TkVilO0J14WScH6BO6horifdwH5+qf0UY2bKjg==", "7b7b77a4-757d-40b1-b5b1-44224ac65888" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fc855c4-2384-4c8f-96fe-93ca52105659", "AQAAAAIAAYagAAAAEFQ8bIK4a3Rg30WtGLrDBXBKs8HNprvY0QQ1hJtie9nyfAAvsKyzQERLZou2mn76Rg==", "d1fb552f-6118-4ac4-9eb7-f45153f3438d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cb318f9-af2e-44f3-8bae-d73bb43171e7", "AQAAAAIAAYagAAAAEKlJ5Fg5uMaduY39jq3VD68a8Dat4dN3fKCwnVZHG/CghkLOhLFZWKhA3i+qtHdPHg==", "77638e09-1839-47e5-9fc7-f62e82498511" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdd4e0a7-c042-419e-9321-d90bcc21318c", "AQAAAAIAAYagAAAAED5AKRCOM9stppbYu4IgZdmQKOEqMfsIN8wHQzoHmylRiYoX7px6QskFhboOR/otRQ==", "ac2b347d-cf40-4662-be3a-940a2ab3a8c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73d443aa-f6a3-4ad8-8152-86530e9a04b0", "AQAAAAIAAYagAAAAEB8A0/DBYxixpp+/tITajRYscFxS9TAXLsEEJeXy7EF+/PswmF2IGNvY+2PoR+CD0w==", "f56f1e46-9dd2-426f-9858-4b14a9f55251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6c11fb3-d08c-43ff-8d99-ea5045543774", "AQAAAAIAAYagAAAAEL6CWpjM1SDFt2COFpfk67/lFh0piEW5AuKOG83nRf7tCaPlTZR1st6ElQcR4H5Ufg==", "c225037b-b2a9-4ba1-8a69-ab7d587693e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c89f2a5e-e80b-408a-97d5-52b7e2cb777f", "AQAAAAIAAYagAAAAEDfgzozur9i4+JoWBtxxx/+vg1FELMJ41QG4yU93CPfneBy+Yd+nHiClsJIurwHfiA==", "0eec9ed1-4707-4686-b657-a31973bbe64b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c75ac7e-1761-4bb1-bfdc-3a471f0c3932", "AQAAAAIAAYagAAAAEGFcDbZlWKELPX8zVz4aIo06ca/SeBn2S5Rawf2wucBlA3OqnNNXuubTAZdHDIH1hw==", "2b63192d-aa33-455b-b5e3-a41c2c1bb079" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52b8bf89-4cd8-476d-8f75-3015e8c3b399", "AQAAAAIAAYagAAAAEHw57gfSJq8vEVtOFpVZ3zuaC6Tt58ex7pUiCnEZ2ZyWry7qNDIPrJ1sfcZEHycREQ==", "9aed4638-860e-4580-bb87-d8cb3d701c5e" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9149), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9152), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9154), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8822), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 3, 16, 1, 38, 56, 126, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6206), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6214), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6217), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6557), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6559), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7703), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7705), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8030), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8042), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8032), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8034), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8036), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8374), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8382), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8386), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7358), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6902), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6905), new DateTime(2023, 3, 16, 1, 38, 57, 170, DateTimeKind.Local).AddTicks(6906) });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                table: "HealthFacilities");

            migrationBuilder.DropIndex(
                name: "IX_HealthFacilities_RegistrationDataId",
                table: "HealthFacilities");

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
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7156), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7161), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7165), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumns: new[] { "AllergyId", "MedicationId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31f5ada6-2ba1-4161-b7dd-f7d5cb7a3419", "AQAAAAIAAYagAAAAEM9/Z6K7ZEpJt9gekNTBouk05WuqDI15BGMD7rBaBUm9OXhq826nmZQH9RTD4QZK7A==", "b0f4b34c-f2b6-4007-b74d-1f90a9ca9469" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59fb8368-02f7-43bd-8465-f4da0ab0868b", "AQAAAAIAAYagAAAAEDh4DBGtwFA8/mHYepdBgBEt4oeSllNlNZoT9VC1y3/+kCnD9aulo/xzgrxx38E0IA==", "9fa13c40-c5d3-41b7-beeb-332cf26e82f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9068ac7-2058-45e2-ba72-72f4ca213498", "AQAAAAIAAYagAAAAEOkHRrwhCLVPEyDPnVCVA7gj88602WG4LzP5C0bazy2Vosnwc6SzytfgrYtOt4UJCA==", "89457e94-db82-47ef-8852-11ac2704406c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "356a872a-e2c6-4cf7-8c0d-68f6ea3147d3", "AQAAAAIAAYagAAAAEBbanvPHs1etHUhI1qG4axJAGhPy1DdaKPIS2Gtky2r5A211j7INX6spQvkX4A0IDg==", "302865eb-0b36-462f-b6a1-f4d3b90ec680" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9776ebb-c760-4496-a4a5-cfd627435850", "AQAAAAIAAYagAAAAEKHz0ylbq+uj10OP3L8iTk+Hd7DtOw4MTu9DBvYilGRUj4OljgQhQh4OjJ7Sp5Dddw==", "5aa2c4a7-abc1-420f-9c4f-76d1f56491ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d7f65f6-1e1a-4e7f-91f7-4ddfcf4686ad", "AQAAAAIAAYagAAAAEBc6qa2JNmzGqbioEo8SHzhjiym6NFYBqNWVRieWZFLjj79kGffokMnr9oNLgnLijg==", "854e7947-4d57-4549-bd96-c085633aea12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47b047e2-0992-400f-ba7a-6c904ea6b5ca", "AQAAAAIAAYagAAAAENdqai3HoSryh7eri4osUiyH9ehT4RQXHmVIUW7U/ypaYN1mkfoKXlnkvVfQXq8v3w==", "100f7248-f014-4ef3-ac62-5bbfd3a4f228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d651bff-6d05-43e8-8292-4633d5467fd5", "AQAAAAIAAYagAAAAED46f6IFonuxRtaiD3reaJfjoXefqg8a+SvqmrC+rsOH2IOLyU4ihg1P56+9W80pcg==", "d2accacd-ec94-450f-a972-93d608141608" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88cb8984-ee2f-48a7-b057-a7745e7875ba", "AQAAAAIAAYagAAAAEFfr2WFVj4KtmKEDofRdeOZTN2pQX+abk4w/cmigRgTiY04Wkaqa7daLb5iMYx0nTg==", "e28b8c46-03c9-47f7-a3df-108660fdf05a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0849cb28-e19e-4d42-9b30-a6a357036569", "AQAAAAIAAYagAAAAECPKbBugmBwEBtlIKOM2wprWxNvh7IEG7XBryrwmvdy+BR+gn4rrritPkA6bxJHZIA==", "01672632-ab97-4a7a-a19e-8b000dd6f11f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce4d9578-7e70-4e45-8ff5-f8b41befe723", "AQAAAAIAAYagAAAAEHLsZkl8GFJRFy36B6weHAbQbZz57+nRw9g4LNEwfMQABjQ2bgEn5AvYZkKGR3IE+Q==", "64b005b8-f1ef-427e-8aab-bba1a1e34632" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fc39d1a-25d5-4ef4-82d4-d2541458fc62", "AQAAAAIAAYagAAAAEAFz0tx7EAsPZhkvvCf07j0giAEQBFeRfphaFmV3wCKakDwUG41EPeVjxwSlvVIFuw==", "991af6cc-18c3-4fa3-a944-bd5d1a2c0496" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6613), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6619), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5780), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5776), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5785), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5784), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5605), new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5611), new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5613), new DateTime(2023, 3, 14, 18, 8, 17, 202, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1420), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1434), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2104), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2109), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4128), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4132), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4135), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4668), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4681), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4683), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4685), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4687), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4678), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5232), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5238), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5241), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5243), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3526), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3547), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3557), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 3, 14, 18, 8, 18, 479, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.AddForeignKey(
                name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                table: "HealthFacilities",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
