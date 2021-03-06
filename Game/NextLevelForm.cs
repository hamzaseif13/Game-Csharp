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
    public partial class NextLevelForm : Form
    {
        public NextLevelForm(int level, string name, bool finished = false)
        {
            
            InitializeComponent();
            if (!finished) 
            label1.Text = $"You just finished level {level}\n    Congrats {name}";
            else
            {
                label1.Text = $"You just finished the whole game\n" +
                    $"               congrats {name} ";

            }
        }

        private void GoNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
