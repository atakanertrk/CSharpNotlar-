using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        //  ** Türeyen sınıf yani alt sınıflar ana(üst) sınıfın tüm özelliklerini ve metotlarını aynı,
        //  ** işlevi gösterecek şekilde kullanabilme ve kendine ait yeni özellikler barındırabilmelidir.

        // LSP princple says : creating inheritance hierarchies in which a client can reliably use any 
        // class or subclass without compromising the expected behavior

        // we have correctly implement LSP principle for this example. With this way now we have 
        // flexibility to work around manager, ceo and employee
        // SOLID princples are good ways of using interface and inheritance in C#
        static void Main(string[] args)
        {
            IManager accountingVP = new CEO();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Manager();

            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);


            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");
            Console.ReadLine();
        }
    }
}