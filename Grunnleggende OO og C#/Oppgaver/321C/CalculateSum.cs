    namespace _321C
    {
        internal class CalculateSum
        {

            public int CalcSum(CoinCount[] coinCounts)
            {

                int sum = 0;
                for (int i = 0; i < coinCounts.Length; i++)
                {
                    sum += coinCounts[i].Value * coinCounts[i].Count;
                }

                return sum;
            }

        }
    }
