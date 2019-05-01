using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
            Console.ReadLine();
        }   //PROGRAM ÇIKTISI
    }       //Added by Sql Code 
            //Added by defaul
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }

    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code"); 
            //base.Add();  burdaki base Database'i gösterir
        }
    }
    class MySql : Database
    {

    }
}
