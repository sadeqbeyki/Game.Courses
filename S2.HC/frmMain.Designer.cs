namespace S2.HC
{
    partial class frmMain
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
            picRunner = new PictureBox();
            picSpearUp = new PictureBox();
            picBarrierDown = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            lblScore = new Label();
            ufo = new PictureBox();
            footer = new Label();
            ((System.ComponentModel.ISupportInitialize)picRunner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSpearUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBarrierDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ufo).BeginInit();
            SuspendLayout();
            // 
            // picRunner
            // 
            picRunner.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRunner.BackColor = Color.Transparent;
            picRunner.Image = Properties.Resources.runner;
            picRunner.Location = new Point(30, 380);
            picRunner.Name = "picRunner";
            picRunner.Size = new Size(139, 144);
            picRunner.SizeMode = PictureBoxSizeMode.StretchImage;
            picRunner.TabIndex = 9;
            picRunner.TabStop = false;
            // 
            // picSpearUp
            // 
            picSpearUp.BackColor = Color.Transparent;
            picSpearUp.Image = Properties.Resources.spearUp;
            picSpearUp.Location = new Point(504, 28);
            picSpearUp.Name = "picSpearUp";
            picSpearUp.Size = new Size(56, 28);
            picSpearUp.SizeMode = PictureBoxSizeMode.StretchImage;
            picSpearUp.TabIndex = 7;
            picSpearUp.TabStop = false;
            picSpearUp.Tag = "obstacle";
            // 
            // picBarrierDown
            // 
            picBarrierDown.BackColor = Color.Transparent;
            picBarrierDown.Image = Properties.Resources.barrierDown;
            picBarrierDown.Location = new Point(504, 494);
            picBarrierDown.Name = "picBarrierDown";
            picBarrierDown.Size = new Size(57, 55);
            picBarrierDown.SizeMode = PictureBoxSizeMode.StretchImage;
            picBarrierDown.TabIndex = 6;
            picBarrierDown.TabStop = false;
            picBarrierDown.Tag = "obstacle";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += MainTimerEvent;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Ubuntu Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.Location = new Point(0, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(90, 23);
            lblScore.TabIndex = 11;
            lblScore.Text = "Score: 0";
            // 
            // ufo
            // 
            ufo.BackColor = Color.Transparent;
            ufo.Image = Properties.Resources.ufo;
            ufo.Location = new Point(721, 238);
            ufo.Name = "ufo";
            ufo.Size = new Size(41, 40);
            ufo.SizeMode = PictureBoxSizeMode.StretchImage;
            ufo.TabIndex = 12;
            ufo.TabStop = false;
            // 
            // footer
            // 
            footer.BackColor = Color.Green;
            footer.Location = new Point(0, 512);
            footer.Name = "footer";
            footer.Size = new Size(985, 12);
            footer.TabIndex = 13;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(ufo);
            Controls.Add(lblScore);
            Controls.Add(picRunner);
            Controls.Add(picSpearUp);
            Controls.Add(picBarrierDown);
            Controls.Add(footer);
            Name = "frmMain";
            Text = "Game Runner";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)picRunner).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSpearUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBarrierDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ufo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picRunner;
        private PictureBox picSpearUp;
        private PictureBox picBarrierDown;
        private System.Windows.Forms.Timer gameTimer;
        private Label lblScore;
        private PictureBox ufo;
        private Label footer;
    }
}