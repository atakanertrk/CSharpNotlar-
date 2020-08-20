using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        // host1List and host2List both shares same instance of TableServers (_instance)
        static TableServers host1List = TableServers.GetTableServers();
        static TableServers host2List = TableServers.GetTableServers();
        static void Main(string[] args)
        {
            Console.WriteLine(GetCountOfServers());
            for (int i = 0; i < 5; i++)
            {
                Host1GetNextServer();
                Host2GetNextServer();
            }
            Console.ReadLine();
        }
        private static void Host1GetNextServer()
        {
            Console.WriteLine("Next server is : " + host1List.GetNextServer());
        }
        private static void Host2GetNextServer()
        {
            Console.WriteLine("Next server is : " + host2List.GetNextServer());
        }
        private static int GetCountOfServers()
        {
            int count = TableServers.GetTableServers().GetCount();
            return count;
        }
    }
}
