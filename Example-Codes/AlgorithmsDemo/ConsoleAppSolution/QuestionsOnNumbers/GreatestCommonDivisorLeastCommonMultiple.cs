using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsOnNumbers
{
    public class GreatestCommonDivisorLeastCommonMultiple
    {
        int smallNumber;
        int bigNumber;
        public GreatestCommonDivisorLeastCommonMultiple(int number1, int number2)
        {
            if (number1 > number2)
            {
                bigNumber = number1;
                smallNumber = number2;
            }
            else
            {
                bigNumber = number2;
                smallNumber = number1;
            }
        }

        public int GetGreatestCommonDivisor()
        {
            int gcd = 1;
            for (int i = 2; i <= smallNumber; i++)
            {
                if (smallNumber % i == 0 && bigNumber % i == 0)
                {
                    gcd = i;
                }
            }
            return gcd;
        }
        public int LeastCommonMultiple()
        {
            return smallNumber * bigNumber / GetGreatestCommonDivisor();
        }

    }
}
