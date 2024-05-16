namespace _323C
{
    internal class GameConsole
    {
        public void Show(Board board)
        {
            Console.WriteLine("  a b c");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine("1│o    │");
            Console.WriteLine("2│    o│");
            Console.WriteLine("3│× ×  │");
            Console.WriteLine(" └─────┘");
        }
    }
}
