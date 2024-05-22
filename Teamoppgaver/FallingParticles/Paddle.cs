namespace FallingParticles
{
    internal class Paddle
    {
        public int Position;
        public int MoveDistance = 6;
        public string Shape = "========";

        public Paddle()
        {
            var centerX = Console.WindowWidth / 2;
            Position = centerX - (centerX % MoveDistance);
        }
        public void Move()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                var moveLeft = key.Key == ConsoleKey.LeftArrow && Position >= MoveDistance;
                var moveRight = key.Key == ConsoleKey.RightArrow && Position < Console.WindowWidth - Shape.Length;
                if (moveLeft || moveRight)
                {
                    var direction = moveLeft ? -1 : 1;
                    Position += direction * 3 * Shape.Length / 4;
                }
            }
        }
    }
}
