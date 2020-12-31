using System;
using System.Collections;
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
        DrawAction myaction;
        int temporaryPoints;
        Pen pen;
         List<DrawAction> actions = new List<DrawAction>(); //temporary list of every indivisual momentary line 
        List<List<Point>> allactions = new List<List<Point>>(); //list containing everything the user draws

       // ArrayList<Point> alldraws = new ArrayList();
        public Form1()
        {
            InitializeComponent();
  
         //   var idk = Color.Black;
           myaction = new DrawAction('P',Color.Black, 3.3f);
        }

        //private void colorSelecting()
        //{
        //    if (selection) { myaction = new DrawAction('P', pen.Color, 3.3f); }
        //}
        private void drawingCanvas_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics, actions);
        }

        public void Draw(Graphics G, List<DrawAction> actions)
        {
            foreach (DrawAction da in actions)
             if (da.type == 'P' && da.points.Count > 1)
                    using (Pen pen = new Pen(myaction.color, myaction.penWidth))
                        G.DrawLines(pen, da.points.ToArray());
            // else..
            foreach (DrawAction da in actions)
                using (Pen pen = new Pen(myaction.color, myaction.penWidth))
                    foreach (List<Point> points in allactions)
                         if (points.Count > 1) G.DrawLines(pen, points.ToArray());

        }

        private void drawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {

         
            drawingCanvas.Cursor = Cursors.Cross;
            if (actions.Count >= 1)
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
                actions.Add(myaction); //saves the object created to actions list
                // ToList creates a copy
                allactions.Add(myaction.points.ToList());
                myaction.points.Clear();

                 temporaryPoints = allactions.Count(); 
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

        private void redColor_Click(object sender, EventArgs e)
        {
            allactions = new List<List<Point>>();
            myaction.color = Color.Red;
           // myaction = new DrawAction('P', pen.Color, 3.3f);
        }

        private void orangeColor_Click(object sender, EventArgs e)
        {
           
            allactions = new List<List<Point>>();
            myaction.color = Color.Orange;
            // myaction = new DrawAction('P', pen.Color, 3.3f);
        }

        private void greenColor_Click(object sender, EventArgs e)
        {
          
            
            myaction = new DrawAction('P', Color.Green, 3.3f);
        }

        private void blueColor_Click(object sender, EventArgs e)
        {

            
            myaction = new DrawAction('P', Color.Blue, 3.3f);
        }

        private void colorDialogBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) { DrawAction myaction = new DrawAction('P', colorDialog1.Color, 3.3f); }

        }
    }
}
