﻿using System;
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
            Shape myRectangle = new Rectangle("Rectangle1", "FusionBlue", 0, 0, 0, 1, 1, 1, 1, 0);
            Shape myRectangle2 = new Rectangle("Rectangle2", "FusionGreen", 0, 0, 0, 1, 1, 1, 1, 0);
            Shape p1 = new Point("Point1", "Red", 1, 2);
            Shape p2 = new Point("Point2", "Blue", 3, 4);
            Shape2d rect2d = myRectangle;
            Shape2d rect2d2 = myRectangle2;
            Shape2d p12d = p1;
            Shape2d p22d = p2;
            Shape2d Jumble = new CompositeShape("Jumble", "grey");

            Jumble.Add(rect2d);
            Jumble.Add(p12d);
            Jumble.Add(p22d);
            Jumble.Add(rect2d2);   
            List<Shape2d> _myShapes = Jumble.GetMyShapes();
            Assert.AreEqual(_myShapes[0].GetData(), rect2d.GetData());
            Assert.AreEqual(_myShapes[1].GetData(), p12d.GetData());
            Assert.AreEqual(_myShapes[2].GetData(), p22d.GetData());
            Assert.AreEqual(_myShapes[3].GetData(), rect2d2.GetData());
            Assert.AreEqual(_myShapes.Count, 4);
            Assert.AreEqual(Jumble.ComputeArea(), 2*myRectangle.ComputeArea());

            Jumble.Add(rect2d);
            Assert.AreEqual(Jumble.ComputeArea(), 2*myRectangle.ComputeArea());

            Jumble.Remove(rect2d);
            Assert.AreEqual(_myShapes.Count, 3);
            Jumble.Remove(rect2d);
            Assert.AreEqual(_myShapes.Count, 3);
            Jumble.Remove(p12d);
            Assert.AreEqual(_myShapes.Count, 2);
            Jumble.Remove(p22d);
            Assert.AreEqual(_myShapes.Count, 1);
            Jumble.Remove(rect2d2);
            Assert.AreEqual(_myShapes.Count, 0);

            Jumble.Add(rect2d);
            //Jumble.Add(rect2d);
            //Jumble.Add(rect2d);
            //Jumble.Add(rect2d);
            //Jumble.Add(rect2d);
            //Jumble.Add(rect2d);
            Jumble.Add(p12d);
            Assert.AreEqual(_myShapes.Count, 2);
            Jumble.Move(1,1);
            Jumble.RemoveAll();
            Assert.AreEqual(_myShapes.Count, 0);
            Jumble.Add(Jumble);
            Jumble.Add(rect2d);
            Jumble.Add(p12d);
            Assert.AreEqual(Jumble.GetData(), "Rectangle1 FusionBlue 1 1 1 2 2 2 2 1 Point1 Red 2 3 ");
        }
    }
}
