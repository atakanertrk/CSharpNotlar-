using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsArray
{
    public class SortArrayDescendingOrder
    {
        public SortArrayDescendingOrder(int[] userArray)
        {
            // userArray = userArray.OrderByDescending(c => c).ToArray();

            // or

            // Array.Sort(userArray);
            // Array.Reverse(userArray);

            //or

            int temp;
            for (int i = 0; i < userArray.Length - 1; i++)
            {
                for (int j = i + 1; j < userArray.Length; j++)
                {
                    if (userArray[i] < userArray[j])
                    {

                        temp = userArray[i];
                        userArray[i] = userArray[j];
                        userArray[j] = temp;
                    }
                }
            }


        }
    }
}
