
namespace paint_application_p19057
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
            this.drawingCanvas = new System.Windows.Forms.PictureBox();
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.eraserBtn = new System.Windows.Forms.Button();
            this.sqaureBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.penBtn = new System.Windows.Forms.Button();
            this.colorDialogBtn = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.blueColor = new System.Windows.Forms.PictureBox();
            this.greenColor = new System.Windows.Forms.PictureBox();
            this.orangeColor = new System.Windows.Forms.PictureBox();
            this.redColor = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.drawingCanvas)).BeginInit();
            this.PaintPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingCanvas
            // 
            this.drawingCanvas.BackColor = System.Drawing.Color.White;
            this.drawingCanvas.Location = new System.Drawing.Point(0, 61);
            this.drawingCanvas.Name = "drawingCanvas";
            this.drawingCanvas.Size = new System.Drawing.Size(1137, 574);
            this.drawingCanvas.TabIndex = 0;
            this.drawingCanvas.TabStop = false;
            this.drawingCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingCanvas_Paint);
            this.drawingCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseDown);
            this.drawingCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseMove);
            this.drawingCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseUp);
            // 
            // PaintPanel
            // 
            this.PaintPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.PaintPanel.Controls.Add(this.eraserBtn);
            this.PaintPanel.Controls.Add(this.sqaureBtn);
            this.PaintPanel.Controls.Add(this.lineBtn);
            this.PaintPanel.Controls.Add(this.circleBtn);
            this.PaintPanel.Controls.Add(this.penBtn);
            this.PaintPanel.Controls.Add(this.colorDialogBtn);
            this.PaintPanel.Controls.Add(this.panel2);
            this.PaintPanel.Controls.Add(this.drawingCanvas);
            this.PaintPanel.Controls.Add(this.menuStrip1);
            this.PaintPanel.Location = new System.Drawing.Point(-4, 0);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(1137, 676);
            this.PaintPanel.TabIndex = 1;
            // 
            // eraserBtn
            // 
            this.eraserBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.eraserBtn.BackgroundImage = global::paint_application_p19057.Properties.Resources.icons8_eraser_64;
            this.eraserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraserBtn.FlatAppearance.BorderSize = 0;
            this.eraserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserBtn.Location = new System.Drawing.Point(648, 27);
            this.eraserBtn.Name = "eraserBtn";
            this.eraserBtn.Size = new System.Drawing.Size(37, 28);
            this.eraserBtn.TabIndex = 19;
            this.eraserBtn.UseVisualStyleBackColor = false;
            // 
            // sqaureBtn
            // 
            this.sqaureBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.sqaureBtn.BackgroundImage = global::paint_application_p19057.Properties.Resources.square_24px;
            this.sqaureBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sqaureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqaureBtn.FlatAppearance.BorderSize = 0;
            this.sqaureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqaureBtn.Location = new System.Drawing.Point(777, 27);
            this.sqaureBtn.Name = "sqaureBtn";
            this.sqaureBtn.Size = new System.Drawing.Size(40, 28);
            this.sqaureBtn.TabIndex = 18;
            this.sqaureBtn.UseVisualStyleBackColor = false;
            // 
            // lineBtn
            // 
            this.lineBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.lineBtn.BackgroundImage = global::paint_application_p19057.Properties.Resources.line_32px;
            this.lineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineBtn.FlatAppearance.BorderSize = 0;
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineBtn.Location = new System.Drawing.Point(734, 27);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(37, 28);
            this.lineBtn.TabIndex = 17;
            this.lineBtn.UseVisualStyleBackColor = false;
            // 
            // circleBtn
            // 
            this.circleBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.circleBtn.BackgroundImage = global::paint_application_p19057.Properties.Resources.circle_50px;
            this.circleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleBtn.FlatAppearance.BorderSize = 0;
            this.circleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleBtn.Location = new System.Drawing.Point(823, 27);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(37, 28);
            this.circleBtn.TabIndex = 16;
            this.circleBtn.UseVisualStyleBackColor = false;
            // 
            // penBtn
            // 
            this.penBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.penBtn.BackgroundImage = global::paint_application_p19057.Properties.Resources.ball_point_pen_64px;
            this.penBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.penBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.penBtn.FlatAppearance.BorderSize = 0;
            this.penBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penBtn.Location = new System.Drawing.Point(691, 27);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(37, 28);
            this.penBtn.TabIndex = 15;
            this.penBtn.UseVisualStyleBackColor = false;
            // 
            // colorDialogBtn
            // 
            this.colorDialogBtn.BackColor = System.Drawing.Color.White;
            this.colorDialogBtn.BackgroundImage = global::paint_application_p19057.Properties.Resources.more_50px;
            this.colorDialogBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colorDialogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorDialogBtn.Location = new System.Drawing.Point(1078, 27);
            this.colorDialogBtn.Name = "colorDialogBtn";
            this.colorDialogBtn.Size = new System.Drawing.Size(42, 28);
            this.colorDialogBtn.TabIndex = 14;
            this.colorDialogBtn.Click += new System.EventHandler(this.colorDialogBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.blueColor);
            this.panel2.Controls.Add(this.greenColor);
            this.panel2.Controls.Add(this.orangeColor);
            this.panel2.Controls.Add(this.redColor);
            this.panel2.Location = new System.Drawing.Point(920, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 28);
            this.panel2.TabIndex = 13;
            // 
            // blueColor
            // 
            this.blueColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blueColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueColor.Location = new System.Drawing.Point(117, 3);
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(32, 22);
            this.blueColor.TabIndex = 4;
            this.blueColor.TabStop = false;
            this.blueColor.Click += new System.EventHandler(this.blueColor_Click);
            // 
            // greenColor
            // 
            this.greenColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenColor.Location = new System.Drawing.Point(79, 3);
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(32, 22);
            this.greenColor.TabIndex = 3;
            this.greenColor.TabStop = false;
            this.greenColor.Click += new System.EventHandler(this.greenColor_Click);
            // 
            // orangeColor
            // 
            this.orangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orangeColor.Location = new System.Drawing.Point(41, 3);
            this.orangeColor.Name = "orangeColor";
            this.orangeColor.Size = new System.Drawing.Size(32, 22);
            this.orangeColor.TabIndex = 2;
            this.orangeColor.TabStop = false;
            this.orangeColor.Click += new System.EventHandler(this.orangeColor_Click);
            // 
            // redColor
            // 
            this.redColor.BackColor = System.Drawing.Color.Red;
            this.redColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redColor.Location = new System.Drawing.Point(3, 3);
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(32, 22);
            this.redColor.TabIndex = 1;
            this.redColor.TabStop = false;
            this.redColor.Click += new System.EventHandler(this.redColor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 635);
            this.Controls.Add(this.PaintPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawingCanvas)).EndInit();
            this.PaintPanel.ResumeLayout(false);
            this.PaintPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blueColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redColor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingCanvas;
        private System.Windows.Forms.Panel PaintPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel colorDialogBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox blueColor;
        private System.Windows.Forms.PictureBox greenColor;
        private System.Windows.Forms.PictureBox orangeColor;
        private System.Windows.Forms.PictureBox redColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button penBtn;
        private System.Windows.Forms.Button sqaureBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button eraserBtn;
    }
}

