using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

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
        private List<Point> currentCircle = new List<Point>();
        private List<Point> currentLine = new List<Point>();
        private List<PenSettings> AllcurvesUndo = new List<PenSettings>();
        private List<PenSettings> AllcurvesRedo = new List<PenSettings>();
        private List<PenSettings> Allcurves = new List<PenSettings>();
        // Tools for drawing
        private Pen pen;
        private Bitmap bmp;
        PrintDialog pd;
        PrintDocument doc;
        // Tools for drag and drop images inside the drawingBox
        protected bool validData;
        string path;
        protected Image image;
        protected Thread getImageThread;
        //bool variables for selecting pen,circle,rectangle,line
        private bool penActive = false;
        private bool lineActive = false;
        private bool circleActive = false;
        private bool squareActive = false;

        private int mouseX,mouseY, mouseX1, mouseY1, mouseMoveX, mouseMoveY;
        private bool undoActive;
        private bool timelapse;

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 3);
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new ColorTable());
            warningLbl.Visible = false;
            penWidth.Value = 3;
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
           // fileToolStripMenuItem1.BackColor = Color.Red;
        }

        private void fileToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
          //  fileToolStripMenuItem1.BackColor = Color.Red;
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
            
            if (circleActive )
            {
                mouseX1 = e.X;
                mouseY1 = e.Y;
                PenCircleSettings penSettings = new PenCircleSettings(pen, currentCurve.ToList(), new Shapes(pen, mouseX, mouseY, mouseX1, mouseY1));
                Allcurves.Add(penSettings);
                AllcurvesRedo.Add(penSettings);
                drawingBox.Invalidate();
            }

            if (lineActive )
            {
                mouseX1 = e.X;
                mouseY1 = e.Y; 
                PenLineSettings penSettings = new PenLineSettings(pen, currentCurve.ToList(), new Shapes(pen, mouseX, mouseY, mouseX1, mouseY1));
                Allcurves.Add(penSettings);
                AllcurvesRedo.Add(penSettings);

                drawingBox.Invalidate();

            }
            if (currentCurve.Count > 1)
            {
                PenFreestyleSettings penSettings = new PenFreestyleSettings(pen, currentCurve.ToList(), new Shapes(pen, mouseX, mouseY, mouseX1, mouseY1));
                Allcurves.Add(penSettings);
                AllcurvesRedo.Add(penSettings);
            }

            currentCurve.Clear();
            drawingBox.Invalidate();
        }
    
        private void drawingBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (circleActive && e.Button == MouseButtons.Left ) //circle preview
            {
                
                mouseMoveX = e.X;
                mouseMoveY = e.Y; 
                currentCircle.Add(e.Location);
                drawingBox.Invalidate();
              
            }
            if (lineActive && e.Button == MouseButtons.Left ) //line preview
            {
                mouseMoveX = e.X;
                mouseMoveY = e.Y;
                drawingBox.Invalidate();
            }
            if (e.Button == MouseButtons.Left && penActive)
            {
                currentCurve.Add(e.Location);
                drawingBox.Invalidate();
            }
        }
        private void drawingBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                undoActive = false;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void drawingBox_Paint(object sender, PaintEventArgs e)
        {
            if (timelapse == false)
            {
                foreach (PenSettings penSettigns in Allcurves)
                {
                    if (penSettigns is PenCircleSettings)
                    {
                        PenCircleSettings penCircleSettings = (PenCircleSettings)penSettigns; //pensettings object is type PenCircleSettings (casting)
                        e.Graphics.DrawEllipse(penCircleSettings.Pen, penCircleSettings.Shapes.MouseX, penCircleSettings.Shapes.MouseY, penCircleSettings.Shapes.MouseY1 - penCircleSettings.Shapes.MouseY, penCircleSettings.Shapes.MouseY1 - penCircleSettings.Shapes.MouseY);
                    }
                    else
                    if (penSettigns is PenLineSettings)
                    {
                        PenLineSettings penCircleSettings = (PenLineSettings)penSettigns;
                        e.Graphics.DrawLine(penCircleSettings.Pen, penCircleSettings.Shapes.MouseX, penCircleSettings.Shapes.MouseY, penCircleSettings.Shapes.MouseX1, penCircleSettings.Shapes.MouseY1);
                    }
                    else
                    if (penSettigns is PenFreestyleSettings)
                    {
                        PenFreestyleSettings penFreestyleSettings = (PenFreestyleSettings)penSettigns;
                        if (penFreestyleSettings.Points.Count > 1) e.Graphics.DrawCurve(penFreestyleSettings.Pen, penFreestyleSettings.Points.ToArray());
                    }

                }
            }
            if (circleActive && (!undoActive))  e.Graphics.DrawEllipse(pen, mouseX, mouseY, mouseMoveY - mouseY, mouseMoveY - mouseY);  //circle preview
            if (lineActive && (!undoActive))  e.Graphics.DrawLine(pen, mouseX, mouseY, mouseMoveX, mouseMoveY); //line preview
            if (currentCurve.Count > 1) e.Graphics.DrawCurve(pen, currentCurve.ToArray()); //freestyle "preview"

            //timelapse
            if (timelapse == true)
            {
                foreach (PenSettings penSettigns in Allcurves)
                {
                 
                    if (penSettigns is PenCircleSettings)
                    {
                     //   Thread.Sleep(500);
                        PenCircleSettings penCircleSettings = (PenCircleSettings)penSettigns; //pensettings object is type PenCircleSettings (casting)
    
                        e.Graphics.DrawEllipse(penCircleSettings.Pen, penCircleSettings.Shapes.MouseX, penCircleSettings.Shapes.MouseY, penCircleSettings.Shapes.MouseY1 - penCircleSettings.Shapes.MouseY, penCircleSettings.Shapes.MouseY1 - penCircleSettings.Shapes.MouseY);
                    }
                    else
                    if (penSettigns is PenLineSettings)
                    {
                      //  Thread.Sleep(500);
                        PenLineSettings penCircleSettings = (PenLineSettings)penSettigns;
              
                        e.Graphics.DrawLine(penCircleSettings.Pen, penCircleSettings.Shapes.MouseX, penCircleSettings.Shapes.MouseY, penCircleSettings.Shapes.MouseX1, penCircleSettings.Shapes.MouseY1);
                    }
                    else
                    if (penSettigns is PenFreestyleSettings)
                    {
                     //   Thread.Sleep(500);
                        PenFreestyleSettings penFreestyleSettings = (PenFreestyleSettings)penSettigns;
                     
                        if (penFreestyleSettings.Points.Count > 1) e.Graphics.DrawCurve(penFreestyleSettings.Pen, penFreestyleSettings.Points.ToArray());
                    }
                 
                }
            }
        }
 
        private void penBtn_Click(object sender, EventArgs e)
        {
            penActive = true;
            penBtn.BackColor = Color.Silver;
            lineActive = false;
            squareActive = false;
            circleActive = false;
            lineBtn.BackColor = Color.WhiteSmoke;
            circleBtn.BackColor = Color.WhiteSmoke;
            squareBtn.BackColor = Color.WhiteSmoke;
        }
        private void lineBtn_Click(object sender, EventArgs e)
        {
            lineActive = true;
            lineBtn.BackColor = Color.Silver;
            penActive = false;
            squareActive = false;
            circleActive = false;
            penBtn.BackColor = Color.WhiteSmoke;
            circleBtn.BackColor = Color.WhiteSmoke;
            squareBtn.BackColor = Color.WhiteSmoke;
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            circleActive = true;
            circleBtn.BackColor = Color.Silver;
            lineActive = false;
            penActive = false;
            squareActive = false;
            penBtn.BackColor = Color.WhiteSmoke;
            squareBtn.BackColor = Color.WhiteSmoke;
            lineBtn.BackColor = Color.WhiteSmoke;
        }

        private void sqaureBtn_Click(object sender, EventArgs e)
        {
            squareActive = true;
            squareBtn.BackColor = Color.Silver;
            circleActive = false;
            lineActive = false;
            penActive = false;
            penBtn.BackColor = Color.WhiteSmoke;
            circleBtn.BackColor = Color.WhiteSmoke;
            lineBtn.BackColor = Color.WhiteSmoke;
        }
        //colors selection
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
        private void penWidth_Scroll(object sender, EventArgs e)
        {
            pen.Width = penWidth.Value;
        }

        //menu options
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            clearningSequence(); //cleaning everything before opening a new file so we can avoid memory leaks.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            // saveFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFileDialog1.OpenFile());
                drawingBox.Image = bmp;
                DisplayWarning("Opened file image: " + openFileDialog1.FileName.ToString(), 9000);
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
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
                        DisplayWarning("Saved image succesfully to " + fs.Name.ToString(), 9000);
                        break;

                    case 2:
                        bmp = new Bitmap(drawingBox.ClientSize.Width, drawingBox.ClientSize.Height);
                        drawingBox.DrawToBitmap(bmp, drawingBox.ClientRectangle);
                        bmp.Save(fs, ImageFormat.Bmp);
                        DisplayWarning("Saved image succesfully to " + fs.Name.ToString(), 9000);
                        break;

                    case 3:
                        bmp = new Bitmap(drawingBox.ClientSize.Width, drawingBox.ClientSize.Height);
                        drawingBox.DrawToBitmap(bmp, drawingBox.ClientRectangle);
                        bmp.Save(fs, ImageFormat.Gif);
                        DisplayWarning("Saved image succesfully to " + fs.Name.ToString(), 9000);
                        break;
                }

                fs.Close();
            }

        }

        //printing settings
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show print dialog
            pd = new PrintDialog(); //creating print dialog object
            doc = new PrintDocument(); //creating doc object
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
        
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Print image
            Bitmap bm = new Bitmap(drawingBox.Width, drawingBox.Height);
            drawingBox.DrawToBitmap(bm, new Rectangle(0, 0, drawingBox.Width, drawingBox.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doc = new PrintDocument();
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            pd = new PrintDialog();
            doc.PrintPage += Doc_PrintPage;
            // preview the assigned document
            printPrvDlg.Document = doc;
            printPrvDlg.ShowDialog(); // this shows the preview and then show the Printer Dlg below

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearningSequence();
        }


        //editing settings
        private void undoToolStripMenuItem_Click(object sender, EventArgs e) //pseudoUndo
        {
          if(Allcurves.Count > 0) {
                undoActive = true;
                
                Allcurves.RemoveAt(Allcurves.Count-1);
            drawingBox.Invalidate();
               
            }
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e) //pseudoRedo
        {

            Allcurves.AddRange(AllcurvesRedo);
            drawingBox.Invalidate();
           
           
        }
        private void clearningSequence()
        {
            if (drawingBox.Image != null)
            {
                drawingBox.Image.Dispose();
                drawingBox.Image = null;
            }
            Allcurves.Clear();
            AllcurvesRedo.Clear();
            circleActive = false;
            lineActive = false;
            penActive = false;
            squareActive = false;
            penBtn.BackColor = Color.WhiteSmoke;
            circleBtn.BackColor = Color.WhiteSmoke;
            squareBtn.BackColor = Color.WhiteSmoke;
            lineBtn.BackColor = Color.WhiteSmoke;
            drawingBox.Invalidate();
        }

        //tools settings
        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            creatingTimelapse();
        }

        private void creatingTimelapse()
        {
            timelapse = true;
            drawingBox.Invalidate();
        }

        //drag and drop images onto the drawingBox
        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                drawingBox.Image = image;
            }
        }

  

        protected void LoadImage()

        {
            image = new Bitmap(path);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            string filename;
            validData = GetFilename(out filename, e);
            if (validData)
            {
                path = filename;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

       

        //copying the image(Ctrl+C) from the drawingBox to clipboard
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(drawingBox.ClientSize.Width, drawingBox.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            drawingBox.DrawToBitmap(bmp, drawingBox.ClientRectangle);
            Clipboard.SetDataObject(bmp);
            DisplayWarning("Copied to clipboard!", 4000);

        }

        //pasting the image(Ctrl+C) from the clipboard to the drawingBox
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage()) //if clipboard contains an image 
            {
                drawingBox.Image = Clipboard.GetImage();
            }

            DisplayWarning("Pasted image from the clipboard!", 4000);

        }

        //method for displaying warning messages for the specified seconds
        private void DisplayWarning(String message, int Interval)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = Interval; //sets timer Interval
            warningLbl.Invoke(new Action(() => warningLbl.Text = message));
            warningLbl.Invoke(new Action(() => warningLbl.Visible = true));

            timer.Elapsed += (s, en) => { //calls Elapsed event for the timer
                warningLbl.Invoke(new Action(() => warningLbl.Visible = false));
            };
            timer.Enabled = true; // Starts the timer. 
        }


    }

    public class Shapes
    {
        public Pen Pen { get; set; }
       public  int MouseX { get; set; }
        public  int MouseY { get; set; }
        public int MouseX1{ get; set; }
        public int MouseY1 { get; set; }

       public Shapes(Pen pen, int mouseX, int mouseY, int mouseX1, int mouseY1)
        {
             Pen = new Pen(pen.Color, pen.Width);
             MouseX =  mouseX;
             MouseY = mouseY;
             MouseX1 = mouseX1;
             MouseY1 = mouseY1;
           
        }
    }
    //pen settings
    public class PenSettings
    {
        public Pen Pen { get; set; }
        public List<Point> Points { get; set; }

        public Shapes Shapes { get; set; }
        public PenSettings(Pen pen, List<Point> points, Shapes shape)
        {
            Pen = new Pen(pen.Color, pen.Width);
            Points = points;
            Shapes = new Shapes(Pen, shape.MouseX, shape.MouseY, shape.MouseX1, shape.MouseY1);
        }

    }

    public class PenCircleSettings : PenSettings {
        public PenCircleSettings(Pen pen, List<Point> points, Shapes shape):base(pen,points,shape)
        {

        }
    }

    public class PenLineSettings : PenSettings
    {
        public PenLineSettings(Pen pen, List<Point> points, Shapes shape) : base(pen, points, shape)
        {

        }
    }
    public class PenFreestyleSettings : PenSettings
    {
        public PenFreestyleSettings(Pen pen, List<Point> points, Shapes shape) : base(pen, points, shape)
        {

        }
    }

    //custom Menu strip color
    public class ColorTable : ProfessionalColorTable
    {
        Color color = Color.FromArgb(63, 63, 65);

        public override Color MenuItemSelected
        {
            get { return Color.Gray; }
        }

        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Color.Transparent; }
        }
     

        public override Color MenuItemBorder
        {
            get { return color; }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return color; }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return color; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return color; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return color; }
        }

    }


}
