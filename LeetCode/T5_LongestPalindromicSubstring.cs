using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T5_LongestPalindromicSubstring
    {
        /// <summary>
        /// 动态规划
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome1(string s)
        {
            int len = s.Length;
            if (len < 2)
                return s;

            bool[,] dp = new bool[len, len];
            int maxSubLen = 0;
            int startIndex = 0;
            //因为 left<right 而且还要保证dp[left + 1, right - 1] 已经计算，所以要一列一列的去赋值
            for (int right = 0; right < len; right++)
            {
                for (int left = 0; left <= right; left++)
                {
                    if (right - left == 0)//子串长度为1
                        dp[left, right] = true;
                    else if (right - left == 1)//子串长度为2
                        dp[left, right] = (s[right] == s[left]);
                    else
                        dp[left, right] = (s[right] == s[left]) && dp[left + 1, right - 1];

                    if (dp[left,right] && right+1-left > maxSubLen)
                    {
                        maxSubLen = right + 1 - left;
                        startIndex = left;
                    }
                }
            }
            return s.Substring(startIndex, maxSubLen);
        }

        /// <summary>
        /// 中心扩展算法
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome2(string s)
        {
            int len = s.Length;
            if (len < 2)
                return s;
            int start = 0, mxSubLen = 0;
            for (int i = 0; i < len; i++)
            {
                var len1 = ExpandAroundCenter(s, i, i);
                var len2 = ExpandAroundCenter(s, i, i + 1);
                var temp = Math.Max(len1, len2);
                if (temp > mxSubLen)
                {
                    mxSubLen = temp;
                    start = i - (mxSubLen - 1)/2;//由方程组 end + 1 -start = l;(end + start)/2 = i 解得；
                }
            }
            return s.Substring(start, mxSubLen);
        }

        public int ExpandAroundCenter(string s, int center1, int center2)
        {
            while(center1 >=0 && center2 < s.Length && s[center1] == s[center2])
            {
                center1--;
                center2++;
            }
            return center2 + 1 - center1 - 2;//退出循环时的c1至c2已不是回文
        }

        /// <summary>
        /// Manacher 算法
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome3(string s)
        {
            return "";
        }

    }
}
