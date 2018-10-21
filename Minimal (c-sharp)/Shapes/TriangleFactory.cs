using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class TriangleFactory
    {
        public Shape2d GetTriangle(string[] parseList)
        {
            Triangle myTriangle = new Triangle(parseList[1], parseList[2], Convert.ToDouble(parseList[3]), Convert.ToDouble(parseList[4]), Convert.ToDouble(parseList[5]), Convert.ToDouble(parseList[6]), Convert.ToDouble(parseList[7]), Convert.ToDouble(parseList[8]));
            return myTriangle;
        }
    }
}
