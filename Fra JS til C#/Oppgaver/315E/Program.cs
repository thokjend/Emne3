namespace _315E
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] getNumbers = numbers(1000, 1028, 7);

            for (int i = 0; i < getNumbers.Length; i++)
            {
                Console.WriteLine(getNumbers[i]);
            }

        }

        static int[] numbers(int start, int end, int diff)
        {
            int indexes = (end - start) / diff + 1;
            int[] numbers = new int[indexes];
            int currentIndex = 0;

            for (int i = start; i <= end; i += diff)
            {
                numbers[currentIndex] = i;
                currentIndex++;
            }

            return numbers;
        }

    }
}
