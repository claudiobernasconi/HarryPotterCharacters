using CommandDotNet.TestTools.Scenarios;
using NUnit.Framework;

namespace HarryPotterCharacters.Tests
{
    public class FilmsTests
    {
        [Test]
        public void List_outputs_all_films_in_table()
        {
            Program.BuildAppRunner()
                .Verify(new Scenario
                {
                    When = {Args = "Films List"},
                    Then =
                    {
                        Output = @" -------------------------------------------------------- 
 | Title                                         | Year |
 -------------------------------------------------------- 
 | Harry Potter and the Philosopher's Stone      | 2001 |
 -------------------------------------------------------- 
 | Harry Potter and the Chamber of Secrets       | 2002 |
 -------------------------------------------------------- 
 | Harry Potter and the Prisoner of Azkaban      | 2004 |
 -------------------------------------------------------- 
 | Harry Potter and the Goblet of Fire           | 2005 |
 -------------------------------------------------------- 
 | Harry Potter and the Order of the Phoenix     | 2007 |
 -------------------------------------------------------- 
 | Harry Potter and the Half-Blood Prince        | 2009 |
 -------------------------------------------------------- 
 | Harry Potter and the Deathly Hallows – Part 1 | 2010 |
 -------------------------------------------------------- 
 | Harry Potter and the Deathly Hallows – Part 2 | 2011 |
 -------------------------------------------------------- 

 Count: 8"
                    }
                });
        }

        [Test]
        public void Add_adds_film()
        {
            Program.BuildAppRunner()
                .Verify(new Scenario
                {
                    When = {Args = "Films Add 2020 \"the best yet\""},
                    Then = {Output = "film added: the best yet (2020)"}
                });
        }
    }
}
