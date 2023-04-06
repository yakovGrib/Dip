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
    public partial class SixthTheoryForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public SixthTheoryForm()
        {
            InitializeComponent();
        }
        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                SixthTheoryRichTextBox.ZoomFactor++;
            else if (e.Delta < 0)
                SixthTheoryRichTextBox.ZoomFactor--;
        }
        private void SixthTheoryRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.MouseWheel += new MouseEventHandler(this_MouseWheel);
            }
            else
            {
                SixthTheoryRichTextBox.ZoomFactor = 1;
            }
        }

        private void SixthTheoryForm_Load(object sender, EventArgs e)
        {
            SixthTheoryRichTextBox.LoadFile(Directory.GetCurrentDirectory() + @"\Theory\DlcParametr.rtf");
            SixthTheoryRichTextBox.SelectionIndent = 0;
        }

        private void SixthTheoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void SixthTheoryForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void SixthTheoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
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
