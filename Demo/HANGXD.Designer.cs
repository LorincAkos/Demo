namespace hangcucc
{
    partial class HANGXD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            volumeTrackBar2 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar2).BeginInit();
            SuspendLayout();
            // 
            // volumeTrackBar
            // 
            volumeTrackBar.BackColor = SystemColors.ControlDarkDark;
            volumeTrackBar.Location = new Point(250, 53);
            volumeTrackBar.Maximum = 100;
            volumeTrackBar.Name = "volumeTrackBar";
            volumeTrackBar.Size = new Size(380, 45);
            volumeTrackBar.TabIndex = 0;
            volumeTrackBar.TickFrequency = 10;
            volumeTrackBar.Value = 50;
            volumeTrackBar.Scroll += volumeTrackBar_Scroll;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 447);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Beállitások";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(419, 34);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 2;
            label2.Text = "Zene Hang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(392, 136);
            label3.Name = "label3";
            label3.Size = new Size(139, 16);
            label3.TabIndex = 4;
            label3.Text = "Minden más Hang";
            // 
            // volumeTrackBar2
            // 
            volumeTrackBar2.BackColor = SystemColors.ControlDarkDark;
            volumeTrackBar2.Location = new Point(250, 155);
            volumeTrackBar2.Maximum = 100;
            volumeTrackBar2.Name = "volumeTrackBar2";
            volumeTrackBar2.Size = new Size(380, 45);
            volumeTrackBar2.TabIndex = 3;
            volumeTrackBar2.TickFrequency = 10;
            volumeTrackBar2.Value = 50;
            volumeTrackBar2.Scroll += volumeTrackBar2_Scroll;
            // 
            // HANGXD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(volumeTrackBar2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(volumeTrackBar);
            Name = "HANGXD";
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
    }
}