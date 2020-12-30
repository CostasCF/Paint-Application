using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace paint_application_p19057
{
    public partial class Form1 : Form
    {
      Pen pen;
        DrawAction myaction = new DrawAction('P', Color.Blue, 3.3f);
        List<DrawAction> actions = new List<DrawAction>();
        List<List<Point>> allactions = new List<List<Point>>();
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 3);
        }

        private void drawingCanvas_Paint(object sender, PaintEventArgs e)
        {
            actions.Add(myaction);
            Draw(e.Graphics, actions);
          
        }

        public void Draw(Graphics G, List<DrawAction> actions)
        {
            foreach (DrawAction da in actions)
             if (da.type == 'P' && da.points.Count > 1)
                    using (Pen pen = new Pen(da.color, da.penWidth))
                        G.DrawLines(pen, da.points.ToArray());
            // else..
            foreach (List<Point> points in allactions)

                if (points.Count > 1) G.DrawLines(pen, points.ToArray());

        }

        private void drawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {
           
            drawingCanvas.Cursor = Cursors.Cross;
            if (actions.Count > 1)
            {
                // begin fresh line or curve
                myaction.points.Clear();
                // startpoint
                myaction.points.Add(e.Location);
            }
        }
        private void drawingCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (actions.Count > 1)
            {
                // ToList creates a copy
                allactions.Add(myaction.points.ToList());

                myaction.points.Clear();
            }
        }

        private void drawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {

             if (e.Button != MouseButtons.Left) return;
            // here we should check if the distance is more than a minimum!
            myaction.points.Add(e.Location);
            // let it show
            drawingCanvas.Invalidate();
        }

        void AddTestActions()
        {
            actions.Add(new DrawAction('L', Color.Blue, 3.3f));
            actions[0].points.Add(new Point(23, 34));
            actions[0].points.Add(new Point(23, 134));
            actions.Add(new DrawAction('P', Color.Red, 1.3f));
            actions[1].points.Add(new Point(11, 11));
            actions[1].points.Add(new Point(55, 11));
            actions[1].points.Add(new Point(55, 77));
            actions[1].points.Add(new Point(11, 77));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTestActions();
            Bitmap bmp = new Bitmap(drawingCanvas.ClientSize.Width,
                                   drawingCanvas.ClientSize.Height);
            using (Graphics G = Graphics.FromImage(bmp)) Draw(G, actions);
            drawingCanvas.Image = bmp;
        }

      
    }
}
