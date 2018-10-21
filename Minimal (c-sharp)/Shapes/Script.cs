using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Script
    {
        public string[] translator(StreamReader _input)
        {
            string line = _input.ReadLine();
            string[] translation = line.Split(null);
            return translation;

        }

        public Shape2d Load(Stream input)
        {
            var reader = new StreamReader(input);
            string[] parsedString = translator(reader);
            Shape2dFactory shapeMaker = new Shape2dFactory();
            Shape2d myShape = shapeMaker.GetShape2D(parsedString);
            return myShape;
        }
        public MemoryStream Save(Shape2d _myShape)
        {
            UnicodeEncoding uniEncoding = new UnicodeEncoding();

            string scriptString = _myShape.GetData();
            byte[] firstString = uniEncoding.GetBytes(scriptString);

            MemoryStream output = new MemoryStream(100);
            output.Write(firstString,0,firstString.Length);
            return output;
        }

        //    public void Save(string filename)
        //    {
        //        var writer = new StreamWriter(filename);
        //        var extrinsicStates = new List<TreeExtrinsicState>();
        //        lock (_myLock)
        //        {
        //            foreach (var tree in _trees)
        //            {
        //                var t = tree as TreeWithAllState;
        //                if (t != null)
        //                    extrinsicStates.Add(t.ExtrinsicStatic);
        //            }
        //        }
        //        JsonSerializer.WriteObject(writer.BaseStream, extrinsicStates);
        //        writer.Close();
        //    }

        //    public void Add(Tree tree)
        //    {
        //        if (tree == null) return;
        //        lock (_myLock)
        //        {
        //            _trees.Add(tree);
        //            IsDirty = true;
        //        }
        //    }

        //    public void DeleteAllSelected()
        //    {
        //        lock (_myLock)
        //        {
        //            _trees.RemoveAll(t => t.IsSelected);
        //            IsDirty = true;
        //        }
        //    }

        //    public void ToggleSelectionAtPosition(Point location)
        //    {
        //        var tree = FindTreeAtPosition(location);

        //        if (tree != null)
        //            tree.IsSelected = !tree.IsSelected;

        //        IsDirty = true;
        //    }

        //    public Tree FindTreeAtPosition(Point location)
        //    {
        //        Tree result;
        //        lock (_myLock)
        //        {
        //            result = _trees.FindLast(t => location.X >= t.Location.X &&
        //                                          location.X < t.Location.X + t.Size.Width &&
        //                                          location.Y >= t.Location.Y &&
        //                                          location.Y < t.Location.Y + t.Size.Height);
        //        }
        //        return result;
        //    }

        //    public void DeselectAll()
        //    {
        //        lock (_myLock)
        //        {
        //            foreach (var t in _trees)
        //                t.IsSelected = false;
        //            IsDirty = true;
        //        }
        //    }

        //    public bool Draw(Graphics graphics, bool redrawEvenIfNotDirty = false)
        //    {
        //        lock (_myLock)
        //        {
        //            if (!IsDirty && !redrawEvenIfNotDirty) return false;
        //            graphics.Clear(Color.White);
        //            foreach (var t in _trees)
        //                t.Draw(graphics);
        //            IsDirty = false;
        //        }
        //        return true;
        //    }
    }
}
