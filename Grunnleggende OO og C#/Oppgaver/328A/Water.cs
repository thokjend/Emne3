namespace _328A
{
    public class Water
    {
        public WaterState State { get; }
        public int Temperature { get; }
        public int Amount { get; }

        public Water(int amount, int temperature)
        {
            Temperature = temperature;
            Amount = amount;
            State = temperature <= 0 ? WaterState.Ice 
                    : Temperature > 100 ? WaterState.Gas
                    : WaterState.Fluid;
        }


    }
}
