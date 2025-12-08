using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CCMovieDatabase.Models;
using System.Reflection;

namespace CCMovieDatabase.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<Rating> Ratings { get; set; } = default!;
        public DbSet<ActingCredit> ActingCredits { get; set; } = default!;
        public DbSet<CrewCredit> CrewCredits { get; set; } = default!;
        public DbSet<Article> Articles { get; set; } = default!;
        public DbSet<Character> Characters { get; set; } = default!;
        public DbSet<Person> Persons { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            var ratings = new List<Rating>
            {
                new Rating { RatingId = 1, Name = "PG-13" },
                new Rating { RatingId = 2, Name = "R" },
                new Rating { RatingId = 3, Name = "G" },
                new Rating { RatingId = 4, Name = "PG"}
            };
            modelBuilder.Entity<Rating>().HasData(ratings);

            // right here we seed data
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "Shrek", ReleaseDate = new DateOnly(2001, 04, 26), Description = "A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.", RatingId = 1, ThumbnailURL = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTG_q0A0cypAsXxYlgs5J_554BrcnjeeKExlQE3ZaZUuPYv0fUd" },
                new Movie { Id = 2, Title = "Shrek 2", ReleaseDate = new DateOnly(2002, 04, 26), Description = "Shrek is back baby!", RatingId = 1, ThumbnailURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTPx7lW6h0G1O9-npEnVPL07fT74Tp6SFl0i47nxfypyVBcQFdS" },
                
                //Aedon seed data

                 new Movie { Id = 3, Title = "Army of Darkness", ReleaseDate = new DateOnly(1993, 02, 19), Description = "When Ash Williams is accidentally transported to 1300 A.D., he must retrieve the Necronomicon and battle an army of the dead in order to return home.", RatingId = 2, ThumbnailURL = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.impawards.com%2F1993%2Fposters%2Farmy_of_darkness_ver3.jpg&f=1&nofb=1&ipt=0f5ba9f7dec46adcdb32748f094b542e4b5c8eff313c6811ef1bea9fde96af7d" },
                  new Movie { Id = 4, Title = "The Truman Show", ReleaseDate = new DateOnly(1998, 06, 05), Description = "An insurance salesman begins to suspect that his whole life is actually some sort of reality TV show.", RatingId = 4, ThumbnailURL = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fpostertok.com%2Fwp-content%2Fuploads%2F2024%2F02%2F5337.webp&f=1&nofb=1&ipt=0e1573f1b1d07b5daa12a781e53f49b27c130790c4d2dcde54916cc0eff9f901" },
                   new Movie { Id = 5, Title = "The Cable Guy", ReleaseDate = new DateOnly(1996, 06, 14), Description = "A designer makes a grievous mistake when he rejects the friendship of a borderline cable guy.", RatingId = 1, ThumbnailURL = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fc8.alamy.com%2Fcomp%2FBKG4ED%2Fthe-cable-guy-1996-poster-BKG4ED.jpg&f=1&nofb=1&ipt=04d76ad2b1e8ab66bd02da1ce264a9d679f0f2cad012d7c99c0ac192572af20b" },
                    new Movie { Id = 6, Title = "Spider-Man", ReleaseDate = new DateOnly(2002, 05, 03), Description = "After being bitten by a genetically-modified spider, a shy teenager gains spider-like abilities that he uses to fight injustice as a masked superhero and face a vengeful enemy.", RatingId = 1, ThumbnailURL = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Famc-theatres-res.cloudinary.com%2Fv1579117618%2Famc-cdn%2Fproduction%2F2%2Fmovies%2F3500%2F3499%2FPoster%2Fp_800x1200_Spider-Man_En_0802517.jpg&f=1&nofb=1&ipt=a5788d911cca9535bbb702afd5665df889150246b214e4f0394fc6f0a1e6f798" },
                     new Movie { Id = 7, Title = "The Nightmare Before Christmas", ReleaseDate = new DateOnly(1993, 10, 29), Description = "Jack Skellington, king of Halloween Town, discovers Christmas Town, but his attempts to bring Christmas to his home causes confusion.", RatingId = 4, ThumbnailURL = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.impawards.com%2F1993%2Fposters%2Fnightmare_before_christmas_ver1.jpg&f=1&nofb=1&ipt=a3fc758eba9bddd233e7d4e35b4511f5d2f2482e2d85d1589232c9d6a4c4efe6" },
            };

            modelBuilder.Entity<Movie>().HasData(movies);

            // article seed data
            var articles = new List<Article>
            { 
                new Article { ArticleId = 1, Title = "Welcome to CCMovieDatabase", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Slug = "hello_world", CreatedAt = new DateTime(2025, 11, 12), ModifiedAt = new DateTime(2025, 11, 12), Author = "Jesse", ThumbnailUrl = "https://craftypixels.com/placeholder-image/300", ShortDescription = "Lorem Ipsum and stuff", IsFeatured = true },
                new Article { ArticleId = 2, Title = "More Movies Added", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Slug = "hello_world2", CreatedAt = new DateTime(2025, 11, 12), ModifiedAt = new DateTime(2025, 11, 12), Author = "Jesse", ThumbnailUrl = "https://craftypixels.com/placeholder-image/300", ShortDescription = "Lorem Ipsum and stuff", IsFeatured = true },
                new Article { ArticleId = 3, Title = "For the love of movies", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Slug = "hello_world3", CreatedAt = new DateTime(2025, 11, 12), ModifiedAt = new DateTime(2025, 11, 12), Author = "Jesse", ThumbnailUrl = "https://craftypixels.com/placeholder-image/300", ShortDescription = "Lorem Ipsum and stuff", IsFeatured = true },
                new Article { ArticleId = 4, Title = "I wrote this", Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Slug = "hello_world4", CreatedAt = new DateTime(2025, 11, 12), ModifiedAt = new DateTime(2025, 11, 12), Author = "Jesse", ThumbnailUrl = "https://craftypixels.com/placeholder-image/300", ShortDescription = "Lorem Ipsum and stuff", IsFeatured = true },
            };

            modelBuilder.Entity<Article>().HasData(articles);


            var categories = new List<Category>()
            {
                new Category
                {
                    CategoryId = 1,
                    Name = "Computer Accessories"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Graphics Cards"
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Monitors"
                },
                new Category
                {
                    CategoryId = 4,
                    Name = "Hard Drives"
                }
            };

            modelBuilder.Entity<Category>().HasData(categories);

            var products = new List<Product>()
            {
                new Product
                {
                    ProductId = 1,
                    Name = "Dell Keyboard",
                    Description = "A simple mass produced keyboard",
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 2,
                    Name = "RTX 5090",
                    Description = "A very expensive video card",
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Dell Widescreen Monitor",
                    Description = "An enterprise widescreen monitor",
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 4,
                    Name = "WD Black Edition SSD",
                    Description = "Western Digital Black Edition SSD",
                    CategoryId = 4
                },
            };

            modelBuilder.Entity<Product>().HasData(products);

            modelBuilder.Entity<Category>().Navigation(c => c.Products).AutoInclude();
            modelBuilder.Entity<Product>().Navigation(p => p.Category).AutoInclude();
        }
    }
}
