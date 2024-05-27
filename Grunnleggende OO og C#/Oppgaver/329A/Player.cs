using System.Runtime.CompilerServices;

namespace _329A
{
    internal class Player
    {
        private string _name;
        private int _points;
        private readonly Random _random = new Random();

        public Player(string name, int points)
        {
            _name = name;
            _points = points;
        }

        public void Play(Player player2)
        {
            var drawRandomWinner = _random.Next(1);
            player2._points += drawRandomWinner == 1 ? 1 : -1;
            _points += drawRandomWinner == 0 ? 1 : -1;
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"{_name}: {_points} points");
        }
    }
}
