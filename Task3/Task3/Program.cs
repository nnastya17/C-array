using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {
                { 2, 4, 3, 3 },
                { 5, 7, 8, 5 },
                { 2, 4, 3, 3 },
                { 5, 7, 8, 5 }
            };
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i > j)
                    {
                        arr[i, j] = 0;
                    }
                    else if (i < j)
                    {
                        arr[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.Write("\n");
            }
        }
    }
}
