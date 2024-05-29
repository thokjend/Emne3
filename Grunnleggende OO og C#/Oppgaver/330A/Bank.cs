namespace _330A
{
    internal class Bank
    {
        private List<Customer> _customers;
        private List<Account> _accounts;
        private int _accountNumber;

        public Bank()
        {
            _customers = new List<Customer>();
            _accounts = new List<Account>();
            _accountNumber = 100001;
        }

        public Customer CreateCustomer(string name)
        {
            var customer = new Customer(name);
            _customers.Add(customer);
            return customer;
        }

        public Account CreateAccount(Customer customer, string name)
        {
            var account = new Account(_accountNumber, name, customer);
            customer.AddAccount(account);
            _accounts.Add(account);
            return account;
        }

    }
}
