using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections;
using Nancy.Json;
using System.Net;
using Nancy.Helpers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using DemoLibrary;

namespace ConsoleApp
{
    class Program
    {
        // abstract class blends both base class and interface
        static void Main(string[] args)
        {
            // we could make same of this code with interfaces but now we made it with abstract class
            // abstract class gives power of being able to use base class and interface togather
            List<DataAccess> databases = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        
    }
}
