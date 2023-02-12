using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();

        Movie MovieGetMovieById(int id);

        List<Movie> MovieChanges(int id, Movie movie);

        List<Movie> AddMovie(Movie movie);

        List<Movie> DeleteMovie(int id);
    }
}
