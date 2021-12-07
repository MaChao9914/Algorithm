using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MyCalendar
    {
        SortedDictionary<int?, int> pairs;
        public MyCalendar()
        {
            pairs = new SortedDictionary<int?, int>();
        }

        public bool Book(int start, int end)
        {
            int? prev = pairs.LastOrDefault(x => x.Key <= start).Key;
            int? next = pairs.FirstOrDefault(x => x.Key >= start).Key;
            if((prev == null || start >= pairs[prev]) && (next == null || end <= next))
            {
                pairs.Add(start, end);
                return true;
            }
            return false;
        }
    }

    public class MyCalendarTwo
    {
        SortedDictionary<int, int> pairs;
        public MyCalendarTwo()
        {
            pairs = new SortedDictionary<int, int>();
        }

        public bool Book(int start, int end)
        {
            if (pairs.ContainsKey(start))
            {
                pairs[start]++;
            }
            else
            {
                pairs.Add(start, 1);
            }
            if (pairs.ContainsKey(end))
            {
                pairs[end]--;
            }
            else
            {
                pairs.Add(end, -1);
            }
            int active = 0;
            foreach (var item in pairs.Values)
            {
                active += item;
                if (active >= 3)
                {
                    pairs[start]--;
                    pairs[end]++;
                    return false;
                }
            }
            return true;
        }
    }

    public class MyCalendarThree
    {
        SortedDictionary<int, int> pairs;
        public MyCalendarThree()
        {
            pairs = new SortedDictionary<int, int>();
        }

        public int Book(int start, int end)
        {
            if (pairs.ContainsKey(start))
            {
                pairs[start]++;
            }
            else
            {
                pairs.Add(start, 1);
            }
            if (pairs.ContainsKey(end))
            {
                pairs[end]--;
            }
            else
            {
                pairs.Add(end, -1);
            }
            int active = 0, ans = 0;
            foreach (var item in pairs.Values)
            {
                active += item;
                ans = active > ans ? active : ans;
            }
            return ans;
        }
    }
}
