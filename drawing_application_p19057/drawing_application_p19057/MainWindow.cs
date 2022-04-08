using drawing_application.Core;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace drawing_application
{
    public partial class MainWindow : Form
    {
        #region Variables definition
        //for moving(Drag) the application around
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //variables for SQL
        String connectionString = "Data Source=ShapeDB.db;Version=3;";
        SQLiteConnection conn;
        DataEntry newDataEntry;
        // List of user's points he creates
        private List<Point> currentCurve = new List<Point>();
        private List<Shapes> AllcurvesRedoTheUndo = new List<Shapes>();
        public static List<Shapes> Allcurves = new List<Shapes>();
        // Tools for drawing
        Pen pen;
        private Bitmap bmp;
        PrintDialog pd;
        PrintDocument doc;
        Color colorSelected = Color.Black;
        String timelapseName;
        // Tools for drag and drop images inside the drawingBox
        protected bool validData;
        string path;
        protected Image image;
        protected Thread getImageThread;
        //bool variables for selecting pen,circle,rectangle,line, ellipse etc
        private bool penActive;
        private bool lineActive = false;
        private bool circleActive = false;
        private bool squareActive = false;
        private bool ellipseActive = false;
        private bool eraserActive = false;
        public int mouseDownX, mouseDownY, mouseUpX, mouseUpY, mouseMoveX, mouseMoveY;
        private bool undoActive;
        private bool mouseDown = false;
        int rectX, rectY, rectWidth, rectHeight;
        #endregion

        #region MainWindow constructor
        public MainWindow()
        {
            InitializeComponent();
            this.MinimumSize = new Size(993, 773);
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new ColorTable());
            warningLbl.Visible = false;
            penWidthControl.Value = 1;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.FormBorderStyle = FormBorderStyle.None;
            aboutControl.Hide();
            penActive = true;
            pen = new Pen(colorSelected, penWidthControl.Value);
            penBtn.BackColor = Color.Silver;
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
            dragDropLabel.Hide();
        }
        #endregion

        #region general settings
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                maximizeBtn.BackgroundImage = Properties.Resources.maximize_button_24px;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                maximizeBtn.BackgroundImage = Properties.Resources.restore_down;
                this.WindowState = FormWindowState.Maximized;
            }
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
            if (this.WindowState == FormWindowState.Maximized) { maximizeBtn.BackgroundImage = Properties.Resources.maximize_button_24px; this.WindowState = FormWindowState.Normal; } else { maximizeBtn.BackgroundImage = Properties.Resources.restore_down; this.WindowState = FormWindowState.Maximized; }
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
        private void penBtn_MouseHover(object sender, EventArgs e)
        {
            penTip.SetToolTip(penBtn, "Pen");
        }
        private void eraserBtn_MouseHover(object sender, EventArgs e)
        {
            eraserTip.SetToolTip(eraserBtn, "Eraser");
        }

        private void lineBtn_MouseHover(object sender, EventArgs e)
        {
            lineTip.SetToolTip(lineBtn, "Line");
        }

        private void ellipseBtn_MouseHover(object sender, EventArgs e)
        {
            ellipseTip.SetToolTip(ellipseBtn, "Ellipse");
        }

        private void circleBtn_MouseHover(object sender, EventArgs e)
        {
            circleTip.SetToolTip(circleBtn, "Circle");
        }

        private void squareBtn_MouseHover(object sender, EventArgs e)
        {
            squareTip.SetToolTip(squareBtn, "Square");
        }

        private void penWidth_MouseHover(object sender, EventArgs e)
        {
            penSizeTip.SetToolTip(penWidthControl, "Select a pen size");
        }
        #endregion

        #region drawing settings
        private void drawingBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpX = e.X;
            mouseUpY = e.Y;
            if (ellipseActive)
            {
                Ellipse ellipse = new Ellipse(new PenOptions(colorSelected, penWidthControl.Value), currentCurve.ToList(), new Coordinates(mouseDownX, mouseDownY, mouseUpX, mouseUpY));
                Allcurves.Add(ellipse);
                drawingBox.Invalidate();
                mouseDown = false;
                InsertingData("ellipse");
            }

            if (circleActive)
            {
                Circle circle = new Circle(new PenOptions(colorSelected, penWidthControl.Value), currentCurve.ToList(), new Coordinates(mouseDownX, mouseDownY, mouseUpX, mouseUpY));
                Allcurves.Add(circle);
                drawingBox.Invalidate();
                mouseDown = false;
                InsertingData("circle");
            }
            if (squareActive)
            {
                rectX = Math.Min(mouseDownX, mouseUpX); //min between start X-value and current X value
                rectY = Math.Min(mouseDownY, mouseUpY);
                rectWidth = Math.Abs(mouseDownX - mouseUpX); // the width value should be the maximum between the start X- position and the current X position
                rectHeight = Math.Abs(mouseDownY - mouseUpY);
                Square square = new Square(new PenOptions(colorSelected, penWidthControl.Value), currentCurve.ToList(), new Coordinates(rectX, rectY, rectWidth, rectHeight));
                Allcurves.Add(square);
                drawingBox.Invalidate();
                mouseDown = false;
                InsertingData("square");
            }
            if (lineActive)
            {
                Line line = new Line(new PenOptions(colorSelected, penWidthControl.Value), currentCurve.ToList(), new Coordinates(mouseDownX, mouseDownY, mouseUpX, mouseUpY));
                Allcurves.Add(line);
                drawingBox.Invalidate();
                mouseDown = false;
                InsertingData("line");

            }
            if (currentCurve.Count > 1)
            {
                Freestyle freestyle = new Freestyle(new PenOptions(colorSelected, penWidthControl.Value), currentCurve.ToList(), new Coordinates(mouseDownX, mouseDownY, mouseUpX, mouseUpY));
                Allcurves.Add(freestyle);
                drawingBox.Invalidate();
                currentCurve.Clear();
                InsertingData("freestyle");

            }
        }

        private void drawingBox_MouseMove(object sender, MouseEventArgs e)
        {
            positionX.Text = e.X.ToString();
            positionY.Text = e.Y.ToString();

            if (squareActive && e.Button == MouseButtons.Left)
            {
                mouseMoveX = e.X;
                mouseMoveY = e.Y;
                rectX = Math.Min(mouseDownX, mouseMoveX); // min between start X- value and current X value
                rectY = Math.Min(mouseDownY, mouseMoveY);
                rectWidth = Math.Abs(mouseDownX - mouseMoveX); // the width value should be the maximum between the start X- position and the current X position
                rectHeight = Math.Abs(mouseDownY - mouseMoveY);

                drawingBox.Invalidate();
            }
            if (ellipseActive && e.Button == MouseButtons.Left) //ellipse preview
            {
                mouseMoveX = e.X;
                mouseMoveY = e.Y;
                drawingBox.Invalidate();
            }
            if (circleActive && e.Button == MouseButtons.Left) //circle preview
            {
                mouseMoveX = e.X;
                mouseMoveY = e.Y;
                drawingBox.Invalidate();

            }
            if (lineActive && e.Button == MouseButtons.Left) //line preview
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
            AllcurvesRedoTheUndo.Clear();
            mouseDown = true;
            undoActive = false;
            mouseDownX = e.X;
            mouseDownY = e.Y;
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;

        }

        private void drawingBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shapes shape in Allcurves)
            {
                if (shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //smoothing the lines
                    e.Graphics.DrawEllipse(new Pen(circle.PenOptions.PenColor, circle.PenOptions.PenWidth), circle.Coordinates.MouseDownX, circle.Coordinates.MouseDownY, circle.Coordinates.MouseUpY - circle.Coordinates.MouseDownY, circle.Coordinates.MouseUpY - circle.Coordinates.MouseDownY);
                }
                else
                if (shape is Line)
                {
                    Line line = (Line)shape;
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //smoothing the lines
                    e.Graphics.DrawLine(new Pen(line.PenOptions.PenColor, line.PenOptions.PenWidth), line.Coordinates.MouseDownX, line.Coordinates.MouseDownY, line.Coordinates.MouseUpX, line.Coordinates.MouseUpY);
                }
                else
                if (shape is Freestyle)
                {
                    Freestyle freestyle = (Freestyle)shape;
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //smoothing the lines
                    if (freestyle.Points.Count > 1) e.Graphics.DrawCurve(new Pen(freestyle.PenOptions.PenColor, freestyle.PenOptions.PenWidth), freestyle.Points.ToArray(), 0.0f);
                }
                else
                if (shape is Square)
                {
                    Square square = (Square)shape;
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //smoothing the lines
                    e.Graphics.DrawRectangle(new Pen(square.PenOptions.PenColor, square.PenOptions.PenWidth), square.Coordinates.MouseDownX, square.Coordinates.MouseDownY, square.Coordinates.MouseUpX, square.Coordinates.MouseUpY);
                }
                else
                if (shape is Ellipse)
                {
                    Ellipse ellipse = (Ellipse)shape;
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //smoothing the lines
                    e.Graphics.DrawEllipse(new Pen(ellipse.PenOptions.PenColor, ellipse.PenOptions.PenWidth), ellipse.Coordinates.MouseDownX, ellipse.Coordinates.MouseDownY, ellipse.Coordinates.MouseUpX - ellipse.Coordinates.MouseDownX, ellipse.Coordinates.MouseUpY - ellipse.Coordinates.MouseDownY);
                }

            }

            if (squareActive && (!undoActive) && mouseDown) { e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; e.Graphics.DrawRectangle(pen, rectX, rectY, rectWidth, rectHeight); }// square preview
            if (ellipseActive && (!undoActive) && mouseDown) { e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; e.Graphics.DrawEllipse(pen, mouseDownX, mouseDownY, mouseMoveX - mouseDownX, mouseMoveY - mouseDownY); }//ellipse preview
            if (circleActive && (!undoActive) && mouseDown) { e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; e.Graphics.DrawEllipse(pen, mouseDownX, mouseDownY, mouseMoveY - mouseDownY, mouseMoveY - mouseDownY); }  //circle preview
            if (lineActive && (!undoActive) && mouseDown) { e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; e.Graphics.DrawLine(pen, mouseDownX, mouseDownY, mouseMoveX, mouseMoveY); } //line preview
            if (currentCurve.Count > 1) { pen.DashCap = System.Drawing.Drawing2D.DashCap.Round; e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; e.Graphics.DrawCurve(pen, currentCurve.ToArray(), 0.0f); } //freestyle "preview"


        }
        private void eraserBtn_Click(object sender, EventArgs e)
        {
            colorSelected = Color.White;
            pen = new Pen(colorSelected, penWidthControl.Value);
            eraserActive = true;
            eraserBtn.BackColor = Color.Silver;
            lineActive = false;
            squareActive = false;
            circleActive = false;
            ellipseActive = false;
            penActive = true;
            penBtn.BackColor = Color.WhiteSmoke;
            lineBtn.BackColor = Color.WhiteSmoke;
            circleBtn.BackColor = Color.WhiteSmoke;
            squareBtn.BackColor = Color.WhiteSmoke;
            ellipseBtn.BackColor = Color.WhiteSmoke;
        }
        private void penBtn_Click(object sender, EventArgs e)
        {
            penActive = true;
            pen = new Pen(colorSelected, penWidthControl.Value);
            penBtn.BackColor = Color.Silver;
            lineActive = false;
            squareActive = false;
            circleActive = false;
            lineBtn.BackColor = Color.WhiteSmoke;
            circleBtn.BackColor = Color.WhiteSmoke;
            squareBtn.BackColor = Color.WhiteSmoke;
            ellipseBtn.BackColor = Color.WhiteSmoke;
            ellipseActive = false;
            eraserBtn.BackColor = Color.WhiteSmoke;
            eraserActive = false;
        }
        private void lineBtn_Click(object sender, EventArgs e)
        {
            pen = new Pen(colorSelected, penWidthControl.Value);
            lineActive = true;
            lineBtn.BackColor = Color.Silver;
            penActive = false;
            squareActive = false;
            circleActive = false;
            penBtn.BackColor = Color.WhiteSmoke;
            circleBtn.BackColor = Color.WhiteSmoke;
            squareBtn.BackColor = Color.WhiteSmoke;
            ellipseBtn.BackColor = Color.WhiteSmoke;
            ellipseActive = false;
            eraserBtn.BackColor = Color.WhiteSmoke;
            eraserActive = false;
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            pen = new Pen(colorSelected, penWidthControl.Value);
            circleActive = true;
            circleBtn.BackColor = Color.Silver;
            lineActive = false;
            penActive = false;
            squareActive = false;
            penBtn.BackColor = Color.WhiteSmoke;
            squareBtn.BackColor = Color.WhiteSmoke;
            lineBtn.BackColor = Color.WhiteSmoke;
            ellipseBtn.BackColor = Color.WhiteSmoke;
            ellipseActive = false;
            eraserBtn.BackColor = Color.WhiteSmoke;
            eraserActive = false;
        }

        private void sqaureBtn_Click(object sender, EventArgs e)
        {
            pen = new Pen(colorSelected, penWidthControl.Value);
            squareActive = true;
            squareBtn.BackColor = Color.Silver;
            circleActive = false;
            lineActive = false;
            penActive = false;
            penBtn.BackColor = Color.WhiteSmoke;
            circleBtn.BackColor = Color.WhiteSmoke;
            lineBtn.BackColor = Color.WhiteSmoke;
            ellipseBtn.BackColor = Color.WhiteSmoke;
            ellipseActive = false;
            eraserBtn.BackColor = Color.WhiteSmoke;
            eraserActive = false;
        }
        private void ellipseBtn_Click(object sender, EventArgs e)
        {
            ellipseActive = true;
            squareActive = false;
            ellipseBtn.BackColor = Color.Silver;
            circleActive = false;
            lineActive = false;
            penActive = false;
            squareActive = false;
            penBtn.BackColor = Color.WhiteSmoke;
            circleBtn.BackColor = Color.WhiteSmoke;
            lineBtn.BackColor = Color.WhiteSmoke;
            squareBtn.BackColor = Color.WhiteSmoke;
            eraserBtn.BackColor = Color.WhiteSmoke;
            eraserActive = false;
        }
        #endregion

        #region colors and pen size selection 
        private void moreColors_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (eraserActive == false) colorSelected = colorDialog1.Color; pen = new Pen(colorSelected, penWidthControl.Value);
            }
        }

        private void redBox_Click(object sender, EventArgs e)
        {
            if (eraserActive == false)
            {
                colorSelected = Color.Red;
                pen = new Pen(colorSelected, penWidthControl.Value);
            }

        }

        private void blueBox_Click(object sender, EventArgs e)
        {
            if (eraserActive == false)
            {
                colorSelected = Color.Blue;
                pen = new Pen(colorSelected, penWidthControl.Value);

            }

        }

        private void yellowBox_Click(object sender, EventArgs e)
        {
            if (eraserActive == false)
            {
                colorSelected = Color.Yellow;
                pen = new Pen(colorSelected, penWidthControl.Value);
            }
        }

        private void greenBox_Click(object sender, EventArgs e)
        {
            if (eraserActive == false)
            {
                colorSelected = Color.Green;
                pen = new Pen(colorSelected, penWidthControl.Value);

            }
        }
        private void blackBox_Click(object sender, EventArgs e)
        {
            if (eraserActive == false)
            {
                colorSelected = Color.Black;
                pen = new Pen(colorSelected, penWidthControl.Value);

            }
        }
        private void penWidth_Scroll(object sender, EventArgs e)
        {

            if (eraserActive == false)
            {
                pen.Width = penWidthControl.Value;
                pen = new Pen(colorSelected, penWidthControl.Value);
            }
            else
            {
                pen.Width = penWidthControl.Value;
                pen = new Pen(Color.White, penWidthControl.Value);
            }

        }
        #endregion

        #region menu options
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            openFileDialog1.Title = "Open an Image File";

            // saveFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFileDialog1.OpenFile());
                clearningSequence(); //cleaning everything before opening a new file so we can avoid memory leaks.
                drawingBox.Image = bmp;
                DisplayWarning("Opened file image: " + openFileDialog1.FileName.ToString(), 9000);
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image they drawed
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
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
                    case 4:
                        bmp = new Bitmap(drawingBox.ClientSize.Width, drawingBox.ClientSize.Height);
                        drawingBox.DrawToBitmap(bmp, drawingBox.ClientRectangle);
                        bmp.Save(fs, ImageFormat.Png);
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

        //about control appears
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutControl.Show();

        }

        //tools settings
        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            creatingLiveTimelapse();

        }

        #endregion

        #region editing settings
        private void undoToolStripMenuItem_Click(object sender, EventArgs e) //pseudoUndo
        {
            if (Allcurves.Count > 0)
            {
                redoToolStripMenuItem.Enabled = true;
                undoActive = true;
                AllcurvesRedoTheUndo.AddRange(Allcurves);
                Allcurves.RemoveAt(Allcurves.Count - 1);
                drawingBox.Invalidate();

            }
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e) //pseudoRedo
        {
            Allcurves.AddRange(AllcurvesRedoTheUndo);
            drawingBox.Invalidate();
        }
        private void clearningSequence()
        {
            if (drawingBox.Image != null)
            {
                drawingBox.Image.Dispose();
                drawingBox.Image = null;
            }
            drawings.Clear();
            AllcurvesRedoTheUndo.Clear();
            colorSelected = Color.Black;
            pen = new Pen(colorSelected, pen.Width);
            Allcurves.Clear();
            circleActive = false;
            lineActive = false;
            penBtn.BackColor = Color.Silver;
            penActive = true;
            squareActive = false;
            eraserActive = false;
            ellipseActive = false;
            ellipseBtn.BackColor = Color.WhiteSmoke;
            eraserBtn.BackColor = Color.WhiteSmoke;
            circleBtn.BackColor = Color.WhiteSmoke;
            squareBtn.BackColor = Color.WhiteSmoke;
            lineBtn.BackColor = Color.WhiteSmoke;
            drawingBox.Invalidate();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
        }


        #endregion

        #region drag and drop images into the drawingBox
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
            drawingBox.BackColor = Color.White;
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                dragDropLabel.Hide();
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
                dragDropLabel.Show();
                dragDropLabel.BackColor = Color.FromArgb(25, Color.Black);
                drawingBox.BackColor = Color.FromArgb(25, Color.Black);
                path = filename;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }



        private void Form1_DragLeave(object sender, EventArgs e)
        {
            drawingBox.BackColor = Color.White;
            dragDropLabel.Hide();

        }
        #endregion

        #region data entry
        //data entry for sqlite db
        public void InsertingData(String shape)
        {
            conn.Open();
            newDataEntry = new DataEntry(shape);
            String insertQuery = "Insert into Shapes(name,Time) values('" + newDataEntry.Name + "','" + newDataEntry.timeStamp + "')";
            SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        #region clipboard settings
        //copying the image(Ctrl+C) from the drawingBox to clipboard
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(drawingBox.ClientSize.Width, drawingBox.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            drawingBox.DrawToBitmap(bmp, drawingBox.ClientRectangle);
            Clipboard.SetDataObject(bmp);
            DisplayWarning("Copied to clipboard!", 4000);

        }

        //pasting the image(Ctrl+V) from the clipboard to the drawingBox
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

            timer.Elapsed += (s, en) =>
            { //calls Elapsed event for the timer
                warningLbl.Invoke(new Action(() => warningLbl.Visible = false));
            };
            timer.Enabled = true; // Starts the timer. 
        }
        #endregion

        #region borderless window settings
        //resizeable border-less window settings
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }
        //resizeable border-less window settings
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }
        #endregion

        #region timelapse settings

        //save as timelapse file
        private void saveAsTimelapseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Displays a SaveFileDialog so the user can save the Image they drawed
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Timelapse file|*.timelapse";
            saveFileDialog1.Title = "Save as a Timelapse File";
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
                        timelapseName = saveFileDialog1.FileName;
                        timelapse = new Timelapse(timelapseName, Allcurves, 2, new Coordinates(mouseDownX, mouseDownY, mouseUpX, mouseUpY));
                        drawings.Add(timelapse);
                        fs.Close();
                        Serialize.SerializeTimelapseSettings(drawings, timelapseName);
                        DisplayWarning("Saved image succesfully to " + fs.Name.ToString(), 9000);
                        break;
                }

            }
        }
        //open a timelapse file
        private void openAsTimelapseToolStripMenuItem_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Timelapse file|*.timelapse";
            openFileDialog1.Title = "Save as a Timelapse File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.OpenFile();
                clearningSequence(); //cleaning everything before opening a new file so we can avoid memory leaks.
                timelapseName = openFileDialog1.FileName;
                drawings.Clear();
                drawings = Serialize.DeserializeTimelapseSettings(timelapseName);


                timelapse = new Timelapse(drawings[0].Name, drawings[0].AllcurvesTimelapse, drawings[0].SecondsAnimation, new Coordinates(drawings[0].Coordinates.MouseDownX, drawings[0].Coordinates.MouseDownY, drawings[0].Coordinates.MouseUpX, drawings[0].Coordinates.MouseUpY));
                timelapse.timerStarter(); //timer starts
                DisplayWarning("Opened file image: " + openFileDialog1.FileName.ToString(), 9000);
            }
        }
        //house add button
        private void houseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutingHouseTimelapse();
        }
        //grass add button
        private void grassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutingGrassTimelapse();
        }
        //trees add button
        private void treesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutingTreesTimelapse();
        }
        //sky add button
        private void skyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutingSkyTimelapse();
        }
        //  List<TimelapseSettings> autoCurves = new List<TimelapseSettings>();
        Timelapse timelapse;
        private void creatingLiveTimelapse()
        {
            timelapse = new Timelapse("Live", Allcurves, 2, new Coordinates(mouseDownX, mouseDownY, mouseUpX, mouseUpY));
            clearningSequence();
            timelapse.timerStarter(); //timer starts
        }

        List<Timelapse> drawings = new List<Timelapse>();


        private void ExecutingHouseTimelapse()
        {
            string name = "House.timelapse";
            drawings = Serialize.DeserializeTimelapseSettings(name);
            timelapse = new Timelapse(name, drawings[0].AllcurvesTimelapse, drawings[0].SecondsAnimation, new Coordinates(drawings[0].Coordinates.MouseDownX, drawings[0].Coordinates.MouseDownY, drawings[0].Coordinates.MouseUpX, drawings[0].Coordinates.MouseUpY));
            timelapse.timerStarter(); //timer starts
        }
        private void ExecutingGrassTimelapse()
        {
            string name = "Grass.timelapse";
            drawings = Serialize.DeserializeTimelapseSettings(name);
            timelapse = new Timelapse(name, drawings[0].AllcurvesTimelapse, drawings[0].SecondsAnimation, new Coordinates(drawings[0].Coordinates.MouseDownX, drawings[0].Coordinates.MouseDownY, drawings[0].Coordinates.MouseUpX, drawings[0].Coordinates.MouseUpY));
            timelapse.timerStarter(); //timer starts
            Console.WriteLine("Drew timelapse");
        }
        private void ExecutingTreesTimelapse()
        {
            string name = "Trees.timelapse";
            drawings = Serialize.DeserializeTimelapseSettings(name);
            timelapse = new Timelapse(name, drawings[0].AllcurvesTimelapse, drawings[0].SecondsAnimation, new Coordinates(drawings[0].Coordinates.MouseDownX, drawings[0].Coordinates.MouseDownY, drawings[0].Coordinates.MouseUpX, drawings[0].Coordinates.MouseUpY));
            timelapse.timerStarter(); //timer starts
            Console.WriteLine("Drew timelapse");
        }
        private void ExecutingSkyTimelapse()
        {
            string name = "Sky.timelapse";
            drawings = Serialize.DeserializeTimelapseSettings(name);
            timelapse = new Timelapse(name, drawings[0].AllcurvesTimelapse, drawings[0].SecondsAnimation, new Coordinates(drawings[0].Coordinates.MouseDownX, drawings[0].Coordinates.MouseDownY, drawings[0].Coordinates.MouseUpX, drawings[0].Coordinates.MouseUpY));
            timelapse.timerStarter(); //timer starts
            Console.WriteLine("Drew timelapse");
        }
        #endregion

        #region custom menu strip color
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
        #endregion

    }
}
