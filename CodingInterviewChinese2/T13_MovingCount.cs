using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T13_MovingCount
    {
        public int MovingCount(int m, int n, int k)
        {
            if (m < 1 || n < 1)
                return 0;

            bool[,] visited = new bool[m, n];

            return SumMovingCount(m, n, 0, 0, k, visited);
        }

        int SumMovingCount(int m ,int n, int r, int c, int k, bool[,] visited)
        {
            int count = 0;
            int sum = GetDigitSum(r) + GetDigitSum(c);
            if (r < 0 || r >= m || c < 0 || c >= n || sum > k || visited[r, c])
            {
                return count;
            }
            visited[r, c] = true;
            count = 1 + SumMovingCount(m, n, r - 1, c, k, visited)
            + SumMovingCount(m, n, r + 1, c, k, visited)
            + SumMovingCount(m, n, r, c - 1, k, visited)
            + SumMovingCount(m, n, r, c + 1, k, visited);
            return count;
        }

        int GetDigitSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            return sum;
        }
    }
}
