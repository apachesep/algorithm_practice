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
    public class MergeSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var input = new int[] { 5, 4, 3, 2, 1 };
            MergeSort sort = new MergeSort();

            var result = sort.Sort(input);

            int[] expectResult = new int[] { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(result, expectResult);
        }
        [TestMethod()]
        public void SortTest1()
        {
            var input = new int[] { 5, 4 };
            MergeSort sort = new MergeSort();

            var result = sort.Sort(input);

            int[] expectResult = new int[] {4, 5 };

            CollectionAssert.AreEqual(result, expectResult);
        }

        [TestMethod()]
        public void SortTest2()
        {
            var input = new int[] { };
            MergeSort sort = new MergeSort();

            var result = sort.Sort(input);

            int[] expectResult = new int[] {  };

            CollectionAssert.AreEqual(result, expectResult);
        }
        [TestMethod()]
        public void SortTest4()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            MergeSort sort = new MergeSort();

            var result = sort.Sort(input);
                
            int[] expectResult = new int[] { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(result, expectResult);
        }

        [TestMethod()]
        public void MergeArray (){
            var input = new int[] { 5, 4, 3, 2, 1 };

            MergeSort sort = new MergeSort();

            var result = sort.newArray(input,1,4);

            int[] expectResult = new int[] { 4, 3, 2, 1 };

            CollectionAssert.AreEqual(result, expectResult);
        }

        [TestMethod()]
        public void MergeArray1()
        {
            var input = new int[] { 5, 4 };

            MergeSort sort = new MergeSort();

            var result = sort.newArray(input, 1, 1);

            int[] expectResult = new int[] {  4 };

            CollectionAssert.AreEqual(result, expectResult);
        }

        [TestMethod()]
        public void MergeArray3()
        {
            var input = new int[] { 5, 4 };

            MergeSort sort = new MergeSort();

            var result = sort.newArray(input, 0, 0);

            int[] expectResult = new int[] { 5 };

            CollectionAssert.AreEqual(result, expectResult);
        }
        [TestMethod()]
        public void MergeArray2()
        {
            var input = new int[] { 5 };

            MergeSort sort = new MergeSort();

            var result = sort.newArray(input, 0, 0);

            int[] expectResult = new int[] { 5 };

            CollectionAssert.AreEqual(result, expectResult);
        }
    }
}