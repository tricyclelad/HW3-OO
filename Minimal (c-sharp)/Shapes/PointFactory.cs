using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class PointFactory
    {
        public Shape2d GetPoint(string[] parseList)
        {
            Point myPoint = new Point(parseList[1], parseList[2], Convert.ToDouble(parseList[3]), Convert.ToDouble(parseList[4]));
            return myPoint;
        }
    }
}
