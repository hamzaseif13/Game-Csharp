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
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;
        int seconds = 3;
        int Level = 1;
        int Speed;
        PlayerGraphic Hamza;
        List<Projectile> Projectiles;
        List<Barrier> Barriers;
        private PlayerObj RealTimePlayer;
        public GameForm()
        {        
            InitializeComponent();           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Projectiles = new List<Projectile>();
            Barriers = new List<Barrier>();
            Hamza = new PlayerGraphic();
            this.Controls.Add(Hamza.Pic);
            RealTimePlayer = DataTracker.currentPlayer;
            PlayerLabel.Text += RealTimePlayer.Name;
            if(RealTimePlayer.Color=="Blue")this.BackColor = Color.FromArgb(52, 149, 235);
            else if(RealTimePlayer.Color=="Purple") this.BackColor = Color.FromArgb(111, 66, 184);
            else if (RealTimePlayer.Color == "Green") this.BackColor = Color.FromArgb(41, 196, 85);
            LevelLable.Text = "Level " + Level;
            Speed = 5;
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartTimer.Enabled = true;
            ClockTimer.Enabled = true;
        }        
        private void StartTimer_Tick(object sender, EventArgs e)
        {            
            Hamza.move(left, right, up, down,Speed);
            if (Level == 2 && Ticks%1000==0&& Barriers.Count < 3)
            {                            
                Barrier drop = new Barrier();
                Barriers.Add(drop);
                this.Controls.Add(drop.Pic);           
            }
            if (Ticks % 100 == 0)
            {
                Random rand = new Random();
                bool isFruit = rand.Next(1, 101) > 80 ? false : true;
                Projectile drop = new Projectile(isFruit);
                Projectiles.Add(drop);
                this.Controls.Add(drop.Pic);
            }
            int currentticks = Ticks;
            //check if the player hits a barrier
            for (int j = 0; j < Barriers.Count; j++)
            {
                if (IsEaten(Barriers[j].Pic.Width, Barriers[j].Pic.Height, Barriers[j].Pic.Location.X, Barriers[j].Pic.Location.Y))
                {
                    Score -= 10;
                    ScoreLabel.Text = "score : " + Score.ToString();  
                }
            }
            //checks if a player eat a fruit or a bomb
                for (int j = 0; j < Projectiles.Count; j++)
            {             
                Projectiles[j].Move();               
                if (IsEaten(Projectiles[j].Pic.Width, Projectiles[j].Pic.Height, Projectiles[j].Pic.Location.X, Projectiles[j].Pic.Location.Y))
                {
                    Score = Projectiles[j].IsFruit ? Score + 10 : Score - 10;
                    ScoreLabel.Text = "score : " + Score.ToString();
                    Projectiles[j].Pic.Visible = false;
                    Projectiles.RemoveAt(j);
                    j--;
                    continue;
                }
                if (Projectiles[j].Pic.Top == this.Height)
                {
                    Projectiles[j].Pic.Visible = false;
                    Projectiles.RemoveAt(j);
                    j--;
                }
            }
            Ticks++;
        }
        private bool IsEaten(int W,int H,int X,int Y)
        {


            double rect1x = X;
            double rect2x = Hamza.Pic.Location.X;
            double rect1y = Y;
            double rect2y = Hamza.Pic.Location.Y;
            double rect1w = W;
            double rect1h = H;
            double rect2h = 80;
            double rect2w = 80;
            if (rect1x < rect2x + rect2w &&
            rect1x + rect1w > rect2x &&
            rect1y < rect2y + rect2h &&
            rect1h + rect1y > rect2y) return true;
            return false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //left = x top = y

            if (e.KeyCode == Keys.A) left = true;
            if (e.KeyCode == Keys.D) right = true;
            if (e.KeyCode == Keys.W) up = true;
            if (e.KeyCode == Keys.S) down = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) left = false;
            if (e.KeyCode == Keys.D) right = false;
            if (e.KeyCode == Keys.W) up = false;
            if (e.KeyCode == Keys.S) down = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //LevelLable.Text = "Level " + Level.ToString();
            if (StartTimer.Enabled == true)
            {

                StartTimer.Enabled = false;
                ClockTimer.Enabled = false;
                return;
            }
            StartBtn.Text = "Puase";
            StartTimer.Enabled = true;
            ClockTimer.Enabled = true;
           
        }   
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            seconds--;
            TimeLabel.Text = "Time:" + seconds.ToString();
            if (seconds == 0) ChangeLevel();
            
        }
        private void ChangeLevel ()
        {
            Level=Level+1;
            StartTimer.Enabled = false;
            ClockTimer.Enabled = false;
            left = false;
            right = false;
            up = false;
            down = false;
            NextLevelForm nextLevelForm = new NextLevelForm(Level,RealTimePlayer.Name);
            nextLevelForm.ShowDialog();            
            seconds = 120;
            Score = 0;
            Ticks = 0;
            Speed = 6;
            LevelLable.Text = "Level " + Level;
            foreach (Projectile proj in Projectiles)
            {
                proj.Pic.Visible = false;

            }
            Projectiles.Clear();
            StartBtn.Text = "Start";
            Hamza.Pic.Location = new Point(470, 500);

        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    class PlayerGraphic
    {
        public PictureBox Pic;
        public PlayerGraphic()
        {
            Pic = new PictureBox()
            {
                Size = new Size(100, 100),
                Location = new Point(470, 500),
                ImageLocation = @"C:\Users\hamza\Desktop\project-assest\mouth.png",
                Name = "hamza",
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
        }
        public void move(bool left, bool right, bool up, bool down,int speed)
        {
            if (left && this.Pic.Left >= 0) this.Pic.Left -= speed;
            if (right && this.Pic.Left <= 935) this.Pic.Left += speed;
            if (up && this.Pic.Top >= 100) this.Pic.Top -= speed;
            if (down && this.Pic.Top <= 700) this.Pic.Top += speed;
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
            string[] imgs = new string[] { "banana.png", "apple.png", "strawberry.png" };
            Random rand = new Random();
            current = this.IsFruit ? current = imgs[rand.Next(0, 3)] : current = "bomb.png";
            Pic = new PictureBox()
            {
                Size = new Size(100, 100),
                Location = new Point(150 * rand.Next(0, 7), 0),
                ImageLocation = @"C:\Users\hamza\Desktop\project-assest\" + current,
                Name = "hamza",
                SizeMode = PictureBoxSizeMode.StretchImage
                
            };
        }
        public void Move()
        {
            Pic.Top += 2;
        }
    }
    class Barrier
    {
        public PictureBox Pic;
        public Barrier()
        {
            Random rand = new Random();
            Pic = new PictureBox()
            {
                Size = new Size(130,30),
                Location = new Point(rand.Next(20,900),rand.Next(200,800)),
                ImageLocation = @"C:\Users\hamza\Desktop\project-assest\brickwall.png" ,
                Name = "hamza",
                SizeMode = PictureBoxSizeMode.StretchImage

            };
        }
    }
}

