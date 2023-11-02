namespace WASD_controllerWithTimer
{
    public partial class Form1 : Form
    {

        private int speed = 5; //speed of the hero
        private int verticalComponent = 0; //positive value = down; negative value = up; 0 = no movement
        private int horizontalComponent = 0; //positive value = right; negative value = left; 0 = no movement

        public Form1()
        {
            InitializeComponent();
            InitializeTimer(); //STAR THE TIMER THING OMAGAD
        }

        private void InitializeTimer() //start the timer function omg
        {
            timerMain.Interval = 10;
            timerMain.Start();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            HeroMove();
            HeroWallCollider();
        }

        private void HeroMove() //hero movement function
        {
            hero.Left += horizontalComponent * speed;
            hero.Top += verticalComponent * speed;
        }

        private void HeroWallCollider() //hero collide function
        {
            if (hero.Left > ClientRectangle.Width)
            {
                hero.Left = -hero.Width;
            }
            else if (hero.Left < -hero.Width)
            {
                hero.Left = ClientRectangle.Width;
            }

            if (hero.Top > ClientRectangle.Height)
            {
                hero.Top = -hero.Height;
            }
            else if (hero.Top < -hero.Height)
            {
                hero.Top = ClientRectangle.Height;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) //moving to the left
            {
                horizontalComponent = -1;
                verticalComponent = 0;
            }
            else if (e.KeyCode == Keys.D) //moving to the right
            {
                horizontalComponent = 1;
                verticalComponent = 0;
            }
            else if (e.KeyCode == Keys.W) //moving to the top
            {
                verticalComponent = -1;
                horizontalComponent = 0;
            }
            else if (e.KeyCode == Keys.S) //moving to the bottom
            {
                verticalComponent = 1;
                horizontalComponent = 0;
            }
            else if (e.KeyCode == Keys.P) //pause
            {
                horizontalComponent = 0;
                verticalComponent = 0;
            }
            else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus) //if "+" is pressed - the speed increases
            {
                if(timerMain.Interval > 1)
                {
                    timerMain.Interval -= 1;
                }
            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus) //if "-" is pressed - the speed decreases
            {
                timerMain.Interval += 1;
            }
        }
    }
}