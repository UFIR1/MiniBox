using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniBoxPracticalTask.MemoryOptimize;
using System;

namespace MiniBoxPracticalTaskTest.MemoryOptimize
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void SquareCorrectlyCalculateTest()
        {
            var testCircle = new Rectangle(6, 5);
            Assert.IsTrue(Math.Round(testCircle.GetSquare(), 3) == 30);
        }
        [TestMethod]
        public void OutOfMemoryTest()
        {
            Assert.ThrowsException<OutOfMemoryException>(() => new Rectangle(float.MaxValue, float.MaxValue).GetSquare());
        }
    }
}
