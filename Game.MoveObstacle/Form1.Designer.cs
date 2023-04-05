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
            lblLevel = new Label();
            ((System.ComponentModel.ISupportInitialize)PlayerA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacleA).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Ubuntu Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.Location = new Point(12, 423);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(99, 20);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score: 00";
            // 
            // PlayerA
            // 
            PlayerA.BackColor = Color.Transparent;
            PlayerA.Image = Properties.Resources.PlayerA;
            PlayerA.Location = new Point(87, 272);
            PlayerA.Name = "PlayerA";
            PlayerA.Size = new Size(102, 82);
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
            floor.BackColor = Color.Transparent;
            floor.Location = new Point(-13, 356);
            floor.Name = "floor";
            floor.Size = new Size(872, 23);
            floor.TabIndex = 5;
            // 
            // obstacleC
            // 
            obstacleC.BackColor = Color.Transparent;
            obstacleC.Image = Properties.Resources.spear;
            obstacleC.Location = new Point(503, 272);
            obstacleC.Name = "obstacleC";
            obstacleC.Size = new Size(98, 12);
            obstacleC.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleC.TabIndex = 6;
            obstacleC.TabStop = false;
            obstacleC.Tag = "obstacle";
            // 
            // obstacleB
            // 
            obstacleB.BackColor = Color.Transparent;
            obstacleB.Image = Properties.Resources.rockA;
            obstacleB.Location = new Point(359, 323);
            obstacleB.Name = "obstacleB";
            obstacleB.Size = new Size(50, 35);
            obstacleB.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleB.TabIndex = 7;
            obstacleB.TabStop = false;
            obstacleB.Tag = "obstacle";
            // 
            // obstacleA
            // 
            obstacleA.BackColor = Color.Transparent;
            obstacleA.Image = Properties.Resources.rockB;
            obstacleA.Location = new Point(634, 323);
            obstacleA.Name = "obstacleA";
            obstacleA.Size = new Size(60, 45);
            obstacleA.SizeMode = PictureBoxSizeMode.StretchImage;
            obstacleA.TabIndex = 8;
            obstacleA.TabStop = false;
            obstacleA.Tag = "obstacle";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Ubuntu Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLevel.Location = new Point(651, 423);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(99, 20);
            lblLevel.TabIndex = 9;
            lblLevel.Text = "Level: 00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgB;
            ClientSize = new Size(784, 461);
            Controls.Add(obstacleB);
            Controls.Add(obstacleA);
            Controls.Add(floor);
            Controls.Add(lblLevel);
            Controls.Add(obstacleC);
            Controls.Add(PlayerA);
            Controls.Add(lblScore);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Keshkeret";
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
        private Label lblLevel;
    }
}