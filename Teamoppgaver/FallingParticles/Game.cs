namespace FallingParticles
{
    internal class Game
    {
        private int _level;
        private int _score;
        private int _gameRoundsBetweenSpawn;
        private int _roundCount;
        private int _levelCount;

        private readonly List<Particle> _particles;
        private readonly Paddle _paddle;
        private readonly Random _random = new Random();

        public Game(Paddle paddle)
        {
            _paddle = paddle;
            _level = 1;
            _score = 0;
            _roundCount = 45;
            _levelCount = 0;
            _particles = new List<Particle>();
            _gameRoundsBetweenSpawn = 50 / _level;
        }

        public void IncreaseLevel()
        {
            if (_levelCount == 100)
            {
                _levelCount = 0;
                _level++;
            }
        }

        public void RoundCount()
        {
            if (_roundCount >= _gameRoundsBetweenSpawn)
            {
                SpawnParticle();
                RoundsBetweenSpawn();
                _roundCount = 0;
            }

            _roundCount++;
            _levelCount++;
        }

        private void RoundsBetweenSpawn()
        {
            _gameRoundsBetweenSpawn = 50 / _level;
        }

        public void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(60, 0);
            Console.Write($"Score: {_score}");
            Console.SetCursorPosition(71, 0);
            Console.Write($"Level: {_level}");
            Console.SetCursorPosition(_paddle.Position, Console.WindowHeight - 1);
            Console.Write(_paddle.Shape);

            foreach (var particle in _particles)
            {
                var particleX = (int)Math.Floor(particle.X);
                var particleY = (int)Math.Floor(particle.Y);
                Console.SetCursorPosition(particleX, particleY);
                Console.Write("O");
            }
        }

        public void MoveParticles()
        {
            for (var index = _particles.Count - 1; index >= 0; index--)
            {
                var particle = _particles[index];
                particle.Y += 0.5f;
                if (particle.Y > Console.WindowHeight - 1)
                {
                    _score++;
                    _particles.Remove(particle);
                }
            }
        }

        public bool CheckLostParticle()
        {
            foreach (var particle in _particles)
            {
                if ((particle.X < _paddle.Position || particle.X > _paddle.Position + _paddle.Shape.Length)
                    && particle.Y == Console.WindowHeight - 1)
                {
                    return true;
                }
            }

            return false;
        }

        private void SpawnParticle()
        {
            var newParticle = new Particle
            {
                X = _random.Next(0, Console.WindowWidth),
                Y = 0
            };
            _particles.Add(newParticle);
        }



    }
}
