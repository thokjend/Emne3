namespace _348A
{
    internal class Vehicle
    {
        protected readonly int _effect;
        protected internal readonly string _characteristics;

        public Vehicle(int effect, string characteristics)
        {
            _effect = effect;
            _characteristics = characteristics;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Reg.nr: {_characteristics}");
            Console.WriteLine($"Effekt: {_effect}kw");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{_characteristics} is driving");
        }

        public void CheckIfSameVehicle(Vehicle vehicle)
        {
            if (_characteristics == vehicle._characteristics)
            {
                Console.WriteLine("This is the same vehicle");
            }
            else
            {
                Console.WriteLine("not the same vehicle");
            }
        }

    }
}
