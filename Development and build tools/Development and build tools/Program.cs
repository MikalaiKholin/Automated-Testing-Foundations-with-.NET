using System;

namespace Development_and_build_tools
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int maxDifferentSymbols = 1;
            for (int i = 0; i < args[0].Length-1; i++)
            {
                if (args[0][i] != args[0][i + 1]) maxDifferentSymbols++;
                if (args[0][i] == args[0][i + 1])
                {
                    if (result<maxDifferentSymbols) result = maxDifferentSymbols;
                    maxDifferentSymbols = 1;
                }

            }

            if (result > maxDifferentSymbols)
            {
                Console.WriteLine(result);
            }
            else Console.WriteLine(maxDifferentSymbols);
        }
    }
}
