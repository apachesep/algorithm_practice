using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    /// <summary>
    /// 選擇排序
    /// 分左右邊  在左邊選擇一個(最大or最小) 移至右邊
    /// </summary>
    public class SelectSort
    {
        int[] _arr;
        public SelectSort(int[] arr)
        {
            _arr = arr;
        }

        public int[] Sort()
        {
            if (_arr == null || _arr.Length == 0)
                return _arr;

            int minindex = 0;
            for (int i = 0; i < _arr.Length - 1; i++)
            {
                minindex = i;
                for (int j = i + 1; j < _arr.Length; j++)
                {
                    if (_arr[minindex] > _arr[j])
                        minindex = j;
                }
                _arr.Swap(i, minindex);

            }
            return _arr;
        }

    }
}
