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
    public partial class FirstTheoryForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public FirstTheoryForm()
        {
            InitializeComponent();
        }

        private void FirstTheoryForm_Load(object sender, EventArgs e)
        {
            FirstTheoryRichTextBox.LoadFile(Directory.GetCurrentDirectory() + @"\Theory\Interface.rtf");
            FirstTheoryRichTextBox.SelectionIndent = 0;
        }
        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                FirstTheoryRichTextBox.ZoomFactor++;
            else if (e.Delta < 0)
                FirstTheoryRichTextBox.ZoomFactor--;
        }

        private void FirstTheoyRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.MouseWheel += new MouseEventHandler(this_MouseWheel);
            }
            else
            {
                FirstTheoryRichTextBox.ZoomFactor = 1;
            }
        }

        private void FirstTheoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FirstTheoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FirstTheoryForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
