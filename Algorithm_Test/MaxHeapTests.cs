using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class MaxHeapTests
    {
        [TestMethod()]
        public void MaxHeapTest()
        {
            List<int> arr = new List<int>() { 1, 55, 4, 5, 11, 3, 21 };

            HeapSort maxHeap = new HeapSort(arr);
            var result = maxHeap.BuildMaxHeap();

            Assert.AreEqual(result[0], 55);
        }

        [TestMethod()]
        public void MaxHeapTest1()
        {
            List<int> arr = new List<int>() { 1, 24, 4, 54, 55 };

            HeapSort maxHeap = new HeapSort(arr);
            var result = maxHeap.BuildMaxHeap();
            Assert.AreEqual (55,result[0]);
        }

        [TestMethod()]
        public void MaxHeapTest2()
        {
            List<int> arr = new List<int>() { 1, 24, 4, 54, 55 };

            HeapSort maxHeap = new HeapSort(arr);

            List<int> expectResult = new List<int>() { 1, 4,24,54,55 };
            var result = maxHeap.Sort();
            CollectionAssert.AreEqual(result, expectResult);

        }

    }
}