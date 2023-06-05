using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.DAL;
using MvcMovie.Models.ViewModels;

namespace MvcMovie.Controllers
{
	public class MoviesController : Controller
	{
		private readonly IUnitOfWork unitOfWork;
        public MoviesController(IUnitOfWork unitofWork)
		{
			this.unitOfWork = unitofWork;
		}

		public IActionResult List(int ratingID = 0)
		{
			var listMoviesVM = new ListMoviesViewModel();

			if (ratingID != 0)
			{
				listMoviesVM.Movies = unitOfWork.MovieRepository.Get(filter: f => f.RatingID == ratingID).ToList();
			
			}
			else
			{
				listMoviesVM.Movies = unitOfWork.MovieRepository.GetAll().ToList();
            }

			listMoviesVM.Ratings =
				new SelectList(unitOfWork.RatingRepository.GetAll(),
								"RatingID", "Name");
			listMoviesVM.ratingID = ratingID;

			return View(listMoviesVM);
		}

		public IActionResult Details(int id)
		{
            var movie = unitOfWork.MovieRepository.Get(
					filter: x => x.MovieID == id,
					includes: x => x.Rating).FirstOrDefault();

			return View(movie);


		}

		// GET: Movies/Create
		public IActionResult Create()
		{
			ViewData["Ratings"] =
				new SelectList(unitOfWork.RatingRepository.GetAll().OrderBy(r => r.Name),
							   "RatingID",
							   "Name");

			return View();
		}

		public IActionResult Add()
		{ 
			return View();
		}
	}
}