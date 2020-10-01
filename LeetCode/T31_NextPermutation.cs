using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class T31_NextPermutation
    {
        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while (i >=  0 && nums[i] >= nums[i+1])
            {
                i--;
            }

            if (i > 0)
            {
                int j = nums.Length - 1;
                while (j > i && nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }

            Array.Reverse(nums, i + 1, nums.Length - i - 1);
        }

        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
