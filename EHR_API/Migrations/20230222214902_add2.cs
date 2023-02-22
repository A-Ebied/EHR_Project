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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678902341",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67fbe4a9-1c18-4e43-957c-8a1c5128b381", "A@GMAIL.COM", "@AHMED123", "AQAAAAIAAYagAAAAEIE3GLUIxYyodIlvjpd1fTGs/IStCiKPouoace7e0uW7fXWYcINHt4USVvMRim33IQ==", "4c4f7dd4-decb-495e-8f4c-78f38de9299c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "079db120-bedf-49ea-8d7a-078238d25e63", "K@GMAIL.COM", "@KAMAL123", "AQAAAAIAAYagAAAAEDYkiUWE438poHYKxhn4l9ZRuyRi6DthJa47H56O399QBvZ2sJdqwCE9VNV80xjm0A==", "6a3f5ca1-bfac-4035-ac8e-dd7886df222b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678921345",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64206651-e54b-497e-aa63-13d6838f2f63", "M@GMAIL.COM", "@MUHAMMAD123", "AQAAAAIAAYagAAAAEBsifW+DouixDzOX8qrMY94FS5AqWXHHD8w939ukpWKzbukV7UM0h/j/5cSdQFsavw==", "9b58cbc7-e41b-4d83-aa6b-d613e5fe643f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92345678912345",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5e22ac2-028b-4a50-b646-61f1a3c191a1", "AL@GMAIL.COM", "@ALI123", "AQAAAAIAAYagAAAAECZ0rL1bGHniGLjAK6XGpqyEAdEkIIT6y5owAGCVt8r4MKtxt9thpF92c54w4PhtBg==", "6ee56618-240f-4130-a5eb-4e48fdc948cf" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3291), new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3303), new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3304), new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3305), new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3306), new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3308), new DateTime(2023, 2, 22, 23, 49, 1, 962, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 49, 2, 209, DateTimeKind.Local).AddTicks(9530), new DateTime(2023, 2, 22, 23, 49, 2, 209, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 49, 2, 209, DateTimeKind.Local).AddTicks(9546), new DateTime(2023, 2, 22, 23, 49, 2, 209, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 49, 2, 209, DateTimeKind.Local).AddTicks(9549), new DateTime(2023, 2, 22, 23, 49, 2, 209, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacilities_RegistrationDataId",
                table: "HealthFacilities",
                column: "RegistrationDataId",
                unique: true,
                filter: "[RegistrationDataId] IS NOT NULL");

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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678902341",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8659b5e-a35c-4eaf-ab49-e24fd11e3fe5", null, null, "AQAAAAIAAYagAAAAEG4l4bQE/3JM6+xJku0tVBOEK4/fyIWw8dpDeWZdR5e6BocyqBBudiOMx65UVcI/+g==", "7f58dba5-c354-4855-9b6b-d373909be64e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "943985e5-f274-4e8d-8366-2c212652d789", null, null, "AQAAAAIAAYagAAAAEFa2nSomuLEWwBkVHYiyqYBEd45oUZmsBgD2GYb2vr5sY1kRh2CMGKkZw8CMkxk+/w==", "3ccac4c4-6511-44fb-9ecb-889d5abe4e0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678921345",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5288dea-6ce7-4574-95bc-7b9d60cccd16", null, null, "AQAAAAIAAYagAAAAEKIDLR4dCEVRi0ErgJis/KjLO20Yo42l9142vnLsRS6PCWW7ve2RPZ0+y+eReN4qtw==", "a6387aa3-96ac-4824-9ad5-258160da70ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92345678912345",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8945ed1a-3189-4257-a948-c5094454d7bb", null, null, "AQAAAAIAAYagAAAAEIMPk0XV8pmm3L54bMXxqIhUKMSoWf8OgS8EAS2Uzs6YxhhG5cgd8ypAYGRxxUoTmg==", "4ffe54d5-d488-4069-8407-77b13bea06f4" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
