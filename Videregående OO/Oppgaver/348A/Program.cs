namespace _348A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("NF123456", 147, 200, "green", "light");
            var car2 = new Car("NF654321", 150, 195, "blue", "light");
            var airplane = new Airplane("LN1234", 1000, 30, 2, 10, "jetfly");
            var boat = new Boat("ABC123", 100, 30, 500);

            boat.Show();

        }
    }
}
