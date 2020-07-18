using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class Operations
    {
        protected static void ProcessOne(List<ValuesModel> valuesList)
        {
            var value = valuesList.First(); // first element of list
            Console.WriteLine($"{value.text} : {value.numberOne + value.numberTwo}");
        }

        protected static void ProcessTwo(List<ValuesModel> valuesList)
        {
            var value = valuesList.Last(); // last element of list
            Console.WriteLine($"{value.text} : {value.numberOne + value.numberTwo}");
        }
    }
}
