using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T30_FindSubstring
    {
        public static IList<int> FindSubstring(string s, string[] words)
        {
            List<int> ans = new List<int>();
            int subLength = words[0].Length;
            int wordsLength = words.Length;
            List<string> temps = new List<string>(words);
            int start = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i).Length >= subLength * wordsLength)
                {
                    string sbStr = s.Substring(i, subLength * wordsLength);
                    for (int j = 0; j < sbStr.Length; j += subLength)
                    {
                        string word = sbStr.Substring(j, subLength);
                        if (temps.Contains(word))
                        {
                            if (temps.Count == wordsLength)
                                start = i;
                            temps.Remove(word);
                            if (temps.Count == 0)
                            {
                                temps = words.ToList();
                                ans.Add(start);
                                start = -1;
                            }
                        }
                        else
                        {
                            if (start != -1)
                                temps = words.ToList();
                            break;
                        }
                    }
                }
            }
            return ans;
        }


    }
}
