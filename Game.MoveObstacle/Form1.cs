using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Game.MoveObstacle
{
    public partial class Form1 : Form
    {
        bool left, right;
        bool up, down;
        bool GameOver = false;

        bool sit = false;

        bool jumping = false;
        int jumpSpeed = 10;
        int force = 12;

        int score = 0;
        int obstacleSpeed = 5;
        Random random = new Random();
        int position;


        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            if (left == true) { PlayerA.Left -= 5; }
            if (right == true) { PlayerA.Left += 10; }
            if (up == true) { PlayerA.Top -= 10; }
            if (down == true) { PlayerA.Top += 10; }

            if (sit == true)
            {
                PlayerA.Height = 50;
                PlayerA.Width = 70;
            }
            else
            {
                PlayerA.Height = 82;
                PlayerA.Width = 102;
            }

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
                    x.Left -= obstacleSpeed;
                    if (x.Left + x.Width < 50)
                    {
                        x.Left = this.ClientSize.Width + random.Next(600, 800) + (x.Width * 15);
                        score++;
                    }

                    if (PlayerA.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver = true;
                        GameTimer.Stop();
                        PlayerA.Image = Properties.Resources.GameOver;
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

            if (score >= 5)
            {
                obstacleSpeed = 8;
                //lblLevel.Text =;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.D) { right = true; }

            if (e.KeyCode == Keys.W) { up = true; }
            if (e.KeyCode == Keys.S) { down = true; }

            if (e.KeyCode == Keys.C) { sit = true; }

            if (e.KeyCode == Keys.R && GameOver == true) { ResetGame(); }

            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }

            if (e.KeyCode == Keys.F1)
            {
                Help help = new();
                help.ShowInTaskbar = false;
                help.Show();
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.D) { right = false; }

            if (e.KeyCode == Keys.W) { up = false; }
            if (e.KeyCode == Keys.S) { down = false; }

            if (e.KeyCode == Keys.C) { sit = false; }

            if (e.KeyCode == Keys.R) { GameOver = false; }

            if (jumping)
            {
                jumping = false;
            }
        }

        private void ResetGame()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 5;
            lblScore.Text = "Score: " + score;
            PlayerA.Image = Properties.Resources.PlayerA;
            GameOver = false;
            PlayerA.Top = floor.Top - PlayerA.Height;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + random.Next(400, 600) + (x.Width * 10);
                    x.Left = position;
                }
            }
            GameTimer.Start();
        }
    }
}