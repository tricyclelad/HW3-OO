using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape2d
    {
        protected string name;

        protected string color;
        //protected double salary;

        public Shape2d(string name, string color)

        {
            this.name = name;
            this.color = color;
        }

        public abstract void Add(Shape2d _shape2d);

        public abstract void Remove(Shape2d _shape2d);

        public abstract string GetData();
    }
}
