﻿using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.DAL
{
    public class RatingRepository
    {
        private readonly MovieContext _context;

        public RatingRepository(MovieContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var rating = _context.Ratings.Find(id);
            _context.Ratings.Remove(rating);
        }

        public IEnumerable<Rating> GetAll()
        {
            return _context.Ratings.ToList();
        }

        public Rating GetByID(int id)
        {
            return _context.Ratings.Find(id);
        }

        public void Insert(Rating obj)
        {
            _context.Ratings.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Rating obj)
        {
            _context.Update(obj);
        }
    }
}
