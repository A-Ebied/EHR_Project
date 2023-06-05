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
            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8387), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8701), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8706), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eac68e98-59b1-42a4-88ee-d98439aeba85", "AQAAAAIAAYagAAAAELfk3Fnkh1KFNmi1q6NYlDH/bi4xNr/yUhLsoSHkENitAZMGDLB9mRINC74//PiMvA==", "f63a22f0-9665-4a8a-8ac1-1d2e105c6071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e040d0c-1e7e-4ae2-a306-f2f44407d7a2", "M@gmail.com", "M@GMAIL.COM", "AQAAAAIAAYagAAAAENTsqlUx83LQA3CET9CoUD0HsakxagD8eRoXoG9jaAHQKU1yZjaXwpCsPWxicHq+wA==", "2b141713-eeda-45c9-a7b6-524761cc70d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a22c59e-a264-4435-a841-7465bac6f073", "muha75375@gmail.com", "MUHA75375@GMAIL.COM", "AQAAAAIAAYagAAAAEJOEKQQrAxVzb7/MjbStFpvA43zYnTF1ff3FB8OVtRuNh05mrgjAr9LBaLnEx3ilLg==", "8b02d0ae-e900-480a-8627-261837570d39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78a94d45-83ac-4675-a77d-d0b226dbd599", "AQAAAAIAAYagAAAAEIOff7ttWzVta16FOzzcw85BBo11IZ/c7D5LM1XoNZp22kpAyYFvjJZ9Qp6auCiyiA==", "e9429c2e-6b87-4e95-bec5-54d388eea90d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a2f3c45-d116-4e28-ab7d-2dbbe640f25e", "AQAAAAIAAYagAAAAEFL2o2IU5w0UU+4lGgoX26L6dOAYiB7l5goRVb3AI3TTGd7y9itXuvBIfxop/kD4hg==", "37e04f68-f846-408c-9cdb-1e65b36cbf26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3925c45-f24f-4b70-b9e7-71a016dec1a7", "AQAAAAIAAYagAAAAELZBcbcWzd7RcI00Ag2RK4jXurusWAuAzd147S/FFA/J2GwXWqyO2TvppeY/R4j+kg==", "c3bf6e4d-7c2f-45bf-b34b-36bc13ab0a6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d8cbaea-eeb0-46c9-9a45-0adf4f1982bd", "AQAAAAIAAYagAAAAEEpYk91cPbR8sRDcER7pxZyhut+TtRVERAXMLqaDX4rp/rUwYmSjG5wJXRF29XDXeg==", "c36a95e7-b791-4d21-831d-7e7fd64758e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "185a86de-a913-42b7-828d-6977e6d6290e", "AQAAAAIAAYagAAAAELSjmX4DL0TZ0zr5vd0ibs0q9SWEmpW7E7rWp8xLcsJk/lQBXpKH9J9l3GhiMEn5VQ==", "c40e0f40-a69e-42cb-8c22-ef6f3ab550f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c7dd5f2-2281-4352-ac73-28427162d321", "AQAAAAIAAYagAAAAEApl6/+qWRDTQNb8cJblvFAc4wF0zYXa44s5u2F6o+aayexulUtjno/GEEzpoKkMcQ==", "76621600-f7e0-46c5-839b-21f45681af34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deb6cd07-dd6b-4d2a-8322-e16e2c909fe8", "AQAAAAIAAYagAAAAECUavcB8//Ne6XpGe8WuOJ+Ny8djWdoEPM4Kj8njrGm/ktgsyI01VXnhi6Fs4di2/w==", "ae5b856c-dcf2-4b1e-b843-6bf3400e7986" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a149b860-2aee-4562-afbb-6f4ee01e3139", "AQAAAAIAAYagAAAAEGzcGRNwv2RtSZsqfB2p9EGqzmqAMz5n+zEUO05vgAvX12B2L4g9qPfE2cZ7ai8i4w==", "f2642f44-d9d4-441e-bba8-150f5abf7305" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8084), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8087), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7774), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7783), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2876), new DateTime(2023, 6, 5, 6, 3, 38, 961, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5264), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5268), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: " I10",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5592), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6777), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6792), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6795), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7100), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7115), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7118), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7121), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7106), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7109), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7112), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7437), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7443), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7446), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7450), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7453), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6434), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6447), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6454), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6005), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6010), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9155), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9161), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9172), new DateTime(2023, 6, 5, 6, 3, 39, 762, DateTimeKind.Local).AddTicks(9173) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Allergies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8918), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "AllergyDrugs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912341",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32619418-fc40-4bb3-bc70-ff3fa9a1dd5f", "AQAAAAIAAYagAAAAEH0txxKHdOZQuonxQM7/eDW5PspMjs6bRHruYjeRa4EXst+OltYLCnlafVkb9D0GfQ==", "f939b792-616f-49cc-bef9-96ca8045fb82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab5109e4-1ff9-494e-b7f0-25bb69d47f79", "muha75375@gmail.com", "MUHA75375@GMAIL.COM", "AQAAAAIAAYagAAAAEEDvileho072WKErApPYBAS/yRNx9jkYzIVRyFGcfrpN/aq+w4TXYoURWINrSKpgDw==", "3edd36e2-deec-4422-b393-d4aef650d552" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0eea9b3-7fde-46ec-a93c-929656c809b1", "M@gmail.com", "M@GMAIL.COM", "AQAAAAIAAYagAAAAEGt991fbf9sUF20EbvMwv95sBVeJbjKc05CUBrLV7+VIoxuHLxRONVcAJaMO7dZdNA==", "b0e5c787-3af3-4487-8714-b30461bf8cf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ccc0706-f107-454e-acb5-29734ecaac71", "AQAAAAIAAYagAAAAEJp8mKRGMv4LC/u7odjmlERfLr/FVXmT5ukbp6PGE7z9g4FKKK3/Nc54LPk6WrCSyQ==", "9362a62b-a35c-4ea0-961c-638bc50ec0d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47b2a3db-10ac-4a2a-b841-6e5b90bcdfc3", "AQAAAAIAAYagAAAAEPi0d3uCWHUDiKnrNc6kuHXGpij6XfkQqpPu4F5J5rnWnfC4a+ayqrpoW4Azl/ujRw==", "21b68d30-0939-4be3-9462-fbb2cc8e6f4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7751264-9f7b-4858-b869-daeda5f8bf76", "AQAAAAIAAYagAAAAEHJwzsM8EleSmNPsj/aNicEBLwVOVT+baPqhs25yw+3COgVpgq8n1b+BvrN5THamJg==", "cfb41475-b94a-4d02-9108-f41bb639188c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90433ea2-45f2-4050-a11f-4328e6cef2f5", "AQAAAAIAAYagAAAAEOFCElfPlokQ7EIBTB0SZw2vpgDkJLWT6CC9B0XIpWL68tisOxbGQ3MCNPvnyZHOWg==", "dc1b3677-a3d6-46a3-90e6-49dcf7a8eb38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06be3f01-5926-4f24-9f99-5fa9bd0b1799", "AQAAAAIAAYagAAAAEB1s8vbTrscjjmGRJnjzMbtwQLZVp0GW6WygKBoNXRnQPBfDM992A2X7g5AIadXRjA==", "1dfb84b5-41bc-41f1-91e8-054768c0bf3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaeea70f-6cb2-42e2-9139-5b1790a7a23c", "AQAAAAIAAYagAAAAELb+Itl8QpEDsuFVGxRrpffp117c2DoyxlwLtfW42WfjOmITTKT6nCxKLuYxqi7F+A==", "e4b0ba5f-8201-4b1d-bf3d-5c8bef4d89bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96eeddde-d719-4f56-9150-8e11c3af500a", "AQAAAAIAAYagAAAAECxvs5KPivsiaJdzZ0vwRVyQ5vwPH8Jro573wx5oMQ+nonQfMrT3WbPDA+E7fPHCVQ==", "ac084808-6253-46a9-88e1-e75bb20e44b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "863da36f-eb6c-48cd-a7ad-6467ad238661", "AQAAAAIAAYagAAAAEE77V4y850W2GkWkGYx5bdzo/9DkoXfmt3kLoE8a5oo2HJO2K1k5Q6btv4udaWNMgw==", "9dac9b81-ebbd-41a3-8e14-6e6a57e19189" });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8377), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8381), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "BadHabits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "BloodDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DonationDateTime", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8145), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8143), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9692), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9741), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9748), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9751), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 6, 4, 17, 46, 11, 387, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6069), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6111), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "HealthFacilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6114), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: " I10",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6384), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6368), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6373), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A00.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6376), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "A01.00",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6378), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "ICDs",
                keyColumn: "Code",
                keyValue: "J18.9",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6381), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "MedicalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7358), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912342",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7614), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912343",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7627), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912344",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7630), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912346",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7633), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912348",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7619), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912349",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7622), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "MedicalTeam",
                keyColumn: "Id",
                keyValue: "12345678912350",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7624), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912351",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7073), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912352",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7085), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "12345678912353",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6691), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "UserInsurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6696), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9166), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9174), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Vaccinations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 6, 4, 17, 46, 12, 166, DateTimeKind.Local).AddTicks(9183) });
        }
    }
}
