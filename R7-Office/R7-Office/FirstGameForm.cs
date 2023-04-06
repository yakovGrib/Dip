using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R7_Office
{
    public partial class FirstGameForm : Form
    {
        PictureBox[] boxes;
        PictureBox selected; 
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public FirstGameForm()
        {
            InitializeComponent();
            boxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8,pictureBox9, pictureBox10, pictureBox11,
                pictureBox12, pictureBox13, pictureBox15, upPictureBox, centerPictureBox, downPictureBox, leftPictureBox, rightPictureBox, justifyPictureBox, aligncenterPictureBox,
                prozentPictureBox, finformPictureBox, boldPictureBox, italyPictureBox, podcherkPictureBox, SelectWordPictureBox, sizePictureBox };
            try
            {

                pictureBox1.BackgroundImage = Properties.Resources.up;
                pictureBox2.BackgroundImage = Properties.Resources.Center;
                pictureBox3.BackgroundImage = Properties.Resources.down;
                pictureBox4.BackgroundImage = Properties.Resources.left;
                pictureBox5.BackgroundImage = Properties.Resources.aligncenter;
                pictureBox6.BackgroundImage = Properties.Resources.right;
                pictureBox7.BackgroundImage = Properties.Resources.justify;
                pictureBox8.BackgroundImage = Properties.Resources.prozent;
                pictureBox9.BackgroundImage = Properties.Resources.SelectWord;
                pictureBox10.BackgroundImage = Properties.Resources.finform;
                pictureBox11.BackgroundImage = Properties.Resources.bold;
                pictureBox12.BackgroundImage = Properties.Resources.italic;
                pictureBox13.BackgroundImage = Properties.Resources.podcherk;
                pictureBox15.BackgroundImage = Properties.Resources.Size;


            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Нет фото!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var box in boxes)
            {
                box.AllowDrop = true;
                box.DragDrop += PictureBox_DragDrop;
                box.DragEnter += PictureBox_DragEnter;
                box.MouseClick += PictureBox_MouseClick;
                box.MouseMove += PictureBox_MouseMove;
                box.Paint += PictureBox_Paint;
            }
        }
        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var target = (PictureBox)sender;
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                var source = (PictureBox)e.Data.GetData(typeof(PictureBox));
                if (source != target)
                {
                    SwapImages(source, target);

                    selected = null;
                    SelectBox(target);
                    return;
                }
            }
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }


        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectBox((PictureBox)sender);
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pb = (PictureBox)sender;
                if (pb.BackgroundImage != null)
                {
                    pb.DoDragDrop(pb, DragDropEffects.Move);
                }
            }
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            var pb = (PictureBox)sender;
            pb.BackColor = Color.White;
            if (selected == pb)
            {
                ControlPaint.DrawBorder(e.Graphics, pb.ClientRectangle,
                   Color.Gray, 1, ButtonBorderStyle.Solid,  // Left
                   Color.Gray, 1, ButtonBorderStyle.Solid,  // Top
                   Color.Gray, 1, ButtonBorderStyle.Solid,  // Right
                   Color.Gray, 1, ButtonBorderStyle.Solid); // Bottom
            }

        }

        private void SelectBox(PictureBox pb)
        {
            if (selected != pb)
            {
                selected = pb;
            }
            else
            {
                selected = null;
            }
            // Cause each box to repaint
            foreach (var box in boxes) box.Invalidate();
        }

        private void SwapImages(PictureBox source, PictureBox target)
        {
            if (source.BackgroundImage == null && target.BackgroundImage == null)
            {
                return;
            }

            var temp = target.BackgroundImage;
            target.BackgroundImage = source.BackgroundImage;
            source.BackgroundImage = temp;
        }


        private void upPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void centerPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (centerPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)centerPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.Center;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                centerPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void downPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (downPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)downPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.down;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                downPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void leftPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (leftPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)leftPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.left;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                leftPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void aligncenterPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (aligncenterPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)aligncenterPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.aligncenter;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                aligncenterPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void rightPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (rightPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)rightPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.right;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                rightPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void justifyPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (justifyPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)justifyPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.justify;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                justifyPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void prozentPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (prozentPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)prozentPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.prozent;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                prozentPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void finformPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (finformPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)finformPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.finform;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                finformPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void boldPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (boldPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)boldPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.bold;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                boldPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void italyPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (italyPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)italyPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.italic;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                italyPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void podcherkPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (podcherkPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)podcherkPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.podcherk;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                podcherkPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void SelectWordPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (SelectWordPictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)SelectWordPictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.SelectWord;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                SelectWordPictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        private void sizePictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (sizePictureBox.BackgroundImage == null)
            {
                return;
            }
            Bitmap Bmp1 = (Bitmap)sizePictureBox.BackgroundImage;
            Bitmap Bmp2 = (Bitmap)Properties.Resources.Size;
            if (Bmp1.Size == Bmp2.Size)
            {
                for (int i = 0; i < Bmp1.Width; i++)
                    for (int j = 0; j < Bmp1.Height; j++)
                        if (Bmp1.GetPixel(i, j) != Bmp2.GetPixel(i, j))
                        {
                            MessageBox.Show("Не верно!");
                            return;
                        }
                sizePictureBox.Visible = false;
                Check();
            }
            else MessageBox.Show("Не верно!");
        }

        public void Check()
        {
            if (SelectWordPictureBox.Visible == false && upPictureBox.Visible == false && centerPictureBox.Visible == false && downPictureBox.Visible == false && leftPictureBox.Visible == false && rightPictureBox.Visible == false && justifyPictureBox.Visible == false && aligncenterPictureBox.Visible == false &&
                prozentPictureBox.Visible == false && finformPictureBox.Visible == false && boldPictureBox.Visible == false && italyPictureBox.Visible == false && podcherkPictureBox.Visible == false && SelectWordPictureBox.Visible == false && sizePictureBox.Visible == false)
            {
                MessageBox.Show("Молодец! Панель управления собрана.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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

        private void FirstGameForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FirstGameForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FirstGameForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}
