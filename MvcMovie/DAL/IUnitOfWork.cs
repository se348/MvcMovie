using MvcMovie.Models;

namespace MvcMovie.DAL
{
    public interface IUnitOfWork
    {
        IRepository<Rating> RatingRepository { get; }
        IRepository<Movie> MovieRepository { get; }

        void save();
    }
}
