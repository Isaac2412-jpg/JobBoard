using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobBoard.Migrations
{
    /// <inheritdoc />
    public partial class UserSeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e9b7a3d2-5f61-4c9b-8a11-0b3f8c4e5678", "11111111-2222-3333-4444-555555555555" },
                    { "e9b7a3d2-5f61-4c9b-8a11-0b3f8c4e5678", "22222222-3333-4444-5555-666666666666" },
                    { "d7e4c1b2-8a9f-4c33-b1a0-92e4f6d8c123", "33333333-4444-5555-6666-777777777777" },
                    { "d7e4c1b2-8a9f-4c33-b1a0-92e4f6d8c123", "44444444-5555-6666-7777-888888888888" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9b7a3d2-5f61-4c9b-8a11-0b3f8c4e5678", "11111111-2222-3333-4444-555555555555" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9b7a3d2-5f61-4c9b-8a11-0b3f8c4e5678", "22222222-3333-4444-5555-666666666666" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d7e4c1b2-8a9f-4c33-b1a0-92e4f6d8c123", "33333333-4444-5555-6666-777777777777" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d7e4c1b2-8a9f-4c33-b1a0-92e4f6d8c123", "44444444-5555-6666-7777-888888888888" });

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateApplied",
                value: new DateTime(2026, 1, 6, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateApplied",
                value: new DateTime(2026, 1, 9, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-2222-3333-4444-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f05e4147-0d64-482f-b551-66dffd28d873", "AQAAAAIAAYagAAAAECwHqKd7l73xDDSQvtTvu9WVyIRlbumPyk/Rsy6wZEm4dUUv4Qjn79pM6yLG+7zQ3w==", "9bc68eec-e7d2-4543-a8d1-4b4113ad6dcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-3333-4444-5555-666666666666",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d582706b-3b0e-4e61-a8fe-8886f9155952", "AQAAAAIAAYagAAAAEHMz9VhP9xMYi7lTnUMvfgYNtDOjSCPy5aBMbq7qlYDg6EKmppP2GeF07nxM61AdHQ==", "3ecd67b3-d840-4a00-b075-d131ed27fc11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-4444-5555-6666-777777777777",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30ed7692-9934-4834-af67-f3a4c34264ac", "AQAAAAIAAYagAAAAEIaogBHZcuquvPyEs2hWk+PvPlvJxkSFReFcrEc1oj4X6/WKOP4ypVqe4Y3BGkoXmA==", "28416ca1-1b76-45a7-9b68-7603233b2145" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2b77943-1669-4331-a4d2-1d4825730450", "AQAAAAIAAYagAAAAECnKGMw8Ri8EsxaJbCdp9N2uy01czg7a3zeixdz1fsx46ZVqZR92jWiEWDtJwf0dXQ==", "142c9f8e-d544-4dff-9790-a3862c1506e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-5555-6666-7777-888888888888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5ece6dd-f202-49fe-9b4a-fa959c6f183e", "AQAAAAIAAYagAAAAEF+auH3lArBW+smhOAxbY5zLY+X7OzPWhlAF204ZvebPq3RmPChmQZ9NiCYl8hOyXA==", "98230cd3-9234-4fdc-bb36-e0408dd2ee29" });

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSubmitted",
                value: new DateTime(2026, 1, 11, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSubmitted",
                value: new DateTime(2026, 1, 11, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2026, 1, 11, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2026, 1, 11, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "JobListing",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2026, 1, 11, 22, 19, 32, 615, DateTimeKind.Local).AddTicks(6128));
        }
    }
}
