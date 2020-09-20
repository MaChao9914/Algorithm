using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeetCode
{
    public class T15_ThreeSum
    {
        /// <summary>
        /// 排序+双指针
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            int length = nums.Length;
            if (length < 3)
                return result;

            //对数组进行排序
            Array.Sort(nums);
            //遍历第一个数字a
            for (int first = 0; first < length; first++)
            {
                //当前枚举数不能和上一个相同
                if (first > 0 && nums[first] == nums[first-1])
                    continue;

                //定义第三个数c的指针（索引），初始值指向数组最右端
                int third = length - 1;
                //b+c的目标值
                int target = -nums[first];
                //遍历第二个数b
                for (int second = first + 1; second < length; second++)
                {
                    //当前枚举数不能和上一个相同
                    if (second> first + 1 && nums[second] == nums[second - 1])
                        continue;

                    //需要保证b在c的左侧
                    //b+c>-a防止c指针移动过多
                    while (second < third && nums[second] + nums[third] > target)
                        third--;

                    // 如果指针重合，随着 b 后续的增加
                    // 就不会有满足 a+b+c=0 并且 b<c 的 c 了，可以退出循环
                    if (second == third)
                    {
                        break;
                    }
                    if (nums[second] + nums[third] == target)
                    {
                        List<int> vs = new List<int>() { nums[first], nums[second], nums[third] };
                        result.Add(vs);
                    }
                }
            }
            return result;
        }
    }
}
