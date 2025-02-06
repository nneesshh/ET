using System;
using System.Collections.Generic;

namespace GameCore
{
    public static class ArrayUtil
    {
        public static T[] Combine<T>(params T[][] sources)
        {
            int length = 0;
            int cnt = sources.Length;

            for (int i = 0; i < cnt; i++)
            {
                length += sources[i].Length;
            }

            T[] results = new T[length];

            int startIndex = 0;
            for (int i = 0; i < cnt; i++)
            {
                int subLength = sources[i].Length;
                Array.Copy(sources[i], 0, results, startIndex, subLength);
                startIndex += subLength;
            }

            return results;
        }

        /// <summary>
        /// 冒泡
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] array)
        {
            int count = array.Length;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < count - (i + 1); j++)
                    {
                        int v1 = array[j];
                        int v2 = array[j + 1];
                        if (v1 > v2)
                        {
                            array[j + 1] = v1;
                            array[j] = v2;
                        }
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// 快速
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static List<int> QuickSort(List<int> array)
        {
            int count = array.Count;
            if (count <= 1)
            {
                return array;
            }

            int mid             = count / 2;
            int midNum          = array[mid];
            List<int> leftArr   = new List<int>();
            List<int> midArr    = new List<int>();
            List<int> rightArr  = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if (array[i] < midNum)
                {
                    leftArr.Add(array[i]);
                }
                else if (array[i] > midNum)
                {
                    rightArr.Add(array[i]);
                }
                else
                {
                    midArr.Add(array[i]);
                }
            }

            leftArr             = QuickSort(leftArr);
            rightArr            = QuickSort(rightArr);

            List<int> sortedArr = new List<int>();
            sortedArr.AddRange(leftArr);
            sortedArr.AddRange(midArr);
            sortedArr.AddRange(rightArr);

            return sortedArr;
        }

        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // 如果目标值等于中间元素，则返回中间元素的索引
                if (arr[mid] == target)
                {
                    return mid;
                }
                // 如果目标值小于中间元素，则在左侧子数组中继续查找
                else if (arr[mid] > target)
                {
                    right = mid - 1;
                }
                // 如果目标值大于中间元素，则在右侧子数组中继续查找
                else
                {
                    left = mid + 1;
                }
            }

            // 如果未找到目标值，则返回 -1
            return -1;
        }

        public static int[] FindMissingNumbers(int[] input, int start, int end)
        {
            // 创建一个HashSet来快速查找已存在的数字  
            HashSet<int> exists = new HashSet<int>(input);

            // 找出缺失的数字并添加到列表中  
            List<int> missing = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (!exists.Contains(i))
                {
                    missing.Add(i);
                }
            }

            // 将列表转换为数组并返回  
            return missing.ToArray();
        }
    }
}
