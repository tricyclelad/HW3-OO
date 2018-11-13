using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape2dFactory
    {
        public Shape2d GetShape2D(string[] parseList)
        {

            switch (parseList[0])
            {
                case "Point":
                   PointFactory pf = new PointFactory();
                   return pf.GetPoint(parseList);
                case "Line":
                    LineFactory lf = new LineFactory();
                    return lf.GetLine(parseList);
                case "Circle":
                    CircleFactory cf = new CircleFactory();
                    return cf.GetCircle(parseList);
                case "Ellipse":
                    EllipseFactory ef = new EllipseFactory();
                    return ef.GetEllipse(parseList);
                case "Square":
                    SquareFactory sf = new SquareFactory();
                    return sf.GetSquare(parseList);
                case "Rectangle":
                    RectangleFactory rf = new RectangleFactory();
                    return rf.GetRectangle(parseList);
                case "Triangle":
                    TriangleFactory tf = new TriangleFactory();
                    return tf.GetTriangle(parseList);
                //case "CompositeShape":
                //    return CompositeShapeFactory(string[] parseList);
                //case "EmbeddedPicture":
                //    return EmbeddedPictureFactory(string[] parseList);

                default:
                    Shape2d point = new Point("null","null",-1,-1);
                    return point;
            }
        }
        //CardFactory factory = null;
        //Console.Write("Enter the card type you would like to visit: ");  
        //    string car = Console.ReadLine();  
  
        //    switch (car.ToLower())  
        //    {  
        //        case "moneyback":  
        //            factory = new MoneyBackFactory(50000, 0);  
        //            break;  
        //        case "titanium":  
        //            factory = new TitaniumFactory(100000, 500);  
        //            break;  
        //        case "platinum":  
        //            factory = new PlatinumFactory(500000, 1000);  
        //            break;  
        //        default:  
        //            break;  
    }
}
