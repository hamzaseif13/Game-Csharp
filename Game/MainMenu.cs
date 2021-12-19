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
        public string CurrentPlayer { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            DataTracker.Players = new List<PlayerObj>();
            DataTracker.AddPlayer("hamza", 21, "Male", "Blue");
            DataTracker.AddPlayer("josh", 21, "Male", "Blue");
            DataTracker.AddPlayer("madina", 21, "Male", "Blue");
            foreach (var x in DataTracker.Players)
            {
                ChoosePlayer.Items.Add(x.Name);
            }
            ChoosePlayer.SelectedItem = DataTracker.Players[0].Name;
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
            var q1 = from player in DataTracker.Players where player.Name == ChoosePlayer.Text select player;

            
            DataTracker.currentPlayer = q1.First(); 
            GameForm g = new GameForm();
            g.ShowDialog();
            //this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void NewPlayer_Click(object sender, EventArgs e)
        {
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
             var q1 = from player in DataTracker.Players where player.Name == ChoosePlayer.Text select player;

            CurrentForm = new AddEditPlayer(q1.First());
            CurrentForm.TopLevel = false;
            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            CurrentForm.Dock = DockStyle.Fill;
            this.RightPanel.Controls.Add(CurrentForm);
            CurrentForm.BringToFront();
            CurrentForm.Show();
        }
    }
    
}
