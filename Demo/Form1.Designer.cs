namespace Demo
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
            BG_Timer = new System.Windows.Forms.Timer(components);
            Player_Left_Timer = new System.Windows.Forms.Timer(components);
            Player_Right_Timer = new System.Windows.Forms.Timer(components);
            Player_Up_Timer = new System.Windows.Forms.Timer(components);
            Player_Down_Timer = new System.Windows.Forms.Timer(components);
            Enemy_Move_Timer = new System.Windows.Forms.Timer(components);
            Hit_Timer = new System.Windows.Forms.Timer(components);
            Ammo_Move_Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // BG_Timer
            // 
            BG_Timer.Enabled = true;
            BG_Timer.Interval = 60;
            BG_Timer.Tick += BG_Timer_Tick;
            // 
            // Player_Left_Timer
            // 
            Player_Left_Timer.Interval = 5;
            Player_Left_Timer.Tick += Player_Left_Timer_Tick;
            // 
            // Player_Right_Timer
            // 
            Player_Right_Timer.Interval = 5;
            Player_Right_Timer.Tick += Player_Right_Timer_Tick;
            // 
            // Player_Up_Timer
            // 
            Player_Up_Timer.Interval = 5;
            Player_Up_Timer.Tick += Player_Up_Timer_Tick;
            // 
            // Player_Down_Timer
            // 
            Player_Down_Timer.Interval = 5;
            Player_Down_Timer.Tick += Player_Down_Timer_Tick;
            // 
            // Enemy_Move_Timer
            // 
            Enemy_Move_Timer.Interval = 16;
            Enemy_Move_Timer.Tick += Enemy_Move_Timer_Tick;
            // 
            // Hit_Timer
            // 
            Hit_Timer.Interval = 1;
            Hit_Timer.Tick += Hit_Timer_Tick;
            // 
            // Ammo_Move_Timer
            // 
            Ammo_Move_Timer.Interval = 50;
            Ammo_Move_Timer.Tick += Ammo_Move_Timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(584, 561);
            DoubleBuffered = true;
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer BG_Timer;
        private System.Windows.Forms.Timer Player_Left_Timer;
        private System.Windows.Forms.Timer Player_Right_Timer;
        private System.Windows.Forms.Timer Player_Up_Timer;
        private System.Windows.Forms.Timer Player_Down_Timer;
        private System.Windows.Forms.Timer Enemy_Move_Timer;
        private System.Windows.Forms.Timer Hit_Timer;
        private System.Windows.Forms.Timer Ammo_Move_Timer;
    }
}