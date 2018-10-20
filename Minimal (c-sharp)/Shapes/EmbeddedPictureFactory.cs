using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class EmbeddedPictureFactory
    {
        private static Dictionary<string, EmbeddedPicture> embeddedPictureByName = new Dictionary<string, EmbeddedPicture>();

        public static EmbeddedPicture getEmbeddedPicture(string _key, string _color, Bitmap _storedImage, int _width, int _height, List<Point> _picturePoints)         
        {
            EmbeddedPicture myEmbeddedPicture = embeddedPictureByName[_key];
            if (myEmbeddedPicture == null)
            {
                myEmbeddedPicture = new EmbeddedPicture(_key, _color, _storedImage, _width, _height, _picturePoints);
                embeddedPictureByName.Add(_key, myEmbeddedPicture);
            }
            return myEmbeddedPicture;

        }
    }
}
