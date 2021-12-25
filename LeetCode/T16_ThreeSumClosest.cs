using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T16_ThreeSumClosest
    {
        /// <summary>
        /// 排序+双指针
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int length = nums.Length;
            int ans = 1000000;

            for (int i = 0; i < length; i++)
            {
                int l = i + 1;
                int r = length - 1;
                while (l < r)
                {
                    int temp = nums[i] + nums[l] + nums[r];
                    if (target == temp)
                        return target;

                    if (Math.Abs(temp - target) < Math.Abs(ans - target))
                        ans = temp;

                    if (temp > target)
                        r--;
                    else
                        l++;
                }
            }

            return ans;
        }
    }
}
