using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T45_MinNumber
    {
        public string MinNumber1(int[] nums)
        {
            string[] strs = Array.ConvertAll(nums, i => i.ToString());

            Array.Sort(strs, (x, y) => (x + y).CompareTo(y + x));

            return string.Concat(strs);
        }
    }
}
