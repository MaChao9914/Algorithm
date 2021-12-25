using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T17_PrintNumbers
    {
        /// <summary>
        /// 因为返回 int[] 所以不考虑大数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] PrintNumbers1(int n)
        {
            int end = (int)Math.Pow(10, n) - 1;
            int[] ans = new int[end];
            for (int i = 0; i < end; i++)
            {
                ans[i] = i + 1;
            }
            return ans;
        }

        /// <summary>
        /// 考虑大数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        
        public void PrintNumbers2(int n)
        {
            var sb = new StringBuilder();
            DFS(0, n, sb);
        }
        void DFS(int idx, int n, StringBuilder sb)
        {
            if (idx == n)
            {
                //sb为空时，代表数字0，因此这里可以实现跳过0，从1开始打印
                if (sb.Length > 0)
                {
                    Console.WriteLine(sb);
                }
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                if (sb.Length > 0 || i > 0) 
                    sb.Append(i);//前导0不会Append

                DFS(idx + 1, n, sb);

                if (sb.Length > 0) 
                    sb.Length--;//回溯
            }
        }
    }
}
