using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class phase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "moviesDb",
                columns: table => new
                {
                    MovieName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ReleseYear = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moviesDb", x => x.MovieName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "moviesDb");
        }
    }
}
