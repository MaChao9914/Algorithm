using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T1_TwoSum
    {
        /// <summary>
        /// 一遍哈希表
        ///  时间复杂度O(n)；空间复杂度O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if (keyValues.ContainsKey(temp))
                {
                    return new int[] { i, keyValues[temp] };
                }
                keyValues.Add(nums[i], i);
            }

            return null;
        }
        /// <summary>
        /// 暴力法
        /// 时间复杂度O(n^2)；空间复杂度O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == target - nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
