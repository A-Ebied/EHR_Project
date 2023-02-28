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
            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Governorates",
                newName: "UpdatedAt");

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
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 2, 28, 22, 16, 24, 707, DateTimeKind.Local).AddTicks(2954) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Governorates",
                newName: "UpdateddAt");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d5dc8da-5cdc-487f-88d2-144b7d5cf079", "AQAAAAIAAYagAAAAED9AudwfMdHZrCQtMcuSNdVrxZ8qLSzGFX5zu3ygsBSOeWdfIFl7sf6l6FPrOfOUNQ==", "ed42894b-7c05-4ad8-8ac9-ad6105aa1d6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa520e37-be5c-4c37-aa58-0cbf8c077309", "AQAAAAIAAYagAAAAEF3ThaPIZkgxmvTYKChGDYVNG1jPCUi7t71oxA6SSSZkdRg2tUHAAExLK2sSy49abQ==", "ad332d4f-d75c-4e49-bdca-b3d1fa10059a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2af4bf8d-49fd-40b5-aa4f-52012eabe104", "AQAAAAIAAYagAAAAEHNdC2Qnl3S+qLgZMmUwAn5S5Fa+ar0+2ta9baa0aOwjndo20zj8Mo5h6ZJivSQgNw==", "e1245de3-1e4d-4b6b-8251-5d5ecde73590" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6744f26-6a4a-48f8-9ae1-7fee64df0ae5", "AQAAAAIAAYagAAAAEMS98cosJRW2JzodvI1qqRagQSyXq0yiYpRFhV0BJ/LzPanNSxgL6StDERiu6+Z0Rw==", "504d014d-cfcb-4ff1-b1d4-b12054c507a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dacbe46-ee6e-47db-aae2-86fada1ba628", "AQAAAAIAAYagAAAAEK8yeA0RfYihhn3NezPHPnOOh6RjHrjuXI8gtzJdKhjylHzu4+cDmqrXRo/1TT7Jzw==", "5a9a6aa2-2b93-41b2-9851-ed14f1d8656c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01d31a6a-f3d1-4dae-a243-215b7535b923", "AQAAAAIAAYagAAAAEBImLEP+erHLcdu+pQiuB7+ZgnVXWBvP3iqssSFyqL4cQ3+nXb0P3aHNHklBT48Ctg==", "9c33abf7-4ce1-4e4f-b09e-767c856556c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bf77dd3-39fe-4604-9d0b-dd3ee4e592ee", "AQAAAAIAAYagAAAAELuLTwuEZo1wLSARqf0eH4SCjwcJ2s8QDu2QlqK/xuQbHNuBMu2smQSt2n2SVMrXuw==", "c9a0a29e-e47b-4ddd-90fa-85e7d02aff59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff553f34-58b9-4999-b948-3647db1d0d20", "AQAAAAIAAYagAAAAEOLtPurzGQSRkbdl6QfV5hqPpqdlM7VRoLt+S2iYt9np3/fYfdqRkAlQW7MOsQOO8g==", "792a5186-7b28-4275-8241-4b661d9a9925" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fd3c4aa-abc7-439a-a9ca-1eed6e58af6c", "AQAAAAIAAYagAAAAEDo9TMGwQdMKQCOtus7UsUyQpVdQa7irAGv6rg89bIaW62/8iQZXXNceAoiU1tTkvA==", "02636644-3690-4515-a438-fd31db6916dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf5b07b-d3b7-4b49-bbb4-f607d84b8b3e", "AQAAAAIAAYagAAAAECLXgkVjxYePvALIoga5U3wml0iBZdKXvT0m9g7Oqt6wwEsSkC3EcYuCDieEa8KrUA==", "75e745ec-c117-47bd-b4b2-b698aef03965" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1297), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1309), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1311), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1312), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1314), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1315), new DateTime(2023, 2, 26, 20, 12, 25, 584, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(449), new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(470), new DateTime(2023, 2, 26, 20, 12, 26, 222, DateTimeKind.Local).AddTicks(470) });
        }
    }
}
