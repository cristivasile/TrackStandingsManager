using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI.Forms
{
    public partial class TemplateFormResizable : Form
    {
        public TemplateFormResizable()
        {
            InitializeComponent();
        }

        protected void InitializeBorder()
        {
            this.TopBarPanel.Location = new Point(0, 0);
            this.TopBarPanel.Width = this.Width;
            this.LeftBorderPanel.Location = new Point(0, 0);
            this.LeftBorderPanel.Height = this.Height;
            this.RightBorderPanel.Location = new Point(this.Width - 2, 0);
            this.RightBorderPanel.Height = this.Height;
            this.BottomBorderPanel.Location = new Point(0, this.Height - 2);
            this.BottomBorderPanel.Width = this.Width;
            this.CloseButton.Location = new Point(this.Width - 30, 6);
            this.MinimizeButton.Location = new Point(this.Width - 56, 6);
            this.ResizeArrowPicture.Location = new Point(this.Width - 18, this.Height - 18);
        }

        //source https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        // ------ //

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void FormTemplate_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // ------ //

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Source = https://stackoverflow.com/questions/2575216/how-to-move-and-resize-a-form-without-a-border
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        //------

        private void TemplateForm_Resize(object sender, EventArgs e)
        {
            this.TopBarPanel.Width = this.Width;
            this.LeftBorderPanel.Height = this.Height;
            this.RightBorderPanel.Location = new Point(this.Width - 2, 0);
            this.RightBorderPanel.Height = this.Height;
            this.BottomBorderPanel.Location = new Point(0, this.Height - 2);
            this.BottomBorderPanel.Width = this.Width;
            this.CloseButton.Location = new Point(this.Width - 30, 6);
            this.MinimizeButton.Location = new Point(this.Width - 56, 6);
            this.ResizeArrowPicture.Location = new Point(this.Width - 18, this.Height - 18);
        }

    }
}
