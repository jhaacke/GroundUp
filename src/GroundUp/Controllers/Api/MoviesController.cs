using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using GroundUp.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GroundUp.Controllers.Api
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private IMoviesRepository _repository;

        public MoviesController(IMoviesRepository repository)
        {
            _repository = repository;
        }

        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            var movies = _repository.GetAllMovies();
            return Json(movies);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return Json(new { name = "JoBob" });
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
