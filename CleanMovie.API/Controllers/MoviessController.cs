using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviessController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviessController(IMovieService movieService)
        {
            _movieService = movieService;
        }


        // GET: api/<MoviessController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var movieFromServices = _movieService.GetAllMovies();
            return Ok(movieFromServices);
        }

        [HttpGet("{id}")]

        public ActionResult<Movie> GetById(int id)
        {
            var moviesFromId = _movieService.MovieGetMovieById(id);
            if(moviesFromId == null)
            {
                return NotFound("Movies doesn't exists");
            }

            return Ok(moviesFromId);
        }

        [HttpPut("{id}")]

        public ActionResult<List<Movie>> UpdateMovies(int id, Movie movie )
        {
            var movieUpdate = _movieService.MovieChanges(id, movie);

            if(movieUpdate == null) { return NotFound(); }
            return Ok(movieUpdate);
        }

        [HttpPost]

        public ActionResult<List<Movie>> AddMovieS(Movie request)
        {
            var movieaDD = _movieService.AddMovie(request); 

            return Ok(movieaDD);

        }

        [HttpDelete("{id}")]

        public ActionResult<List<Movie>> Delete(int id) 
        { 
            var Deltee = _movieService.DeleteMovie(id);
            if( Deltee is null) 
            {
                return NotFound();
            }
            return Ok(Deltee);
        }
       
    }
}
