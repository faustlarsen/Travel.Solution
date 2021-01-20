using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(maxLength: 20, nullable: false),
                    City = table.Column<string>(maxLength: 20, nullable: false),
                    ReviewText = table.Column<string>(maxLength: 1000, nullable: false),
                    Author = table.Column<string>(maxLength: 20, nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Author", "City", "Country", "Rating", "ReviewText" },
                values: new object[,]
                {
                    { 1, "John Snow", "Seattle, WA", "USA", 5, "Great city" },
                    { 2, "Pamela Anderson", "Los Angeles, CA", "USA", 4, "Dirty city" },
                    { 3, "John Sun", "Tucson, Az", "USA", 3, "Hot city" },
                    { 4, "John Snow", "Tomsk", "Russia", 2, "Cold city" },
                    { 5, "A. Lukashenko", "Mogilev", "Belarus", 1, "Terrible city" },
                    { 6, "Serge Bash", "Minsk", "Belarus", 1, "OK city" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
