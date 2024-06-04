namespace _341B
{
    internal class BuySuperUpgradeCommand : ICommand
    {
        private ClickerGame _game;
        public char Character { get; set; } = 'S';

        public BuySuperUpgradeCommand(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.BuySuperUpgrade();
        }
    }
}
