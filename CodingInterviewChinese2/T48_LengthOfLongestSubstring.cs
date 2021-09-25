        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T48_LengthOfLongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = s.Length;
            Dictionary<char, int> window = new Dictionary<char, int>();
            int maxLength = 0;
            for (int i = -1, j = 0; j < length; j++)
            {
                char c = s[j];
                if (window.ContainsKey(c))
                {
                    i = window[c] > i ? window[c] : i;
                    window[c] = j;
                }
                else
                {
                    window.Add(c, j);
                }
                int currLength = j - i;
                maxLength = currLength > maxLength ? currLength : maxLength;
            }
            return maxLength;
        }
    }
}
