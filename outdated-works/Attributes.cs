using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConsoleApp1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1, FirstName="Atakan",Age=20};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadKey();
        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }

    }
    class CustomerDal
    {
        [Obsolete("Add metodunu kullanma, onun yerine addnew kullan")]//hazır bir attribute, add kullanilacağı zaman kullaniciyi uyarır(eski bir metod olduğunu söyler) 
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    [AttributeUsage(AttributeTargets.Property)]//requiredpropertyattribute'u sadece propertyler için kullanacağımızı tanımladık.
    class RequiredPropertyAttribute : Attribute //kendi oluşturduğumuz bir attribute
    {
         
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple =true )]//allowmultiple ile buradaki durum için; bir class'a birden fazla defa yazılabilir
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName) //kendi oluşturduğumuz bir attribute
        {
            _tableName = tableName;
        }
    }
}
