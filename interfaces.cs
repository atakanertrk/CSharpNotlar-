using System;

namespace interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                FistName = "atakan",
                LastName = "ertürk"
            };

            manager.Add(customer);

        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FistName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }

        public string Derpartment { get; set; }
    }

    class PersonManager
    {
        public void Add(Customer customer)     // bir nesne de parametre olabilir
        {
            Console.WriteLine(customer.FistName);
        }
    }

}
