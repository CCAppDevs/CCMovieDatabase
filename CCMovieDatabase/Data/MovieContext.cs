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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var ratings = new List<Rating>
            {
                new Rating { RatingId = 1, Name = "PG-13" },
                new Rating { RatingId = 2, Name = "R" },
                new Rating { RatingId = 3, Name = "G" },
                new Rating { RatingId = 4, Name = "PG" }
            };
            modelBuilder.Entity<Rating>().HasData(ratings);

            // right here we seed data
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "Shrek", ReleaseDate = new DateOnly(2001, 04, 26), Description = "A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.", RatingId = 1, ThumbnailURL = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTG_q0A0cypAsXxYlgs5J_554BrcnjeeKExlQE3ZaZUuPYv0fUd" },
                new Movie { Id = 2, Title = "Shrek 2", ReleaseDate = new DateOnly(2002, 04, 26), Description = "Shrek is back baby!", RatingId = 1, ThumbnailURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTPx7lW6h0G1O9-npEnVPL07fT74Tp6SFl0i47nxfypyVBcQFdS" },
                new Movie { Id = 3, Title = "Harry Potter and the Sorcerer's Stone", ReleaseDate = new DateOnly(2001,01,01), Description = "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.", RatingId = 4, ThumbnailURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQcZT3sdwr1NiJytvJb95icJJKPWpWRNv35l_uuVYxjlzBJS-hb" },
                new Movie { Id = 4, Title = "Toy Story", ReleaseDate = new DateOnly(1995,01,01), Description = "A cowboy doll is profoundly jealous when a new spaceman action figure supplants him as the top toy in a boy's bedroom.", RatingId = 3, ThumbnailURL = "https://m.media-amazon.com/images/M/MV5BZTA3OWVjOWItNjE1NS00NzZiLWE1MjgtZDZhMWI1ZTlkNzYwXkEyXkFqcGc@._V1_.jpg"  },
                new Movie { Id = 5, Title = "A Christmas Story", ReleaseDate = new DateOnly(1983,01,01), Description = "In the 1940s, a young boy named Ralphie Parker attempts to convince his parents, teacher, and Santa Claus that a Red Ryder Range 200 Shot BB gun really is the perfect Christmas gift.", RatingId = 4, ThumbnailURL = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSUZk92ju8kisZKCc9m4lyySg9S5RSM6mhFnSWOpOb1_MlCsHsw" },
                new Movie { Id = 6, Title = "Elf", ReleaseDate = new DateOnly(2003,01,01), Description = "Raised as an oversized elf, Buddy travels from the North Pole to New York City to meet his biological father, Walter Hobbs, who doesn't know he exists and is in desperate need of some Christmas spirit.", RatingId = 4, ThumbnailURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcT08ZFpbAwAL_jQFtQfMjut1_T6oNgxRCQiOPA6S1twJLXZq_Wi" },
                new Movie { Id = 7, Title = "Weapons", ReleaseDate = new DateOnly(2025,01,01), Description = "When all but one child from the same class mysteriously vanish on the same night at exactly the same time, a community is left questioning who or what is behind their disappearance.", RatingId = 2, ThumbnailURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR84Bm2XnTfW7hukdkEdr5jezVGfoIt22h0-s7Dfk1aRavoPZmh" }

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

        }
    }
}
