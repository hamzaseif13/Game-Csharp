using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
           
        }
        private void HistoryForm_Load_1(object sender, EventArgs e)
        {
            foreach(PlayerObj player in DataTracker.Players)
            foreach (Game  game in player.GamesHistory) {
                GameInfo c = new GameInfo(player.Name, game.GameDate, game.GameDuration,  game.GameScore, game.GameLevel, this);
            };


        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameInfo.Count = 0;
            this.Close();
        }
    }
    public class GameInfo
    {
        public static int Count = 0;
        public GameInfo(string name, string date, int duraion, int score, int level, HistoryForm historyForm)
        {
            Label NameLabel = new Label();
            NameLabel.Text = name;
            NameLabel.Location = new Point(26,100+Count*50 );
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Calibri", 22);
            NameLabel.ForeColor = Color.Blue;
            historyForm.Controls.Add(NameLabel);

            Label DateLabel = new Label();
            DateLabel.Text = date;
            DateLabel.Location = new Point(186, 100 + Count * 50);
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Calibri", 22);
            DateLabel.ForeColor = Color.Blue;
            historyForm.Controls.Add(DateLabel);

            Label DurationLabel = new Label();
            DurationLabel.Text = duraion.ToString()+" s";
            DurationLabel.Location = new Point(401, 100 + Count * 50);
            DurationLabel.AutoSize = true;
            DurationLabel.Font = new Font("Calibri", 22);
            DurationLabel.ForeColor = Color.Blue;
            historyForm.Controls.Add(DurationLabel);

            Label ScoreLabel = new Label();
            ScoreLabel.Text = score.ToString();
            ScoreLabel.Location = new Point(562, 100 + Count * 50);
            ScoreLabel.AutoSize = true;
            ScoreLabel.Font = new Font("Calibri", 22);
            ScoreLabel.ForeColor = Color.Blue;
            historyForm.Controls.Add(ScoreLabel);

            Label LevelLabel = new Label();
            LevelLabel.Text = level.ToString();
            LevelLabel.Location = new Point(740, 100 + Count * 50);
            LevelLabel.AutoSize = true;
            LevelLabel.Font = new Font("Calibri", 22);
            LevelLabel.ForeColor = Color.Blue;
            historyForm.Controls.Add(LevelLabel);
            Count++;
        }
    }
}
