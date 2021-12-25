using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T547_FindCircleNum
    {
        public int FindCircleNum(int[][] isConnected)
        {
            int cities = isConnected.Length;
            bool[] visited = new bool[cities];
            int circleNum = 0;
            for (int i = 0; i < cities; i++)
            {
                if (!visited[i])
                {
                    FindCircleNum(isConnected, visited, cities, i);
                    circleNum++;
                }
            }
            return circleNum;
        }

        private void FindCircleNum(int[][] isConnected, bool[] visited, int cities, int currIndex)
        {
            for (int i = 0; i < cities; i++)
            {
                if(isConnected[currIndex][i] == 1 && !visited[i])
                {
                    visited[i] = true;
                    FindCircleNum(isConnected, visited, cities, i);
                }
            }
        }
    }
}
