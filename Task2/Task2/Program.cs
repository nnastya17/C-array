using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 10, 10, 10, 10 };

            Console.WriteLine("Початковий масив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            int index_first = 0;
            int max = nums[0];
            int index_last = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Boolean count = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max && count==false)
                {
                    index_first = i;
                    count = true;
                }
            }
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] == max)
                {
                    index_last = i;
                    break;
                }
            }
            int result = index_last - index_first;
            Console.WriteLine();
            Console.WriteLine("Вiдстань мiж першим та останнiм максимальни елементом: " + result);
        }
    }
}
