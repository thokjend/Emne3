namespace FirstCsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = MyConsole.Ask("What is your name?");
            Console.WriteLine($"Hello, {name}");

            var birthYear = MyConsole.AskForInt("What year were you born?");
            var hadBirthday = MyConsole.AskForBool("Have you had birthday this year?");
            var age = 2024 - birthYear;
            if (!hadBirthday)
            {
                age--;
            }
            Console.WriteLine($"You are {age} years old");
        }
    }
}
