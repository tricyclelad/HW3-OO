using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesTests
{
    [TestClass]
    public class Shape2dFactoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] parseList = {"Point","name","colour","0","1" };
            Shape2dFactory myShape2DFactory = new Shape2dFactory();
            Shape2d myPoint = myShape2DFactory.GetShape2D(parseList);
            Assert.AreEqual(myPoint.color, "colour");
            Assert.AreEqual(myPoint.name, "name");

            string[] parseList2 = {"Line","name1","colour1","0","1","10","10"};
            Shape2d myLine = myShape2DFactory.GetShape2D(parseList2);
            Assert.AreEqual(myLine.color, "colour1");
            Assert.AreEqual(myLine.name, "name1");

            string[] parseList3 = {"Circle","name2","colour2","0","1","10",};
            Shape2d myCircle = myShape2DFactory.GetShape2D(parseList3);
            Assert.AreEqual(myCircle.color, "colour2");
            Assert.AreEqual(myCircle.name, "name2");

            string[] parseList4 = {"Ellipse","name3","colour3","0","0","0","1","2","1","2","0"};
            Shape2d myEllipse = myShape2DFactory.GetShape2D(parseList4);
            Assert.AreEqual(myEllipse.color, "colour3");
            Assert.AreEqual(myEllipse.name, "name3");

            string[] parseList5 = {"Square", "name4", "colour4", "0", "0", "0", "1", "1", "1", "1", "0" };
            Shape2d mySquare = myShape2DFactory.GetShape2D(parseList5);
            Assert.AreEqual(mySquare.color, "colour4");
            Assert.AreEqual(mySquare.name, "name4");

            string[] parseList6 = {"Rectangle", "name5", "colour5", "0", "0", "0", "1", "1", "1", "1", "0" };
            Shape2d myRectangle = myShape2DFactory.GetShape2D(parseList6);
            Assert.AreEqual(myRectangle.color, "colour5");
            Assert.AreEqual(myRectangle.name, "name5");

            string[] parseList7 = {"Triangle", "name6", "colour6", "0", "0", "0", "1", "1", "1"};
            Shape2d myTriangle = myShape2DFactory.GetShape2D(parseList7);
            Assert.AreEqual(myTriangle.color, "colour6");
            Assert.AreEqual(myTriangle.name, "name6");

        }
    }
}
