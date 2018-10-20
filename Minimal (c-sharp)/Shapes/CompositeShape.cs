﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class CompositeShape : Shape2d
    {
        List<Shape2d> myShapes = new List<Shape2d>();

        public CompositeShape(string name, string color) : base(name, color) { }

        public override void Add(Shape2d _shape2d)
        {
            myShapes.Add(_shape2d);
        }

        public override void Remove(Shape2d _shape2d)
        {
            myShapes.Remove(_shape2d);
        }

        public override string GetData()

        {

            StringBuilder SBshape2d = new StringBuilder();

            foreach (Shape2d twoD in myShapes)
            {
                SBshape2d.Append(twoD.GetData() + "\n");
            }

            return SBshape2d.ToString();
        }
    }

}


