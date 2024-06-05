namespace _341B
{
    internal class CheatCommand : ICommand
    {
        private ClickerGame _game;
        public char Character { get; set; } = 'J';

        public CheatCommand(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.Cheat();
        }
    }
}
