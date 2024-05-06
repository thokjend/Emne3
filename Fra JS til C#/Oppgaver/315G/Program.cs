class Program
{
    static void Main(string[] arguments)
    {
        var range = 250;
        var counts = new int[range];
        string text = "something";
        int counter = 0;
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            foreach (var character in text)
            {
                counts[(int)character]++;
                counter++;
            }
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    float percentage = (float)counts[i] / counter * 100;
                    Console.WriteLine($"{character} -  {counts[i]} - {percentage:F2}%");
                }
            }
        }
    }
}