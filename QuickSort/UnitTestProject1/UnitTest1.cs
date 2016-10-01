using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            QuickSort q = new QuickSort();
            int[] array = { 1, 4, 6, 89, 66 };
            q.Sort(array, 0, array.Length-1);
            int[] res = { 1, 4, 6, 66, 89 };
            CollectionAssert.AreEqual(array, res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            QuickSort w = new QuickSort();

            int a = 6, b = 4;
            w.Swap(ref a, ref b);

            Assert.IsTrue(a == 4 && b == 6);
        }
    }
}
