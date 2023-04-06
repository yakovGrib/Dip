namespace R7_Office
{
    partial class SecondTheoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SecondTheoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.ClosePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(223, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 74);
            this.label1.TabIndex = 10;
            this.label1.Text = "Электронное пособие \r\n\"Основы работы R7-Офис. Редактор таблиц\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondTheoryRichTextBox
            // 
            this.SecondTheoryRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondTheoryRichTextBox.Location = new System.Drawing.Point(9, 136);
            this.SecondTheoryRichTextBox.Name = "SecondTheoryRichTextBox";
            this.SecondTheoryRichTextBox.ReadOnly = true;
            this.SecondTheoryRichTextBox.Size = new System.Drawing.Size(1126, 637);
            this.SecondTheoryRichTextBox.TabIndex = 8;
            this.SecondTheoryRichTextBox.Text = "";
            this.SecondTheoryRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondTheoryRichTextBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::R7_Office.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Image = global::R7_Office.Properties.Resources.minimize;
            this.MinimizePictureBox.Location = new System.Drawing.Point(1033, 5);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(52, 53);
            this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePictureBox.TabIndex = 12;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            // 
            // ClosePictureBox
            // 
            this.ClosePictureBox.Image = global::R7_Office.Properties.Resources.Close;
            this.ClosePictureBox.Location = new System.Drawing.Point(1086, 5);
            this.ClosePictureBox.Name = "ClosePictureBox";
            this.ClosePictureBox.Size = new System.Drawing.Size(52, 53);
            this.ClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePictureBox.TabIndex = 11;
            this.ClosePictureBox.TabStop = false;
            this.ClosePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            // 
            // SecondTheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1145, 783);
            this.Controls.Add(this.MinimizePictureBox);
            this.Controls.Add(this.ClosePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondTheoryRichTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecondTheoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Второй раздел теории";
            this.Load += new System.EventHandler(this.SecondTheoryForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecondTheoryForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SecondTheoryForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SecondTheoryForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox SecondTheoryRichTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox ClosePictureBox;
    }
}