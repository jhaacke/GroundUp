using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroundUp.Models
{
    public class MoviesRepository : IMoviesRepository
    {
        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _GetTestMovies();
            return result;
        }

        private IEnumerable<Movie> _GetTestMovies()
        {
            return new[]
            {
                new Movie
                {
                    Title = "Get Shorty",
                    Date = new DateTime(1987, 2, 22)
                },
                new Movie
                {
                    Title = "Pulp Fiction",
                    Date = new DateTime(1992, 07, 13)
                }
            };
        }
    }
}
