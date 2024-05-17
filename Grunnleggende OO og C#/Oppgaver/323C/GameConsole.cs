namespace _323C
{
    internal class GameConsole
    {
        public void Show(Board board)
        {
            var chars = " xo";
            Console.WriteLine("  a b c");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine($"1│{chars[board.squares[0].state]}    │");
            Console.WriteLine("2│    o│");
            Console.WriteLine("3│× ×  │");
            Console.WriteLine(" └─────┘");
        }
    }
}
