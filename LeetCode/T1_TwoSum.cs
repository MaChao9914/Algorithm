using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T1_TwoSum
    {
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
    }
}
