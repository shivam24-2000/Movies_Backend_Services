using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Movie> AddMovie(Movie movie)
        {
            var movieADD = _movieRepository.AddMovie(movie);

            return movieADD;
        }

        public List<Movie> DeleteMovie(int id)
        {
            var DeletemovieSS = _movieRepository.DeleteMovie(id);
            return DeletemovieSS;
        }

        public List<Movie> GetAllMovies()
        {
            var movies =  _movieRepository.GetAllMovies();

            return movies;
        }

        public List<Movie> MovieChanges(int id, Movie movie)
        {
            var movieSS = _movieRepository.MovieChanges(id, movie);
            return movieSS;
        }

        public Movie MovieGetMovieById(int id)
        {
            var moviesss = _movieRepository.MovieGetMovieById(id);
            return moviesss;
        }
    }
}
