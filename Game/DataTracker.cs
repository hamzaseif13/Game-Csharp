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
        public static MainMenu startF;

        public static string currentPlayer;
        public static List<PlayerObj> Players;
 
        
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
        public PlayerObj(string name,int age,string gender,string color)
        {
            
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Color = color;
           

        }

    }
}
