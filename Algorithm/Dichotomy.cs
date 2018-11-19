using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Dichotomy
    {
        public bool GetValue(int[] arr, int expectValue)
        {
            return GetValue(arr, 1, arr.Length, expectValue);
        }

        public bool GetValue(int[] arr, int first, int end, int expectValue)
        {
            int mid = (first + end) / 2 - 1;

            if (arr[0] > expectValue
                || arr[arr.Length - 1] < expectValue
                || first > end)
                return false;

            if (arr[mid] > expectValue)
                return GetValue(arr, first, mid, expectValue);
            else if (arr[mid] < expectValue)
                return GetValue(arr, mid, end, expectValue);
            else if (arr[mid] == expectValue)
                return true;
            else
                return false;
        }
    }
}
