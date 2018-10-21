using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class CircleFactory
    {
        public Shape2d GetCircle(string[] parseList)
        {
            Circle myCircle = new Circle(parseList[1], parseList[2], Convert.ToDouble(parseList[3]), Convert.ToDouble(parseList[4]), Convert.ToDouble(parseList[5]));
            return myCircle;
        }
    }
}
