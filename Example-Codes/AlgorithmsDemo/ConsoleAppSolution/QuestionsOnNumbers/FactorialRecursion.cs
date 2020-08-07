using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsOnNumbers
{
    public class FactorialRecursion
    {
        int result;
        public int GetResult()
        {
            return result;
        }
        public FactorialRecursion(int input)
        {
            result = Factorial(input);
        }
        private int Factorial(int input)
        {
            if (input > 0)
            {
                return input * Factorial(input - 1);
            }
            return 1;
        }
        
    }
}
