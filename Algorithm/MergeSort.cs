using System;


namespace Algorithm
{
    public class MergeSort
    {
        /// <summary>
        /// 合併算法 核心每次遞規都對於新陣列進行排序
        /// </summary>
        /// <param name="arr"></param>
        public int[] Sort(int[] arr)
        {
            int totalLength = arr.Length;
            if (totalLength <= 1)
                return arr;

            int mid = totalLength / 2;

            int[] right_arr = Sort(newArray(arr, 0, mid - 1));
            int[] left_arr = Sort(newArray(arr, mid, totalLength - 1));

            int idx = 0;
            int rightPoint = 0;
            int leftPoint = 0;
            int[] result = new int[totalLength];

            while (rightPoint < mid && leftPoint < mid)
            {
                if (right_arr[rightPoint] < left_arr[leftPoint])
                {
                    result[idx] = right_arr[rightPoint];
                    rightPoint++;
                }
                else if(right_arr[rightPoint] > left_arr[leftPoint])
                {
                    result[idx] = left_arr[leftPoint];
                    leftPoint++;
                }

                idx++;
            }

            for (int i = leftPoint; i < left_arr.Length; i++)
            {
                result[idx] = left_arr[i];
                idx++;
            }

            for (int i = rightPoint; i < right_arr.Length; i++)
            {
                result[idx] = right_arr[i];
                idx++;
            }

            return result;
        }
        /// <summary>
        /// 搬運新陣列
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public int[] newArray (int[] arr,int from, int to){
           
             int[] new_li = new int[to - from + 1];

            for (int i = from, j = 0; i <= to; i++,j++)
                new_li[j] = arr[i];
             
            return new_li;
        }
    }
}
