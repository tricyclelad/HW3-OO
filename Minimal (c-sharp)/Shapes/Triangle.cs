﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        //public Point Vertex1 { get; private set; }
        //public Point Vertex2 { get; private set; }
        //public Point Vertex3 { get; private set; }
        public Line Edge1 { get; private set; }
        public Line Edge2 { get; private set; }
        public Line Edge3 { get; private set; }


        public Triangle(string _name, string _color, double x1, double y1, double x2, double y2, double x3, double y3) : base(_name, _color)
        {
            var Vertex1 = new Point(_name + "'s Vertex1", _color, x1, y1);
            var Vertex2 = new Point(_name + "'s Vertex2", _color, x2, y2);
            var Vertex3 = new Point(_name + "'s Vertex3", _color, x3, y3);
            myPoints = new List<Point>();
            myPoints.Add(Vertex1);
            myPoints.Add(Vertex2);
            myPoints.Add(Vertex3);

            if(AreVerticesEqual(Vertex1, Vertex2, Vertex3))
            {
                throw new ShapeException("Two or more Triangle Vertices are equal");
            }
 
            Edge1 = new Line(_name + "'s Edge1", _color, Vertex1, Vertex2); 
            Edge2 = new Line(_name + "'s Edge2", _color, Vertex2, Vertex3); 
            Edge3 = new Line(_name + "'s Edge2", _color, Vertex3, Vertex1);

            if(AreEdgeSlopesEqual())
            {
                throw new ShapeException("Invalid triangle edges: 1 or more lines are in same location");
            }

            //if (AreEdgesEqual())
            //{
            //    throw new ShapeException("Invalid triangle edges: 1 or more lines are in same location");
            //}

            //if (!AreEdgeLengthsValid())
            //{
            //    throw new ShapeException("Invalid triangle edge lengths");
            //}

        }
        public Triangle(string _name, string _color, Point _Vertex1, Point _Vertex2, Point _Vertex3): base(_name, _color)
        {
            
            var Vertex1 = _Vertex1;
            var Vertex2 = _Vertex2;
            var Vertex3 = _Vertex3;
            myPoints = new List<Point>();
            myPoints.Add(Vertex1);
            myPoints.Add(Vertex2);
            myPoints.Add(Vertex3);

            if(AreVerticesEqual(_Vertex1, _Vertex2, _Vertex3))
            {
                throw new ShapeException("Two or more Triangle Vertices are equal");
            }

            Edge1 = new Line(_name + "'s Edge1", _color, Vertex1, Vertex2); 
            Edge2 = new Line(_name + "'s Edge1", _color, Vertex2, Vertex3); 
            Edge3 = new Line(_name + "'s Edge1", _color, Vertex3, Vertex1); 

            if(AreEdgeSlopesEqual())
            {
                throw new ShapeException("Invalid triangle edges: 1 or more lines are in same location");
            }
            //if (AreEdgesEqual())
            //{
            //    throw new ShapeException("Invalid triangle edges: 1 or more lines are in same location");
            //}

            //if (!AreEdgeLengthsValid())
            //{
            //    throw new ShapeException("Invalid triangle edge Lengths");
            //}

        }
        //public void Move(double deltaX, double deltaY)
        //{
        //    Vertex1.Move(deltaX, deltaY);
        //    Vertex2.Move(deltaX, deltaY);
        //    Vertex3.Move(deltaX, deltaY);
        //}

        public override double ComputeArea()
        {
            //Compute area using Heron's formula
            double semiperimiter = (Edge1.ComputeLength() + Edge2.ComputeLength() + Edge3.ComputeLength()) / 2;

            double area = Math.Sqrt(semiperimiter * (semiperimiter - Edge1.ComputeLength()) * (semiperimiter - Edge2.ComputeLength()) * (semiperimiter - Edge3.ComputeLength()));

            return area;
        }
        private bool AreEdgeSlopesEqual()
        {
            if (Edge1.ComputeSlope() == Edge2.ComputeSlope())
                return true;
            if (Edge2.ComputeSlope() == Edge3.ComputeSlope())
                return true;
            if (Edge1.ComputeSlope() == Edge3.ComputeSlope())
                return true;
            return false;
        }
        private bool AreVerticesEqual(Point _Vertex1, Point _Vertex2, Point _Vertex3)
        {
            if (Validator.ArePointsEqual(_Vertex1, _Vertex2))
            {
                return true;
            }

            if (Validator.ArePointsEqual(_Vertex2, _Vertex3))
            {
                return true;
            }

            if (Validator.ArePointsEqual(_Vertex1, _Vertex3))
            {
                return true;
            }
            return false;

        }

     

        //private bool AreEdgeLengthsValid()
        //{
        //    if (Edge1.ComputeLength() + Edge2.ComputeLength() < Edge3.ComputeLength())
        //        return false;
        //    if (Edge1.ComputeLength() + Edge3.ComputeLength() < Edge2.ComputeLength())
        //        return false;
        //    if (Edge2.ComputeLength() + Edge3.ComputeLength() < Edge1.ComputeLength())
        //        return false;
        //    return true;
        //}

        //private bool AreEdgesEqual()
        //{

        //    if (Validator.AreLinesEqual(Edge1, Edge2))
        //        return true;

        //    if (Validator.AreLinesEqual(Edge2, Edge3))
        //        return true;

        //    if (Validator.AreLinesEqual(Edge1, Edge3))
        //        return true;
        //    return false;
        //}


    }
}
