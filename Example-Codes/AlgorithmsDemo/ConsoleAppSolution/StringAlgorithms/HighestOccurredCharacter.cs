using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public class HighestOccurredCharacter
    {
        string alphabet = "abcdefghijklmnoprstuvyzwq";
        Dictionary<char, int> counts = new Dictionary<char, int>();
        public HighestOccurredCharacter(string userInput)
        {
            //get rid of spaces and other unwanted characters
            userInput = formatUserInput(userInput); 
            // loading dictionary with characters of input
            // example input : aatak -> dictionar=[a,t,k]
            loadDictionaryWithCharactersOfInput(userInput); 
            // looping input string and increasing count of dictionary via character count
            updateDictionaryValues(userInput);
        }
        public string formatUserInput(string input)
        {
            string tempString = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (alphabet.Contains(input[i]))
                {
                    tempString += input[i];
                }
            }
            input = tempString;
            input += "?"; //we need extra one character in the end, otherwise program wont work properly
            return input;
        }
        public void loadDictionaryWithCharactersOfInput(string input)
        {
            string tempString = "";
            foreach (char item in input)
            {
                if (!tempString.Contains(item))
                {
                    tempString += item;
                    counts.Add(item, 0);
                }
            }
        }
        public void updateDictionaryValues(string input)
        {
            for (int j = 0; j < counts.Count() - 1; j++)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] == counts.ElementAt(j).Key)
                    {
                        counts[counts.ElementAt(j).Key] += 1;
                    }
                }
            }
        }
        public char returnMostUsedCharacter()
        {
            char mostUsedChar = counts.FirstOrDefault(x => x.Value == counts.Values.Max()).Key;
            return mostUsedChar;
        }
    }
}
