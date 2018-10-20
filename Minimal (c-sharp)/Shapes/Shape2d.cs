using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape2d
    {
        public string name { get; protected set; }

        public string color { get; protected set; }
        //protected double salary;

        public Shape2d(string name, string color)

        {
            this.name = name;
            this.color = color;
        }

        public abstract void Add(Shape2d _shape2d);

        public abstract void Remove(Shape2d _shape2d);

        public abstract string GetData();
        public abstract double ComputeArea();
        public abstract List<Shape2d> GetMyShapes();
    }
}
