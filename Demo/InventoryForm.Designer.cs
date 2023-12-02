using System.Runtime.CompilerServices;

namespace SoftwaretechInventory
{
    partial class InventoryForm
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
            pictureBox1 = new PictureBox();
            playerLevelProgress = new ProgressBar();
            playerLevelDisplay = new Label();
            weaponEquiped = new PictureBox();
            weapon1 = new PictureBox();
            weapon2 = new PictureBox();
            weapon3 = new PictureBox();
            engine3 = new PictureBox();
            engine2 = new PictureBox();
            engine1 = new PictureBox();
            engineEquiped = new PictureBox();
            shipbody1 = new PictureBox();
            shipbody2 = new PictureBox();
            shipbody3 = new PictureBox();
            shipbodyEquiped = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            backButton = new Button();
            panel1 = new Panel();
            speedDisplay = new Label();
            fireRateDisplay = new Label();
            damageDisplay = new Label();
            healtDisplay = new Label();
            speedLabel = new Label();
            fireRateLabel = new Label();
            damageLabel = new Label();
            healthLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weaponEquiped).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weapon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weapon2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weapon3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engine3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engineEquiped).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipbody1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipbody2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipbody3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipbodyEquiped).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GrayText;
            pictureBox1.Location = new Point(223, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 243);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // playerLevelProgress
            // 
            playerLevelProgress.Location = new Point(198, 42);
            playerLevelProgress.Name = "playerLevelProgress";
            playerLevelProgress.Size = new Size(204, 14);
            playerLevelProgress.Style = ProgressBarStyle.Continuous;
            playerLevelProgress.TabIndex = 5;
            // 
            // playerLevelDisplay
            // 
            playerLevelDisplay.AutoSize = true;
            playerLevelDisplay.BackColor = SystemColors.WindowText;
            playerLevelDisplay.ForeColor = Color.FromArgb(0, 192, 0);
            playerLevelDisplay.Location = new Point(289, 24);
            playerLevelDisplay.Name = "playerLevelDisplay";
            playerLevelDisplay.Size = new Size(27, 15);
            playerLevelDisplay.TabIndex = 6;
            playerLevelDisplay.Text = "text";
            // 
            // weaponEquiped
            // 
            weaponEquiped.BackColor = SystemColors.AppWorkspace;
            weaponEquiped.Location = new Point(386, 94);
            weaponEquiped.Name = "weaponEquiped";
            weaponEquiped.Size = new Size(40, 40);
            weaponEquiped.SizeMode = PictureBoxSizeMode.StretchImage;
            weaponEquiped.TabIndex = 7;
            weaponEquiped.TabStop = false;
            // 
            // weapon1
            // 
            weapon1.BackColor = SystemColors.AppWorkspace;
            weapon1.Location = new Point(443, 94);
            weapon1.Name = "weapon1";
            weapon1.Size = new Size(40, 40);
            weapon1.SizeMode = PictureBoxSizeMode.StretchImage;
            weapon1.TabIndex = 8;
            weapon1.TabStop = false;
            weapon1.Click += weapon_Click;
            // 
            // weapon2
            // 
            weapon2.BackColor = SystemColors.AppWorkspace;
            weapon2.Location = new Point(489, 94);
            weapon2.Name = "weapon2";
            weapon2.Size = new Size(40, 40);
            weapon2.SizeMode = PictureBoxSizeMode.StretchImage;
            weapon2.TabIndex = 9;
            weapon2.TabStop = false;
            weapon2.Click += weapon_Click;
            // 
            // weapon3
            // 
            weapon3.BackColor = SystemColors.AppWorkspace;
            weapon3.Location = new Point(535, 94);
            weapon3.Name = "weapon3";
            weapon3.Size = new Size(40, 40);
            weapon3.SizeMode = PictureBoxSizeMode.StretchImage;
            weapon3.TabIndex = 10;
            weapon3.TabStop = false;
            weapon3.Click += weapon_Click;
            // 
            // engine3
            // 
            engine3.BackColor = SystemColors.AppWorkspace;
            engine3.Location = new Point(535, 279);
            engine3.Name = "engine3";
            engine3.Size = new Size(40, 40);
            engine3.TabIndex = 14;
            engine3.TabStop = false;
            // 
            // engine2
            // 
            engine2.BackColor = SystemColors.AppWorkspace;
            engine2.Location = new Point(489, 279);
            engine2.Name = "engine2";
            engine2.Size = new Size(40, 40);
            engine2.TabIndex = 13;
            engine2.TabStop = false;
            // 
            // engine1
            // 
            engine1.BackColor = SystemColors.AppWorkspace;
            engine1.Location = new Point(443, 279);
            engine1.Name = "engine1";
            engine1.Size = new Size(40, 40);
            engine1.TabIndex = 12;
            engine1.TabStop = false;
            // 
            // engineEquiped
            // 
            engineEquiped.BackColor = SystemColors.AppWorkspace;
            engineEquiped.Location = new Point(386, 279);
            engineEquiped.Name = "engineEquiped";
            engineEquiped.Size = new Size(40, 40);
            engineEquiped.TabIndex = 11;
            engineEquiped.TabStop = false;
            // 
            // shipbody1
            // 
            shipbody1.BackColor = SystemColors.AppWorkspace;
            shipbody1.Location = new Point(116, 203);
            shipbody1.Name = "shipbody1";
            shipbody1.Size = new Size(40, 40);
            shipbody1.TabIndex = 18;
            shipbody1.TabStop = false;
            // 
            // shipbody2
            // 
            shipbody2.BackColor = SystemColors.AppWorkspace;
            shipbody2.Location = new Point(70, 203);
            shipbody2.Name = "shipbody2";
            shipbody2.Size = new Size(40, 40);
            shipbody2.TabIndex = 17;
            shipbody2.TabStop = false;
            // 
            // shipbody3
            // 
            shipbody3.BackColor = SystemColors.AppWorkspace;
            shipbody3.Location = new Point(24, 203);
            shipbody3.Name = "shipbody3";
            shipbody3.Size = new Size(40, 40);
            shipbody3.TabIndex = 16;
            shipbody3.TabStop = false;
            // 
            // shipbodyEquiped
            // 
            shipbodyEquiped.BackColor = SystemColors.AppWorkspace;
            shipbodyEquiped.Location = new Point(172, 203);
            shipbodyEquiped.Name = "shipbodyEquiped";
            shipbodyEquiped.Size = new Size(40, 40);
            shipbodyEquiped.TabIndex = 15;
            shipbodyEquiped.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(382, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 19;
            label1.Text = "Equiped";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(381, 261);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 20;
            label2.Text = "Equiped";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(167, 185);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 21;
            label3.Text = "Equiped";
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.MenuHighlight;
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 22;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(speedDisplay);
            panel1.Controls.Add(fireRateDisplay);
            panel1.Controls.Add(damageDisplay);
            panel1.Controls.Add(healtDisplay);
            panel1.Controls.Add(speedLabel);
            panel1.Controls.Add(fireRateLabel);
            panel1.Controls.Add(damageLabel);
            panel1.Controls.Add(healthLabel);
            panel1.Location = new Point(12, 389);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 160);
            panel1.TabIndex = 23;
            // 
            // speedDisplay
            // 
            speedDisplay.AutoSize = true;
            speedDisplay.Location = new Point(113, 110);
            speedDisplay.Name = "speedDisplay";
            speedDisplay.Size = new Size(0, 15);
            speedDisplay.TabIndex = 7;
            // 
            // fireRateDisplay
            // 
            fireRateDisplay.AutoSize = true;
            fireRateDisplay.Location = new Point(113, 80);
            fireRateDisplay.Name = "fireRateDisplay";
            fireRateDisplay.Size = new Size(0, 15);
            fireRateDisplay.TabIndex = 6;
            // 
            // damageDisplay
            // 
            damageDisplay.AutoSize = true;
            damageDisplay.Location = new Point(113, 50);
            damageDisplay.Name = "damageDisplay";
            damageDisplay.Size = new Size(0, 15);
            damageDisplay.TabIndex = 5;
            // 
            // healtDisplay
            // 
            healtDisplay.AutoSize = true;
            healtDisplay.Location = new Point(115, 20);
            healtDisplay.Name = "healtDisplay";
            healtDisplay.Size = new Size(0, 15);
            healtDisplay.TabIndex = 4;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new Point(29, 110);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(39, 15);
            speedLabel.TabIndex = 3;
            speedLabel.Text = "Speed";
            // 
            // fireRateLabel
            // 
            fireRateLabel.AutoSize = true;
            fireRateLabel.Location = new Point(28, 80);
            fireRateLabel.Name = "fireRateLabel";
            fireRateLabel.Size = new Size(52, 15);
            fireRateLabel.TabIndex = 2;
            fireRateLabel.Text = "Fire Rate";
            // 
            // damageLabel
            // 
            damageLabel.AutoSize = true;
            damageLabel.Location = new Point(29, 50);
            damageLabel.Name = "damageLabel";
            damageLabel.Size = new Size(51, 15);
            damageLabel.TabIndex = 1;
            damageLabel.Text = "Damage";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.Location = new Point(29, 20);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(42, 15);
            healthLabel.TabIndex = 0;
            healthLabel.Text = "Health";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(584, 561);
            Controls.Add(panel1);
            Controls.Add(backButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(shipbody1);
            Controls.Add(shipbody2);
            Controls.Add(shipbody3);
            Controls.Add(shipbodyEquiped);
            Controls.Add(engine3);
            Controls.Add(engine2);
            Controls.Add(engine1);
            Controls.Add(engineEquiped);
            Controls.Add(weapon3);
            Controls.Add(weapon2);
            Controls.Add(weapon1);
            Controls.Add(weaponEquiped);
            Controls.Add(playerLevelDisplay);
            Controls.Add(playerLevelProgress);
            Controls.Add(pictureBox1);
            Name = "InventoryForm";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)weaponEquiped).EndInit();
            ((System.ComponentModel.ISupportInitialize)weapon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)weapon2).EndInit();
            ((System.ComponentModel.ISupportInitialize)weapon3).EndInit();
            ((System.ComponentModel.ISupportInitialize)engine3).EndInit();
            ((System.ComponentModel.ISupportInitialize)engine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)engine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)engineEquiped).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipbody1).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipbody2).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipbody3).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipbodyEquiped).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar playerLevelProgress;
        private Label playerLevelDisplay;
        private PictureBox weaponEquiped;
        private PictureBox weapon1;
        private PictureBox weapon2;
        private PictureBox weapon3;
        private PictureBox engine3;
        private PictureBox engine2;
        private PictureBox engine1;
        private PictureBox engineEquiped;
        private PictureBox shipbody1;
        private PictureBox shipbody2;
        private PictureBox shipbody3;
        private PictureBox shipbodyEquiped;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button backButton;
        private Panel panel1;
        private Label speedLabel;
        private Label fireRateLabel;
        private Label damageLabel;
        private Label healthLabel;
        private Label speedDisplay;
        private Label fireRateDisplay;
        private Label damageDisplay;
        private Label healtDisplay;
    }
}