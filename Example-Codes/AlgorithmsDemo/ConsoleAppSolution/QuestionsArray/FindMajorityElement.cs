using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsArray
{
    public class FindMajorityElement
    {
        char[] originalArray;
        Dictionary<char, int> countOfElements = new Dictionary<char, int>();
        public char GetHighestOccuredMember()
        {
            return countOfElements.FirstOrDefault(x => x.Value == countOfElements.Values.Max()).Key;
        }
        // constructor
        public FindMajorityElement(string userInput)
        {
            char[] input = userInput.ToArray();
            originalArray = input;

            LoadDictionary(input);

            foreach (var item in countOfElements)
            {
                Console.WriteLine(item.Key + "  :  " + item.Value);
            }
        }
        private void LoadDictionary(char[] userInput)
        {
            foreach(char c in userInput)
            {
                if (countOfElements.ContainsKey(c) == false)
                {
                    countOfElements.Add(c, 0);
                }
            }
            for (int i = 0; i < countOfElements.Count; i++)
            {
                for (int j = 0; j < userInput.Length; j++)
                {
                    if (userInput[j] == countOfElements.ElementAt(i).Key)
                    {
                        countOfElements[countOfElements.ElementAt(i).Key] += 1;
                    }
                }
            }
        }
    }
}
