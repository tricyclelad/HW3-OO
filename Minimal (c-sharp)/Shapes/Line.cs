﻿using System;
using System.Collections.Generic;

namespace Shapes
{
    public class Line : Shape
    {
        //public Point Point1 { get; private set; }
        //public Point Point2 { get; private set; }

        /**
         * Constructor based on x-y Locations
         * @param x1                The x-location of first point -- must be a valid double.
         * @param y1                The y-location of first point -- must be a valid double.
         * @param x2                The x-location of second point -- must be a valid double.
         * @param y2                The y-location of second point -- must be a valid double.
         * @throws ShapeException   Exception throw if any parameter is invalid
         */
        //public Line(string name, string color)
        //{
        //    this.name = name;
        //    this.color = color;
        //}
        public Line(string _name, string _color, double x1, double y1, double x2, double y2) : base(_name, _color)
        {
            this.name = _name;
            this.color = _color;
            if (x1 == x2 && y1 == y2)
                throw new ShapeException("Cannot create a line of length 0");
            var Point1 = new Point(_name+"'s Point1", _color, x1, y1);
            var Point2 = new Point(_name+"'s Point2", _color, x2, y2);
            myPoints = new List<Point>();
            myPoints.Add(Point1);
            myPoints.Add(Point2);
        }

        /**
         *
         * @param point1            The first point -- must not be null
         * @param point2            The second point -- must not b e null
         * @throws ShapeException   Exception throw if any parameter is invalid
         */
        public Line(string _name, string _color, Point point1, Point point2):base(_name, _color)
        {
            this.name = _name;
            this.color = _color;
            
            if (point1 == null || point2 == null)
                throw new ShapeException("Invalid point");
            if (point1.X == point2.X && point1.Y == point2.Y)
                throw new ShapeException("Cannot create a line of length 0");

            var Point1 = point1;
            var Point2 = point2;
            myPoints = new List<Point>();
            myPoints.Add(Point1);
            myPoints.Add(Point2);

        }

        /**
         * Move a line
         *
         * @param deltaX            The delta x-location by which the line should be moved -- must be a valid double
         * @param deltaY            The delta y-location by which the line should be moved -- must be a valid double
         * @throws ShapeException   Exception throw if any parameter is invalid
         */
        //public void Move(double deltaX, double deltaY)
        //{
        //    Point1.Move(deltaX, deltaY);
        //    Point2.Move(deltaX, deltaY);
        //}

        /**
         * @return  The length of the line
         */
        public double ComputeLength()
        {
            //return Math.Sqrt(Math.Pow(Point2.X - Point1.X, 2) +
            //                 Math.Pow(Point2.Y - Point1.Y, 2));
            return Math.Sqrt(Math.Pow(myPoints[1].X - myPoints[0].X, 2) +
                             Math.Pow(myPoints[1].Y - myPoints[0].Y, 2));
        }

        /**
         * @return  The slope of the line
         */
        public double ComputeSlope()
        {
            //return (Point2.Y - Point1.Y) / (Point2.X - Point1.X);
            return (myPoints[1].Y - myPoints[0].Y) / (myPoints[1].X - myPoints[0].X);
            
        }
    }
}
