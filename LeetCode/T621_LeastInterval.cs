using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T621_LeastInterval
    {
        /// <summary>
        /// 模拟
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int LeastInterval1(char[] tasks, int n)
        {
            //统计每一种任务的频次
            var freq = tasks.GroupBy(t => t);

            //记录每种任务的下次执行时间和未执行的次数
            List<Tuple<int, int>> tuples = new List<Tuple<int, int>>();
            foreach (var item in freq)
            {
                Tuple<int, int> tuple = new Tuple<int, int>(1, item.Count());
                tuples.Add(tuple);
            }

            //当前时间；任务总数
            int time = 0, length = tasks.Length;
            for (int i = 0; i < length; i++)
            {
                time++;

                //从还未执行完的任务中选出最近需要执行的任务的时间
                int minNext = tuples
                    .Where(x => x.Item2 != 0)
                    .Min(x => x.Item1);

                time = Math.Max(time, minNext);

                //选出符合执行时间内 剩余执行次数最多的任务
                int excuteTaskIndex = tuples
                    .FindIndex(0, x => x.Item1 <= time && x.Item2 == tuples.Where(x => x.Item2 != 0 && x.Item1 <= time).Max(x => x.Item2));

                //更新下次执行时间和剩余执行次数
                tuples[excuteTaskIndex] = new Tuple<int, int>(time + n + 1, tuples[excuteTaskIndex].Item2 - 1);
            }
            return time;
        }

        /// <summary>
        /// 基于桶思想
        /// 1、记录最大任务数量 N，看一下任务数量并列最多的任务有多少个，
        /// 即最后一个桶子的任务数 X，计算NUM1=(N-1)*(n+1)+x
        /// 2、NUM2=tasks.size()
        /// 输出其中较大值即可
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int LeastInterval2(char[] tasks, int n)
        {
            //统计每一种任务的频次
            var freq = tasks.GroupBy(t => t);

            //计算执行次数最多的任务的次数
            int maxExec = freq.Max(x => x.Count());

            //计算执行次数等于最大执行次数的任务数量
            int maxCount = freq.Where(x => x.Count() == maxExec).Count();

            return Math.Max((maxExec - 1) * (n + 1) + maxCount, tasks.Length);
        }
    }
}
