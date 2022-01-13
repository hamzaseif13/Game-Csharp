
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
            this.NewPlayer = new System.Windows.Forms.Button();
            this.ChoosePlayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditPlayerBtn = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.Error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(557, 449);
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
            this.Exit.Location = new System.Drawing.Point(12, 435);
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
            this.History.Location = new System.Drawing.Point(12, 184);
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
            this.Statistics.Location = new System.Drawing.Point(12, 120);
            this.Statistics.MaximumSize = new System.Drawing.Size(242, 44);
            this.Statistics.MinimumSize = new System.Drawing.Size(242, 44);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(242, 44);
            this.Statistics.TabIndex = 5;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = true;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // NewPlayer
            // 
            this.NewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPlayer.Location = new System.Drawing.Point(12, 51);
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
            this.ChoosePlayer.Location = new System.Drawing.Point(251, 234);
            this.ChoosePlayer.Name = "ChoosePlayer";
            this.ChoosePlayer.Size = new System.Drawing.Size(297, 50);
            this.ChoosePlayer.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Player";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EditPlayerBtn);
            this.panel1.Controls.Add(this.Statistics);
            this.panel1.Controls.Add(this.History);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.NewPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 590);
            this.panel1.TabIndex = 10;
            // 
            // EditPlayerBtn
            // 
            this.EditPlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPlayerBtn.Location = new System.Drawing.Point(12, 250);
            this.EditPlayerBtn.MaximumSize = new System.Drawing.Size(242, 44);
            this.EditPlayerBtn.MinimumSize = new System.Drawing.Size(242, 44);
            this.EditPlayerBtn.Name = "EditPlayerBtn";
            this.EditPlayerBtn.Size = new System.Drawing.Size(242, 44);
            this.EditPlayerBtn.TabIndex = 8;
            this.EditPlayerBtn.Text = "Edit player";
            this.EditPlayerBtn.UseVisualStyleBackColor = true;
            this.EditPlayerBtn.Click += new System.EventHandler(this.EditPlayerBtn_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.Error);
            this.RightPanel.Controls.Add(this.ChoosePlayer);
            this.RightPanel.Controls.Add(this.label1);
            this.RightPanel.Controls.Add(this.StartGame);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(280, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(854, 590);
            this.RightPanel.TabIndex = 11;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(205, 59);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(413, 33);
            this.Error.TabIndex = 17;
            this.Error.Text = "There is no Players registered.";
            this.Error.Visible = false;
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
        private System.Windows.Forms.Button NewPlayer;
        private System.Windows.Forms.ComboBox ChoosePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Button EditPlayerBtn;
        private System.Windows.Forms.Label Error;
    }
}