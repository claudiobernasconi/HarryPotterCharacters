using CommandDotNet.Attributes;
using ConsoleTables;
using System.Linq;

namespace HarryPotterCharacters
{
    public class HarryPotterChars
    {
        [ApplicationMetadata(Description = "Lists the films")]
        public void Films()
        {
            ConsoleTable
                .From(Movies.GetMovies())
                .Write();
        }

        [ApplicationMetadata(Description = "Lists the individual wizards")]
        public void Wizards(string house = "")
        {
            var characters = Characters.GetCharacters()
                .Where(wizard => wizard.House.Contains(house));

            ConsoleTable
               .From(characters)
               .Write();
        }
    }
}
