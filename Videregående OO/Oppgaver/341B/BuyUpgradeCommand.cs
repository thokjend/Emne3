namespace _341B
{
    internal class BuyUpgradeCommand : ICommand
    {
        private ClickerGame _game;
        public char Character { get; set; } = 'K';

        public BuyUpgradeCommand(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.BuyUpgrade();
        }
    }

}
