using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T27_RemoveElement
    {
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
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
