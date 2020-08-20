using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class TableServers
    {   
        // we create this instance whenever we start using TableServers.
        // when you call GetServerTables() you get an instance of TableServers but you- 
        // -always gonna get the same instance back. So every usecase of TableServers has the same instance
        // second tip for understanding; "instance created inside the class. So it will include the current status each call"
        private static readonly TableServers _instance = new TableServers();
  
        private List<string>  servers = new List<string>();
        private int nextServer = 0;
        private int test=0;
        private TableServers() //constructor
        {
            servers.Add("Tim");
            servers.Add("Sue");
            servers.Add("Marry");
            servers.Add("Bob");
        }
        public static TableServers GetTableServers()
        {
            return _instance;
        }
        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer += 1;
            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }
            return output;
        }
        public int GetCount()
        {
            int count = servers.Count();
            return count;
        }
        public int TestMethod()
        {
            return test;
        }
        public int ChangeTestMethod()
        {
            test += 2;
            return test;
        }
    }
}
