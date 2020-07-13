using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Interface
{
    //understanding interfaces
    //example of this code used on : https://stackoverflow.com/questions/6802573/interfaces-whats-the-point#:~:text=You%20use%20interfaces%20when%20you,will%20happen%20when%20it%27s%20disposed.
    class Program
    {
        static void Main(string[] args)
        {
            StuffedCrustPizza pizza = new StuffedCrustPizza();
            pizza.Prepare();
            Console.ReadLine();
        }
        // about IList https://stackoverflow.com/questions/400135/listt-or-ilistt
        public void PreparePizzas(IList<IPizza> pizzas)
        {
            foreach (var pizza in pizzas)
                pizza.Prepare();
        }
    }
    public interface IPizza
    {
        void Prepare();
    }

    public class StuffedCrustPizza : IPizza
    {
        public void Prepare()
        {
            // Set settings in system for stuffed crust preparations
            Console.WriteLine("StuffedCrustPizza is ready");
        }
    }

    public class DeepDishPizza : IPizza
    {
        public void Prepare()
        {
            // Set settings in system for deep dish preparations
            Console.WriteLine("deep dish ready");
        }
    }
}
