using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Sorter2
    {
        public static void Swap<T>(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static T[] BubbleSort<T>(T[] arr) where T : IComparable
        {
            int length = arr.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if(arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Swap<T>(arr, j, j + 1);
                    }
                }
            }
            return arr;
        }

        public static T[] SelectSort<T>(T[] arr) where T : IComparable
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                int selectIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j].CompareTo(arr[selectIndex]) < 0)
                        selectIndex = j;
                }
                Swap<T>(arr, i, selectIndex);
            }
            return arr;
        }

        public static T[] InsertionSort<T>(T[] arr) where T : IComparable
        {
            int length = arr.Length;
            for (int i = 1; i < length; i++)
            {
                int j = i;
                T tempVal = arr[i];
                while (j > 0 && arr[j-1].CompareTo(tempVal) > 0)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = tempVal;
            }
            return arr;
        }

        public static T[] QuickSort<T>(T[] arr, int start, int end) where T : IComparable
        {
            if (start >= end)
                return null;
            int partition = FindPartition<T>(arr, start, end);
            QuickSort<T>(arr, start, partition - 1);
            QuickSort<T>(arr, partition + 1, end);
            return arr;
        }

        private static int FindPartition<T>(T[] arr, int start, int end) where T : IComparable
        {
            T baseVal = arr[start];
            while (start < end)
            {
                while (start < end && baseVal.CompareTo(arr[end]) <= 0)
                    end--;
                arr[start] = arr[end];

                while (start < end && baseVal.CompareTo(arr[start]) >= 0)
                    start++;
                arr[end] = arr[start];
            }
            arr[start] = baseVal;
            return start;
        } 

        public static T[] MergeSort<T>(T[] arr, int start, int end) where T : IComparable
        {
            if (start >= end)
                return null;

            int mid = (start + end) >> 1;
            MergeSort<T>(arr, start, mid);
            MergeSort<T>(arr, mid + 1, end);
            T[] arrTemp = new T[arr.Length];
            for (int i = start, k1 = start, k2 = mid + 1; i <= end; i++)
            {
                if (k1 <= mid && k2 <= end)
                {
                    if (arr[k1].CompareTo(arr[k2]) > 0)
                        arrTemp[i] = arr[k2++];
                    else
                        arrTemp[i] = arr[k1++];
                }
                else if (k1 > mid)
                    arrTemp[i] = arr[k2++];
                else if (k2 > end)
                    arrTemp[i] = arr[k1++];
            }

            for (int i = start; i <= end; i++)
            {
                arr[i] = arrTemp[i];
            }
            return arr;
        }
    }
}
