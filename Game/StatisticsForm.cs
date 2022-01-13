using System;
using System.Linq;
using System.Windows.Forms;

namespace Game
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            games.Text = DataTracker.NumberOfGames.ToString();
            NumberOfProfile.Text = DataTracker.Players.Count.ToString();
            Total.Text = DataTracker.TotalDuration.ToString();
            var q1 = from pl in DataTracker.Players orderby pl.HighestScore descending select pl.HighestScore;
            var q2 = from pl in DataTracker.Players orderby pl.LowestScore  select pl.LowestScore;
            
            if (q2.Any()&&q1.Any())
            {
                High.Text = q1.First().ToString();
                Low.Text = q2.First().ToString();
            }
            else
            {
                High.Text = "----";
                Low.Text = "----";
            }
            var q3 = from pl in DataTracker.Players orderby pl.MaxDuration descending select pl.MaxDuration;
            var q4 = from pl in DataTracker.Players orderby pl.MinDuration select pl.MinDuration;
            if (q3.Any() && q4.Any())
            {
                Maxi.Text = q3.First().ToString();
                Mini.Text = q4.First().ToString();
            }
            else
            {
                Maxi.Text = "----";
                Mini.Text = "----";
            }



        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
