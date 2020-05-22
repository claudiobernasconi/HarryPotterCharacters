using CommandDotNet;
using CommandDotNet.Rendering;

namespace HarryPotterCharacters
{
    [Command(Description = "Manage the films")]
    public class Films
    {
        [Command(Description = "Lists the films")]
        public void List(IConsole console)
        {
            console.WriteTable(Movies.GetMovies());
        }

        public void Add(IConsole console, int year, string title)
        {
            var movie = new Movie {Year = year, Title = title};
            console.Write($"film added: {movie.Title} ({year})");
        }
    }
}