using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Using foreach, write a program that displays on the screen the command line arguments
            // longer than 3 characters.
            // → Hint: the Length property also exists in the string type
            // If any argument is 8 characters or longer, the program 
            // terminates immediately without printing that argument and printing [EARLY STOP].

            // $ dotnet run --project RightSize -- varios 123 abc gamma
            // varios
            // gamma
            // $ dotnet run --project RightSize -- um mais 2 sete! 8933 arglongo!! favor
            // mais
            // sete!
            // 8933
            // [EARLY STOP]

            foreach (string arg in args)
            {
                if (arg.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }

                if (arg.Length > 3)
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }
}
