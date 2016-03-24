using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using FoodyRater.Web.Models;

namespace FoodyRater.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private ApplicationDbContext _context;

        public RestaurantsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Restaurants
        public IActionResult Index()
        {
            return View(_context.Restaurant.ToList());
        }

        // GET: Restaurants/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Restaurant restaurant = _context.Restaurant.Single(m => m.Id == id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }

            return View(restaurant);
        }

        // GET: Restaurants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Restaurants/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _context.Restaurant.Add(restaurant);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }

        // GET: Restaurants/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Restaurant restaurant = _context.Restaurant.Single(m => m.Id == id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }

        // POST: Restaurants/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _context.Update(restaurant);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }

        // GET: Restaurants/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Restaurant restaurant = _context.Restaurant.Single(m => m.Id == id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }

            return View(restaurant);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Restaurant restaurant = _context.Restaurant.Single(m => m.Id == id);
            _context.Restaurant.Remove(restaurant);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
