using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Game.MoveObstacle
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed = 10;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 5;
        Random rnd = new Random();
        int position;
        bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            PlayerA.Top += jumpSpeed;
            lblScore.Text = "Score: " + score;

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                     x.Left -= obstacleSpeed; // move the obstacles towards the left
                    //if (x.Left + x.Width < 10)
                    //{
                    //    // if the obstacles have gone off the screen
                    //    // then we respawn it off the far right
                    //    // in this case we are calculating the form width and a random number between 200 and 800
                    //    x.Left = this.ClientSize.Width + rnd.Next(200, 800) + (x.Width * 15);
                    //    // we will add one to the score
                    //    score++;
                    //}
                    // if the t rex collides with the obstacles
                    if (PlayerA.Bounds.IntersectsWith(x.Bounds))
                    {
                        // we stop the timer
                        GameTimer.Stop();
                        // change the t rex image to the dead one
                        PlayerA.Image = Properties.Resources.GameOver;
                        // show press r to restart on the score text label
                        lblScore.Text += "  Press R to restart";
                    }
                }
            }

            if (PlayerA.Top >= floor.Top - PlayerA.Height && !jumping)
            {
                force = 12;
                PlayerA.Top = floor.Top - PlayerA.Height;
                jumpSpeed = 0;
            }

            //if (score >= 10)
            //{
            //    obstacleSpeed = 10;
            //}
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (jumping)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                ResetGame();
            }
        }

        private void ResetGame()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            lblScore.Text = "Score: " + score;
            PlayerA.Image = Properties.Resources.PlayerA;
            isGameOver = false;
            PlayerA.Top = floor.Top - PlayerA.Height;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rnd.Next(10, 100) + (x.Width * 10);
                    x.Left = position;
                }
            }
            GameTimer.Start();
        }
    }
}