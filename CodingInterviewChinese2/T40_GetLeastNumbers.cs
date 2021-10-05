using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewChinese2
{
    class T40_GetLeastNumbers
    {
        public int[] GetLeastNumbers2(int[] arr, int k)
        {
            if (k <= 0)
                return new int[0];
            if (arr == null || arr.Length < k)
                return arr;

            List<int> ans = new List<int>(k);
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                if(i<k)
                {
                    ans.Add(temp);
                    continue;
                }

                int max = ans.Max();
                if(temp < max)
                {
                    ans.Remove(max);
                    ans.Add(temp);
                }
            }
            return ans.ToArray();
        }

        public int[] GetLeastNumbers1(int[] arr, int k)
        {
            if (k <= 0)
                return new int[0];
            if (arr == null || arr.Length < k)
                return arr;

            int start = 0, end = arr.Length - 1;
            int partition = FindPartition(arr, start, end);
            while (partition != k -1)
            {
                if (partition < k - 1)
                    partition = FindPartition(arr, start = partition + 1, end);
                else
                    partition = FindPartition(arr, start, end = partition - 1);
            }
            return arr.Take(k).ToArray();
        }

        int FindPartition(int[] arr, int start, int end)
        {
            int key = arr[start];

            while (start < key)
            {
                while (start < key && arr[end] >= key)
                    end--;
                arr[start] = arr[end];
                while (start < key && arr[start] <= key)
                    start++;
                arr[end] = arr[start];
            }
            arr[start] = key;
            return start;
        }
    }
}
