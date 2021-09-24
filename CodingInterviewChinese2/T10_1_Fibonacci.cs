using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T10_1_Fibonacci
    {
        public static int Fib(int n)
        {
            if (n < 2)
                return n;
            const int MOD = 1000000007;
            int temp1 = 0;
            int temp2 = 1;
            for (int i = 2; i <= n; i++)
            {
                int result = (temp1 + temp2) % MOD;
                temp1 = temp2;
                temp2 = result;
            }
            return temp2;
        }

        public int Fib2(int n)
        {
            const int MOD = 1000000007;
            if (n < 2)
            {
                return n;
            }
            int p = 0, q = 0, r = 1;
            for (int i = 2; i <= n; ++i)
            {
                p = q;
                q = r;
                r = (p + q) % MOD;
            }
            return r;
        }
    }
}
