using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTests
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TestValidConstruction()
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(0, 1);
            var p3 = new Point(1, 1);
            var p4 = new Point(1, 0);
            var p5 = new Point(2, 0);
            var p6 = new Point(2, 1);
            var mySquare = new Square(0, 0, 0, 1, 1, 1, 1, 0);

            Assert.AreEqual(0, mySquare.Vertex1.X, 0);
            Assert.AreEqual(0, mySquare.Vertex1.Y, 0);
            Assert.AreEqual(0, mySquare.Vertex2.X, 0);
            Assert.AreEqual(1, mySquare.Vertex2.Y, 0);
            Assert.AreEqual(1, mySquare.Vertex3.X, 0);
            Assert.AreEqual(1, mySquare.Vertex3.Y, 0);
            Assert.AreEqual(1, mySquare.Vertex4.X, 0);
            Assert.AreEqual(0, mySquare.Vertex4.Y, 0);
            try
            {
                mySquare = new Square(0, 0, 1, 1, 0, 0, 1, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Square Vertices are equal", e.Message);
            }

            try
            {
                mySquare = new Square(0, 0, 1, 1, 2, 2, 0, 0);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Square Vertices are equal", e.Message);
            }

            try
            {
                mySquare = new Square(0, 0, 1, 1, 1, 1, 2, 2);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Square Vertices are equal", e.Message);
            }

            try
            {
                mySquare = new Square(0, 0, 1, 1, 2, 2, 1, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Square Vertices are equal", e.Message);
            }

            try
            {
                mySquare = new Square(0, 0, 1, 1, 2, 2, 2, 2);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Square Vertices are equal", e.Message);
            }



            try
            {
                mySquare = new Square(0, 0, 0, 1, 1, 1, 2, 0);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more corresponding sides are not equal lengths", e.Message);
            }
            try
            {
                mySquare = new Square(1, 1, 5, 3, 7, 7, 3, 5);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Atleast one vertex is not squared with the other vertices", e.Message);
            }
            try
            {
                mySquare = new Square(p1, p2, p1, p3);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Square Vertices are equal", e.Message);
            }
            try
            {
                mySquare = new Square(p1, p1, p1, p1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Square Vertices are equal", e.Message);
            }

            try
            {
                mySquare = new Square(p1, p2, p3, p5);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more corresponding sides are not equal lengths", e.Message);
            }
                var q1 = new Point(1,1);
                var q2 = new Point(5,3);
                var q3 = new Point(7,7);
                var q4 = new Point(3,5);

            try
            {
                mySquare = new Square(q1, q2, q3, q4);
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
            Square mySquare = new Square(0, 0, 0, 1, 1, 1, 1, 0);
            Assert.AreEqual(1, mySquare.ComputeArea(), 0.0001);

            mySquare = new Square(0, 0, 0, 5.5, 5.5, 5.5, 5.5, 0);
            Assert.AreEqual(30.25, mySquare.ComputeArea(), 0.0001);
        }
        [TestMethod]
        public void TestMove()
        {
            Square mySquare = new Square(0, 0, 0, 1, 1, 1, 1, 0);
            Assert.AreEqual(0, mySquare.Vertex1.X, 0);
            Assert.AreEqual(0, mySquare.Vertex1.Y, 0);
            Assert.AreEqual(0, mySquare.Vertex2.X, 0);
            Assert.AreEqual(1, mySquare.Vertex2.Y, 0);
            Assert.AreEqual(1, mySquare.Vertex3.X, 0);
            Assert.AreEqual(1, mySquare.Vertex3.Y, 0);
            Assert.AreEqual(1, mySquare.Vertex4.X, 0);
            Assert.AreEqual(0, mySquare.Vertex4.Y, 0);

            mySquare.Move(10, 10);
            Assert.AreEqual(10, mySquare.Vertex1.X, 0);
            Assert.AreEqual(10, mySquare.Vertex1.Y, 0);
            Assert.AreEqual(10, mySquare.Vertex2.X, 0);
            Assert.AreEqual(11, mySquare.Vertex2.Y, 0);
            Assert.AreEqual(11, mySquare.Vertex3.X, 0);
            Assert.AreEqual(11, mySquare.Vertex3.Y, 0);
            Assert.AreEqual(11, mySquare.Vertex4.X, 0);
            Assert.AreEqual(10, mySquare.Vertex4.Y, 0);

            mySquare.Move(.123, .123);
            Assert.AreEqual(10.123, mySquare.Vertex1.X, 0);
            Assert.AreEqual(10.123, mySquare.Vertex1.Y, 0);
            Assert.AreEqual(10.123, mySquare.Vertex2.X, 0);
            Assert.AreEqual(11.123, mySquare.Vertex2.Y, 0);
            Assert.AreEqual(11.123, mySquare.Vertex3.X, 0);
            Assert.AreEqual(11.123, mySquare.Vertex3.Y, 0);
            Assert.AreEqual(11.123, mySquare.Vertex4.X, 0);
            Assert.AreEqual(10.123, mySquare.Vertex4.Y, 0);
            try
            {
                mySquare.Move(double.PositiveInfinity, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-x value", e.Message);
            }
            try
            {
                mySquare.Move(double.NegativeInfinity, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-x value", e.Message);
            }

            try
            {
                mySquare.Move(double.NaN, 1);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-x value", e.Message);
            }

            try
            {
                mySquare.Move(1, double.PositiveInfinity);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-y value", e.Message);
            }

            try
            {
                mySquare.Move(1, double.PositiveInfinity);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-y value", e.Message);
            }

            try
            {
                mySquare.Move(1, double.NaN);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid delta-y value", e.Message);
            }
        }
    }
}
