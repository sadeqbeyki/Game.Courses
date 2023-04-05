

namespace Game.VazKhos
{
    public partial class frmGame : Form
    {
        bool left, right;
        bool up, down;

        bool jump = false;//trx
        int gravity = 20;
        int force = 12;//trex 

        int jumpSpeed;

        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new();
        int position;
        bool isGameOver = false;

        public frmGame()
        {
            InitializeComponent();
            //trex
            GameReset();
            //end trex
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }

            if (e.KeyCode == Keys.Up) { up = true; }
            if (e.KeyCode == Keys.Down) { down = true; }

            if (!jump)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = gravity;
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }

            if (e.KeyCode == Keys.Up) { up = false; }
            if (e.KeyCode == Keys.Down) { down = false; }

            //trex
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (right == true) { PlayerA.Left += 10; }
            if (left == true) { PlayerA.Left -= 5; }

            if (up == true) { PlayerA.Top -= 10; }
            if (down == true) { PlayerA.Top += 10; }

            //trex
            //PlayerA.Top += jumpSpeed;
            lblScore.Text = "Score: " + score;
            //end trex

            if (jump)
            {
                PlayerA.Top -= force;
                force -= 1;
                //trex
                //jumpSpeed = -12;
            }
            //else
            //{
            //    jumpSpeed = 12;
            //}

            //if (jump == true && force < 0)
            //{
            //    jump = false;
            //}
            //end trex

            //back to line
            if (PlayerA.Top + PlayerA.Height >= gameArea.Height)
            {
                PlayerA.Top = gameArea.Height - PlayerA.Height;
                jump = false;
                //trex
                //jumpSpeed = 0;
                //end trex

            }
            else
            {
                PlayerA.Top += 5;
            }

            //trex

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox && (string)ctrl.Tag == "obstacle")
                {
                    ctrl.Left -= obstacleSpeed;
                    if (ctrl.Left < -100)
                    {
                        ctrl.Left = this.ClientSize.Width + rand.Next(10, 50) + ctrl.Width * 15;
                        score++;
                    }
                    if (PlayerA.Bounds.IntersectsWith(ctrl.Bounds))
                    {
                        GameTimer.Stop();
                        PlayerA.Image = Properties.Resources.GameOver;
                        lblScore.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }
            if (score >= 5)
            {
                obstacleSpeed = 15;
            }

        }

        //trex
        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jump = false;
            score = 0;
            obstacleSpeed = 10;
            lblScore.Text = "Score: " + score;
            PlayerA.Image = Properties.Resources.PlayerA;
            isGameOver = false;
            PlayerA.Top = 472;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox && (string)ctrl.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(10, 100) + (ctrl.Width * 10);
                    ctrl.Left = position;
                }
            }
            GameTimer.Start();
        }

    }
}