using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniBoxPracticalTask.MemoryOptimize;
using System;

namespace MiniBoxPracticalTaskTest.MemoryOptimize
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void SquareCorrectlyCalculateTest()
        {
            var testCircle = new Triangle(6,5,2);
            Assert.IsTrue(Math.Round(testCircle.GetSquare(),3) == 4.684);
        }
        [TestMethod]
        public void IncorrectTriangleTest()
        {
            Assert.ThrowsException<Exception>(() => new Triangle(10, 2, 2));
        }
        [TestMethod]
        public void OutOfMemoryTest()
        {
            Assert.ThrowsException<OutOfMemoryException>(()=> new Triangle(float.MaxValue, float.MaxValue, float.MaxValue).GetSquare());
        }
    }
}
