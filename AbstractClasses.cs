using System;

namespace AbstractClasses
{
    class Program
    {   // abstract classlardan obje olusturamayız ( new -> class..)
        static void Main(string[] args)
        {
            Database database = new Oracle();         // Program çıktısı : Added by default 
            database.Add();                           //                    Deleted by oracle        
            database.Delete();                       //                     Added by default
            Database database2 = new SqlServer();   //                       Deleted by sql      
            database2.Add();                        // Sonuç olarak ekleme işlemim tüm databaselerde aynı fakat delete işlemine gelince
            database2.Delete();                     //  olay değişiyor. her databaseimde delete işlemi farklı bu örneğimizde

            Console.ReadLine();
        }
    }                                                                                                                           
    abstract class Database
    {
        // tamamlanmış metod
        public void Add()
        {
            Console.WriteLine("Added by default");  
        } 

        //tamamlanmamış metod
        public abstract void Delete(); // Misal her database'de ekleme kodlarımız aynı
    }                                  // fakat silme işlemimiz farklı kodlardan oluşsun (böyle bir olay yok fakat misal..)        
    class SqlServer : Database
    {
        public override void Delete()// görüldüğü üzere database'i implament ettiğimizde
        {                            // oluşan metodumuz override olarak geldi çünkü abstract tanımlı
            Console.WriteLine("Deleted by Sql");// yani abstract metodlar içi boş olan virtual metoddur birnevi. her ortamda farklı oldugundan
        }                                                                                                  // herkesin ayrı ayrı implament etmesi gerekir                                              

    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle");
        }
    }

}      


