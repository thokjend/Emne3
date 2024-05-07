using System.Xml.Schema;

namespace PasswordGenerator
{
    internal class Program
    {
        static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                showHelpText();
                return;
            }

            int length = Convert.ToInt32(args[0]);
            string options = args[1];

            var pattern = options.PadRight(length, 'l');
            string password = "";


            while (pattern.Length > 0)
            {
                int randomIndex = Random.Next(0, pattern.Length - 1);
                char randomChar = pattern[randomIndex];

                if (randomChar == 'l')
                {
                    password += WriteRandomLowerCaseLetter();
                }
                else if (randomChar == 'L')
                {
                    password += WriteRandomUpperCaseLetter();
                }
                else if (randomChar == 's')
                {
                    password += WriteRandomSpecialCharacter();
                }
                else if (randomChar == 'd')
                {
                    password += WriteRandomDigit();
                }

                pattern = pattern.Remove(pattern.Length - 1);
            }

            Console.WriteLine(password);

        }

        static char WriteRandomLowerCaseLetter()
        {
            return GetRandomLetter('a','z');
        }

        static char WriteRandomUpperCaseLetter()
        {
            return GetRandomLetter('A', 'Z');
        }

        static int WriteRandomDigit()
        {
            return Random.Next(0, 9);
        }

        static char WriteRandomSpecialCharacter()
        {
            string specialCharacters = "!#¤%&/()=?`@£$€{[]}´|";
            var randomIndex = Random.Next(0, specialCharacters.Length - 1);
            return specialCharacters[randomIndex];
        }

        static char GetRandomLetter(char min, char max)
        {
            return (char)Random.Next(min, max);
        }

        static bool IsValid(string[] args)
        {
            if (args.Length != 2)
            {
                return false;
            }

            else
            {
                string s = args[0];
                string t = args[1];
                string validChars = "lLds";

                foreach (var c in s)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }

                foreach (var l in t)
                {
                    if (!validChars.Contains(l))
                    {
                        return false;
                    }
                }

            }

            return true;
        }

        static void showHelpText()
        {
            Console.WriteLine("PasswordGenerator  \r" +
                              "\nOptions:\r" +
                              "\n- l = liten bokstav\r" +
                              "\n- L = stor bokstav\r\n- d = siffer\r" +
                              "\n- s = spesialtegn !#¤%&/()=?`@£$€{[]}´|\r" +
                              "\nEksempel: PasswordGenerator 14 lLssdd\r" +
                              "\n    betyr\r\n        Min. 1 liten bokstav\r" +
                              "\n        Min. 1 1 stor bokstav\r" +
                              "\n        Min. 2 spesialtegn\r\n        Min. 2 sifre\r" +
                              "\n        Lengde på passordet skal være 14");
        }
    }
}