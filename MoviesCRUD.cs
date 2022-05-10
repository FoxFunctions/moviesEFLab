using System;
using moviesEFLab.models;
namespace moviesEFLab
{
	public class MoviesCRUD
	{
		public MoviesDbContext mc = new MoviesDbContext();
		public MoviesCRUD()
		{
		}

		public List<Movie> GetMovies()
        {
			return mc.Movies.ToList();
        }

		public void AddMovie(Movie m)
        {
			mc.Add(m);
			mc.SaveChanges();
        }
	}
}

