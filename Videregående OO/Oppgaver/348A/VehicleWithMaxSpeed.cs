namespace _348A
{
    internal class VehicleWithMaxSpeed : Vehicle
    {
        private readonly int _maxSpeed;
        public VehicleWithMaxSpeed(int effect, string characteristics, int maxSpeed) : base(effect, characteristics)
        {
            _maxSpeed = maxSpeed;
        }

        public virtual void Show()
        {
            base.Show();
            Console.WriteLine($"Maksfart {_maxSpeed}km/t");
        }
    }
}
