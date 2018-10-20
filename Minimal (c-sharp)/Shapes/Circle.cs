using System;
using System.Collections.Generic;

namespace Shapes
{
    public class Circle: Shape
    {
        //public Point Center { get; private set; }
        public double Radius { get; private set;  }

        /**
         * Constructor with x-y Location for center
         *
         * @param x                 The x-location of the center of the circle -- must be a valid double
         * @param y                 The y-location of the center of the circle
         * @param radius            The radius of the circle -- must be greater or equal to zero.
         * @throws ShapeException   The exception thrown if the x, y, or z are not valid
         */
        public Circle(string _name, string _color, double x, double y, double radius): base(_name, _color)
        {
            Validator.ValidatePositiveDouble(radius, "Invalid radius");
            var Center = new Point(_name + "CenterPoint", _color, x, y);
            myPoints = new List<Point>();
            myPoints.Add(Center);
            Radius = radius;
            this.name = _name;
            this.color = _color;
        }

        /**
         * Constructor with a Point for center
         *
         * @param center            The x-location of the center of the circle -- must be a valid point
         * @param radius            The radius of the circle -- must be greater or equal to zero.
         * @throws ShapeException   The exception thrown if the x, y, or z are not valid
         */
        public Circle(string _name, string _color, Point center, double radius): base(_name, _color) {
        
            Validator.ValidatePositiveDouble(radius, "Invalid radius");
            if (center == null)
                throw new ShapeException("Invalid center point");

            var Center = center;
            myPoints = new List<Point>();
            myPoints.Add(Center);
            Radius = radius;
        }

        /**
         * Move the circle
         * @param deltaX            a delta change for the x-location of center of the circle
         * @param deltaY            a delta change for the y-location of center of the circle
         * @throws ShapeException   Exception thrown if either the delta x or y are not valid doubles
         */
        //public void Move(double deltaX, double deltaY)
        //{
        //    Center.Move(deltaX, deltaY);
        //}

        /**
         * Scale the circle
         *
         * @param scaleFactor       a non-negative double that represents the percentage to scale the circle.
         *                          0>= and <1 to shrink.
         *                          >1 to grow.
         * @throws ShapeException   Exception thrown if the scale factor is not valid
         */
        public void Scale(double scaleFactor)
        {
            Validator.ValidatePositiveDouble(scaleFactor, "Invalid scale factor");
            Radius *= scaleFactor;
        }

        /**
         * @return  The area of the circle.
         */
        public double ComputeArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
