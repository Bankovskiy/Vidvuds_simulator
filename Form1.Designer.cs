﻿namespace WASD_controllerWithTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            hero = new PictureBox();
            timerMain = new System.Windows.Forms.Timer(components);
            food1 = new PictureBox();
            food2 = new PictureBox();
            food3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)hero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)food1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)food2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)food3).BeginInit();
            SuspendLayout();
            // 
            // hero
            // 
            hero.BackColor = Color.FromArgb(128, 255, 128);
            hero.BackgroundImage = (Image)resources.GetObject("hero.BackgroundImage");
            hero.Image = (Image)resources.GetObject("hero.Image");
            hero.Location = new Point(498, 422);
            hero.Name = "hero";
            hero.Size = new Size(234, 220);
            hero.SizeMode = PictureBoxSizeMode.StretchImage;
            hero.TabIndex = 0;
            hero.TabStop = false;
            // 
            // timerMain
            // 
            timerMain.Interval = 50;
            timerMain.Tick += timerMain_Tick;
            // 
            // food1
            // 
            food1.BackColor = Color.Transparent;
            food1.Image = (Image)resources.GetObject("food1.Image");
            food1.Location = new Point(55, 307);
            food1.Name = "food1";
            food1.Size = new Size(100, 100);
            food1.SizeMode = PictureBoxSizeMode.StretchImage;
            food1.TabIndex = 1;
            food1.TabStop = false;
            food1.Click += food1_Click;
            // 
            // food2
            // 
            food2.BackColor = Color.Transparent;
            food2.Image = (Image)resources.GetObject("food2.Image");
            food2.Location = new Point(733, 61);
            food2.Name = "food2";
            food2.Size = new Size(100, 100);
            food2.SizeMode = PictureBoxSizeMode.StretchImage;
            food2.TabIndex = 2;
            food2.TabStop = false;
            // 
            // food3
            // 
            food3.BackColor = Color.Transparent;
            food3.Image = (Image)resources.GetObject("food3.Image");
            food3.Location = new Point(1027, 588);
            food3.Name = "food3";
            food3.Size = new Size(100, 100);
            food3.SizeMode = PictureBoxSizeMode.StretchImage;
            food3.TabIndex = 3;
            food3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(322, 28);
            label1.TabIndex = 4;
            label1.Text = "WASD to move (like in snake game)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 6;
            label2.Text = "P to pause";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(226, 28);
            label3.TabIndex = 7;
            label3.Text = "+ and - to change speed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1220, 753);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(food3);
            Controls.Add(food2);
            Controls.Add(food1);
            Controls.Add(hero);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "vidvudiņa simulātoriņš āboļu pasauliņā";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)hero).EndInit();
            ((System.ComponentModel.ISupportInitialize)food1).EndInit();
            ((System.ComponentModel.ISupportInitialize)food2).EndInit();
            ((System.ComponentModel.ISupportInitialize)food3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox hero;
        private System.Windows.Forms.Timer timerMain;
        private PictureBox food1;
        private PictureBox food2;
        private PictureBox food3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}