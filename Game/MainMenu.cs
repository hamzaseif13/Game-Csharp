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
    public partial class MainMenu : Form
    {
        public Form CurrentForm=new Form();
       
        public MainMenu()
        {
            InitializeComponent();
            DataTracker.Players = new List<PlayerObj>();
            
            
        }
        public  void Refreshl()
        {
            ChoosePlayer.Items.Clear();
            foreach (var x in DataTracker.Players)
            {
                ChoosePlayer.Items.Add(x.Name);
            }
            ChoosePlayer.SelectedItem = DataTracker.Players[DataTracker.Players.Count-1].Name;
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            if (DataTracker.Players.Count > 0)
            {
                var q1 = from player in DataTracker.Players where player.Name == ChoosePlayer.Text select player;
                DataTracker.currentPlayer = q1.First();
                GameForm g = new GameForm(false);
                g.ShowDialog();
                return;
            }
            Error.Visible = true;
            //this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPlayer_Click(object sender, EventArgs e)
        {
            Error.Visible = false;

            this.RightPanel.Controls.Remove(CurrentForm);
            CurrentForm = new AddEditPlayer(null);
            CurrentForm.TopLevel = false;
            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            CurrentForm.Dock = DockStyle.Fill;
            this.RightPanel.Controls.Add(CurrentForm);
            CurrentForm.BringToFront();
            CurrentForm.Show();           
        }

        private void EditPlayerBtn_Click(object sender, EventArgs e)
        {

            if (DataTracker.Players.Count > 0)
            {
                var q1 = from player in DataTracker.Players where player.Name == ChoosePlayer.Text select player;
                this.RightPanel.Controls.Remove(CurrentForm);
                CurrentForm = new AddEditPlayer(q1.First());
                CurrentForm.TopLevel = false;
                CurrentForm.FormBorderStyle = FormBorderStyle.None;
                CurrentForm.Dock = DockStyle.Fill;
                this.RightPanel.Controls.Add(CurrentForm);
                CurrentForm.BringToFront();
                CurrentForm.Show();return;
            }
            Error.Visible = true;
            this.RightPanel.Controls.Remove(CurrentForm);
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
           

            this.RightPanel.Controls.Remove(CurrentForm);
            CurrentForm = new StatisticsForm();
            CurrentForm.TopLevel = false;
            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            CurrentForm.Dock = DockStyle.Fill;
            this.RightPanel.Controls.Add(CurrentForm);
            CurrentForm.BringToFront();
            CurrentForm.Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            GameInfo.Count = 0;
            this.RightPanel.Controls.Remove(CurrentForm);
            CurrentForm = new HistoryForm();
            CurrentForm.TopLevel = false;
            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            CurrentForm.Dock = DockStyle.Fill;
            this.RightPanel.Controls.Add(CurrentForm);
            CurrentForm.BringToFront();
            CurrentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RightPanel.Controls.Remove(CurrentForm);

        }
       
    }
    
}
