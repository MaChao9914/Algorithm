using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T14_1_CuttingRope
    {
        public int CuttingRope(int n)
        {
            if (n < 2)
                return 0;
            else if (n == 2)
                return 1;
            else if (n == 3)
                return 2;
            int max = 0;
            int[] k = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                if(i < 4)//小于4的部分绳子没必要剪断了
                {
                    k[i] = i;
                    continue;
                }
                for (int j = 1; j <= i/2; j++)
                {
                    int temp = k[j] * k[i - j];
                    if (temp > max)
                        max = temp;
                    k[i] = max;
                }
            }

            return k[n];
        }
    }
}
