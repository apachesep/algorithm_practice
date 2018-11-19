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
    public class SelectSortTests
    {
        [TestMethod()]
        public void SortTest1()
        {
            int[] input = new int[] { 5, 4, 3, 2, 1 };
            SelectSort selectsort = new SelectSort(input);

            var result = selectsort.Sort();

            int[] expectResult = new int[] { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(input, expectResult);
        }

        [TestMethod()]
        public void SortTest22()
        {
            int[] input = new int[] {1,2,3,4,5 };
            SelectSort selectsort = new SelectSort(input);

            var result = selectsort.Sort();

            int[] expectResult = new int[] { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(input, expectResult);
        }

        [TestMethod()]
        public void SortTest3()
        {
            int[] input = new int[] { };
            SelectSort selectsort = new SelectSort(input);

            var result = selectsort.Sort();

            int[] expectResult = new int[] { };

            CollectionAssert.AreEqual(input, expectResult);
        }

        [TestMethod()]
        public void SortTest34()
        {
            int[] input = null;
            SelectSort selectsort = new SelectSort(input);

            var result = selectsort.Sort();

            int[] expectResult = null;

            CollectionAssert.AreEqual(input, null);
        }
    }
}

