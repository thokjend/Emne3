namespace _323C
{
    internal class Square
    {
        public int state;
        public bool IsEmpty()
        {
            return state == 0;
        }

        public bool IsTakenByPlayer1()
        {
            return state == 1;
        }

        public void SetSquare(bool isPlayer1)
        {
            if (state == 0)
            {
                state = isPlayer1 ? 1 : 2;
            }
        }
    }
}
