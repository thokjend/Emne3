using System.ComponentModel;

namespace _330A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            var customer = bank.CreateCustomer("Per");
            var account = bank.CreateAccount(customer, "konto1");

        }
    }
}
