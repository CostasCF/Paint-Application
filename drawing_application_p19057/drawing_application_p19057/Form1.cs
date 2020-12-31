using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace drawing_application_p19057
{
    public partial class Form1 : Form
    {
        //για μετακινηση(Drag) εφαρμογης
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // List of user's points he creates
        private List<Point> currentCurve = new List<Point>();
        private List<PenSettings> curves = new List<PenSettings>();

        // Tools for drawing
        Pen pen;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 2);
        }


        //general settings
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
           
            if (this.WindowState == FormWindowState.Maximized) { this.WindowState = FormWindowState.Normal; } else { this.WindowState = FormWindowState.Maximized; }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void topPanel_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) { this.WindowState = FormWindowState.Normal; } else { this.WindowState = FormWindowState.Maximized; }
        }

        private void fileToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            fileToolStripMenuItem1.BackColor = Color.Red;
        }

        private void fileToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
            fileToolStripMenuItem1.BackColor = Color.Red;
        }

        private void moreColors_MouseLeave(object sender, EventArgs e)
        {
            moreColors.BackColor = Color.Transparent;
        }

        private void moreColors_MouseEnter(object sender, EventArgs e)
        {
            
            moreColors.BackColor = Color.FromArgb(63, 63, 65);
        }
        private void moreColors_MouseHover(object sender, EventArgs e)
        {
            moreColorsTp.SetToolTip(moreColors, "More Colors");
        }

        //drawing settings
        private void drawingBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentCurve.Count > 1)
            {
                PenSettings penSettings = new PenSettings(pen, currentCurve.ToList()); // Copy the list so it not by reference
                curves.Add(penSettings);
            }

            currentCurve.Clear();
            drawingBox.Invalidate();
        }

        private void drawingBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentCurve.Add(e.Location);
                drawingBox.Invalidate();
            }
        }

        private void drawingBox_Paint(object sender, PaintEventArgs e)
        {

            if (currentCurve.Count > 1) e.Graphics.DrawCurve(pen, currentCurve.ToArray());

            foreach (PenSettings penSettings in curves)
                if (penSettings.Points.Count > 1) e.Graphics.DrawCurve(penSettings.Pen, penSettings.Points.ToArray());
        }

        private void moreColors_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) { pen.Color = colorDialog1.Color; }
        }

        private void redBox_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void blueBox_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void yellowBox_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }

        private void greenBox_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Displays a SaveFileDialog so the user can save the Image they drawed
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        bmp = new Bitmap(drawingBox.ClientSize.Width, drawingBox.ClientSize.Height);
                        drawingBox.DrawToBitmap(bmp, drawingBox.ClientRectangle);
                        bmp.Save(fs, ImageFormat.Jpeg);
                        break;

                    case 2:
                        bmp = new Bitmap(drawingBox.ClientSize.Width, drawingBox.ClientSize.Height);
                        drawingBox.DrawToBitmap(bmp, drawingBox.ClientRectangle);
                        bmp.Save(fs, ImageFormat.Bmp);
                        break;
                       
                    case 3:
                        bmp = new Bitmap(drawingBox.ClientSize.Width, drawingBox.ClientSize.Height);
                        drawingBox.DrawToBitmap(bmp, drawingBox.ClientRectangle);
                        bmp.Save(fs, ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }


        }
    }


    //pen settings
    public class PenSettings
    {
        public Pen Pen { get; set; }
        public List<Point> Points { get; set; }

        public PenSettings(Pen pen, List<Point> points)
        {
            Pen = new Pen(pen.Color, pen.Width);
            Points = points;
        }
    }

}
