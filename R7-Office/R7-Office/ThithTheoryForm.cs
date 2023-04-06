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
    public partial class ThithTheoryForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public ThithTheoryForm()
        {
            InitializeComponent();
        }
        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                ThithTheoryRichTextBox.ZoomFactor++;
            else if (e.Delta < 0)
                ThithTheoryRichTextBox.ZoomFactor--;
        }
        private void ThithTheoryRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.MouseWheel += new MouseEventHandler(this_MouseWheel);
            }
            else
            {
                ThithTheoryRichTextBox.ZoomFactor = 1;
            }
        }

        private void ThithTheoryForm_Load(object sender, EventArgs e)
        {
            ThithTheoryRichTextBox.LoadFile(Directory.GetCurrentDirectory() + @"\Theory\CoopChange.rtf");
            ThithTheoryRichTextBox.SelectionIndent = 0;
        }

        private void ThithTheoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ThithTheoryForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void ThithTheoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
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
