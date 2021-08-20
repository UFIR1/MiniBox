using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniBoxPracticalTask.ResultCaching;
using System;

namespace MiniBoxPracticalTaskTest.ResultCaching
{
    [TestClass]
    public class AdditionalTasks
    {
        [TestMethod]
        public void TriangleIsNotRectangle()
        {
            BaseFigure testTriangle = new Triangle(2, 3, 4);
            Assert.IsFalse(testTriangle is Rectangle);
        }
        [TestMethod]
        public void GetSquareByUncnovFIgure()
        {
            object testFigure = new Rectangle(5, 5);
            if (testFigure is BaseFigure figure)
            {
                Assert.IsTrue(figure.Square == 25);
                return;
            }
            throw new AssertFailedException();

        }
    }
}
