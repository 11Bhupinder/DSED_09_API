using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DSED_07_Web_Development.Migrations
{
    public partial class LibraryDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComuterScience",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false),
                    BookAuthor = table.Column<string>(maxLength: 50, nullable: true),
                    BookName = table.Column<string>(maxLength: 50, nullable: true),
                    BookPrice = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComuterScience", x => x.BookID);
                });

            migrationBuilder.CreateTable(
                name: "Novels",
                columns: table => new
                {
                    NovelID = table.Column<int>(nullable: false),
                    NovelAuthor = table.Column<string>(maxLength: 50, nullable: true),
                    NovelName = table.Column<string>(maxLength: 50, nullable: true),
                    NovelPrice = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novels", x => x.NovelID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportId = table.Column<int>(nullable: false),
                    SportCoach = table.Column<string>(maxLength: 50, nullable: true),
                    SportFees = table.Column<double>(nullable: true),
                    SportName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComuterScience");

            migrationBuilder.DropTable(
                name: "Novels");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
