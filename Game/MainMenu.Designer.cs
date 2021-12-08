﻿
namespace Game
{
    partial class MainMenu
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
            this.StartGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.NewPlayer = new System.Windows.Forms.Button();
            this.ChoosePlayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(33, 70);
            this.StartGame.MaximumSize = new System.Drawing.Size(242, 44);
            this.StartGame.MinimumSize = new System.Drawing.Size(242, 44);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(242, 44);
            this.StartGame.TabIndex = 2;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(33, 440);
            this.Exit.MaximumSize = new System.Drawing.Size(242, 44);
            this.Exit.MinimumSize = new System.Drawing.Size(242, 44);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(242, 44);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // History
            // 
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.Location = new System.Drawing.Point(33, 314);
            this.History.MaximumSize = new System.Drawing.Size(242, 44);
            this.History.MinimumSize = new System.Drawing.Size(242, 44);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(242, 44);
            this.History.TabIndex = 4;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Statistics
            // 
            this.Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.Location = new System.Drawing.Point(33, 221);
            this.Statistics.MaximumSize = new System.Drawing.Size(242, 44);
            this.Statistics.MinimumSize = new System.Drawing.Size(242, 44);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(242, 44);
            this.Statistics.TabIndex = 5;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.Location = new System.Drawing.Point(33, 171);
            this.Profile.MaximumSize = new System.Drawing.Size(242, 44);
            this.Profile.MinimumSize = new System.Drawing.Size(242, 44);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(242, 44);
            this.Profile.TabIndex = 6;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // NewPlayer
            // 
            this.NewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPlayer.Location = new System.Drawing.Point(33, 120);
            this.NewPlayer.MaximumSize = new System.Drawing.Size(242, 44);
            this.NewPlayer.MinimumSize = new System.Drawing.Size(242, 44);
            this.NewPlayer.Name = "NewPlayer";
            this.NewPlayer.Size = new System.Drawing.Size(242, 44);
            this.NewPlayer.TabIndex = 7;
            this.NewPlayer.Text = "New Player";
            this.NewPlayer.UseVisualStyleBackColor = true;
            this.NewPlayer.Click += new System.EventHandler(this.NewPlayer_Click);
            // 
            // ChoosePlayer
            // 
            this.ChoosePlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoosePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosePlayer.FormattingEnabled = true;
            this.ChoosePlayer.Location = new System.Drawing.Point(320, 120);
            this.ChoosePlayer.Name = "ChoosePlayer";
            this.ChoosePlayer.Size = new System.Drawing.Size(297, 50);
            this.ChoosePlayer.TabIndex = 8;
            this.ChoosePlayer.SelectedIndexChanged += new System.EventHandler(this.ChoosePlayer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Player";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Statistics);
            this.panel1.Controls.Add(this.History);
            this.panel1.Controls.Add(this.Profile);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.NewPlayer);
            this.panel1.Controls.Add(this.StartGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 590);
            this.panel1.TabIndex = 10;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.ChoosePlayer);
            this.RightPanel.Controls.Add(this.label1);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(280, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(854, 590);
            this.RightPanel.TabIndex = 11;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(1134, 590);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1150, 629);
            this.MinimumSize = new System.Drawing.Size(1150, 629);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button NewPlayer;
        private System.Windows.Forms.ComboBox ChoosePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel RightPanel;
    }
}