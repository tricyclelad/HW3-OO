using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesTests
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void TestValidConstruction()
        {
            Shape p1 = new Point("Point1", "Red", 1, 2);
            Assert.AreEqual(1,p1.myPoints[0].X); 
            Assert.AreEqual(2, p1.myPoints[0].Y);
            Assert.AreEqual(p1.GetData(), "Name: " + "Point1" + "\tcolor: " + "Red");

        }
    }
}
