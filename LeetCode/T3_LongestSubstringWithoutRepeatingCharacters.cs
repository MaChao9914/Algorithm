using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class T3_LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// 滑动窗口
        /// 注意测试用例3
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int length = s.Length;
            int maxSubLength = 0;
            Dictionary<char, int> window = new Dictionary<char, int>();
            int left = 0;
            for (int right = 0; right < length; right++)
            {
                var c1 = s[right];
                if (window.ContainsKey(c1))
                    window[c1]++;
                else
                    window.Add(c1, 1);

                while(window[c1] > 1)
                {
                    var c2 = s[left];
                    window[c2]--;
                    left++;
                }
                maxSubLength = Math.Max(maxSubLength, right + 1 - left);
            }

            return maxSubLength;
        }

        /// <summary>
        /// 使用linq
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring2(string s)
        {
            int length = s.Length;
            int maxSubLength = 0;
            List<char> window = new List<char>();
            for (int right = 0; right < length; right++)
            {
                var c = s[right];
                if (window.Contains(c))
                {
                    //Linq
                    window = window.Skip(window.IndexOf(c) + 1).ToList();
                }
                window.Add(c);
                maxSubLength = Math.Max(maxSubLength, window.Count);
            }

            return maxSubLength;
        }

        public int LengthOfLongestSubstring3(string s)
        {
            Dictionary<char, int> window = new Dictionary<char, int>();
            int longest = 0;
            for (int i = 0,j = 0; j < s.Length; j++)
            {
                char ch = s[j];
                if (window.ContainsKey(ch))
                {
                    i = window[ch] > i ? window[ch] : i;
                    window[ch] = j;
                }
                else
                {
                    window.Add(ch, j);
                }
                var temp = j - i;
                longest = temp > longest ? temp : longest;
            }
            return longest;
        }
    }
}
