using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class LineFactory
    {
        public Shape2d GetLine(string[] parseList)
        {
            Line myLine = new Line(parseList[1], parseList[2], Convert.ToDouble(parseList[3]), Convert.ToDouble(parseList[4]),Convert.ToDouble(parseList[5]), Convert.ToDouble(parseList[6]));
            return myLine;
        }
    }
}
