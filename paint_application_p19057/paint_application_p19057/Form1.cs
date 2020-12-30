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
        DrawAction myaction = new DrawAction('P', Color.Blue, 3.3f);
        List<DrawAction> actions = new List<DrawAction>(); //temporary list of every indivisual momentary line 
        List<List<Point>> allactions = new List<List<Point>>(); //list containing everything the user draws
        public Form1()
        {
            InitializeComponent();
        }

        private void drawingCanvas_Paint(object sender, PaintEventArgs e)
        {
           
            Draw(e.Graphics, actions);
        }

        public void Draw(Graphics G, List<DrawAction> actions)
        {
            foreach (DrawAction da in actions)
             if (da.type == 'P' && da.points.Count > 1)
                    using (Pen pen = new Pen(da.color, da.penWidth))
                        G.DrawLines(pen, da.points.ToArray());
            // else..
            foreach (DrawAction da in actions)
                using (Pen pen = new Pen(da.color, da.penWidth))
                    foreach (List<Point> points in allactions)
                         if (points.Count > 1) G.DrawLines(pen, points.ToArray());

        }

        private void drawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {

            actions.Add(myaction); //saves the object created to actions list
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
    }
}
