﻿using System.Text;
using SimpleChessMoves;

Console.OutputEncoding = Encoding.UTF8;
var board = new Board();
var bishop = new Bishop();
var rook = new Rook();
board.Set("e4", bishop);
board.Set("f7", rook);
while (true)
{
    board.Show();
    Console.WriteLine("Blankt svar avslutter programmet. Ruter skrives som en bokstav og et tall, for eksempel \"e4\".");
    var positionFrom = Ask("Hvilken rute vil du flytte fra?");
    var positionTo = Ask("Hvilken rute vil du flytte til?");
    board.Move(positionFrom, positionTo);
}

string Ask(string question)
{
    Console.Write(question);
    Console.Write(" ");
    var answer = Console.ReadLine();
    if (string.IsNullOrEmpty(answer)) Environment.Exit(0);
    return answer;
}