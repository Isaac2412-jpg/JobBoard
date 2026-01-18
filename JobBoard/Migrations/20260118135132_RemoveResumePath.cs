using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobBoard.Migrations
{
    /// <inheritdoc />
    public partial class RemoveResumePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResumePath",
                table: "JobSeeker");

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateApplied",
                value: new DateTime(2026, 1, 13, 21, 51, 30, 532, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateApplied",
                value: new DateTime(2026, 1, 16, 21, 51, 30, 532, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-2222-3333-4444-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b6cd7cd-737c-49f0-9c7b-1e897043837b", "AQAAAAIAAYagAAAAEOrqZ2vjS2MPR9TlRefdFS/YQlkQA8eN8P3wQuhq2eoMnDFv20n+xSe9kPH4ec1/8g==", "f1368e3d-d4b5-485e-b0cc-4eaf963db54e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-3333-4444-5555-666666666666",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0cf3a7d-0279-4ce4-afc5-a6bfa5e5065f", "AQAAAAIAAYagAAAAEM5R0m/o8iugxCOAcUvYB1+fAI7Rlfw46nLTs+UfqF4WPre2EHzne7VokIuwCgL1Pg==", "3fc0aee5-d65b-4b51-a4c8-5029eaa81a65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-4444-5555-6666-777777777777",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a7ec7b2-5905-472a-b56d-3cda5b5c40fc", "AQAAAAIAAYagAAAAEC5AieKHIm+1sQEMJjVXwr4LY0rWHb6Fl4BtnJBCLlxkRr+YzvTMdRNCWe2Pl6G8ZQ==", "9f038f50-c7fa-45f3-b210-fce1e09d3085" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea016dc8-3743-4669-a4a0-483737f35682", "AQAAAAIAAYagAAAAED5BXW2RxoWRJUfxMqH8mqsrgeaWYGnxo644SJQSJCt2M9ZhmU0O5YQR3EJ61WNW3A==", "b50a3831-a053-4737-9a08-14a3343587c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-5555-6666-7777-888888888888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55248409-540e-4860-a236-1fad2fac70db", "AQAAAAIAAYagAAAAEPdUXlP9uNncOHN25kVOPIwvpGZ1eJvi1zVxpcvwN1h/BSwhi+7zNcOblTEQr2KNUg==", "85b077b9-804d-42d8-a638-d0f3b99674d2" });

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSubmitted",
                value: new DateTime(2026, 1, 18, 21, 51, 30, 532, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSubmitted",
                value: new DateTime(2026, 1, 18, 21, 51, 30, 532, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2026, 1, 18, 21, 51, 30, 532, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2026, 1, 18, 21, 51, 30, 532, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2026, 1, 18, 21, 51, 30, 532, DateTimeKind.Local).AddTicks(6413));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResumePath",
                table: "JobSeeker",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateApplied",
                value: new DateTime(2026, 1, 6, 22, 55, 52, 619, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateApplied",
                value: new DateTime(2026, 1, 9, 22, 55, 52, 619, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-2222-3333-4444-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84c1638b-10bb-4a36-8dd5-7644bd4f774c", "AQAAAAIAAYagAAAAEEaP5Pojqkr1s6VpIUfO705A7um2FcEiLUC/g+oxzKCqNJpO2n8Je7Vg/e7XOhU/5Q==", "2caa8c53-0cd8-45af-994a-1b6646cfe48c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-3333-4444-5555-666666666666",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5c9a794-61b9-4a02-a8d2-c3995003870e", "AQAAAAIAAYagAAAAEDvQff23ghmfAMsQMe1KtOdGB8UwV3bneUiutsfxgRWAgmjMmsxR+Ba/FTF/pGdC+A==", "c4d2f4d1-63e6-43f0-8199-58983afda879" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-4444-5555-6666-777777777777",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72e0edb4-c94f-4f3c-b4e7-f632342505da", "AQAAAAIAAYagAAAAEKUsQecuqKbOjMyNlpCxXB5efzKVhTxXEZEpHQmhrwtFWj7A+Wv3r+nVB0SHk8suvA==", "a36fa712-28b4-4798-a5d5-344ce5844990" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2fb5193-ed99-4c90-bcdb-1eefbbb3386f", "AQAAAAIAAYagAAAAEOHNqcbQCGWEqi5LGTnXkNskIbOWtOzCmdj2PV7Gvi+W1GMHN7eLwXy49+KmQhagvg==", "1ad00f8c-f88d-4b4b-b73e-ac51be294069" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-5555-6666-7777-888888888888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "611cad19-8788-4758-bdd1-3de800706b85", "AQAAAAIAAYagAAAAEDbCPoBbUIWTX3ucEsVBlpLYlLsC9RZ0TYR/NXHiP9ao9/sRlfI3aqotl+2YPFeAKA==", "87ba62c2-cd45-4654-9533-18be1b7c4443" });

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSubmitted",
                value: new DateTime(2026, 1, 11, 22, 55, 52, 619, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSubmitted",
                value: new DateTime(2026, 1, 11, 22, 55, 52, 619, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2026, 1, 11, 22, 55, 52, 619, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2026, 1, 11, 22, 55, 52, 619, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2026, 1, 11, 22, 55, 52, 619, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "JobSeeker",
                keyColumn: "Id",
                keyValue: 1,
                column: "ResumePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "JobSeeker",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResumePath",
                value: null);
        }
    }
}
