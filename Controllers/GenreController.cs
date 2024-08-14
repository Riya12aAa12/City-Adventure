using Microsoft.AspNetCore.Mvc;
using MovieStoreMvc.Models.Domain;

namespace MovieStoreMvc.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Genre model)
        {
            if (ModelState.IsValid)
            {
                // Code to save the genre to the database (e.g., using Entity Framework)

                // Example:
                // _context.Genres.Add(model);
                // _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
