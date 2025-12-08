using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class MovieSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "RatingId", "ReleaseDate", "ThumbnailURL", "Title" },
                values: new object[,]
                {
                    { 3, "A world-class playboy and part-time secret agent from the 1960s emerges after thirty years in a cryogenic state to battle with his nemesis Dr. Evil.", 1, new DateOnly(1997, 5, 2), "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTlO5X0VeATdsHkdAiSqrIjnibxUZFxHvr56dYDONVdRyNsdJyhhAgLl7cMeUZX_nJL1szd1r0PWHMyHtWNoVVvP1FZNLZ6-A", "Austin Powers: International Man of Mystery" },
                    { 4, "Dr. Evil is back and has invented a new time machine that allows him to go back to the 1960s and steal Austin Powers' mojo, inadvertently leaving him \"shagless\".", 1, new DateOnly(1999, 6, 11), "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSIfeD5mGXpWtcfJ_ycbhE_9ZAqnEugZyaEOd9vnjZYPipvpQq2olg1Bl2uyE6N_VcV7L0cnGIGgg8WqQD-fRo-USv7_4lLeQ", "Austin Powers: The Spy Who Shagged Me" },
                    { 5, "Upon learning that his father has been kidnapped, Austin Powers must travel to 1975 and defeat the aptly named villain Goldmember, who is working with Dr. Evil.", 1, new DateOnly(2002, 7, 26), "https://static.qobuz.com/images/covers/66/49/0081227784966_600.jpg", "Austin Powers in Goldmember" },
                    { 6, "A troubled security guard begins working at Freddy Fazbear's Pizza. During his five nights on the job, he realizes that something is wrong with the pizzeria and pretty soon finds the truth about its animatronics.", 1, new DateOnly(2023, 10, 27), "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTaydvBSSHZ_qYRr2QlfuisPN1JxzqmasvFmmuhCn9-vLzw6D1cY7NXscySkTHC80g2ASZKzSi2ATEICdak16TVc_kxIkeXFA", "Five Nights at Freddy's" },
                    { 7, "Anyone can survive five nights. This time, there will be no second chances.", 1, new DateOnly(2025, 12, 5), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQlGcWZganGfskXyYsVD1UMZmtaXp2y7nlxqJlWXAkAMSRYG6QgGZ-OCUAt77g7EC5Md-gD-7Ht8mV2OKFLj-nPQjUPW5a9DA", "Five Nights ar Freddy's 2" }
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
