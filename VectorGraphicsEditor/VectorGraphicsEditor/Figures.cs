﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_editor;

namespace VectorGraphicsEditor
{
    public class Rectangle : Figure
    {
        public Rectangle(Point DownLeft, Point UpRight, Color BorderColor, Color FillColor)
        {
            Colored = true;
            Is1D = false;
            this.FillColor = FillColor;

            _figureBorder = new List<Point>()
            {
                new Point(UpRight.X, DownLeft.Y),
                UpRight,
                new Point(UpRight.Y, DownLeft.X),
                DownLeft
            };

            _figureBorder = new List<Point>(_figureBorder);

             _triangles = new List<trTriangle>()
            {
                new trTriangle(_figureBorder[0], _figureBorder[1], _figureBorder[2]),
                new trTriangle(_figureBorder[2], _figureBorder[3], _figureBorder[0])
            };

        }

        public override bool Colored { get;set;}

        public override Color FillColor { get; set; }

        public override bool Is1D { get; protected set; }

        public override Color LineColor { get; set; }

        public override Dictionary<string, object> Parameters { get; set; }

        public override IPath Paths { get; }

        public override string type { get; set; }

        public override IFigure Clone(Dictionary<string, object> parms)
        {
            return new Rectangle((Point)parms["DownLeft"],
                            (Point)parms["UpRight"],
                            (Color)parms["BorderColor"],
                            (Color)parms["FillColor"]);
        }

        public override void FillPaths()
        {
            throw new NotImplementedException();
        }

        public override Tuple<IEnumerable<trTriangle>, IEnumerable<ILineContainer>> NewTriangulation(double eps)
        {
            throw new NotImplementedException();
        }

        public override IFigure Transform(ITransformation transform)
        {
            throw new NotImplementedException();
        }
    }

    public class Triangle : Figure
    {
        public Triangle(Point Point1, Point Point2, Point Point3, Color BorderColor, Color FillColor)
        {
            Colored = true;
            Is1D = false;
            this.FillColor = FillColor;

            _figureBorder = new List<Point>()
            {
                new Point(Point1.X, Point1.Y),
                new Point(Point2.X, Point2.Y),
                new Point(Point3.X, Point3.Y)
            };

            _figureBorder = new List<Point>(_figureBorder);

            _triangles = new List<trTriangle>()
            {
                new trTriangle(_figureBorder[0], _figureBorder[1], _figureBorder[2]),
            };

        }
        public override string type { get; set;}

        public override Dictionary<string, object> Parameters { get; set;}

        public override IPath Paths { get ; }

        public override bool Colored { get; set; }

        public override Color FillColor { get; set; }

        public override Color LineColor { get; set; }

        public override bool Is1D { get;  protected set; }

        public override void FillPaths()
        {
            throw new NotImplementedException();
        }

        public override Tuple<IEnumerable<Interfaces.trTriangle>, IEnumerable<ILineContainer>> NewTriangulation(double eps)
        {
            throw new NotImplementedException();
        }

        public override IFigure Clone(Dictionary<string, object> parms)
        {
            return new Triangle((Point)parms["Point1"],
                            (Point)parms["Point2"],
                            (Point)parms["Point3"],
                            (Color)parms["BorderColor"],
                            (Color)parms["FillColor"]);
        }

        public override IFigure Transform(ITransformation transform)
        {
            throw new NotImplementedException();
        }
    }

}
