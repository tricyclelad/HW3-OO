using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class RectangleFactory
    {
        public Shape2d GetRectangle(string[] parseList)
        {
            Rectangle myRectangle = new Rectangle(parseList[1], parseList[2], Convert.ToDouble(parseList[3]), Convert.ToDouble(parseList[4]), Convert.ToDouble(parseList[5]), Convert.ToDouble(parseList[6]), Convert.ToDouble(parseList[7]), Convert.ToDouble(parseList[8]), Convert.ToDouble(parseList[9]), Convert.ToDouble(parseList[10]));
            return myRectangle;
        }
    }
}
