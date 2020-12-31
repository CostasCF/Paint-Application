
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.maximizeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.stripPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawingBox = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.Controls.Add(this.maximizeBtn);
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 27);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
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
            this.exitBtn.Location = new System.Drawing.Point(759, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(29, 21);
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
            this.maximizeBtn.Location = new System.Drawing.Point(724, 3);
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
            this.minimizeBtn.Location = new System.Drawing.Point(689, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(29, 21);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 27);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(48, 423);
            this.menuPanel.TabIndex = 2;
            // 
            // stripPanel
            // 
            this.stripPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.stripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.stripPanel.Location = new System.Drawing.Point(48, 27);
            this.stripPanel.Name = "stripPanel";
            this.stripPanel.Size = new System.Drawing.Size(752, 3);
            this.stripPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(48, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 420);
            this.panel1.TabIndex = 4;
            // 
            // drawingBox
            // 
            this.drawingBox.BackColor = System.Drawing.SystemColors.Control;
            this.drawingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingBox.Location = new System.Drawing.Point(0, 0);
            this.drawingBox.Name = "drawingBox";
            this.drawingBox.Size = new System.Drawing.Size(800, 450);
            this.drawingBox.TabIndex = 0;
            this.drawingBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stripPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.drawingBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel stripPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button maximizeBtn;
    }
}

