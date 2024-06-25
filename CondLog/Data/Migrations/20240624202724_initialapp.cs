using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondLog.Migrations
{
    /// <inheritdoc />
    public partial class initialapp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuários",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuários", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuários_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocurrences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocurrences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ocurrences_Usuários_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuários",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f77923c-6f14-4248-9d58-93819b5c4d94", null, "Usuário", "USUÁRIO" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2e5317bb-05bf-4474-bc10-01b4eda8946a", 0, "1ce7de4a-e190-4103-a59c-b655c1743dcf", "pedrorc2602@gmail.com", true, false, null, "PEDRORC2602@GMAIL.COM", "PEDRORC2602@GMAIL.COM", "AQAAAAIAAYagAAAAEOKIcDbr1309n7NRy407bp81dLyfTD/pYBaubyARQJnbtgXqxpBd5pyW/3M6sAzgYw==", "(87) 3685-4252", false, "9c0336fe-2822-4ed5-8a31-bf6144e65dd1", false, "pedrorc2602@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2f77923c-6f14-4248-9d58-93819b5c4d94", "2e5317bb-05bf-4474-bc10-01b4eda8946a" });

            migrationBuilder.InsertData(
                table: "Usuários",
                columns: new[] { "Id", "Apartment", "Block", "IsDeleted", "Name" },
                values: new object[] { "2e5317bb-05bf-4474-bc10-01b4eda8946a", "603", "A", false, "Pedro" });

            migrationBuilder.CreateIndex(
                name: "IX_Ocurrences_UserId",
                table: "Ocurrences",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ocurrences");

            migrationBuilder.DropTable(
                name: "Usuários");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f77923c-6f14-4248-9d58-93819b5c4d94", "2e5317bb-05bf-4474-bc10-01b4eda8946a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f77923c-6f14-4248-9d58-93819b5c4d94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e5317bb-05bf-4474-bc10-01b4eda8946a");
        }
    }
}
