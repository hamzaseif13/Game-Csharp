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
    public partial class GameForm : Form
    {
        int Score = 0;
        int Ticks = 0;
        int Total = 0;
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;
        int seconds = 0;
        int minutes = 0;
        string curr;
        Player Hamza;
        List<Projectile> Projectiles;
        public GameForm()
        {
           
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Projectiles = new List<Projectile>();
            Hamza = new Player();
            this.Controls.Add(Hamza.Pic);
            PlayerLabel.Text += DataTracker.currentPlayer;
           
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartTimer.Enabled = true;
            ClockTimer.Enabled = true;
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            Hamza.move(left, right, up, down);
            if (Ticks % 100 == 0)
            {
                Random rand = new Random();
                bool isFruit = rand.Next(1, 101) > 80 ? false : true;
                Projectile drop = new Projectile(isFruit);
                Projectiles.Add(drop);
                this.Controls.Add(drop.Pic);
                Total=isFruit?Total+1:Total;
                TotalLabel.Text = Total.ToString();
            }
            for (int j = 0; j < Projectiles.Count; j++)
            {
                Projectiles[j].move();
                if (IsEaten(Projectiles[j]))
                {
                    Score = Projectiles[j].IsFruit ? Score + 10 : Score - 10;
                    ScoreLabel.Text = "score : "+Score.ToString();
                    Projectiles[j].Pic.Visible = false;
                    Projectiles.RemoveAt(j);
                    j--;
                    continue;
                }

                if (Projectiles[j].Pic.Top == this.Height)
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

        private bool IsEaten(Projectile pr)
        {
            double rect1x = pr.Pic.Location.X;
            double rect2x = Hamza.Pic.Location.X;
            double rect1y = pr.Pic.Location.Y;
            double rect2y = Hamza.Pic.Location.Y;
            double rect1w = 80;
            double rect2w = 80;
            double rect1h = 80;
            double rect2h = 80;
            if (rect1x < rect2x + rect2w &&
            rect1x + rect1w > rect2x &&
            rect1y < rect2y + rect2h &&
            rect1h + rect1y > rect2y) return true;
            return false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //left = x top = y
            if (e.KeyCode == Keys.Left) left = true;
            if (e.KeyCode == Keys.Right) right = true;
            if (e.KeyCode == Keys.Up) up = true;
            if (e.KeyCode == Keys.Down) down = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) left = false;
            if (e.KeyCode == Keys.Right) right = false;
            if (e.KeyCode == Keys.Up) up = false;
            if (e.KeyCode == Keys.Down) down = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartTimer.Enabled = true;
            ClockTimer.Enabled = true;
            //button1.Visible = false;
            button1.Enabled = false;
           
        }

        

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            if (seconds == 59)
            {
                seconds = 0;
                minutes++;
            }
            else
            {
                seconds++;
            }
            string mnt=""+minutes;
            if (minutes < 10) mnt = "0" + minutes;
            string sc = "" + seconds;
            if (seconds < 10) sc = "0" + seconds;

            TimeLabel.Text = $"Time {mnt} : {sc}";
        }
    }
    class Player
    {
        public PictureBox Pic;
        public Player()
        {
            Pic = new PictureBox()
            {
                Size = new Size(100, 100),
                Location = new Point(470, 500),
                ImageLocation = @"C:\Users\hamza\Desktop\project-assest\mouth.png",
                Name = "hamza",
                SizeMode = PictureBoxSizeMode.StretchImage,               
            };
        }
        public void move(bool left, bool right, bool up, bool down)
        {
            if (left && this.Pic.Left >= 0) this.Pic.Left -= 5;
            if (right && this.Pic.Left <= 935) this.Pic.Left += 5;
            if (up && this.Pic.Top >= 0) this.Pic.Top -= 5;
            if (down && this.Pic.Top <= 700) this.Pic.Top += 5;
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
            current = this.IsFruit ? current = imgs[rand.Next(0, 3)] : current = bomb;
            Pic = new PictureBox()
            {
                Size = new Size(100, 100),
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
