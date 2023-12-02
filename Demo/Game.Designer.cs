namespace Demo
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            BG_Timer = new System.Windows.Forms.Timer(components);
            Ammo_Move_Timer = new System.Windows.Forms.Timer(components);
            Player_Down_Timer = new System.Windows.Forms.Timer(components);
            Player_Up_Timer = new System.Windows.Forms.Timer(components);
            Hit_Timer = new System.Windows.Forms.Timer(components);
            Player_Right_Timer = new System.Windows.Forms.Timer(components);
            Enemy_Move_Timer = new System.Windows.Forms.Timer(components);
            Player_Left_Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // BG_Timer
            // 
            BG_Timer.Enabled = true;
            BG_Timer.Interval = 60;
            BG_Timer.Tick += BG_Timer_Tick;
            // 
            // Ammo_Move_Timer
            // 
            Ammo_Move_Timer.Interval = 50;
            Ammo_Move_Timer.Tick += Ammo_Move_Timer_Tick;
            // 
            // Player_Down_Timer
            // 
            Player_Down_Timer.Interval = 5;
            Player_Down_Timer.Tick += Player_Down_Timer_Tick_1;
            // 
            // Player_Up_Timer
            // 
            Player_Up_Timer.Interval = 5;
            Player_Up_Timer.Tick += Player_Up_Timer_Tick_1;
            // 
            // Hit_Timer
            // 
            Hit_Timer.Interval = 1;
            Hit_Timer.Tick += Hit_Timer_Tick;
            // 
            // Player_Right_Timer
            // 
            Player_Right_Timer.Interval = 5;
            Player_Right_Timer.Tick += Player_Right_Timer_Tick_1;
            // 
            // Enemy_Move_Timer
            // 
            Enemy_Move_Timer.Interval = 10;
            Enemy_Move_Timer.Tick += Enemy_Move_Timer_Tick_1;
            // 
            // Player_Left_Timer
            // 
            Player_Left_Timer.Interval = 5;
            Player_Left_Timer.Tick += Player_Left_Timer_Tick_1;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(584, 561);
            DoubleBuffered = true;
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
            Name = "Game";
            Text = "Game";
            Paint += Game_Paint;
            KeyDown += Game_KeyDown;
            KeyUp += Game_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer BG_Timer;
        private System.Windows.Forms.Timer Ammo_Move_Timer;
        private System.Windows.Forms.Timer Player_Down_Timer;
        private System.Windows.Forms.Timer Player_Up_Timer;
        private System.Windows.Forms.Timer Hit_Timer;
        private System.Windows.Forms.Timer Player_Right_Timer;
        private System.Windows.Forms.Timer Enemy_Move_Timer;
        private System.Windows.Forms.Timer Player_Left_Timer;
    }
}