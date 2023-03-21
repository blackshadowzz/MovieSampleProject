using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable
//this is migration that genereted by system
namespace MovieSampleProject.Migrations
{
    /// <inheritdoc />
    public partial class moviedb01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Languege = table.Column<string>(type: "varchar(30)", nullable: true),
                    MovieType = table.Column<int>(type: "int", nullable: true),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "varchar(500)", nullable: true),
                    Released = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Duration = table.Column<string>(type: "varchar(30)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Production = table.Column<string>(type: "varchar(40)", nullable: true),
                    AgeLimited = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
