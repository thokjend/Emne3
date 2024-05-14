namespace _321C
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var coinCounts = new CoinCount[]
            {
                new CoinCount(1,7),
                new CoinCount(5,3),
                new CoinCount(10,2),
                new CoinCount(10,11),
            };

            var calculate = new CalculateSum();
            int sum = calculate.CalcSum(coinCounts);
            Console.WriteLine(sum);

        }
    }
}
