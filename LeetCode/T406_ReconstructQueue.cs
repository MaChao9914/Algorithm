using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T406_ReconstructQueue
    {
        /// <summary>
        /// 高到底
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public int[][] ReconstructQueue(int[][] people)
        {
            Array.Sort<int[]>(people, (x, y) =>
            {
                if (x[0] != y[0])
                    return y[0] - x[0];
                else
                    return x[1] - y[1];//因为i-1会影响第i个人(都比i高),所以升序
            });

            List<int[]> ans = new List<int[]>();
            foreach (var item in people)
            {
                ans.Insert(item[1], item);
            }
            return ans.ToArray();
        }

        /// <summary>
        /// 低到高排序
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public int[][] ReconstructQueue2(int[][] people)
        {
            Array.Sort<int[]>(people, (x, y) =>
            {
                if (x[0] != y[0])
                    return x[0] - y[0];
                else
                    return y[1] - x[1];//因为第i+1个人会影响前i个人（都比i高），所有降序，先把位置占了
            });

            int m = people.Length;
            int[][] ans = new int[m][];
            foreach (var item in people)
            {
                int location = item[1] + 1;
                for (int i = 0; i < m; i++)
                {
                    if(ans[i] == null)//保证前面有location个空位置
                    {
                        --location;
                        if(location == 0)
                        {
                            ans[i] = item;
                            break;
                        }
                    }
                }
            }
            return ans;
        }
    }
}
