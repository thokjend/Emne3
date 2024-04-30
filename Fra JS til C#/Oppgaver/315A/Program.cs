namespace _315A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 100);

            Console.WriteLine("Guess a number between 1 and 100");
            string guessStr = Console.ReadLine();
            int guess = Convert.ToInt32(guessStr);
            int guessCount = 0;

            while (number != guess)
            {
                guessCount++;
                if (guess < number)
                {
                    Console.WriteLine($"Too low, you guessed {guess} with a total of {guessCount} guesses. Try again!");
                }

                else if (guess > number)
                {
                    Console.WriteLine($"Too high, you guessed {guess} with a total of {guessCount} guesses. Try again!");
                }
                else
                {
                    Console.WriteLine($"You Won!, it took you {guessCount} guesses");
                }

            }

        }
    }
}
