using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T33_SearchinRotatedSortedArray
    {
        /// <summary>
        /// 二分查找
        /// O(logn)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int m = (l + r) / 2;
                if (nums[m] == target)
                {
                    return m;
                }

                if (nums[0] <= nums[m])
                {
                    if (nums[0] <= target && target < nums[m])
                    {
                        r = m - 1;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
                else
                {
                    if (nums[m] < target && target <= nums[nums.Length -1])
                    {
                        l = m + 1;
                    }
                    else
                    {
                        r = m - 1;
                    }
                }
            }
            return -1;
        }
    }
}
