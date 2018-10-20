using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
     public class Shape
    {
        public List<Point> myPoints;
        public void Move(double deltaX, double deltaY)
        {
            foreach (var point in myPoints)
            {
                point.Move(deltaX, deltaY);
            }
        }
    }
}
