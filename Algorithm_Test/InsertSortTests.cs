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
    public class InsertSortTests
    {
        [TestMethod()]
        public void InsertSortTest()
        {
            int[] input = new int[] { 5, 4, 3, 2, 1 };
            SelectSort selectsort = new SelectSort(input);

            var result = selectsort.Sort();

            int[] expectResult = new int[] { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(input, expectResult);

        }

        [TestMethod()]
        public void SortTest()
        {
            int[] input = new int[] {};
            SelectSort selectsort = new SelectSort(input);

            var result = selectsort.Sort();

            int[] expectResult = new int[] {  };

            CollectionAssert.AreEqual(input, expectResult);
        }
    }
}