using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T46_TranslateNum
    {
        public int TranslateNum1(int num)
        {
            string s = Convert.ToString(num);
            int a = 1, b = 1;
            for (int i = s.Length; i >= 2; i--)
            {
                string temp = s.Substring(i - 2, 2);
                int c = temp.CompareTo("10") >= 0 && temp.CompareTo("25") <= 0 ? a + b : a;
                b = a;
                a = c;
            }
            return a;
        }
        public int TranslateNum2(int num)
        {
            int a = 1, b = 1;
            while (num != 0)
            {
                int temp = num % 100;
                int c = temp >= 10 && temp <= 25 ? a + b : a;
                b = a;
                a = c;
                num = num / 10;
            }
            return a;
        }
    }
}
