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
using System.IO;
using System.Threading;
using ClassLibrary;
using System.Diagnostics;

namespace ConsoleApp
{
    class Program : Operations
    {
        delegate void processing(List<ValuesModel> valuesList);
        static void Main(string[] args)
        {
            ValuesModel valuesOne = new ValuesModel() { numberOne = 2, numberTwo = 5, text = "values of proces one" };
            ValuesModel valuesTwo = new ValuesModel() { numberOne = 10, numberTwo = 20, text = "values of proces two" };
            List<ValuesModel> valuesList = new List<ValuesModel>();
            valuesList.Add(valuesOne);
            valuesList.Add(valuesTwo);

            processing process = new processing(ProcessOne);
            process += ProcessTwo;
            process(valuesList);

            ClearDelegate(process);

            Console.ReadKey();
        }
        private static void ClearDelegate(processing process)
        {
            process -= ProcessOne;
            process -= ProcessTwo;
        }

    }
}

