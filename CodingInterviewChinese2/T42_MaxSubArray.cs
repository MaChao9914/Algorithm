using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T42_MaxSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int length = nums.Length;
            int currentValue = nums[0];
            int maxValue = currentValue;
            for (int i = 1; i < length; i++)
            {
                currentValue = currentValue + nums[i];

                if (currentValue < nums[i])
                    currentValue = nums[i];

                if (currentValue > maxValue)
                    maxValue = currentValue;
            }
            return maxValue;
        }
    }
}
