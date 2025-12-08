using CCMovieDatabase.Data;
using CCMovieDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CCMovieDatabase.Controllers
{
    public class JamelsController1 : Controller
    {
        private readonly MovieContext _context;

        public JamelsController1(MovieContext context)
        {
            _context = context;
        }

       // i could not figure out how to only display movies and descriptions separately so I put into comments the code I wrote that did not work
       // the titles and descriptions show up but i could not get them separately 
        public async Task<IActionResult> Index()
        {
            var movieContext = _context.Movie.Include(m => m.Rating);
            return View(await movieContext.ToListAsync());

            //var movieContext = _context.Movie.Include(m => m.Title);
            //return View(await movieContext.ToListAsync());

        }
        // this code works
        public async Task<IActionResult> Index2()
        {
            var movieContext = _context.Movie.Include(m => m.Description);
            return View(await movieContext.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .Include(m => m.Rating)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

       
        public IActionResult Create()
        {
            ViewData["RatingId"] = new SelectList(_context.Ratings, "RatingId", "RatingId");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,ReleaseDate,RatingId")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RatingId"] = new SelectList(_context.Ratings, "RatingId", "RatingId", movie.RatingId);
            return View(movie);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            ViewData["RatingId"] = new SelectList(_context.Ratings, "RatingId", "RatingId", movie.RatingId);
            return View(movie);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,ReleaseDate,RatingId")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RatingId"] = new SelectList(_context.Ratings, "RatingId", "RatingId", movie.RatingId);
            return View(movie);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .Include(m => m.Rating)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            if (movie != null)
            {
                _context.Movie.Remove(movie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}

