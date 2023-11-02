namespace WASD_controllerWithTimer
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
            ((System.ComponentModel.ISupportInitialize)hero).BeginInit();
            SuspendLayout();
            // 
            // hero
            // 
            hero.BackColor = Color.FromArgb(128, 255, 128);
            hero.BackgroundImage = (Image)resources.GetObject("hero.BackgroundImage");
            hero.Image = (Image)resources.GetObject("hero.Image");
            hero.Location = new Point(498, 307);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1220, 753);
            Controls.Add(hero);
            Name = "Form1";
            Text = "WASD controller";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)hero).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox hero;
        private System.Windows.Forms.Timer timerMain;
    }
}