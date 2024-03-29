﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
     public abstract class Shape : Shape2d
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
        public override void RemoveAll()
        {
            //Operation not permitted since this is a leaf node.          
        }
        
        public override List<Shape2d> GetMyShapes()
        {
            List<Shape2d> myNullShapes = new List<Shape2d>();
            return myNullShapes;
            //This returns null because we don't want the simple shape to have shapes
        }

        public override string GetData()
        {
            StringBuilder myBuilder = new StringBuilder();
            myBuilder.Append(name + " " + color + " " );
            foreach (var point in myPoints)
            {
                for (int i = 0; i < point.myPoints.Count; i++)
                {
                    myBuilder.Append(point.myPoints[i].X);
                    myBuilder.Append(" ");
                    myBuilder.Append(point.myPoints[i].Y);
                    myBuilder.Append(" ");
                }

            }
            return myBuilder.ToString();
        }
        //public abstract double ComputeArea();
        public override void Move(double deltaX, double deltaY)
        {
            foreach (var point in myPoints)
            {
                point.Move(deltaX, deltaY);
            }
        }


    }
}
