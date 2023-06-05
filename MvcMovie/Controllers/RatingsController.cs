using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.DAL;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class RatingsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public RatingsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;  
        }

        // GET: Ratings/List
        public IActionResult List()
        {
            var ratings = unitOfWork.RatingRepository.GetAll().OrderBy(r => r.Name);

            return View(ratings.ToList());
        }

        // GET: Ratings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ratings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("RatingID,Code,Name")] Rating rating)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.RatingRepository.Insert(rating);
                unitOfWork.save();
                return RedirectToAction("List");
            }
            return View(rating);
        }

        // GET: Ratings/Edit/5
        public IActionResult Edit(int id)
        {
            var rating = unitOfWork.RatingRepository.GetByID(id);

            return View(rating);
        }

        // POST: Ratings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("RatingID,Code,Name")] Rating rating)
        {
			if (ModelState.IsValid)
            {
                try
                {
                    unitOfWork.RatingRepository.Update(rating);
                    unitOfWork.save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction("List");
            }
            return View(rating);
        }

        // GET: Ratings/Delete/5
        public IActionResult Delete(int id)
        {
            unitOfWork.RatingRepository.Delete(id);
            unitOfWork.save();
            return RedirectToAction("List");
        }

    }
}
