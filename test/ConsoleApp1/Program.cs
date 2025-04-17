using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = nums.Min();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine($"Най - голямия елемент е: {max}");

        }
    }
}
