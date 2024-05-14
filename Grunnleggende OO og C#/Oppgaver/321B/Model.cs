namespace _321B
{
    internal class Model
    {
        public points Points;
        public rows Rows;
        public data Data;
    }

    class points
    {
        public int CodeBreaker;
        public int CodeMaker;
    }

    class rows
    {
        public string[] SecretRow;
        public guessRows GuessRows;
        public feedbackRows FeedbackRows;

    }

    class guessRows
    {
        public string[] row1;
        public string[] row2;
        public string[] row3;
        public string[] row4;
        public string[] row5;
        public string[] row6;
        public string[] row7;
        public string[] row8;
        public string[] row9;
        public string[] row10;
    }

    class feedbackRows
    {
        public string[] row1;
        public string[] row2;
        public string[] row3;
        public string[] row4;
        public string[] row5;
        public string[] row6;
        public string[] row7;
        public string[] row8;
        public string[] row9;
        public string[] row10;
    }

    class data
    {
        public int SelectedIndex;
        public bool GoToNextRound;
    }

}
