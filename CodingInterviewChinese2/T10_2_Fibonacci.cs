using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T10_2_Fibonacci
    {
        public int NumWays(int n)
        {
            if (n == 0)
                return 1;
            if (n <= 2)
                return n;
            const int MOD = 1000000007;
            int temp1 = 1;
            int temp2 = 2;
            for (int i = 3; i <= n; i++)
            {
                int result = (temp1 + temp2) % MOD;
                temp1 = temp2;
                temp2 = result;
            }
            return temp2;
        }

        public int NumWays2(int n)
        {
            if (n == 0)
                return 1;
            if (n <= 2)
                return n;
            const int MOD = 1000000007;
            int temp1 = 0, temp2 = 1, result = 2;
            for (int i = 3; i <= n; i++)
            {
                temp1 = temp2;
                temp2 = result;
                result = (temp1 + temp2) % MOD;
            }
            return result;
        }
    }
}
