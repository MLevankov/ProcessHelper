namespace ProcessHelper
{
    partial class Run
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            browseDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(432, 26);
            label1.TabIndex = 0;
            label1.Text = "Type the name of a program, folder, document, or\r\nInternet resource, and Process Helper will open it for you";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.run;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(46, 13);
            label2.TabIndex = 2;
            label2.Text = "Open:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 52);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(381, 17);
            button3.Name = "button3";
            button3.Size = new Size(112, 23);
            button3.TabIndex = 2;
            button3.Text = "Browse...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(263, 17);
            button2.Name = "button2";
            button2.Size = new Size(112, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(145, 17);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // browseDialog
            // 
            browseDialog.DefaultExt = "*.*";
            browseDialog.Filter = "All files|*.*";
            browseDialog.Title = "Browse...";
            // 
            // Run
            // 
            AutoScaleDimensions = new SizeF(9F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 158);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Run";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Run";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private OpenFileDialog browseDialog;
    }
}