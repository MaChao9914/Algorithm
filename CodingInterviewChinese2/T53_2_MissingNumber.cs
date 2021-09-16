using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T53_2_MissingNumber
    {
        public int MissingNumber(int[] nums)
        {
            if (nums.Length == 0)
                return -1;
            int start = 0;
            int end = nums.Length - 1;

            while(start <= end)
            {
                int mid = (start + end) >> 1;
                int key = nums[mid];

                if (key == mid) 
                {
                    start += 1;
                }
                else
                {
                    if (mid == 0 || mid - 1 == nums[mid - 1])
                    {
                        return mid;
                    }
                    end -= 1;
                }
            }
            return nums.Length;
        }


    }
}
