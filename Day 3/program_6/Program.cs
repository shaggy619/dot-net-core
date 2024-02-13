using System;

namespace program_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** MULTI-DIMENSIONAL ARRAY IN C# *****/

            pixels();
            Console.ReadLine();
        }

        static void pixels()
        {
            int[,] pixelPoints = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 }, { 4, 5, 6, 7 } }; // Multi-dimensional array

            for (int x = 0; x < pixelPoints.GetLength(0); x++) //The GetLength(0) method is used to get the length of the first dimension of a multi - dimensional array.
            {
                for (int y = 0; y < pixelPoints.GetLength(1); y++) //The GetLength(1) method is used to get the length of the second dimension of a multi-dimensional array.
                {
                    Console.WriteLine($"Pixel at ({x}, {y}): {pixelPoints[x, y]}");
                }
            }
        }
    }
}
