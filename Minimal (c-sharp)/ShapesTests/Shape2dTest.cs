using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesTests
{
    [TestClass]
    public class Shape2dTest
    {
        [TestMethod]
        public void TestValidConstruction()
        {
            Shape shape1 = new Point("Point1", "Red", 1, 2);
            Shape2d shape2d = shape1;
            Assert.AreEqual("Point1", shape2d.name);
            Assert.AreEqual("Red", shape2d.color);
        }
        [TestMethod]
        public void TestValidConstruction2()
        {
            Shape p1 = new Point("Point1", "Red", 1, 2);
            Shape p2 = new Point("Point2", "Blue", 3, 4);
            Shape L1 = new Line("Line1", "Black", (Point)p1, (Point)p2);
            Shape2d Line2d = L1; 
            Assert.AreEqual("Line1", Line2d.name);
            Assert.AreEqual("Black", Line2d.color);
        }

        [TestMethod]
        public void TestVoidFunctions()
        {
            Shape myRectangle = new Rectangle("Rectangle1", "Fusion Blue", 0, 0, 0, 1, 1, 1, 1, 0);
            Shape p1 = new Point("Point1", "Red", 1, 2);
            Shape p2 = new Point("Point2", "Blue", 3, 4);
            Shape2d rect2d = myRectangle;
            rect2d.Add(p1);
            rect2d.Add(p2);
            rect2d.Remove(p1);
            rect2d.Remove(p2);
        }
    }
}
