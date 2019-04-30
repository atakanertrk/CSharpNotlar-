using System;                 //*********************************************************//
                             //!!!!!!!!!!!!!!!!!!!! ÖNEMLİ NOT 54. SATIRDA !!!!!!!!!!!!!!!!
namespace interfaces           //********************************************************//
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
                                                            // interface1.cs KODUNDA DAHA DETAYLI ÖRENK VAR
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
    {                                     //*******************************************************************************
        public void Add(Customer customer)//Customer customer yerine IPerson customer verirsem ben Add metodumu kullanırken
        {                      //customer dışında student da ekleme işlemini yapabilirim. kodun bu halind student ekleyemem !!!!!!!
                               //******************************************************************************************
            Console.WriteLine(customer.FistName);  
        }
    }

}
