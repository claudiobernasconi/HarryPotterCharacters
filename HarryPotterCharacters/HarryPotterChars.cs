using CommandDotNet;
using System.Linq;
using CommandDotNet.Rendering;

namespace HarryPotterCharacters
{
    public class HarryPotterChars
    {
        [Command(Description = "Lists the films")]
        public void Films(IConsole console)
        {
            console.WriteTable(Movies.GetMovies());
        }

        [Command(Description = "Lists the individual wizards")]
        public void Wizards(IConsole console, string house = "")
        {
            var characters = Characters.GetCharacters()
                .Where(wizard => wizard.House.Contains(house));
            console.WriteTable(characters);
        }
    }
}
