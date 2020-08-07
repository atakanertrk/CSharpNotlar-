using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsArray
{
    public class RotateArrayWithGivenPivot
    {
        int pivotIndex;
        char[] originalArray;
        public char[] result { get; set; }
        public RotateArrayWithGivenPivot(char[] inputArr, int userPivotIndex)
        {
            pivotIndex = userPivotIndex;
            originalArray = inputArr;
            char[] rotatetArray = new char[originalArray.Length];
            char[] leftArray = new char[pivotIndex];
            char[] rightArray = new char[originalArray.Length - pivotIndex - 1];
            char centerChar = originalArray[pivotIndex];
            SplitArray(ref leftArray, ref rightArray);
            leftArray = ReverseArray(leftArray);
            rightArray = ReverseArray(rightArray);
            rotatetArray = GatherSplitetArrays(leftArray,rightArray,centerChar);
            result = rotatetArray;
        }
        public void SplitArray(ref char[] leftArray, ref char[] rightArray)
        {
            int counter = 0;
            for (int i = 0; i < pivotIndex; i++)
            {
                leftArray[i] = originalArray[i];
            }
            for (int i = pivotIndex + 1; i < originalArray.Length; i++)
            {
                rightArray[counter] = originalArray[i];
                counter += 1;
            }
        }
        public char[] ReverseArray(char[] array)
        {
            char[] reversedArray = new char[array.Length];
            int index = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[index] = array[i];
                index += 1;
            }
            return reversedArray;
        }
        public char[] GatherSplitetArrays(char[] leftArray, char[] rightArray,char centerChar)
        {
            char[] array = new char[originalArray.Length];
            int counter = 0;
            foreach (var item in leftArray)
            {
                array[counter] = item;
                counter += 1;
            }
            array[counter] = centerChar;
            counter += 1;
            foreach (var item in rightArray)
            {
                array[counter] = item;
                counter += 1;
            }
            return array;
        }
    }
}
