using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T58_2_ReverseLeftWords
    {
        public static string ReverseLeftWords(string s, int n)
        {
            int length = s.Length;
            if (n < 0 || n > length)
                return s;
            string temp = Reverse(s, 0, n - 1);
            temp = Reverse(temp, n, length - 1);
            temp = Reverse(temp, 0, length - 1);
            return temp;
        }

        static string Reverse(string s, int start, int end)
        {
            //StringBuilder ans = new StringBuilder(s);
            var ans = s.ToCharArray();
            for (int i = start, j = end; i <= j ; i++, j--)
            {
                var temp = ans[i];
                ans[i] = ans[j];
                ans[j] = temp;
            }
            return new string(ans);
        }

        public string ReverseLeftWords2(string s, int n)
        {
            int len = s.Length;
            char[] t = new char[len];
            for (int i = 0; i < len; ++i)
            {
                int idx = (i - n) % len; //左旋，所以是减
                if (idx < 0) 
                    idx += len; //超出左边界则移到最右边
                t[idx] = s[i];
            }
            return new string(t);
        }

        public static string ReverseLeftWords3(string s, int n)
        {
            return s.Substring(n) + s.Substring(0, n);
        }
    }
}
