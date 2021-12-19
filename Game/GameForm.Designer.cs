
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
            this.LevelLable = new System.Windows.Forms.Label();
            this.MainMenuBtn = new System.Windows.Forms.Button();
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
            this.ScoreLabel.Location = new System.Drawing.Point(24, 27);
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
            this.StartBtn.Location = new System.Drawing.Point(832, 28);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(98, 38);
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
            this.TimeLabel.Location = new System.Drawing.Point(520, 28);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(166, 63);
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
            this.PlayerLabel.Location = new System.Drawing.Point(212, 28);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(145, 39);
            this.PlayerLabel.TabIndex = 5;
            this.PlayerLabel.Text = "Player : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.LevelLable);
            this.panel1.Controls.Add(this.MainMenuBtn);
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.PlayerLabel);
            this.panel1.Controls.Add(this.ScoreLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 101);
            this.panel1.TabIndex = 6;
            // 
            // LevelLable
            // 
            this.LevelLable.BackColor = System.Drawing.Color.Transparent;
            this.LevelLable.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLable.Location = new System.Drawing.Point(682, 28);
            this.LevelLable.Name = "LevelLable";
            this.LevelLable.Size = new System.Drawing.Size(144, 43);
            this.LevelLable.TabIndex = 7;
            this.LevelLable.Text = "Level 1";
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBtn.Location = new System.Drawing.Point(933, 28);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(98, 38);
            this.MainMenuBtn.TabIndex = 6;
            this.MainMenuBtn.Text = "Exit";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(149)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1034, 761);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1050, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1050, 800);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer StartTimer;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Label LevelLable;
    }
}

