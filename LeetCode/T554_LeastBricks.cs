using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T554_LeastBricks
    {
        public int LeastBricks(IList<IList<int>> wall)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            foreach (var item in wall)
            {
                int sum = 0;
                int n = item.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    sum += item[i];
                    if (!pairs.ContainsKey(sum))
                        pairs.Add(sum, 1);
                    else
                        pairs[sum] += 1;
                }
            }
            int max = 0;
            foreach (var item in pairs)
            {
                max = Math.Max(max, item.Value);
            }
            return wall.Count - max;
        }
    }
}
