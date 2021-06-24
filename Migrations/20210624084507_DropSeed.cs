using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace VideoRental.API.Migrations
{
    public partial class DropSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "VideoTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rate = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Genre = table.Column<string>(type: "text", nullable: true),
                    MaximumAge = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    VideoTypeId = table.Column<int>(type: "integer", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Videos_VideoTypes_VideoTypeId",
                        column: x => x.VideoTypeId,
                        principalTable: "VideoTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VideoTypes",
                columns: new[] { "Id", "Rate", "Type" },
                values: new object[,]
                {
                    { 1, 10, "Regular" },
                    { 2, 8, "Children’s Movie" },
                    { 3, 15, "New Release" }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Genre", "MaximumAge", "Title", "VideoTypeId", "Year" },
                values: new object[,]
                {
                    { 1, "Drama", 0, "Diary of a Chambermaid", 1, 0 },
                    { 28, "Horror", 0, "The Feathered Serpent", 3, 2021 },
                    { 27, "Action", 0, "Red Hook Summer", 3, 2021 },
                    { 26, "Drama", 0, "As Long as You've Got Your Health (Tant qu'on a la santé)", 3, 2020 },
                    { 25, "Romance", 0, "Time of Eve (Eve no jikan)", 3, 2020 },
                    { 24, "Comedy", 0, "Big Tease, The", 3, 2019 },
                    { 23, "Comedy", 0, "Sorority Babes in the Slimeball Bowl-O-Rama", 3, 2019 },
                    { 22, "Comedy", 0, "Singing Detective, The", 3, 2021 },
                    { 21, "Horror", 0, "YellowBrickRoad", 3, 2020 },
                    { 20, "Comedy", 14, "Officer and a Gentleman, An", 2, 0 },
                    { 19, "Drama", 13, "Misérables, Les", 2, 0 },
                    { 18, "Action", 12, "Few Good Men, A", 2, 0 },
                    { 17, "Romance", 6, "Black Tights (1-2-3-4 ou Les Collants noirs)", 2, 0 },
                    { 16, "Drama", 9, "Ring Two, The", 2, 0 },
                    { 15, "Comedy", 11, "Diggstown", 2, 0 },
                    { 14, "Horror", 10, "Vanishing, The (Spoorloos)", 2, 0 },
                    { 13, "Romance", 14, "Paris, France", 2, 0 },
                    { 12, "Regular", 12, "Mumia Abu-Jamal: A Case for Reasonable Doubt?", 2, 0 },
                    { 11, "Drama", 14, "Eva", 2, 0 },
                    { 10, "Horror", 0, "Shadow, The", 1, 0 },
                    { 9, "Comedy", 0, "Moon 44", 1, 0 },
                    { 8, "Romance", 0, "Layer Cake", 1, 0 },
                    { 7, "Drama", 0, "Septième juré, Le", 1, 0 },
                    { 6, "Comedy", 0, "Razortooth", 1, 0 },
                    { 5, "Action", 0, "Over the Brooklyn Bridge", 1, 0 },
                    { 4, "Action", 0, "The Emperor's Candlesticks", 1, 0 },
                    { 3, "Action", 0, "Secret of the Grain, The (La graine et le mulet)", 1, 0 },
                    { 2, "Action", 0, "Perfect Sense", 1, 0 },
                    { 29, "Comedy", 0, "Little Lili (La petite Lili)", 3, 2021 },
                    { 30, "Romance", 0, "Falling in Love", 3, 2021 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Videos_VideoTypeId",
                table: "Videos",
                column: "VideoTypeId");
        }
    }
}
