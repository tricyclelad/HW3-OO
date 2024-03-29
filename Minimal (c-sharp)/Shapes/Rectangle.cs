﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        //public Point Vertex1 { get; private set; }
        //public Point Vertex2 { get; private set; }
        //public Point Vertex3 { get; private set; }
        //public Point Vertex4 { get; private set; }
        public Line Width { get; private set; }
        public Line Height { get; private set; }

        public Rectangle(string _name, string _color, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4): base(_name, _color)
        {
            var Vertex1 = new Point( _name + "'s Vertex1", _color, x1,y1);
            var Vertex2 = new Point( _name + "'s Vertex2", _color, x2,y2);
            var Vertex3 = new Point( _name + "'s Vertex3", _color, x3,y3);
            var Vertex4 = new Point( _name + "'s Vertex4", _color, x4,y4);
            myPoints = new List<Point>();
            myPoints.Add(Vertex1);
            myPoints.Add(Vertex2);
            myPoints.Add(Vertex3);
            myPoints.Add(Vertex4);

            if(AreVerticesEqual(Vertex1, Vertex2, Vertex3, Vertex4))
            {
                throw new ShapeException("Two or more Rectangle Vertices are equal");
            }
            Width = new Line( _name + "'s Width", _color, Vertex1, Vertex2);
            Height = new Line( _name + "'s Height", _color, Vertex1, Vertex4);

            if(!AreSidesSameLength())
            {
                throw new ShapeException("Two or more corresponding sides are not equal lengths");
            }

            if(!AreDiagonalsSameLength())
            {
                throw new ShapeException("Atleast one vertex is not squared with the other vertices");
            }
        }
        public Rectangle(string _name, string _color, Point _Vertex1, Point _Vertex2, Point _Vertex3, Point _Vertex4) : base(_name, _color)
        {
            var Vertex1 = _Vertex1;
            var Vertex2 = _Vertex2;
            var Vertex3 = _Vertex3;
            var Vertex4 = _Vertex4;
            myPoints = new List<Point>();
            myPoints.Add(Vertex1);
            myPoints.Add(Vertex2);
            myPoints.Add(Vertex3);
            myPoints.Add(Vertex4);

            if(AreVerticesEqual(Vertex1, Vertex2, Vertex3, Vertex4))
            {
                throw new ShapeException("Two or more Rectangle Vertices are equal");
            }
            Width = new Line( _name + "'s Width", _color, Vertex1, Vertex2);
            Height = new Line( _name + "'s Height", _color, Vertex1, Vertex4);

            if(!AreSidesSameLength())
            {
                throw new ShapeException("Two or more corresponding sides are not equal lengths");
            }

            if(!AreDiagonalsSameLength())
            {
                throw new ShapeException("Atleast one vertex is not squared with the other vertices");
            }
        }
        //public void Move(double deltaX, double deltaY)
        //{
        //    Vertex1.Move(deltaX, deltaY);
        //    Vertex2.Move(deltaX, deltaY);
        //    Vertex3.Move(deltaX, deltaY);
        //    Vertex4.Move(deltaX, deltaY);
        //}

        public override double ComputeArea()
        {
            //Compute area using Heron's formula

            double area = Width.ComputeLength() * Height.ComputeLength();

            return area;
        }
        public bool AreVerticesEqual(Point _Vertex1, Point _Vertex2, Point _Vertex3, Point _Vertex4)
        {
            if (Validator.ArePointsEqual(_Vertex1, _Vertex2))
            {
                return true;
            }

            if (Validator.ArePointsEqual(_Vertex1, _Vertex3))
            {
                return true;
            }

            if (Validator.ArePointsEqual(_Vertex1, _Vertex4))
            {
                return true;
            }

            if (Validator.ArePointsEqual(_Vertex2, _Vertex3))
            {
                return true;
            }
            
            if (Validator.ArePointsEqual(_Vertex2, _Vertex4))
            {
                return true;
            }

            if (Validator.ArePointsEqual(_Vertex3, _Vertex4))
            {
                return true;
            }
            return false;

        }
        public bool AreSidesSameLength()
        {
            Line Width1 = new Line("null","null",myPoints[0], myPoints[1]);
            Line Width2 = new Line("null","null",myPoints[2], myPoints[3]);
            Line Height1 = new Line("null","null",myPoints[0], myPoints[3]);
            Line Height2 = new Line("null","null",myPoints[1], myPoints[2]);
            if (Validator.AreLineLengthsEqual(Width1, Width2) && Validator.AreLineLengthsEqual(Height1, Height2))
                return true;
            return false;
        }
        public bool AreDiagonalsSameLength()
        {
            Line Diagonal1 = new Line("null","null",myPoints[0], myPoints[2]);
            Line Diagonal2 = new Line("null","null",myPoints[1], myPoints[3]);
            if (Validator.AreLineLengthsEqual(Diagonal1, Diagonal2))
                return true;
            return false;
        }

        //public bool IsRectangle()
        //{
        //    if (AreSidesSameLength() && AreDiagonalsSameLength())
        //        return true;
        //    return false;
        //}

    }
}
