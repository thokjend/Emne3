namespace _348A
{
    internal class Car : Vehicle
    {
        private readonly int _maxSpeed;
        private readonly string _color;
        private readonly string _type;

        public Car(string characteristics, int effect, int maxSpeed, string color, string type)
            : base(effect, characteristics)
        {
            _maxSpeed = maxSpeed;
            _color = color;
            _type = type;
        }

        public override void Show()
        {
            Console.WriteLine($"Reg.nr: {_characteristics}");
            Console.WriteLine($"Effekt: {_effect}kw");
            Console.WriteLine($"Maksfart {_maxSpeed}km/t");
            Console.WriteLine($"Farge: {_color}");
            Console.WriteLine($"kjøretøystype: {_type}");
        }


    }
}
