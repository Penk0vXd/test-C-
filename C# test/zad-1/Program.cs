namespace zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            int max = int.MinValue;
            int broj = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];

                if (num[i] > max)
                {
                    max = num[i];
                }

                if (num[i] == 9)
                {
                    broj++;
                }
            }
            Console.WriteLine($"Сумата на елементите: {sum}");
            Console.WriteLine($"Най - голямия елемент е: {max}");
            Console.WriteLine($"Числото 9 се среща {broj} пъти");
        }
    }
}
