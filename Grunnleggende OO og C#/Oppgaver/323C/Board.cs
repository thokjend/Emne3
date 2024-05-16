namespace _323C
{
    internal class Board
    {
        public Square[] squares;
        public Board()
        {
            squares = new Square[9];
            for (int i = 0; i < squares.Length; i++)
            {
                squares[i] = new Square();
            }
        }

    }
}
