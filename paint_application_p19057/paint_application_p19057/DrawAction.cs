using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint_application_p19057
{
    public class DrawAction
    {
        public char type { get; set; }             // this should be an Enum!
        public Color color { get; set; }
        public float penWidth { get; set; }        // only one of many Pen properties!
        public List<Point> points { get; set; }    // use PointF for more precision
        
       

        public DrawAction(char type_, Color color_, float penwidth_)
        {
            type = type_; color = color_; penWidth = penwidth_;;
            points = new List<Point>();
        }
    }
}
