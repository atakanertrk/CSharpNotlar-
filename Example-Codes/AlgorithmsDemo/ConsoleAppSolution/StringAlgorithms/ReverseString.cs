using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public class ReverseString
    {
        string result;
        public ReverseString(string userInput)
        {
            char[] reversedCharSet = new char[userInput.Length];
            int counter = 0;
            for (int i = userInput.Length-1; i >= 0; i--)
            {
                reversedCharSet[counter] = userInput[i];
                counter += 1;
            }
            result = new string(reversedCharSet);
        }
        public string getResult()
        {
            return result;
        }
    }
}
