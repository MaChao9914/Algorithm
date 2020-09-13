using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T39_CombinationSum
    {
        /// <summary>
        /// 搜索回溯；类似的题转化成空间树
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="target"></param>
        public string CombinationSum(int[] candidates, int target)
        {
            List<int[]> result = new List<int[]>();
            List<int> combine = new List<int>();
            DFS(candidates, target, combine, 0, result);
            return JsonConvert.SerializeObject(result);
        }
        /// <summary>
        /// DFS深度优先搜索；BFS广度优先搜索；
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="target"></param>
        /// <param name="combine"></param>
        /// <param name="index"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        private void DFS(int[] candidates, int target, List<int> combine, int index, List<int[]> result)
        {
            if (index == candidates.Length)
                return ;

            if (target == 0)
            {
                result.Add(combine.ToArray());
                return;
            }

            //结果数组combine中添加当前索引数
            int target_new =target - candidates[index];
            if (target_new >= 0)
            {
                combine.Add(candidates[index]);
                DFS(candidates, target_new, combine, index, result);
                combine.RemoveAt(combine.Count - 1);
            }

            //跳过当前index数
            DFS(candidates, target, combine, index + 1, result);
        }
    }
}
