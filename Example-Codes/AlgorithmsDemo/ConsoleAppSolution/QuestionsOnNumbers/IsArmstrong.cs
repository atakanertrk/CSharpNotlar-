using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsOnNumbers
{
    public class IsArmstrong
    {
        string input;
        public IsArmstrong(int userInput)
        {
            input = userInput.ToString();
        }
        public bool IsItArmstrong()
        {
            int total = 0;
            foreach (var item in input)
            {
                int x = int.Parse(item.ToString());
                total += x * x * x;
            }
            if (total == int.Parse(input))
            { 
                return true;
            }
            return false;
        }
    }
}
