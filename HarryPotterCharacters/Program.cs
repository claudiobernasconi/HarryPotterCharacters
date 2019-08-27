using CommandDotNet;

namespace HarryPotterCharacters
{
    class Program
    {
        static int Main(string[] args)
        {
            AppRunner<HarryPotterChars> appRunner = new AppRunner<HarryPotterChars>();
            return appRunner.Run(args);
        }
    }
}
