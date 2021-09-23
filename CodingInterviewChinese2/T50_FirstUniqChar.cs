using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T50_FirstUniqChar
    {
        public char FirstUniqChar(string s)
        {
            var a = s.FirstOrDefault(c => s.IndexOf(c).Equals(s.LastIndexOf(c)));
            return a == default(char) ? ' ' : a;
        }

        public char FirstUniqChar2(string s)
        {
            int[] map = new int[26];

            foreach (var c in s)
            {
                map[c - 'a'] += 1;
            }
            foreach (var c in s)
            {
                if (map[c - 'a'] == 1)
                    return c;
            }
            return ' ';
        }
    }
}
