namespace Delulu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            GameTick = new System.Windows.Forms.Timer(components);
            richTextBox1 = new RichTextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Cyan;
            pictureBox1.Image = Properties.Resources.iu;
            pictureBox1.Location = new Point(830, 431);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // GameTick
            // 
            GameTick.Enabled = true;
            GameTick.Interval = 500;
            GameTick.Tick += GameTick_Tick;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(383, 261);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 192, 0);
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-6, 605);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1913, 431);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(401, 14);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.FullOpen = true;
            colorDialog1.ShowHelp = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1898, 1029);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer GameTick;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ColorDialog colorDialog1;
    }
}
