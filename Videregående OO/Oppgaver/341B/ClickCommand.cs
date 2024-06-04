namespace _341B
{
    internal class ClickCommand : ICommand
    {
        private ClickerGame _game;
        public char Character { get; set; } = ' ';

        public ClickCommand(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.Click();
        }
    }
}
