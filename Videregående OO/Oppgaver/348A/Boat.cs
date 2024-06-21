namespace _348A
{
    internal class Boat : VehicleWithMaxSpeed
    {
        private readonly int _tonnageUnits;

        public Boat(string characteristics, int effect, int maxSpeed, int tonnageUnits)
            : base(effect, characteristics, maxSpeed)
        {
            _tonnageUnits = tonnageUnits;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"bruttotonnasje: {_tonnageUnits}kg");
        }
    }
}
