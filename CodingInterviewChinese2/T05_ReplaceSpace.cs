using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T05_ReplaceSpace
    {
        public static string ReplaceSpace(string s)
        {
            int length = s.Length;
            int spaceCount = s.Count(c => c.Equals(' '));
            int newLength = length + spaceCount * 2;
            char[] chars = new char[newLength];
            for (int i = length - 1, j = newLength - 1; i >= 0; --i)
            {
                char temp = s[i];
                if (temp.Equals(' '))
                {
                    chars[j--] = '0';
                    chars[j--] = '2';
                    temp = '%';
                }
                chars[j--] = temp;
            }

            string ans = new string(chars);
            return ans;
        }

        public static string ReplacSpace(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in s)
            {
                if(item.Equals(' '))
                {
                    stringBuilder.Append("%20");
                }
                else
                {
                    stringBuilder.Append(item);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
