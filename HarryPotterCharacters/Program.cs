using CommandDotNet;

namespace HarryPotterCharacters
{
    public class Program
    {
        static int Main(string[] args)
        {
            return BuildAppRunner().Run(args);
        }

        public static AppRunner<HarryPotterChars> BuildAppRunner()
        {
            return new AppRunner<HarryPotterChars>();
        }
    }
}
