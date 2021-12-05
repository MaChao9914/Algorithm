using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class T49__GroupAnagrams
    {
        /// <summary>
        /// 排序数组分类
        /// 字母异位词就是两个字符串中的字母都是一样的，只不过顺序被打乱了
        /// 算法复杂度 O(nklogk);空间复杂度O(nk)
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupAnagrams1(string[] strs)
        {
            if (strs == null && strs.Length == 0)
                return new List<IList<string>>();
            Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                var chars = str.ToCharArray();
                Array.Sort(chars);
                var keyStr = new string(chars);
                
                if (!pairs.ContainsKey(keyStr))
                {
                    List<string> vs = new List<string>();
                    pairs.Add(keyStr, vs);
                }
                pairs[keyStr].Add(str);
            }
            List<IList<string>> ans = new List<IList<string>>();
            ans.AddRange(pairs.Values);
            return ans;
        }

        /// <summary>
        /// 按计数分类
        /// 算法复杂度 O(nk);空间复杂度O(nk)
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupAnagrams2(string[] strs)
        {
            if (strs == null && strs.Length == 0)
                return new List<IList<string>>();
            Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                char[] chars = new char[26];
                foreach (var c in str.ToCharArray())
                {
                    chars[c - 'a']++;
                }
                string keyStr = new string(chars);
                if (!pairs.ContainsKey(keyStr))
                {
                    List<string> vs = new List<string>();
                    pairs.Add(keyStr, vs);
                }
                pairs[keyStr].Add(str);
            }
            List<IList<string>> ans = new List<IList<string>>();
            ans.AddRange(pairs.Values);
            return ans;
        }

        public IList<IList<string>> GroupAnagrams3(string[] strs)
        {
            List<IList<string>> ans = new List<IList<string>>();
            if (strs == null || strs.Length == 0)
                return ans;
            Dictionary<string, IList<string>> keyValues = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                char[] chs = new char[26];

                foreach (var ch in str)
                {
                    chs[ch - 'a']++;
                }
                var key = new string(chs);
                if (keyValues.ContainsKey(key))
                    keyValues[key].Add(str);
                else
                {
                    List<string> value = new List<string>();
                    value.Add(str);
                    keyValues.Add(key, value);
                }
            }
            ans = keyValues.Values.ToList();
            return ans;
        }
    }
}
