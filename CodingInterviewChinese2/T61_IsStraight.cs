using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T61_IsStraight
    {
        public bool IsStraight(int[] nums)
        {
            if (nums == null || nums.Length < 5)
                return false;
            int joker = 0;
            Array.Sort(nums);
            for (int i = 0; i < 4; i++)
            {
                if (nums[i] == 0)
                    joker++;
                else if (nums[i] == nums[i + 1])
                    return false;
            }

            return nums[4] - nums[joker] < 5 ? true : false;
        }
    }
}
