using System;
using System.Text;

namespace Utilities
{
    /// <summary>
    /// 自定义排序类
    /// </summary>
    public class Sorter
    {
        /// <summary>
        /// 交换元素位置
        /// </summary>
        public static void Swap<T>(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /// <summary>
        /// 冒泡排序
        /// 平均、最坏、最好：O(n^2),O(n^2),O(n)
        /// 比较相邻的元素。如果第一个比第二个大，就交换他们两个。
        /// 对每一对相邻元素做同样的工作，从开始第一对到结尾的最后一对。在这一点，最后的元素应该会是最大的数。
        /// 针对所有的元素重复以上的步骤，除了最后一个。
        /// 持续每次对越来越少的元素重复上面的步骤，直到没有任何一对数字需要比较。
        /// 这个算法的名字由来是因为越大的元素会经由交换慢慢“浮”到数列的顶端（升序或降序排列），就如同碳酸饮料中二氧化碳的气泡最终会上浮到顶端一样，故名“冒泡排序”。
        /// 
        /// </summary>
        public static T[] BubbleSort<T>(T[] arr) where T : IComparable
        {
            int length = arr.Length;

            //for (int i = 0; i < length - 1; i++)//n个数进行n-1次排序
            //{
            //    for (int j = 0; j < length - 1 - i; j++)//-i表示已经比较过的数字就不比较了
            //    {
            //        if(arr[j].CompareTo(arr[j+1]) > 0)
            //        {
            //            Swap(ref arr, j, j + 1);
            //        }
            //    }
            //}
            for (int i = length - 1; i > 0; --i)//n个数进行n-1次排序
            {
                for (int j = 0; j < i; ++j)//<i 表示不比较已经比较过的数字
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// 选择排序
        /// 平均、最坏、最好：O(n^2),O(n^2),O(n^2)
        /// 比较未排序区域的元素，每次选出最大或最小的元素放到排序区域。
        /// 一趟比较完成之后，再从剩下未排序的元素开始比较。
        /// 反复执行以上步骤，只到排序完成。
        /// 
        /// </summary>
        public static T[] SelectionSort<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                int index = i;
                for (int j = i + 1; j < arr.Length; ++j)//从未排序区域选出最小值
                {
                    if (arr[j].CompareTo(arr[index]) < 0)
                        index = j;
                }
                Swap(arr, i, index);
            }
            return arr;
        }

        /// <summary>
        /// 插入排序
        /// 平均、最坏、最好：O(n^2),O(n^2),O(n)
        /// 插入排序的基本操作就是将一个数据插入到已经排好序的有序数据中，
        /// 从而得到一个新的、个数加一的有序数据，算法适用于少量数据的排序
        /// 
        /// </summary>
        public static T[] InsertionSort<T>(T[] arr) where T : IComparable
        {
            for (int i = 1; i < arr.Length; ++i)//从第二个元素开始插入，[0,i-1]都是有序数据
            {
                int j = i;
                T value = arr[i];
                while (j > 0 && arr[j - 1].CompareTo(value) > 0)//往右偏移，给插入的地方空出一个位置
                {
                    arr[j] = arr[j - 1];
                    --j;
                }
                arr[j] = value;
            }
            return arr;
        }

        /// <summary>
        /// 快速排序
        /// 平均、最坏、最好：O(Nlog2N),O(N^2),O(Nlog2N)
        /// 快速排序的本质就是把基准数大的都放在基准数的右边,把比基准数小的放在基准数的左边,这样就找到了基准在数组中的正确位置.
        /// 以后采用递归的方式分别对前半部分和后半部分排序，当前半部分和后半部分均有序时该数组就自然有序了。
        /// 
        /// </summary>
        public static T[] QuickSort<T>(T[] arr, int startIndex, int endIndex) where T : IComparable
        {
            startIndex = startIndex < 0 ? 0 : startIndex;
            endIndex = endIndex > arr.Length - 1 ? arr.Length - 1 : endIndex;

            if (startIndex > endIndex)
                return null;

            int partition = FindPartition<T>(startIndex, endIndex, arr);//基准元素位置
            QuickSort(arr, startIndex, partition - 1);
            QuickSort(arr, partition + 1, endIndex);

            return arr;
        }

        /// <summary>
        /// 快速排序法找基准元素位置
        /// </summary>
        static int FindPartition<T>(int start, int end, T[] arr) where T: IComparable 
        {
            T key = arr[start]; //选取一个数据作为基准元素
            while (start < end)
            {
                while (start < end && arr[end].CompareTo(key) >= 0)//从序列右端开始处理，大于基准的不变
                    end--;
                arr[start] = arr[end];//小于基准的交换到左边

                while (start < end && arr[start].CompareTo(key) <= 0)//处理左端,小于基准的不变
                    start++;
                arr[end] = arr[start];//大于基准的交换到右边
            }
            //当左边的元素都小于base,右边的元素都大于base时，此时base就是基准元素，le或ri就是基准元素的位置
            arr[start] = key;
            return start;
        }

        /// <summary>
        /// 归并排序
        /// 平均、最坏、最好：O(Nlog2N),O(Nlog2N),O(Nlog2N)
        /// 归并排序的核心思想是将两个有序的数列合并成一个大的有序的序列。通过递归，层层合并，即为归并。
        /// </summary>
        public static T[] MergeSort<T>(T[] arr, int startIndex, int endIndex) where T : IComparable
        {
            startIndex = (startIndex < 0 ? 0 : startIndex);
            endIndex = (endIndex > arr.Length - 1 ? arr.Length - 1 : endIndex);

            T[] arrF = new T[arr.Length];
            if (startIndex >= endIndex) 
                return null;

            int m = (startIndex + endIndex) >> 1;//位运算，相当于除以2

            MergeSort(arr, startIndex, m);//左边有序
            MergeSort(arr, m + 1, endIndex);//右边有序

            //左右两边合并
            for (int i = startIndex, j = startIndex, k = m + 1; i <= endIndex; ++i)
            {
                //arrF[i] = arr[(k > endIndex || j <= m && arr[j].CompareTo(arr[k]) < 0) ? j++ : k++];

                if (j <= m && k <= endIndex)
                {
                    if (arr[j].CompareTo(arr[k]) < 0)
                        arrF[i] = arr[j++];
                    else
                        arrF[i] = arr[k++];
                }
                else if(j > m)
                {
                    arrF[i] = arr[k++];
                }
                else
                {
                    arrF[i] = arr[j++];
                }
            }
            for (int i = startIndex; i <= endIndex; ++i)
                arr[i] = arrF[i];

            return arr;
        }

        /// <summary>
        /// 希尔排序
        /// </summary>
        public static T[] ShellSort<T>(T[] arr) where T : IComparable
        {
            for (int step = arr.Length >> 1; step > 0; step >>= 1)
            {
                for (int i = 0; i < step; ++i)
                {
                    for (int j = i + step; j < arr.Length; j += step)
                    {
                        int k = j;
                        T value = arr[j];
                        while (k >= step && arr[k - step].CompareTo(value) > 0)
                        {
                            arr[k] = arr[k - step];
                            k -= step;
                        }
                        arr[k] = value;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// 堆排序
        /// </summary>
        public static T[] HeapSort<T>(T[] arr) where T : IComparable
        {
            for (int i = 1; i < arr.Length; ++i)
            {
                for (int j = i, k = (j - 1) >> 1; k >= 0; j = k, k = (k - 1) >> 1)
                {
                    if (arr[k].CompareTo(arr[j]) >= 0) break;
                    //Swap(ref arr, j, k);
                }
            }
            for (int i = arr.Length - 1; i > 0; --i)
            {
                //Swap(ref arr, 0, i);
                for (int j = 0, k = (j + 1) << 1; k <= i; j = k, k = (k + 1) << 1)
                {
                    if (k == i || arr[k].CompareTo(arr[k - 1]) < 0) --k;
                    if (arr[k].CompareTo(arr[j]) <= 0) break;
                    //Swap(ref arr, j, k);
                }
            }
            return arr;
        }
    }
}