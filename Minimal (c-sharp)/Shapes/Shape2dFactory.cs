using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape2dFactory
    {
        public Shape2d GetShape2D(string[] parseList)
        {

            switch (parseList[0])
            {
                case "Point":
                    return PointFactory(string[] parseList);
                    break;
                case "Line":
                    return LineFatory(string[] parseList);
                    break;
                case "Circle":
                    return CircleFactory(string[] parseList);
                    break;
                case "Ellipse":
                    return EllipseFactory(string[] parseList);
                    break;
                case "Square":
                    return SquareFactory(string[] parseList);
                    break;
                case "Rectangle":
                    return RectangleFactory(string[] parseList);
                    break;
                case "Triangle":
                    return TriangleFactory(string[] parseList);
                    break;
                case "CompositeShape":
                    return CompositeShapeFactory(string[] parseList);
                    break;
                case "EmbeddedPicture":
                    return EmbeddedPictureFactory(string[] parseList);
                    break;

                default:
                    break;
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
