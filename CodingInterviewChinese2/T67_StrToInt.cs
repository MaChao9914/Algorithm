using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T67_StrToInt
    {
        public int StrToInt(string str)
        {
            int length = str.Length, idx = 0, sign = 1;
            long ans = 0;

            while (idx < length && str[idx] == ' ') //寻找到的第一个非空字符
                idx++;
            
            if (idx == length)//全为空
                return 0;

            if (str[idx] == '-')
            {
                sign = -1;
                idx++;
            }
            else if (str[idx] == '+')
            {
                idx++;
            }

            while (idx < length && str[idx] >= '0' && str[idx] <= '9')
            {
                var cur = str[idx++] - '0';
                ans = ans * 10 + cur;

                if (ans > int.MaxValue)
                    return sign == 1 ? int.MaxValue : int.MinValue;
            }

            return sign == 1 ? (int)ans : (int)-ans;
        }
    }
}