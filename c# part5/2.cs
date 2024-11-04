using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
    public class Movie
    {
        public string Title;
        public int Year;

        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }

    }
    public class MovieLibrary
    {
        public Movie[] movies = new Movie[4];
        public void Add(Movie movie, int index)
        {
            movies[index] = movie;
        }
        public void Display()
        {
            foreach (var movie in movies)
            {
                Console.WriteLine($"title:{movie.Title},year:{movie.Year}");
            }
        }

    }
}
