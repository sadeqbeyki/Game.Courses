namespace Game.MoveObstacle
{
    partial class Help
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            helpWindow = new Panel();
            btnClose = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            upKey = new Label();
            helpWindow.SuspendLayout();
            SuspendLayout();
            // 
            // helpWindow
            // 
            helpWindow.Controls.Add(btnClose);
            helpWindow.Controls.Add(label7);
            helpWindow.Controls.Add(label6);
            helpWindow.Controls.Add(label5);
            helpWindow.Controls.Add(label4);
            helpWindow.Controls.Add(label3);
            helpWindow.Controls.Add(label2);
            helpWindow.Controls.Add(label1);
            helpWindow.Controls.Add(upKey);
            resources.ApplyResources(helpWindow, "helpWindow");
            helpWindow.Name = "helpWindow";
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // upKey
            // 
            resources.ApplyResources(upKey, "upKey");
            upKey.Name = "upKey";
            // 
            // Help
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(helpWindow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Help";
            ShowInTaskbar = false;
            helpWindow.ResumeLayout(false);
            helpWindow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel helpWindow;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label upKey;
        private Label label7;
        private Button btnClose;
    }
}