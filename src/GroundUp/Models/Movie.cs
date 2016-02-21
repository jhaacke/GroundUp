using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroundUp.Models
{
    public class Movie
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public ICollection<Actor> Actors { get; set; }
    }
}
