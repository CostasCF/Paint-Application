using System;
using System.Collections.Generic;
using System.Drawing;

namespace drawing_application_p19057.Core
{
    [Serializable]
    public class Shapes
    {

        public List<Point> Points { get; set; }
        public Coordinates Coordinates { get; set; }
        public PenOptions PenOptions { get; set; }

        public Shapes(PenOptions penOptions, List<Point> points, Coordinates coordinates)
        {
            PenOptions = penOptions;
            Points = points;
            Coordinates = new Coordinates(coordinates.MouseDownX, coordinates.MouseDownY, coordinates.MouseUpX, coordinates.MouseUpY);
        }

    }
    [Serializable]
    public class Ellipse : Shapes
    {
        public Ellipse(PenOptions penOptions, List<Point> points, Coordinates coordinates) : base(penOptions, points, coordinates)
        {

        }
    }
    [Serializable]
    public class Square : Shapes
    {
        public Square(PenOptions penOptions, List<Point> points, Coordinates coordinates) : base(penOptions, points, coordinates)
        {

        }
    }
    [Serializable]
    public class Circle : Shapes
    {
        public Circle(PenOptions penOptions, List<Point> points, Coordinates coordinates) : base(penOptions, points, coordinates)
        {

        }
    }
    [Serializable]
    public class Line : Shapes
    {
        public Line(PenOptions penOptions, List<Point> points, Coordinates coordinates) : base(penOptions, points, coordinates)
        {

        }
    }
    [Serializable]
    public class Freestyle : Shapes
    {
        public Freestyle(PenOptions penOptions, List<Point> points, Coordinates coordinates) : base(penOptions, points, coordinates)
        {

        }
    }
}
