using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//new commit test
namespace Game
{
    public partial class Form1 : Form
    {
        int Score = 0;
        int Ticks = 0;
        int Total = 0;
        bool left = false;
        bool right = false;
        bool up = false;
        bool down= false;

        Player Hamza;
        List<Projectile> Projectiles;
        public Form1()
        {
            InitializeComponent();
         
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Projectiles = new List<Projectile>();
            Hamza = new Player();
            this.Controls.Add(Hamza.Pic);
            this.Select();
            
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartTimer.Enabled = true;
 
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            Hamza.move(left,right,up,down);
            if (Ticks % 75 == 0)
            {
                Projectile drop = new Projectile(true);
                Projectiles.Add(drop);
                this.Controls.Add(drop.Pic);
     
                Total++;
                TotalLabel.Text = Total.ToString();
            }
            for (int j = 0; j < Projectiles.Count; j++)
            {
                Projectiles[j].move();
                if (Projectiles[j].Pic.Top == 700)
                {
                    if (Projectiles[j].IsFruit) Score -= 10;
                    ScoreLabel.Text = Score.ToString();
                    Projectiles[j].Pic.Visible = false;
                    Projectiles.RemoveAt(j);
                    j--;
                }
            }
            Ticks++;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Left) left = true;
            if (e.KeyCode == Keys.Right) right = true;
            if (e.KeyCode == Keys.Up) up = true;
            if (e.KeyCode == Keys.Down) down= true;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) left = false;
            if (e.KeyCode == Keys.Right) right = false;
            if (e.KeyCode == Keys.Up) up = false;
            if (e.KeyCode == Keys.Down) down = false;
            
        }

       

       

        private void StartBtn_KeyDown(object sender, KeyEventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTimer.Enabled = true;
        }
    }
    class Player
    {
        public PictureBox Pic;
        public  Player()
        {
            
            Pic = new PictureBox()
            {
               
                Size = new Size(100, 100),
                Location = new Point(470,500),
                ImageLocation = @"C:\Users\hamza\Desktop\project-assest\mouth.png" ,
                Name = "hamza",
                SizeMode = PictureBoxSizeMode.StretchImage,
               
            };
        }
        public void move(bool left,bool right,bool up,bool down)
        {
            if (left) this.Pic.Left -= 4;
            if (right) this.Pic.Left += 4;
            if (up) this.Pic.Top -= 4;
            if (down) this.Pic.Top += 4;

        }
    }
    class Projectile
    {
        //sync test
        public PictureBox Pic;
        public bool IsFruit;
        public Projectile(bool IsFruit)
        {
            this.IsFruit = IsFruit;
            string current;
            string bomb = "bomb.png";
            string[] imgs = new string[] { "banana.png", "apple.png", "strawberry.png" };

            Random rand = new Random();
            if (this.IsFruit)
            {
                current = imgs[rand.Next(0, 3)];
            }
            else
            {
                current = bomb;
            }
            Pic = new PictureBox()
            {
                
                Size = new Size(75, 75),
                Location = new Point(150 * rand.Next(0, 7), 0),
                ImageLocation = @"C:\Users\hamza\Desktop\project-assest\" + current,
                Name = "hamza",
                SizeMode = PictureBoxSizeMode.StretchImage

            };
        }
        public void move()
        {
            Pic.Top += 2;
        }
    }
}
