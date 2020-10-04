using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T10_RegularExpressionMatching
    {
        /// <summary>
        /// 动态规划
        ///如果 p.charAt(j) == s.charAt(i) : dp[i][j] = dp[i - 1][j - 1]；
        ///如果 p.charAt(j) == '.' : dp[i][j] = dp[i - 1][j - 1]；
        ///如果 p.charAt(j) == '*'：
        ///     如果 p.charAt(j-1) != s.charAt(i) : dp[i][j] = dp[i][j - 2] //in this case, a* only counts as empty
        ///     如果 p.charAt(j-1) == s.charAt(i) or p.charAt(j-1) == '.'：
        ///         dp[i][j] = dp[i - 1][j] //in this case, a* counts as multiple a
        ///         or dp[i][j] = dp[i][j - 1] // in this case, a* counts as single a
        ///         or dp[i][j] = dp[i][j - 2] // in this case, a* counts as empty
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool IsMatch(string s, string p)
        {
            int len_s = s.Length;
            int len_p = p.Length;
            bool[,] dp = new bool[len_s + 1, len_p + 1];
            dp[0, 0] = true;//动态划分的边界条件，表示两个空字符串是可以匹配的

            for (int i = 0; i <= len_s; i++)//i=0 情况考虑测试用例4，c*无匹配的情况
            {
                for (int j = 1; j <= len_p; j++)
                {
                    if (IsTrue(s, p, i, j))
                        dp[i, j] = dp[i - 1, j - 1];
                    else if(p[j - 1] == '*')
                    {
                        dp[i, j] = dp[i, j - 2];
                        if (IsTrue(s, p, i, j - 1))
                        {
                            dp[i, j] = dp[i - 1, j] || dp[i, j - 1] || dp[i, j];
                        }

                        //if (IsTrue(s, p, i, j - 1))
                        //{
                        //    dp[i, j] = dp[i - 1, j] || dp[i, j - 1] || dp[i, j - 2];
                        //}
                        //else if (i == 0 || p[j - 1 - 1] != s[i - 1])//in this case, a* only counts as empty
                        //{
                        //    dp[i, j] = dp[i, j - 2];
                        //}
                    }
                }
            }
            return dp[len_s, len_p];
        }

        private bool IsTrue(string s, string p, int i, int j)
        {
            if (i == 0)
                return false;
            if (p[j - 1] == '.')
            {
                return true;
            }

            return p[j - 1] == s[i - 1];
        }
    }
}
