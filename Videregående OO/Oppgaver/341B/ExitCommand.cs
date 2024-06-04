namespace _341B
{
    internal class ExitCommand : ICommand
    {
        public char Character { get; set; } = 'X';

        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
