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
        //[TestMethod]
        //public void TestValidConstruction2()
        //{
        //    Shape p1 = new Point("Point1", "Red", 1, 2);
        //    Shape p2 = new Point("Point2", "Blue", 3, 4);
        //    Shape L1 = new Line("Line1", "Black", (Point)p1, (Point)p2);
        //    Assert.AreEqual(1, L1.myPoints[0].X);
        //    Assert.AreEqual(2, L1.myPoints[0].Y);
        //    Assert.AreEqual(3, L1.myPoints[1].X);
        //    Assert.AreEqual(4, L1.myPoints[1].Y);
        //    Assert.AreEqual(L1.GetData(), "Name: " + "Line1" + "\tcolor: " + "Black");
        //}

        //[TestMethod]
        //public void TestVoidFunctions()
        //{
        //    Shape myRectangle = new Rectangle("Rectangle1", "Fusion Blue", 0, 0, 0, 1, 1, 1, 1, 0);
        //    Shape p1 = new Point("Point1", "Red", 1, 2);
        //    Shape p2 = new Point("Point2", "Blue", 3, 4);
        //    myRectangle.Add(p1);
        //    myRectangle.Add(p2);
        //    myRectangle.Remove(p1);
        //    myRectangle.Remove(p2);
        //}
    }
}
