using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeededMoviesForTop5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "RatingId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 3, "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.", 1, new DateOnly(2001, 1, 1), "Harry Potter and the Sorcerer's Stone" },
                    { 4, "A cowboy doll is profoundly jealous when a new spaceman action figure supplants him as the top toy in a boy's bedroom.", 3, new DateOnly(1995, 1, 1), "Toy Story" },
                    { 5, "In the 1940s, a young boy named Ralphie Parker attempts to convince his parents, teacher, and Santa Claus that a Red Ryder Range 200 Shot BB gun really is the perfect Christmas gift.", 1, new DateOnly(1983, 1, 1), "A Christmas Story" },
                    { 6, "Raised as an oversized elf, Buddy travels from the North Pole to New York City to meet his biological father, Walter Hobbs, who doesn't know he exists and is in desperate need of some Christmas spirit.", 1, new DateOnly(2003, 1, 1), "Elf" },
                    { 7, "When all but one child from the same class mysteriously vanish on the same night at exactly the same time, a community is left questioning who or what is behind their disappearance.", 2, new DateOnly(2025, 1, 1), "Weapons" }
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
