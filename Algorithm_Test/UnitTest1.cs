using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        int[] arr;
        [TestInitialize]
        public void Init() {
            arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i + 1;
        }

        [TestMethod]
        public void GetValueTest()
        {
            Dichotomy dichotmy = new Dichotomy();
            Assert.IsTrue(dichotmy.GetValue(arr, 20));
            Assert.IsTrue(dichotmy.GetValue(arr, 1));
            Assert.IsFalse(dichotmy.GetValue(arr, 1000));

            Assert.IsFalse(dichotmy.GetValue(arr, 0));
        }
        [TestMethod]
        public void TestMethod2()
        {
            

        }

    }
}
