using System.Collections.Generic;

namespace GroundUp.Models
{
    public interface IMoviesRepository
    {
        IEnumerable<Movie> GetAllMovies();
    }
}