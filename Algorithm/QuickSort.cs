using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    /// <summary>
    /// 設置左右兩個 
    /// 錨點 往中間走 一但相交 那個位置就是中間點
    /// </summary>
    public class QuickSort
    {
        List<int> _arr;
        public QuickSort(List<int> arr) { _arr = arr; }

        public List<int> Sort()
        {
            return Sort(0, _arr.Count - 1);
        }

        private List<int> Sort(int first, int last)
        {
            if (first >= last)
                return null;

            int low = first;
            int heigh = last;
            int midValue = _arr[first];//設置中間值

            while (low < heigh)
            {
                while (low < heigh && _arr[heigh] >= midValue)
                    heigh--;
                _arr[low] = _arr[heigh];

                while (low < heigh && _arr[low] < midValue)
                    low++;
                _arr[heigh] = _arr[low];
            }

            _arr[low] = midValue;

            Sort(first, low - 1);
            Sort(low + 1, last);
      
            return _arr;
        }
    }
}
