using System;
using System.Collections.Generic;

namespace Collections_Dictionary
{   
    // Buradaki işlemleri nesnelere erişmek için, numaralandırmak için kullanıyoruz genelde. Ör: Dictionary<Id,Customer> şeklinde. 
    class Program                                                                  // Customer nesnesine direk id ile erişebilirim
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");//book=key , kitap= value
            dictionary.Add("computer", "bilgisayar");
            dictionary.Add("table", "tablo");

            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["computer"]);
            Console.WriteLine(dictionary["table"]);

            Console.WriteLine("********************");

            Console.WriteLine(dictionary.ContainsKey("book")); //true
            Console.WriteLine(dictionary.ContainsValue("tablo")); //true

            Console.WriteLine("*******************");

            foreach (var values in dictionary)
            {
                Console.WriteLine(values);
            }

            Console.WriteLine("*******************");

            foreach(var values in dictionary)
            {
                Console.WriteLine(values.Key);
            }

            Console.WriteLine("*******************");

            foreach (var values in dictionary)
            {
                Console.WriteLine(values.Value);
            }

            Console.ReadLine();
        }
    }
}
