using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Create a program that:
            // Asks the user for a string
            // Asks the user for a character
            // Prints the string replacing the character with x
            // 3 Example:
            // String: How are you?
            // Character: o
            // Will be printed: Hxw are yxu?

            Console.Write("String: ");
            string inputString = Console.ReadLine();

            Console.Write("Character: ");
            char inputChar = Console.ReadLine()[0];

            string outputString = "";
            foreach (char c in inputString)
            {
                if (c == inputChar)
                    outputString += 'x';

                else
                    outputString += c;
            }

            Console.WriteLine(outputString);
        }
    }
}
