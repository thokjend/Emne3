namespace _348A
{
    internal class Airplane : Vehicle
    {
        private readonly int _wingspan;
        private readonly int _loadCapacity;
        private readonly int _specificWeight;
        private readonly string _type;

        public Airplane(string characteristics, int effect, int wingspan, int loadCapacity, int specificWeight, string type) 
            : base(effect, characteristics)
        {
            _wingspan = wingspan;
            _loadCapacity = loadCapacity;
            _specificWeight = specificWeight;
            _type = type;
        }

        public override void Move()
        {
            Console.WriteLine($"{_characteristics} is flying");
        }

    }
}
