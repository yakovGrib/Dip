namespace R7_Office
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.ClosePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.questiontime = new System.Windows.Forms.Label();
            this.AnswerlButton = new System.Windows.Forms.Button();
            this.spendedLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Question = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.answerRadioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.answerRadioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.answerRadioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.answerRadioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Image = global::R7_Office.Properties.Resources.minimize;
            this.MinimizePictureBox.Location = new System.Drawing.Point(1036, 8);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(52, 53);
            this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePictureBox.TabIndex = 25;
            this.MinimizePictureBox.TabStop = false;
            // 
            // ClosePictureBox
            // 
            this.ClosePictureBox.Image = global::R7_Office.Properties.Resources.Close;
            this.ClosePictureBox.Location = new System.Drawing.Point(1089, 8);
            this.ClosePictureBox.Name = "ClosePictureBox";
            this.ClosePictureBox.Size = new System.Drawing.Size(52, 53);
            this.ClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePictureBox.TabIndex = 24;
            this.ClosePictureBox.TabStop = false;
            this.ClosePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(226, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 74);
            this.label1.TabIndex = 23;
            this.label1.Text = "Электронное пособие \r\n\"Основы работы R7-Офис. Редактор таблиц\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::R7_Office.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.Question);
            this.panel3.Location = new System.Drawing.Point(3, 152);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(1138, 214);
            this.panel3.TabIndex = 52;
            // 
            // questiontime
            // 
            this.questiontime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questiontime.AutoSize = true;
            this.questiontime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.questiontime.ForeColor = System.Drawing.Color.Black;
            this.questiontime.Location = new System.Drawing.Point(6, 382);
            this.questiontime.Name = "questiontime";
            this.questiontime.Size = new System.Drawing.Size(192, 29);
            this.questiontime.TabIndex = 53;
            this.questiontime.Text = "Время ответа:";
            // 
            // AnswerlButton
            // 
            this.AnswerlButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerlButton.Location = new System.Drawing.Point(939, 375);
            this.AnswerlButton.Name = "AnswerlButton";
            this.AnswerlButton.Size = new System.Drawing.Size(194, 44);
            this.AnswerlButton.TabIndex = 54;
            this.AnswerlButton.Text = "Следующий вопрос";
            this.AnswerlButton.UseVisualStyleBackColor = true;
            this.AnswerlButton.Click += new System.EventHandler(this.AnswerlButton_Click);
            // 
            // spendedLabel
            // 
            this.spendedLabel.AutoSize = true;
            this.spendedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.spendedLabel.Location = new System.Drawing.Point(574, 381);
            this.spendedLabel.Name = "spendedLabel";
            this.spendedLabel.Size = new System.Drawing.Size(27, 29);
            this.spendedLabel.TabIndex = 55;
            this.spendedLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Question
            // 
            this.Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Question.ForeColor = System.Drawing.Color.Black;
            this.Question.Location = new System.Drawing.Point(4, 4);
            this.Question.MaximumSize = new System.Drawing.Size(1140, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(88, 24);
            this.Question.TabIndex = 1;
            this.Question.Text = "Вопрос:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.answerRadioButton4);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.answerRadioButton3);
            this.panel4.Controls.Add(this.checkBox4);
            this.panel4.Controls.Add(this.answerRadioButton1);
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Controls.Add(this.answerRadioButton2);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Location = new System.Drawing.Point(8, 60);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(1121, 144);
            this.panel4.TabIndex = 56;
            // 
            // answerRadioButton4
            // 
            this.answerRadioButton4.AutoSize = true;
            this.answerRadioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.answerRadioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton4.ForeColor = System.Drawing.Color.Black;
            this.answerRadioButton4.Location = new System.Drawing.Point(4, 264);
            this.answerRadioButton4.Name = "answerRadioButton4";
            this.answerRadioButton4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.answerRadioButton4.Size = new System.Drawing.Size(1113, 33);
            this.answerRadioButton4.TabIndex = 52;
            this.answerRadioButton4.TabStop = true;
            this.answerRadioButton4.Text = "AnsweradioButton3";
            this.answerRadioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(4, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1113, 29);
            this.textBox1.TabIndex = 58;
            // 
            // answerRadioButton3
            // 
            this.answerRadioButton3.AutoSize = true;
            this.answerRadioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.answerRadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton3.ForeColor = System.Drawing.Color.Black;
            this.answerRadioButton3.Location = new System.Drawing.Point(4, 202);
            this.answerRadioButton3.Name = "answerRadioButton3";
            this.answerRadioButton3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.answerRadioButton3.Size = new System.Drawing.Size(1113, 33);
            this.answerRadioButton3.TabIndex = 51;
            this.answerRadioButton3.TabStop = true;
            this.answerRadioButton3.Text = "да";
            this.answerRadioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.Black;
            this.checkBox4.Location = new System.Drawing.Point(4, 169);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.checkBox4.Size = new System.Drawing.Size(1113, 33);
            this.checkBox4.TabIndex = 57;
            this.checkBox4.Text = "checkBox5";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton1
            // 
            this.answerRadioButton1.AutoSize = true;
            this.answerRadioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.answerRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton1.ForeColor = System.Drawing.Color.Black;
            this.answerRadioButton1.Location = new System.Drawing.Point(4, 136);
            this.answerRadioButton1.Name = "answerRadioButton1";
            this.answerRadioButton1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.answerRadioButton1.Size = new System.Drawing.Size(1113, 33);
            this.answerRadioButton1.TabIndex = 50;
            this.answerRadioButton1.TabStop = true;
            this.answerRadioButton1.Text = "radioButton1";
            this.answerRadioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.Black;
            this.checkBox3.Location = new System.Drawing.Point(4, 103);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.checkBox3.Size = new System.Drawing.Size(1113, 33);
            this.checkBox3.TabIndex = 56;
            this.checkBox3.Text = "checkBox6";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton2
            // 
            this.answerRadioButton2.AutoSize = true;
            this.answerRadioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.answerRadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton2.ForeColor = System.Drawing.Color.Black;
            this.answerRadioButton2.Location = new System.Drawing.Point(4, 70);
            this.answerRadioButton2.Name = "answerRadioButton2";
            this.answerRadioButton2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.answerRadioButton2.Size = new System.Drawing.Size(1113, 33);
            this.answerRadioButton2.TabIndex = 53;
            this.answerRadioButton2.TabStop = true;
            this.answerRadioButton2.Text = "radioButton4";
            this.answerRadioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(4, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.checkBox1.Size = new System.Drawing.Size(1113, 33);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "checkBox7";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.checkBox2.Size = new System.Drawing.Size(1113, 33);
            this.checkBox2.TabIndex = 54;
            this.checkBox2.Text = "checkBox8";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1145, 427);
            this.Controls.Add(this.spendedLabel);
            this.Controls.Add(this.AnswerlButton);
            this.Controls.Add(this.questiontime);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MinimizePictureBox);
            this.Controls.Add(this.ClosePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox ClosePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label questiontime;
        private System.Windows.Forms.Button AnswerlButton;
        private System.Windows.Forms.Label spendedLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton answerRadioButton4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton answerRadioButton3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.RadioButton answerRadioButton1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton answerRadioButton2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}