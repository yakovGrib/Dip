using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R7_Office
{
    public partial class SecondTheoryForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public SecondTheoryForm()
        {
            InitializeComponent();
        }

        private void SecondTheoryForm_Load(object sender, EventArgs e)
        {
            SecondTheoryRichTextBox.LoadFile(Directory.GetCurrentDirectory() + @"\Theory\Editing.rtf");
            SecondTheoryRichTextBox.SelectionIndent = 0;
        }

        private void SecondTheoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                SecondTheoryRichTextBox.ZoomFactor++;
            else if (e.Delta < 0)
                SecondTheoryRichTextBox.ZoomFactor--;
        }

        private void SecondTheoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void SecondTheoryForm_MouseUp(object sender, MouseEventArgs e)
        {
           dragging = false;
        }

        private void SecondTheoryRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.MouseWheel += new MouseEventHandler(this_MouseWheel);
            }
            else
            {
                SecondTheoryRichTextBox.ZoomFactor = 1;
            }
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
