namespace Demo
{
    partial class Base
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
            NameLabel = new Label();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(217, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(0, 65);
            NameLabel.TabIndex = 0;
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(584, 561);
            Controls.Add(NameLabel);
            DoubleBuffered = true;
            ForeColor = Color.Yellow;
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
            Name = "Base";
            Text = "Base";
            Paint += Base_Paint;
            MouseClick += Base_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
    }
}