using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class InsertSort
    {
        List<int> _arr;
        public InsertSort(List<int> arr) { _arr = arr; }

        public List<int> Sort()
        {
            if (_arr.Count == 0)
                return _arr;

            for (int i = 1; i < _arr.Count; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (_arr[j] > _arr[j - 1])
                        _arr.Swap(j, j - 1);
                    else
                        break;
                }
            }
            return _arr;
        }


    }
}
