using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.IO;

namespace ShapesTests
{
    [TestClass]
    public class ScriptTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Script myScript = new Script();
            string path = "C:\\Users\\Camron Martinez\\Desktop\\Current OO Homework\\HW3\\HW3-OO\\Minimal (c-sharp)\\ShapesTests\\Point.txt";
            FileStream myStream = File.OpenRead(path);
            Shape2d myShape = myScript.Load(myStream);
            Assert.AreEqual(myShape.color,"Colour");
            Assert.AreEqual(myShape.name,"Name");

        }
    }
}
