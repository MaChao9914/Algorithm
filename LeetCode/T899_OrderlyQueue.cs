using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class T899_OrderlyQueue
    {
        public string OrderlyQueue(string s, int k)
        {
            string ans = s;
            if(k == 1)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    string temp = s.Substring(i) + s.Substring(0, i);
                    if (temp.CompareTo(ans) < 0)
                        ans = temp;
                }
            }
            else
            {
                var temp = s.ToCharArray();
                Array.Sort(temp);
                ans = new string(temp);
            }
            return ans;
        }
    }
}
