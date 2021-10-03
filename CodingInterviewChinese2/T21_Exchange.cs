using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T21_Exchange
    {
        public int[] Exchange(int[] nums)
        {
            int length = nums.Length;

            for (int i = 0, j = length - 1; i < j;)
            {
                while (i < j && nums[i] % 2 != 0)
                    i++;

                while (i < j && nums[j] % 2 == 0)
                    j--;
                if(i < j)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }

            return nums;
        }
    }
}
