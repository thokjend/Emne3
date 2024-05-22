namespace FallingParticles
{
    internal class Paddle
    {
        public int paddlePosition;
        public int paddleMoveDistance = 6;
        public string paddle = "========";

        public void Move()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                var moveLeft = key.Key == ConsoleKey.LeftArrow && paddlePosition >= paddleMoveDistance;
                var moveRight = key.Key == ConsoleKey.RightArrow && paddlePosition < Console.WindowWidth - paddle.Length;
                if (moveLeft || moveRight)
                {
                    var direction = moveLeft ? -1 : 1;
                    paddlePosition += direction * 3 * paddle.Length / 4;
                }
            }
        }
    }
}
