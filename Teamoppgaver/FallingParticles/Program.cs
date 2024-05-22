﻿using FallingParticles;

class Program
{
    static int paddlePosition;
    static int paddleMoveDistance = 6;
    static string paddle = "========";
    static List<Particle> particles = new List<Particle>();
    static int level;
    static int score;
    static int gameRoundsBetweenSpawn;
    static readonly Random random = new Random();

    static void Main()
    {
        var paddle = new Paddle();

        Console.CursorVisible = false;
        Console.WindowWidth = 80;

        while (true)
        {
            InitializeGame();
            var levelCount = 0;
            var roundCount = 45;
            while (!CheckLostParticle())
            {
                DrawGame();
                paddle.Move();
                MoveParticles();
                if (roundCount >= gameRoundsBetweenSpawn)
                {
                    SpawnParticles();
                    InitGameRoundsBetweenSpawn();
                    roundCount = 0;
                }

                roundCount++;
                levelCount++;
                if (levelCount == 100)
                {
                    levelCount = 0;
                    level++;
                }
                Thread.Sleep(100);
            }
            var text = "Game Over! Press ENTER to restart";
            Console.SetCursorPosition(40 - text.Length / 2, 5);
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }

    static void InitializeGame()
    {
        var centerX = Console.WindowWidth / 2;
        paddlePosition = centerX - (centerX % paddleMoveDistance);
        particles.Clear();
        score = 0;
        level = 1;
        InitGameRoundsBetweenSpawn();
    }

    static void InitGameRoundsBetweenSpawn()
    {
        gameRoundsBetweenSpawn = 50 / level;
    }

    static void DrawGame()
    {
        Console.Clear();
        Console.SetCursorPosition(60, 0);
        Console.Write($"Score: {score}");
        Console.SetCursorPosition(71, 0);
        Console.Write($"Level: {level}");
        Console.SetCursorPosition(paddlePosition, Console.WindowHeight - 1);
        Console.Write(paddle);

        foreach (var particle in particles)
        {
            var particleX = (int)Math.Floor(particle.X);
            var particleY = (int)Math.Floor(particle.Y);
            Console.SetCursorPosition(particleX, particleY);
            Console.Write("O");
        }
    }

    static void MoveParticles()
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

    static bool CheckLostParticle()
    {
        foreach (var particle in particles)
        {
            if ((particle.X < paddlePosition || particle.X > paddlePosition + paddle.Length)
                && particle.Y == Console.WindowHeight - 1)
            {
                return true;
            }
        }

        return false;
    }

    static void SpawnParticles()
    {
        var newParticle = new Particle
        {
            X = random.Next(0, Console.WindowWidth),
            Y = 0
        };
        particles.Add(newParticle);
    }
}