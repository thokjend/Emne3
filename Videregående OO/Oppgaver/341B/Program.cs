namespace _341B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new ClickerGame();
            var commands = new CommandSet(game);

            while (true)
            {
                Console.Clear();
                game.ShowStartMessage();
                game.DisplayPoints();
                game.DisplayCommandMessage();
                var command = Console.ReadKey().KeyChar;
                commands.RunCommand(command);

            }
        }
    }
}
