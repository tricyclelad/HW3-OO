using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;
using System.Collections.Generic;


namespace ShapesTests
{
    [TestClass]
    public class EmbeddedPictureTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bitmap image = new Bitmap("C:\\Users\\Camron Martinez\\Desktop\\Current OO Homework\\HW3\\HW3-OO\\Minimal (c-sharp)\\ShapesTests\\Usu-Logo.bmp");
            List<Shapes.Point> points = new List<Shapes.Point>();
            Shapes.Point p1 = new Shapes.Point("Null","Null",0,0);
            Shapes.Point p2 = new Shapes.Point("Null","Null",0,0);
            Shapes.Point p3 = new Shapes.Point("Null","Null",0,0);
            Shapes.Point p4 = new Shapes.Point("Null","Null",0,0);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);

            EmbeddedPicture myEmbed = new EmbeddedPicture("Embed1", "AquaMarine", image, 5, 5, points);

        }
    }
}
