using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Shapes
{
    public class EmbeddedPicture : Shape2d
    {
        Bitmap storedImage;
        Double Width, Height;
        List<Point> myEmbeddedPicturePoints;
        
        public EmbeddedPicture(string _name, string _color, Bitmap _storedImage, double width, double height, List<Point> _picturePoints):base(_name, _color)
        {
            storedImage = _storedImage;
            myEmbeddedPicturePoints = _picturePoints;
            Width = width;
            Height = height;

        }
        public override void Add(Shape2d _shape2d)
        {
            //Not used
        }

        public override double ComputeArea()
        {
            return Width * Height;
        }

        public override string GetData()
        {
            throw new NotImplementedException();
        }

        public override List<Shape2d> GetMyShapes()
        {
            throw new NotImplementedException();
        }

        public override void Move(double deltaX, double deltaY)
        {
            foreach (var point in myEmbeddedPicturePoints)
            {
                point.Move(deltaX,deltaY);
            }
        }

        public override void Remove(Shape2d _shape2d)
        {
            throw new NotImplementedException();
        }

        public override void RemoveAll()
        {
            throw new NotImplementedException();
        }
    }
}
