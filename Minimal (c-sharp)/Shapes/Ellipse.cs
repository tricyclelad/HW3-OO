using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Ellipse
    {
        public Point Foci1 { get; private set; }
        public Point Foci2 { get; private set; }
        public Point Center { get; private set; }
        public Point Vertex1 { get; private set; }
        public Point Vertex2 { get; private set; }
        public Point Vertex3 { get; private set; }
        public Point Vertex4 { get; private set; }
        public Line Axis1 { get; private set; }
        public Line Axis2 { get; private set; }
        //The bindingrectangle is used to create an ellipse.
        public Rectangle BindingRectangle { get; private set; }

        //Create an ellipse given a binding rectangle.
        public Ellipse(Rectangle _BindingRectangle)
        {
            BindingRectangle = _BindingRectangle;
            Line Diagonal = new Line(BindingRectangle.Vertex1, BindingRectangle.Vertex3);
            Point CenterOfDiagonal = new Point(((Diagonal.Point1.X + Diagonal.Point2.X)/2), ((Diagonal.Point1.Y + Diagonal.Point2.Y)/2));
            Point CenterOfRectangleEdge1 = new Point(((BindingRectangle.Vertex1.X + BindingRectangle.Vertex2.X)/2), ((BindingRectangle.Vertex1.Y + BindingRectangle.Vertex2.Y)/2));
            Point CenterOfRectangleEdge2 = new Point(((BindingRectangle.Vertex2.X + BindingRectangle.Vertex3.X)/2), ((BindingRectangle.Vertex2.Y + BindingRectangle.Vertex3.Y)/2));
            Point CenterOfRectangleEdge3 = new Point(((BindingRectangle.Vertex3.X + BindingRectangle.Vertex4.X)/2), ((BindingRectangle.Vertex3.Y + BindingRectangle.Vertex4.Y)/2));
            Point CenterOfRectangleEdge4 = new Point(((BindingRectangle.Vertex4.X + BindingRectangle.Vertex1.X)/2), ((BindingRectangle.Vertex4.Y + BindingRectangle.Vertex1.Y)/2));

            Line _Axis1 = new Line(CenterOfRectangleEdge1, CenterOfRectangleEdge3);
            Line _Axis2 = new Line(CenterOfRectangleEdge2, CenterOfRectangleEdge4);

            Center =  CenterOfDiagonal;
            Vertex1 = CenterOfRectangleEdge1;
            Vertex2 = CenterOfRectangleEdge2;
            Vertex3 = CenterOfRectangleEdge3;
            Vertex4 = CenterOfRectangleEdge4;
            Axis1 = _Axis1;
            Axis2 = _Axis2;

            if (Axis1.ComputeLength() > Axis2.ComputeLength())
            {
                //Axis1 is major axis
                if (CenterOfRectangleEdge1.X == CenterOfRectangleEdge3.X)
                {
                    //foci are on the y axis
                    double FociDistanceFromCenter = Math.Sqrt(((Axis1.ComputeLength() / 2) * (Axis1.ComputeLength() / 2)) - ((Axis2.ComputeLength() / 2) * (Axis2.ComputeLength() / 2)));
                    Point _foci1 = new Point(CenterOfRectangleEdge1.X, Center.Y - FociDistanceFromCenter);
                    Point _foci2 = new Point(CenterOfRectangleEdge1.X, Center.Y + FociDistanceFromCenter);
                    Foci1 = _foci1;
                    Foci2 = _foci2;
                }
                else
                {
                    //Foci are on the x axis 
                    double FociDistanceFromCenter = Math.Sqrt(((Axis1.ComputeLength() / 2) * (Axis1.ComputeLength() / 2)) - ((Axis2.ComputeLength() / 2) * (Axis2.ComputeLength() / 2)));
                    Point _foci1 = new Point(Center.X - FociDistanceFromCenter, CenterOfRectangleEdge1.Y);
                    Point _foci2 = new Point(Center.X + FociDistanceFromCenter, CenterOfRectangleEdge1.Y);
                    Foci1 = _foci1;
                    Foci2 = _foci2;
                }
            }
            else
            {
                //Axis2 is major axis
                 if (CenterOfRectangleEdge1.X == CenterOfRectangleEdge3.X)
                {
                    //foci are on the x axis
                    double FociDistanceFromCenter = Math.Sqrt(((Axis2.ComputeLength() / 2) * (Axis2.ComputeLength() / 2)) - ((Axis1.ComputeLength() / 2) * (Axis1.ComputeLength() / 2)));
                    Point _foci1 = new Point(CenterOfRectangleEdge1.X, Center.Y - FociDistanceFromCenter);
                    Point _foci2 = new Point(CenterOfRectangleEdge1.X, Center.Y + FociDistanceFromCenter);
                    Foci1 = _foci1;
                    Foci2 = _foci2;

                }
                else
                {
                    //Focis are on the y axis 
                    double FociDistanceFromCenter = Math.Sqrt(((Axis2.ComputeLength() / 2) * (Axis2.ComputeLength() / 2)) - ((Axis1.ComputeLength() / 2) * (Axis1.ComputeLength() / 2)));
                    Point _foci1 = new Point(Center.X - FociDistanceFromCenter, CenterOfRectangleEdge1.Y);
                    Point _foci2 = new Point(Center.X + FociDistanceFromCenter, CenterOfRectangleEdge1.Y);
                    Foci1 = _foci1;
                    Foci2 = _foci2;
                }   

            }



        }
        //Create an Ellipse with vertices of a binding rectangle
        public Ellipse(Point _Vertex1, Point _Vertex2, Point _Vertex3, Point _Vertex4)
        {
            Rectangle _BindingRectangle = new Rectangle(_Vertex1, _Vertex2, _Vertex3, _Vertex4);
            BindingRectangle = _BindingRectangle;
            Line Diagonal = new Line(BindingRectangle.Vertex1, BindingRectangle.Vertex3);
            Point CenterOfDiagonal = new Point(((Diagonal.Point1.X + Diagonal.Point2.X) / 2), ((Diagonal.Point1.Y + Diagonal.Point2.Y) / 2));
            Point CenterOfRectangleEdge1 = new Point(((BindingRectangle.Vertex1.X + BindingRectangle.Vertex2.X) / 2), ((BindingRectangle.Vertex1.Y + BindingRectangle.Vertex2.Y) / 2));
            Point CenterOfRectangleEdge2 = new Point(((BindingRectangle.Vertex2.X + BindingRectangle.Vertex3.X) / 2), ((BindingRectangle.Vertex2.Y + BindingRectangle.Vertex3.Y) / 2));
            Point CenterOfRectangleEdge3 = new Point(((BindingRectangle.Vertex3.X + BindingRectangle.Vertex4.X) / 2), ((BindingRectangle.Vertex3.Y + BindingRectangle.Vertex4.Y) / 2));
            Point CenterOfRectangleEdge4 = new Point(((BindingRectangle.Vertex4.X + BindingRectangle.Vertex1.X) / 2), ((BindingRectangle.Vertex4.Y + BindingRectangle.Vertex1.Y) / 2));

            Line _Axis1 = new Line(CenterOfRectangleEdge1, CenterOfRectangleEdge3);
            Line _Axis2 = new Line(CenterOfRectangleEdge2, CenterOfRectangleEdge4);

            Center = CenterOfDiagonal;
            Vertex1 = CenterOfRectangleEdge1;
            Vertex2 = CenterOfRectangleEdge2;
            Vertex3 = CenterOfRectangleEdge3;
            Vertex4 = CenterOfRectangleEdge4;
            Axis1 = _Axis1;
            Axis2 = _Axis2;

            if (Axis1.ComputeLength() > Axis2.ComputeLength())
            {
                //Axis1 is major axis
                if (CenterOfRectangleEdge1.X == CenterOfRectangleEdge3.X)
                {
                    //foci are on the y axis
                    double FociDistanceFromCenter = Math.Sqrt(((Axis1.ComputeLength() / 2) * (Axis1.ComputeLength() / 2)) - ((Axis2.ComputeLength() / 2) * (Axis2.ComputeLength() / 2)));
                    Point _foci1 = new Point(CenterOfRectangleEdge1.X, Center.Y - FociDistanceFromCenter);
                    Point _foci2 = new Point(CenterOfRectangleEdge1.X, Center.Y + FociDistanceFromCenter);
                    Foci1 = _foci1;
                    Foci2 = _foci2;
                }
                else
                {
                    //Foci are on the x axis 
                    double FociDistanceFromCenter = Math.Sqrt(((Axis1.ComputeLength() / 2) * (Axis1.ComputeLength() / 2)) - ((Axis2.ComputeLength() / 2) * (Axis2.ComputeLength() / 2)));
                    Point _foci1 = new Point(Center.X - FociDistanceFromCenter, CenterOfRectangleEdge1.Y);
                    Point _foci2 = new Point(Center.X + FociDistanceFromCenter, CenterOfRectangleEdge1.Y);
                    Foci1 = _foci1;
                    Foci2 = _foci2;
                }
            }
            else
            {
                //Axis2 is major axis
                if (CenterOfRectangleEdge1.X == CenterOfRectangleEdge3.X)
                {
                    //foci are on the y axis
                    double FociDistanceFromCenter = Math.Sqrt(((Axis2.ComputeLength() / 2) * (Axis2.ComputeLength() / 2)) - ((Axis1.ComputeLength() / 2) * (Axis1.ComputeLength() / 2)));
                    Point _foci1 = new Point(CenterOfRectangleEdge1.X, Center.Y - FociDistanceFromCenter);
                    Point _foci2 = new Point(CenterOfRectangleEdge1.X, Center.Y + FociDistanceFromCenter);
                    Foci1 = _foci1;
                    Foci2 = _foci2;

                }
                else
                {
                    //Focis are on the x axis 
                    double FociDistanceFromCenter = Math.Sqrt(((Axis2.ComputeLength() / 2) * (Axis2.ComputeLength() / 2)) - ((Axis1.ComputeLength() / 2) * (Axis1.ComputeLength() / 2)));
                    Point _foci1 = new Point(Center.X - FociDistanceFromCenter, CenterOfRectangleEdge1.Y);
                    Point _foci2 = new Point(Center.X + FociDistanceFromCenter, CenterOfRectangleEdge1.Y);
                    Foci1 = _foci1;
                    Foci2 = _foci2;
                }

            }
        }
            public void MoveEllipse(double deltaX, double deltaY)
            {
                Center.Move(deltaX, deltaY);
                Vertex1.Move(deltaX, deltaY);
                Vertex2.Move(deltaX, deltaY);
                Vertex3.Move(deltaX, deltaY);
                Vertex4.Move(deltaX, deltaY);
                Foci1.Move(deltaX, deltaY);
                Foci2.Move(deltaX, deltaY);
                Axis1.Move(deltaX, deltaY);
                Axis2.Move(deltaX, deltaY);
                BindingRectangle.Move(deltaX, deltaY);
            }
        public double ComputeArea()
        {
            return Math.PI * Axis1.ComputeLength() / 2 * Axis2.ComputeLength() / 2;
        }
    }
}
