using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Author", "City", "Country", "Rating", "Text" },
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
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);
        }
    }
}
