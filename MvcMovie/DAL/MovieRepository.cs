using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.DAL
{
    public class MovieRepository 
    {
        private readonly MovieContext _context;
        public MovieRepository(MovieContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var movie = _context.Movies.Find(id);
            _context.Movies.Remove(movie);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies.Include(v => v.Rating).ToList();
        }

        public Movie GetByID(int id)
        {
            return _context.Movies.Include(r => r.Rating).FirstOrDefault(i => i.MovieID == id);
        }

        public void Insert(Movie obj)
        {
            _context.Movies.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Movie obj)
        {
            _context.Update(obj);
        }

    }
}
