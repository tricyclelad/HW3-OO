using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTests
{
    [TestClass]
    public class EllipseTest
    {
        [TestMethod]
        public void TestValidConstructionWithRectangle()
        {
            Rectangle myRectangle = new Rectangle(-2, -1, -2, 1, 2, 1, 2, -1);
            var Ellipse = new Ellipse(myRectangle);
            //var Ellipse = new Ellipse(-2, -1, -2, 1, 2, 1, 2, -1);

            Assert.AreEqual(0, Ellipse.Center.X);
            Assert.AreEqual(0, Ellipse.Center.Y);
            Assert.AreEqual(-1.73205080757, Ellipse.Foci1.X, 0.0001);
            Assert.AreEqual(0, Ellipse.Foci1.Y);
            Assert.AreEqual(1.73205080757, Ellipse.Foci2.X, 0.0001);
            Assert.AreEqual(0, Ellipse.Foci2.Y);

            Assert.AreEqual(-2, Ellipse.Vertex1.X);
            Assert.AreEqual(0, Ellipse.Vertex1.Y);
            Assert.AreEqual(0, Ellipse.Vertex2.X);
            Assert.AreEqual(1, Ellipse.Vertex2.Y);
            Assert.AreEqual(2, Ellipse.Vertex3.X);
            Assert.AreEqual(0, Ellipse.Vertex3.Y);
            Assert.AreEqual(0, Ellipse.Vertex4.X);
            Assert.AreEqual(-1, Ellipse.Vertex4.Y);

            Line _Axis1 = new Line(-2, 0, 2, 0);
            Line _Axis2 = new Line(0, 1, 0, -1);

            Assert.AreEqual(_Axis1.Point1.X, Ellipse.Axis1.Point1.X);
            Assert.AreEqual(_Axis1.Point1.Y, Ellipse.Axis1.Point1.Y);
            Assert.AreEqual(_Axis1.Point2.X, Ellipse.Axis1.Point2.X);
            Assert.AreEqual(_Axis1.Point2.Y, Ellipse.Axis1.Point2.Y);

            Assert.AreEqual(_Axis2.Point1.X, Ellipse.Axis2.Point1.X);
            Assert.AreEqual(_Axis2.Point1.Y, Ellipse.Axis2.Point1.Y);
            Assert.AreEqual(_Axis2.Point2.X, Ellipse.Axis2.Point2.X);
            Assert.AreEqual(_Axis2.Point2.Y, Ellipse.Axis2.Point2.Y);

            Rectangle _BindingRectangle = new Rectangle(-2, -1, -2, 1, 2, 1, 2, -1);
            Assert.AreEqual(_BindingRectangle.Vertex1.X, Ellipse.BindingRectangle.Vertex1.X);
            Assert.AreEqual(_BindingRectangle.Vertex1.Y, Ellipse.BindingRectangle.Vertex1.Y);
            Assert.AreEqual(_BindingRectangle.Vertex2.X, Ellipse.BindingRectangle.Vertex2.X);
            Assert.AreEqual(_BindingRectangle.Vertex2.Y, Ellipse.BindingRectangle.Vertex2.Y);
            Assert.AreEqual(_BindingRectangle.Vertex3.X, Ellipse.BindingRectangle.Vertex3.X);
            Assert.AreEqual(_BindingRectangle.Vertex3.Y, Ellipse.BindingRectangle.Vertex3.Y);
            Assert.AreEqual(_BindingRectangle.Vertex4.X, Ellipse.BindingRectangle.Vertex4.X);
            Assert.AreEqual(_BindingRectangle.Vertex4.Y, Ellipse.BindingRectangle.Vertex4.Y);

            myRectangle = new Rectangle(-1,-2,-1,2,1,2,1,-2);
            Ellipse = new Ellipse(myRectangle);
            Assert.AreEqual(-1.73205080757, Ellipse.Foci1.X, 0.0001);
            Assert.AreEqual(0, Ellipse.Foci1.Y);
            Assert.AreEqual(1.73205080757, Ellipse.Foci2.X, 0.0001);
            Assert.AreEqual(0, Ellipse.Foci2.Y);
        }
        [TestMethod]
        public void TestValidConstructionWithVertices()
        {
            Point _Vertex1 = new Point(-2,-1);
            Point _Vertex2 = new Point(-2,1);
            Point _Vertex3 = new Point(2,1);
            Point _Vertex4 = new Point(2,-1);

            var Ellipse = new Ellipse(_Vertex1,_Vertex2,_Vertex3,_Vertex4);

            Assert.AreEqual(0, Ellipse.Center.X);
            Assert.AreEqual(0, Ellipse.Center.Y);
            Assert.AreEqual(-1.73205080757, Ellipse.Foci1.X, 0.0001);
            Assert.AreEqual(0, Ellipse.Foci1.Y);
            Assert.AreEqual(1.73205080757, Ellipse.Foci2.X, 0.0001);
            Assert.AreEqual(0, Ellipse.Foci2.Y);

            Assert.AreEqual(-2, Ellipse.Vertex1.X);
            Assert.AreEqual(0, Ellipse.Vertex1.Y);
            Assert.AreEqual(0, Ellipse.Vertex2.X);
            Assert.AreEqual(1, Ellipse.Vertex2.Y);
            Assert.AreEqual(2, Ellipse.Vertex3.X);
            Assert.AreEqual(0, Ellipse.Vertex3.Y);
            Assert.AreEqual(0, Ellipse.Vertex4.X);
            Assert.AreEqual(-1, Ellipse.Vertex4.Y);

            Line _Axis1 = new Line(-2, 0, 2, 0);
            Line _Axis2 = new Line(0, 1, 0, -1);

            Assert.AreEqual(_Axis1.Point1.X, Ellipse.Axis1.Point1.X);
            Assert.AreEqual(_Axis1.Point1.Y, Ellipse.Axis1.Point1.Y);
            Assert.AreEqual(_Axis1.Point2.X, Ellipse.Axis1.Point2.X);
            Assert.AreEqual(_Axis1.Point2.Y, Ellipse.Axis1.Point2.Y);

            Assert.AreEqual(_Axis2.Point1.X, Ellipse.Axis2.Point1.X);
            Assert.AreEqual(_Axis2.Point1.Y, Ellipse.Axis2.Point1.Y);
            Assert.AreEqual(_Axis2.Point2.X, Ellipse.Axis2.Point2.X);
            Assert.AreEqual(_Axis2.Point2.Y, Ellipse.Axis2.Point2.Y);

            Rectangle _BindingRectangle = new Rectangle(-2, -1, -2, 1, 2, 1, 2, -1);
            Assert.AreEqual(_BindingRectangle.Vertex1.X, Ellipse.BindingRectangle.Vertex1.X);
            Assert.AreEqual(_BindingRectangle.Vertex1.Y, Ellipse.BindingRectangle.Vertex1.Y);
            Assert.AreEqual(_BindingRectangle.Vertex2.X, Ellipse.BindingRectangle.Vertex2.X);
            Assert.AreEqual(_BindingRectangle.Vertex2.Y, Ellipse.BindingRectangle.Vertex2.Y);
            Assert.AreEqual(_BindingRectangle.Vertex3.X, Ellipse.BindingRectangle.Vertex3.X);
            Assert.AreEqual(_BindingRectangle.Vertex3.Y, Ellipse.BindingRectangle.Vertex3.Y);
            Assert.AreEqual(_BindingRectangle.Vertex4.X, Ellipse.BindingRectangle.Vertex4.X);
            Assert.AreEqual(_BindingRectangle.Vertex4.Y, Ellipse.BindingRectangle.Vertex4.Y);

            _Vertex1 = new Point(-1,-2);
            _Vertex2 = new Point(-1,2);
            _Vertex3 = new Point(1,2);
            _Vertex4 = new Point(1,-2);

            Ellipse = new Ellipse(_Vertex1,_Vertex2,_Vertex3,_Vertex4 );
            Assert.AreEqual(-1.73205080757, Ellipse.Foci1.X, 0.0001);
            Assert.AreEqual(0, Ellipse.Foci1.Y);
            Assert.AreEqual(1.73205080757, Ellipse.Foci2.X, 0.0001);
            Assert.AreEqual(0, Ellipse.Foci2.Y);
        }
        [TestMethod]
        public void TestMoveEllipse()
        {
            Rectangle myRectangle = new Rectangle(-2, -1, -2, 1, 2, 1, 2, -1);
            Ellipse MyEllipse = new Ellipse(myRectangle);
            MyEllipse.MoveEllipse(1, 1);

            Assert.AreEqual(1, MyEllipse.Center.X);
            Assert.AreEqual(1, MyEllipse.Center.Y);
            Assert.AreEqual(-0.73205080757, MyEllipse.Foci1.X, 0.0001);
            Assert.AreEqual(1, MyEllipse.Foci1.Y);
            Assert.AreEqual(2.73205080757, MyEllipse.Foci2.X, 0.0001);
            Assert.AreEqual(1, MyEllipse.Foci2.Y);

            Assert.AreEqual(0, MyEllipse.Vertex1.X);
            Assert.AreEqual(2, MyEllipse.Vertex1.Y);
            Assert.AreEqual(2, MyEllipse.Vertex2.X);
            Assert.AreEqual(3, MyEllipse.Vertex2.Y);
            Assert.AreEqual(4, MyEllipse.Vertex3.X);
            Assert.AreEqual(2, MyEllipse.Vertex3.Y);
            Assert.AreEqual(2, MyEllipse.Vertex4.X);
            Assert.AreEqual(1, MyEllipse.Vertex4.Y);

            Line _Axis1 = new Line(0, 2, 4, 2);
            Line _Axis2 = new Line(2, 3, 2, 1);

            Assert.AreEqual(_Axis1.Point1.X, MyEllipse.Axis1.Point1.X);
            Assert.AreEqual(_Axis1.Point1.Y, MyEllipse.Axis1.Point1.Y);
            Assert.AreEqual(_Axis1.Point2.X, MyEllipse.Axis1.Point2.X);
            Assert.AreEqual(_Axis1.Point2.Y, MyEllipse.Axis1.Point2.Y);

            Assert.AreEqual(_Axis2.Point1.X, MyEllipse.Axis2.Point1.X);
            Assert.AreEqual(_Axis2.Point1.Y, MyEllipse.Axis2.Point1.Y);
            Assert.AreEqual(_Axis2.Point2.X, MyEllipse.Axis2.Point2.X);
            Assert.AreEqual(_Axis2.Point2.Y, MyEllipse.Axis2.Point2.Y);

            myRectangle.Move(1, 1);
            Assert.AreEqual(myRectangle.Vertex1.X, MyEllipse.BindingRectangle.Vertex1.X);
            Assert.AreEqual(myRectangle.Vertex1.Y, MyEllipse.BindingRectangle.Vertex1.Y);
            Assert.AreEqual(myRectangle.Vertex2.X, MyEllipse.BindingRectangle.Vertex2.X);
            Assert.AreEqual(myRectangle.Vertex2.Y, MyEllipse.BindingRectangle.Vertex2.Y);
            Assert.AreEqual(myRectangle.Vertex3.X, MyEllipse.BindingRectangle.Vertex3.X);
            Assert.AreEqual(myRectangle.Vertex3.Y, MyEllipse.BindingRectangle.Vertex3.Y);
            Assert.AreEqual(myRectangle.Vertex4.X, MyEllipse.BindingRectangle.Vertex4.X);
            Assert.AreEqual(myRectangle.Vertex4.Y, MyEllipse.BindingRectangle.Vertex4.Y);
        }
        [TestMethod]
        public void TestComputeArea()
        {
            Rectangle myRectangle = new Rectangle(-2, -1, -2, 1, 2, 1, 2, -1);
            Ellipse MyEllipse = new Ellipse(myRectangle);
            Assert.AreEqual(6.283185307,MyEllipse.ComputeArea(), .00001);
        }

    }
}
