using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T1254_ClosedIsland
    {
        public int ClosedIsland(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int ans = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 0 && IsClosed(grid, m, n, i, j))
                    {
                        ans += 1;
                    }
                }
            }
            return ans;
        }

        private bool IsClosed(int[][] grid, int rows, int cols, int i, int j)
        {
            if (i < 0 || i >= rows || j < 0 || j >= cols)
                return false;

            if (grid[i][j] != 0)
                return true;

            grid[i][j] = 2;//用来充当visited的数组，标记已被遍历过

            bool b1 = IsClosed(grid, rows, cols, i - 1, j);
            bool b2 = IsClosed(grid, rows, cols, i + 1, j);
            bool b3 = IsClosed(grid, rows, cols, i, j - 1);
            bool b4 = IsClosed(grid, rows, cols, i, j + 1);

            return b1 && b2 && b3 & b4;//注意是 且 所以要这样分开写
        }
    }
}
