using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T03_FindRepeatNumber
    {
        public static int FindRepeatNumber1(int[] nums)
        {
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] < 0 || nums[i] > length - 1)
                    return -1;
            }

            int j = 0;
            while (true)
            {
                if (j >= length)
                    return -1;

                int temp = nums[j];
                if (temp == j)
                {
                    j++;
                    continue;
                }

                if (temp == nums[temp])
                    return temp;

                nums[j] = nums[temp];
                nums[temp] = temp;
            }
        }

        public static int FindRepeatNumber2(int[] nums)
        {
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] < 0 || nums[i] > length - 1)
                    return -1;
            }
        }
    }
}
