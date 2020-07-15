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
using ConsoleApp.Models;
using ConsoleApp.WithoutGenerics;
using ConsoleApp.WithGenerics;

namespace ConsoleApp
{ 
    class Program 
    {
        static void Main(string[] args)
        {
            DemonstrateTextFileStorage();
            Console.WriteLine();
            Console.Write("Press enter to shut down...");
            Console.ReadLine();
        }

        private static void DemonstrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();
            string peopleFile = @"C:\Temp\people.csv";
            string logFile = @"C:\Temp\logs.csv";

            PopulateLists(people, logs);

            /* With Generics (good way of doing) */
            // instead of copy-paste and configure methods inside we have like OriginalTextFileProcessor 
            // we can use generic method like this example.
            // if we have another model, not a problem. We dont need to configure another method for it.
            // GenericTextFileProcessor configures for all list types.
            GenericTextFileProcessor.SaveToTextFile<Person>(people, peopleFile);
            GenericTextFileProcessor.SaveToTextFile<LogEntry>(logs,logFile);
            var newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFile);
            foreach (var p in newPeople)
            {
                Console.WriteLine($"{ p.FirstName } { p.LastName } (IsAlive = { p.IsAlive })");
            }
            var newLogs = GenericTextFileProcessor.LoadFromTextFile<LogEntry>(logFile);
            foreach (var log in newLogs)
            {
                Console.WriteLine($"{log.ErrorCode} : {log.Message} at {log.TimeOfEvent.ToShortTimeString()}");
            }

            /* Without Generics (bad way of doing) */
            //OriginalTextFileProcessor.SavePeople(people, peopleFile);
            //var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);
            //foreach (var p in newPeople)
            //{
            //    Console.WriteLine($"{ p.FirstName } { p.LastName } (IsAlive = { p.IsAlive })");
            //}

            //OriginalTextFileProcessor.SaveLogs(logs,logFile);
            //var newLogs = OriginalTextFileProcessor.LoadLogs(logFile);
            //foreach (var log in newLogs)
            //{
            //    Console.WriteLine($"{log.ErrorCode} : {log.Message} at {log.TimeOfEvent.ToShortTimeString()}");
            //}
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm", IsAlive = false });
            people.Add(new Person { FirstName = "Greg", LastName = "Olsen" });

            logs.Add(new LogEntry { Message = "I blew up", ErrorCode = 9999 });
            logs.Add(new LogEntry { Message = "I'm too awesome", ErrorCode = 1337 });
            logs.Add(new LogEntry { Message = "I was tired", ErrorCode = 2222 });
        }
    }
}
