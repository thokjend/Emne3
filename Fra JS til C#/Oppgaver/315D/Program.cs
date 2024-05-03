namespace _315D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            string[] textArray = text.Split(' ');
            string longestWord = textArray[0];
            string mostVowelsWord = "";
            int maxVowelCount = 0;
            
            foreach (string word in textArray)
            {
                int vowelCount = countVowels(word);

                if (vowelCount > maxVowelCount)
                {
                    maxVowelCount = vowelCount;
                    mostVowelsWord = word;
                }

                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine($"Number of words: {textArray.Length}");
            Console.WriteLine($"The longest word is: {longestWord}");
            if (maxVowelCount > 0)
            {
                Console.WriteLine($"The word with the most vowels is: {mostVowelsWord} with {maxVowelCount} vowels");
            }
        }

        static int countVowels(string word)
        {
            string Vowels = "aeiouyæøåAEIOUYÆØÅ";
            int vowelCount = 0;
            foreach (char c in word)
            {
                if (Vowels.Contains(c))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
