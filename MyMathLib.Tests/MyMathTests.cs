using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyMathLib.Tests
{
    [TestClass]
    public class MyMathTests
    {
        [TestMethod]
        public void Sum_1and2_3returned()
        {
            int x = 1;
            int y = 2;
            int expected = 3;

            Addition c = new Addition();
            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
