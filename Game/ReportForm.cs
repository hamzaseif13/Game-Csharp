using System;
using System.Windows.Forms;

namespace Game
{
    public partial class ReportForm : Form
    {
        public ReportForm(int n,int profile, int high,int low,int min,int max,int total)
        {
            InitializeComponent();
            games.Text = n.ToString();
            NumberOfProfile.Text = profile.ToString();
            High.Text = high.ToString();
            Low.Text = low.ToString();
            Mini.Text = min.ToString();
            Maxi.Text = max.ToString();
            Total.Text = total.ToString();
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
