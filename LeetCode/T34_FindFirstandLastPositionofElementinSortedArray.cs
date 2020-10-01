using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class T34_FindFirstandLastPositionofElementinSortedArray
    {
        /// <summary>
        /// 二分搜索左右边界
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[] { -1, -1 };
            int length = nums.Length;
            if (length == 0)
            {
                return result;
            }
            result[0] = Search(nums, target, true);
            result[1] = Search(nums, target, false);
            return result;
        }

        private  int Search(int[] nums, int target, bool leftPosition)
        {
            int left = 0;
            int rigth = nums.Length;
            while (left < rigth)
            {
                int m = (left + rigth) / 2;
                if (nums[m] == target)
                {
                    if (leftPosition)//搜索左边界
                    {
                        rigth = m;
                    }
                    else
                    {
                        left = m + 1;
                    }
                }
                else if(nums[m] > target)
                {
                    rigth = m;
                }
                else if (nums[m] < target)
                {
                    left = m + 1;
                }
            }

            if (leftPosition)//左边界返回值
            {
                if (left == nums.Length)
                {
                    return -1;
                }
                return nums[left] == target ? left : -1;
            }
            else
            {
                if (left == 0)
                {
                    return -1;
                }
                return nums[left - 1] == target ? left - 1 : -1;
            }
        }
    }
}
