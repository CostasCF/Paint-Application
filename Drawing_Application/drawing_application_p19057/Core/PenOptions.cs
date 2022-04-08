using System;
using System.Drawing;

namespace drawing_application_p19057.Core
{
    [Serializable]
    public class PenOptions
    {
        public Color PenColor { get; set; }
        public float PenWidth { get; set; }

        [NonSerialized]
        public Pen Pen;

        public PenOptions(Color penColor, float penWidth)
        {
            PenColor = penColor;
            PenWidth = penWidth;
            Pen = new Pen(PenColor, PenWidth);
            Pen.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
            Pen.MiterLimit = 1 + Pen.Width / 5f;
            Pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
        }
    }
}
