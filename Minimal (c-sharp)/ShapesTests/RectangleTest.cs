using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTests
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestValidConstruction()
        {
            var p1 = new Point("null","null",0, 0);
            var p2 = new Point("null","null",0, 1);
            var p3 = new Point("null","null",1, 1);
            var p4 = new Point("null","null",1, 0);
            var p5 = new Point("null","null",2, 0);
            var p6 = new Point("null","null",2, 1);
            //var myRectangle = new Rectangle(p1,p2,p3,p4);
            var myRectangle = new Rectangle("null","null",0, 0, 0, 1, 1, 1, 1, 0);

            Assert.AreEqual(0, myRectangle.myPoints[0].X, 0);
            Assert.AreEqual(0, myRectangle.myPoints[0].Y, 0);
            Assert.AreEqual(0, myRectangle.myPoints[1].X, 0);
            Assert.AreEqual(1, myRectangle.myPoints[1].Y, 0);
            Assert.AreEqual(1, myRectangle.myPoints[2].X, 0);
            Assert.AreEqual(1, myRectangle.myPoints[2].Y, 0);
            Assert.AreEqual(1, myRectangle.myPoints[3].X, 0);
            Assert.AreEqual(0, myRectangle.myPoints[3].Y, 0);
            try
            {
                myRectangle = new Rectangle("null","null",0, 0, 1, 1, 0, 0, 1, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Rectangle Vertices are equal", e.Message);
            }
            try
            {
                myRectangle = new Rectangle("null","null",0, 0, 0, 1, 1, 1, 2, 0);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more corresponding sides are not equal lengths", e.Message);
            }

            try
            {
                myRectangle = new Rectangle("null","null",0, 0, 1, 1, 2, 1, 1, 0);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Atleast one vertex is not squared with the other vertices", e.Message);
            }
            try
            {
                myRectangle = new Rectangle("null","null",p1, p2, p1, p3);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Rectangle Vertices are equal", e.Message);
            }
            try
            {
                myRectangle = new Rectangle("null","null",p1, p1, p1, p1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Rectangle Vertices are equal", e.Message);
            }

            try
            {
                myRectangle = new Rectangle("null","null",p1, p2, p3, p5);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more corresponding sides are not equal lengths", e.Message);
            }
            try
            {
                myRectangle = new Rectangle("null","null",p1, p3, p6, p4);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Atleast one vertex is not squared with the other vertices", e.Message);
            }
        }
        [TestMethod]
        public void TestComputeArea()
        {
            Rectangle myRectangle = new Rectangle("null","null",0, 0, 0, 1, 1, 1, 1, 0);
            Assert.AreEqual(1, myRectangle.ComputeArea(), 0.0001);

            myRectangle = new Rectangle("null","null",0, 0, 0, 5.5, 10, 5.5, 10, 0);
            Assert.AreEqual(55, myRectangle.ComputeArea(), 0.0001);
        }
        [TestMethod]
        public void TestMove()
        {
            Rectangle myRectangle = new Rectangle("null","null",0, 0, 0, 1, 1, 1, 1, 0);
            Assert.AreEqual(0, myRectangle.myPoints[0].X, 0);
            Assert.AreEqual(0, myRectangle.myPoints[0].Y, 0);
            Assert.AreEqual(0, myRectangle.myPoints[1].X, 0);
            Assert.AreEqual(1, myRectangle.myPoints[1].Y, 0);
            Assert.AreEqual(1, myRectangle.myPoints[2].X, 0);
            Assert.AreEqual(1, myRectangle.myPoints[2].Y, 0);
            Assert.AreEqual(1, myRectangle.myPoints[3].X, 0);
            Assert.AreEqual(0, myRectangle.myPoints[3].Y, 0);

            myRectangle.Move(10, 10);
            Assert.AreEqual(10, myRectangle.myPoints[0].X, 0);
            Assert.AreEqual(10, myRectangle.myPoints[0].Y, 0);
            Assert.AreEqual(10, myRectangle.myPoints[1].X, 0);
            Assert.AreEqual(11, myRectangle.myPoints[1].Y, 0);
            Assert.AreEqual(11, myRectangle.myPoints[2].X, 0);
            Assert.AreEqual(11, myRectangle.myPoints[2].Y, 0);
            Assert.AreEqual(11, myRectangle.myPoints[3].X, 0);
            Assert.AreEqual(10, myRectangle.myPoints[3].Y, 0);

            myRectangle.Move(.123, .123);
            Assert.AreEqual(10.123, myRectangle.myPoints[0].X, 0);
            Assert.AreEqual(10.123, myRectangle.myPoints[0].Y, 0);
            Assert.AreEqual(10.123, myRectangle.myPoints[1].X, 0);
            Assert.AreEqual(11.123, myRectangle.myPoints[1].Y, 0);
            Assert.AreEqual(11.123, myRectangle.myPoints[2].X, 0);
            Assert.AreEqual(11.123, myRectangle.myPoints[2].Y, 0);
            Assert.AreEqual(11.123, myRectangle.myPoints[3].X, 0);
            Assert.AreEqual(10.123, myRectangle.myPoints[3].Y, 0);
            try
            {
                myRectangle.Move(double.PositiveInfinity, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-x value", e.Message);
            }
            try
            {
                myRectangle.Move(double.NegativeInfinity, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-x value", e.Message);
            }

            try
            {
                myRectangle.Move(double.NaN, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-x value", e.Message);
            }

            try
            {
                myRectangle.Move(1, double.PositiveInfinity);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-y value", e.Message);
            }

            try
            {
                myRectangle.Move(1, double.PositiveInfinity);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-y value", e.Message);
            }

            try
            {
                myRectangle.Move(1, double.NaN);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-y value", e.Message);
            }
        }
    }
}
