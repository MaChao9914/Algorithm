using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T14_2_CuttingRope
    {
        public int CuttingRope(int n)
        {
            //if (n < 2)
            //    return 0;
            //else if (n == 2)
            //    return 1;
            //else if (n == 3)
            //    return 2;
            //int[] k = new int[n + 1];
            //int p = (int)1e9 + 7;
            //for (int i = 1; i <= n; i++)
            //{
            //    int max = 0;
            //    if (i < 4)//小于4的部分绳子没必要剪断了
            //    {
            //        k[i] = i;
            //        continue;
            //    }
            //    for (int j = 1; j <= i / 2; j++)
            //    {
            //        int temp = (k[j] * k[i - j]) % p;
            //        if (temp > max)
            //            max = temp;
            //    }
            //    k[i] = max;
            //}

            //return k[n];
            if (n < 4) return n - 1;
            long res = 1;
            while (n > 4)
            {
                res %= 1000000007;
                res *= 3;
                n -= 3;
            }
            res *= n;
            res %= 1000000007;
            return (int)res;
        }

    }
}
