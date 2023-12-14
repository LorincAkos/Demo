namespace Demo
{
    partial class Shop
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
            panel1 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            Player = new Label();
            pages = new TabControl();
            Weapons = new TabPage();
            Ships = new TabPage();
            Engines = new TabPage();
            Chests = new TabPage();
            panel1.SuspendLayout();
            pages.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Player);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 737);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.SaddleBrown;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Teal;
            button5.FlatAppearance.MouseOverBackColor = Color.Navy;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(32, 426);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(128, 53);
            button5.TabIndex = 7;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.AntiqueWhite;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Teal;
            button3.FlatAppearance.MouseOverBackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(32, 291);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(128, 53);
            button3.TabIndex = 5;
            button3.Text = "Chests";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.AntiqueWhite;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Teal;
            button4.FlatAppearance.MouseOverBackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(32, 228);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(128, 53);
            button4.TabIndex = 4;
            button4.Text = "Engines";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AntiqueWhite;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Teal;
            button2.FlatAppearance.MouseOverBackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(32, 164);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(128, 53);
            button2.TabIndex = 3;
            button2.Text = "Ships";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.AntiqueWhite;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 10;
            button1.FlatAppearance.MouseDownBackColor = Color.Teal;
            button1.FlatAppearance.MouseOverBackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(32, 101);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(128, 53);
            button1.TabIndex = 2;
            button1.Text = "Weapons";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Player
            // 
            Player.AutoSize = true;
            Player.Font = new Font("Mongolian Baiti", 17F, FontStyle.Bold, GraphicsUnit.Point);
            Player.Location = new Point(16, 13);
            Player.Margin = new Padding(5, 0, 5, 0);
            Player.Name = "Player";
            Player.Size = new Size(78, 30);
            Player.TabIndex = 1;
            Player.Text = "Shop";
            // 
            // pages
            // 
            pages.Alignment = TabAlignment.Bottom;
            pages.Controls.Add(Weapons);
            pages.Controls.Add(Ships);
            pages.Controls.Add(Engines);
            pages.Controls.Add(Chests);
            pages.Location = new Point(218, 0);
            pages.Margin = new Padding(5, 4, 5, 4);
            pages.Name = "pages";
            pages.SelectedIndex = 0;
            pages.Size = new Size(448, 748);
            pages.TabIndex = 2;
            // 
            // Weapons
            // 
            Weapons.Location = new Point(4, 4);
            Weapons.Margin = new Padding(5, 4, 5, 4);
            Weapons.Name = "Weapons";
            Weapons.Padding = new Padding(5, 4, 5, 4);
            Weapons.Size = new Size(440, 715);
            Weapons.TabIndex = 0;
            Weapons.Text = "Weapons";
            Weapons.UseVisualStyleBackColor = true;
            // 
            // Ships
            // 
            Ships.Location = new Point(4, 4);
            Ships.Margin = new Padding(5, 4, 5, 4);
            Ships.Name = "Ships";
            Ships.Padding = new Padding(5, 4, 5, 4);
            Ships.Size = new Size(440, 715);
            Ships.TabIndex = 1;
            Ships.Text = "Ships";
            Ships.UseVisualStyleBackColor = true;
            // 
            // Engines
            // 
            Engines.Location = new Point(4, 4);
            Engines.Margin = new Padding(5, 4, 5, 4);
            Engines.Name = "Engines";
            Engines.Padding = new Padding(5, 4, 5, 4);
            Engines.Size = new Size(440, 715);
            Engines.TabIndex = 2;
            Engines.Text = "Engines";
            Engines.UseVisualStyleBackColor = true;
            // 
            // Chests
            // 
            Chests.Location = new Point(4, 4);
            Chests.Margin = new Padding(5, 4, 5, 4);
            Chests.Name = "Chests";
            Chests.Padding = new Padding(5, 4, 5, 4);
            Chests.Size = new Size(440, 715);
            Chests.TabIndex = 3;
            Chests.Text = "Chests";
            Chests.UseVisualStyleBackColor = true;
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 737);
            Controls.Add(pages);
            Controls.Add(panel1);
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(683, 784);
            MinimumSize = new Size(683, 784);
            Name = "Shop";
            Text = "Shop";
            Load += Shop_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pages.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label Player;
        private TabControl pages;
        private TabPage Weapons;
        private TabPage Ships;
        private TabPage Engines;
        private TabPage Chests;
    }
}