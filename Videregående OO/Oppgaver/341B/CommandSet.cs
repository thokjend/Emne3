namespace _341B
{
    internal class CommandSet
    {
        private ICommand[] _commands;

        public CommandSet(ClickerGame game)
        {
            _commands = new ICommand[]
            {
                new ExitCommand(),
                new ClickCommand(game),
                new BuyUpgradeCommand(game),
                new BuySuperUpgradeCommand(game),
                new CheatCommand(game)
            };
        }

        public void RunCommand(char commandChar)
        {
            var command = FindCommand(commandChar);
            if (command != null) command.Run();
        }

        private ICommand FindCommand(char commandChar)
        {
            foreach (var command in _commands)
            {
                if (command.Character == commandChar) return command;
            }

            return null;
        }
    }
}
