using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T96_UniqueBinarySearchTrees
    {
        /// <summary>
        /// 动态规划
        /// G(n): 长度为 n 的序列能构成的不同二叉搜索树的个数。
        /// F(i, n) : 以 i 为根、序列长度为 n 的不同二叉搜索树个数(1≤i≤n)。
        /// G(n)=f(1)+f(2)+f(3)+f(4)+...+f(n)
        /// f(i)=G(i−1)∗G(n−i)
        /// G[n]=G(0)∗G(n−1)+G(1)∗(n−2)+...+G(n−1)∗G(0)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumTrees(int n)
        {
            int[] g = new int[n + 1];
            g[0] = 1;
            g[1] = 1;

            for (int i = 2; i <= n; i++)//已知g[0]、g[1]，求出g[2]~g[n]，因为g[n]依赖于g[n-1]
            {
                for (int j = 1; j <= i; j++)
                {
                    g[i] += g[j - 1] * g[i - j];
                }
            }
            return g[n];
        }

        /// <summary>
        /// 数学：卡塔兰数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumTrees1(int n)
        {
            int c = 1;
            for (int i = 0; i < n; i++)
            {
                c = c * 2 * (2 * i + 1) / (i + 2);
            }
            return c;
        }
    }
}
