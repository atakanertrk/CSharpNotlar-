using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsOnNumbers
{
    // creating fibonacci array with depending on user input (integer length, index)
    public class NthNumberOfFibonacci
    {
        List<int> fibonacciList = new List<int>();
        public NthNumberOfFibonacci(int input)
        {
            fibonacciList.Add(0); fibonacciList.Add(1);
            fibonacciList.Add(1); fibonacciList.Add(2);
            // creating fibonacci list. Length of list is depends on user input.
            // if input is 10, we have 10 value in fibonacci
            for (int i = 0; i < input - 4; i++)
            {
                fibonacciList.Add(fibonacciList[i + 2] + fibonacciList[i + 3]);
            }

        }

        public int[] ReturnResult()
        {
            // converting our fibonacci list to array list
            int counter = 0;
            int[] arrList = new int[fibonacciList.Count];
            foreach (int x in fibonacciList)
            {
                arrList[counter] = x;
                counter += 1;
            }
            return arrList;
        }
    }
}
