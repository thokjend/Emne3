namespace _341B
{
    internal class ClickerGame
    {
        private int _points = 0;
        private int _pointsPerClick = 1;
        private int _pointsPerClickIncrease = 1;

        public void ShowStartMessage()
        {
            Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n"
                              + " - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       "
                              + "koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       "
                              + "øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       "
                              + "koster 100 poeng\r\n - X = avslutt applikasjonen\r\n"
                              + " - J = Juks \r\n       øker poeng med 1000");
        }
        public void DisplayPoints()
        {
            Console.WriteLine($"Du har {_points} poeng.");
        }

        public void DisplayCommandMessage()
        {
            Console.WriteLine("Trykk tast for ønsket kommando.");
        }

        public void Cheat()
        {
            _points += 1000;
        }
        public void Click()
        {
            _points += _pointsPerClick;
        }

        public void BuyUpgrade()
        {
            if (_points < 10) return;
            _points -= 10;
            _pointsPerClick += _pointsPerClickIncrease;
        }

        public void BuySuperUpgrade()
        {
            if (_points < 100) return;
            _points -= 100;
            _pointsPerClickIncrease++;
        }



    }
}
