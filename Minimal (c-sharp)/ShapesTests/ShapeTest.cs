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
        [TestMethod]
        public void TestValidConstruction2()
        {
            Shape p1 = new Point("Point1", "Red", 1, 2);
            Shape p2 = new Point("Point2", "Blue", 3, 4);
            Shape L1 = new Line("Line1", "Black", (Point)p1, (Point)p2);
            Assert.AreEqual(1,L1.myPoints[0].X); 
            Assert.AreEqual(2, L1.myPoints[0].Y);
            Assert.AreEqual(3, L1.myPoints[1].X);
            Assert.AreEqual(4, L1.myPoints[1].Y);
            Assert.AreEqual(L1.GetData(), "Name: " + "Line1" + "\tcolor: " + "Black");
        }

    }
}
