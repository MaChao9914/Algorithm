using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Sorter2
    {
        static void Swap<T>(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static T[] BubbleSort<T>(T[] arr) where T : IComparable
        {
            int length = arr.Length;
            for (int i = length -1; i > 0; --i)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1])>0)
                    {
                        Swap<T>(arr, j, j + 1);
                    }
                }
            }

            return arr;
        }

        public static T[] InsertionSort<T>(T[] arr) where T: IComparable
        {
            int length = arr.Length;
            for (int i = 1; i < length; i++)
            {
                int minIndex = i;
                T minValue = arr[i];
                while (minIndex > 0 && arr[minIndex - 1].CompareTo(minValue) > 0)
                {
                    arr[minIndex] = arr[minIndex - 1];
                    minIndex--;
                }
                arr[minIndex] = minValue;
            }

            return arr;
        }

        public static T[] MergeSort<T>(T[] arr, int startIndex, int endIndex) where T : IComparable
        {
            int length = arr.Length;

            startIndex = startIndex < 0 ? 0 : startIndex;
            endIndex = endIndex > length - 1 ? length - 1 : endIndex;

            if (startIndex >= endIndex)
                return null;

            int mid = (startIndex + endIndex) >> 1;
            T[] temp = new T[length];

            MergeSort<T>(arr, startIndex, mid);
            MergeSort<T>(arr, mid + 1, endIndex);

            for (int i = startIndex, j = startIndex, k = mid + 1; i <= endIndex; i++)
            {
                if (j <= mid && k <= endIndex)
                {
                    if (arr[j].CompareTo(arr[k])<0)
                    {
                        temp[i] = arr[j++];
                    }
                    else
                    {
                        temp[i] = arr[k++];
                    }
                }
                else if (j > mid)
                {
                    temp[i] = arr[k++];
                }
                else
                {
                    temp[i] = arr[j++];
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                arr[i] = temp[i];
            }

            return arr;
        }

        public static T[] QuickSort<T>(T[] arr, int startIndex, int endIndex) where T : IComparable
        {
            int length = arr.Length;
            startIndex = startIndex < 0 ? 0 : startIndex;
            endIndex = endIndex > length - 1 ? length - 1 : endIndex;

            if (startIndex > endIndex)
                return null;

            int partion = FindPartition<T>(arr, startIndex, endIndex);
            QuickSort<T>(arr, startIndex, partion - 1);
            QuickSort<T>(arr, partion + 1, endIndex);

            return arr;
        }

        static int FindPartition<T>(T[] arr, int startIndex, int endIndex) where T : IComparable
        {
            T key = arr[startIndex];

            while (startIndex < endIndex)
            {
                while (startIndex < endIndex && arr[endIndex].CompareTo(key) >= 0)
                    endIndex--;
                arr[startIndex] = arr[endIndex];

                while (startIndex < endIndex && arr[startIndex].CompareTo(key) <= 0)
                    startIndex++;
                arr[endIndex] = arr[startIndex];
            }
            arr[startIndex] = key;
            return startIndex;
        }

        public static T[] SelectSort<T>(T[] arr) where T :IComparable
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < length; j++)
                {
                    if (arr[j].CompareTo(arr[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                Swap<T>(arr, i, minIndex);
            }

            return arr;
        }
    }
}
