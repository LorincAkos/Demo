namespace Demo
{
    partial class Sound
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
            volumeTrackBar = new TrackBar();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            volumeTrackBar2 = new TrackBar();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar2).BeginInit();
            SuspendLayout();
            // 
            // volumeTrackBar
            // 
            volumeTrackBar.BackColor = SystemColors.ControlDarkDark;
            volumeTrackBar.Location = new Point(278, 94);
            volumeTrackBar.Maximum = 100;
            volumeTrackBar.Name = "volumeTrackBar";
            volumeTrackBar.Size = new Size(184, 45);
            volumeTrackBar.TabIndex = 0;
            volumeTrackBar.TickFrequency = 10;
            volumeTrackBar.Value = 50;
            volumeTrackBar.Scroll += volumeTrackBar_Scroll;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 561);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(24, 509);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(278, 75);
            label2.Name = "label2";
            label2.Size = new Size(106, 16);
            label2.TabIndex = 2;
            label2.Text = "Music sounds";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(278, 191);
            label3.Name = "label3";
            label3.Size = new Size(116, 16);
            label3.TabIndex = 4;
            label3.Text = "Effects Sounds";
            // 
            // volumeTrackBar2
            // 
            volumeTrackBar2.BackColor = SystemColors.ControlDarkDark;
            volumeTrackBar2.Location = new Point(278, 210);
            volumeTrackBar2.Maximum = 100;
            volumeTrackBar2.Name = "volumeTrackBar2";
            volumeTrackBar2.Size = new Size(184, 45);
            volumeTrackBar2.TabIndex = 3;
            volumeTrackBar2.TickFrequency = 10;
            volumeTrackBar2.Value = 50;
            volumeTrackBar2.Scroll += volumeTrackBar2_Scroll;
            // 
            // button2
            // 
            button2.Location = new Point(468, 94);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 2;
            button2.Text = "TestMusic";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(468, 210);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 5;
            button3.Text = "TestSFX";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Sound
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(584, 561);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(volumeTrackBar2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(volumeTrackBar);
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
            Name = "Sound";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        public TrackBar volumeTrackBar;
        private Label label3;
        public TrackBar volumeTrackBar2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}