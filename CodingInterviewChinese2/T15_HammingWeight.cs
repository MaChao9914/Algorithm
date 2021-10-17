using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T15_HammingWeight
    {
        public int HammingWeight1(uint n)
        {
            int ans = 0;
            uint flag = 1;
            while (flag != 0)
            {
                if ((n & flag) != 0)
                    ans++;
                flag = flag << 1;
            }
            return ans;
        }

        /// <summary>
        /// n & (n−1)，其预算结果恰为把 n 的二进制位中的最低位的 1 变为 0 之后的结果
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int HammingWeight2(uint n)
        {
            int ans = 0;
            while (n != 0)
            {
                ans++;
                n = n & (n - 1);
            }
            return ans;
        }
    }
}
