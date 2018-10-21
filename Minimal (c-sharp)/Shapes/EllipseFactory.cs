﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class EllipseFactory
    {
        public Shape2d GetEllipse(string[] parseList)
        {
            Rectangle rectangle = new Rectangle("null","null",Convert.ToDouble(parseList[3]), Convert.ToDouble(parseList[4]), Convert.ToDouble(parseList[5]), Convert.ToDouble(parseList[6]), Convert.ToDouble(parseList[7]), Convert.ToDouble(parseList[8]), Convert.ToDouble(parseList[9]), Convert.ToDouble(parseList[10]));
            Ellipse myEllipse = new Ellipse(parseList[1], parseList[2], rectangle);
            return myEllipse;
        }
    }
}
