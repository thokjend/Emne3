namespace _321C
{
    internal class CoinCount
    {
        private int Value;
        private int Count;


        public CoinCount(int value , int count)
        {
            Value = value;
            Count = count;
        }

        public int GetSum()
        {
            return Value * Count;
        }

    }
}
