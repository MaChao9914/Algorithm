using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T58_1_ReverseWords
    {
        public string ReverseWords1(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            int start = 0, end = s.Length - 1;
            s = Reverse(s, start, end);
            end = 0;
            while (end < s.Length - 1)
            {
                end = s.IndexOf(' ', start);
                if (end == -1)
                    end = s.Length;
                s = Reverse(s, start, end - 1);
                start = end + 1;
            }
            s = s.Trim();
            for (start = 0; start < s.Length; start++)
            {
                if (s[start] == ' ' && s[start + 1] == ' ')
                {
                    s = s.Remove(start + 1, 1);
                    start--;
                }
            }
            
            return s;
        }

        static string Reverse(string s, int start, int end)
        {
            var ans = s.ToCharArray();
            for (int i = start, j = end; i <= j; i++, j--)
            {
                var temp = ans[i];
                ans[i] = ans[j];
                ans[j] = temp;
            }
            return new string(ans);
        }

        public string ReverseWords2(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            StringBuilder ans = new StringBuilder();
            for (int i = s.Length - 1, j = i; i >= -1; i--)
            {
                if (i == -1 || s[i] == ' ')
                {
                    ans.Append(s.Substring(i + 1, j - i));
                    ans.Append(' ');
                }
                while (i != -1 && s[i] == ' ')
                {
                    i--;
                    j = i;
                }
            }
            return ans.ToString().Trim();
        }
    }
}
