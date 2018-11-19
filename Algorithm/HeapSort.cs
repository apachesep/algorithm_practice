using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class HeapSort
    {

        private List<int> _arr;
        public HeapSort(List<int> arr) { _arr = arr; }

        /// <summary>
        /// 取得最大推
        /// 使用二元樹
        /// </summary>
        /// <param name="root"></param>
        /// <param name="maxLenght"></param>
        public void MaxHeapify(int root, int maxLenght)
        {
            int left = root * 2 + 1;
            int right = root * 2 + 2;
            if (left < maxLenght && _arr[left] > _arr[root])
            {
                MaxHeapify(left, maxLenght);
                _arr.Swap(root,left);
            }
            if (right < maxLenght && _arr[right] > _arr[root])
            {
                MaxHeapify(right, maxLenght);
                _arr.Swap(root, right);
            }


        }

        public List<int> Sort()
        {
            BuildMaxHeap();
            for (int i = _arr.Count - 1; i > 0; i--)
            {
                _arr.Swap(0, i);
                BuildMaxHeap(i);
            }
            return _arr;
        }

        public List<int> BuildMaxHeap()
        {
            return BuildMaxHeap(_arr.Count);
        }
        public List<int> BuildMaxHeap(int len)
        {
            var start = _arr.Count / 2;
            for (int i = start; i >= 0; i--)
                MaxHeapify(i, len);

            return _arr;
        }

    }

}
