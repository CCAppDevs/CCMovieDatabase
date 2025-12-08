using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "RatingId", "ReleaseDate", "ThumbnailURL", "Title" },
                values: new object[,]
                {
                    { 3, "When Ash Williams is accidentally transported to 1300 A.D., he must retrieve the Necronomicon and battle an army of the dead in order to return home.", 2, new DateOnly(1993, 2, 19), null, "Army of Darkness" },
                    { 5, "A designer makes a grievous mistake when he rejects the friendship of a borderline cable guy.", 1, new DateOnly(1996, 6, 14), null, "The Cable Guy" },
                    { 6, "After being bitten by a genetically-modified spider, a shy teenager gains spider-like abilities that he uses to fight injustice as a masked superhero and face a vengeful enemy.", 1, new DateOnly(2002, 5, 3), null, "Spider-Man" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "Name" },
                values: new object[] { 4, "PG" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "RatingId", "ReleaseDate", "ThumbnailURL", "Title" },
                values: new object[,]
                {
                    { 4, "An insurance salesman begins to suspect that his whole life is actually some sort of reality TV show.", 4, new DateOnly(1998, 6, 5), null, "The Truman Show" },
                    { 7, "Jack Skellington, king of Halloween Town, discovers Christmas Town, but his attempts to bring Christmas to his home causes confusion.", 4, new DateOnly(1993, 10, 29), null, "The Nightmare Before Christmas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 4);
        }
    }
}
