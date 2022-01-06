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
    public partial class AddEditPlayer : Form
    {
        
        private PlayerObj Current;
        public AddEditPlayer(PlayerObj CurrentPlayer)
        {
            
            InitializeComponent();
            if (CurrentPlayer == null)
            {
                Male.Checked = true;
                Green.Checked = true;
                Current = null;                
            }
            else
            {
                Current = CurrentPlayer;
                Age.Value=CurrentPlayer.Age;
                NameBox.Text = CurrentPlayer.Name;
                if (CurrentPlayer.Color == "Blue") Blue.Checked = true;
                if (CurrentPlayer.Color == "Green") Green.Checked = true;
                if (CurrentPlayer.Color == "Purple") Purple.Checked = true;
                if (CurrentPlayer.Gender == "Male") Male.Checked = true;
                if (CurrentPlayer.Gender == "Female") Female.Checked = true;
            }
              
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            int age = (int)Age.Value;
            string Gender = Male.Checked ? "Male" : "Female";
            string Color = Green.Checked ? "Green" : Blue.Checked ? "Blue" : "Purple";
            if (name=="") Error.Visible=true;
            else
            {
                if (Current == null) DataTracker.AddPlayer(name, age, Gender, Color);
                else Current.EditPlayer(name,age, Gender, Color);               
                DataTracker.MainForm.Refreshl();
                this.Close();
            }            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
