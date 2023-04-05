namespace Game.MoveObstacle
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
            lblScore = new Label();
            PlayerA = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            floor = new Label();
            obstacleC = new PictureBox();
            obstacleB = new PictureBox();
            obstacleA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PlayerA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleA).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(26, 24);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(19, 15);
            lblScore.TabIndex = 1;
            lblScore.Text = "00";
            // 
            // PlayerA
            // 
            PlayerA.BackColor = Color.Transparent;
            PlayerA.Image = Properties.Resources.PlayerA;
            PlayerA.Location = new Point(136, 411);
            PlayerA.Name = "PlayerA";
            PlayerA.Size = new Size(54, 44);
            PlayerA.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerA.TabIndex = 4;
            PlayerA.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 20;
            GameTimer.Tick += MainGameTimerEvent;
            // 
            // floor
            // 
            floor.BackColor = Color.ForestGreen;
            floor.Location = new Point(-7, 451);
            floor.Name = "floor";
            floor.Size = new Size(872, 23);
            floor.TabIndex = 5;
            // 
            // obstacleC
            // 
            obstacleC.Image = Properties.Resources.spear;
            obstacleC.Location = new Point(543, 82);
            obstacleC.Name = "obstacleC";
            obstacleC.Size = new Size(98, 12);
            obstacleC.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleC.TabIndex = 6;
            obstacleC.TabStop = false;
            obstacleC.Tag = "obstacle";
            // 
            // obstacleB
            // 
            obstacleB.Image = Properties.Resources.rockA;
            obstacleB.Location = new Point(344, 420);
            obstacleB.Name = "obstacleB";
            obstacleB.Size = new Size(50, 35);
            obstacleB.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleB.TabIndex = 7;
            obstacleB.TabStop = false;
            obstacleB.Tag = "obstacle";
            // 
            // obstacleA
            // 
            obstacleA.Image = Properties.Resources.rockB;
            obstacleA.Location = new Point(673, 410);
            obstacleA.Name = "obstacleA";
            obstacleA.Size = new Size(60, 45);
            obstacleA.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleA.TabIndex = 8;
            obstacleA.TabStop = false;
            obstacleA.Tag = "obstacle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(obstacleA);
            Controls.Add(obstacleB);
            Controls.Add(obstacleC);
            Controls.Add(floor);
            Controls.Add(PlayerA);
            Controls.Add(lblScore);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)PlayerA).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleC).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleB).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacleA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblScore;
        private PictureBox PlayerA;
        private System.Windows.Forms.Timer GameTimer;
        private Label floor;
        private PictureBox obstacleC;
        private PictureBox obstacleB;
        private PictureBox obstacleA;
    }
}