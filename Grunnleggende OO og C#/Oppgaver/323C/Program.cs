namespace _323C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            var gameConsole = new GameConsole();

            gameConsole.Show(board);
        }
    }
}
