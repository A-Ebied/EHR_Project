using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class g : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(9295), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(9305), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bedbe904-2d8a-4614-ab5c-339a4c961d2f", null, "AQAAAAIAAYagAAAAEPPGzSBTU1LeApD800XDxJkvJ1lzrxbr3gwBU+EDRA31nbDVCQroC1h8jZ+Gdht3ZA==", "b345a7a9-020c-4fca-89f8-8378532077b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dc0bb7a-a154-4cc2-b31f-6d2bca566e63", null, "AQAAAAIAAYagAAAAEE+58qsDggh1mKnOUCH4VWGAalaLl4HdaGxjY4PGF76bLCWt6QhHd4IsvbgAf+niNw==", "f82dada6-98da-484b-9c9e-e8d960c4dd97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48a3e1b7-04dc-4745-9816-34c4afc0e287", null, "AQAAAAIAAYagAAAAELrsrEOCKeUuCmMRYzldn2ZvpVIvHyfk7PpPHCvshkruHQZA3moQZXRrn+1qeDCkVQ==", "349019ff-e477-48db-990c-7e875e2b04c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd48fdb7-fe20-4a59-9600-fe5a8dcd5e5e", null, "AQAAAAIAAYagAAAAEP9aLNGuaG852n65NEfkWWMRBpfPnktckTlcR0mtWPQLV+Bpjf260sieDwIVFIBhag==", "665946d7-d3eb-4a6c-b1dc-ed83a0f49f2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53c5014d-b4e4-44a7-8139-2beb823afc57", null, "AQAAAAIAAYagAAAAELMPavq511mfi4H2LuMQzwmECrE88v9Cftav1EFr8pS7dgSvhAYPNmTEdmfSJs2j2g==", "46e57592-b1d3-473c-9987-9e3c0a94648a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0a26c23-1c0e-47bf-a8b2-ec82245ce27a", null, "AQAAAAIAAYagAAAAEP7eQ8wkQ0/d/TqBqTICgULJ9kNv2Ht21eZ752kTL0cyBqyMHPfk+NzWubHomCgBmQ==", "f053fd9c-d2ec-442b-8e08-0c23991f2e81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021d78f3-3690-42e3-8ad5-3ca0cb8a53a9", null, "AQAAAAIAAYagAAAAEJC3IDEFS9L88LLwYW+E5rUBt/iZANzPofufb4F+R2qr2q46eKjJntI5AtnE2DaASg==", "c4c8e936-fe64-440b-9193-026f6d7a62e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab06e19f-08ce-4b69-99ac-f4224586b6a6", null, "AQAAAAIAAYagAAAAENqZnVaX41GNcl6jYDCrFOu45wohIMX02FfGvg1e4rqjrkXU1EBbaHtRE/qijquA8A==", "26b16a34-6747-40cd-9dd8-ca3bf964509f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7888329-d7fd-48a5-86fb-0126510a7b28", null, "AQAAAAIAAYagAAAAEJtqOjUKoE984t4TYbT8Z++xzo6SboePrO19eA33KEkb7+6KV8iUbUcrfzpqAEJ7rg==", "aad0a51a-9efb-49f1-ab18-7f5777d219a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cfa3be1-a303-4400-9b4b-1766acc20bf7", null, "AQAAAAIAAYagAAAAEB0TG3z2qcmpQMLY6Jw7o9Z7XO06cgBTXrDZ2dYQHmLkeW4ZuFNqwXxmUFwwYC7F6w==", "636c5828-53d2-4c4f-90ac-8373b5b18ca8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58ec0f3b-0165-4c11-8126-9e2927d760c9", null, "AQAAAAIAAYagAAAAELO8UEXxk0rT5cj++ycK37x8gZ3g3YKEw+VCkbLOwlJrJWXloWhhXn/THngb7PejZA==", "2bbd5161-dfbe-428c-a6fb-f2775556ecdc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "ConfirmEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07985f2e-6c11-48a4-bf63-c493e1dba70a", null, "AQAAAAIAAYagAAAAEGlEGUU53XWBeleUkz9dwoJCpu7MXB3K0GqPpCHB74uxKz5kmtij4Wsu3dnui7R9tQ==", "542b0aa5-f4a9-48d6-a155-90a4eadbdcdf" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8262), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8271), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8275), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7759), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7772), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2542), new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2547), new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2551), new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 5, 19, 7, 7, 45, 650, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(3847), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(3932), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(3938), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4391), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4409), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5876), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5891), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6412), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6434), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6439), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6443), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6422), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6427), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6430), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7121), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7135), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7140), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7144), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5399), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5431), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4845), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(9742), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(9751), new DateTime(2023, 5, 19, 7, 7, 47, 118, DateTimeKind.Local).AddTicks(9753) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmEmail",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9409), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9413), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9737), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9742), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca5b01a4-82bb-4ee7-9de6-0c0ede0d71d0", "AQAAAAIAAYagAAAAEBSMTTjorG6PX3M/5KJTTFe3AgbuHTOqbLKpC0qPmCdGfzt0eqhhA0ezMQLz2112gg==", "925a3a22-c38c-4f3f-9bfd-7e51830482b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5cffab5-c79c-4a65-8b0e-4061b964db3f", "AQAAAAIAAYagAAAAEOjNA7VbZcs2tQF2hdOddNCivPyNi1Dpcm1QTrXzhgGAvrb9VWKhalPC47SQTSs6+w==", "33387039-ff02-4792-a988-adcfbd5e9294" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "836272be-2225-4a15-8ed2-8ae56d23a466", "AQAAAAIAAYagAAAAEL7zWQmUYCB51gfsoXEBY2eE7Uf1+w0PRIBOKi+qVcgatu6tCKMOXFEP//7Q5l//xQ==", "ab20da37-9edc-4187-98d4-b64ffe7ba44d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15d175db-d305-42c5-b60c-06b7c87331e6", "AQAAAAIAAYagAAAAEPG6IoGg6PDwtjZCUlzjz3z4lF9a8EQX+OfULtXlTta1eKwrbgNMxR+g0o/BlXiYgw==", "f6e56ffa-e7e5-4a04-b78b-2fab997c27b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bae2510-35ae-4391-a0ed-bc563c813640", "AQAAAAIAAYagAAAAENP6I4SPVPseitZWDU15LQsL18jxsycMRD7b+e/b6BsrUlQpe35eOjKRF7B24JWuqA==", "c1ec677d-5680-4b99-8efe-00c3de8d7aa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "228599f8-c7d6-4383-930b-e31fb69b85d6", "AQAAAAIAAYagAAAAEB0pAYsF/2GQJYxZ8RyFL+AueRYcff8eoKk6nS1muuJahDYvobm5ZvvqQWH3XixWMQ==", "0830fbc3-331b-474d-854c-8c2f364226ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fb1197b-d3cd-4a5b-8152-75f9a80aec0d", "AQAAAAIAAYagAAAAEE1UTk0uj1HbPbHUh4Ud2QH9Q2iD0rFBQkXf5t3inQmlFeYPJqHvDEKTmnJiG4ixig==", "dc292734-b754-4fbd-bd8a-b674f70ce9bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62787c8d-817a-45be-8d5c-b1886143fade", "AQAAAAIAAYagAAAAECwZcaGLe2z0HV+7IgeOVrh5gW1fiWZIiM/wGSYP3zgH3qR+QogsvcUEg8gg/Bfcgw==", "a5cfe7a4-ea4f-4f0f-9442-4ce12c844197" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b602afd-54dc-431a-acb2-46346d2fb86b", "AQAAAAIAAYagAAAAEFidV5AMgOFhzj7mGs8WIJ/ron86GyhcILdKyC4woFSA93T0g7rL2YXS8/m2JbcMlw==", "57e959c3-2582-4dc9-bde9-3a666edc43c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fd99608-263d-47e1-a1a4-07bcf2ab3c1a", "AQAAAAIAAYagAAAAEF1dPQtWba5lvsw3FdA4AZ/4pI3dkyfVdaOE/d//IhZZvymix9XY+Ej0PdNH99BfxA==", "e0a016f6-8f9f-4aba-9a0f-8165edbde9e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2a37b78-c937-4e54-9855-39f91b991e4f", "AQAAAAIAAYagAAAAEKFt0vQBiMk7YaBoIHL37QlWA0TwiynXWHQeSzck/4CF8OGVyY61b0F9cPwSCAFkVg==", "3d0c161b-7a6c-4023-9110-5d98b1147452" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c17ba5b0-0c1b-4c4c-9084-856fade0c7fc", "AQAAAAIAAYagAAAAEJ1HLosa37cM4V1Mi3/38obX4U3/uk7k3N4rAxlPKx/xg1aF5aagdh9uiNA1vKyzmA==", "068bbd7a-00cf-486d-9911-ca034bca0e4b" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9015), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9030), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8664), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8659), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8670), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8668), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1592), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1651), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1656), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1661), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1665), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 4, 15, 15, 18, 17, 496, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5801), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5944), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6289), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6295), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6299), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7504), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7836), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7855), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7862), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7865), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7843), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7847), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7850), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8314), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8320), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8323), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8327), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7126), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7141), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7150), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6639), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 4, 15, 15, 18, 18, 536, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 537, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 4, 15, 15, 18, 18, 537, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 15, 15, 18, 18, 537, DateTimeKind.Local).AddTicks(122), new DateTime(2023, 4, 15, 15, 18, 18, 537, DateTimeKind.Local).AddTicks(123) });
        }
    }
}
