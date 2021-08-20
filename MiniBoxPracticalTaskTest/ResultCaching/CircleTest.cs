using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniBoxPracticalTask.ResultCaching;
using System;

namespace MiniBoxPracticalTaskTest.ResultCaching
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void SquareCorrectlyCalculateTest()
        {
            var testCircle = new Circle(10);
            Assert.IsTrue(Math.Round(testCircle.Square,3) == 314.159);
        }
        [TestMethod]
        public void OutOfMemoryTest()
        {
            Assert.ThrowsException<OutOfMemoryException>(()=> new Circle(float.MaxValue));
        }
    }
}
