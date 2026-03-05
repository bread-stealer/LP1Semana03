using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Write a program that multiplies an A2×2 matrix by a b2×1 vector
            //→ The values, of type float, must be obtained through command line arguments, such that:
            //$ dotnet run --project ArrayMul -- arg1 arg2 arg3 arg4 arg5 arg6
            // Multiplication must be performed with a double for loop
            // → Numbers must be shown with 2 decimal places, aligned to the right and occupying 7 positions
            // → Imitating a vector, each number must have a bar on each side, with a margin of one space.
            // For example: |_-133.94_|

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            if (args.Length != 6)
            {
                Console.WriteLine("Provide exactly 6 arguments: arg1 arg 2 arg3 arg4 arg5 arg6");
                return;
            }

            // 2x2 matrix A and 2x1 b vector from args
            float[,] A = new float[2,2];
            float[] b = new float[2];

            A[0,0] = float.Parse(args[0]);
            A[0,1] = float.Parse(args[1]);
            A[1,0] = float.Parse(args[2]);
            A[1,1] = float.Parse(args[3]);
            b[0] = float.Parse(args[4]);
            b[1] = float.Parse(args[5]);

            float[] c = new float[2];
            for (int i = 0; i < 2; i++)
            {
                c[i] = 0;
                for (int j = 0; j < 2; j++)
                {
                    c[i] += A[i,j]*b[j];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"| {c[i],7:F2} |");
            }


        }
    }
}
