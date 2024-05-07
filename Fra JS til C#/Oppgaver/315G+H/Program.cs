class Program
{
    static int[] counts = new int[250];
    static void Main(string[] arguments)
    {
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            addToArray(text);
            countLetters();
        }
    }

    static void addToArray(string text)
    {
        foreach (var character in text)
        {
            counts[(int)character]++;
        }
    }

    static void countLetters()
    {
        var sum = 0;
        foreach (var n in counts)        
        {
            sum += n;
        }



        for (var i = 0; i < counts.Length; i++)
        {
            if (counts[i] > 0)
            {
                var character = (char)i;
                float percentage = (float)counts[i] / sum * 100;
                Console.WriteLine($"{character} -  {counts[i]} - {percentage:F2}%");
            }
        }
    }
}