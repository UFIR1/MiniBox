using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniBoxPracticalTask.MemoryOptimize;
using System;

namespace MiniBoxPracticalTaskTest.MemoryOptimize
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void SquareCorrectlyCalculateTest()
        {
            var testCircle = new Circle(10);
            Assert.IsTrue(Math.Round(testCircle.GetSquare(),3) == 314.159);
        }
        [TestMethod]
        public void OutOfMemoryTest()
        {
            Assert.ThrowsException<OutOfMemoryException>(()=> new Circle(float.MaxValue).GetSquare());
        }
    }
}
