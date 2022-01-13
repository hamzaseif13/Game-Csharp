using Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//new commit test
namespace Game
{
   
    public partial class GameForm : Form
    {
        //string recorder = "";
        Dictionary<int, Dir> History;
        int Score = 0;
        int Ticks = 0;
        int fade = 0;
        //int ReplayTick = 0;
        int TotalDuration = 0;
        int TotalScore = 0;
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;
        int seconds = 120;
        int Level = 1;
        bool isHit = false;
        int hitIndex;
      
        int Speed;
        bool replay = false;
        Random rand = new Random();
        PlayerGraphic Hamza;
        List<Projectile> Projectiles;
        List<Barrier> Barriers;
        private PlayerObj RealTimePlayer;
        public GameForm(bool replay)
        {        
            InitializeComponent();
            this.replay = replay;
            if (replay)
            {
                StartTimer.Interval = 1000;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RealTimePlayer = DataTracker.currentPlayer;
            Projectiles = new List<Projectile>();
            Barriers = new List<Barrier>();
            Hamza = new PlayerGraphic(RealTimePlayer.Gender);
            this.Controls.Add(Hamza.Pic);           
            PlayerLabel.Text += RealTimePlayer.Name;
            if(RealTimePlayer.Color=="Blue")this.BackColor = Color.FromArgb(52, 149, 235);
            else if(RealTimePlayer.Color=="Purple") this.BackColor = Color.FromArgb(111, 66, 184);
            else if (RealTimePlayer.Color == "Green") this.BackColor = Color.FromArgb(41, 196, 85);
            LevelLable.Text = "Level " + Level;
            Speed = 5;
            History = new Dictionary<int, Dir>();
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            
            StartTimer.Enabled = true;
            ClockTimer.Enabled = true;
        }        
        private void StartTimer_Tick(object sender, EventArgs e)

        {

            if (replay) return;
            //check if player still hitting the barrier so it the score will only lose once 
            if (Level==2&&Barriers.Count>0)
            if (!IsEaten(Barriers[hitIndex].Pic.Width, Barriers[hitIndex].Pic.Height, Barriers[hitIndex].Pic.Location.X, Barriers[hitIndex].Pic.Location.Y)) isHit = false;
           
            Hamza.move(left, right, up, down,Speed);
            if (Level == 2 && Ticks%1000==0&& Barriers.Count < 3)
            {                            
                Barrier drop = new Barrier();
                Barriers.Add(drop);
                this.Controls.Add(drop.Pic);           
            }
            if (Ticks % 100 == 0)
            {
                string DropType;
                if (Level == 1) DropType = "fruit";
                else if (Level == 2)
                {
                    //stars and sandclock
                    DropType = rand.Next(0, 100) < 11 ? "reward" : "fruit";
                }
                else
                {
                    //stars and sandclock 
                    //bombs and skulls
                    int x = rand.Next(0, 100);
                    if (x < 80) DropType = "fruit";
                    else if (x < 90) DropType = "bomb";
                    else DropType = "reward";
                }
                Projectile drop = new Projectile(DropType);
                Projectiles.Add(drop);
                this.Controls.Add(drop.Pic);
            }
            //check if the player hits a barrier
            for (int j = 0; j < Barriers.Count; j++)
            {                
                if ((!isHit)&&IsEaten(Barriers[j].Pic.Width, Barriers[j].Pic.Height, Barriers[j].Pic.Location.X, Barriers[j].Pic.Location.Y))
                {
                    Score -= 10;
                    isHit = true;
                    hitIndex = j;
                    ScoreLabel.Text = "score : " + Score.ToString();
                    UpdateLabel.Text = "- 10 Points ";
                    UpdateLabel.Visible = true;
                    FadeTimer.Enabled = true;
                }
            }
            //checks if a player eat a fruit or a bomb
            for (int j = 0; j < Projectiles.Count; j++)
            {             
                Projectiles[j].Move();               
                if (IsEaten(Projectiles[j].Pic.Width, Projectiles[j].Pic.Height, Projectiles[j].Pic.Location.X, Projectiles[j].Pic.Location.Y))
                {
                    if (Projectiles[j].Type == "fruit")
                    {
                       
                        Score += 10;
                        UpdateLabel.Text = "+ 10 Points ";
                        UpdateLabel.Visible = true;
                        FadeTimer.Enabled = true;
                        

                    }
                    else if (Projectiles[j].Type == "bomb")
                    {
                        Score -= 10;
                         UpdateLabel.Text = "- 10 Points ";
                        UpdateLabel.Visible = true;
                        
                        FadeTimer.Enabled = true;
                    }
                    else
                    {
                        if (Projectiles[j].isStar)
                        {
                           
                            Score += 15;
                            UpdateLabel.Text = "+ 15 Points ";
                            UpdateLabel.Visible = true;

                            FadeTimer.Enabled = true;
                        }

                        else {
                           
                            seconds += 15;
                            UpdateLabel.Text = "+ 15 seconds ";
                            UpdateLabel.Visible = true;

                            FadeTimer.Enabled = true;
                        }
                        
                    }
                    ScoreLabel.Text = "Score : " + Score.ToString();
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
                //ReplayTimer.Enabled = false;
                ClockTimer.Enabled = false;
                return;
            }
            StartBtn.Text = "Puase";
            StartTimer.Enabled = true;
            //ReplayTimer.Enabled = true;
            ClockTimer.Enabled = true;
           
        }   
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            
            seconds--;
            TimeLabel.Text = "Time:" + seconds.ToString();
            if (seconds == 0||Score>300) ChangeLevel();
            
        }
        private void ChangeLevel ()
        {
            if (Level == 3)
            {
                NextLevelForm nextLevelForm1 = new NextLevelForm(Level - 1, RealTimePlayer.Name,true);
                nextLevelForm1.ShowDialog();
                
                return;
            }
            TimeLabel.Text = "Time:";
            Level=Level+1;
            StartTimer.Enabled = false;
            ClockTimer.Enabled = false;
            left = false;
            right = false;
            up = false;
            down = false;
            NextLevelForm nextLevelForm = new NextLevelForm(Level-1,RealTimePlayer.Name);
            nextLevelForm.ShowDialog();
            TotalScore += Score;
            TotalDuration += 120-seconds;
            seconds = 120;
            Score = 0;
            Ticks = 0;
            Speed = 6;
            LevelLable.Text = "Level " + Level;
            foreach (Projectile proj in Projectiles)
            {
                proj.Pic.Visible = false;
            }
            foreach (Barrier barrier in Barriers)
            {
                barrier.Pic.Visible = false;
            }
            Barriers.Clear();
            Projectiles.Clear();
            StartBtn.Text = "Start";
            Hamza.Pic.Location = new Point(470, 500);

        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextLevelBtn_Click(object sender, EventArgs e)
        {
            if (Level == 2) NextLevelBtn.Enabled = false; ;

            ChangeLevel();
        }
        private void FadeTimer_Tick(object sender, EventArgs e)
        {

            if (fade == 50)
            {
                UpdateLabel.Visible = false;
                UpdateLabel.Location = new Point(this.Width / 2 - 265 / 2, 130);
                fade = 0;
                FadeTimer.Enabled = false;
            }
            UpdateLabel.Location = new Point(UpdateLabel.Location.X, UpdateLabel.Location.Y-1);
            fade++;
           
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TotalScore = TotalScore == 0 ? Score : TotalScore;            
            TotalDuration = TotalDuration == 0 ? 120 - seconds : TotalDuration;            
            RealTimePlayer.AddGame(TotalScore,Level,TotalDuration);
            DataTracker.NumberOfGames++;
            DataTracker.TotalDuration += TotalDuration;

        }
      
        
    }

    public class Dir
    {
        public bool left, right, up, down;
        public Dir(bool up,bool right ,bool down,bool left)
        {
            this.left = left;
            this.right = right;
            this.down = down;
            this.up = up;
        }
        public override string ToString()
        {
            return ($"up:{up} right:{right} down:{down} left:{left}");
        }
    }

    class PlayerGraphic
    {
        public PictureBox Pic;
        public PlayerGraphic(string gender)
        {
            
            Pic = new PictureBox()
            {
                Size = new Size(150, 150),
                Location = new Point(470, 500),
                Name = "hamza",
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
            if (gender == "Male")
            {
                Pic.Image = Resources.male;
            }
            else
            {
                Pic.Size = new Size(120, 120);
                Pic.Image = Resources.female;
            }
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
        public PictureBox Pic;
        public string  Type;
        public bool isFruit;
        public bool isSand;
        public bool isStar;
        public Projectile(string type)
        {
            this.Type = type;
            Random rand = new Random();
            string current;            
            string[] fruits = new string[] { "banana.png", "apple.png", "strawberry.png" };
            string[] bomb = new string[] {"bomb.png" ,"skull.png"};
            string[] reward = new string[] {"star.png","sandclock.png" };
            if (this.Type == "fruit")
            {
                this.isFruit = true;
                current = fruits[rand.Next(0, 3)];

            }
            else if (this.Type == "reward")
            {
                current = reward[rand.Next(0, 2)];
                if (current == "sandclock.png") this.isSand = true;
                else this.isStar = true;
            }
            else
            {
                current = bomb[rand.Next(0, 2)];
                this.isFruit = false;
            }

            Pic = new PictureBox()
            {
                Size = new Size(100, 100),
                Location = new Point(150 * rand.Next(0, 7), 0),
                Name = "hamza",
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            if (current == "bomb.png") Pic.Image = Resources.bomb;
            if (current == "banana.png") Pic.Image = Resources.banana;
            if (current == "apple.png") Pic.Image = Resources.apple;
            if (current == "strawberry.png") Pic.Image = Resources.strawberry;
            if (current == "skull.png") Pic.Image = Resources.skull;
            if (current == "star.png") Pic.Image = Resources.star;
            if (current == "sandclock.png") Pic.Image = Resources.sandclock;
            
        }

        public bool IsFruit { get; internal set; }

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

