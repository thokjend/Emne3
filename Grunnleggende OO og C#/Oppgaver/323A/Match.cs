namespace _323A
{
    internal class Match
    {
        private int _homeGoals = 0;
        private int _awayGoals = 0;
        private string _bet;
        public bool MatchIsRunning = true;


        public Match(string bet)
        {
            _bet = bet;
        }

        public void AddGoal(string team)
        {
            if (team == "H")
            {
                _homeGoals++;
            }
            else
            {
                _awayGoals++;
            }
        }

        public bool CorrectBet()
        {
            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            return _bet.Contains(result);
        }

        public void EndMatch()
        {
            MatchIsRunning = false;
        }

        public string GetScore()
        {
            return _homeGoals + "-" + _awayGoals;
        }




    }

    


}
