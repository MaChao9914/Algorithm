using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    public class T53_1_Search
    {
        public static int Search(int[] nums, int target)
        {
            int length = nums.Length;
            if (length == 0)
                return 0;

            int first = GetFirstIndex(nums, target, 0, length - 1);
            int last = GetLastIndex(nums, target, 0, length - 1);
            if (first > -1 && last > -1)
                return last - first + 1;
            return 0;
        }

        static int GetFirstIndex(int[] nums, int target, int start, int end)
        {
            if (start > end)
                return -1;
            int mid = (start + end) >> 1;
            int key = nums[mid];

            if (key == target && (mid == 0 || nums[mid - 1] != key))
                return mid;

            if (key >= target)
                return GetFirstIndex(nums, target, 0, mid - 1);
            else
                return GetFirstIndex(nums, target, mid + 1, end);
        }

        static int GetLastIndex(int[] nums, int target, int start, int end)
        {
            if (start > end)
                return -1;
            int mid = (start + end) >> 1;
            int key = nums[mid];

            if (key == target && (mid == nums.Length - 1 || nums[mid + 1] != key))
                return mid;

            if (key > target)
                return GetLastIndex(nums, target, 0, mid - 1);
            else
                return GetLastIndex(nums, target, mid + 1, end);
        }
    }
}
