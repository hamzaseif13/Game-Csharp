using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Game
{
    public partial class MainMenu : Form
    {
        public Form CurrentForm=new Form();
        public string[] Players = new string[] {"hamza","josh"};
        public string CurrentPlayer { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            DataTracker.Players = new List<PlayerObj>();
            DataTracker.AddPlayer("hamza", 21, "male", "blue");
            if (Players.Length == 0)
            {
                MessageBox.Show("there is no players add new player ");
            }
            foreach(var x in DataTracker.Players)
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
            ChoosePlayer.SelectedItem = DataTracker.Players[0].Name;
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            //if (ChoosePlayer.SelectedItem.ToString() == "") MessageBox.Show("hs");
            string pl = ChoosePlayer.SelectedItem.ToString();
            DataTracker.currentPlayer = pl;
            GameForm g = new GameForm();
            g.ShowDialog();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void NewPlayer_Click(object sender, EventArgs e)
        {
            CurrentForm = new AddEditPlayer();
            CurrentForm.TopLevel = false;
            CurrentForm.FormBorderStyle = FormBorderStyle.None;
            CurrentForm.Dock = DockStyle.Fill;
            this.RightPanel.Controls.Add(CurrentForm);
            CurrentForm.BringToFront();
            CurrentForm.Show();
            /*
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
             */
        }

        private void ChoosePlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void History_Click(object sender, EventArgs e)
        {
        }
    }
    
}
