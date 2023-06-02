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
            migrationBuilder.AddColumn<string>(
                name: "MedicalTeamId",
                table: "ReceiveBloods",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicalTeamId",
                table: "RadLabResult",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1734), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1743), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1750), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(2648), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f10885f-5f46-4b9f-8d31-8d7b939baa6b", "AQAAAAIAAYagAAAAEPr+4d+KkFtDgKdBfi88gnvqC2bHO4iU5G4NwpL3EeGZDrPem8YjgJPZzF5EeDaOZg==", "4b92969d-e0a2-456c-bec6-d85570fee1fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "362daa26-8655-41ba-a132-2956804cf7d9", "AQAAAAIAAYagAAAAEBXlMrZogv4BFV6Gax4tu5eyMq5uAGCWEhF6Rdseq0eQgfTkal+Vn4h0c9B90ec5Dg==", "bc7cd52f-e5d0-4a0d-b373-0a57a009afcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd0728d8-8407-44f2-bc91-dfc58e163276", "AQAAAAIAAYagAAAAENINGdlYWv0lDQ3MjDZBJrueHR/gOmp6Utk3oCatZ/URTJbZjijwgTbFPlda8REaBw==", "0f92a40e-9599-4eb1-977b-81a2eae30760" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9530ae2-7434-4dc9-a187-a7b22b6aaff4", "AQAAAAIAAYagAAAAEObTXVd9kHL/ShT2ikPwwbb4ZsHu01Eq8iC1XmWjh2g0FgUU3AtpwaoxZz+e5sm+WA==", "803f243c-5c34-45c3-a04a-87221125e824" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08cfe263-4672-4fdc-8ddd-a63da79072f1", "AQAAAAIAAYagAAAAEM+1jN1mTrdXuyjA4VMtFpdXvHBPAvbWNUD8X3CQ1fmI9yGLysuf7szqAm3k3XRDaQ==", "8e47d8f6-ba1d-4c28-bee6-8c561a43679d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3fea843-a43b-49c3-bb43-8109cba05fed", "AQAAAAIAAYagAAAAEPaff1zON+XI6isH8UUGh7PkKNuziAktYLRCfksfkzYLaEw2yhYAb/GB6Nzs8ECTTg==", "f76d22cd-b97c-4794-b350-0bc13311d6f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "587a9f64-06b1-40a6-b723-1063468cff26", "AQAAAAIAAYagAAAAEGlKLRXyYBz8EcQoBMNNn0celunK65nJh8u9Gnc8XWoHCJPPL0y+q5AoMpufoPPlMA==", "bcbf5e10-d221-48af-b948-889b666de0f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1f13a31-bd31-4393-97ae-83ce5448a951", "AQAAAAIAAYagAAAAEBjJ3KXQEH1ZV8mo7sorR1lsIeMGvPP+sPAf/ITe7gxjVFqz+nlogBdlWIax1PB0+A==", "3921929e-6993-4f58-8ec9-88e6e997d3f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff6d935d-9419-4eb5-a26a-05c2aa5a558f", "AQAAAAIAAYagAAAAEOZTDOWBWRAZ4eVIANKRmHSwIKI71PoU6eX0d+Yjj9QUUPKiWyWFZ14oAGJ24ITJsg==", "63ea4267-2758-416e-8fb1-a6912a0a2d23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24dfed95-da30-476a-aa10-e76d6018e4f8", "AQAAAAIAAYagAAAAELLcFa9hNG3L3blV+qUS8pi6gfaL5N+JY0acRplxJn8dvokPUym39wyrAj6TBmke9w==", "4a301762-27c0-4d62-b917-68078f79e9f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cd483f4-1d29-4c2f-b943-61bd9b6f98b4", "AQAAAAIAAYagAAAAEBEeBJZnGml8l+RRpfdRm1+LXQ/ND7BnzACZmv9wHjwS/rrcWOcPL3nyNeBK+Ikfrg==", "d6e521bc-e063-4479-854c-8ce871d34036" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1201), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1209), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1214), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(659), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(653), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(667), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(664), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4385), new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4457), new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4465), new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4468), new DateTime(2023, 6, 2, 17, 25, 1, 699, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(6661), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7212), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7221), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7225), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7230), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8923), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9500), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9524), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9529), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9534), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9510), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9515), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9520), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(125), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(135), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(140), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(145), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8326), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8347), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7738), new DateTime(2023, 6, 2, 17, 25, 2, 786, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(3152), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(3161), new DateTime(2023, 6, 2, 17, 25, 2, 787, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveBloods_MedicalTeamId",
                table: "ReceiveBloods",
                column: "MedicalTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_RadLabResult_MedicalTeamId",
                table: "RadLabResult",
                column: "MedicalTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_RadLabResult_MedicalTeam_MedicalTeamId",
                table: "RadLabResult",
                column: "MedicalTeamId",
                principalTable: "MedicalTeam",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiveBloods_MedicalTeam_MedicalTeamId",
                table: "ReceiveBloods",
                column: "MedicalTeamId",
                principalTable: "MedicalTeam",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RadLabResult_MedicalTeam_MedicalTeamId",
                table: "RadLabResult");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiveBloods_MedicalTeam_MedicalTeamId",
                table: "ReceiveBloods");

            migrationBuilder.DropIndex(
                name: "IX_ReceiveBloods_MedicalTeamId",
                table: "ReceiveBloods");

            migrationBuilder.DropIndex(
                name: "IX_RadLabResult_MedicalTeamId",
                table: "RadLabResult");

            migrationBuilder.DropColumn(
                name: "MedicalTeamId",
                table: "ReceiveBloods");

            migrationBuilder.DropColumn(
                name: "MedicalTeamId",
                table: "RadLabResult");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8002), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d585a3a-419e-4807-9286-425b4bf8611c", "AQAAAAIAAYagAAAAEBUZwbdVK03aqOwC9mhtpy5UdAL0jUNByAX+hbvkhJGbm2A1ixPsr44Pz+NvJL58pw==", "4160cdb7-1d5c-4bca-9e7f-9799dde15e36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f6fe70f-d0a8-4b20-a82a-fdccaa7b59ce", "AQAAAAIAAYagAAAAEO1twOrK8sDdo+QkMWEGPxf4NV6+guxRnEzha8Ef27ayZ6N4g+yI4YMt8lWvtRFsNA==", "2e3f036f-7a52-4ad8-b13f-6f2fad762510" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d6414df-4766-4af3-9bba-aed1ad8fae57", "AQAAAAIAAYagAAAAEHDKEP1aaZHGaLEjcx92E+oYOKjQlNGtzDIYpUsu/3H/3j/9p6/6L8MwVO7HnZObKw==", "36811252-6a99-4a9e-9445-8dbd7d736970" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc7b87d0-1dfa-4936-928d-ad632b34e7a8", "AQAAAAIAAYagAAAAEGTbdMwDfw9Jp59STw98Q+cgzQmz8Xh7XgXFhCS9iqb4418ZAqocdiCDDg0bmKpfjw==", "7f0def4d-be4a-4c5f-9749-6f2333e6d1eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11bf23dd-bfb5-45e4-bc82-ea2f832815ec", "AQAAAAIAAYagAAAAEHKPeTugPi3EjDnJFKXtzfOqaRWKIHCqb44NGBsQGK7hn7tY9pz5vuXzeNtG08qtSw==", "ee38f5b9-5153-4e45-8d10-b092bcbf6177" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd43c9e4-78a5-4e98-b603-98932750ceb6", "AQAAAAIAAYagAAAAED6s1mxm9P1VQM1Q387/OvSGMiTlUulnWYt0WZFhPK8OprV92l+ImASmx6SMEsLMjg==", "14fd9b03-0d8d-414c-822b-9f2384039706" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1b4f3f5-6c97-435e-9b99-87843e323411", "AQAAAAIAAYagAAAAENM7NQAm2LG3ovA9JZCL/Cj5tzlBZnz7z5tfEbKvqb4erc1Q4Y7un+7/m/Vd8ZknNA==", "008f0425-caf5-44a7-84f6-1c7abaa3611b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "815a3826-85e5-4cf7-8f1c-a88f7236d074", "AQAAAAIAAYagAAAAEBG5a0kurN+XHns/4j4PrJTs6RTkLqK2FoT+fugbXY9AkXpViu/DzKu0T6RfDtlkww==", "b4311db6-65f9-439a-9054-4ec2d583b3fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fdcef71-daf7-4f33-ae53-fa3a7e1a3c53", "AQAAAAIAAYagAAAAEPgJutsh7jsHgqblTeokvDaC52DIxCj2lBuoKq74rsUViVA4EoiFoOLCPb/sFhpG9g==", "96bfe5b2-a9d1-43fc-897f-92d78be537e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4f31e05-6cbe-4316-83cd-99a83a041ff3", "AQAAAAIAAYagAAAAENXdPLyMsik6g3M1/9HbzQRR16BRD3QMfGx6wf2i8xxT8rY56pvp/1Co2HegUA4KkA==", "9c563f45-02e0-4739-96e3-2e135bf93543" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1a38a09-46de-458c-9236-c11277466360", "AQAAAAIAAYagAAAAEC3rj1nrGfEgg6nqjUp6a+QPzzq/HhOJIINzSxS60xH1ITcbJbQHpwLsvDqdt/37Aw==", "fc1e2d41-1d40-4ea0-94e0-2cb02b222922" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7493), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7497), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7240), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7237), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7244), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7243), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2905), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 6, 2, 6, 53, 49, 887, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4840), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4965), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4968), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5255), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5257), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6307), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6315), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6714), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6718), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6622), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6980), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6984), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6987), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6989), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5505), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8247), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8252), new DateTime(2023, 6, 2, 6, 53, 50, 640, DateTimeKind.Local).AddTicks(8253) });
        }
    }
}
