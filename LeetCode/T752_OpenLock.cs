using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class T752_OpenLock
    {
        public int OpenLock(string[] deadends, string target)
        {
            if (target.Equals("0000"))
                return 0;

            HashSet<string> deadHash = new HashSet<string>(deadends);
            if (deadHash.Contains("0000"))
                return -1;

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("0000");
            HashSet<string> hasVisited = new HashSet<string>();
            hasVisited.Add("0000");
            int ans = 0;
            while(queue.Count != 0)
            {
                ans++;
                int length = queue.Count;
                for (int i = 0; i < length; i++)
                {
                    string curr = queue.Dequeue();
                    var nexts = GetNexts(curr);//获得所有可能的组合
                    foreach (var next in nexts)
                    {
                        if(!deadHash.Contains(next) && !hasVisited.Contains(next))
                        {
                            if (next.Equals(target))
                                return ans;
                            hasVisited.Add(next);
                            queue.Enqueue(next);
                        }
                    }
                }
            }

            return -1;
        }

        private List<string> GetNexts(string current)
        {
            List<string> ans = new List<string>();

            int length = current.Length;
            for (int i = 0; i < length; i++)
            {
                char[] newStr = current.ToCharArray();

                newStr[i] = Pre(current[i]);
                ans.Add(new string(newStr));
                newStr[i] = Next(current[i]);
                ans.Add(new string(newStr));
            }
            return ans;
        }

        private char Pre(char c)
        {
            return c == '0' ? '9' : (char)(c - 1);
        }

        private char Next(char c)
        {
            return c == '9' ? '0' : (char)(c + 1);
        }
    }
}
