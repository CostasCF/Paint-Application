using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace drawing_application_p19057
{
    public partial class AboutControl : UserControl
    {   //για μετακινηση(Drag) Control
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AboutControl()
        {
            InitializeComponent();
        }



        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/CostasCF");

        }
    }
}
