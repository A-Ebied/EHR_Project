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
            migrationBuilder.DropColumn(
                name: "Note",
                table: "VisitMedications");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34f5212b-45d5-407b-81a5-135798d90c6b", "AQAAAAIAAYagAAAAEKYTcb/sgFZ5rMYlFLWQaCaaPkVpDau9MQrOjvNDCorQEqXBolXWaRJjZ02BzOKRpA==", "efd7c925-722e-4b54-b9fd-b2cc54740795" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ea217e6-2c3d-4270-9890-46e58ed05748", "AQAAAAIAAYagAAAAELD4d53JQu8urWVFi0rP93cBHkaRofJQ2Iez0ECCVI6zKNAco7f2GjCY7E3v8JWIiA==", "6dfe901d-b39d-4a1e-9663-1b79865cd929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb5aef83-c5be-4e6b-9dbe-414650d3194e", "AQAAAAIAAYagAAAAEFlOpMgIjczAmmxNQPIcF/aUzSGOO27T4VmGz/QfnKpRkKHE22L1SDug1BdoKuyh7Q==", "7ecd7033-6c61-4529-ad8f-67f0310b7b88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9a98d66-556a-4c60-bf58-7f846e30a549", "AQAAAAIAAYagAAAAEDG8NSpy3Yxg5AqcBpRIE/rnmQLMYRjLyG/z4PPkcGEPn26v31+DwtMDGs/uQwzu0w==", "35cc6dfe-d5fd-40d3-801b-280fd7007b31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912345",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bfaf880-fa25-44ce-9f1e-4ad5ba1b06f2", "AQAAAAIAAYagAAAAEMwpuFvU4uzoiXVTE6cHkgVkDHnt/MrQUm8BlDyntXCR5p68/8JgWiIEvMioN8rT8g==", "e2d807d9-cd3e-4ce1-a1be-abf8284e8eaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad794c2d-ba35-4e82-8ce4-6d62d9953a08", "AQAAAAIAAYagAAAAEM/0+9BeKdLRyeVIdvdHF0FIC4tQ8z2S6vfhI1YECcAv4zZfSRGzD2oVHkrenWEIqw==", "23e6e3fc-36eb-4441-98f3-a34fa14541b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b55fe0cd-51d2-4ab4-aeb2-75b57734ede6", "AQAAAAIAAYagAAAAEIiJ8qmC5e+zCRxG9qS5jq6qakGtrhzFebNZFyb/kZ7yuVgKaZh94KLcSPA0gv/pcw==", "8d183025-e920-445c-8540-dd081d0d2af9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5553ecda-3fbd-4402-b042-69f6f744c1ad", "AQAAAAIAAYagAAAAEIn2VNNh11H8+Olw9RGfFOfJcNnBdlrFshwn5Bx806RsmZ3yYCff3Lg0Gv1ivlLQUA==", "eb61403b-da4d-4e1b-b2fe-188500fc0de4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e848d712-b1bc-43dc-a0a7-e737ecef7f23", "AQAAAAIAAYagAAAAEHw6YgyZczw1n5b2k3418Hlab4C9XyH10cnCTFK0IudMoSyu1cCFJy6fDyOpJOFt4g==", "fadb87e2-fdef-4b0e-99f1-75272c8d65fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4491b36c-5ebd-4163-8b06-a920105fd77f", "AQAAAAIAAYagAAAAELq8m2hYEXeaKBz3ceC3FCBM2xSA3Z+DwYYMEj9XiOMH0yt+d2t2I36MsqaUKZWDgQ==", "55d2f9fb-5b0d-49e1-84af-06ce43b60d73" });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8675), new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8677), new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8679), new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8682), new DateTime(2023, 3, 7, 22, 23, 35, 332, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 7, 22, 23, 36, 214, DateTimeKind.Local).AddTicks(9732), new DateTime(2023, 3, 7, 22, 23, 36, 214, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 7, 22, 23, 36, 214, DateTimeKind.Local).AddTicks(9749), new DateTime(2023, 3, 7, 22, 23, 36, 214, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 7, 22, 23, 36, 214, DateTimeKind.Local).AddTicks(9752), new DateTime(2023, 3, 7, 22, 23, 36, 214, DateTimeKind.Local).AddTicks(9753) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "VisitMedications",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4073), new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4091), new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4094), new DateTime(2023, 3, 2, 14, 11, 41, 88, DateTimeKind.Local).AddTicks(4095) });
        }
    }
}
