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



        }
    }
}
