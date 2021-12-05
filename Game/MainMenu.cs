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
        public string[] Players = new string[] {"hamza","josh"};
        public string CurrentPlayer { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            if (Players.Length == 0)
            {
                MessageBox.Show("there is no players add new player ");
            }
            foreach(var x in Players)
            {
                ChoosePlayer.Items.Add(x);

            }
            ChoosePlayer.SelectedItem = Players[0];
        }

        private void StartGame_Click(object sender, EventArgs e)
        {


            //if (ChoosePlayer.SelectedItem.ToString() == "") MessageBox.Show("hs");
            string pl = ChoosePlayer.SelectedItem.ToString();
                DataTracker.currentPlayer = pl;

           
           // this.Close();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPlayer_Click(object sender, EventArgs e)
        {
            new AddEditPlayer().ShowDialog();
        }
    }
    
}
