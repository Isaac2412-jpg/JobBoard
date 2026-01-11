using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobBoard.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                name: "Employer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyLogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employer_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeedBack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdentityUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedBack_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSeeker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedInPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeeker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeeker_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobListing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobListing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobListing_Employer_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateApplied = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobListingId = table.Column<int>(type: "int", nullable: false),
                    JobSeekerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_AspNetUsers_JobSeekerId",
                        column: x => x.JobSeekerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Application_JobListing_JobListingId",
                        column: x => x.JobListingId,
                        principalTable: "JobListing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c3a1f2d4-9b8e-4a21-a1b2-01f0e5d6c789", null, "Admin", "ADMIN" },
                    { "d7e4c1b2-8a9f-4c33-b1a0-92e4f6d8c123", null, "Employer", "EMPLOYER" },
                    { "e9b7a3d2-5f61-4c9b-8a11-0b3f8c4e5678", null, "JobSeeker", "JOBSEEKER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11111111-2222-3333-4444-555555555555", 0, "f05e4147-0d64-482f-b551-66dffd28d873", "alice.johnson@example.com", true, false, null, "ALICE.JOHNSON@EXAMPLE.COM", "ALICE.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAECwHqKd7l73xDDSQvtTvu9WVyIRlbumPyk/Rsy6wZEm4dUUv4Qjn79pM6yLG+7zQ3w==", null, false, "9bc68eec-e7d2-4543-a8d1-4b4113ad6dcf", false, "alice.johnson@example.com" },
                    { "22222222-3333-4444-5555-666666666666", 0, "d582706b-3b0e-4e61-a8fe-8886f9155952", "bob.smith@example.com", true, false, null, "BOB.SMITH@EXAMPLE.COM", "BOB.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHMz9VhP9xMYi7lTnUMvfgYNtDOjSCPy5aBMbq7qlYDg6EKmppP2GeF07nxM61AdHQ==", null, false, "3ecd67b3-d840-4a00-b075-d131ed27fc11", false, "bob.smith@example.com" },
                    { "33333333-4444-5555-6666-777777777777", 0, "30ed7692-9934-4834-af67-f3a4c34264ac", "employer1@techcorp.com", true, false, null, "EMPLOYER1@TECHCORP.COM", "EMPLOYER1@TECHCORP.COM", "AQAAAAIAAYagAAAAEIaogBHZcuquvPyEs2hWk+PvPlvJxkSFReFcrEc1oj4X6/WKOP4ypVqe4Y3BGkoXmA==", null, false, "28416ca1-1b76-45a7-9b68-7603233b2145", false, "employer1@techcorp.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d2b77943-1669-4331-a4d2-1d4825730450", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECnKGMw8Ri8EsxaJbCdp9N2uy01czg7a3zeixdz1fsx46ZVqZR92jWiEWDtJwf0dXQ==", null, false, "142c9f8e-d544-4dff-9790-a3862c1506e1", false, "admin@localhost.com" },
                    { "44444444-5555-6666-7777-888888888888", 0, "e5ece6dd-f202-49fe-9b4a-fa959c6f183e", "employer2@healthplus.com", true, false, null, "EMPLOYER2@HEALTHPLUS.COM", "EMPLOYER2@HEALTHPLUS.COM", "AQAAAAIAAYagAAAAEF+auH3lArBW+smhOAxbY5zLY+X7OzPWhlAF204ZvebPq3RmPChmQZ9NiCYl8hOyXA==", null, false, "98230cd3-9234-4fdc-bb36-e0408dd2ee29", false, "employer2@healthplus.com" }
                });

            migrationBuilder.InsertData(
                table: "Employer",
                columns: new[] { "Id", "CompanyEmail", "CompanyLogoPath", "CompanyName", "IdentityUserId", "Industry", "Location", "UserId", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, "contact@techcorp.com", null, "TechCorp", "33333333-4444-5555-6666-777777777777", "Software", "New York, NY", null, "https://techcorp.com" },
                    { 2, "info@healthplus.com", null, "HealthPlus", "44444444-5555-6666-7777-888888888888", "Healthcare", "Boston, MA", null, "https://healthplus.com" }
                });

            migrationBuilder.InsertData(
                table: "FeedBack",
                columns: new[] { "Id", "DateSubmitted", "IdentityUserId", "Message", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 11, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(5685), "11111111-2222-3333-4444-555555555555", "Great job board, very easy to use!", null },
                    { 2, new DateTime(2026, 1, 11, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(5692), "22222222-3333-4444-5555-666666666666", "I love how easy it is to post jobs.", null }
                });

            migrationBuilder.InsertData(
                table: "JobSeeker",
                columns: new[] { "Id", "EducationLevel", "Email", "Experience", "IdentityUserId", "LinkedInPath", "Name", "ResumePath", "UserId" },
                values: new object[,]
                {
                    { 1, "Bachelor's in Computer Science", "alice.johnson@example.com", "2 years at TechCorp as Frontend Developer", "11111111-2222-3333-4444-555555555555", "https://www.linkedin.com/in/alicejohnson", "Alice Johnson", null, null },
                    { 2, "Master's in Data Science", "bob.smith@example.com", "3 years at DataSolutions as Data Analyst", "22222222-3333-4444-5555-666666666666", "https://www.linkedin.com/in/bobsmith", "Bob Smith", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c3a1f2d4-9b8e-4a21-a1b2-01f0e5d6c789", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "JobListing",
                columns: new[] { "Id", "DatePosted", "Description", "EmployerId", "Industry", "JobType", "Location", "Requirements", "Salary", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 11, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(6119), "Develop and maintain web applications using modern frameworks.", 1, "Software", "Full-time", "New York, NY", "Proficient in C#, ASP.NET, and React.", 80000, "Frontend Developer" },
                    { 2, new DateTime(2026, 1, 11, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(6125), "Work on APIs and server-side logic.", 1, "Software", "Full-time", "San Francisco, CA", "Experience with C#, .NET Core, SQL Server.", 85000, "Backend Developer" },
                    { 3, new DateTime(2026, 1, 11, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(6128), "Analyze data to provide actionable insights.", 2, "Finance", "Part-time", "Chicago, IL", "SQL, Excel, and Power BI experience.", 60000, "Data Analyst" }
                });

            migrationBuilder.InsertData(
                table: "Application",
                columns: new[] { "Id", "DateApplied", "JobListingId", "JobSeekerId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 6, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(5034), 1, "11111111-2222-3333-4444-555555555555", "Pending" },
                    { 2, new DateTime(2026, 1, 9, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(5080), 2, "22222222-3333-4444-5555-666666666666", "Reviewed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_JobListingId",
                table: "Application",
                column: "JobListingId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_JobSeekerId",
                table: "Application",
                column: "JobSeekerId");

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
                name: "IX_Employer_UserId",
                table: "Employer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_UserId",
                table: "FeedBack",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobListing_EmployerId",
                table: "JobListing",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeeker_UserId",
                table: "JobSeeker",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

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
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "JobSeeker");

            migrationBuilder.DropTable(
                name: "JobListing");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Employer");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
