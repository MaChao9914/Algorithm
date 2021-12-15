using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T494_FindTargetSumWays
    {
        private int _count = 0;
        public int FindTargetSumWays(int[] nums, int target)
        {
            Backtrack(nums, target, 0);
            return _count;
        }

        private void Backtrack(int[] nums, int target, int index)
        {
            if (index == nums.Length)
            {
                if (target == 0)
                    _count++;
            }
            else
            {
                Backtrack(nums, target - nums[index], index + 1);
                Backtrack(nums, target + nums[index], index + 1);
            }
        }
    }
}
