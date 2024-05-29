namespace _330A
{
    internal class Customer
    {
        private string _name;
        private List<Account> _accounts;


        public Customer(string name)
        {
            _name = name;
            _accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }
    }
}
