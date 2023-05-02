using CostumerDetailsDemo;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

namespace CostumerDetailsDemo
{
    class Customer
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public int Id { get; set; }
        
    }
    class Management
    {
        List<Customer> customers;
        public Management()
        {
            customers = new List<Customer>()
            {
                new Customer {Id = 1,Fname = "Sirisha", Lname = "Sapasetty", Email = "ss2501@gmail.com", Phone = "9381798558", City = "Annavaram"},
                new Customer {Id = 2 ,Fname = "Lakshmi", Lname = "Girajala", Email = "1025@gmail.com", Phone = "9295559603", City = "Kakinada"},
            };
        }
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public int GenerateCustomerId(string firstName, string lastName)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 9999);
            return randomNumber;
        }
        public Customer GetCustomer(string fname)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Fname == fname)
                    return customer;
            }
            return null;
        }
        public List<Customer> GetCustomers()
        {
            return customers;
        }
        public bool UpdateCustomer(string fname)
        {
            foreach(Customer c in customers)
            {
                if (c.Fname == fname)
                {
                    Console.WriteLine("Enter updated Details");

                    Console.WriteLine("Enter updated fname");
                    c.Fname = Console.ReadLine();

                    Console.WriteLine("Enter updated lname");
                    c.Lname = Console.ReadLine();

                    Console.WriteLine("Enter updated email");
                    c.Email = Console.ReadLine();

                    Console.WriteLine("Enter updated phone");
                    c.Phone = Console.ReadLine();

                    Console.WriteLine("Enter updated city");
                    c.City = Console.ReadLine();

                    //Console.WriteLine("Customer Details Updated Successfully");
                    return true;

                }


            }return false;


        }
        public bool DeleteCustomer(string fname)
        {
            foreach (Customer c in customers)
            {
                if (c.Fname == fname)
                {
                    customers.Remove(c);
                    return true;
                }
            }
            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Management m = new Management();
            string res = "";
            do
            {
                Console.WriteLine("Display Customer Details");
                Console.WriteLine("1. AddCustomer");
                Console.WriteLine("2. GetCustomer by Fname");
                Console.WriteLine("3. GetCustomers");
                Console.WriteLine("4. Update Customer by Fname");
                Console.WriteLine("5. Delete Customer by Fname");

                Console.WriteLine("Enter ur choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Customer First Name");
                            string fname = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Enter  Customer Last Name");
                            string lname = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Enter Customer email");
                            string email = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Enter Customer Phone Number");
                            string phone = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Enter Customer City");
                            string city = Convert.ToString(Console.ReadLine());

                            m.AddCustomer(new Customer()
                            {
                                Fname = fname,
                                Lname = lname,
                                Email = email,
                                Phone = phone,
                                City = city
                            });


                            //Console.WriteLine($"{customerId.CustomerId}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Get Customer by Fname");
                            string fname = Convert.ToString(Console.ReadLine());
                            Customer? c = m.GetCustomer(fname);
                            if (c == null)
                            {
                                Console.WriteLine("Customer with specified first name does not exists");
                            }
                            else
                            {
                                Console.WriteLine($"{c.Id} {c.Fname} {c.Lname} {c.Email} {c.Phone} {c.City}");
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (var c in m.GetCustomers())
                            {
                                Console.WriteLine($"{c.Id} {c.Fname} {c.Lname} {c.Email} {c.Phone} {c.City}");
                            }
                            break;
                        }
                        
                    case 4:
                        {
                            Console.WriteLine("Enter Customer Fname");
                            string fname = Convert.ToString(Console.ReadLine());
                            if (m.UpdateCustomer(fname))
                            {
                                Console.WriteLine("Customer Detail Updated Successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Customer with specified first name does not exist");
                            }
                            break;

                        }
                    
                    case 5:
                        {
                            Console.WriteLine("Enter Customer Fname");
                            string fname = Convert.ToString(Console.ReadLine());
                            if (m.DeleteCustomer(fname))
                            {
                                Console.WriteLine("Customer Deleted Successfully");
                            }
                            else
                            {
                                Console.WriteLine("Customer with specified first name does not exist");
                            }
                            break;
                        }
                }


                Console.WriteLine("Do you wish to continue? [y/n] ");
                res = Console.ReadLine();
            }
            while (res.ToLower() == "y");

        }

    }        
        
}
