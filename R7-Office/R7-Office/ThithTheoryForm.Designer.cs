namespace R7_Office
{
    partial class ThithTheoryForm
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
            this.ThithTheoryRichTextBox = new System.Windows.Forms.RichTextBox();
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
            this.label1.TabIndex = 19;
            this.label1.Text = "Электронное пособие \r\n\"Основы работы R7-Офис. Редактор таблиц\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThithTheoryRichTextBox
            // 
            this.ThithTheoryRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThithTheoryRichTextBox.Location = new System.Drawing.Point(9, 136);
            this.ThithTheoryRichTextBox.Name = "ThithTheoryRichTextBox";
            this.ThithTheoryRichTextBox.ReadOnly = true;
            this.ThithTheoryRichTextBox.Size = new System.Drawing.Size(1126, 637);
            this.ThithTheoryRichTextBox.TabIndex = 17;
            this.ThithTheoryRichTextBox.Text = "";
            this.ThithTheoryRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThithTheoryRichTextBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::R7_Office.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Image = global::R7_Office.Properties.Resources.minimize;
            this.MinimizePictureBox.Location = new System.Drawing.Point(1033, 5);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(52, 53);
            this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePictureBox.TabIndex = 21;
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
            this.ClosePictureBox.TabIndex = 20;
            this.ClosePictureBox.TabStop = false;
            this.ClosePictureBox.Click += new System.EventHandler(this.ClosePictureBox_Click);
            // 
            // ThithTheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1145, 783);
            this.Controls.Add(this.MinimizePictureBox);
            this.Controls.Add(this.ClosePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThithTheoryRichTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThithTheoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пятый раздел теории";
            this.Load += new System.EventHandler(this.ThithTheoryForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThithTheoryForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThithTheoryForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThithTheoryForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ThithTheoryRichTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox ClosePictureBox;
    }
}