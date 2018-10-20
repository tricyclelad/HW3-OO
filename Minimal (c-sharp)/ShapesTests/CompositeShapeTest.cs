using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Collections.Generic;

namespace ShapesTests
{
    [TestClass]
    public class CompositeShapeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Shape myRectangle = new Rectangle("Rectangle1", "Fusion Blue", 0, 0, 0, 1, 1, 1, 1, 0);
            Shape p1 = new Point("Point1", "Red", 1, 2);
            Shape p2 = new Point("Point2", "Blue", 3, 4);
            Shape2d rect2d = myRectangle;
            Shape2d p12d = p1;
            Shape2d p22d = p2;
            Shape2d Jumble = new CompositeShape("Jumble", "grey");

            Jumble.Add(rect2d);
            Jumble.Add(p12d);
            Jumble.Add(p22d);
            List<Shape2d> _myShapes = Jumble.GetMyShapes();
            Assert.AreEqual(_myShapes[0].GetData(), rect2d.GetData());
            Assert.AreEqual(_myShapes[1].GetData(), p12d.GetData());
            Assert.AreEqual(_myShapes[2].GetData(), p22d.GetData());
            Assert.AreEqual(_myShapes.Count, 3);
            Assert.AreEqual(Jumble.ComputeArea(), myRectangle.ComputeArea());
            Jumble.Add(rect2d);
            
            Assert.AreEqual(Jumble.ComputeArea(), 2 * myRectangle.ComputeArea());


            //rect2d.Add(p1);
            //rect2d.Add(p2);
            //rect2d.Remove(p1);
            //rect2d.Remove(p2);

            //Shape2d = 
        }
    }
}
