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
        public Form curr;
        public AddEditPlayer()
        {
            
            
            InitializeComponent();
            Male.Checked = true;
            Green.Checked = true;
           
        }

       

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            int age = (int)Age.Value;
            string Gender = Male.Checked ? "Male" : "Female";
            string Color = Green.Checked ? "Green" : Blue.Checked ? "Blue" : "Purple";
            if (name == "") Error.Visible=true;
            else
            {
                DataTracker.AddPlayer(name, age, Gender, Color);
                DataTracker.startF.Refreshl();
                this.Close();
            }
            
           
        }
    }
}
