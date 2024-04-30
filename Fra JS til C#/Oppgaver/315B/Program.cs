namespace _315B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Funksjon som skal telle antall bokstaver i en tekst
            int countLetter = 0;
            string letter = "";

            while (letter.Length != 1)
            {
                Console.Write("Enter letter: ");
                letter = Console.ReadLine().ToLower();

            }

            Console.Write("Enter text: ");
            string text = Console.ReadLine().ToLower();


            foreach (char c in text)
            {
                if (c == letter[0])
                {
                    countLetter++;
                }
            }

            Console.WriteLine($"{letter}: {countLetter}");
        }
    }
}
