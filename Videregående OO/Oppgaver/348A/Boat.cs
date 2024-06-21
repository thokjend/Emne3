namespace _348A
{
    internal class Boat : Vehicle
    {
        private readonly int _maxSpeed;
        private readonly int _tonnageUnits;

        public Boat(string characteristics, int effect, int maxSpeed, int tonnageUnits)
            : base(effect, characteristics)
        {
            _maxSpeed = maxSpeed;
            _tonnageUnits = tonnageUnits;
        }

        public override void Show()
        {
            Console.WriteLine($"Kjennetegn: {_characteristics}");
            Console.WriteLine($"Effekt: {_effect}");
            Console.WriteLine($"Maksfart: {_maxSpeed}knop");
            Console.WriteLine($"bruttotonnasje: {_tonnageUnits}kg");
        }
    }
}
