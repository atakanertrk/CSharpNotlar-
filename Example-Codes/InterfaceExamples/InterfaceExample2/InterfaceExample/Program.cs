using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using DemoLibrary;

namespace ConsoleApp
{
    class Program
    {
        // Also with interface if i want to add another Model, I dont have to change the main code
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);
            }
            Console.ReadLine();
        }
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "atakan",
                LastName = "erturk",
                City = "eskisehir",
                EmailAddress = "contact@atakanerturk.me",
                PhoneNumber = "5512-312"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            // with IProductModel we can Add PhysicalProductModel and DigitalProductModel in output.
            // otherwise(without interface) we cant add PhysicalProductModel and DigitalProductModel in a list
            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Project Source Code" });
            return output;
        }

    }
}
