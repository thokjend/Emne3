using System;
using System.Reflection.Metadata;

namespace FallingParticles
{
    internal class Game
    {
        public int level;
        public int score;
        public int gameRoundsBetweenSpawn;
        public int roundCount;
        public int levelCount;
        public List<Particle> particles;

        private readonly Paddle _paddle;

        readonly Random random = new Random();

        public Game(Paddle paddle)
        {
            _paddle = paddle;
            level = 1;
            score = 0;
            roundCount = 45;
            levelCount = 0;
            particles = new List<Particle>();
            gameRoundsBetweenSpawn = 50 / level;
        }

        public void IncreaseLevel()
        {
            if (levelCount == 100)
            {
                levelCount = 0;
                level++;
            }
        }

        public void RoundCount()
        {
            if (roundCount >= gameRoundsBetweenSpawn)
            {
                SpawnParticle();
                RoundsBetweenSpawn();
                roundCount = 0;
            }

            roundCount++;
            levelCount++;
        }

        public void RoundsBetweenSpawn()
        {
            gameRoundsBetweenSpawn = 50 / level;
        }

        public void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(60, 0);
            Console.Write($"Score: {score}");
            Console.SetCursorPosition(71, 0);
            Console.Write($"Level: {level}");
            Console.SetCursorPosition(_paddle.Position, Console.WindowHeight - 1);
            Console.Write(_paddle.Shape);

            foreach (var particle in particles)
            {
                var particleX = (int)Math.Floor(particle.X);
                var particleY = (int)Math.Floor(particle.Y);
                Console.SetCursorPosition(particleX, particleY);
                Console.Write("O");
            }
        }

        public void MoveParticles()
        {
            for (var index = particles.Count - 1; index >= 0; index--)
            {
                var particle = particles[index];
                particle.Y += 0.5f;
                if (particle.Y > Console.WindowHeight - 1)
                {
                    score++;
                    particles.Remove(particle);
                }
            }
        }

        public bool CheckLostParticle()
        {
            foreach (var particle in particles)
            {
                if ((particle.X < _paddle.Position || particle.X > _paddle.Position + _paddle.Shape.Length)
                    && particle.Y == Console.WindowHeight - 1)
                {
                    return true;
                }
            }

            return false;
        }

        public void SpawnParticle()
        {
            var newParticle = new Particle
            {
                X = random.Next(0, Console.WindowWidth),
                Y = 0
            };
            particles.Add(newParticle);
        }



    }
}
