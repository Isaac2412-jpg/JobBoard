using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobBoard.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Application",
                columns: new[] { "Id", "DateApplied", "JobListingId", "JobSeekerId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 15, 18, 27, 55, 522, DateTimeKind.Local).AddTicks(5471), 1, 3, "Pending" },
                    { 2, new DateTime(2025, 12, 18, 18, 27, 55, 522, DateTimeKind.Local).AddTicks(5506), 2, 4, "Reviewed" }
                });

            migrationBuilder.InsertData(
                table: "Employer",
                columns: new[] { "Id", "CompanyEmail", "CompanyLogoPath", "CompanyName", "Industry", "Location", "UserId", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, "contact@techcorp.com", null, "TechCorp", "Software", "New York, NY", 2, "https://techcorp.com" },
                    { 2, "info@healthplus.com", null, "HealthPlus", "Healthcare", "Boston, MA", 2, "https://healthplus.com" }
                });

            migrationBuilder.InsertData(
                table: "FeedBack",
                columns: new[] { "Id", "DateSubmitted", "Message", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 20, 18, 27, 55, 522, DateTimeKind.Local).AddTicks(6030), "Great job board, very easy to use!", 3 },
                    { 2, new DateTime(2025, 12, 20, 18, 27, 55, 522, DateTimeKind.Local).AddTicks(6032), "I love how easy it is to post jobs.", 2 }
                });

            migrationBuilder.InsertData(
                table: "JobListing",
                columns: new[] { "Id", "DatePosted", "Description", "EmployerId", "Industry", "JobType", "Location", "Requirements", "Salary", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 20, 18, 27, 55, 522, DateTimeKind.Local).AddTicks(6110), "Develop and maintain web applications using modern frameworks.", 1, "Software", "Full-time", "New York, NY", "Proficient in C#, ASP.NET, and React.", 80000, "Frontend Developer" },
                    { 2, new DateTime(2025, 12, 20, 18, 27, 55, 522, DateTimeKind.Local).AddTicks(6114), "Work on APIs and server-side logic.", 1, "Software", "Full-time", "San Francisco, CA", "Experience with C#, .NET Core, SQL Server.", 85000, "Backend Developer" },
                    { 3, new DateTime(2025, 12, 20, 18, 27, 55, 522, DateTimeKind.Local).AddTicks(6116), "Analyze data to provide actionable insights.", 2, "Finance", "Part-time", "Chicago, IL", "SQL, Excel, and Power BI experience.", 60000, "Data Analyst" }
                });

            migrationBuilder.InsertData(
                table: "JobSeeker",
                columns: new[] { "Id", "EducationLevel", "Email", "Experience", "LinkedInPath", "Name", "ResumePath", "UserId" },
                values: new object[,]
                {
                    { 1, "Bachelor's in Computer Science", "alice.johnson@example.com", "2 years at TechCorp as Frontend Developer", "https://www.linkedin.com/in/alicejohnson", "Alice Johnson", null, 1 },
                    { 2, "Master's in Data Science", "bob.smith@example.com", "3 years at DataSolutions as Data Analyst", "https://www.linkedin.com/in/bobsmith", "Bob Smith", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccountType", "Email", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin", "admin@example.com", "Admin", "AdminUser" },
                    { 2, "Standard", "employer@example.com", "Employer", "EmployerUser" },
                    { 3, "Standard", "jobseeker@example.com", "JobSeeker", "JobSeekerUser" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DeleteData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobSeeker",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobSeeker",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
