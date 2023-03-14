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
                name: "Date",
                table: "BadHabits");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3020770-db49-4721-9506-118fa8d940dc", "AQAAAAIAAYagAAAAEG64w+9ttHBRzEGPtrAShLBftqa9QgOWXiQ2dFHpIVYPade2WJRvIF5B/4pqALrIQg==", "fa2c01ae-e626-49f3-80e5-e70c9e50ba71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a550215-c8db-4425-b5bc-1703658deffb", "AQAAAAIAAYagAAAAEPUlLtyY/WAgkR64yMu9uUHEMPLVQW7D529eGWCe7gUezV9YiO4cQMH49pW1e4GEMA==", "160835c0-5b8a-4a89-b750-f2ada3ef181b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f324b57-b37e-4961-95b2-25e52bbecb58", "AQAAAAIAAYagAAAAEPnZKiu1UrER2pABTqdlRW5Pg3DAGtim4v3RWdsnU+ayQpWXQRHaMJh3CtuDg/NJDQ==", "30483b54-799d-4f3c-8bf3-7f88b0731678" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f00f5c92-8760-43d8-b523-82b027887dc5", "AQAAAAIAAYagAAAAEP1WRYjpsPhBUwy4cn5sDEr2NwhO331yhnlNxQhEqdIRuwRvfm9FP1QBCTO3WaIPxA==", "bf268fd5-3188-4595-9d5c-2d93194ddce9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b57b2b4-ae8a-49cd-a060-542fcf73a39c", "AQAAAAIAAYagAAAAEEJUzINMuidIDj/MwNugdGq7Oz5ZjltYRwdtkBQcJJV0CbFclqR1dr4b+nDzDZgzIw==", "e87faeff-6923-475a-b8e3-9bc215cf96ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c49bd3d5-55d4-421a-9e0b-2b4689889c98", "AQAAAAIAAYagAAAAECeg9ga/kM7SLDdUHtmTFa7zX3bWPH08j4OVwk+9f5uY+8HqZJzIFDBl1Py0F3FXsg==", "ebc55f0d-c6a6-4422-93aa-53c2ab10206b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bebda6ab-31bb-4625-b0b8-739ac2837972", "AQAAAAIAAYagAAAAEJfU3Fx9I4rb5ktz/7oc71fZY0TQaXxZNgDWryWq+YS4DlgEGwqf9LxxBnK8Lia9lw==", "3432acb5-930f-4b07-95cf-171b974153de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27f36ee1-8040-41fd-acd2-c1e8a1401d65", "AQAAAAIAAYagAAAAEDHbzPhbeVTnVhkMd0TbKIWSlHN5P82kbOsZvIU/Ajt8fSj+nGey18GMAalFqWDGYQ==", "8f39b2bb-980d-48cf-8d70-20a511318b78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60324b8b-e946-49db-948f-22d88a58b12c", "AQAAAAIAAYagAAAAEGWz82kLhVHSUkddrP5lgLZ46TPSsLmtoBAEYOz3Hs8BzT2iU4b4ZLPj2p101Oyg1A==", "8f5e73b7-3252-4c5f-a689-f11adf5bbabb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73be71e0-e942-4793-a019-6dc2b201502d", "AQAAAAIAAYagAAAAELhi/lssOlTazmevPAKf3ChrLoGQI+0beuT9xJDeWq8d1KciADgY8Z0DT7upFefrIw==", "78b530da-cdd5-4143-9db5-f246e1f138f0" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(784), new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(799), new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(801), new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(803), new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(805), new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(807), new DateTime(2023, 3, 2, 14, 11, 40, 187, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4073), new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4091), new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4094), new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4095) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "BadHabits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1015e9b9-61d9-4723-9c80-f3352a2f8179", "AQAAAAIAAYagAAAAEF2mIlgudgLjgMXcFcXngIk6pp+1016clTFrK0RuuFZAtX+g3U1F3r1V6wYl/jEsZw==", "b0fda9de-26a3-49e3-8ba1-355d1e65c228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4554d905-fb0a-4b13-9a68-f82af95705ad", "AQAAAAIAAYagAAAAEHGVXZ32d/L8XGXO8pBeHX3Jr+jWDLbEOpKjSJO0KnAl2Mh9t/fHcR715/TWFGis4A==", "3f42e8e9-51f8-445d-a017-4b5ee29ea92d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ae3626f-1ee9-4774-b6ef-96534c0188a7", "AQAAAAIAAYagAAAAEKNAtF9dUhYainBpFxhlK05NehZswE/YRjZmjpNB0Vmvq74FyQuesTjTUSSWcbgiLA==", "361fe720-ca52-4f1a-ad46-570c37c66c77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bd4bff4-5e2f-4bea-bb9d-e5478109f856", "AQAAAAIAAYagAAAAEETuVhiYT0+vs1J6l0GDkzO2QRSGPtHUeNCdc30E/Vh4BcfL0r8BjjNL8N28VppCGQ==", "d615275b-1e77-4426-89dc-49a55cb719f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97e5353a-8b5c-4629-87c8-6a02980d0c5e", "AQAAAAIAAYagAAAAEOySENJ/j0Fn20894yWQ/3FNn8YmYTOAHB3pJCJ95XC3LRU4kOEEwi2ipBFj7tr+xg==", "db537b7c-b55d-4613-aa48-583eb0796e40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2253a90b-f7be-40aa-a465-2585b367a24f", "AQAAAAIAAYagAAAAEOmYbIGEdjZNCV3OCczwaogG1Hj9um2nQsrvJ6JZ3EVjo38Zq5RT5B6U2B5yzj5rJw==", "1b36f55f-4d74-4971-9537-a4a9e5d33d9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb8f3b60-7ace-4f6b-90c5-1f6ab0e5ef81", "AQAAAAIAAYagAAAAEMGY/9M5gQTVj0TRXtq/5hR5HI6p8Y6y3qkwCSrbrN/A/mDga+nC/Ft+DLyYY+h5ZQ==", "dd416d94-7069-4dc3-b113-60b3fdc4095e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee839e1b-fd0d-4216-9711-cf7a0dfc7384", "AQAAAAIAAYagAAAAEIMexUjzPE12UdWYb8buNue3/Xskm0qfE9Sph4CdEPq5ilf8PSdMMRpAeST7qaRqsw==", "e318d30e-09a8-4657-86e1-157bb02970da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee5facb7-e4ba-4849-9fa2-b2641a5b6eab", "AQAAAAIAAYagAAAAEFzAflo9Liwbki04uAvOP+gQBEh5uGi7+YH3K9tua9XyZ9dfTPQLmZ9KofG1BwbcGQ==", "8592843b-e6db-4460-a087-50475617b5fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31f9695f-194b-4460-8f36-0bf22d2963d3", "AQAAAAIAAYagAAAAEDR4rK4G4LeFF+RhHivV9UyTx3T+0rld2koGKM5a8Ol8ti5rmdgpf7leadFxxZ9scA==", "e79dcb32-206e-42c4-b90d-fa10fc88956b" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6192), new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6210), new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6212), new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6215), new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6216), new DateTime(2023, 2, 28, 22, 16, 24, 78, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2954) });
        }
    }
}
