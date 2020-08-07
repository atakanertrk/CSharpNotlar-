using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsArray
{
    public class MergeTwoSortedArray
    {
        int[] result;
        public MergeTwoSortedArray(int[] arrOne, int[] arrTwo)
        {
            int[] resultArray = new int[arrOne.Length+arrTwo.Length];
            int counter = 0;
            foreach (int x in arrOne)
            {
                resultArray[counter] = x;
                counter += 1;
            }
            foreach (int x in arrTwo)
            {
                resultArray[counter] = x;
                counter += 1;
            }
            Array.Sort(resultArray);
            result = resultArray;
        }
        public int[] GetResult()
        {
            return result;
        } 
    }
}
