using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class CompositeShape : Shape2d
    {
        private List<Shape2d> myShapes = new List<Shape2d>();
        public override List<Shape2d> GetMyShapes()
        {
            return myShapes;
        }
        public CompositeShape(string name, string color) : base(name, color) {
            myShapes = new List<Shape2d>();
        }


        public override void Add(Shape2d _shape2d)
        {
            if (!myShapes.Contains(_shape2d)) 
                myShapes.Add(_shape2d);
        }

        public override void Remove(Shape2d _shape2d)
        {
            myShapes.Remove(_shape2d);
        }
        public override void RemoveAll()
        {
            myShapes.RemoveRange(0, myShapes.Count);
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
        public override double ComputeArea()
        {
            double total = 0;
            foreach (Shape2d twoD in myShapes)
            {
                total += twoD.ComputeArea();

            }
            return total;
        }

        public override void Move(double deltaX, double deltaY)
        {
            foreach (Shape2d twoD in myShapes)
            {
                twoD.Move(deltaX, deltaY);
            }
        }

    }

}


