using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public class TwoStringAnagramCheck
    {
        private  bool isAnagram = false;
        public TwoStringAnagramCheck(string inputOne, string inputTwo)
        {
            inputOne = inputOne.ToLower();
            char[] inputOneChar = inputOne.ToArray();
            Array.Sort(inputOneChar);
            string inputOneSorted = new string(inputOneChar);

            inputTwo = inputTwo.ToLower();
            char[] inputTwoChar = inputTwo.ToArray();
            Array.Sort(inputTwoChar);
            string inputTwoSorted = new string(inputTwoChar);

            if (inputOneSorted == inputTwoSorted)
            {
                isAnagram = true;
            }
        }
        public bool returnResult()
        {
            return isAnagram;
        }
    }
}
