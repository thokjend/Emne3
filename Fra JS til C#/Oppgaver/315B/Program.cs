namespace _315B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Funksjon som skal telle antall bokstaver i en tekst
            int countLetter = 0;
            Console.Write("Enter letter: ");
            string letterStr = Console.ReadLine().ToLower();
            char letter = letterStr.ToCharArray()[0];

            while (letterStr.Length != 1)
            {
                Console.Write("Please enter a single letter: ");
                letterStr = Console.ReadLine().ToLower();
                letter = letterStr.ToCharArray()[0];
            }
            Console.Write("Enter text: ");

            string text = Console.ReadLine().ToLower();


            foreach (char c in text)
            {
                if (c == letter)
                {
                    countLetter++;
                }
            }

            Console.WriteLine($"{letter}: {countLetter}");
        }
    }
}
