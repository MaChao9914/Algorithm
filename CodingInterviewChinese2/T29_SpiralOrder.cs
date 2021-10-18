using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T29_SpiralOrder
    {
        public int[] SpiralOrder(int[][] matrix)
        {
            List<int> ans = new List<int>();

            int m = matrix.Length;
            if (m == 0)
                return ans.ToArray();
            int n = matrix[0].Length;
            if (n == 0)
                return ans.ToArray();

            int start = 0;
            while (2 * start < m && 2 * start < n)
            {
                int endX = n - start - 1;
                int endY = m - start - 1;
                for (int i = start; i <= endX; i++)
                {
                    ans.Add(matrix[start][i]);
                }
                if (start + 1 <= endY)
                {
                    for (int i = start + 1; i <= endY; i++)
                    {
                        ans.Add(matrix[i][endX]);
                    }

                    if (start + 1 <= endX)
                    {
                        for (int i = endX - 1; i >= start; i--)
                        {
                            ans.Add(matrix[endY][i]);
                        }
                    }
                }

                if (start + 1 < endY && start + 1 <= endX )
                {
                    for (int i = endY - 1; i > start; i--)
                    {
                        ans.Add(matrix[i][start]);
                    }
                }
                start++;
            }
            return ans.ToArray();
        }
    }
}
