using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PressureSpotFixer
{
    class FixerForm : PerPixelAlphaForm
    {

        private Bitmap bitmap;		// bitmap that is currently displaying on our test form
        private readonly bool draggable; // able to drag and drop or not

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="draggable">form should be draggable? readonly variable</param>
        public FixerForm(bool draggable)
        {
            this.draggable = draggable;
            loadPosition();

            /* Set on top of all */
            TopMost = true;
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.SizableToolWindow; // don't show in alt-tab

            /* Load image */
            LoadImage();
        }

        /// <summary>
        /// Draggable getter
        /// </summary>
        /// <returns></returns>
        public bool IsDraggable()
        {
            return this.draggable;
        }

        /*************** POSITION ***************/

        /// <summary>
        ///  Sets poition of fixer to given x,y
        /// </summary>
        /// <param name="x">x value</param>
        /// <param name="y">y value</param>
        public void SetPosition(int x, int y)
        {
            this.Location = new Point(x, y);
        }
        
        /// <summary>
        /// Resets the position of the fixer to a known one (100 ,100)
        /// </summary>
        public void ResetPosition()
        {
            SetPosition(100, 100);
        }

        /// <summary>
        /// Load position from settings
        /// </summary>
        private void loadPosition()
        {
            SetPosition(Properties.Settings.Default.Xpos, Properties.Settings.Default.Ypos);
        }
        
        /// <summary>
        /// Save current position to settings
        /// </summary>
        public void SavePosition()
        {
            Properties.Settings.Default.Xpos = this.Location.X;
            Properties.Settings.Default.Ypos = this.Location.Y;
            Properties.Settings.Default.Save();
        }


        /********** FIXER IMAGE ************/
        
        /// <summary>
        /// Loads fixer image path from settings and calls setImage function
        /// </summary>
        protected void LoadImage()
        {
            SetImage(Properties.Settings.Default.filePath);
        }

        /// <summary>
        /// Sets the given file (as filePath) as fixer.
        /// Marker will be added if Settings Form is open (so fixer is draggable)
        /// </summary>
        /// <param name="filePath">file path as string</param>
        private void SetImage(string filePath)
        {
            Bitmap newBitmap;
            try
            {
                newBitmap = Image.FromFile(filePath) as Bitmap;

                if (this.IsDraggable())
                    newBitmap = AddMarker(newBitmap);

                this.SetBitmap(newBitmap, 255);
            }
            catch (ApplicationException exc)
            {
                MessageBox.Show(this, exc.Message, "Error with bitmap.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, exc.Message, "Could not open image file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bitmap != null)
                bitmap.Dispose();

            bitmap = newBitmap;
        }

        /// <summary>
        /// Adds a marker to the fixer bitmap (20x20 red marker on top left)
        /// </summary>
        /// <param name="bmp">bitmap</param>
        /// <returns>bitmap with marker</returns>
        public static Bitmap AddMarker(Bitmap bmp)
        {
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    bmp.SetPixel(x, y, Color.Red);
                }
            }
            return bmp;
        }

        /// <summary>
        /// Drag n drop
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (IsDraggable() && m.Msg == 0x0084 /*WM_NCHITTEST*/)
            {
                m.Result = (IntPtr)2;	// HTCLIENT
                return;
            }
            base.WndProc(ref m);
        }

        /* Click through code*/
        // Thanks Stackoverflow
        // http://stackoverflow.com/questions/1524035/topmost-form-clicking-through-possible

        public enum GWL
        {
            ExStyle = -20
        }

        public enum WS_EX
        {
            Transparent = 0x20,
            Layered = 0x80000
        }

        public enum LWA
        {
            ColorKey = 0x1,
            Alpha = 0x2
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);

        // [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        // public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);

        protected override void OnShown(EventArgs e)
        {
            if (!IsDraggable())
            {

                base.OnShown(e);
                int wl = GetWindowLong(this.Handle, GWL.ExStyle);
                wl = wl | 0x80000 | 0x20;
                SetWindowLong(this.Handle, GWL.ExStyle, wl);
                //SetLayeredWindowAttributes(this.Handle, 0, 128, LWA.Alpha);
            }
        }

        /* Don't show in alt-tab */
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

    }
}
