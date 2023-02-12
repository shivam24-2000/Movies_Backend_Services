using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        /*public static List<Movie> movies = new List<Movie>()
        {
            new Movie { Id = 1, Name = "Passion Of Christ", Cost = 2},
            new Movie { Id = 2, Name = "Home Alone", Cost= 3}

        };*/
        public readonly MovieDbContext _movieDbContext;

        public MovieRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }


        public  List<Movie> AddMovie(Movie movie)
        {
            /*movies.Add(movie);
            return movies; */

            _movieDbContext.Movies.Add(movie);
            _movieDbContext.SaveChanges();
            return _movieDbContext.Movies.ToList();
        }

         public  List<Movie> DeleteMovie(int id)
         {
             var movieDelete = _movieDbContext.Movies.Find(id);
             if( movieDelete is null) {
                 return null;
             }
             _movieDbContext.Remove(movieDelete);
              _movieDbContext.SaveChanges();

             return   _movieDbContext.Movies.ToList();
         }

        public List<Movie> GetAllMovies()
        {
           // return movies;

            return _movieDbContext.Movies.ToList();
        }

        public List<Movie> MovieChanges(int id, Movie request)
        {
            //var movieS = movies.Find(x => x.Id == id);
            var movieS = _movieDbContext.Movies.Find(id);
            if( movieS == null)
            { 
                return null; 
            }

            movieS.Name = request.Name;
            movieS.Cost = request.Cost;
            _movieDbContext.SaveChanges();

            return _movieDbContext.Movies.ToList();

        }

        public Movie MovieGetMovieById(int id)
        {
            var moviesss  = _movieDbContext.Movies.Find(id);
            if(moviesss == null)
            {
                return null;
            }

            return moviesss;
        }
    }
}
