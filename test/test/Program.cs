namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int  sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine($"Сумата на елементите: {sum}");
        }
    }
}
