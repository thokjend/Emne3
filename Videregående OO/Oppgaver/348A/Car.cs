namespace _348A
{
    internal class Car : VehicleWithMaxSpeed
    {
        private readonly string _color;
        private readonly string _type;

        public Car(string characteristics, int effect, int maxSpeed, string color, string type)
            : base(effect, characteristics, maxSpeed)
        {
            _color = color;
            _type = type;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Farge: {_color}");
            Console.WriteLine($"kjøretøystype: {_type}");
        }


    }
}
