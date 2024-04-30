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

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    countLetter++;
                }
            }

            Console.WriteLine(countLetter);
        }
    }
}
