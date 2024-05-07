namespace PasswordGenerator
{
    internal class Program
    {
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

                char lastIndex = pattern[pattern.Length - 1];

                if (lastIndex == 'l')
                {
                    password += WriteRandomLowerCaseLetter();
                }
                else if (lastIndex == 'L')
                {
                    password += WriteRandomUpperCaseLetter();
                }
                else if (lastIndex == 's')
                {
                    password += WriteRandomSpecialCharacter();
                }
                else if (lastIndex == 'd')
                {
                    password += WriteRandomDigit();
                }

                pattern = pattern.Remove(pattern.Length - 1);
            }

            Console.WriteLine(password);

        }

        static char WriteRandomLowerCaseLetter()
        {
            return 'a';
        }

        static char WriteRandomUpperCaseLetter()
        {
            return 'A';
        }

        static int WriteRandomDigit()
        {
            return 4;
        }

        static char WriteRandomSpecialCharacter()
        {
            return '!';
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
                              "\n- s = spesialtegn (!\"#\u00a4%&/(){}[]\r" +
                              "\nEksempel: PasswordGenerator 14 lLssdd\r" +
                              "\n    betyr\r\n        Min. 1 liten bokstav\r" +
                              "\n        Min. 1 1 stor bokstav\r" +
                              "\n        Min. 2 spesialtegn\r\n        Min. 2 sifre\r" +
                              "\n        Lengde på passordet skal være 14");
        }
    }

}