namespace CustomerDetails
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Taluk { get; set; }
        public string Village { get; set; }
        public string Phone { get; set; }
        public string CustomerId { get; }



        private static int lastCustomerId = 0;



        public Customer(string firstName, string lastName, string address, string taluk, string village, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Taluk = taluk;
            Village = village;
            if (IsValidPhoneNumber(phone))
            {
                Phone = phone;
            }
            else
            {
                Console.WriteLine("Invalid phone number");
            }
            lastCustomerId++;
            CustomerId = lastCustomerId.ToString("D6");
        }



        private bool IsValidPhoneNumber(string phone)
        {
            if (phone.Length != 10)
            {
                return false;
            }
            int stateCode;
            if (!int.TryParse(phone.Substring(0, 2), out stateCode))
            {
                return false;
            }
            return true;
        }
    }



    class Bank
    {
        private List<Customer> customers = new List<Customer>();



        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }



        public void DisplayCustomerByLastName(string lastName)
        {
            foreach (Customer customer in customers)
            {
                if (customer.LastName == lastName)
                {
                    Console.WriteLine($"Customer ID: {customer.CustomerId}");
                    Console.WriteLine($"Name: {customer.FirstName} {customer.LastName}");
                    Console.WriteLine($"Address: {customer.Address}");
                    Console.WriteLine($"Taluk: {customer.Taluk}");
                    Console.WriteLine($"Village: {customer.Village}");
                    Console.WriteLine($"Phone: {customer.Phone}");
                    Console.WriteLine();
                }
            }
        }



        public void DisplayCustomersByTalukOrVillage(string taluk, string village)
        {
            Console.WriteLine("Customer ID\t\tName\t\t\tAddress\t\t\tPhone");
            Console.WriteLine("");
            foreach (Customer customer in customers)
            {
                if (customer.Taluk == taluk && customer.Village == village)
                {
                    Console.WriteLine($"{customer.CustomerId}\t\t{customer.FirstName} {customer.LastName}\t\t\t{customer.Address}\t\t{customer.Phone}");
                }
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();



            bank.AddCustomer(new Customer("Sirisha", "Sapasetty", "Main Road", "ABC", "AKPL", "9381798558"));
            bank.AddCustomer(new Customer("Jaya", "Mandavilli", " Ramalayam Street", "XYZ", "RYVM", "7995156778"));
            bank.AddCustomer(new Customer("Lakshmi", "Girajala", "PR Street", "PQR", "KKD", "9295559603"));
            Console.WriteLine("Customers with last name Girajala:");
            bank.DisplayCustomerByLastName("Girajala");
            Console.WriteLine("Customers in PQR,KKD:");
            bank.DisplayCustomersByTalukOrVillage("PQR", "KKD");



            Console.ReadKey();
        }
    }
}

