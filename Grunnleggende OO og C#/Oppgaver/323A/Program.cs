namespace _323A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \n" + " - H, U, B\n" + " - halvgardering: HU, HB, UB\n" + " - helgardering: HUB\n" + "Hva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            var newMatch = new Match(bet);

            while (newMatch.MatchIsRunning)
            {
                Console.Write("Kommandoer: \n" + " - H = scoring hjemmelag\n" + " - B = scoring bortelag\n" + " - X = kampen er ferdig\n" + "Angi kommando: ");
                var command = Console.ReadLine();
                if(command == "X") { newMatch.EndMatch();}
                else if(command == "H"){newMatch.AddGoal("H"); }
                else if(command == "B") { newMatch.AddGoal("B"); }
                Console.WriteLine($"Stillingen er {newMatch.GetScore()}.");
            }

            var isBetCorrectText = newMatch.CorrectBet() ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }
}
