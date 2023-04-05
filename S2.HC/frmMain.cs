using System.Numerics;

namespace S2.HC
{
    public partial class frmMain : Form
    {

        // enter the variables
        bool goUp; // this is a boolean to allow player to go up
        bool goDown; // this is a boolean to allow player to go down
        bool shot = false; // this will check if the player has shot any bullets
        bool gameOver;

        int score = 0; // this is a integer for player to keep score
        int speed = 8; // this is the speed of obstacles and ufos
        int UfoSpeed = 10;
        Random rand = new Random(); // this is the random class to generate a random number
        int playerSpeed = 7; // this interger will control how fast the player moves
        int index = 0; // this is a empty integer which will be used to change the UFO images
        public frmMain()
        {
            InitializeComponent();
        }
        private void MainTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            if (goUp == true && picRunner.Top > 0)
            {
                picRunner.Top -= playerSpeed;
            }
            if (goDown == true && picRunner.Top + picRunner.Height < this.ClientSize.Height)
            {
                picRunner.Top += playerSpeed;
            }

            ufo.Left -= UfoSpeed;

            if (ufo.Left + ufo.Width < 0)
            {
                ChangeUFO();
            }
            //move things
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && (string)control.Tag == "obstacle")
                {
                    control.Left -= speed;
                    if (control.Left < -200)
                    {
                        control.Left = 900;
                    }
                    if (picRunner.Bounds.IntersectsWith(control.Bounds))
                    {
                        GameOver();
                    }
                }
                //bullet
                if (control is PictureBox && (string)control.Tag == "bullet")
                {
                    control.Left += 25;
                    if (control.Left > 800)
                    {
                        RemoveBullet(((PictureBox)control));
                    }
                    if (ufo.Bounds.IntersectsWith(control.Bounds))
                    {
                        RemoveBullet(((PictureBox)control));
                        score += 1;
                        ChangeUFO();
                    }
                }
            }
            if (picRunner.Bounds.IntersectsWith(ufo.Bounds))
            {
                GameOver();
            }
            if (score > 10)
            {
                speed = 12;
                UfoSpeed = 18;
            }
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // if the player has pressed down the up key
                // we change the go up to true
                goUp = true;

            }
            if (e.KeyCode == Keys.Down)
            {
                // if the player has pressed down the down key
                // we change the go down to true
                goDown = true;
            }
            if (e.KeyCode == Keys.Space && shot == false)
            {
                // if the player has pressed down space key
                // AND shot boolean is false when they did
                // then we run the make bullet function
                // and change the shot from false to true
                MakeBullet();
                shot = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // if the player has left the up key
                // change go up to false
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                // if the player has left the down key
                // change go down to false
                goDown = false;
            }
            if (shot == true)
            {
                //if shot variable is true 
                // we change it false so the player will have to shoot again
                // for more bullet. 
                shot = false;
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
        private void RestartGame()
        {
            goUp = false;
            goDown = false;
            shot = false;
            gameOver = false;
            score = 0;
            UfoSpeed = 10;

            lblScore.Text = "Score: " + score;

            ChangeUFO();
            picRunner.Top = 340;

            picSpearUp.Left = 390;
            picBarrierDown.Left = 655;

            gameTimer.Start();
        }
        private void GameOver()
        {
            gameTimer.Stop();
            lblScore.Text = "Score: " + " Game over, press enter to retry!";
            gameOver = true;
        }
        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }
        private void MakeBullet()
        {
            PictureBox bullet = new();
            // create a new picture box class to the form
            bullet.BackColor = Color.DarkOrange;
            // set the colour of the bullet to dark organge
            bullet.Height = 5;
            // set bullet height to 5 pixels
            bullet.Width = 10;

            // set bullet width to 10 pixels
            bullet.Left = picRunner.Left + picRunner.Width;
            // bullet will place in front of player object
            bullet.Top = picRunner.Top + picRunner.Height / 2;
            // bullet will be middle of player object
            bullet.Tag = "bullet";
            // set the tag for the object to bullet
            this.Controls.Add(bullet);
            // finally adding the picture box bullet to the scene
        }
        private void ChangeUFO()
        {
            index += 1; // increase index by 1
            if (index > 3)
            {
                // if indexes value is greater than 3
                // set it back to 1
                index = 1;
            }

            // we will use the switch statement to switch between alien images
            // by using the number in index we can switch them effectively
            // when the numbers in index change this switch statement will follow
            switch (index)
            {
                // if the number in index is 1
                // then we will show the alien 1 skin on UFO picture Box
                case 1:
                    ufo.Image = Properties.Resources.ufoA;
                    break;
                // if the number in index is 2
                // then we will show the alien 2 skin on UFO picture Box
                case 2:
                    ufo.Image = Properties.Resources.ufoB;
                    break;
                // if the number in index is 3
                // then we will show the alien 3 skin on UFO picture Box
                case 3:
                    ufo.Image = Properties.Resources.ufoC;
                    break;
            }
            ufo.Left = 1000;
            ufo.Top = rand.Next(20, this.ClientSize.Height - ufo.Height);
        }


        private void MainTimerEventB(object sender, EventArgs e)
        {
            // move pillar 1 towards the left of the screen
            picSpearUp.Left -= speed;
            // move pillar 2 towards the left of the screen
            picBarrierDown.Left -= speed;
            // move ufo towards the left of the screen
            ufo.Left -= speed;
            // show the score on label 1
            lblScore.Text = "Score: " + score;
            if (goUp)
            {
                // if go up is true then move the player up the screen
                // notice its minus equals means it will deduct from the top location
                // thus moving the player upwards
                picRunner.Top -= playerSpeed;
            }
            if (goDown)
            {
                // if go down is true then move the player down the screen
                // notice its plus equals means it will add to the top location
                // thus moving the player downwards
                picRunner.Top += playerSpeed;
            }
            if (picSpearUp.Left < -150)
            {
                // if pillar 1 has gone past -150 which is off the screen
                // then move it to 900 pixels to the right of the screen
                // it will appear to have a continuous motion from right to left
                picSpearUp.Left = 900;
            }
            if (picBarrierDown.Left < -150)
            {
                // if pillar 2 has gone past -150 which is off the screen
                // then move it to 1000 pixels to the right of the screen
                // it will appear to have a continuous motion from right to left
                picBarrierDown.Left = 1000;
            }
            // the two || symbols represent the OR option in If statements
            // the below if statement is logically checking the following
            // if UFO has left the screen towards the left
            // OR
            // player has collided with the UFO object on screen
            // OR
            // player has collided with pillar 1 object
            // OR 
            // player has collided with pillar 2 object
            // then follow the instructions inside the statement
            // we are able to check multiple conditions at the if statement
            if (ufo.Left < -5 ||
                picRunner.Bounds.IntersectsWith(ufo.Bounds) ||
                picRunner.Bounds.IntersectsWith(picSpearUp.Bounds) ||
                picRunner.Bounds.IntersectsWith(picBarrierDown.Bounds)
                )
            {
                // if one of the above is true then we stop the timer
                gameTimer.Stop();
                // the game will show the final score to the player in a message box
                MessageBox.Show("You failed the mission, you Killed " + score + " Ufo's");
            }
            // below is a for loop thats checking the components in this form
            // first we created a valiable called X in this form
            // x will be linked to the bullet object 
            // it will find out if the bullet object exist
            foreach (Control X in this.Controls)
            {
                // if X is a picture box object AND it has a tag of bullet
                // then we will follow the instructions within
                if (X is PictureBox && X.Tag == "bullet")
                {
                    // move x towards the right of the screen
                    X.Left += 15;
                    // if x has left the screen towards the right
                    // x's location is greater than 900 pixels from the screen
                    if (X.Left > 900)
                    {
                        // then remove x from display
                        this.Controls.Remove(X);
                        // dispose the x from the application
                        // we use the dispose method so it doesn't leak memory later on
                        X.Dispose();
                    }
                    // below we will check if X collides with the UFO object
                    if (X.Bounds.IntersectsWith(ufo.Bounds))
                    {
                        // is X collides with the UFO object
                        // add 1 to the score
                        score += 1;
                        // remove the bullet from the screen
                        this.Controls.Remove(X);
                        // dispose the bullet from the program
                        X.Dispose();
                        // move the UFO object 1000 pixels off the screen
                        ufo.Left = 1000;
                        // generate a random vertical location for the UFO
                        ufo.Top = rand.Next(5, 330) - ufo.Height;
                        // run the change UFO function it appears like a different UFO
                        ChangeUFO();
                    }
                }
            }
        }

    }
}