using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
     public class Shape : Shape2d
    {
        public List<Point> myPoints;
        public Shape(string name, string color) : base(name, color) { }

        public override void Add(Shape2d _shape2d)
        {
            //Operation not permitted since this is a leaf node.
        }

        public override void Remove(Shape2d _shape2d)
        {
            //Operation not permitted since this is a leaf node.          
        }

        public override string GetData()
        {
            return "Name: " + name + "\tcolor: " + color;
        }
        public void Move(double deltaX, double deltaY)
        {
            foreach (var point in myPoints)
            {
                point.Move(deltaX, deltaY);
            }
        }
    }
}
