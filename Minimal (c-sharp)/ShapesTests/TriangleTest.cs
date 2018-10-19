using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTests
{
    [TestClass]
    public class TriangleTest
    {

        [TestMethod]
        public void TestValidConstruction()
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(1, 1);
            var p3 = new Point(2, 0);
            var p4 = new Point(3, 3);
            var myTriangle = new Triangle(0, 0, 1, 1, 2, 0);

            Assert.AreEqual(0, myTriangle.Vertex1.X, 0);
            Assert.AreEqual(0, myTriangle.Vertex1.Y, 0);
            Assert.AreEqual(1, myTriangle.Vertex2.X, 0);
            Assert.AreEqual(1, myTriangle.Vertex2.Y, 0);
            Assert.AreEqual(2, myTriangle.Vertex3.X, 0);
            Assert.AreEqual(0, myTriangle.Vertex3.Y, 0);

            try
            {
                myTriangle = new Triangle(0, 0, 1, 1, 0, 0);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {

                Assert.AreEqual("Two or more Triangle Vertices are equal", e.Message);
            }

            try
            {
                myTriangle = new Triangle(0, 0, 1, 1, 3, 3);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid triangle edges: 1 or more lines are in same location", e.Message);
            }

            try
            {
                myTriangle = new Triangle(0, 0, 1, -1, 3, -3);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid triangle edges: 1 or more lines are in same location", e.Message);
            }

            try
            {
                myTriangle = new Triangle(p1, p2, p1);
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Triangle Vertices are equal", e.Message);
            }

            try
            {
                myTriangle = new Triangle(p1, p1, p1);
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Triangle Vertices are equal", e.Message);
            }

            try
            {
                myTriangle = new Triangle(p2, p1, p1);
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Triangle Vertices are equal", e.Message);
            }


            try
            {
                myTriangle = new Triangle(p1, p2, p4);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid triangle edges: 1 or more lines are in same location", e.Message);
            }
            p1 = new Point(1.4, 2.5);
            p2 = new Point(4.6, 10.7);
            p3 = new Point(5.6, 13.7);
            myTriangle = new Triangle(p1, p2, p3);
            Assert.AreSame(p1, myTriangle.Vertex1);
            Assert.AreSame(p2, myTriangle.Vertex2);
            Assert.AreSame(p3, myTriangle.Vertex3);

            myTriangle = new Triangle(0.1, 0.1, 1.1, 1.1, 2.1, 0.1);

            Assert.AreEqual(0.1, myTriangle.Vertex1.X, 0);
            Assert.AreEqual(0.1, myTriangle.Vertex1.Y, 0);
            Assert.AreEqual(1.1, myTriangle.Vertex2.X, 0);
            Assert.AreEqual(1.1, myTriangle.Vertex2.Y, 0);
            Assert.AreEqual(2.1, myTriangle.Vertex3.X, 0);
            Assert.AreEqual(0.1, myTriangle.Vertex3.Y, 0);
        }
        [TestMethod]
        public void TestMove()
        {
            Triangle myTriangle = new Triangle(0,0,5,5,5,0);
            Assert.AreEqual(0, myTriangle.Vertex1.X, 0);
            Assert.AreEqual(0, myTriangle.Vertex1.Y, 0);
            Assert.AreEqual(5, myTriangle.Vertex2.X, 0);
            Assert.AreEqual(5, myTriangle.Vertex2.Y, 0);
            Assert.AreEqual(5, myTriangle.Vertex3.X, 0);
            Assert.AreEqual(0, myTriangle.Vertex3.Y, 0);

            myTriangle.Move(1, 1);
            Assert.AreEqual(1, myTriangle.Vertex1.X, 0);
            Assert.AreEqual(1, myTriangle.Vertex1.Y, 0);
            Assert.AreEqual(6, myTriangle.Vertex2.X, 0);
            Assert.AreEqual(6, myTriangle.Vertex2.Y, 0);
            Assert.AreEqual(6, myTriangle.Vertex3.X, 0);
            Assert.AreEqual(1, myTriangle.Vertex3.Y, 0);

            myTriangle.Move(.123, .123);
            Assert.AreEqual(1.123, myTriangle.Vertex1.X, 0);
            Assert.AreEqual(1.123, myTriangle.Vertex1.Y, 0);
            Assert.AreEqual(6.123, myTriangle.Vertex2.X, 0);
            Assert.AreEqual(6.123, myTriangle.Vertex2.Y, 0);
            Assert.AreEqual(6.123, myTriangle.Vertex3.X, 0);
            Assert.AreEqual(1.123, myTriangle.Vertex3.Y, 0);

            myTriangle.Move(-.123, -.123);
            Assert.AreEqual(1, myTriangle.Vertex1.X, 0);
            Assert.AreEqual(1, myTriangle.Vertex1.Y, 0);
            Assert.AreEqual(6, myTriangle.Vertex2.X, 0);
            Assert.AreEqual(6, myTriangle.Vertex2.Y, 0);
            Assert.AreEqual(6, myTriangle.Vertex3.X, 0);
            Assert.AreEqual(1, myTriangle.Vertex3.Y, 0);

            try
            {
                myTriangle.Move(double.PositiveInfinity, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-x value", e.Message);
            }

            try
            {
                myTriangle.Move(double.NegativeInfinity, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-x value", e.Message);
            }

            try
            {
                myTriangle.Move(double.NaN, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-x value", e.Message);
            }

            try
            {
                myTriangle.Move(1, double.PositiveInfinity);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-y value", e.Message);
            }

            try
            {
                myTriangle.Move(1, double.PositiveInfinity);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-y value", e.Message);
            }

            try
            {
                myTriangle.Move(1, double.NaN);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-y value", e.Message);
            }
        }
        
        [TestMethod]
        public void TestComputeArea()
        {
                Triangle myTriangle = new Triangle(-5,0,0,5,5,0);
                Assert.AreEqual(25, myTriangle.ComputeArea(), 0.0001);

                myTriangle = new Triangle(0,0,5.5,5.5,5.9,0);
                Assert.AreEqual(16.225, myTriangle.ComputeArea(), 0.0001);

                myTriangle = new Triangle(-6.239,0,0,12.987,0,0);
                Assert.AreEqual(40.5129465, myTriangle.ComputeArea(), 0.0001);

        }
 
    }
}
