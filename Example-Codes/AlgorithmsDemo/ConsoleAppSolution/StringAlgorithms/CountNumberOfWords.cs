using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public class CountNumberOfWords
    {
        string alphabet = "abcdefghijklmnoprstuvxyzw1234567890";
        List<string> words = new List<string>();
        public CountNumberOfWords(string userInput)
        {
            userInput = userInput.ToLower();
            string word = "";
            userInput = userInput.Trim();
            userInput += " "; // we need one empty character on last for being able to check last word of input
            foreach (char c in userInput)
            {
                if (alphabet.Contains(c))
                {
                    word += c;
                }
                else if(c == ' ')
                {
                    words.Add(word);
                    word = "";
                }
            }
        }
        public int getResult()
        {
            int count=words.Count();
            foreach (var item in words)
            {
                if (item == "")
                {
                    count -= 1;
                }
            }
            return count;
        }
    }
}
