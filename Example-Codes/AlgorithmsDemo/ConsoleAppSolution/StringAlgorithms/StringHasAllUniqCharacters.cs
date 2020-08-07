using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public class StringHasAllUniqCharacters
    {
        // if all uniq, result is true
        private bool _result;

        public StringHasAllUniqCharacters(string userInput)
        {
            char[] inputCharArr = userInput.ToArray();
            Array.Sort(inputCharArr);
            userInput = new String(inputCharArr);

            for (int i = 0; i < userInput.Length - 1; i++)
            {
                _result = (userInput[i] == userInput[i + 1]) ? false : true;
                if (_result == false)
                    break;
            }
        }
        public bool GetResult()
        {
            return _result;
        }
    }
}
