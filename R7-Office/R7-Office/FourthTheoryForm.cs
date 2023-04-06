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
    public partial class FourthTheoryForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public FourthTheoryForm()
        {
            InitializeComponent();
        }

        private void FourthTheoryForm_Load(object sender, EventArgs e)
        {
            FourthTheoryRichTextBox.LoadFile(Directory.GetCurrentDirectory() + @"\Theory\AddTextObject.rtf");
            FourthTheoryRichTextBox.SelectionIndent = 0;
        }
        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                FourthTheoryRichTextBox.ZoomFactor++;
            else if (e.Delta < 0)
                FourthTheoryRichTextBox.ZoomFactor--;
        }

        private void FourthTheoryForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FourthTheoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FourthTheoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ThirdTheoryRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.MouseWheel += new MouseEventHandler(this_MouseWheel);
            }
            else
            {
                FourthTheoryRichTextBox.ZoomFactor = 1;
            }
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
