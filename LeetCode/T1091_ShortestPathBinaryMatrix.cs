using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T1091_ShortestPathBinaryMatrix
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            if (grid[0][0] == 1)
                return -1;

            int n = grid.Length, ans = 0;
            Queue<int[]> queue = new Queue<int[]>();//记录坐标值
            bool[,] visited = new bool[n, n];
            int[][] directions = new int[][] { //定义八个方向
                new int[] { -1, 0 },
                new int[] { -1, 1 },
                new int[] { 0, 1 },
                new int[] { 1, 1 },
                new int[] { 1, 0 },
                new int[] { 1, -1 },
                new int[] { 0, -1 },
                new int[] { -1, -1 }
            };

            queue.Enqueue(new int[] { 0, 0 });
            visited[0, 0] = true;

            while (queue.Count != 0)
            {
                ans += 1;
                int length = queue.Count;
                for (int i = 0; i < length; i++)
                {
                    var curr = queue.Dequeue();
                    if (curr[0] == n - 1 && curr[1] == n - 1)
                        return ans;
                    foreach (var direction in directions)
                    {
                        int newX = curr[0] + direction[0], newY = curr[1] + direction[1];
                        if (newX >= 0 && newX < n && newY >= 0 && newY < n && grid[newX][newY] == 0 && visited[newX, newY] == false)
                        {
                            queue.Enqueue(new int[] { newX, newY });
                            visited[newX, newY] = true;
                        }
                    }
                }
            }

            return -1;
        }
    }
}
