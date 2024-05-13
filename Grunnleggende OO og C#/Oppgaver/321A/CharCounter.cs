using System.Diagnostics.Metrics;

namespace _321A
{
    internal class CharCounter
    {
        public int[] counts;

        public CharCounter()
        {
            counts = new int[250];
        }

        public void AddText(string text)
        {
            foreach (var character in text ?? String.Empty)
            {
                counts[(int)character]++;
            }
        }

        public void ShowCounts()
        {
            for (var i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine($"{character} -  {counts[i]}");
                }
            }
        }
    }
}
