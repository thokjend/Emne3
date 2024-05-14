using System.Globalization;

namespace _321B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var model = new Model
            {
                Points = new points()
                {
                    CodeBreaker = 10,
                    CodeMaker = 8,
                },
                Rows = new rows()
                {
                    GuessRows = new guessRows()
                    {
                        row1 = ["white","red","blue","green"],
                        row2 = ["white", "red", "blue", "green"],
                        row3 = ["white", "red", "blue", "green"],
                        row4 = ["white", "red", "blue", "green"],
                        row5 = ["white", "red", "blue", "green"],
                        row6 = ["white", "red", "blue", "green"],
                        row7 = ["white", "red", "blue", "green"],
                        row8 = ["white", "red", "blue", "green"],
                        row9 = ["white", "red", "blue", "green"],
                        row10 = ["white", "red", "blue", "green"],
                    },
                    FeedbackRows = new feedbackRows()
                    {
                        row1 = ["white", "red", "red", "red"],
                        row2 = ["white", "red", "red", "red"],
                        row3 = ["white", "red", "red", "red"],
                        row4 = ["white", "red", "red", "red"],
                        row5 = ["white", "red", "red", "red"],
                        row6 = ["white", "red", "red", "red"],
                        row7 = ["white", "red", "red", "red"],
                        row8 = ["white", "red", "red", "red"],
                        row9 = ["white", "red", "red", "red"],
                        row10 = ["white", "red", "red", "red"],
                    },
                    SecretRow = ["white", "red", "blue", "green"]

                },
                Data = new data()
                {
                    SelectedIndex = 3,
                    GoToNextRound = false,
                }
            };


            Console.WriteLine(model.Rows.SecretRow[2]);
        }
        
    }
}
