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
            migrationBuilder.DropIndex(
                name: "IX_HealthFacilities_RegistrationDataId",
                table: "HealthFacilities");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678902341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc60b4c2-57cc-4528-b173-18d89fa2d8e6", "AQAAAAIAAYagAAAAEOIL7v4ENFvqVPB2sdqoonZJY4QRzjEbCh6uXnMjK9FbEuReEkxlw7q0cMnkry7hOA==", "38fdc788-33aa-4007-b712-10695e2b0aa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a39ca5e-affa-427a-ab9e-01b3b85a75d5", "AQAAAAIAAYagAAAAEBDbgelwajAZgNpPUFaZFDZ8sa9D9XAAew6zdMRB182laeXpb+6sO21p2TaEItfW5A==", "20355420-0601-47f3-85e0-57a4c44d06da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678921345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "415e50e5-2920-4ede-a3b1-ad3e7c75233f", "AQAAAAIAAYagAAAAEBeApjx1H15ka903LEkIwXqZ+AHR53wUay7UWstvjuNrkb9ReyiOjsVxud/hviWUVg==", "c5a05c77-25a1-427a-86d7-ce31416ae572" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e8e4107-956b-4cd1-96fc-2df8149eb89b", "AQAAAAIAAYagAAAAEN0Cw0KvLwgcsbXUkyRMWGb+VMLg2GVupqoO/5irAiKk45RBg7pIUQEdeRrj9awQ1A==", "6cd5e3e1-c683-41a4-bf11-de3460bb4995" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4424), new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4431), new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 2, 22, 23, 50, 22, 241, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 50, 22, 502, DateTimeKind.Local).AddTicks(8621), new DateTime(2023, 2, 22, 23, 50, 22, 502, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 50, 22, 502, DateTimeKind.Local).AddTicks(8636), new DateTime(2023, 2, 22, 23, 50, 22, 502, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 22, 23, 50, 22, 502, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 2, 22, 23, 50, 22, 502, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacilities_RegistrationDataId",
                table: "HealthFacilities",
                column: "RegistrationDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HealthFacilities_RegistrationDataId",
                table: "HealthFacilities");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678902341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67fbe4a9-1c18-4e43-957c-8a1c5128b381", "AQAAAAIAAYagAAAAEIE3GLUIxYyodIlvjpd1fTGs/IStCiKPouoace7e0uW7fXWYcINHt4USVvMRim33IQ==", "4c4f7dd4-decb-495e-8f4c-78f38de9299c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "079db120-bedf-49ea-8d7a-078238d25e63", "AQAAAAIAAYagAAAAEDYkiUWE438poHYKxhn4l9ZRuyRi6DthJa47H56O399QBvZ2sJdqwCE9VNV80xjm0A==", "6a3f5ca1-bfac-4035-ac8e-dd7886df222b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678921345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64206651-e54b-497e-aa63-13d6838f2f63", "AQAAAAIAAYagAAAAEBsifW+DouixDzOX8qrMY94FS5AqWXHHD8w939ukpWKzbukV7UM0h/j/5cSdQFsavw==", "9b58cbc7-e41b-4d83-aa6b-d613e5fe643f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5e22ac2-028b-4a50-b646-61f1a3c191a1", "AQAAAAIAAYagAAAAECZ0rL1bGHniGLjAK6XGpqyEAdEkIIT6y5owAGCVt8r4MKtxt9thpF92c54w4PhtBg==", "6ee56618-240f-4130-a5eb-4e48fdc948cf" });

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
        }
    }
}
