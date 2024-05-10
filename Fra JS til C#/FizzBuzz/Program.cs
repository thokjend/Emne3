namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                return;
            }

            int amount = int.Parse(args[0]);

            for (int i = 1; i <= amount; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
