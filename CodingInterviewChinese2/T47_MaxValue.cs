using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T47_MaxValue
    {
        public int MaxValue(int[][] grid)
        {
            int m = grid.Length;
            if (m == 0)
                return 0;
            int n = grid[0].Length;
            if (n == 0)
                return 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0)
                        continue;
                    else if (i == 0)
                        grid[i][j] += grid[i][j - 1];
                    else if (j == 0)
                        grid[i][j] += grid[i - 1][j];
                    else
                        grid[i][j] += Math.Max(grid[i - 1][j], grid[i][j - 1]);
                }
            }
            return grid[m - 1][n - 1];
        }
    }
}
