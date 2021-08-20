using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniBoxPracticalTask.ResultCaching;
using System;

namespace MiniBoxPracticalTaskTest.ResultCaching
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void SquareCorrectlyCalculateTest()
        {
            var testCircle = new Triangle(6,5,2);
            Assert.IsTrue(Math.Round(testCircle.Square,3) == 4.684);
        }
        [TestMethod]
        public void IncorrectTriangleTest()
        {
            Assert.ThrowsException<Exception>(() => new Triangle(10, 2, 2));
        }
        [TestMethod]
        public void OutOfMemoryTest()
        {
            Assert.ThrowsException<OutOfMemoryException>(()=> new Triangle(float.MaxValue, float.MaxValue, float.MaxValue));
        }
    }
}
