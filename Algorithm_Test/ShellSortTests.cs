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
    public class QuickSortTest
    {
        [TestMethod()]
        public void SortTest()
        {
            List<int> input = new List<int>() { 5, 4, 3, 2, 1 };
            QuickSort selectsort = new QuickSort(input);

            var result = selectsort.Sort();

            List<int> expectResult = new List<int>(){ 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(input, expectResult);
        }
        [TestMethod()]
        public void SortTest1()
        {
            List<int> input = new List<int>() {  };
            QuickSort selectsort = new QuickSort(input);

            var result = selectsort.Sort();

            List<int> expectResult = new List<int>() {  };

            CollectionAssert.AreEqual(input, expectResult);
        }
        [TestMethod()]
        public void SortTest2()
        {
            List<int> input = new List<int>() { 5,23,1,31,1};
            QuickSort selectsort = new QuickSort(input);

            var result = selectsort.Sort();

            List<int> expectResult = new List<int>() {1,1,5,23,31 };

            CollectionAssert.AreEqual(input, expectResult);
        }
    }

}