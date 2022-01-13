using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class DataTracker
    {
        public static MainMenu MainForm;

        public static PlayerObj currentPlayer;
        public static List<PlayerObj> Players;
        public static int NumberOfGames = 0;
        public static int HighestScore=0;
        public static int LowestScore=1000000;
        public static int MinimumDuration=1000000;
        public static int MaximumDuration=0;
        public static int TotalDuration=0;
        
        public static void AddPlayer (string name, int age, string gender, string color)
        {           
            PlayerObj lol = new PlayerObj(name, age, gender, color);
            Players.Add(lol);
            
        }       
    }
    public class PlayerObj
    {
        public string Name;
        public int Age;
        public string Gender;
        public string Color;
        public int HighestScore;
        public int LowestScore;
        public int MaxDuration;
        public int MinDuration;
        public List<Game> GamesHistory;
        public PlayerObj(string name,int age,string gender,string color)
        {           
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Color = color;
            this.GamesHistory = new List<Game>();
        }
        public void AddGame(int score, int level,int duration)
        {

            this.GamesHistory.Add(new Game(score,level,duration));
            var HighQuery  = from s in GamesHistory orderby s.GameScore descending select s.GameScore;
            HighestScore = HighQuery.First();
            var LowQuery = from s in GamesHistory orderby s.GameScore  select s.GameScore;
            LowestScore  = LowQuery.First();
            var Max= from s in GamesHistory orderby s.GameDuration descending select s.GameDuration;
            MaxDuration = Max.First();
            var Min = from s in GamesHistory orderby s.GameDuration select s.GameDuration;
            MinDuration = Min.First();

        }
        public void EditPlayer(string name, int age, string gender, string color)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Color = color;
            
            for(int j = 0; j < DataTracker.Players.Count; j++)
            {
                if (DataTracker.Players[j] == this)
                {
                    Swap(DataTracker.Players, j, DataTracker.Players.Count - 1);
                }
            }           
        }
        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

    }
   public class Game
    {
        public int GameScore;
        public int GameLevel;
        public string GameDate;
        public int GameDuration;
        public Game(int score,int level,int duration)
        {
            this.GameScore = score;
            this.GameDate =DateTime.Today.Day.ToString()+"/"+DateTime.Today.Month.ToString()+"/"+DateTime.Today.Year.ToString();
            this.GameLevel=level;
            this.GameDuration = duration;
        }
    }
}
