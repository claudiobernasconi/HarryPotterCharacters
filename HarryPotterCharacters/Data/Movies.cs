using System.Collections.Generic;

namespace HarryPotterCharacters
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
    }

    public static class Movies
    {
        public static IEnumerable<Movie> GetMovies()
        {
            yield return new Movie
            {
                Title = "Harry Potter and the Philosopher's Stone",
                Year = 2001
            };
            yield return new Movie
            {
                Title = "Harry Potter and the Chamber of Secrets",
                Year = 2002
            };
            yield return new Movie
            {
                Title = "Harry Potter and the Prisoner of Azkaban",
                Year = 2004
            };
            yield return new Movie
            {
                Title = "Harry Potter and the Goblet of Fire",
                Year = 2005
            };
            yield return new Movie
            {
                Title = "Harry Potter and the Order of the Phoenix",
                Year = 2007
            };
            yield return new Movie
            {
                Title = "Harry Potter and the Half-Blood Prince",
                Year = 2009
            };
            yield return new Movie
            {
                Title = "Harry Potter and the Deathly Hallows – Part 1",
                Year = 2010
            };
            yield return new Movie
            {
                Title = "Harry Potter and the Deathly Hallows – Part 2",
                Year = 2011
            };
        }
    }
}
