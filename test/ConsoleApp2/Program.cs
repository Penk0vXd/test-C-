namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int broj = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 9)
                {
                    broj++;
                }
            }
            Console.WriteLine($"Числото 9 се среща {broj} пъти");
        }
    }
}
