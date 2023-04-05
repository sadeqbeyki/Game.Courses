namespace Game.VazKhos
{
    partial class frmGame
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
            GameArea = new Panel();
            lblScore = new Label();
            rockB = new PictureBox();
            rockA = new PictureBox();
            PlayerA = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            floor = new Label();
            GameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rockB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rockA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerA).BeginInit();
            SuspendLayout();
            // 
            // GameArea
            // 
            GameArea.BackColor = Color.Transparent;
            GameArea.Controls.Add(lblScore);
            GameArea.Controls.Add(rockB);
            GameArea.Controls.Add(rockA);
            GameArea.Controls.Add(PlayerA);
            GameArea.Location = new Point(12, 12);
            GameArea.Name = "GameArea";
            GameArea.Size = new Size(760, 540);
            GameArea.TabIndex = 0;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Dosis", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.Location = new Point(3, 3);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(82, 29);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score: 0";
            // 
            // rockB
            // 
            rockB.Image = Properties.Resources.rockB;
            rockB.Location = new Point(580, 474);
            rockB.Name = "rockB";
            rockB.Size = new Size(100, 70);
            rockB.SizeMode = PictureBoxSizeMode.StretchImage;
            rockB.TabIndex = 2;
            rockB.TabStop = false;
            rockB.Tag = "obstacle";
            // 
            // rockA
            // 
            rockA.Image = Properties.Resources.rockA;
            rockA.Location = new Point(335, 492);
            rockA.Name = "rockA";
            rockA.Size = new Size(66, 50);
            rockA.SizeMode = PictureBoxSizeMode.StretchImage;
            rockA.TabIndex = 1;
            rockA.TabStop = false;
            rockA.Tag = "obstacle";
            // 
            // PlayerA
            // 
            PlayerA.BackColor = Color.Transparent;
            PlayerA.Image = Properties.Resources.PlayerA;
            PlayerA.Location = new Point(0, 472);
            PlayerA.Name = "PlayerA";
            PlayerA.Size = new Size(100, 70);
            PlayerA.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerA.TabIndex = 0;
            PlayerA.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // floor
            // 
            floor.BackColor = Color.ForestGreen;
            floor.Location = new Point(-2, 550);
            floor.Name = "floor";
            floor.Size = new Size(793, 23);
            floor.TabIndex = 1;
            // 
            // frmGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 568);
            Controls.Add(floor);
            Controls.Add(GameArea);
            Name = "frmGame";
            Text = "Vazism";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            GameArea.ResumeLayout(false);
            GameArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rockB).EndInit();
            ((System.ComponentModel.ISupportInitialize)rockA).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel GameArea;
        private PictureBox PlayerA;
        private System.Windows.Forms.Timer GameTimer;
        private Label floor;
        private PictureBox rockA;
        private PictureBox rockB;
        private Label lblScore;
    }
}