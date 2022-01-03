
namespace Game
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NextLevelBtn = new System.Windows.Forms.Button();
            this.LevelLable = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.FadeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartTimer
            // 
            this.StartTimer.Interval = 1;
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScoreLabel.Location = new System.Drawing.Point(32, 33);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(127, 39);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Score :";
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartBtn.CausesValidation = false;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(1109, 34);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(131, 47);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.TabStop = false;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.button1_Click);
            this.StartBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.StartBtn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(680, 34);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(221, 78);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time :";
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerLabel.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.Location = new System.Drawing.Point(283, 34);
            this.PlayerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(145, 39);
            this.PlayerLabel.TabIndex = 5;
            this.PlayerLabel.Text = "Player : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.NextLevelBtn);
            this.panel1.Controls.Add(this.LevelLable);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.PlayerLabel);
            this.panel1.Controls.Add(this.ScoreLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 124);
            this.panel1.TabIndex = 6;
            // 
            // NextLevelBtn
            // 
            this.NextLevelBtn.Location = new System.Drawing.Point(1181, 84);
            this.NextLevelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NextLevelBtn.Name = "NextLevelBtn";
            this.NextLevelBtn.Size = new System.Drawing.Size(100, 28);
            this.NextLevelBtn.TabIndex = 8;
            this.NextLevelBtn.Text = "Jumb to next level";
            this.NextLevelBtn.UseVisualStyleBackColor = true;
            this.NextLevelBtn.Click += new System.EventHandler(this.NextLevelBtn_Click);
            // 
            // LevelLable
            // 
            this.LevelLable.BackColor = System.Drawing.Color.Transparent;
            this.LevelLable.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLable.Location = new System.Drawing.Point(909, 34);
            this.LevelLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelLable.Name = "LevelLable";
            this.LevelLable.Size = new System.Drawing.Size(192, 53);
            this.LevelLable.TabIndex = 7;
            this.LevelLable.Text = "Level 1";
            // 
            // MainMenuBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(1244, 34);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBtn.Name = "MainMenuBtn";
            this.CloseBtn.Size = new System.Drawing.Size(131, 47);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "Exit";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLabel.ForeColor = System.Drawing.Color.Red;
            this.UpdateLabel.Location = new System.Drawing.Point(521, 128);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(265, 55);
            this.UpdateLabel.TabIndex = 7;
            this.UpdateLabel.Text = "+ 10 Points";
            this.UpdateLabel.Visible = false;
            // 
            // FadeTimer
            // 
            this.FadeTimer.Interval = 10;
            this.FadeTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(149)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1379, 937);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpdateLabel);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1395, 976);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1395, 976);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer StartTimer;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label LevelLable;
        private System.Windows.Forms.Button NextLevelBtn;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.Timer FadeTimer;
    }
}

