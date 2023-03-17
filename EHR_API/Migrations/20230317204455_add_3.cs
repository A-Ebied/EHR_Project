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
            migrationBuilder.AddColumn<string>(
                name: "RegistrationDataId",
                table: "Admits",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7471), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7475), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7479), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7840), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7843), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "140c3780-17a9-42ef-a056-2f941c9fe154", "AQAAAAIAAYagAAAAECTq8apdSC0NRFBCcZYpuaDk7VlA46U+hqCjgXpSc1yvFniRCZ26PF7aokgtA2pQlQ==", "707d984f-d205-4db4-8984-89013b2fdf49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c47afc97-70cf-475b-bea0-26d60a21a660", "AQAAAAIAAYagAAAAECQ5oZp/4lgGAPGcZR3dHrjh1MWUGoy992PsaGnNn3S2iZkHZZl9E1MoH53ugcX2Lg==", "5dddb71b-0da7-472e-b8ec-9e8ca4bfd94b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b7610d8-c692-447e-83c7-7af6fe55ff36", "AQAAAAIAAYagAAAAEMwkOiqSkjXs6fjqBsFOqnmdKcwUfLsO5P2yhKPpAN3uZCQURKpl9pBwYGq5P3qACQ==", "9f79eb6b-172e-43fd-9386-368a2bfe5de0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d8f2376-c57d-4d32-bc38-6675f9eb1482", "AQAAAAIAAYagAAAAEEQlPO6T85ML49E9yr04mW8+9kyqN358796cuWjqpjPCxyLjSxW6lXtw/QIeISxYdw==", "035188d3-b3e0-449b-99a7-ff9c76376931" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f21eec4-7c39-4af1-a4f9-673c3220646d", "AQAAAAIAAYagAAAAECVOwfB5oVi+0wyA0mrlP3Z9QI9RWA+b9zcInS49NErKmnqpc/4R8JIU+fWtugqn+w==", "1117d1af-c3c1-4e22-8f89-c39f81373ac8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f9b1927-5dee-4f23-9a07-b2f61818af03", "AQAAAAIAAYagAAAAEKawM10Ys9P9I6m/M0bMbf0Bl5lMG5pdA/3w71PBlDLeXD5EJCxywhrSQ4UdaHTs3A==", "2388ba72-98b4-4190-b533-ce2f0f52bf42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36703c7e-6c33-4a7c-a0de-f925de09da60", "AQAAAAIAAYagAAAAEAE2Xr897en8aQNeydnQIdqbrIgzwpxJP2Hu0id9YvRFfXtym92i6zsSgXGXraywDg==", "b558589b-aca1-44df-ba99-1cba5ac68302" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b57be39a-51c2-4179-a1b7-f2f4999300d3", "AQAAAAIAAYagAAAAEHyA1otph4Dgxez919PVOu1bt/lFI0FgYylnePz2ltlKdN2Rem6D62yIbHnhDYFJNw==", "a1593995-b06d-4005-a339-fa994c8fad0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f6c84c-2ff2-44a3-af26-e4829e90a629", "AQAAAAIAAYagAAAAEEDBTp69QQXXlgi1QTA6HKUqPntoeA8N3x0bzn8H3YAaTAaEs80ZQx4ei10rDEWcgg==", "e231e44f-83e5-47f2-9d83-358e2cb91af4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c65f4be-6eea-4b15-ae78-bb55105f7db9", "AQAAAAIAAYagAAAAEDUe6/Wyk/+gRZBLjHG33yXSVkFiDZSwT7DyQ7C7XY9k94+66RS+nUj/oFsf9qTtXA==", "d7220365-401e-4ad8-b5ce-37e5d0999264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89a4fce1-c292-493f-a8ed-92bb11e00848", "AQAAAAIAAYagAAAAEMEz6Xx7e6hz7LbcoFujgAf89ds7uRWYacQ7PTd0ANqhg0PEBmvzkfX5RZ/V37cO8A==", "4afc2295-63ec-48b3-8a7a-b9fb5570e216" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce4d411a-ff67-48e2-8aa1-e875dda8a831", "AQAAAAIAAYagAAAAENUcp3DlHevlpYFjylR0xEjrFJeZsLj1nwQVXqkLqkzjR3bPP1RiDeGv6uH2KqF85w==", "01dc261d-9227-49d9-a918-9c62259f4c74" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6909), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6913), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6915), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6585), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6590), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6589), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1740), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1747), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1749), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1750), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1752), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1754), new DateTime(2023, 3, 17, 22, 44, 53, 425, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3918), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3926), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3929), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4274), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5869), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5881), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6222), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6226), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5143), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4613), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(8180), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(8184), new DateTime(2023, 3, 17, 22, 44, 54, 486, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.CreateIndex(
                name: "IX_Admits_RegistrationDataId",
                table: "Admits",
                column: "RegistrationDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admits_AspNetUsers_RegistrationDataId",
                table: "Admits",
                column: "RegistrationDataId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admits_AspNetUsers_RegistrationDataId",
                table: "Admits");

            migrationBuilder.DropIndex(
                name: "IX_Admits_RegistrationDataId",
                table: "Admits");

            migrationBuilder.DropColumn(
                name: "RegistrationDataId",
                table: "Admits");

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3417), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d15c9f44-b075-428b-b142-58b16cde0a09", "AQAAAAIAAYagAAAAEBmeo9T5ObXQ7ziEmDRwKgS11ptecjKmPw9wcrHlhNpZOywt3J7SRls1nat46Wxzhw==", "7edcd8f4-77ec-4b6b-a670-c0e6d848ea39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7ff2f25-000a-43ec-a2ce-8329ecf8a966", "AQAAAAIAAYagAAAAEMwaKeOvZ+PcB3I/HwsbUlZJsLAqx2zjd+kH/iUg//ht+9iRjieSA8/0sdU4PZriQg==", "c41349f2-48da-4000-906c-d2f207a1dfe8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe96c0f5-f3ec-465f-bb4e-af91074c4324", "AQAAAAIAAYagAAAAEAa4NQYXWvqz2dH0T+ml2Y+qcSZIOyjFgaXM27Tr17m2p+JpI8JGfY4yFbkC2tCzvg==", "5d789fa2-c180-41fc-a008-b677d1c22167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aea226f0-3906-4ea5-aff7-b06d3c1dc752", "AQAAAAIAAYagAAAAEDOmMoE1A5MVU9ursYTk4rWlGKUCfl2yj5BctOfqoHYgll3llMu6yeQuzmuiWED5+g==", "8683016c-6d76-41f7-95e4-c2310516158e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ceda4dd-537a-4d41-97bc-34fb36fb8211", "AQAAAAIAAYagAAAAEBvASfj+CI2kL7osHQLylToMa48rxW0L0EwP/4uJEgH75lsVVc37/ZFJaH6yICQKNw==", "fd9e1bb8-e6ef-4fff-a71f-24c395bbb5b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd9b89d1-126b-48a0-bac6-23daec1e4fdf", "AQAAAAIAAYagAAAAEHm9Ly/CW7F5DMZ5zcUOtJWLwyRrk9Yctp9SdEDbH15uiyHKNxduq/QrqxFHtJeqyQ==", "98598c8c-9fb8-4955-ac6a-2fcdc77ec027" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c195b955-b01e-4997-a02a-06a8bcae7a00", "AQAAAAIAAYagAAAAEPM+/SDH1XDVYq5wN2DmnGQkkJ4BKJB8nAZ1aVIURNnnqd5Ea1CL3gxBSWYpU1EPqQ==", "f5c1cb3b-e7c1-46be-942f-a8bf4b7b1611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fce4ece-6553-4b2e-8efa-efb5575376aa", "AQAAAAIAAYagAAAAEPiyN0PAgKNy9XU2uLTGMTkjr8Cv9njCZid+jpAAOZ9ZQZp4SCevLI9AY/LzM+4zbA==", "bf7f6b84-b55b-490a-83a6-841d51530d2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e7175b6-f19a-4cfb-afc0-ff52c23569f6", "AQAAAAIAAYagAAAAEODMzcxEPM3FurPSn3XvURug0PBCi5ZznhZL1g3quZBa8DyqhHYYRnRFHvZbaHS80w==", "a4bd0e60-ca2a-494c-a6b5-be4ac408100c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f6afc50-f949-41be-8e36-b90181e14a01", "AQAAAAIAAYagAAAAEA8nbZ3N3qGQEHaBpo51MO6jKzKpSZ5BukeF3XmQw1/mei74UqPdnteBmSdCjSW7nQ==", "1386f0a8-3c55-44c8-8266-5609b4129ef2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8104b6f-df9d-4123-9210-681be9083588", "AQAAAAIAAYagAAAAEJhCo/rjbuzyl0NsE4zl3qoYQdMQ9m9pyGKnRTGeLQQH5u5vuc5+xM0JHA1qP2g8Mg==", "8d0548d4-1f9f-4676-bee9-255942b2efcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8bdeca5-b722-4d67-8b05-d919b61162df", "AQAAAAIAAYagAAAAEIOSgNfZsOJHiZzBuvgfHkozOdlG+JRQNGckiYAr8fBL1MGHDr+Qi6sTPSDmL+xErA==", "7a56fedb-a092-4261-a356-878559fb3b7c" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2393), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2390), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2396), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2395), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2159), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2177), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 3, 17, 22, 29, 24, 475, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9547), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9559), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 3, 17, 22, 29, 25, 780, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1232), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1234), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1680), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1690), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1692), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1695), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912347",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1697), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1683), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1685), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1688), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2052), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2056), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2058), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2061), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(851), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(865), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(875), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(341), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(343), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3751), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3754), new DateTime(2023, 3, 17, 22, 29, 25, 781, DateTimeKind.Local).AddTicks(3755) });
        }
    }
}
