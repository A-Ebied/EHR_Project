using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EHRAPI.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Governorates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HasGovernmentInsurance = table.Column<bool>(type: "bit", nullable: false),
                    HasAnotherInsurance = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceData_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNAImageResultUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalData_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalTeam",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MedicalSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalTeam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalTeam_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSane = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthFacilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubordinateTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDataId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthFacilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthFacilities_AspNetUsers_RegistrationDataId",
                        column: x => x.RegistrationDataId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthFacilities_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumOfChildren = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyPhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalData_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalData_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInsurance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceOrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelationshipWithOrganization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsuranceDataId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInsurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInsurance_InsuranceData_InsuranceDataId",
                        column: x => x.InsuranceDataId,
                        principalTable: "InsuranceData",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "SystemManager", "SYSTEMMANAGER" },
                    { "2", null, "HealthFacilitiesAdministrator", "HEALTHFACILITIESADMINISTRATOR" },
                    { "3", null, "HealthFacilityManager", "HEALTHFACILITYAMANAGER" },
                    { "4", null, "Physician", "PHYSICIAN" },
                    { "5", null, "Nurse", "NURSE" },
                    { "6", null, "Pharmacist", "PHARMACIST" },
                    { "7", null, "Patient", "PATIENT" },
                    { "8", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateddAt", "UserName" },
                values: new object[,]
                {
                    { "12345678902341", 0, "b7800ff5-b486-4e03-840d-bae84ba9216e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A@gmail.com", false, "أحمد محمد أحمد", false, null, "مصري", "A@GMAIL.COM", "@AHMED123", "AQAAAAIAAYagAAAAEEaF7eCZ1rTM+3Ld61A0l0jkbIP3AkCMzaTnrX/oQpQPhqEKRMX4TE7U9KAe0p+sIQ==", "", false, "ccefc028-03b0-46fb-8292-50d9cd4d15b2", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Ahmed123" },
                    { "12345678912345", 0, "32f0eef8-9fcc-490f-a30a-9e29fd4be25e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "k@gmail.com", false, "أحمد محمد كمال", false, null, "مصري", "K@GMAIL.COM", "@KAMAL123", "AQAAAAIAAYagAAAAEGRDODo4tC0AXIvXvIo9pPKgoeA/SZfpsQOyOcSxh45cqwd9Z1tujFDaEuB8E4yWFw==", "01234567890", false, "a24c5725-7ff6-4c7a-ad0e-31faa5f20db9", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Kamal123" },
                    { "12345678921345", 0, "4e89614d-3d34-4af7-92fc-5099b85f3f8c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M@gmail.com", false, "أحمد محمد محمد", false, null, "مصري", "M@GMAIL.COM", "@MUHAMMAD123", "AQAAAAIAAYagAAAAEASmkRNJGaZvyRSIFvxLoIrLJ4vuTANxyb03t23dNA4vm3jX3OaHUdZQp0nRE2AjVQ==", "01234567899", false, "72146f97-1ef2-484c-8a2f-a7c3b1c840b7", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Muhammad123" },
                    { "92345678912345", 0, "0d64d543-19ff-4bad-aadf-2c7658b01ebf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al@gmail.com", false, "أحمد محمد علي", false, null, "مصري", "AL@GMAIL.COM", "@ALI123", "AQAAAAIAAYagAAAAEFjdeFFq4USTgl/Z4LTonI4HzsuvXoxho8SfJZVEi4rkFl4BQppjXBAcgOxqNxCjfQ==", "01234567890", false, "8374da3b-f3b0-41b1-833c-e53dcb3eac31", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "@Ali123" }
                });

            migrationBuilder.InsertData(
                table: "Governorates",
                columns: new[] { "Id", "CreatedAt", "Title", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(420), "القاهرة", new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(453) },
                    { 2, new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(461), "الجيزة", new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(464) },
                    { 3, new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(469), "مطروح", new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(472) },
                    { 4, new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(476), "شمال سيناء", new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(478) },
                    { 5, new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(503), "الشرقية", new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(506) },
                    { 6, new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(511), "الدقهلية", new DateTime(2023, 2, 23, 12, 44, 52, 148, DateTimeKind.Local).AddTicks(514) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "12345678902341" },
                    { "3", "12345678912345" },
                    { "3", "12345678921345" },
                    { "1", "92345678912345" }
                });

            migrationBuilder.InsertData(
                table: "HealthFacilities",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "Email", "GovernorateId", "Phone1", "Phone2", "Phone3", "RegistrationDataId", "SubordinateTo", "Title", "Type", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, "Address1", new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2706), "Description1", "m@gmail.com", 1, "01123456878", "", "", "12345678912345", "المؤسسة العسكرية", "المستشفى العسكري بالشرقية", "مستشفى عسكري", new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2724) },
                    { 2, "Address2", new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2729), "Description2", "a@gmail.com", 1, "01122456878", "", "", "12345678902341", "وزارة الصحة", "المستشفى العام بالعريش", "مستشفى عام", new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2731) },
                    { 3, "Address3", new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2734), "Description3", "j@gmail.com", 1, "01123416878", "", "", "12345678921345", "مستشفيات الجامعة", "مستشفى الجامعة بالزقازيق", "مستشفى جامعي", new DateTime(2023, 2, 23, 12, 44, 53, 86, DateTimeKind.Local).AddTicks(2736) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacilities_GovernorateId",
                table: "HealthFacilities",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthFacilities_RegistrationDataId",
                table: "HealthFacilities",
                column: "RegistrationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_GovernorateId",
                table: "PersonalData",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInsurance_InsuranceDataId",
                table: "UserInsurance",
                column: "InsuranceDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "HealthFacilities");

            migrationBuilder.DropTable(
                name: "MedicalData");

            migrationBuilder.DropTable(
                name: "MedicalTeam");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "PersonalData");

            migrationBuilder.DropTable(
                name: "UserInsurance");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Governorates");

            migrationBuilder.DropTable(
                name: "InsuranceData");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
