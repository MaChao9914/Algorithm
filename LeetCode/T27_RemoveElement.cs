using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T27_RemoveElement
    {
        /// <summary>
        /// 双指针
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int l = 0;
            int r = nums.Length - 1;
            while (l < r)//left 等于 val时将right赋值给left
            {
                if (nums[l] == val)
                {
                    nums[l] = nums[r];
                    r--;
                }
                else
                {
                    l++;
                }
            }
            return l;
        }
    }
}
