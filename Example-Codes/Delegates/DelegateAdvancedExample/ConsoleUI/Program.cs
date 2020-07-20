using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();

        // we have 3 diffrent deleagete.
        // One is simple way of doing with delegate keyword 
        // other one is Func<> and 
        // the other one is Action<>
        // (SubTotalAlert, CalculateLevelDiscount, AlertUser)
        static void Main(string[] args)
        {
            PopulateCartWithDemoData();
            // Display Way 1: passing 3 created methods to generatetotal SubTotalAlert, CalculateLevelDiscount, AlertUser
            Console.WriteLine($"Total for the cart is (included discount) : {Math.Round(cart.GenerateTotal(SubTotalAlert, CalculateLevelDiscount, AlertUser),2)}");
            
            Console.WriteLine();

            // Display way 2: instead of passing 3 method (SubTotalAlert, CalculateLevelDiscount, AlertUser)
            // we create those methods inline (inside generatetotal as paramater)
            decimal total = cart.GenerateTotal((subTotal) => Console.WriteLine($"The subtotal for cart 2 is {Math.Round(subTotal,2)}"),
                (products, subTotal) =>
                {
                    if (products.Count > 3)
                    {
                        return subTotal * 0.5M;
                    }
                    else
                    {
                        return subTotal;
                    }
                },
                (message) => Console.WriteLine($"Cart 2 Alert: {message}"));
            Console.WriteLine($"The total for cart 2 is : {total} ");

            Console.WriteLine();
            Console.Write("Please press any key to exit the application...");
            Console.ReadKey();
        }

        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }

        // we pass this method as paramater to GenerateTotal()
        // Only important thing when create this method is acces type(void) and paramater (decimal)
        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is : {Math.Round(subTotal, 2)}");
        }
        // We dont use List of ProductModel paramater but maybe in some cases we need that later.
        private static decimal CalculateLevelDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.80M ;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.95M;
            }
            else
            {
                return subTotal;
            }
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}
