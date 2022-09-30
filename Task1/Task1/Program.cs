using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 100, 2, 3, 45, 33, 8, 4, 54 };

            Console.WriteLine("Початковий масив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int a = nums[i];
                int b = nums[nums.Length - 1 - i];
                if(a%2==0 && b % 2 == 0) {
                    result[i] = b;
                    result[nums.Length - 1 - i] = a;
                }
                else
                {
                    result[i] = a;
                    result[nums.Length - 1 - i] = b;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Змiнений масив: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
