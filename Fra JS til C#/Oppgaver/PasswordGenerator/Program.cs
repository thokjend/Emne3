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

            string pattern = args[1];
            Console.WriteLine(pattern);


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

                /*
                int argToInt = int.Parse(s);
                if (t.Length > argToInt)
                {
                    return false;
                }
                */

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