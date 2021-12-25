using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T16_MyPow
    {
        public double MyPow1(double x, int n)
        {
            double ans = x;
            if (x == 0)
                return ans;
            if (x == 1 || n == 0)
                return 1;

            for (int i = 1; i < Math.Abs(n); i++)
            {
                ans = ans * x;
            }

            if (n < 0)
                return 1 / ans;
            return ans;
        }

        /// <summary>
        /// LeetCode 50 题
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double MyPow2(double x, int n)
        {
            if (x == 0)
                return 0;
            if (n == 0)
                return 1;
            long b = n;//当 n = -2147483648 时执行 n = -n 会因越界而赋值出错。解决方法是先将 n 存入 long 变量 b ，后面用 b 操作即可
            if (b < 0)
            {
                x = 1 / x;
                b = -b;
            }

            double ans = 1.0;
            while (b > 0)
            {
                if ((b & 1) == 1)
                    ans *= x;
                x = x * x;
                b = b >> 1;
            }
            
            return ans;
        }
    }
}
