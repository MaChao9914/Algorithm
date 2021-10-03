using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T57_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> ans = new List<int>();
            int i = 0, j = nums.Length - 1;

            while (i <= j)
            {
                int temp = nums[i] + nums[j];
                if (temp == target)
                {
                    ans.Add(nums[i]);
                    ans.Add(nums[j]);
                    break;
                }
                else if (temp > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return ans.ToArray();
        }
    }
}
