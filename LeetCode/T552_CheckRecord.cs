using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T552_CheckRecord
    {
        public int CheckRecord(int n)
        {
            const int MOD = 1000000007;
            int[,,] dp = new int[n + 1, 2, 3];
            dp[0, 0, 0] = 1;
            for (int i = 1; i <= n; i++)
            {
                //以p结尾
                for (int j = 0; j <= 1; j++)
                {
                    for (int k = 0; k <= 2; k++)
                    {
                        dp[i, j, 0] = (dp[i, j, 0] + dp[i - 1, j, k]) % MOD;
                    }
                }
                //以A结尾
                for (int k = 0; k <= 2; k++)
                {
                    dp[i, 1, 0] = (dp[i, 1, 0] + dp[i - 1, 0, k]) % MOD;
                }
                //以L结尾
                for (int j = 0; j <= 1; j++)
                {
                    for (int k = 1; k <= 2; k++)
                    {
                        dp[i, j, k] = (dp[i, j, k] + dp[i - 1, j, k - 1]) % MOD;
                    }
                }
            }
            int ans = 0;
            for (int j = 0; j <= 1; j++)
            {
                for (int k = 0; k <= 2 ; k++)
                {
                    ans = (ans + dp[n, j, k]) % MOD;
                }
            }
            return ans;
        }
    }
}
