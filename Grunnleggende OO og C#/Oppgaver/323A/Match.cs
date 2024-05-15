namespace _323A
{
    internal class Match
    {
        public int homeGoals = 0;
        public int awayGoals = 0;
        public string Bet;
        public bool matchIsRunning = true;


        public Match(string bet)
        {
            Bet = bet;
        }

        public void AddGoal(string team)
        {
            if (team == "H")
            {
                homeGoals++;
            }
            else
            {
                awayGoals++;
            }
        }

        public bool CorrectBet()
        {
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            return Bet.Contains(result);
        }

        public void EndMatch()
        {
            matchIsRunning = false;
        }

        public string GetScore()
        {
            return homeGoals + "-" + awayGoals;
        }




    }

    


}
