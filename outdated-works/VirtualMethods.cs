using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)                 //Programa çıktısı : Added by Sql Code \n Added by default.
        {   
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
            Console.ReadLine();
        }   
    }        
                       // VIRTUALMEHODS'un amacı örnekte de görüldüğü gibi benim ekleme işlemim sqlserver'da farklı mysql'de farklı
    class Database     // database sınıfında yazdığım add metodunun içinde değişiklik yapmak için virual metodları kullanırız.
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
        public override void Add()          // base.Add()'i de çaşıştırırsak add by default ve add by sql code çıktısını görürüz.
        {                                   
            Console.WriteLine("Added by Sql Code"); 
            //base.Add();  burdaki base Database'i gösterir
        }
    }
    class MySql : Database
    {
 
    }
}
