using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class Sonic3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "RatingId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 3, "The third sonic movie focusing on shadow and the sonic adventure 2 inspired story", 1, new DateOnly(2024, 12, 20), "Sonic 3" },
                    { 4, "The final movie in the prequel trilogy connecting it to the original trilogy", 1, new DateOnly(2005, 4, 26), "Star Wars Revenge of ths sith" },
                    { 5, "about the avatar a supposed master of the 4 bending elements ", 1, new DateOnly(2005, 2, 21), "Avatar the last airbender" },
                    { 6, "about an immortal elf that goes on an adventure to understand the meaning of the limited time poeple have", 1, new DateOnly(2023, 9, 29), "Frieren: Beyond Journeys ENd" },
                    { 7, "The mario movie giving a diffrent story of how Mario came to the Mushroom kingdom", 1, new DateOnly(2023, 4, 5), "The Mario Movie" }
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
        }
    }
}
