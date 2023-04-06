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
using System.Xml;

namespace R7_Office
{
    public partial class TestForm : Form
    {
        double successAnswer = 0;
        XmlNode success;
        int[] mass = new int[15] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int arr = 0;
        int secTick = 0;
        int counter = 1;
        string FN = "";
        public TestForm(string filename)
        {
            InitializeComponent();
            FN = filename;
        }
        public void CheckAnswers()
        {
            if (answerRadioButton1.Checked)
            {
                if (answerRadioButton1.Text.ToLower() == success.Value.ToLower())
                {
                    successAnswer++;
                }
            }
            else if (answerRadioButton2.Checked)
            {
                if (answerRadioButton2.Text.ToLower() == success.Value.ToLower())
                {
                    successAnswer++;
                }
            }
            else if (answerRadioButton3.Checked)
            {
                if (answerRadioButton3.Text.ToLower() == success.Value.ToLower())
                {
                    successAnswer++;
                }
            }
            else if (answerRadioButton4.Checked)
            {
                if (answerRadioButton4.Text.ToLower() == success.Value.ToLower())
                {
                    successAnswer++;
                }
            }
            if (checkBox1.Visible)
            {
                var str = "";
                if (checkBox1.Checked) str += checkBox1.Text;
                if (checkBox2.Checked) str += checkBox2.Text;
                if (checkBox3.Checked) str += checkBox3.Text;
                if (checkBox4.Checked) str += checkBox4.Text;
                if (str == success.Value) successAnswer++;
            }
            if (textBox1.Text.ToLower() == success.Value.ToLower()) successAnswer++;
            arr++;
            if (arr > 9)
            {
                timer1.Stop();
                if ((successAnswer / 10) * 100 >= 90)
                {
                    if (FN == (Directory.GetCurrentDirectory() + @"\Test\data.xml"))
                    {
                        MessageBox.Show($"Отлично! Вы прошли тест на оценку «5».", "Поздравляем!");
                        Properties.Settings.Default.FirstMark = 5;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data2.xml"))
                    {
                        MessageBox.Show($"Отлично! Вы прошли тест на оценку «5».", "Поздравляем!");
                        Properties.Settings.Default.SecondMark = 5;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data3.xml"))
                    {
                        MessageBox.Show($"Отлично! Вы прошли тест на оценку «5».", "Поздравляем!");
                        Properties.Settings.Default.ThirdMark = 5;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data4.xml"))
                    {
                        MessageBox.Show($"Отлично! Вы прошли тест на оценку «5».", "Поздравляем!");
                        Properties.Settings.Default.FourthMark = 5;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data5.xml"))
                    {
                        MessageBox.Show($"Отлично! Вы прошли тест на оценку «5».", "Поздравляем!");
                        Properties.Settings.Default.FifthMark = 5;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data6.xml"))
                    {
                        MessageBox.Show($"Отлично! Вы прошли тест на оценку «5».", "Поздравляем!");
                        Properties.Settings.Default.SixthMark = 5;
                        Properties.Settings.Default.Save();
                    }
                }

                else if ((successAnswer / 10) * 100 >= 70 && (successAnswer / 10) * 100 < 90)
                {
                    if (FN == (Directory.GetCurrentDirectory() + @"\Test\data.xml"))
                    {
                        MessageBox.Show($"Хорошо! Вы прошли тест на оценку «4».", "Хорошо!");
                        Properties.Settings.Default.FirstMark = 4;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data2.xml"))
                    {
                        MessageBox.Show($"Хорошо! Вы прошли тест на оценку «4».", "Хорошо!");
                        Properties.Settings.Default.SecondMark = 4;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data3.xml"))
                    {
                        MessageBox.Show($"Хорошо! Вы прошли тест на оценку «4».", "Хорошо!");
                        Properties.Settings.Default.ThirdMark = 4;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data4.xml"))
                    {
                        MessageBox.Show($"Хорошо! Вы прошли тест на оценку «4».", "Хорошо!");
                        Properties.Settings.Default.FourthMark = 4;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data5.xml"))
                    {
                        MessageBox.Show($"Хорошо! Вы прошли тест на оценку «4».", "Хорошо!");
                        Properties.Settings.Default.FifthMark = 4;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data6.xml"))
                    {
                        MessageBox.Show($"Хорошо! Вы прошли тест на оценку «4».", "Хорошо!");
                        Properties.Settings.Default.SixthMark = 4;
                        Properties.Settings.Default.Save();
                    }
                }

                else if ((successAnswer / 10) * 100 >= 60 && (successAnswer / 10) * 100 < 70)
                {
                    if (FN == (Directory.GetCurrentDirectory() + @"\Test\data.xml"))
                    {
                        MessageBox.Show($"Неплохо! Вы прошли тест на оценку «3».", "Неплохо!");
                        Properties.Settings.Default.FirstMark = 3;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data2.xml"))
                    {
                        MessageBox.Show($"Неплохо! Вы прошли тест на оценку «3».", "Неплохо!");
                        Properties.Settings.Default.SecondMark = 3;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data3.xml"))
                    {
                        MessageBox.Show($"Неплохо! Вы прошли тест на оценку «3».", "Неплохо!");
                        Properties.Settings.Default.ThirdMark = 3;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data4.xml"))
                    {
                        MessageBox.Show($"Неплохо! Вы прошли тест на оценку «3».", "Неплохо!");
                        Properties.Settings.Default.FourthMark = 3;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data5.xml"))
                    {
                        MessageBox.Show($"Неплохо! Вы прошли тест на оценку «3».", "Неплохо!");
                        Properties.Settings.Default.FifthMark = 3;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data6.xml"))
                    {
                        MessageBox.Show($"Неплохо! Вы прошли тест на оценку «3».", "Неплохо!");
                        Properties.Settings.Default.SixthMark = 3;
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    if (FN == (Directory.GetCurrentDirectory() + @"\Test\data.xml"))
                    {
                        MessageBox.Show($"Плохо! Вы прошли тест на оценку «2».", "Плохо!");
                        Properties.Settings.Default.FirstMark = 2;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data2.xml"))
                    {
                        MessageBox.Show($"Плохо! Вы прошли тест на оценку «2».", "Плохо!");
                        Properties.Settings.Default.SecondMark = 2;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data3.xml"))
                    {
                        MessageBox.Show($"Плохо! Вы прошли тест на оценку «2».", "Плохо!");
                        Properties.Settings.Default.ThirdMark = 2;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data4.xml"))
                    {
                        MessageBox.Show($"Плохо! Вы прошли тест на оценку «2».", "Плохо!");
                        Properties.Settings.Default.FourthMark = 2;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data5.xml"))
                    {
                        MessageBox.Show($"Плохо! Вы прошли тест на оценку «2».", "Плохо!");
                        Properties.Settings.Default.FifthMark = 2;
                        Properties.Settings.Default.Save();
                    }
                    else if (FN == (Directory.GetCurrentDirectory() + @"\Test\data6.xml"))
                    {
                        MessageBox.Show($"Плохо! Вы прошли тест на оценку «2».", "Плохо!");
                        Properties.Settings.Default.SixthMark = 2;
                        Properties.Settings.Default.Save();
                    }
                }
                Close();
            }
        }
        public void GetXml()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(FN);
            XmlElement xRoot = xDoc.DocumentElement;
            try
            {
                if (xRoot != null)
                {
                    Question.Text = "Вопрос " + counter;
                    XmlNodeList a = xDoc.GetElementsByTagName("question");
                    XmlNode question1 = a.Item(mass[arr]).Attributes.GetNamedItem("question1");
                    Question.Text = question1.Value;
                    if (a.Item(mass[arr]).Attributes["type"].Value == "WithRB")
                    {
                        counter++;
                        questiontime.Text = "Время ответа: 30 секунд";
                        secTick = 30;
                        timer1.Start();
                        answerRadioButton1.Visible = true;
                        answerRadioButton2.Visible = true;
                        answerRadioButton3.Visible = true;
                        answerRadioButton4.Visible = true;
                        success = a.Item(mass[arr]).Attributes.GetNamedItem("true");
                        XmlNode answer1 = a.Item(mass[arr]).Attributes.GetNamedItem("answer1");
                        XmlNode answer2 = a.Item(mass[arr]).Attributes.GetNamedItem("answer2");
                        XmlNode answer3 = a.Item(mass[arr]).Attributes.GetNamedItem("answer3");
                        XmlNode answer4 = a.Item(mass[arr]).Attributes.GetNamedItem("answer4");
                        answerRadioButton1.Text = answer1.Value;
                        answerRadioButton2.Text = answer2.Value;
                        answerRadioButton3.Text = answer3.Value;
                        answerRadioButton4.Text = answer4.Value;
                    }
                    else if (a.Item(mass[arr]).Attributes["type"].Value == "WithCHB")
                    {
                        counter++;
                        questiontime.Text = "Время ответа: 60 секунд";
                        secTick = 60;
                        timer1.Start();
                        checkBox1.Visible = true;
                        checkBox2.Visible = true;
                        checkBox3.Visible = true;
                        checkBox4.Visible = true;
                        success = a.Item(mass[arr]).Attributes.GetNamedItem("true");
                        XmlNode answer1 = a.Item(mass[arr]).Attributes.GetNamedItem("answer1");
                        XmlNode answer2 = a.Item(mass[arr]).Attributes.GetNamedItem("answer2");
                        XmlNode answer3 = a.Item(mass[arr]).Attributes.GetNamedItem("answer3");
                        XmlNode answer4 = a.Item(mass[arr]).Attributes.GetNamedItem("answer4");
                        checkBox1.Text = answer1.Value;
                        checkBox2.Text = answer2.Value;
                        checkBox3.Text = answer3.Value;
                        checkBox4.Text = answer4.Value;
                    }
                    else if (a.Item(mass[arr]).Attributes["type"].Value == "WithTB")
                    {
                        counter++;
                        questiontime.Text = "Время ответа: 90 секунд";
                        secTick = 90;
                        timer1.Start();
                        textBox1.Visible = true;
                        success = a.Item(mass[arr]).Attributes.GetNamedItem("true");
                    }
                }
            }
            catch (Exception)
            {
            }

        }
        private void Invisible()
        {
            answerRadioButton1.Visible = false;
            answerRadioButton2.Visible = false;
            answerRadioButton3.Visible = false;
            answerRadioButton4.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            textBox1.Visible = false;
            answerRadioButton1.Checked = false;
            answerRadioButton2.Checked = false;
            answerRadioButton3.Checked = false;
            answerRadioButton4.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox1.Text = "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secTick = secTick - 1;
            if (secTick < 10) spendedLabel.Text = " " + secTick.ToString();
            else spendedLabel.Text = secTick.ToString();
            if (answerRadioButton1.Visible == true)
            {
                if (secTick <= 0)
                {
                    secTick = 0;
                    AnswerlButton_Click(this, EventArgs.Empty);
                    timer1.Stop();
                    timer1.Start();
                }
            }
            else if (textBox1.Visible == true)
            {
                if (secTick <= 0)
                {
                    secTick = 0;
                    AnswerlButton_Click(this, EventArgs.Empty);
                    timer1.Stop();
                    timer1.Start();
                }
            }
            else if (checkBox1.Visible == true)
            {
                if (secTick <= 0)
                {
                    secTick = 0;
                    AnswerlButton_Click(this, EventArgs.Empty);
                    timer1.Stop();
                    timer1.Start();
                }
            }
        }

        private void AnswerlButton_Click(object sender, EventArgs e)
        {
            CheckAnswers();
            Invisible();
            secTick = 0;
            timer1.Stop();
            GetXml();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = mass.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                var temp = mass[j];
                mass[j] = mass[i];
                mass[i] = temp;
            }
            Invisible();
            GetXml();
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
