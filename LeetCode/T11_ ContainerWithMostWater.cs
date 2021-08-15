using System;

namespace LeetCode
{
    public class T11__ContainerWithMostWater
    {
        /// <summary>
        /// 双指针
        /// 时间复杂度O(n);空间复杂度O(1)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxContainer(int[] height)
        {
            int result = 0;
            int left = 0, right = height.Length - 1;

            while(left < right)
            {
                int temp = Math.Min(height[left], height[right]) * (right - left);
                result = Math.Max(result, temp);
                if (height[left] <= height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return result;
        }
    }
}
