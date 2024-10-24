using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace todo.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_753 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jegyzet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    kartyaID = table.Column<int>(type: "INTEGER", nullable: false),
                    tartalom = table.Column<string>(type: "TEXT", nullable: false),
                    letrehozasIdeje = table.Column<DateTime>(type: "TEXT", nullable: false),
                    modositasIdeje = table.Column<DateTime>(type: "TEXT", nullable: false),
                    kesz = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jegyzet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kartya",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nev = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kartya", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jegyzet");

            migrationBuilder.DropTable(
                name: "Kartya");
        }
    }
}
