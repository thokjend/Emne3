namespace _330A
{
    internal class Account
    {
        private int _accountNumber;
        private string _name;
        private Customer _customer;


        public Account(int accountNumber, string name, Customer customer)
        {
            _accountNumber = accountNumber;
            _name = name;
            _customer = customer;
        }
    }
}
