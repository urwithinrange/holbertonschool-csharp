using NUnit.Framework;
using System.Collections.Generic;


namespace MyMath.Tests
{
    /// <summary>MyMath test class</summary>
    [TestFixture]
    public class MyMathTests
    {        
        [Test]
        public void TestList_MaxIntegerFound_ReturnTrue()
        {
            List<int> alist = new List<int>();
            alist.Add(1);
            alist.Add(2);
            alist.Add(6);
            alist.Add(7);
            alist.Add(9);
            alist.Add(10);
            int x = 10, y;
            y = Operations.Max(alist);
            Assert.AreEqual(x, y);
        }
        [Test]
        public void TestList_ListIsEmpty_ReturnTrue()
        {
            List<int> alist = new List<int>();
            int x = 0, y;
            y = Operations.Max(alist);
            Assert.AreEqual(x, y);
        }

    }
}