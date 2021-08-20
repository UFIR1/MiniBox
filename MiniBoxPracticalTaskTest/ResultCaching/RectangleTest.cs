using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniBoxPracticalTask.ResultCaching;
using System;

namespace MiniBoxPracticalTaskTest.ResultCaching
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void SquareCorrectlyCalculateTest()
        {
            var testCircle = new Rectangle(6, 5);
            Assert.IsTrue(Math.Round(testCircle.Square, 3) == 30);
        }
        [TestMethod]
        public void OutOfMemoryTest()
        {
            Assert.ThrowsException<OutOfMemoryException>(() => new Rectangle(float.MaxValue, float.MaxValue));
        }
    }
}
