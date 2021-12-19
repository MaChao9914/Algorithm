using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T1129_ShortestAlternatingPaths
    {
        public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
        {
            //第 i 项表示从节点 i 出发以红色或蓝色边能到达的节点集合；
            List<List<int>> redTargets = new List<List<int>>(n);
            List<List<int>> blueTargets = new List<List<int>>(n);
            for (int i = 0; i < n; i++)
            {
                redTargets.Add(new List<int>());
                blueTargets.Add(new List<int>());
            }
            foreach (var item in redEdges)
            {
                redTargets[item[0]].Add(item[1]);
            }
            foreach (var item in blueEdges)
            {
                blueTargets[item[0]].Add(item[1]);
            }

            //距离矩阵，第一列记录红色边 0->n 的最短距离，第二列记录绿色边 0->n 的最短距离
            int[][] dist = new int[n][];
            //0->0距离默认为0
            dist[0] = new int[] { 0, 0 };
            //其余初始化为-1
            for (int i = 1; i < n; i++)
            {
                dist[i] = new int[] { -1, -1 };
            }

            return BFS(n, redTargets, blueTargets, dist);
        }

        /// <summary>
        /// 广度搜索
        /// </summary>
        /// <param name="n">节点数</param>
        /// <param name="redTargets">节点 i 以红边到达的节点集合</param>
        /// <param name="blueTargets">节点 i 以蓝边到达的节点集合</param>
        /// <param name="dist">距离矩阵</param>
        /// <returns></returns>
        private int[] BFS(int n, List<List<int>> redTargets, List<List<int>> blueTargets, int[][] dist)
        {
            int stepNum = 0;
            //记录以红边或者蓝边搜索的节点队列
            Queue<int> redStartQueue = new Queue<int>();
            Queue<int> blueStartQueue = new Queue<int>();
            redStartQueue.Enqueue(0);
            blueStartQueue.Enqueue(0);

            //分别找到 红->蓝->红 或者 蓝->红->蓝 的最短路径
            while (redStartQueue.Count != 0 || blueStartQueue.Count != 0)
            {
                stepNum++;

                int redLength = redStartQueue.Count, blueLength = blueStartQueue.Count;
                for (int i = 0; i < redLength; i++)
                {
                    int startNode = redStartQueue.Dequeue();
                    var nodes = redTargets[startNode];
                    foreach (var node in nodes)
                    {
                        if (dist[node][0] == -1)
                        {
                            dist[node][0] = stepNum;
                            blueStartQueue.Enqueue(node);
                        }
                    }
                }

                for (int i = 0; i < blueLength; i++)
                {
                    int starNode = blueStartQueue.Dequeue();
                    var nodes = blueTargets[starNode];
                    foreach (var node in nodes)
                    {
                        if (dist[node][1] == -1)
                        {
                            dist[node][1] = stepNum;
                            redStartQueue.Enqueue(node);
                        }
                    }
                }
            }

            //合并两种颜色的矩阵
            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                ans[i] = (dist[i][0] == -1 && dist[i][1] == -1) ? -1 :
                    ((dist[i][0] == -1 || dist[i][1] == -1) ?
                    Math.Max(dist[i][0], dist[i][1]) : Math.Min(dist[i][0], dist[i][1]));
            }
            return ans;
        }
    }
}
