using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleAppHW
{
    public class Program
    {
        public static void Main()
        {
            Test1();

            Test2();
            
            Test3();

            //string line;
            //while ((line = System.Console.ReadLine()) != null)
            //{ // 注意 while 处理多个 case
            //    string[] tokens = line.Split();
            //    System.Console.WriteLine(int.Parse(tokens[0]) + int.Parse(tokens[1]));
            //}
            //Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// LeetCode621 任务调度器
        /// </summary>
        static void Test3()
        {
            string line = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] tasks = line.Split(',');
            string[] distinct = tasks.Distinct().ToArray();
            int ans = 0;

            if (distinct.Length == tasks.Length)
            {
                Console.WriteLine(tasks.Length);
                return;
            }

            if (n > distinct.Length - 1)
            {
                ans = n + 1;
                ans += (tasks.Length - distinct.Length) + 2 * (tasks.Length - distinct.Length - 1);
                Console.WriteLine(ans);
                return;
            }
            else
            {

            }
        }

        /// <summary>
        /// 类似于 LeetCode1944 队列中可以看到的人数
        /// </summary>
        static void Test2()
        {
            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int[] height = line.Split().Select(x => int.Parse(x)).ToArray();
            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                int temp = height.Skip(i + 1).FirstOrDefault(x => x > height[i]);
                if (temp == 0)
                    ans[i] = 0;
                else
                    ans[i] = Array.IndexOf(height, temp);
            }
            var ansStr = string.Join(" ", ans);
            Console.WriteLine(ansStr);
        }

        /// <summary>
        /// LeetCode1047 删除字符串中的所有相邻重复项
        /// </summary>
        static void Test1()
        {
            string line = Console.ReadLine();
            int length = line.Length;
            if (length == 0)
            {
                Console.WriteLine(0);
                return;
            }

            Stack<char> newStr = new Stack<char>();
            var temp = line.ToLower();
            foreach (var ch in temp)
            {
                if (ch < 'a' || ch > 'z')
                {
                    Console.WriteLine(0);
                    return;
                }
            }

            var last = ' ';
            for (int i = 0; i < length; i++)
            {
                var ch = line[i];
                if (newStr.Count == 0)
                {
                    if (ch != last)
                    {
                        newStr.Push(ch);
                    }
                }
                else
                {
                    if (newStr.Peek() == ch)
                    {
                        newStr.Pop();
                    }
                    else
                    {
                        if (ch != last)
                        {
                            newStr.Push(ch);
                        }
                    }
                }
                last = ch;
            }

            Console.WriteLine(newStr.Count);
        }
    }
}
