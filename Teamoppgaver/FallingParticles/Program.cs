﻿using FallingParticles;

class Program
{
    static void Main()
    {
        var paddle = new Paddle();

        Console.CursorVisible = false;
        Console.WindowWidth = 80;

        while (true)
        {
            var game = new Game(paddle);
            while (!game.CheckLostParticle())
            {

                game.Draw();
                paddle.Move();
                game.MoveParticles();
                game.RoundCount();
                game.IncreaseLevel();

                Thread.Sleep(100);
            }
            var text = "Game Over! Press ENTER to restart";
            Console.SetCursorPosition(40 - text.Length / 2, 5);
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}