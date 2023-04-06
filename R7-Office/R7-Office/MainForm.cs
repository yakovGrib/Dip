using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace R7_Office
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public MainForm()
        {
            InitializeComponent();
            ChapterLabel1.MouseEnter += (s, e) => ChapterLabel1.BackColor = Color.FromArgb(191, 191, 191);
            ChapterLabel1.MouseLeave += (s, e) => ChapterLabel1.BackColor = Color.FromArgb(226, 226, 226);
            ChapterLabel2.MouseEnter += (s, e) => ChapterLabel2.BackColor = Color.FromArgb(191, 191, 191);
            ChapterLabel2.MouseLeave += (s, e) => ChapterLabel2.BackColor = Color.FromArgb(226, 226, 226);
            ChapterLabel3.MouseEnter += (s, e) => ChapterLabel3.BackColor = Color.FromArgb(191, 191, 191);
            ChapterLabel3.MouseLeave += (s, e) => ChapterLabel3.BackColor = Color.FromArgb(226, 226, 226);
            ChapterLabel4.MouseEnter += (s, e) => ChapterLabel4.BackColor = Color.FromArgb(191, 191, 191);
            ChapterLabel4.MouseLeave += (s, e) => ChapterLabel4.BackColor = Color.FromArgb(226, 226, 226);
            ChapterLabel5.MouseEnter += (s, e) => ChapterLabel5.BackColor = Color.FromArgb(191, 191, 191);
            ChapterLabel5.MouseLeave += (s, e) => ChapterLabel5.BackColor = Color.FromArgb(226, 226, 226);
            ChapterLabel6.MouseEnter += (s, e) => ChapterLabel6.BackColor = Color.FromArgb(191, 191, 191);
            ChapterLabel6.MouseLeave += (s, e) => ChapterLabel6.BackColor = Color.FromArgb(226, 226, 226);
            FirstTestLabel.MouseEnter += (s, e) => FirstTestLabel.BackColor = Color.FromArgb(191, 191, 191);
            FirstTestLabel.MouseLeave += (s, e) => FirstTestLabel.BackColor = Color.FromArgb(226, 226, 226);
            SecondTestLabel.MouseEnter += (s, e) => SecondTestLabel.BackColor = Color.FromArgb(191, 191, 191);
            SecondTestLabel.MouseLeave += (s, e) => SecondTestLabel.BackColor = Color.FromArgb(226, 226, 226);
            ThirdTestLabel.MouseEnter += (s, e) => ThirdTestLabel.BackColor = Color.FromArgb(191, 191, 191);
            ThirdTestLabel.MouseLeave += (s, e) => ThirdTestLabel.BackColor = Color.FromArgb(226, 226, 226);
            FourthTestLabel.MouseEnter += (s, e) => FourthTestLabel.BackColor = Color.FromArgb(191, 191, 191);
            FourthTestLabel.MouseLeave += (s, e) => FourthTestLabel.BackColor = Color.FromArgb(226, 226, 226);
            FifthTestLabel.MouseEnter += (s, e) => FifthTestLabel.BackColor = Color.FromArgb(191, 191, 191);
            FifthTestLabel.MouseLeave += (s, e) => FifthTestLabel.BackColor = Color.FromArgb(226, 226, 226);
            SixthTestLabel.MouseEnter += (s, e) => SixthTestLabel.BackColor = Color.FromArgb(191, 191, 191);
            SixthTestLabel.MouseLeave += (s, e) => SixthTestLabel.BackColor = Color.FromArgb(226, 226, 226);
            FirstGameLabel.MouseEnter += (s, e) => FirstGameLabel.BackColor = Color.FromArgb(191, 191, 191);
            FirstGameLabel.MouseLeave += (s, e) => FirstGameLabel.BackColor = Color.FromArgb(226, 226, 226);
            MainTabControl.Appearance = TabAppearance.FlatButtons;
            MainTabControl.ItemSize = new Size(0, 1);
            MainTabControl.SizeMode = TabSizeMode.Fixed;
            this.MainTabControl.SelectedIndex = 15;
        }

        //private void TheoryLabel_Click(object sender, EventArgs e)
        //{
        //    TheoryLabel.BackColor = Color.FromArgb(152, 251, 152);
        //    TestLabel.BackColor = Color.FromArgb(64, 134, 92);
        //    InteractiveLabel.BackColor = Color.FromArgb(64, 134, 92);
        //    if (TestPanel.Visible == true || InteractivePanel.Visible == true)
        //    {
        //        InteractivePanel.Visible = false;
        //        TestPanel.Visible = false;
        //    }
        //    if (TheoryPanel.Visible == false)
        //    {
        //        TheoryPanel.Visible = true;
        //    }
        //    else
        //    {
        //        TheoryPanel.Visible = false;
        //        TheoryLabel.BackColor = Color.FromArgb(64, 134, 92);
        //    }
        //}

        //private void TestLabel_Click(object sender, EventArgs e)
        //{
        //    TestLabel.BackColor = Color.FromArgb(152, 251, 152);
        //    TheoryLabel.BackColor = Color.FromArgb(64, 134, 92);
        //    InteractiveLabel.BackColor = Color.FromArgb(64, 134, 92);
        //    if (TheoryPanel.Visible == true || InteractivePanel.Visible == true)
        //    {
        //        InteractivePanel.Visible = false;
        //        TheoryPanel.Visible = false;
        //    }
        //    if (TestPanel.Visible == false)
        //    {
        //        TestPanel.Visible = true;
        //    }
        //    else
        //    {
        //        TestPanel.Visible = false;
        //        TestLabel.BackColor = Color.FromArgb(64, 134, 92);
        //    }
        //}

        //private void InteractiveLabel_Click(object sender, EventArgs e)
        //{
        //    InteractiveLabel.BackColor = Color.FromArgb(152, 251, 152);
        //    TheoryLabel.BackColor = Color.FromArgb(64, 134, 92);
        //    TestLabel.BackColor = Color.FromArgb(64, 134, 92);
        //    if (TheoryPanel.Visible == true || TestPanel.Visible == true)
        //    {
        //        TheoryPanel.Visible = false;
        //        TestPanel.Visible = false;
        //    }
        //    if (InteractivePanel.Visible == false)
        //    {
        //        InteractivePanel.Visible = true;
        //    }
        //    else
        //    {
        //        InteractivePanel.Visible = false;
        //        InteractiveLabel.BackColor = Color.FromArgb(64, 134, 92);
        //    }
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(848, 416);
            MainTabControl.Visible = true;
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChapterLabel1_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(848, 416);
            MainTabControl.Visible = true;
        }

        private void ChapterLabel2_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 1;
            MainTabControl.Size = new Size(848, 416);
            MainTabControl.Visible = true;
        }

        private void ChapterLabel3_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 2;
            MainTabControl.Size = new Size(848, 416);
            MainTabControl.Visible = true;
        }

        private void ChapterLabel4_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 3;
            MainTabControl.Size = new Size(848, 416);
            MainTabControl.Visible = true;
        }

        private void ChapterLabel5_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 4;
            MainTabControl.Size = new Size(848, 416);
            MainTabControl.Visible = true;
        }

        private void ChapterLabel6_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 5;
            MainTabControl.Size = new Size(848, 416);
            MainTabControl.Visible = true;
        }

        private void FirstTestLabel_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 6;
            MainTabControl.Size = new Size(840, 416);
            MainTabControl.Visible = true;
        }

        private void SecondTestLabel_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 7;
            MainTabControl.Size = new Size(840, 416);
            MainTabControl.Visible = true;
        }

        private void ThirdTestLabel_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 8;
            MainTabControl.Size = new Size(840, 416);
            MainTabControl.Visible = true;
        }

        private void FourthTestLabel_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 9;
            MainTabControl.Size = new Size(840, 416);
            MainTabControl.Visible = true;
        }

        private void FifthTestLabel_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 10;
            MainTabControl.Size = new Size(840, 416);
            MainTabControl.Visible = true;
        }

        private void SixthTestLabel_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 11;
            MainTabControl.Size = new Size(840, 416);
            MainTabControl.Visible = true;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FirstTheoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstTheoryForm ftf = new FirstTheoryForm();
            ftf.ShowDialog();
            this.Show();
        }

        private void SecondTheoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondTheoryForm stf = new SecondTheoryForm();
            stf.ShowDialog();
            this.Show();
        }

        private void ThirdTheoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            ThirdTheoryForm ttf = new ThirdTheoryForm();
            ttf.ShowDialog();
            this.Show();
        }

        private void FourthTheoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            FourthTheoryForm ftff = new FourthTheoryForm();
            ftff.ShowDialog();
            this.Show();
        }

        private void FifthTheoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            ThithTheoryForm ttff = new ThithTheoryForm();
            ttff.ShowDialog();
            this.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SixthTheoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            SixthTheoryForm stf = new SixthTheoryForm();
            stf.ShowDialog();
            this.Show();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            Hide();
           TestForm tf = new TestForm(Directory.GetCurrentDirectory() + @"\Test\data.xml");
            tf.ShowDialog();
            this.Show();
        }

        private void SecTestButton_Click(object sender, EventArgs e)
        {
            Hide();
            TestForm tf = new TestForm(Directory.GetCurrentDirectory() + @"\Test\data2.xml");
            tf.ShowDialog();
            this.Show();
        }

        private void ThirdTestButton_Click(object sender, EventArgs e)
        {
            Hide();
            TestForm tf = new TestForm(Directory.GetCurrentDirectory() + @"\Test\data3.xml");
            tf.ShowDialog();
            this.Show();
        }

        private void FourthTestButton_Click(object sender, EventArgs e)
        {
            Hide();
            TestForm tf = new TestForm(Directory.GetCurrentDirectory() + @"\Test\data4.xml");
            tf.ShowDialog();
            this.Show();
        }

        private void FifthTestButton_Click(object sender, EventArgs e)
        {
            Hide();
            TestForm tf = new TestForm(Directory.GetCurrentDirectory() + @"\Test\data5.xml");
            tf.ShowDialog();
            this.Show();
        }

        private void SixthTestButton_Click(object sender, EventArgs e)
        {
            Hide();
            TestForm tf = new TestForm(Directory.GetCurrentDirectory() + @"\Test\data6.xml");
            tf.ShowDialog();
            this.Show();
        }

        private void FirstGameLabel_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 12;
            MainTabControl.Size = new Size(840, 300);
            MainTabControl.Visible = true;
        }

        private void FirstGameButton_Click(object sender, EventArgs e)
        {
            Hide();
            FirstGameForm fgf = new FirstGameForm();
            fgf.ShowDialog();
            this.Show();
        }
    }
}