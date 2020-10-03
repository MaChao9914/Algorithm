using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class T76_MinimumWindowSubstring
    {
        /// <summary>
        /// 滑动窗口
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public string MinWindow(string s, string t)
        {
            Dictionary<char, int> need = new Dictionary<char, int>();
            Dictionary<char, int> window = new Dictionary<char, int>();

            for (int i = 0; i < t.Length; i++)
            {
                char c = t[i];
                if (!need.ContainsKey(c))
                    need.Add(c, 1);
                else
                    need[c]++;
            }

            int hasMatch = 0, left = 0;
            int startIndex = 0, minSubLen = s.Length + 1;
            for (int right = 0; right < s.Length; right++)
            {
                char c1 = s[right];

                if (need.ContainsKey(c1))
                {
                    if (!window.ContainsKey(c1))
                        window.Add(c1, 1);
                    else
                        window[c1]++;

                    if (window[c1] == need[c1])
                    {
                        hasMatch++;//记录已匹配到的数量
                    }
                }

                while(hasMatch == need.Count)
                {
                    char c2 = s[left];
                    if (minSubLen > right + 1 - left)
                    {
                        minSubLen = right + 1 - left;
                        startIndex = left;
                    }

                    if (need.ContainsKey(c2))
                    {
                        window[c2]--;
                        if (window[c2] < need[c2])
                        {
                            hasMatch--;
                        }
                    }
                    left++;
                }
            }
            return minSubLen == s.Length + 1? "" : s.Substring(startIndex, minSubLen);
        }
    }
}
