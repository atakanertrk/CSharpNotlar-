using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public class RemoveDuplicateCharactersInsideString
    {
        private List<char> resultList = new List<char>();
        public RemoveDuplicateCharactersInsideString(string userInput)
        {
            foreach (char c in userInput)
            {
                if (!resultList.Contains(c))
                {
                    resultList.Add(c);
                }
            }
        }
        public string returnResult()
        {
            string result = "";
            foreach (var item in resultList)
            {
                result += item;
            }
            return result;
        }
    }
}
