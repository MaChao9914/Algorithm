using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace LeetCode
{
    public class T17_LetterCombinationsofaPhoneNumber
    {
        /// <summary>
        /// 回溯算法、
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public IList<string> LetterCombinations(string digits)
        {
            Dictionary<string, string> phoneDic = new Dictionary<string, string>()
            {
                {"2","abc" },
                {"3","def" },
                {"4","ghi" },
                {"5","jkl" },
                {"6","mno" },
                {"7","pqrs" },
                {"8","tuv" },
                {"9","wxyz" }
            };

            List<string> combinations = new List<string>();
            List<char> combination = new List<char>();
            BackTrack(phoneDic, combinations, digits, combination, 0);

            return combinations;
        }

        private void BackTrack(Dictionary<string,string> phoneDic, List<string> combinations, 
            string digits, List<char> combination, int index)
        {
            if (index == digits.Length)
            {
                combinations.Add(new string(combination.ToArray()));
                return;
            }

            string key = digits[index] + "";
            foreach (var c in phoneDic[key].ToCharArray())
            {
                combination.Add(c);
                BackTrack(phoneDic, combinations, digits, combination, index + 1);
                combination.RemoveAt(index);
            }
        }
    }
}
