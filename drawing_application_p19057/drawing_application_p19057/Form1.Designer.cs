
namespace drawing_application_p19057
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.warningLbl = new System.Windows.Forms.Label();
            this.iconPaint = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.Button();
            this.maximizeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.positionY = new System.Windows.Forms.Label();
            this.positionX = new System.Windows.Forms.Label();
            this.eraserBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.penWidth = new System.Windows.Forms.TrackBar();
            this.moreColors = new System.Windows.Forms.PictureBox();
            this.greenBox = new System.Windows.Forms.PictureBox();
            this.yellowBox = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.circleBtn = new System.Windows.Forms.Button();
            this.squareBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.penBtn = new System.Windows.Forms.Button();
            this.stripPanel = new System.Windows.Forms.Panel();
            this.stripPanel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.moreColorsTp = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.drawingBox = new System.Windows.Forms.PictureBox();
            this.aboutControl = new drawing_application_p19057.AboutControl();
            this.penTip = new System.Windows.Forms.ToolTip(this.components);
            this.eraserTip = new System.Windows.Forms.ToolTip(this.components);
            this.lineTip = new System.Windows.Forms.ToolTip(this.components);
            this.ellipseTip = new System.Windows.Forms.ToolTip(this.components);
            this.circleTip = new System.Windows.Forms.ToolTip(this.components);
            this.squareTip = new System.Windows.Forms.ToolTip(this.components);
            this.penSizeTip = new System.Windows.Forms.ToolTip(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPaint)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moreColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.warningLbl);
            this.topPanel.Controls.Add(this.iconPaint);
            this.topPanel.Controls.Add(this.menuStrip1);
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.Controls.Add(this.maximizeBtn);
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(5, 5);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(993, 27);
            this.topPanel.TabIndex = 1;
            this.topPanel.DoubleClick += new System.EventHandler(this.topPanel_DoubleClick);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // warningLbl
            // 
            this.warningLbl.AutoSize = true;
            this.warningLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLbl.ForeColor = System.Drawing.Color.White;
            this.warningLbl.Location = new System.Drawing.Point(311, 7);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(49, 16);
            this.warningLbl.TabIndex = 10;
            this.warningLbl.Text = "label1";
            // 
            // iconPaint
            // 
            this.iconPaint.BackColor = System.Drawing.Color.Transparent;
            this.iconPaint.BackgroundImage = global::drawing_application_p19057.Properties.Resources.icons8_paint_64;
            this.iconPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPaint.Location = new System.Drawing.Point(9, 3);
            this.iconPaint.Name = "iconPaint";
            this.iconPaint.Size = new System.Drawing.Size(33, 21);
            this.iconPaint.TabIndex = 9;
            this.iconPaint.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(48, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(187, 25);
            this.menuStrip1.TabIndex = 3;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.toolStripSeparator,
            this.saveToolStripMenuItem1,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
            this.openToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(162, 6);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.saveToolStripMenuItem1.Text = "&Save As";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.optionsToolStripMenuItem1.Text = "Create a timelapse";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contentsToolStripMenuItem.Text = "Version 1.0";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(137, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.exitBtn.BackgroundImage = global::drawing_application_p19057.Properties.Resources.x_24px;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(952, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 21);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.maximizeBtn.BackgroundImage = global::drawing_application_p19057.Properties.Resources.maximize_button_16px;
            this.maximizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maximizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.maximizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.maximizeBtn.Location = new System.Drawing.Point(917, 3);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(29, 18);
            this.maximizeBtn.TabIndex = 1;
            this.maximizeBtn.UseVisualStyleBackColor = false;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.minimizeBtn.BackgroundImage = global::drawing_application_p19057.Properties.Resources.minus_20px;
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeBtn.Location = new System.Drawing.Point(882, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(29, 21);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Controls.Add(this.positionY);
            this.menuPanel.Controls.Add(this.positionX);
            this.menuPanel.Controls.Add(this.eraserBtn);
            this.menuPanel.Controls.Add(this.ellipseBtn);
            this.menuPanel.Controls.Add(this.penWidth);
            this.menuPanel.Controls.Add(this.moreColors);
            this.menuPanel.Controls.Add(this.greenBox);
            this.menuPanel.Controls.Add(this.yellowBox);
            this.menuPanel.Controls.Add(this.blueBox);
            this.menuPanel.Controls.Add(this.redBox);
            this.menuPanel.Controls.Add(this.circleBtn);
            this.menuPanel.Controls.Add(this.squareBtn);
            this.menuPanel.Controls.Add(this.lineBtn);
            this.menuPanel.Controls.Add(this.penBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(5, 32);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(51, 746);
            this.menuPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 709);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Y:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "X:";
            // 
            // positionY
            // 
            this.positionY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.positionY.AutoSize = true;
            this.positionY.BackColor = System.Drawing.Color.Transparent;
            this.positionY.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionY.ForeColor = System.Drawing.Color.White;
            this.positionY.Location = new System.Drawing.Point(15, 709);
            this.positionY.Name = "positionY";
            this.positionY.Size = new System.Drawing.Size(36, 16);
            this.positionY.TabIndex = 14;
            this.positionY.Text = "posY";
            // 
            // positionX
            // 
            this.positionX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.positionX.AutoSize = true;
            this.positionX.BackColor = System.Drawing.Color.Transparent;
            this.positionX.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionX.ForeColor = System.Drawing.Color.White;
            this.positionX.Location = new System.Drawing.Point(15, 677);
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(36, 16);
            this.positionX.TabIndex = 13;
            this.positionX.Text = "posX";
            // 
            // eraserBtn
            // 
            this.eraserBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eraserBtn.BackgroundImage = global::drawing_application_p19057.Properties.Resources.icons8_eraser_64;
            this.eraserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraserBtn.FlatAppearance.BorderSize = 0;
            this.eraserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.eraserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.eraserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.eraserBtn.Location = new System.Drawing.Point(3, 45);
            this.eraserBtn.Name = "eraserBtn";
            this.eraserBtn.Size = new System.Drawing.Size(42, 33);
            this.eraserBtn.TabIndex = 12;
            this.eraserBtn.UseVisualStyleBackColor = false;
            this.eraserBtn.Click += new System.EventHandler(this.eraserBtn_Click);
            this.eraserBtn.MouseHover += new System.EventHandler(this.eraserBtn_MouseHover);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ellipseBtn.BackgroundImage = global::drawing_application_p19057.Properties.Resources.ellipse_24px;
            this.ellipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ellipseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipseBtn.FlatAppearance.BorderSize = 0;
            this.ellipseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ellipseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ellipseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ellipseBtn.Location = new System.Drawing.Point(3, 129);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(42, 33);
            this.ellipseBtn.TabIndex = 11;
            this.ellipseBtn.UseVisualStyleBackColor = false;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            this.ellipseBtn.MouseHover += new System.EventHandler(this.ellipseBtn_MouseHover);
            // 
            // penWidth
            // 
            this.penWidth.Location = new System.Drawing.Point(9, 246);
            this.penWidth.Maximum = 20;
            this.penWidth.Minimum = 1;
            this.penWidth.Name = "penWidth";
            this.penWidth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.penWidth.Size = new System.Drawing.Size(45, 185);
            this.penWidth.TabIndex = 10;
            this.penWidth.Value = 1;
            this.penWidth.Scroll += new System.EventHandler(this.penWidth_Scroll);
            this.penWidth.MouseHover += new System.EventHandler(this.penWidth_MouseHover);
            // 
            // moreColors
            // 
            this.moreColors.BackColor = System.Drawing.Color.Transparent;
            this.moreColors.BackgroundImage = global::drawing_application_p19057.Properties.Resources.menu_vertical_48px;
            this.moreColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moreColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moreColors.Location = new System.Drawing.Point(9, 576);
            this.moreColors.Name = "moreColors";
            this.moreColors.Size = new System.Drawing.Size(33, 40);
            this.moreColors.TabIndex = 9;
            this.moreColors.TabStop = false;
            this.moreColors.Click += new System.EventHandler(this.moreColors_Click);
            this.moreColors.MouseEnter += new System.EventHandler(this.moreColors_MouseEnter);
            this.moreColors.MouseLeave += new System.EventHandler(this.moreColors_MouseLeave);
            this.moreColors.MouseHover += new System.EventHandler(this.moreColors_MouseHover);
            // 
            // greenBox
            // 
            this.greenBox.BackColor = System.Drawing.Color.Green;
            this.greenBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenBox.Location = new System.Drawing.Point(9, 544);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(33, 30);
            this.greenBox.TabIndex = 8;
            this.greenBox.TabStop = false;
            this.greenBox.Click += new System.EventHandler(this.greenBox_Click);
            // 
            // yellowBox
            // 
            this.yellowBox.BackColor = System.Drawing.Color.Yellow;
            this.yellowBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellowBox.Location = new System.Drawing.Point(9, 508);
            this.yellowBox.Name = "yellowBox";
            this.yellowBox.Size = new System.Drawing.Size(33, 30);
            this.yellowBox.TabIndex = 7;
            this.yellowBox.TabStop = false;
            this.yellowBox.Click += new System.EventHandler(this.yellowBox_Click);
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.Color.Blue;
            this.blueBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueBox.Location = new System.Drawing.Point(9, 473);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(33, 30);
            this.blueBox.TabIndex = 6;
            this.blueBox.TabStop = false;
            this.blueBox.Click += new System.EventHandler(this.blueBox_Click);
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Red;
            this.redBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redBox.Location = new System.Drawing.Point(9, 437);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(33, 30);
            this.redBox.TabIndex = 5;
            this.redBox.TabStop = false;
            this.redBox.Click += new System.EventHandler(this.redBox_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.circleBtn.BackgroundImage = global::drawing_application_p19057.Properties.Resources.circle_50px;
            this.circleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleBtn.FlatAppearance.BorderSize = 0;
            this.circleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.circleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.circleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.circleBtn.Location = new System.Drawing.Point(3, 168);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(42, 33);
            this.circleBtn.TabIndex = 3;
            this.circleBtn.UseVisualStyleBackColor = false;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            this.circleBtn.MouseHover += new System.EventHandler(this.circleBtn_MouseHover);
            // 
            // squareBtn
            // 
            this.squareBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.squareBtn.BackgroundImage = global::drawing_application_p19057.Properties.Resources.square_24px;
            this.squareBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.squareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squareBtn.FlatAppearance.BorderSize = 0;
            this.squareBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.squareBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.squareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.squareBtn.Location = new System.Drawing.Point(3, 207);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(42, 33);
            this.squareBtn.TabIndex = 4;
            this.squareBtn.UseVisualStyleBackColor = false;
            this.squareBtn.Click += new System.EventHandler(this.sqaureBtn_Click);
            this.squareBtn.MouseHover += new System.EventHandler(this.squareBtn_MouseHover);
            // 
            // lineBtn
            // 
            this.lineBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lineBtn.BackgroundImage = global::drawing_application_p19057.Properties.Resources.line_32px;
            this.lineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineBtn.FlatAppearance.BorderSize = 0;
            this.lineBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.lineBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.lineBtn.Location = new System.Drawing.Point(3, 90);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(42, 33);
            this.lineBtn.TabIndex = 2;
            this.lineBtn.UseVisualStyleBackColor = false;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            this.lineBtn.MouseHover += new System.EventHandler(this.lineBtn_MouseHover);
            // 
            // penBtn
            // 
            this.penBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.penBtn.BackgroundImage = global::drawing_application_p19057.Properties.Resources.ball_point_pen_64px;
            this.penBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.penBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.penBtn.FlatAppearance.BorderSize = 0;
            this.penBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.penBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.penBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.penBtn.Location = new System.Drawing.Point(3, 6);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(42, 33);
            this.penBtn.TabIndex = 1;
            this.penBtn.UseVisualStyleBackColor = false;
            this.penBtn.Click += new System.EventHandler(this.penBtn_Click);
            this.penBtn.MouseHover += new System.EventHandler(this.penBtn_MouseHover);
            // 
            // stripPanel
            // 
            this.stripPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.stripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.stripPanel.Location = new System.Drawing.Point(56, 32);
            this.stripPanel.Name = "stripPanel";
            this.stripPanel.Size = new System.Drawing.Size(942, 3);
            this.stripPanel.TabIndex = 3;
            // 
            // stripPanel2
            // 
            this.stripPanel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.stripPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.stripPanel2.Location = new System.Drawing.Point(56, 35);
            this.stripPanel2.Name = "stripPanel2";
            this.stripPanel2.Size = new System.Drawing.Size(3, 743);
            this.stripPanel2.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // drawingBox
            // 
            this.drawingBox.BackColor = System.Drawing.Color.White;
            this.drawingBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.drawingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingBox.Location = new System.Drawing.Point(5, 5);
            this.drawingBox.Name = "drawingBox";
            this.drawingBox.Size = new System.Drawing.Size(993, 773);
            this.drawingBox.TabIndex = 0;
            this.drawingBox.TabStop = false;
            this.drawingBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBox_Paint);
            this.drawingBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseDown);
            this.drawingBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseMove);
            this.drawingBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingBox_MouseUp);
            // 
            // aboutControl
            // 
            this.aboutControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aboutControl.BackColor = System.Drawing.SystemColors.Control;
            this.aboutControl.Location = new System.Drawing.Point(248, 134);
            this.aboutControl.Name = "aboutControl";
            this.aboutControl.Size = new System.Drawing.Size(558, 307);
            this.aboutControl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1003, 783);
            this.Controls.Add(this.aboutControl);
            this.Controls.Add(this.stripPanel2);
            this.Controls.Add(this.stripPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.drawingBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPaint)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moreColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel stripPanel;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button maximizeBtn;
        private System.Windows.Forms.Button penBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel stripPanel2;
        private System.Windows.Forms.PictureBox redBox;
        private System.Windows.Forms.PictureBox greenBox;
        private System.Windows.Forms.PictureBox yellowBox;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.PictureBox iconPaint;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox moreColors;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip moreColorsTp;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label warningLbl;
        private System.Windows.Forms.TrackBar penWidth;
        private System.Windows.Forms.Button ellipseBtn;
        private AboutControl aboutControl;
        private System.Windows.Forms.Button eraserBtn;
        private System.Windows.Forms.Label positionX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label positionY;
        private System.Windows.Forms.ToolTip penTip;
        private System.Windows.Forms.ToolTip eraserTip;
        private System.Windows.Forms.ToolTip lineTip;
        private System.Windows.Forms.ToolTip ellipseTip;
        private System.Windows.Forms.ToolTip circleTip;
        private System.Windows.Forms.ToolTip squareTip;
        private System.Windows.Forms.ToolTip penSizeTip;
    }
}

